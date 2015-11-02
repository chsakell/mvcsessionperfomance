using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace SessionStateAsync.Controllers
{
    [OutputCache(NoStore = true, Duration = 0)]
    [SessionState(SessionStateBehavior.Disabled)]
    public class SessionResolvedController : Controller
    {
        public List<string> boxes = new List<string>() { "red", "green", "blue", "black", "gray", "yellow", "orange" };

        public string GetBox()
        {
            try
            {
                System.Threading.Thread.Sleep(10);
                //object name = System.Web.HttpContext.Current.Session["Name"];
                Random rnd = new Random();
                int index = rnd.Next(0, boxes.Count);

                return boxes[index];
            }
            catch(Exception ex)
            {
                return "red";
            }
        }
    }
}