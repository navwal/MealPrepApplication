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
                2 => new Meal
                {
                    Title = "Cilantro Orange Chimkin Bites",
                    Ingredients = Utilities.getIngredients("Cilantro Orange Chimkin Bites")
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
                5 => new Meal
                {
                    Title = "Hot Honey Chimken w/ Peach Salsa",
                    Ingredients = Utilities.getIngredients("Hot Honey Chimken w/ Peach Salsa")
                },
                6 => new Meal
                {
                    Title = "Chimkin Enchilada Boats",
                    Ingredients = Utilities.getIngredients("Chimkin Enchilada Boats")
                },
                7 => new Meal
                {
                    Title = "Spicy Mediterranean chimkin w/ Cucumber Salad",
                    Ingredients = Utilities.getIngredients("Spicy Mediterranean chimkin w/ Cucumber Salad")
                },
                8 => new Meal
                {
                    Title = "(Sheet pan) Mediterranean chimkin w/ Yogurt sauce",
                    Ingredients = Utilities.getIngredients("(Sheet pan) Mediterranean chimkin w/ Yogurt sauce")
                },
                9 => new Meal
                {
                    Title = "Balsamic Chimkin",
                    Ingredients = Utilities.getIngredients("Balsamic Chimkin")
                },
                10 => new Meal
                {
                    Title = "Cheesy Asparagus Stuffed Chimkin",
                    Ingredients = Utilities.getIngredients("Cheesy Asparagus Stuffed Chimkin")
                },
                11 => new Meal
                {
                    Title = "Chimkin w/ Mediterranean Salsa",
                    Ingredients = Utilities.getIngredients("Chimkin w/ Mediterranean Salsa")
                },
                12 => new Meal
                {
                    Title = "Pork/Potato Taco Bowl",
                    Ingredients = Utilities.getIngredients("Pork/Potato Taco Bowl")
                },
                13 => new Meal
                {
                    Title = "Potato Thing",
                    Ingredients = Utilities.getIngredients("Potato Thing")
                },
                14 => new Meal
                {
                    Title = "Meal Prep",
                    Ingredients = Utilities.getIngredients("Meal Prep")
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
