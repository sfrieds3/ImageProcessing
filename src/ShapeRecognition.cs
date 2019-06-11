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

            string squarePath = "\\assets\\square\\BlackSquare.png";
            string square = String.Concat(projectDir, squarePath);
            Bitmap squareBitmap = new Bitmap(square);

            string circlePath = "\\assets\\circle\\BlackCircle.png";
            string circle = String.Concat(projectDir, circlePath);
            Bitmap circleBitmap = new Bitmap(circle);

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(String.Concat(projectDir, "\\square.txt")))
            {
                for (int i = 0; i < squareBitmap.Width; i++)
                {
                    file.WriteLine("LINE {0}", i);
                    for (int j = 0; j < squareBitmap.Height; j++)
                    {
                        Color color = squareBitmap.GetPixel(i, j);
                        file.WriteLine(color);
                    }
                }
            };

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(String.Concat(projectDir, "\\circle.txt")))
            {
                for (int i = 0; i < circleBitmap.Width; i++)
                {
                    file.WriteLine("LINE {0}", i);
                    for (int j = 0; j < circleBitmap.Height; j++)
                    {
                        Color color = circleBitmap.GetPixel(i, j);
                        file.WriteLine(color);
                    }
                }
            };
        }
    }
}
