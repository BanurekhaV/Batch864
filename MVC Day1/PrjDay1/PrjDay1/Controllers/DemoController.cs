using PrjDay1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrjDay1.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        //Normal Method that returns a string
        public string NormalMethod()
        {
            return "Hello All!";
        }

        //View Result 
        public ViewResult ViewMethod()
        {
           // ViewData["val"] = "understanding View Data";
            return View();
        }

        //content Result

        public ContentResult ContentMethod()
        {
            // return Content("Good Morning!!", "text/plain");
            return Content("<h1>Good Morning to all of You!!</h1>", "text/html");
        }

        //empty result not for display
        public EmptyResult EmptyMethod()
        {
            int amt = 5000;
            float increase = (amt * 3 * 2) / 100;
            return new EmptyResult();
        }

        //return a Json Object

        public JsonResult JsonMethod()
        {
            
            Employee e = new Employee();
            e.Id = 100;
            e.Age = 27;
            e.Name = "Sunil";
            return Json(e, JsonRequestBehavior.AllowGet);

        }
        
    }
}