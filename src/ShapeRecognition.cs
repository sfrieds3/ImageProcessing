using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace ArtificialApplication
{
    class ShapeRecognition
    {
        ShapeRecognition()
        {

        }

        ~ShapeRecognition()
        {

        }

        public static void ReadImage()
        {
            Bitmap bitmap = new Bitmap(@"C:\dev\AI\assets\square\BlackSquare.png");

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color color = bitmap.GetPixel(i, j);
                    Console.WriteLine("color: {0}", color);
                }
            }
        }
    }
}
