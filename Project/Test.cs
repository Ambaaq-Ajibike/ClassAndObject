using System;

namespace Project
{
    public class Test
    {
         public static void PrintMenu()
        {
             Console.WriteLine("Enter the number of student you want to register");
            int studentlent = int.Parse(Console.ReadLine()); 
            string[] arr = new string[studentlent];           
            for (int i = 0; i < studentlent; i++)
            {
                     Console.Write("Enter your firstname   ");
                    var firstname = Console.ReadLine();
                    arr[i] = (firstname);
                    Console.Write("Enter your lastname   ");
                    var lastname = Console.ReadLine();
                    Console.Write("Enter your phonenumber   ");
                    var phonenum = Console.ReadLine();
                    Console.Write("Enter your Email   ");
                    var email = Console.ReadLine();
                    Console.Write("Enter your Address   ");
                    var address = Console.ReadLine();
                    Console.WriteLine("Choose your level");
                    Console.WriteLine("\t1.SSS1");
                    Console.WriteLine("\t2.SSS2");
                    Console.WriteLine("\t3.SSS3");
                    var level = (Levels)int.Parse(Console.ReadLine());
                    Student student1 = new Student(firstname, lastname, email, phonenum, address, level);
                    student1.PrintRegistrationDetails();
                    Console.WriteLine();
            }
            Console.WriteLine("Enter 2 to see the name of the students or any key to quit");
            int x = int.Parse(Console.ReadLine());
            if (x == 2)
            {
                for(int a = 0; a < studentlent; a ++)
                {
                    Console.WriteLine(arr[a]);
                }
            }
            else
            {
                Console.WriteLine("You are quiting without viewing the students name thanks");
            }

           
        }
        
                  
    }
}