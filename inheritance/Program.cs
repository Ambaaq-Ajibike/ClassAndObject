using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.Name = "Ade";
            st.Setmatric(300);
            st.Behaviour("crawl");
            //st.Walk = "Cat walk";
            Student st1 = new Student("ayo", 39);
            Console.WriteLine($"{st1.Name} {st1.Age} ");
            Console.WriteLine($"{st.Name} and his working style is {Behaviour("cat walk")}");
            Console.WriteLine($"{st.Name} and his working style is {st.Walk} and his matric number is {st.MatricNum}");

        }
    }
}
