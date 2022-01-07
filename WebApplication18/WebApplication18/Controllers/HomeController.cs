using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication18.Models;

namespace WebApplication18.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public static string accessStr = "DefaultEndpointsProtocol=https;AccountName=firstaccount002;AccountKey=Faxwn0jUug2dHV4pg0lY/+rFXaI+UMAJnFVNtwPziFTrPTdOv4PnsmrTtVQhKaTpLJWhzPmvjxmH5X2adznjrw==;EndpointSuffix=core.windows.net";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult ContainerView(ContainerModel model)
        {
            try
            {
                BlobContainerClient container = new BlobContainerClient(accessStr, model.ContainerName.ToLower());
                container.Create();
                ViewBag.ContainerCreateStatus = "Container created";
            }
            catch(Exception ex)
            {
                ViewBag.ContainerCreateStatus = "Container not created is " + ex.Message;
            }
            return View("/views/ContainerView.cshtml");
        }
        public IActionResult Index()
        {
            return View("/views/ContainerView.cshtml");
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
