using System;

namespace NewProject
{
    public class Student : Person
    {
        public string Registration{get; set;}
        public Level StudentLevel{get; set;}
        public static int RegistrationNumber = 0;
        public static Student[] students = new Student[10];
        public Student(string firstname, string lastname, string email, string phonenumber, string address, Level studentlevel) : base(firstname, lastname, email, phonenumber, address)
        {
            Registration = Getregnum();
            RegistrationNumber ++;
            StudentLevel = studentlevel;
            AllMoreStudents();

        }
        private string Getregnum()
        {
            return $"SD{(RegistrationNumber + 1).ToString("000")}";
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Dear{FirstName} you are kindly welcome to ASCI and your registration number is{Registration}");
        }
        public void AllMoreStudents()
        {
            students[RegistrationNumber] = this;
        }

        public static void PrintStudent()
        {
            for(var i = 0; i < RegistrationNumber; i++)
            {
                Console.WriteLine($"{i + 1}. {students[i].Registration}  {students[i].FirstName}  {students[i].LastName}");
            }
        }

    }
}
