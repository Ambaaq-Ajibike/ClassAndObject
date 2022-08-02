using System;

namespace overLoading
{
    class Program
    {
        static void Main(string[] args)
        {
        //     Triangle area = new Triangle();
        //     //  area.breadth = 5;
        //   //overriding  //  area.width = 5;
        //     //  area.height = 5;
        //     Console.WriteLine($"{area.GetArea()}");
        //     Shape rec = new Shape();
        //      rec.breadth = 5;
        //      rec.width = 6;
        //     Console.WriteLine($"{rec.GetArea()}");
            Student st = new Student("def", "sed", "098787658748", 8765);
           st.PrintInfo();
           Person pa = new Person ("kunle", "ajanlekoko", "08708765365");
           pa.PrintInfo();
        }
    }
}
