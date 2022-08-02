using System;

namespace NewProject
{
    public abstract class Person
    {
        public string FirstName{get; set;}
        public string LastName{get; set;}
        public string Email{get; set;}
        public string PhoneNumber{get; set;}
        public string Address{get; set;}
        public Person(string firstname, string lastname, string email, string phonenumber, string address)
        {
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            PhoneNumber = phonenumber;
            Address = address;
        }
        
    }
}
