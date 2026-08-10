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
                1 => new Meal
                {
                    Title = "Chimkin Carnitas Tacos w/ Avocado Sauce",
                    Ingredients = Utilities.getIngredients("Chimkin Carnitas Tacos w/ Avocado Sauce")
                },
                3 => new Meal
                {
                    Title = "Grilled Balsamic Chicken with Burrata and Peaches",
                    Ingredients = Utilities.getIngredients("Grilled Balsamic Chicken with Burrata and Peaches")
                },
                4 => new Meal
                {
                    Title = "Marry Me chimkin Meatballs",
                    Ingredients = Utilities.getIngredients("Marry Me Chicken Meatballs")
                },
                15 => new Meal
                {
                    Title = "Teriyaki Pineapple Chimkin Meatballs",
                    Ingredients = Utilities.getIngredients("Teriyaki Pineapple Chicken Meatballs")
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
