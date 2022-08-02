using System;

namespace overLoading
{
    // public class Shape
    // {
    //     public int breadth;
    //     public int width;
    //     //over loadpublic int GetArea(int width, int breadth)
    //     public virtual int GetArea()
    //     {
    //         return width * breadth;
    //     } }
    public class Person
    {
        public string Name;
        public string Address;
        public string PhoneNum;
        public Person(string name, string address, string phoneNum)
        {
            this.Name = name;
            this.Address = address;
            this.PhoneNum = phoneNum;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name is {Name} and I live at {Address}, my phone number is{PhoneNum}");
        }
    }
}