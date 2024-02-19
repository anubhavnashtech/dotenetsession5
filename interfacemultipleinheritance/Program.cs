using System;



namespace interfacemultipleinheritance
{


    public class TextBox: UIControl
    {
        
    }

    public class UIControl
    {
        public int Id { get; set; }

        public int Height { get; set; } 

        public int Width { get; set; }

        public Size Size { get; set; }

        public virtual void Draw()
        {

        }

        public void Focus()
        {
            System.Console.WriteLine("Recieved Focus..");
        }

    }

    public class Size
    {
        public int Test { get; set; }
    }

    public interface IDraggable
    {
        void Drag();
    }

    public interface IDroppable
    {
        void Drop();
    }





    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
