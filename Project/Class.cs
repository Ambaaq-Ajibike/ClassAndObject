using System.Collections.Generic;
using System;

namespace Project
{
   // public class Student : Person
    //{
        // public static int NumberOfRegistration = 0;
        // public string RegistrationNumber {get;}
        // public Levels Studentlevel{get; set; }
        // public static Student[] students = new Student[10];
        

        // public Student(string firstname, string lastname, string email, string phonenum, string address, Levels studentlevel) : base(firstname, lastname, email, phonenum, address)
        // {
        //     RegistrationNumber = GenerateRegistrationNumber();
        //     Studentlevel = studentlevel;
        //     AddToStudent();
        //     NumberOfRegistration ++;
        // }
        // public void AddToStudent()
        // {
        //     students[NumberOfRegistration] = this;
        // }        
        // public void PrintRegistrationDetails()
        // {
        //     Console.WriteLine($" Dear {Firstname}, you are welcome to code learners hub your registration is {RegistrationNumber}");
        // }
        // public string GenerateRegistrationNumber()
        // {
        //     return $"SB{NumberOfRegistration.ToString("000")}";
        // }
        // public void PrintStudent()
        // {
        //     for(var i = 0; i < NumberOfRegistration; i ++)
        //     {
        //         Console.WriteLine($"{i + 1}. {students[i].RegistrationNumber} - {students[i].Firstname} {students[i].Lastname}");
        //     }
        // }
   // }
   public class Manager
   {
       public string Name {get; set;}
     
       public Manager(string name) 
       {
           Name = name;
       }
      
   }
    
   
        
        
    
    
}
