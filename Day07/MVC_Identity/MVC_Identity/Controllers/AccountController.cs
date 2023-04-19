using MVC_Identity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using System.Web.WebSockets;

namespace MVC_Identity.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Client client)
        {
            //check if valid user (ModelState.IsValid)
           
            if (ModelState.IsValid)
            {
                ClientDbContext context = new ClientDbContext();

                //Insert newUser into DB
                context.Clients.Add(client);
                context.SaveChanges();

                //Create User Identity for this user Using Claims (Name, Email, Password, Phone
                var clientIdentity = new ClaimsIdentity(new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, client.Name),
                    new Claim(ClaimTypes.Email, client.Email),
                    new Claim("Password", client.Password)
                }, "Cookies");

                //Owin Cookie middleware, user identity to create cookie for this user to authenticate him
                //Owin Authentication manager
                Request.GetOwinContext().Authentication.SignIn(clientIdentity);

                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LogIn(Client client)
        {
            ClientDbContext context = new ClientDbContext();
            var loggedClient = context.Clients.FirstOrDefault(x => x.Email == client.Email && x.Password == client.Password);
            if (loggedClient != null)
            {
                var signInIdentity = new ClaimsIdentity(new List<Claim>()
                {
                    new Claim(ClaimTypes.Email, client.Email),
                    new Claim("Password", client.Password)
                }, "Cookies");

                //Owin Authentication manager
                Request.GetOwinContext().Authentication.SignIn(signInIdentity);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("Name", "Client is not Existed");

                return View();
            }
        }
        public ActionResult LogOut()
        {
            Request.GetOwinContext().Authentication.SignOut("Cookies");
            return RedirectToAction("LogIn");
        }
    }
}