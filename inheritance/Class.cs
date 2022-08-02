using System;

namespace inheritance
{
    public class Person
    {
        public string Name;
        public int Age;
        private double Weight;
        public string Walk;
        public string Behaviour(string walk)
        {
           // Walk = walk;
            return walk;
        }
        
    }
}