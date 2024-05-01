using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BusinessLogic;

namespace MVCBusiness.Controllers
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

        private EmployeeContext empContext = new BusinessLogic.EmployeeContext();
        public ActionResult GetAllEmployee()
        {
            var employeeDataTable = empContext.SelectEmployee(); // Retrieve student data
            var employeeList = empContext.ConvertDataTableToList(employeeDataTable); // Convert DataTable to List<StudentModel>
            return View(employeeList); // Pass the list of students to the view
        }



        // GET: Student/Create
        public ActionResult Create()
        {
            ViewBag.message = "Your Add Student page";
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                empContext.AddEmployee(emp);
                return RedirectToAction("GetAllEmployee");
            }

            return View(emp);
        }




        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            // Retrieve student details by ID
            var employeeDataTable = empContext.SelectEmployee(); // Retrieve student data
            var employeeList = empContext.ConvertDataTableToList(employeeDataTable); // Convert DataTable to List<StudentModel>
            return View(employeeList.Find(Std => Std.id == id));
        }







        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            // Retrieve student details by ID
            var employeeDataTable = empContext.SelectEmployee(); // Retrieve student data
            var employeeList = empContext.ConvertDataTableToList(employeeDataTable); // Convert DataTable to List<StudentModel>
            return View(employeeList.Find(Std => Std.id == id));
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee emp)
        {
            if (ModelState.IsValid)
            {
                empContext.UpdateEmployee(emp);
                return RedirectToAction("GetAllEmployee");
            }

            return View(emp);
        }



        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {

                if (empContext.DeleteConfirm(id))
                {
                    ViewBag.AlertMsg = "Employee details deleted successfully";

                }
                return RedirectToAction("GetAllEmployee");

            }
            catch
            {
                return RedirectToAction("Index");
            }

        }

    }
}