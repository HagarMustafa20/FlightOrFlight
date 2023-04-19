using MVC_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_EF.Controllers
{
    
    public class StudentController : Controller
    {

        ITIEntities context = new ITIEntities();
        // GET: Student
        public ActionResult getAll()
        {
            ViewBag.departments = context.Department;
            return View(context.Student.ToList());
        }
        [HttpPost]
        public ActionResult getAll(int? id)
        {
            ViewBag.departments = context.Department.ToList();
            var std = context.Student.Where(x => x.Dept_Id == id).ToList();
            return View(std);
        }




        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            Student student = context.Student.Find(id);
            ViewBag.Departments = context.Department.ToList();
            return View(student);
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Student student)
        {
            try
            {
                // TODO: Add update logic here
                Student student1 = context.Student.Find(id);

                student1.St_Id = student.St_Id;
                student1.St_Fname = student.St_Fname;
                student1.St_Lname = student.St_Lname;
                student1.St_Age = student.St_Age;
                student1.St_Address = student.St_Address;
                student1.St_super = student.St_super;
                
                context.SaveChanges();
                return RedirectToAction("getAll");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
