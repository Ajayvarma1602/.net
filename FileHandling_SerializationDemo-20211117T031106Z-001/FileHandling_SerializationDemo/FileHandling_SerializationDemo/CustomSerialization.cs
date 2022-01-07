using System;
using System.Runtime.Serialization.Formatters.Soap;

using System.IO;

using System.Runtime.Serialization;

namespace FileHandling_SerializationDemo
{
    class CustomSerialization
    {
        [Serializable]
        public class Customer : ISerializable
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            string fullName;

            public Customer()
            {

            }
            //Deserialization
            private Customer(SerializationInfo si, StreamingContext ctx)
            {
                var names = si.GetString("FullName").Split(' ');
                FirstName = names[0];
                LastName = names[1];

            }

            //serialize
            void ISerializable.GetObjectData(SerializationInfo info, StreamingContext ctx)
            {
                fullName = FirstName + " " + LastName;
                // Fill up the SerializationInfo object with the formatted data.
                info.AddValue("FullName", fullName);
                info.AddValue("CreatedDate", DateTime.Now.ToShortDateString());
            }
        }

        [Serializable]
        public class Author
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            [OnSerializing]
            internal void OnSerializing(StreamingContext context)
            {
                FirstName = FirstName.ToUpper();
                LastName = LastName.ToUpper();
            }

            [OnDeserialized]
            internal void OnDeserialized(StreamingContext context)
            {
                FirstName = FirstName.ToLower();
                LastName = LastName.ToLower();
            }
        }

        static void SerializeAuthorData()
        {
            string fileName = @"Author.xml";
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                SoapFormatter s = new SoapFormatter();
                Author c = new Author { FirstName = "Chetan", LastName = "Bhagat" };
                s.Serialize(fs, c);
                Console.WriteLine("Author Serialized..");
            }
        }
        static void DeSerializeAuthorData()
        {
            string fileName = @"Author.xml";
            if (File.Exists(fileName))
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    SoapFormatter s = new SoapFormatter();
                    Author c = s.Deserialize(fs) as Author;
                    Console.WriteLine("Author First Name : " + c.FirstName);
                    Console.WriteLine("Author Last Name : " + c.LastName);
                }
            }
        }
        static void SerializeCustomerData()
        {
            string fileName = @"customer.xml";
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                SoapFormatter s = new SoapFormatter();
                Customer c = new Customer { FirstName = "John", LastName = "Smith" };
                s.Serialize(fs, c);
                Console.WriteLine("Customer Serialized..");
            }
        }
        static void DeSerializeCustomerData()
        {
            string fileName = @"customer.xml";
            if (File.Exists(fileName))
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    SoapFormatter s = new SoapFormatter();
                    Customer c = s.Deserialize(fs) as Customer;
                    Console.WriteLine("Customer First Name : " + c.FirstName);
                    Console.WriteLine("Customer Last Name : " + c.LastName);
                }
            }
        }
        static void Main(string[] args)
        {
            DeSerializeCustomerData();
            SerializeCustomerData();

            DeSerializeAuthorData();
            SerializeAuthorData();

            Console.ReadLine();
        }
    }
}
