using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCDemos.Models;

namespace MVCDemos.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            //Student student = new Student();
            //student.Id = 1;
            //student.Name = "Ajay";
            //student.BatchCode = "B001";
            //student.Marks = 90;

            // Object Initializer

            Student student = new Student()
            {
                Id = 1,
                Name = "Ajay",
                BatchCode = "B001",
                Marks = 90
            };
            ViewBag.student = student;
            return View();
        }

        public IActionResult Index1()
        {
            //Student student = new Student();
            //student.Id = 1;
            //student.Name = "Ajay";
            //student.BatchCode = "B001";
            //student.Marks = 90;

            // Object Initializer

            Student student = new Student()
            {
                Id = 1,
                Name = "Ajay",
                BatchCode = "B001",
                Marks = 90
            };
            //ViewBag.student = student;
            return View(student);
        }

        //public IActionResult StudentsList()
        //{
        //    List<Student> list = new List<Student>();

        //    list.Add(new Student()
        //    {
        //        Id = 1,
        //        Name = "Ajay",
        //        BatchCode = "B001",
        //        Marks = 90
        //    });
        //    list.Add(new Student()
        //    {
        //        Id = 2,
        //        Name = "Ajay",
        //        BatchCode = "B001",
        //        Marks = 90
        //    });
        //    return View();
        //}

        public IActionResult StudentsList()
        {
            List<Student> studentList = new List<Student>()
            {
                 new Student() {Id = 1,
                Name = "Ajay",
                BatchCode = "B001",
                Marks = 90},
                 new Student() {Id = 2,
                Name = "Deepak",
                BatchCode = "B002",
                Marks = 90 },
                 new Student(){Id = 3,
                Name = "Kavya",
                BatchCode = "B001",
                Marks = 90 },
                 new Student(){Id = 4,
                Name = "Maneesh",
                BatchCode = "B001",
                Marks = 90 }
            };
            ViewBag.Students = studentList;
            return View();
        }

        public IActionResult StudentsList2()
        {
            List<Student> studentList = new List<Student>()
            {
                 new Student() {Id = 1,
                Name = "Ajay",
                BatchCode = "B001",
                Marks = 90},
                 new Student() {Id = 2,
                Name = "Deepak",
                BatchCode = "B002",
                Marks = 90 },
                 new Student(){Id = 3,
                Name = "Kavya",
                BatchCode = "B001",
                Marks = 90 },
                 new Student(){Id = 4,
                Name = "Maneesh",
                BatchCode = "B001",
                Marks = 90 }
            };
            //ViewBag.Students = studentList;
            return View(studentList);
        }
    }
}
