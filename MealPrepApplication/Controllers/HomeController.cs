using MealPrepApplication.Meals;
using MealPrepApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using MealPrepApplication.Views.Shared;

namespace MealPrepApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Recipes()
        {
            return View();
        }

        [Route("meal/{id}")]
        public IActionResult MealPage(int id)
        {
            Meal meal = id switch
            {
                4 => new Meal
                {
                    Title = "Marry Me chimkin Meatballs",
                    Ingredients = Utilities.getIngredients("Marry Me Chicken Meatballs")
                },
                _ => new Meal
                {
                    Title = "Meal Name goes here",
                    Ingredients = Utilities.getIngredients("")
                }
            };
            return View(meal);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
