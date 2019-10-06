using ChemiCleanDataLibrary.BusinessLogic;
using ChemiCleanDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChemiCleanMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Products()
        {
            ViewBag.Message = "Display Products.";

            var data = ProductProcessor.LoadProducts();
            List<ProductModel> products = new List<ProductModel>();

            data.ForEach(row =>
            {
                products.Add(new ProductModel
                {
                    Id = row.Id,
                    ProductName = row.ProductName,
                    SupplierName = row.SupplierName,
                    URL = row.URL,
                    Username = row.Username,
                    Password = row.Password
                });
            });


            return View(products);
        }
    }
}