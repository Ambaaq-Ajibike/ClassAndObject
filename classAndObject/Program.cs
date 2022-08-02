using System;

namespace classAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Car price = new Car();
            price.SetPrice(-1);
            Console.WriteLine($"{price.GetPrice()}");
        }
    }
}
