using System;

namespace obj
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle area =  new Shape();
            area.width = 7;
            area.breadth = 2;
            area.height = 4;
            Console.WriteLine(GetArea());
        }
    }
}
