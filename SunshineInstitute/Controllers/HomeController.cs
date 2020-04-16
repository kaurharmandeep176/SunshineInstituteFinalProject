using SunshineInstitute.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SunshineInstitute.Controllers
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

        public ActionResult Gallery()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Thanks()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



        public ActionResult passMessage(Contact Admin)
        {
            Login data = new Login();
            string qry = "insert into MsgQuery(Name,Email,Msg) values('"+Admin.ClientName+"','"+Admin.ClientEmail+"','"+Admin.ClientMessage+"')";
            data.SqlQuery(qry);
            return View("Thanks");

        }

    }
}