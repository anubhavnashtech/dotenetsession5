using System;

namespace abstractclasses
{
    public class Shape
    {
        public int Height { get; set; }

        public int Width { get; set; }

        public virtual void Draw()
        {

        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
           System.Console.WriteLine("Draw a circle");
        }
    }

    public class Rectangle : Shape
    {

    }




    public class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();

            circle.Draw();

            var rectangle = new Rectangle();

            rectangle.Draw();
        }
    }
}
