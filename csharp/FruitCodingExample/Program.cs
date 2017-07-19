using System;

namespace FruitCodingExample
{
    public abstract class Fruit
    {
        public virtual void GetColor()
        {
            Console.Write("Unknown");
        }
    }

    public class Apple : Fruit
    {
        public override void GetColor()
        {
            Console.WriteLine("Red");
        }
    }

    public class Banana : Fruit
    {
        public new void GetColor()
        {
            Console.WriteLine("Yellow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Apple a = new Apple();
            Banana b = new Banana();

            a.GetColor();
            b.GetColor();

            DisplayFruitColor(a);
            DisplayFruitColor(b);
        }

        private static void DisplayFruitColor(Fruit f)
        {
            f.GetColor();
        }
    }
}
