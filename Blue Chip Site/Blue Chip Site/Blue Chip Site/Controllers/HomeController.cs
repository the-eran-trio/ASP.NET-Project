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
           ProductDAL dal = new ProductDAL();
           List<Product> model = dal.GetProducts();

            return View(model);
        }

        public ActionResult Detail(String name)
        {
            List<String> model = new List<String>();

            if(name.Equals("Our Services"))
            {
                model.Add("Business is transforming and technology is at the center.");
                model.Add("​​​IT delivery for mergers, acquisitions and divestitures.");
                model.Add("Consolidation");
                model.Add("Connect the disconnected. Effectively and efficiently integrate disparate applications, servers and systems into one, optimized platform.");
                model.Add("Modernization");
                model.Add("Modernize in order to meet new demands and beat out the competition by moving workloads to the cloud.");
                model.Add("Optimization");
                model.Add("Decrease cost and increase productivity. Realize the full value of your IT infrastructure and investment while freeing up IT to focus on strategic projects.");
            }

            if (name.Equals("We're Growing"))
            {
                model.Add("Blue Chip Expands into St. Louis, Missouri");
                model.Add("As a result of the increased demand for experienced IT partners in Central and Southeast United States, " +
                    "Blue Chip is proud to announce its expansion into St. Louis, Missouri. Now, more than ever, enterprise organizations " +
                    "are investing in Microsoft technologies and cloud computing,” said Jim Peelman, CEO at Blue Chip. “As a result, there " +
                    "is a growing need for IT partners who can successfully implement and optimize Microsoft products and services.Blue " +
                    "Chip is committed to being that IT partner and to helping Fortune 1000 companies maximize the value of their Microsoft " +
                    "investment and move to the cloud. “In 2017, Blue Chip invested $1.3 million in its Cleveland headquarters to accommodate" + 
                    "team growth; increase client collaboration; and enhance training facilities. Blue Chip also expanded into Nashville, " +
                    "Tennessee and Louisville, Kentucky. In 2018, Blue Chip will focus on the development of St.Louis, bringing an estimated " +
                    "40 jobs to the region. Blue Chip’s expansion into St. Louis will be led by newly appointed Senior Vice President of Emerging " +
                    "Marketing, Tony Guidi. “Our goal is to help an increasing number of enterprise clients capitalize on advances in cloud " +
                    "computing and Microsoft technologies,” said Guidi. “We also welcome the opportunity to build new relationship with " +
                    "partners and vendors as we have done with exceptional success in the Midwest. Individuals interested in joining Blue Chip's" +
                    " St. Louis team are encouraged to apply here.");
            }

            if (name.Equals("Entrepreneur 360"))
            {
                model.Add("Blue Chip Named One of the Most Entrepreneurial Companies in America");
                model.Add("Recently, Blue Chip was named one of the most entrepreneurial companies in America by Entrepreneur Magazine. " +
                    "Each year, Entrepreneur Magazine identifies 360 small businesses that are successfully growing their companies.To do " +
                    "this, they invite companies from all over the nation to apply. Then, they evaluate applications for entrepreneurship using" +
                    " four key metrics: impact, innovation, growth, and leadership. The result is their annual Entrepreneur 360 list. We’re thrilled" +
                    " to announce that Blue Chip made Entrepreneur Magazine’s 2017 list and was named the 101st most entrepreneurial " +
                    "company in the country. You can see the full list and Blue Chip's company profile here. To learn more about working at Blue" +
                    " Chip, visit www.bluechip-llc.com/careers.");
            }

            return View(model);
        }
    }
}