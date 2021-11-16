using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bitmap bitmap = new Bitmap(@"C:\Users\Dev\Downloads/secret.png");
            alterBitMap(bitmap);
            bitmap.Save(@"C:\Users\Dev\Downloads/secret2.png", ImageFormat.Png);
        }

        public static void alterBitMap(Bitmap bmp)
        {
            int redColor = 0;

            for (int i = 0; i < bmp.Height; i++)
            {
                
                for (int j = 0; j < bmp.Width; j++)
                {
                    redColor = bmp.GetPixel(j, i).R;
                    bmp.SetPixel(j, i, Color.FromArgb(0, redColor, 0, 0));
                }
            }
        }
    }
}
