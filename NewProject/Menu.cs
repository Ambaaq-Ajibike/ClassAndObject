using System;

namespace NewProject
{
    public class Menu
    {
        public static void PrintStudentInfo()
        {
            Console.WriteLine("Enter the number of students you want to register");
            int lent = int.Parse(Console.ReadLine());
            string[] arr = new string[lent];
            string[] arr2 = new string[lent];
            for (int a = 0; a < lent; a ++)
            {
                Console.WriteLine("Enter the first name of the student");
                var firstname = Console.ReadLine();
                arr[a] = firstname;
                Console.WriteLine("Enter the last name of the student");
                var lastname = Console.ReadLine(); 
                arr2[a] = lastname;  
                Console.WriteLine("Enter your email");
                var email = Console.ReadLine();
                Console.WriteLine("Enter your phonenumber");
                var phonenumber = Console.ReadLine();
                Console.WriteLine("Enter your address");
                var address = Console.ReadLine();
                Console.WriteLine("Enter the level");
                Console.WriteLine("Enter 1 for SSS1");
                Console.WriteLine("Enter 1 for SSS2");
                Console.WriteLine("Enter 1 for SSS3");
                var level = (Level)int.Parse(Console.ReadLine());
                Student student = new Student(firstname, lastname, email, phonenumber, address, level);
                student.PrintInfo();
            }
            Console.WriteLine("Enter 2 to view students name or any number to quit");
            int y = int.Parse(Console.ReadLine());
            if (y == 2)
            {
                for(int b = 0; b < lent; b ++)
                {
                    Console.WriteLine($"{arr[b]} {arr2[b]}");
                }
                
                Console.WriteLine("Thanks");
            }
            else
            {
                Console.WriteLine("You are living without viewing the names thanks");
            }
        }        
    }
}
