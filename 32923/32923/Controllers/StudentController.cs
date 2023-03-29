using Microsoft.AspNetCore.Mvc;
using _32923.Models;
using System.Collections.Generic;
using _32923.ViewModels;

namespace _32923.Controllers
{
    public class StudentController : Controller
    {
        private readonly List<Student> _students;
        private readonly List<Group> _groups;

        public StudentController()
        {
            _students = new List<Student> {
                new Student { Id = 1, FullName = "Elvin bilalov", Point = 89 },
                new Student { Id = 2, FullName = "Maqsud maqsudzade", Point = 100 },
                new Student { Id = 3, FullName = "Amin israfilzade", Point = 112 },
                new Student { Id = 4, FullName = "Huseyn arrayzade", Point = 44 }
            };

            _groups = new List<Group> {
                new Group { Id = 1, Name = "P2232"},
                new Group { Id = 2, Name = "D193"},
                new Group { Id = 3, Name = "E285"},
                new Group { Id = 4, Name = "C197" }
            };
        }



        public ActionResult Index()
        {
            StdGrp stdgrp = new StdGrp()
            {
                Students = _students,
                Groups = _groups
            };
            return View(stdgrp);
        }
        public ActionResult Detail(int id)
        {
            Student std = new Student();
            std = _students.Find(x => x.Id == id);
             return View(std);
        }
    }

}

