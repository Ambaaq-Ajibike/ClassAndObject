using System.Collections.Generic;
using System;

namespace Project
{
            // public abstract class Person
            // {
            //     public string Firstname{get; set; }
            //     public string Lastname{get; set;}
            //     public string Email{get; set; }
            //     public string PhoneNum{get; set; }
            //     public string Address{get; set; }
            //     public Person(string firstname, string lastname, string email, string phonenum, string address)
            //     {
            //         Firstname = firstname;
            //         Lastname = lastname;
            //         Email = email;
            //         PhoneNum = phonenum;
            //         Address = address;
            //     }
            //     public string GetSimpleDetails()
            //     {
            //         return $"Firstname: {Firstname}\n" +
            //             $"Lastname: {Lastname}\n" +
            //             $"Email: {Email}\n"+
            //             $"Address: {Address}";
            //     }
            //     public string GetFullname()
            //     {
            //         return $"{Firstname} {Lastname}";
            //     }
            // }
    public class Customer
    {
        public string Name{get; set;}
        public DateTime DateOfPurchase{get;}
        public string CommodtyPurchased{set; set;}
        List<Customer> CustomersInfo = new List<Customer>();
        public Customer(string name, string commodityPurchased, DateTime dateOfpurchase)
        {
            Name = name;
            CommodtyPurchased = commodityPurchased;
            DateOfPurchase = dateOfpurchase;
            CustomersID()
        }
        public int GenerateCostumerID()
        {
            Random random = new Random();
            return random.Next(265, 10934);
        }
        public void AllCustomersInfo()
        {
            CustomersInfo.Add(this);
        }
        public void VeiwCostumers()
        {
            foreach (var info in CustomersInfo)
            {
                System.Console.WriteLine(info);
            }
        }
    }            
}



 

    
