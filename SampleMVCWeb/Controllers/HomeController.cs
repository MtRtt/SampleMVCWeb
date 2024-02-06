using Microsoft.AspNetCore.Mvc;
using SampleMVCWeb.Models;
using System.Diagnostics;

namespace SampleMVCWeb.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult Details()
        {
            ViewData["Title"] = "Student Details Page";
            ViewData["Header"] = "Student Details";

            Student student = new Student()
            {
                StudentId = 1,
                Name = "Taghi",
                Branch = "CSE",
                Section = "A",
                Gender = "Male"
            };
            ViewData["Student"] = student;
            return View();
        }
    }
}