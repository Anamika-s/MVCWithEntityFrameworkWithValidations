using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCDemo3.Context;
using MVCDemo3.Models;

namespace MVCDemo3.Controllers
{
    public class StudentController : Controller
    {

        StudentDbContext _context;
        public StudentController(StudentDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {

            return View(_context.Students.ToList());
        }

        public IActionResult Details(int id)
        {
            var student = _context.Students.FirstOrDefault(
                x => x.Id == id);
            if (student != null)
                return View(student);
            else
                ViewBag.msg = "Record with this ID do not exist";
            return View();
        }

        public IActionResult Create()
        {

            return View(new Student());
        }

        [HttpPost]
        public IActionResult Create(Student student)

        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {
            var student = _context.Students.FirstOrDefault(
                x => x.Id == id);
            if (student != null)
                return View(student);
            else
                ViewBag.msg = "Record with this ID do not exist";
            return View();

        }

        [HttpPost]
        public IActionResult Delete(Student student)
        {
            var temp = _context.Students.FirstOrDefault(
                x => x.Id == student.Id);
            if (temp != null)
            {
                _context.Students.Remove(temp);
                _context.SaveChanges();
                 
            }

            return RedirectToAction("Index");

        }

        public IActionResult Edit(int id)
        {
            var student = _context.Students.FirstOrDefault(
                x => x.Id == id);
            if (student != null)
                return View(student);
            else
                ViewBag.msg = "Record with this ID do not exist";
            return View();

        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            var temp = _context.Students.FirstOrDefault(
                x => x.Id == student.Id);
            if (temp != null)
            {
                foreach (Student obj in _context.Students)
                {
                    if (obj.Id == student.Id)
                    {
                        obj.Marks = student.Marks;

                    }
                }
                _context.SaveChanges();
                
            }

            return RedirectToAction("Index");

        }
    }
}
