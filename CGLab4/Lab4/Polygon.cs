using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CGLab6
{
    public class Pair<T, U>
    {
        public Pair()
        {
        }

        public Pair(T first, U second)
        {
            this.First = first;
            this.Second = second;
        }

        public T First { get; set; }
        public U Second { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1}", First, Second);
        }
    };

    public enum PolygonChangeType { PointsChanged, EdgesChanged }

    public class PolygonChangedEventArgs
    {
        public PolygonChangedEventArgs(PolygonChangeType t) { Type = t; }
        public PolygonChangeType Type { get; private set; }
    }

    public class Polygon
    {
        public delegate void ChangedEventHandler(object sender, PolygonChangedEventArgs e);
        public event ChangedEventHandler ChangedEvent;

        List<PointF> points = new List<PointF>();
        List<Pair<int, int>> edges = new List<Pair<int, int>>();

        public List<PointF> Points { get { return points; } }
        public List<Pair<int, int>> Edges { get { return edges; } }

        public void AddEdge(PointF p1, PointF p2)
        {
            points.Add(p1); points.Add(p2);
            edges.Add(new Pair<int, int>(points.Count - 1, points.Count - 2));
            RaiseChangedEvent(PolygonChangeType.EdgesChanged);
        }

        public void AddPoint(PointF p)
        {
            points.Add(p);
            RaiseChangedEvent(PolygonChangeType.PointsChanged);
        }

        public void RemovePointAt(int index)
        {
            points.RemoveAt(index);
            edges.RemoveAll(x => x.First == index || x.Second == index);
            for (int i = 0; i < edges.Count; ++i)
            {
                edges[i].First = edges[i].First >= index ? edges[i].First - 1 : edges[i].First;
                edges[i].Second = edges[i].Second >= index ? edges[i].Second - 1 : edges[i].Second;
            }
            RaiseChangedEvent(PolygonChangeType.EdgesChanged);
            RaiseChangedEvent(PolygonChangeType.PointsChanged);
        }

        public void RemoveEdgeAt(int i)
        {
            edges.RemoveAt(i);
            RaiseChangedEvent(PolygonChangeType.EdgesChanged);
        }

        public void CreateEdgesFromPoints()
        {
            if (points.Count < 2)
                return;

            edges.Clear();
            for (int i = 0; i < points.Count - 1; ++i)
            {
                edges.Add(new Pair<int, int>(i, i + 1));
            }
            edges.Add(new Pair<int, int>(points.Count - 1, 0));
            RaiseChangedEvent(PolygonChangeType.EdgesChanged);
        }

        public void Translate(float dx, float dy)
        {
            for (int i = 0; i < points.Count; ++i)
            {
                AffineTransformer t = new AffineTransformer(AffineMatrix.FromPoint(points[i]));
                t.Translate(dx, dy);
                points[i] = t.GetResult().ToPoint();
            }
            RaiseChangedEvent(PolygonChangeType.PointsChanged);
        }

        public void Rotate(float angle, PointF point)
        {
            for (int i = 0; i < points.Count; ++i)
            {
                AffineTransformer t = new AffineTransformer(AffineMatrix.FromPoint(points[i]));
                t.Translate(-point.X, -point.Y);
                t.Rotate(angle);
                t.Translate(point.X, point.Y);
                points[i] = t.GetResult().ToPoint();
            }
            RaiseChangedEvent(PolygonChangeType.PointsChanged);
        }

        public void Scale(float width, float height)
        {
            float sumX = 0, sumY = 0;
            for (int i = 0; i < points.Count; ++i)
            {
                sumX += points[i].X;
                sumY += points[i].Y;
            }
            PointF transPoint = new PointF(sumX / points.Count, sumY / points.Count);
            for (int i = 0; i < points.Count; ++i)
            {
                AffineTransformer t = new AffineTransformer(AffineMatrix.FromPoint(points[i]));
                t.Translate(-transPoint.X, -transPoint.Y);
                t.Scale(width, height);
                t.Translate(transPoint.X, transPoint.Y);
                points[i] = t.GetResult().ToPoint();
            }
            RaiseChangedEvent(PolygonChangeType.PointsChanged);
        }

        void RaiseChangedEvent(PolygonChangeType t)
        {
            if (ChangedEvent != null)
                ChangedEvent(this, new PolygonChangedEventArgs(t));
        }
    }
}
