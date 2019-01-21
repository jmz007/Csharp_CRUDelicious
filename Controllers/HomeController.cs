using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Csharp_CRUDelicious.Models;
using System.Linq;

namespace Csharp_CRUDelicious.Controllers
{

    public class HomeController : Controller
    {
        //"dbContext" here is just a variable name, we could replace it with anything.
        private DishContext dbContext;

        // here we can "inject" our context service into the constructor
        public HomeController(DishContext context)
        {
            dbContext = context;
        }
    
        [HttpGet("")]

        public IActionResult Index()
        {
            List<Dish> AllDishes = dbContext.Dishes.ToList();
            // Other code
            return View(AllDishes);
        }

        [HttpGet("new")]

        public IActionResult NewForm()
        {
            return View("NewForm");
        }

        [HttpGet("edit/{tempid}")]

        public IActionResult EditForm(int tempid)
        {
            Dish dish = dbContext.Dishes.SingleOrDefault(a => a.DishId == tempid);
            return View(dish);
        }


        [HttpPost]
        [RouteAttribute("AddDish")]
        public IActionResult AddDish(Dish NewDish)
        {
            if (ModelState.IsValid)
            {
                dbContext.Add(NewDish);
                dbContext.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                return View("NewForm");
            }
        }
        [HttpGet("{tempid}")]
        public IActionResult ShowOne(int tempid)
        {
            Dish dish = dbContext.Dishes.SingleOrDefault(a => a.DishId == tempid);
            return View(dish);
        }
       [HttpGet("delete/{tempid}")]
        public IActionResult DeleteDish(int tempid, Dish deleteddish)
        {
            Dish dish = dbContext.Dishes.SingleOrDefault(a => a.DishId == tempid);
            dbContext.Dishes.Remove(dish);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost("edit/{tempid}")]

        public IActionResult EditForm(int tempid, Dish editeddish)
        {
            Dish dish = dbContext.Dishes.SingleOrDefault(a => a.DishId == tempid);
            dish.Name = editeddish.Name;
            dish.Chef = editeddish.Chef;
            dish.Description = editeddish.Description;
            dish.Tastiness = editeddish.Tastiness;
            dish.Calories = editeddish.Calories;
            dish.UpdatedAt = editeddish.UpdatedAt;
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
