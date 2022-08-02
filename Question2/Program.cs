using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Information = new Student("dad", 20);
            Information.SetBestSubject("Mathematics");
            Console.WriteLine($"My dad is {Information.Name} and he is {Information.Age}");
            
            
        }
    }
}
