using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace star_wars.Controllers
{
    // This is the naming convetion for a "Home" controller. 
    // The colon ( : ) means that this object inherits from the Controller object in this case
    // When a file is loaded into the web browser, it loads under the URL with just the first name of the controller
    // and then the name of the Action after that. ex) http://localhost:50589/Home/Index
    public class HomeController : Controller
    {
        // GET: Home "action" which returns a type of ActionResult, in this case Index()
        public ActionResult Index()
        {
            return View();
        }
    }
}