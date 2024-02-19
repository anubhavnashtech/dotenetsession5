using System;

namespace methodoverridingbase
{
    public class Position
    {

    }

    public enum ShapeType
    {
        Circle,
        Rectangle, 
        Triangle
    }


    public class Shape
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public Position  Position { get; set; }

        public ShapeType Type { get; set; }
    }

    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {

            foreach(var shape in shapes)
            {

                switch(shape.Type)
                {
                    case ShapeType.Circle:
                    System.Console.WriteLine("Draw a circle");
                    break;

                    case ShapeType.Rectangle:
                    System.Console.WriteLine("Draw a rectangle");
                    break;

                   case ShapeType.Triangle:
                    System.Console.WriteLine("Draw a Triangle");
                    break;
                }
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape> ();

            shapes.Add(new Shape(){Height = 100, Width =140, Type = ShapeType.Circle});
            shapes.Add(new Shape(){Height = 100, Width =140, Type = ShapeType.Rectangle});


            var canvas = new Canvas();

            canvas.DrawShapes(shapes);
        }
    }
}
