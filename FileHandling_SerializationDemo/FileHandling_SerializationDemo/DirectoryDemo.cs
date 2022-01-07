using System;
using System.IO;

namespace FileHandling_SerializationDemo
{
    class DirectoryDemo
    {
        static void Main()
        {
            //DriveInfo drive = new DriveInfo(@"c:\");
            //Console.WriteLine($"Drive type : {drive.DriveType} and Memory available : {drive.AvailableFreeSpace} bytes");

            string dirName = @"d:\testDirectory";

            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Directory exists");
                //get the reference of the directory
                //DirectoryInfo dir = new DirectoryInfo(dirName);

                //var files = dir.GetFiles(); //returns an array of FileInfo objects
                //if (files.Length > 0)
                //{
                //    Console.WriteLine("Files in the directory:");
                //    foreach (FileInfo f in files)
                //    {
                //        Console.WriteLine(f.Name);
                //    }
                //}
                //else
                //{
                //    Console.WriteLine("Directory has no files in it");

                //    File.Create(dirName + @"\file1.txt"); // d:\testDirectory\file1.txt
                //    File.Create(dirName + @"\file2.txt");
                //    File.Create(dirName + @"\file3.txt");

                //    Console.WriteLine("File created..");
                //}
            }
            else
            {
                Console.WriteLine("Directory not found..");
                // DirectoryInfo d = Directory.CreateDirectory(dirName);

                DirectoryInfo d = new DirectoryInfo(dirName);
                d.Create();

                Console.WriteLine("Directory created...");
            }

            Console.ReadLine();
        }
    }
}
