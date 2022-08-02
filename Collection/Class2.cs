using System;

namespace MyNamespace
{
    
    public interface Living
    {
         string GetName();
    }


    public class Person : Living
    {
        public string FirstName{get; set;}
        public string MiddleName{get; set;}
        public string LastName{get; set;}
        public Person(string firstname, string middlename, string lastname)
        {
            FirstName =firstname;
            MiddleName = middlename;
            LastName = lastname;
        }
        public string GetName()
        {
            return LastName;
        }
    } 
    public class InvalidUserInputException : Exception
    {
        public InvalidUserInputException(string message) : base(message)
        {
            
        }
    }  
}