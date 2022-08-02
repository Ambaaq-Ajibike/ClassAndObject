using System;
//using Classes;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {//WITH9OUT gETAND sET
                Shape Square = new Shape();
                Square.Length = 4;
                Square.Breadth = 7;
                Console.WriteLine($"The area of the square is {Square.Length * Square.Breadth} ");
                Shape Square2 = new Shape(6, 6);
                Console.WriteLine($"The perimeter 9of the square is {Square2.Length + Square2.Breadth}");


            //     // wITH gET aND sET
            //       Shape Square = new Shape();
            //     Square.Length = 4;
            //    // Square.Breadth = 7;
            //    Square.SetBreadth(4);
            //     Console.WriteLine($"The area of the square is {Square.Length * Square.GetLength()} ");
            //     Shape Square2 = new Shape(6, 6);
            //     Console.WriteLine($"The perimeter 9of the square is {Square2.Length + Square2.GetLength()}");

        }
    }
}
