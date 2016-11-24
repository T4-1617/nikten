using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Table_SDK_test.Models;
using Microsoft.Azure; // Namespace for CloudConfigurationManager
using Microsoft.WindowsAzure.Storage; // Namespace for CloudStorageAccount
using Microsoft.WindowsAzure.Storage.Table; // Namespace for Table storage types

namespace Table_SDK_test.Controllers
{
    public class HomeController : Controller
    {
        // Parse the connection string and return a reference to the storage account.
        CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
            CloudConfigurationManager.GetSetting("StorageConnectionString"));

        // Create the table client.
        CloudTableClient tableClient = storageAccount.CreateCloudTableClient();




        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RSVP()
        {
            return View();
        }

        public ViewResult RSVP(GuestResponse g)
        {
            if (ModelState.IsValid == true)
            {
                return View("Thanks", g);
            }

            return View();
        }
    }
}