using EntityFrameWorkDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameWorkDemo.Controllers
{
    public class HomeController : Controller
    {

        DbStudent context;
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Index(Student student)
        {
            context = new DbStudent();
            context.Student.Add(student);
            context.SaveChanges();

            // Display
            context = new DbStudent();
            IEnumerable<Student> s = context.Student;

            return View("Display", s);
        }

        public ViewResult Display()
        {
            // Display
            context = new DbStudent();
            IEnumerable<Student> s = context.Student;
            return View(s);
        }

        public ViewResult Edit(string StudentName)
        {
            context = new DbStudent();
            IEnumerable<Student> s = context.Student;
            Student currentstudent = s.FirstOrDefault(p => p.StudentName == StudentName);

            return View("Index", currentstudent);
        }

        public ActionResult Delete(string StudentName)
        {
            context = new DbStudent();
            IEnumerable<Student> s = context.Student;
            Student currentstudent = s.FirstOrDefault(p => p.StudentName == StudentName);
            context.Student.Remove(currentstudent);
            context.SaveChanges();

            //IEnumerable<Student> ss = context.Student;
            return RedirectToAction("Display");
        }
    }
}