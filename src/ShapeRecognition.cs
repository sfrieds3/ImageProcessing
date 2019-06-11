using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            string projectDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string remainPath = "\\assets\\square\\BlackSquare.png";
            string square = String.Concat(projectDir, remainPath);

            Console.WriteLine(square);

            Bitmap bitmap = new Bitmap(square);

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
