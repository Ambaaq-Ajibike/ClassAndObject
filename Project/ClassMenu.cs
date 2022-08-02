using System.Transactions;
using System;

namespace Project
{
  //  public class Menu
   // {
        // public static void PrintMenu()
        // {
        //     Console.WriteLine("Enter 1 to register student and 2 to List All Students");
        //     int x = int.Parse(Console.ReadLine());
            
        //     if (x == 1)
        //     {
        //         RegisterStudent();
        //     }             
        // }
        // public static void RegisterStudent()
        // {
        //     Console.WriteLine("Enter the number of student you want to register");
        //     int studentlent = int.Parse(Console.ReadLine());            
        //     for (int i = 0; i < studentlent; i++)
        //     {
        //              Console.Write("Enter your firstname");
        //             var firstname = Console.ReadLine();
        //             Console.Write("Enter your lastname");
        //             var lastname = Console.ReadLine();
        //             Console.Write("Enter your phonenumber");
        //             var phonenum = Console.ReadLine();
        //             Console.Write("Enter your Email");
        //             var email = Console.ReadLine();
        //             Console.Write("Enter your Address");
        //             var address = Console.ReadLine();
        //             Console.WriteLine("Choose your leve");
        //             Console.WriteLine("\t1.SSS1");
        //             Console.WriteLine("\t2.SSS2");
        //             Console.WriteLine("\t3.SSS3");
        //             var level = (Levels)int.Parse(Console.ReadLine());
        //             Student student1 = new Student(firstname, lastname, email, phonenum, address, level);
        //             student1.PrintRegistrationDetails();
        //             Console.WriteLine();
        //     }
        // }
        public class Transaction
        {
            public string NameOfCommodity{get; set;}
            public double Price{get; set;}
            public string Quantity{get; set;}
            public DateTime DateOfTransaction{get; set;}
            public Transaction(string nameofcommodity, double price, string quantity, DateTime dateoftransaction)
            {
                NameOfCommodity = nameofcommodity;
                Price = price;
                Quantity = quantity;
                DateOfTransaction = dateoftransaction;
            }
        }
   // })
}