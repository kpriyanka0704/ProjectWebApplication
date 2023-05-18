using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectWebApplication.Models;

namespace ProjectWebApplication.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult AddStudent()
        {
            List<string> options = new List<string>() { "Select City", "Pune", "Nashik", "Mumbai", "Beed", "Ahmednagar" };
            ViewData["city"] = new SelectList(options);
            List<string> options1 = new List<string>() { "Select Year", "1st Year", "2nd Year", "3rd Year", "4th year" };
            ViewData["year"] = new SelectList(options1);
            return View();

        } 
        public IActionResult StudentList()
        {
           
            List<Student> Students = new List<Student>()
            {
                new Student{RollNo=1,Name="Rohan",City="Pune",Percentage=67.77M},
                new Student{RollNo=2,Name="Suraj",City="Nashik",Percentage=57.77M},
                new Student{RollNo=3,Name="Amol",City="Beed",Percentage=69.77M},
                new Student{RollNo=4,Name="Kishor",City="Mumbai",Percentage=69.77M},
                new Student{RollNo=5,Name="Akshay",City="Ahmednagar",Percentage=68.77M},
            };
            ViewBag.Students = Students;
            return View();

        }

        [HttpPost]
        public IActionResult AddStudent(IFormCollection form)
        {
            ViewBag.RollNo = form["rollno"];
            ViewBag.Name = form["name"];
            ViewBag.City = form["city"];
            ViewBag.Gender = form["gender"];
            ViewBag.CurrentYear = form["year"];
            return View("Details");
        }
       
    }
}

