using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGLab6
{
    public partial class AffineTransformation: Form
    {
        Polygon polygon = new Polygon();
        Bitmap drawArea;
        Graphics gr;
        AffineDialog dialog;

        public AffineTransformation()
        {
            InitializeComponent();
            InitHandlers();
            RefreshGraphics();
            dialog = new AffineDialog(this);
        }

        private void InitHandlers()
        {
            polygon.ChangedEvent += new Polygon.ChangedEventHandler(polygon_Changed);
        }

        private void RefreshGraphics()
        {
            drawArea = new Bitmap(drawWind.Width, drawWind.Height);
            gr = Graphics.FromImage(drawArea);
            gr.Clear(Color.White);
        }

        private void DrawPolygon()
        {
            gr.Clear(Color.White);
            for (int i = 0; i < polygon.Edges.Count; ++i)
                gr.DrawLine(Pens.Black, polygon.Points[polygon.Edges[i].First], polygon.Points[polygon.Edges[i].Second]);

            for (int i = 0; i < polygon.Points.Count; ++i)
                gr.DrawRectangle(Pens.Black, polygon.Points[i].X, polygon.Points[i].Y, 1, 1);

            drawWind.Invalidate();
        }

        private void drawWind_MouseDown(object sender, MouseEventArgs e)
        {
            polygon.AddPoint(new PointF(e.X, e.Y));
        }

        private void drawPolygonButton_Click(object sender, EventArgs e)
        {
            polygon.CreateEdgesFromPoints();
            DrawPolygon();
        }

        private void drawWind_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(drawArea, 0, 0);
        }

        private void pointsList_KeyDown(object sender, KeyEventArgs e)
        {
            int ind = pointsList.SelectedIndex;
            if (e.KeyCode == Keys.Delete && ind > -1)
            {
                polygon.RemovePointAt(ind);
                pointsList.SelectedIndex = ind < pointsList.Items.Count ? ind : pointsList.Items.Count - 1;
                e.Handled = true;
            }
        }

        private void polygon_Changed(object sender, PolygonChangedEventArgs e)
        {
            switch (e.Type)
            {
                case PolygonChangeType.PointsChanged:
                    pointsList.Items.Clear();
                    for (int i = 0; i < polygon.Points.Count; ++i)
                        pointsList.Items.Add(string.Format("{0}: {1}", i.ToString(), polygon.Points[i].ToString()));
                    break;
                case PolygonChangeType.EdgesChanged:
                    edgesList.Items.Clear();
                    foreach (Pair<int, int> x in (sender as Polygon).Edges)
                        edgesList.Items.Add(x);
                    break;
                default:
                    break;
            }
            DrawPolygon();
        }

        private void edgesList_KeyDown(object sender, KeyEventArgs e)
        {
            int ind = edgesList.SelectedIndex;
            if (e.KeyCode == Keys.Delete && ind > -1)
            {
                polygon.RemoveEdgeAt(ind);
                edgesList.SelectedIndex = ind < edgesList.Items.Count ? ind : edgesList.Items.Count - 1;
                e.Handled = true;
            }
        }

        void LoadDialog()
        {
            dialog.rotatePoint.Items.Clear();
            for (int i = 0; i < pointsList.Items.Count; ++i)
                dialog.rotatePoint.Items.Add(pointsList.Items[i]);
            dialog.rotatePoint.SelectedIndex = 0;
        }

        private void affineDialogButton_Click(object sender, EventArgs e)
        {
            LoadDialog();
            dialog.Show();
        }

        public void ApplyTransformation()
        {
            polygon.Scale((float)dialog.scaleX.Value, (float)dialog.scaleY.Value);
            polygon.Rotate((float)dialog.rotateAngle.Value, polygon.Points[dialog.rotatePoint.SelectedIndex]);
            polygon.Translate((float)dialog.translateX.Value, (float)dialog.translateY.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            polygon.AddPoint(new PointF((int)xPoint.Value, (int)yPoint.Value));
        }
    }
}
