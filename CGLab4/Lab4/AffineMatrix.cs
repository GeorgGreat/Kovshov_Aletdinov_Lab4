using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CGLab6
{
    public class AffineMatrix
    {
        public List<List<float>> Data { get; private set; }
        public int Rows { get; private set; }
        public int Columns { get; private set; }

        public AffineMatrix(int rows, int cols)
        {
            Rows = rows; Columns = cols;
            Data = new List<List<float>>();
            for (int i = 0; i < rows; ++i)
            {
                Data.Add(new List<float>());
                for (int j = 0; j < cols; ++j)
                    Data[i].Add(0f);
            }
        }

        public static AffineMatrix MultMatrices(AffineMatrix A, AffineMatrix B)
        {
            AffineMatrix C = new AffineMatrix(A.Rows, B.Columns);
            for (int i = 0; i < A.Rows; i++)
                for (int j = 0; j < B.Columns; j++)
                    for (int k = 0; k < A.Columns; k++)
                        C.Data[i][j] += A.Data[i][k] * B.Data[k][j];
            return C;
        }

        public static AffineMatrix FromPoint(PointF p)
        {
            AffineMatrix res = new AffineMatrix(3, 1);

            res.Data[0][0] = p.X;
            res.Data[1][0] = p.Y;
            res.Data[2][0] = 1;
            return res;
        }

        public PointF ToPoint()
        {
            if (Columns == 1 && Rows == 3)
                return new PointF(Data[0][0], Data[1][0]);
            else
                throw new InvalidCastException();
        }

        public static AffineMatrix TranslateMatrix(float dx, float dy)
        {
            AffineMatrix res = new AffineMatrix(3, 3);

            res.Data[0][0] = 1; res.Data[0][1] = 0; res.Data[0][2] = dx;
            res.Data[1][0] = 0; res.Data[1][1] = 1; res.Data[1][2] = dy;
            res.Data[2][0] = 0; res.Data[2][1] = 0; res.Data[2][2] = 1;

            return res;
        }

        public static AffineMatrix RotateMatrix(float angle)
        {
            AffineMatrix res = new AffineMatrix(3, 3);

            double a = Math.PI * angle / 180; 
            res.Data[0][0] = (float)Math.Cos(a); res.Data[0][1] = (float)Math.Sin(a); res.Data[0][2] = 0;
            res.Data[1][0] = (float)-Math.Sin(a); res.Data[1][1] = (float)Math.Cos(a); res.Data[1][2] = 0;
            res.Data[2][0] = 0; res.Data[2][1] = 0; res.Data[2][2] = 1;

            return res;
        }

        public static AffineMatrix ScaleMatrix(float width, float height)
        {
            AffineMatrix res = new AffineMatrix(3, 3);

            res.Data[0][0] = width; res.Data[0][1] = 0; res.Data[0][2] = 0;
            res.Data[1][0] = 0; res.Data[1][1] = height; res.Data[1][2] = 0;
            res.Data[2][0] = 0; res.Data[2][1] = 0; res.Data[2][2] = 1;

            return res;
        }
    }

    public class AffineTransformer
    {
        AffineMatrix matrix;

        public AffineTransformer(AffineMatrix m) { matrix = m; }

        public void Translate(float dx, float dy)
        {
            matrix = AffineMatrix.MultMatrices(AffineMatrix.TranslateMatrix(dx, dy), matrix);
        }

        public void Rotate(float angle)
        {
            matrix = AffineMatrix.MultMatrices(AffineMatrix.RotateMatrix(angle), matrix);
        }

        public void Scale(float width, float height)
        {
            matrix = AffineMatrix.MultMatrices(AffineMatrix.ScaleMatrix(width, height), matrix);
        }

        public AffineMatrix GetResult()
        {
            return matrix;
        }
    }
}
