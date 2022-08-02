using System;

namespace Question2
{
    public class Student
    {
        public string Name;
        public int Age;
        private string Bestsubject;
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void SetBestSubject(string bestsubject)
        {
            this.Bestsubject = bestsubject;
        }
        public string GetBestSubject()
        {
            return Bestsubject;
        }
    }
}