using System;

namespace abstractclassesdemo
{
    public abstract class Shape
    {
        public int Height { get; set; }

        public int Width { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            System.Console.WriteLine("Copy the object");
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
       public override void Draw()
        {
           System.Console.WriteLine("Draw a rectange"); 
        }

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
