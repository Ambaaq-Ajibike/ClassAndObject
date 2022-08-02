using System;

namespace inheritance
{
    public class Student : Person
    {
        public int score;
        private int MatricNum;
        public Student(){}
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Setmatric(int matricNum)
        {
            this.MatricNum = matricNum;
        }
        public int Getmatric()
        {
            return MatricNum;
        }
    }
}