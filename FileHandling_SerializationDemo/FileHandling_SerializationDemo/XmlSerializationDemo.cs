using System;
using System.IO; //for file handling
using System.Xml.Serialization;//for xmlserialization

namespace FileHandling_SerializationDemo
{
    class XmlSerializationDemo
    {
        static void PersonDataDeserialize()
        {
            string fileName = @"person.xml";
            Person lastPerson = null;
            if (File.Exists(fileName))
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    

                    Console.WriteLine("Last Person Information");
                    Console.WriteLine("First Name = " + lastPerson.FirstName);
                    Console.WriteLine("Last Name = " + lastPerson.LastName);
                    Console.WriteLine("--------------------------------------");
                }
            }
        }
        static void PersonDataSerialize()
        {
            string fileName = @"person.xml";
            Person p = new Person();
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                Console.Write("Enter Firstname : ");
                p.FirstName = Console.ReadLine();
                Console.Write("Enter Lastname : ");
                p.LastName = Console.ReadLine();

                //write serialize code here
                //here, the object of type Person class will be serialized in xml format
              

                Console.WriteLine("Data serialized");
            }
        }
        static void Main()
        {
          //  PersonDataDeserialize();
            PersonDataSerialize();

            Console.WriteLine("Thankyou for visiting..Press enter to terminate");
            Console.ReadLine();
        }
    }
}
