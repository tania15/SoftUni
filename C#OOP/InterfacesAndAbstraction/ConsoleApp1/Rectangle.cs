using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public Rectangle(int w, int h)
        {
            Width = w;
            Height = h;
        }

        //public void Draw()
        //{
        //    DrawLine(this.Width, '*', '*');

        //    for (int i = 1; i < this.Height - 1; ++i)
        //    {
        //        DrawLine(this.Width, '*', ' ');
        //    }

        //    DrawLine(this.Width, '*', '*');
        //}

        //private void DrawLine(int width, char end, char mid)
        //{
        //    Console.WriteLine(end);

        //    for (int i = 1; i < width - 1; ++i)
        //    {
        //        Console.WriteLine(mid);
        //    }

        //    Console.WriteLine(end);
        //}

        public void Draw()
        {

            DrawLine(this.width, '*', '*');

            for (int i = 1; i < this.height - 1; ++i)

                DrawLine(this.width, '*', ' ');

            DrawLine(this.width, '*', '*');
        }

        private void DrawLine(int width, char end, char mid)
        {

            Console.Write(end);

            for (int i = 1; i < width - 1; ++i)

                Console.Write(mid);

            Console.WriteLine(end);
        }
    }
}
