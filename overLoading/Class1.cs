using System;

namespace overLoading
{
    // public class Triangle : Shape
    // {
    //     public int height;
    //    //(Over loading) public int GetArea(int width, int breadth, int height)
    //     public  override int GetArea()
    //     {
    //         return width * breadth * height;
    //     }\
    public class Student : Person
    {
        public int MatricNum;
        public Student(string name, string address, string phoneNum, string matnum)
        {
             Name = name;
            Address = address;
            PhoneNum = phoneNum;
            MatricNum = matnum;
           
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"My name is {Name}, I lived at {Address},this is my phone number {PhoneNum}. My matric number is {MatricNum}");
        }
    }
}
