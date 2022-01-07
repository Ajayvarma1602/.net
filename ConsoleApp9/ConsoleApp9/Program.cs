using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConsoleApp9
{
    class Program
    {
        private static object configuration;

        static void Main(string[] args)
        {
            string path1 = "D:\\Capgemini\\Batch_2\\IMPORTANT.TXT";
            string name = "newsol";
            
            //string a = "pdffilecontainer";
           // string connectionString = ConfigurationSettings.AppSettings.Get("ConnectionString");
            // Get a reference to a container

            string cs1 = ConfigurationSettings.AppSettings.Get("ConnectionString");
            BlobContainerClient c1 = new BlobContainerClient(cs1, name);
           // BlobContainerClient container = new BlobContainerClient(connectionString,name);
            BlobClient blob = c1.GetBlobClient(path1);
            //await container.CreateAsync();
             //container.Create();
           //    blob.Upload(path1);

           Console.WriteLine("update successfully");
            Console.WriteLine($"{name}");
            c1.DeleteAsync();
            //Console.WriteLine("file deleted successfully");
           // c1.DeleteAsync();
            //Console.WriteLine("deleted successfully");
            Console.ReadLine();
        }
    }
}
