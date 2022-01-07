using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication19.Models;
using Azure.Storage.Blobs;
using System.IO;

namespace WebApplication19.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public static string accessStr = "DefaultEndpointsProtocol=https;AccountName=firstaccount002;AccountKey=nmUzvVVQXou8mXpxlhEe10+unrGeQG3aPAXDL8CkWokVwdas/HNFJCH94orCBID/dPtC8BcGnbMuC9HU+Vr8RQ==;EndpointSuffix=core.windows.net";
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private static string GetContentFromBlob(string accessStr,string BlobName,string ContainerName)
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient(accessStr);
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(ContainerName);
            BlobClient blobClient = containerClient.GetBlobClient(BlobName);
            string line = string.Empty;
            if (blobClient.Exists())
            {
                var response = blobClient.Download();
                using(var streamReader=new StreamReader(response.Value.Content))
                {
                    while (!streamReader.EndOfStream)
                    {
                        line += streamReader.ReadLine() + Environment.NewLine;
                    }
                }
            }
            return line;

        }
        public IActionResult CreateContainer(ContainerModel model)
        {
            var content = GetContentFromBlob(accessStr, "asd","project");
            //try
            //{
            //    string path1 = "D:\\Capgemini\\Batch_2\\IMPORTANT.TXT";

            //    string connectionstring = accessStr;
            //    string blobName = model.BlobName;
            //    BlobContainerClient container = new BlobContainerClient(connectionstring, model.ContainerName.ToLower());
            //    //               container.Create();
            //    BlobClient blob = container.GetBlobClient(blobName);
            //    blob.Upload(path1);
            //    ViewBag.ContainerCreateStatus = "uploaded successfully";
            //}
            //catch (Exception ex)
            //{
            //    ViewBag.ContainerCreateStatus = "Container not created is " + ex.Message;
            //}
            return View("/views/CreateContainer.cshtml");
        }
        public IActionResult Index()
        {
            return View("/views/CreateContainer.cshtml");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
