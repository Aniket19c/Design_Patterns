using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Design_Patterns
{

    interface IColor
    {
        void ApplyColor();
    }

    class RedColor : IColor
    {
        public void ApplyColor()
        {
            Console.WriteLine("Applying Red Color");
        }
    }

    class BlueColor : IColor
    {
        public void ApplyColor()
        {
            Console.WriteLine("Applying Blue Color");
        }
    }

    abstract class Shape
    {
        protected IColor color;

        protected Shape(IColor color)
        {
            this.color = color;
        }

        public abstract void Draw();
    }

    class Circle : Shape
    {
        public Circle(IColor color) : base(color) { }

        public override void Draw()
        {
            Console.Write("Drawing Circle with ");
            color.ApplyColor();
        }
    }

    class Square : Shape
    {
        public Square(IColor color) : base(color) { }

        public override void Draw()
        {
            Console.Write("Drawing Square with ");
            color.ApplyColor();
        }
    }

    class Program
    {
        static void Main()
        {
            Shape redCircle = new Circle(new RedColor());
            redCircle.Draw();

            Shape blueSquare = new Square(new BlueColor());
            blueSquare.Draw();
            Console.ReadLine();
        }
    }

}
