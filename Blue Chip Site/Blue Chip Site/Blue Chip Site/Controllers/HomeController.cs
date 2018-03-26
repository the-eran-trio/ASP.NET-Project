using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blue_Chip_Site.DAL;
using Blue_Chip_Site.Models;

namespace Blue_Chip_Site.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
           // ProductDAL dal = new ProductDAL();
           // List<Product> model = dal.GetProducts();

           // Don't for get to add the model back into the parameters of the view

            return View();
        }
    }
}