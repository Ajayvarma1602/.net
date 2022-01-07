using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using Azure.Storage.Blobs;

class Program
{
    public static string accessStr = "DefaultEndpointsProtocol=https;AccountName=firstaccount002;AccountKey=Faxwn0jUug2dHV4pg0lY/+rFXaI+UMAJnFVNtwPziFTrPTdOv4PnsmrTtVQhKaTpLJWhzPmvjxmH5X2adznjrw==;EndpointSuffix=core.windows.net";
    static void Main(string[] args)
    {
        BlobContainerClient container = new BlobContainerClient(accessStr, "container");

               + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString());
        container.Create();
        Console.WriteLine("created");
        Console.ReadLine();
    }
}
