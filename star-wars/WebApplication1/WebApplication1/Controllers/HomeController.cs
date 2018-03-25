using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    // This naming indicates the root of the website with the "Home" name.
    // All controllers end with the name controller
    // The " : " indicates that this class inherites from the interface controller
    public class HomeController : Controller
    {
        // GET: Home
        // Here Index is the view that we want to call, as indicated with our return View()
        public ActionResult Index()
        {
            StarWarsCharacterDAL dal = new StarWarsCharacterDAL();
            List<StarWarsCharacter> model = dal.GetCharacters();

            return View(model);
        }
    }
}