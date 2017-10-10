﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace CGLab6
{
    public class LockBitmap
    {
        Bitmap source = null;
        IntPtr ptr = IntPtr.Zero;
        BitmapData bitmapData = null;

        public byte[] Pixels { get; set; }
        public int Depth { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public LockBitmap(Bitmap source)
        {
            this.source = source;
        }

        public void LockBits()
        {
            Width = source.Width;
            Height = source.Height;

            int PixelCount = Width * Height;

            Rectangle rect = new Rectangle(0, 0, Width, Height);

            Depth = System.Drawing.Bitmap.GetPixelFormatSize(source.PixelFormat);

            if (Depth != 8 && Depth != 24 && Depth != 32)
            {
                throw new ArgumentException("Only 8, 24 and 32 bpp images are supported.");
            }

            bitmapData = source.LockBits(rect, ImageLockMode.ReadWrite,
                                         source.PixelFormat);

            int step = Depth / 8;
            Pixels = new byte[PixelCount * step];
            ptr = bitmapData.Scan0;

            Marshal.Copy(ptr, Pixels, 0, Pixels.Length);
        }

        public void UnlockBits()
        {
            Marshal.Copy(Pixels, 0, ptr, Pixels.Length);

            source.UnlockBits(bitmapData);
        }

        public Color GetPixel(int x, int y)
        {
            Color clr = Color.Empty;

            int cCount = Depth / 8;

            int i = ((y * Width) + x) * cCount;

            if (i > Pixels.Length - cCount)
                throw new IndexOutOfRangeException();

            if (Depth == 32)
            {
                byte b = Pixels[i];
                byte g = Pixels[i + 1];
                byte r = Pixels[i + 2];
                byte a = Pixels[i + 3]; // a
                clr = Color.FromArgb(a, r, g, b);
            }
            if (Depth == 24)
            {
                byte b = Pixels[i];
                byte g = Pixels[i + 1];
                byte r = Pixels[i + 2];
                clr = Color.FromArgb(r, g, b);
            }
            if (Depth == 8)
            {
                byte c = Pixels[i];
                clr = Color.FromArgb(c, c, c);
            }
            return clr;
        }

        public void SetPixel(int x, int y, Color color)
        {
            int cCount = Depth / 8;

            int i = ((y * Width) + x) * cCount;

            if (Depth == 32)
            {
                Pixels[i] = color.B;
                Pixels[i + 1] = color.G;
                Pixels[i + 2] = color.R;
                Pixels[i + 3] = color.A;
            }
            if (Depth == 24)
            {
                Pixels[i] = color.B;
                Pixels[i + 1] = color.G;
                Pixels[i + 2] = color.R;
            }
            if (Depth == 8)
            {
                Pixels[i] = color.B;
            }
        }
    }
}
