using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalWebsite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            Server.Transfer("Default.aspx");
            return "sss";
        }
    }
}