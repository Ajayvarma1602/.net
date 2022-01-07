using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.IO;

namespace FileHandling_SerializationDemo
{
    class JSONDataContractSerializationDemo
    {
        static void ProductDataSerialize()
        {
            string fileName = @"product.txt";
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                DataContractJsonSerializer productJson = new DataContractJsonSerializer(typeof(List<Product>));

                //get the list from the collection and store in the local pList object
                List<Product> pList = ProductCollection.productList;

                //serialize the list
                productJson.WriteObject(fs, pList);

                Console.WriteLine("Json data serialized.");
            }
        }
        static void ProductDataDeSerialize()
        {
            string fileName = @"product.txt";
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                DataContractJsonSerializer productJson = new DataContractJsonSerializer(typeof(List<Product>));

                //deserialize
                List<Product> pList = productJson.ReadObject(fs) as List<Product>;

                Console.WriteLine("Product Details:");
                foreach (Product p in pList)
                {
                    Console.WriteLine($"Product Id = {p.ProductId}");
                    Console.WriteLine($"Product Name = {p.ProductName}");
                    Console.WriteLine($"Product Price = {p.ProductPrice}");
                }
            }
        }
        static void Main()
        {
           //ProductDataDeSerialize();
            ProductDataSerialize();
            Console.WriteLine("Press enter to terminate..");
            Console.ReadLine();
        }
    }
}
