    using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebApplication2.Models;
using WebApplication2.repository;

namespace WebApplication2.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



        IList<Student> studentList = new List<Student>() {
                    new Student(){ StudentId=1, StudentName="Steve", Age = 21 },
                    new Student(){ StudentId=2, StudentName="Bill", Age = 25 },
                    new Student(){ StudentId=3, StudentName="Ram", Age = 20 },
                    new Student(){ StudentId=4, StudentName="Ron", Age = 31 },
                    new Student(){ StudentId=5, StudentName="Rob", Age = 19 }
                };
        public ActionResult Details()
        {
            //ViewBag.Message = "Details Page.";
            ViewBag.totalStudetns = studentList;

            return View();
        }




        public ActionResult StudentMan()
        {
            ViewBag.message = "Your StudentMan page";

            return View();
        }



       

       
    }
}