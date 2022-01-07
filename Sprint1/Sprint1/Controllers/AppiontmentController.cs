using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sprint1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint1.Controllers
{
    public class AppiontmentController : Controller
    {
        // GET: AppiontmentController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AppiontmentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AppiontmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AppiontmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Appointment appointment)
        {
            try
            {
                string appointStr = Newtonsoft.Json.JsonConvert.SerializeObject(appointment);
                string conStr = "DefaultEndpointsProtocol=https;AccountName=appointmentaccount;AccountKey=/m6ZSAmlvxp6o/PNTL1L57UDLAOyNK8dT3l9vbmmqTp4JP+9p73qe3E8kk5yUnRMCpF00sQSUq5gBNK3hHz3Sw==;EndpointSuffix=core.windows.net";
                try
                {
                    UploadBlob(conStr, appointStr, "appointment", true);
                    ViewBag.Result = "Details Updated to Blob :" + appointStr;
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

        // GET: AppiontmentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
        public static string UploadBlob(string conStr, string fileContent, string containerName, bool isAppend = false)
        {
            string result = "Success";
            try
            {
                //string containerName = "appointment";
                string fileName, existingContent;
                BlobClient blobClient;
                Insert(conStr, containerName, out fileName, out existingContent, out blobClient);

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

        private static void Insert(string conStr, string containerName, out string fileName, out string existingContent, out BlobClient blobClient)
        {
            var serviceClient = new BlobServiceClient(conStr);
            var containerClient = serviceClient.GetBlobContainerClient(containerName);

            fileName = "appointmentinfo.txt";
            existingContent = "";
            blobClient = containerClient.GetBlobClient(fileName);
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

        // POST: AppiontmentController/Edit/5
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

        // GET: AppiontmentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AppiontmentController/Delete/5
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
