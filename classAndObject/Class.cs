using System;

namespace classAndObject
{
    public class Car
    {
        public int Price;
        public void SetPrice(int price)
        {
            if (value > 0)
            {
                this.Price = price;
            }
            else 
            {
                Console.WriteLine("invalid price");
            }
        } 
        public int GetPrice() 
        {
            
                return this.Price;
            
        }
    }
}