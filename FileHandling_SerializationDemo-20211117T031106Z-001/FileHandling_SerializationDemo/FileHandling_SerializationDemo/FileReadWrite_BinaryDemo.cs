using System;
using System.IO;

namespace FileHandling_SerializationDemo
{
    class FileReadWrite_BinaryDemo
    {
        static void WriteToFile(string name, int salary)
        {
            string fileName = @"d:\testDirectory\empdetails.txt";
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(name);
                bw.Write(Convert.ToInt32(salary));
                bw.Flush();
                Console.WriteLine("File saved..");
            }
        }
        static void ReadFromFile()
        {
            string fileName = @"d:\testDirectory\empdetails.txt";
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                BinaryReader br = new BinaryReader(fs);
                string name = br.ReadString();
                int salary = br.ReadInt32();

                Console.WriteLine("Name = " + name);
                Console.WriteLine("Salary = " + salary);
            }
        }
        static void Main()
        {
            //Console.Write("Enter your name = ");
            //string name = Console.ReadLine();
            //Console.Write("Enter your salary = ");
            //int salary = Convert.ToInt32(Console.ReadLine());

            //WriteToFile(name, salary);

           // ReadFromFile();

            Console.WriteLine("Press enter to terminate...");
            Console.ReadLine();
        }
    }
}
