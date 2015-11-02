using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionStateAsync.Controllers
{
    [OutputCache(NoStore = true, Duration = 0)]
    public class HomeController : Controller
    {
        public List<string> boxes = new List<string>() { "red", "green", "blue", "black", "gray", "yellow", "orange" };
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public string GetBox()
        {
            System.Threading.Thread.Sleep(10);
            Random rnd = new Random();
            int index = rnd.Next(0, boxes.Count);

            return boxes[index];
        }

        public ActionResult StartSession()
        {
            System.Web.HttpContext.Current.Session["Name"] = "Chris";

            return RedirectToAction("Index");
        }
    }
}