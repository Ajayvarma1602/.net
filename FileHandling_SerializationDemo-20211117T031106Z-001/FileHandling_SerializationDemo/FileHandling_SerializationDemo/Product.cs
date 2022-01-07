using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FileHandling_SerializationDemo
{
    [DataContract]
    class Product
    {
        [DataMember]
        public int ProductId { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public int ProductPrice { get; set; }
    }

    class ProductCollection
    {
        public static List<Product> productList = new List<Product> {
          new Product{ProductId=1,ProductName="Keyboard",ProductPrice=500},
           new Product{ProductId=2,ProductName="Mouse",ProductPrice=300},
            new Product{ProductId=3,ProductName="Pendrive",ProductPrice=550},
             new Product{ProductId=4,ProductName="Harddisk",ProductPrice=2000},
              new Product{ProductId=5,ProductName="WebCamera",ProductPrice=3000}
        };
    }
}
