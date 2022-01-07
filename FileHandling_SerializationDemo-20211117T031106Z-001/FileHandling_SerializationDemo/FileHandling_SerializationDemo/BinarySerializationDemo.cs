using System;
using System.IO; //for file handling
using System.Runtime.Serialization.Formatters.Binary;//for binary serialization

namespace FileHandling_SerializationDemo
{
    class BinarySerializationDemo
    {
        static void LoginDataDeserialize()
        {
            string fileName = @"logindata.txt";
            LoginInfo lastLogin = null;

            if (File.Exists(fileName))
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    
                    Console.WriteLine("----------------------------------");
                }
            }
        }
        static void LoginDataSerialize()
        {
            string fileName = @"logindata.txt";
            LoginInfo currentLogin = new LoginInfo();

            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                Console.Write("Enter Username : ");
                currentLogin.UserName = Console.ReadLine();
                Console.Write("Enter Password : ");
                currentLogin.Password = Console.ReadLine();

                if (currentLogin.Password == "test123")
                {
                    Console.WriteLine("Login successfull..");
                    Console.WriteLine($"Welcome {currentLogin.UserName}");

                   
                }
                else
                {
                    Console.WriteLine("Login credentials are not correct..try again");
                }
            }
        }
        static void Main(string[] args)
        {
           // LoginDataDeserialize();

            LoginDataSerialize();

            Console.WriteLine("Thankyou for visiting..Press enter to terminate");
            Console.ReadLine();
        }
    }
}
