//using System;
using System.Linq;
//using System.Web;
using Car_CoreApp.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace Car_CoreApp.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult getAll()
        {
            List<Car> carLst = CarList.Cars;

            ViewBag.Cars = carLst;

            return View();
        }

        public ActionResult getByNum(int id)
        {
            ViewBag.selectedCar = CarList.Cars.FirstOrDefault(e => e.Num == id);

            return View();
        }

        public ActionResult Edit(int id)
        {
            ViewBag.selectedCar = CarList.Cars.FirstOrDefault(e => e.Num == id);

            return View();
        }

        [HttpPost]
        public ActionResult Edit(int num, string color, string model, string manfacture)
        {
            Car edidtedCar = CarList.Cars.FirstOrDefault(e => e.Num == num);

            edidtedCar.Color = color;
            edidtedCar.Model = model;
            edidtedCar.Manfacture = manfacture;

            return RedirectToAction("getAll");
        }
        public ActionResult Create()
        {
            ViewBag.selectedCar = new Car();
            return View();
        }

        [HttpPost]
        public ActionResult create(int num, string color, string model, string manfacture)
        {
            Car newCar = new Car { Num = num, Color = color, Model = model, Manfacture = manfacture };

            CarList.Cars.Add(newCar);

            return RedirectToAction("getAll");
        }


        public ActionResult delete(int id)
        {
            var deletedCar = CarList.Cars.FirstOrDefault(e => e.Num == id);
            CarList.Cars.Remove(deletedCar);
            return RedirectToAction("getAll");

        }
    }
}
