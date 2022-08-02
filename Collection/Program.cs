// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Collections.Generic;
using System;

namespace MyNamespace
{
    class program
    {
        static void Main (string[] args)
        {
           // RemoveDuplicate();
            // Common();
            // Common<Person> person = new Common<Person>();
            // Person p1 = new Person("debo", "dayo","dolapo");
            
            // Console.WriteLine(person.GetUpperName(p1));
            // try
            // {
                
            // }
            // catch ({System.Exception} ex)
            // {
            //      // TODO
            // }
            // catch({System.InvalidOperationException})
            // {

            // }
            // finally
            // {

            // }
            //int d;
            // System.Console.WriteLine("Enter num");
            // int num= int.Parse(Console.ReadLine());
            // var check = int.TryParse(num,out int d);
            // while(check == false)
            // {
            //     System.Console.WriteLine("Enter num");
            //     age = Console.ReadLine();
            //     check = int.TryParse(num, out d);
            var x = new int[10];
            try
            {
                Console.WriteLine(x[1]);
                throw new InvalidUserInputException(message"asd");
            }
            catch (IndexOutOfBoundException)
            {
                 System.Console.WriteLine("ase");
            }
        }
        //     var arr = new int {10};
        //     try
        //     {
        //         System.Console.WriteLine(arr[11]);
        //     }
        //     catch (IndexOut)
        //     {
        //          System.Console.WriteLine("index");
        //     }            
            
           

        // }
        // static void Common()
        // {
        //      Hashtable hash = new Hashtable();
        //     bool isCommon = false;
        //     int[] arr = {1, 3, 2, 1};
        //     foreach (var item in arr)
        //     {
        //         if(hash.ContainsKey(item))
        //         {
        //             isCommon = true;
        //             System.Console.WriteLine(isCommon);
        //             break;
        //         }
        //         else
        //         {
        //             hash.Add(item, 1);
        //         }
        //     }
        // }
        // static void RemoveDuplicate()
        // {
        //     List<int> Myarr = new List<int>(){4, 1, 1, 6, 1, 2, 4, 6};
        //    SortedList<int, int> sortDuplicate = new SortedList<int, int>();
        //    foreach (var c in Myarr)
        //    {
        //        if (sortDuplicate.ContainsKey(c))
        //        {
        //            sortDuplicate[c] = sortDuplicate[c] + 1;                
        //        }
        //        else
        //        {
        //           sortDuplicate.Add(c, 1);                                
        //        }
        //    }
        //     foreach (var item in sortDuplicate)
        //     {
        //         if(item.Value > 1)
        //         {
        //              System.Console.Write(item.Key);
        //         }   
        //     }
        //     System.Console.WriteLine();

        //     System.Console.WriteLine();
        //    foreach (var item in sortDuplicate)
        //    {
        //        if(item.Value > 1)
        //         {
        //              System.Console.Write(item.Value);
        //         }               
        //    }


        // }
        // static bool Catch(int a, out int b)
        // {
        //     System.Console.WriteLine("Enter num");
        //    int num = int.Parse(Console.ReadLine());

            
        // }
    }
}
