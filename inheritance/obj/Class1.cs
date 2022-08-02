using System;

namespace obj
{
    public class Shape
    {
        public int width;
        public int breadth;
        public virtual int GetArea()
        {
            return width * breadth;
        }
    }
}