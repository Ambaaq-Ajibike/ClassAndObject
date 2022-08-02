using System;

namespace obj
{
    public class Triangle : Shape
    {
        public int height;
        public override int GetArea()
        {
            return width * breadth * height;
        }
    }
}