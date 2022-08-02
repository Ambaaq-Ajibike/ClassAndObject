using System;

namespace Classes
{
    public class Shape
    {
        public int Length;
        public int Breadth;
         public int Height;
         public Shape(){}
         public Shape(int length, int breadth)
         {
             Length = length;
             Breadth = breadth;
         }

        //  public void SetBreadth(int breadth)
        //  {
        //      this.Breadth = breadth;
        //  }
        //  public int GetBreadth()
        //  {
        //      return Breadth;
        //  }
    }
}