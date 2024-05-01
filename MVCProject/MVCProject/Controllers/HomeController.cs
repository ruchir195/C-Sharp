using MVCProject.Models;
using MVCProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
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



        private ModelLogic modelLogic = new ModelLogic();

        // GET: Student/GetAllStudentDetails
        public ActionResult GetAllStudentDetails()
        {
            var studentDataTable = modelLogic.SelectStudents(); // Retrieve student data
            var studentList = modelLogic.ConvertDataTableToList(studentDataTable); // Convert DataTable to List<StudentModel>
            return View(studentList); // Pass the list of students to the view
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
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid) 
            {
                modelLogic.AddStudent(student);
                return RedirectToAction("Index");
            }

            return View(student);
        }




        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            // Retrieve student details by ID
            var studentDataTable = modelLogic.SelectStudents(); // Retrieve student data
            var studentList = modelLogic.ConvertDataTableToList(studentDataTable); // Convert DataTable to List<StudentModel>
            return View(studentList.Find(Std => Std.StudentID == id));
        }







        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            // Retrieve student details by ID
            var studentDataTable = modelLogic.SelectStudents(); // Retrieve student data
            var studentList = modelLogic.ConvertDataTableToList(studentDataTable); // Convert DataTable to List<StudentModel>
            return View(studentList.Find(Std => Std.StudentID == id));
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                modelLogic.UpdateStudent(student);
                return RedirectToAction("GetAllStudentDetails");
            }

            return View(student);
        }



        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {

                if (modelLogic.DeleteConfirm(id))
                {
                    ViewBag.AlertMsg = "Employee details deleted successfully";

                }
                return RedirectToAction("GetAllStudentDetails");

            }
            catch
            {
                return RedirectToAction("Index");
            }

        }

       

    }
}