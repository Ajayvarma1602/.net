using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCAppToBlob.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAppToBlob.Controllers
{
    public class AttendanceController : Controller
    {
        // GET: Attendanc
        public ActionResult Index()
        {
            return View("Create");
        }

        // GET: Attendanc/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Attendanc/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Attendanc/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Attendence attendence)
        {
            //string conStr = "DefaultEndpointsProtocol=https;AccountName=logicalstorageaccount;AccountKey=3rD/7qWKq3gfcrX9hfmeJnMxhoSJ6ylSDOzWHlbQpSd87/HQ1vrNtAK3MxBk5FQZyVZlqLQFZzzNSiNQyNSDgA==;EndpointSuffix=core.windows.net";

            try
            
            
            {
                string attendStr = Newtonsoft.Json.JsonConvert.SerializeObject(attendence);
                //string conStr = "BlobEndpoint=https://logicalstorageaccount.blob.core.windows.net/;QueueEndpoint=https://logicalstorageaccount.queue.core.windows.net/;FileEndpoint=https://logicalstorageaccount.file.core.windows.net/;TableEndpoint=https://logicalstorageaccount.table.core.windows.net/;SharedAccessSignature=sv=2020-08-04&ss=bfqt&srt=sco&sp=rwdlacuptfx&se=2021-07-31T12:43:25Z&st=2021-07-31T04:43:25Z&spr=https&sig=shn1vydXzTEDDoSQdpQTqqCAFxKcPNvWqLqfGfg02hw%3D";
   //           string conStr = "DefaultEndpointsProtocol=https;AccountName=logicalstorageaccount;AccountKey=3rD/7qWKq3gfcrX9hfmeJnMxhoSJ6ylSDOzWHlbQpSd87/HQ1vrNtAK3MxBk5FQZyVZlqLQFZzzNSiNQyNSDgA==;EndpointSuffix=core.windows.net";
                string conStr = "DefaultEndpointsProtocol=https;AccountName=firstaccount002;AccountKey=nmUzvVVQXou8mXpxlhEe10+unrGeQG3aPAXDL8CkWokVwdas/HNFJCH94orCBID/dPtC8BcGnbMuC9HU+Vr8RQ==;EndpointSuffix=core.windows.net";
                try
                {
                    UploadBlob(conStr, attendStr, "container", true);
                    ViewBag.Result = "Details Updated to Blob :" + attendStr;
                }
                catch (Exception ex)
                {
                    ViewBag.Result = "Failed to update blob " + ex.Message;
                }
                return View("Create");
            }
            catch
            {
                return View("Create");
            }
        }

        public static string UploadBlob(string conStr, string fileContent, string containerName, bool isAppend = false)
        {
            string result = "Success";
            try
            {

                //string containerName = "sample1";
                var serviceClient = new BlobServiceClient(conStr);
                var containerClient = serviceClient.GetBlobContainerClient(containerName);

                var fileName = "Attendence.txt";
                string existingContent = "";
                var blobClient = containerClient.GetBlobClient(fileName);

                if (isAppend)
                {
                    string fillerStart = "";
                    string fillerEnd = "]";
                    existingContent = GetContentFromBlob(conStr, fileName, containerName);
                    if (string.IsNullOrEmpty(existingContent.Trim()))
                    {
                        fillerStart = "[";
                        fileContent = fillerStart + existingContent + fileContent + fillerEnd;

                    }
                    else
                    {
                        existingContent = existingContent.Substring(0, existingContent.Length - 3);
                        fileContent = fillerStart + existingContent + "," + fileContent + fillerEnd;
                    }
                }

                var ms = new MemoryStream();
                TextWriter tw = new StreamWriter(ms);
                tw.Write(fileContent);
                tw.Flush();
                ms.Position = 0;

                blobClient.UploadAsync(ms, true);

            }
            catch (Exception ex)
            {
                result = "Failed";
                throw ex;
            }
            return result;
        }

        private static string GetContentFromBlob(string conStr, string fileName, string containerName)
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient(conStr);
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
            BlobClient blobClient = containerClient.GetBlobClient(fileName);
            string line = string.Empty;
            if (blobClient.Exists())
            {
                var response = blobClient.Download();
                using (var streamReader = new StreamReader(response.Value.Content))
                {
                    while (!streamReader.EndOfStream)
                    {
                        line += streamReader.ReadLine() + Environment.NewLine;
                    }
                }
            }
            return line;
        }
        // GET: Attendanc/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Attendanc/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Attendanc/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Attendanc/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
