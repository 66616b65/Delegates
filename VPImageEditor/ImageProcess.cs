using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VPImageEditor
{
    public class ImageProcess
    {
        static byte[] BmpToArray(Bitmap source)
        {
            var result = new byte[source.Width * source.Height * 3];
            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    result[3 * (j * source.Width + i) + 0] = source.GetPixel(i, j).R;
                    result[3 * (j * source.Width + i) + 1] = source.GetPixel(i, j).G;
                    result[3 * (j * source.Width + i) + 2] = source.GetPixel(i, j).B;
                }
            }
            return result;
        }

        static Bitmap ArrayToBmp(byte[] source, int width, int height)
        {
            var result = new Bitmap(width, height);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    result.SetPixel(i, j, Color.FromArgb(source[3 * (j * width + i) + 0],
                       source[3 * (j * width + i) + 1],
                       source[3 * (j * width + i) + 2]));
                }
            }
            return result;
        }

        static int RgbRange(int value)
        {
            if (value < 0)
            {
                value = 0;
            }
            else
            {
                if (value > 255)
                {
                    value = 255;
                }
            }
            return value;
        }

        public static Bitmap FilterImage(Bitmap source)
        {
            byte[] src = BmpToArray(source);
            byte[] res = new byte[src.Length];

            //var result = new Bitmap(source.Width, source.Height);

            int[,] matrix = new int[3, 3] { { 0, -1, 0 }, { -1, 5, -1 }, { 0, -1, 0 } };

            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    var r = 0;
                    var g = 0;
                    var b = 0;
                    //    var count = 0;
                    for (int n = 0; n < 3; n++)
                    {
                        for (int m = 0; m < 3; m++)
                        {
                            if (((j - 1 + m) < 0) || ((j - 1 + m) == source.Height)
                               || ((i - 1 + n) < 0) || ((i - 1 + n) == source.Width))
                            {
                                continue;
                            }

                            r += src[3 * (source.Width * (j - 1 + m) + (i - 1 + n)) + 0] * matrix[n, m];
                            g += src[3 * (source.Width * (j - 1 + m) + (i - 1 + n)) + 1] * matrix[n, m];
                            b += src[3 * (source.Width * (j - 1 + m) + (i - 1 + n)) + 2] * matrix[n, m];
                            //r += source.GetPixel(i - 1 + n, j - 1 + m).R * matrix[n, m];
                            //g += source.GetPixel(i - 1 + n, j - 1 + m).G * matrix[n, m];
                            //b += source.GetPixel(i - 1 + n, j - 1 + m).B * matrix[n, m];
                            // count++;
                        }

                    }
                    r = RgbRange(r);
                    g = RgbRange(g);
                    b = RgbRange(b);

                    res[3 * (source.Width * j + i) + 0] = (byte)r;
                    res[3 * (source.Width * j + i) + 1] = (byte)g;
                    res[3 * (source.Width * j + i) + 2] = (byte)b;
                    //   result.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
            return ArrayToBmp(res, source.Width, source.Height);
            //return result;
        }
    }
}
