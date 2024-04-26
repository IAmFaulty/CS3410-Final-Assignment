/*
* Course: CS 3410
* Section: 02
* Name: Alhasan Mohsen
* Professor: Jyothsna Dinadayalane
* Assignment #: Module Assignment #8
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCartV2.Models;

namespace ShoppingCartV2.Controllers
{
    public partial class HomeController : Controller
    {
        // Text for Site Heading
        string siteHeading = "Canned Foods Store";

        // Text for Order View Heading
        string orderHeading = "Cake Orders";

        // Text for View Heading for each Tab
        string[] tabHeadings = { "Home", "Canned Fruits", "Canned Vegetables", "Canned Meats",
                                         "Check-Out", "Admin", "About" };

        // View label displayed on each Tab
        string[] tabLabels = { "Home", "Canned Fruits", "Canned Vegetables", "Canned Meats",
                                       "Check-Out", "Admin", "About" };

        // View method name for each Tab
        string[] tabViews = { "Index", "Tab1Orders", "Tab2Orders", "Tab3Orders",
                                       "CheckOut", "Admin", "About" };

        // Text for View Heading of any Options columns
        string[] optionsColumnHeading = { "", "Canned Fruit Customization",
                                              "", "", "" };

        // The tax rate is 5%
        decimal taxRate = 0.06M;

        // Action Method for Home page View
        public ActionResult Index()
        {
            Session["PageHeading"] = siteHeading;

            ViewBag.Message = "Welcome To The " + siteHeading;
            ViewBag.Message2 = "<img src=\"/Images/welcome.jpg\">";
            ViewBag.Message2 += "<br />Where you can get anything in a can!";
            return View();
        }

        // Action Method for About page View
        public ActionResult About()
        {
            Session["PageHeading"] = siteHeading;

            ViewBag.Message = "About the " + siteHeading;
            ViewBag.Message2 = "I am Alhasan Mohsen, the webmaster, mwahaha!.";
            ViewBag.Message2 += "<img src=\"/Images/face.jpg\">";
            return View();
        }

        // Action Method for First Product View
        public ActionResult Tab1Orders()
        {
            return GetTabView(1);
        }

        // Action Method to Process First Product View
        [HttpPost]
        public ActionResult Tab1Orders(string button, FormCollection collection)
        {
            return ProcessTabView(1, button, collection);
        }

        public ActionResult Tab2Orders()
        {
            return GetTabView(1);
        }

        // Action Method to Process First Product View
        [HttpPost]
        public ActionResult Tab2Orders(string button, FormCollection collection)
        {
            return ProcessTabView(1, button, collection);
        }

        public ActionResult Tab3Orders()
        {
            return GetTabView(1);
        }

        // Action Method to Process First Product View
        [HttpPost]
        public ActionResult Tab3Orders(string button, FormCollection collection)
        {
            return ProcessTabView(1, button, collection);
        }
    }
}