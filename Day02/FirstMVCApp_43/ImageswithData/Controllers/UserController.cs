using ImageswithData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImageswithData.Controllers
{
    public class UserController : Controller
    {
        // GET: User

       
        public ActionResult getById(int id)
        {
            ViewBag.user = UsersList.users.FirstOrDefault(e => e.Id==id);
            return View();
        }
        public ActionResult Create()
        {
            ViewBag.newuser = new UserData();
            return View();
        }
        [HttpPost]
        public ActionResult Create(int id , string name , string image)
        {
            UserData user = new UserData() { Id = id, Name = name, Image = image };
            UsersList.users.Add(user);
            return RedirectToAction("getById", new {id=user.Id});
        }
    }
}