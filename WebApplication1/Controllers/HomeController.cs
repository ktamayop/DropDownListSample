using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new ViewModel
            {
                sermon = new SermonModel
                {
                    Series_ID = 3
                },
                seriesList = new List<SeriesModel>
                {
                    new SeriesModel{Series_ID = 1, Series_Title = "Serie 1"},
                    new SeriesModel{Series_ID = 2, Series_Title = "Serie 2"},
                    new SeriesModel{Series_ID = 3, Series_Title = "Serie 3"},
                    new SeriesModel{Series_ID = 4, Series_Title = "Serie 4"}
                },
                series = new SeriesModel()
            };

            return View(model);
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
    }
}