using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PwI.Domain.Entities;

namespace PwI.Controllers
{
    public class HomeController : Controller
    {
        private List<Car> Cars;

        public HomeController()
        {
            Cars = new List<Car>
            {
                new Car {Id = 1,Model = "w233", Name = "Mercedes", price = 150, ProductionYear = 2016},
                new Car {Id = 2,Model = "w233", Name = "Mercedes", price = 150, ProductionYear = 2017},
                new Car {Id = 3,Model = "Croma", Name = "Fiat", price = 110, ProductionYear = 2018},
                new Car {Id = 4,Model = "Croma", Name = "Fiat", price = 80, ProductionYear = 2014},
                new Car {Id = 5,Model = "Ceed", Name = "Kia", price = 100, ProductionYear = 2017},
                new Car {Id = 6,Model = "Ceed", Name = "Kia", price = 100, ProductionYear = 2017},
                new Car {Id = 7,Model = "Tipo", Name = "Fiat", price = 120, ProductionYear = 2017},



            };
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Last";

            return View(Cars);
        }

    }
}