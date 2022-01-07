using System;
using System.Xml.Serialization;

namespace FileHandling_SerializationDemo
{
    //NOTE: for XML serialization class should be marked public
    public class Person
    {
        string firstName;
        string lastName;

     
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

     
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
    }
}
