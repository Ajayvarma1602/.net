using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace TicketCollector.Controllers
{
    public class TicketController : Controller
    {
        public enum Days { Monday = 0, Tuesday = 1, Wednesday = 2, Thursday = 3, Friday = 4, Saturday = 5, Sunday = 6 }
        public enum Colors { Red = 0, Blue = 1, Green = 2, Yellow = 3, Purple = 4, Black = 5, Pink = 6 }
       
        public ActionResult Index()
        {
            return View("Views/Ticket/Ticket.cshtml");
        }

        public ActionResult Create(Models.TicketModel ticket)
        {
            try
            {
                string color = ticket.TicketColor;
                string day = DateTime.Now.DayOfWeek.ToString();
                int index = 0, day_value = 0, color_value = 0;
                var days = Enum.GetValues(typeof(Days));
                var colors = Enum.GetValues(typeof(Colors));
                foreach (var d in days)
                {
                    index += 1;
                    if (day == $"{d}")
                        day_value = index - 1;
                }
                index = 0;
                foreach (var c in colors)
                {
                    index += 1;
                    if (color == $"{c}")
                        color_value = index - 1;
                }
                ticket.Day = day;
                string attendStr = Newtonsoft.Json.JsonConvert.SerializeObject(ticket);
                string conStr = "DefaultEndpointsProtocol=https;AccountName=santhosh89;AccountKey=/lJn+kNlBSfWOUYtUhRnB1K8Hf7W+SF4OXXHIAppHhqctw2/a7vKJfITLHLtzWhy1rMYDQ4Yq1Gu4MaSr8hWqA==;EndpointSuffix=core.windows.net";

                try
                {
                    UploadTicketDetails(conStr, attendStr, "ticket", true);
                    ViewBag.Result = "Ticket Details are Uploaded Successfully.";
                }
                catch (Exception ex)
                {
                    ViewBag.Result = "Failed to update blob " + ex.Message;
                }
                return View("Views/Ticket/Ticket.cshtml");
            }
            catch
            {
                return View("Views/Ticket/Ticket.cshtml");
            }
        }

        public static string UploadTicketDetails(string conStr, string fileContent, string containerName, bool isAppend = false)
        {
            string result = "Success";
            try
            {

                var serviceClient = new BlobServiceClient(conStr);
                var containerClient = serviceClient.GetBlobContainerClient(containerName);

                var fileName = "ticketdetails.txt";
                string existingContent = "";
                var blobClient = containerClient.GetBlobClient(fileName);

                if (isAppend)
                {
                    string fillerStart = "";
                    string fillerEnd = "]";
                    existingContent = GetTicketDetailsFromBlob(conStr, fileName, containerName);
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

        private static string GetTicketDetailsFromBlob(string conStr, string fileName, string containerName)
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
    }
}
