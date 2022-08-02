using System;

namespace constant
{ 

    // public class School
    // {
    //     public static int numOfStudents;
    // }


    // public static  class Calculator 
    // {
    //     private static int Result = 0;
    //     public static string Type = "Arithmetic";
    //     public static int Sum(int num1, int num2)
    //     {
    //         return num1 + num2;
    //     }
    //     public static void SetResult(int result)
    //     {
    //         Result = result;
    //     }
    //     public static int GetResult()
    //     {
    //         return Result;
    //     }
    // }
        //public class Student
        //{
            // public string StudentsName;
            // public int Age;
            // public string Dod;
            // public static int Count;  
            // public const string School = "ASCI";
            //  public Student(string name, int age, string dod)
            //  {
            //      this.StudentsName = name;
            //      this.Age = age;
            //      this.Dod = dod;
            //      Count ++;
            //  }
            //  public string StoreStudentsName(string name)
            //  {
            //      this.StudentsName = name;
            //  }
        //}



        //ENUM
            // public enum Gender
            // {
            //     Male,
            //     Female,
            //     RatherNotSpecified

            // }
            // public class Student
            // {
            //     public string Name;
            //     public int Age;
            //     public Gender Gender;
            //     public Student(string name, int age, Gender gendee)
            //     {
            //         Name = name;
            //         Age = age;
            //         Gender = gendee;
            //     }
            // }
            // public class StudentTest
            // {
            //     public void PrintInfo()
            //     {
            //         Student st = new Student("Adewale", 10, Gender.Male);
            //         st.Gender = Gender.Female;
            //         Console.WriteLine(st.Gender);
            //     }
            // }
            // public enum MonthofTheYear
            // {
            //     January = 1,
            //     February,
            //     March,
            //     April,
            //     May,
            //     June,
            //     July, 
            //     August,
            //     September,
            //     October,
            //     November,
            //     December,
            // }
            // public class Student
            // {
            //     public string Name;
            //     public Gender Gender; 
            //     public string DateOFBirth;
            // }
            // public class Arithmetic 
            // {                
            //     private static  int Result;
            //     public static int Sum(int length, int breadth)
            //     {
            //         return length * breadth;
            //     }
            //     public static void SetResult(int result)
            //     {
            //         Result = result;
            //     }
            //     public static int GetResult()
            //     {
            //         return Result;
            //     }
                
            // }
            public class Counter
            {
                public string Name;
                public static int Count;

                public Counter()
                {
                    Count++;
                }
            }
}        
