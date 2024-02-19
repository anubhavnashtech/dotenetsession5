using System;

namespace methodoverriding
{
    public class Position
    {

    }

    public class Circle : Shape
    {

        public override void Draw()
        {
            System.Console.WriteLine("This is a circle");
        }

    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("This is a rectangle");
        }

    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("This is a Triangle");
        }

    }

    public class Shape
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public Position  Position { get; set; }

        public virtual void Draw()
        {

        }

        public void Copy()
        {

        }

    }

    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {

            foreach(var shape in shapes)
            {

                shape.Draw();

            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();

            shapes.Add(new Circle());

            shapes.Add(new Rectangle());

             shapes.Add(new Triangle());

            var canvas = new Canvas();

            canvas.DrawShapes(shapes);
        }
    }
}
