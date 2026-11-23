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
                    Ingredients = Utilities.getIngredients("Chimkin Carnitas Tacos w/ Avocado Sauce"),
                    Steps = Utilities.getSteps("Chimkin Carnitas Tacos w/ Avocado Sauce")
                },
                2 => new Meal
                {
                    Title = "Cilantro Orange Chimkin Bites",
                    Ingredients = Utilities.getIngredients("Cilantro Orange Chimkin Bites"),
                    Steps = Utilities.getSteps("Cilantro Orange Chimkin Bites")
                },
                3 => new Meal
                {
                    Title = "Grilled Balsamic Chicken with Burrata and Peaches",
                    Ingredients = Utilities.getIngredients("Grilled Balsamic Chicken with Burrata and Peaches"),
                    Steps = Utilities.getSteps("Grilled Balsamic Chicken with Burrata and Peaches")
                },
                4 => new Meal
                {
                    Title = "Marry Me chimkin Meatballs",
                    Ingredients = Utilities.getIngredients("Marry Me Chicken Meatballs"),
                    Steps = Utilities.getSteps("Marry Me Chicken Meatballs")
                },
                5 => new Meal
                {
                    Title = "Hot Honey Chimken w/ Peach Salsa",
                    Ingredients = Utilities.getIngredients("Hot Honey Chimken w/ Peach Salsa"),
                    Steps = Utilities.getSteps("Hot Honey Chimken w/ Peach Salsa")
                },
                6 => new Meal
                {
                    Title = "Chimkin Enchilada Boats",
                    Ingredients = Utilities.getIngredients("Chimkin Enchilada Boats"),
                    Steps = Utilities.getSteps("Chimkin Enchilada Boats")
                },
                7 => new Meal
                {
                    Title = "Spicy Mediterranean chimkin w/ Cucumber Salad",
                    Ingredients = Utilities.getIngredients("Spicy Mediterranean chimkin w/ Cucumber Salad"),
                    Steps = Utilities.getSteps("Spicy Mediterranean chimkin w/ Cucumber Salad")
                },
                8 => new Meal
                {
                    Title = "(Sheet pan) Mediterranean chimkin w/ Yogurt sauce",
                    Ingredients = Utilities.getIngredients("(Sheet pan) Mediterranean chimkin w/ Yogurt sauce"),
                    Steps = Utilities.getSteps("(Sheet pan) Mediterranean chimkin w/ Yogurt sauce")
                },
                9 => new Meal
                {
                    Title = "Balsamic Chimkin",
                    Ingredients = Utilities.getIngredients("Balsamic Chimkin"),
                    Steps = Utilities.getSteps("Balsamic Chimkin")
                },
                10 => new Meal
                {
                    Title = "Cheesy Asparagus Stuffed Chimkin",
                    Ingredients = Utilities.getIngredients("Cheesy Asparagus Stuffed Chimkin"),
                    Steps = Utilities.getSteps("Cheesy Asparagus Stuffed Chimkin")
                },
                11 => new Meal
                {
                    Title = "Chimkin w/ Mediterranean Salsa",
                    Ingredients = Utilities.getIngredients("Chimkin w/ Mediterranean Salsa"),
                    Steps = Utilities.getSteps("Chimkin w/ Mediterranean Salsa")
                },
                12 => new Meal
                {
                    Title = "Pork/Potato Taco Bowl",
                    Ingredients = Utilities.getIngredients("Pork/Potato Taco Bowl"),
                    Steps = Utilities.getSteps("Pork/Potato Taco Bowl")
                },
                13 => new Meal
                {
                    Title = "Potato Thing",
                    Ingredients = Utilities.getIngredients("Potato Thing"),
                    Steps = Utilities.getSteps("Potato Thing")
                },
                14 => new Meal
                {
                    Title = "Meal Prep",
                    Ingredients = Utilities.getIngredients("Meal Prep"),
                    Steps = Utilities.getSteps("Meal Prep")
                },
                15 => new Meal
                {
                    Title = "Teriyaki Pineapple Chimkin Meatballs",
                    Ingredients = Utilities.getIngredients("Teriyaki Pineapple Chicken Meatballs"),
                    Steps = Utilities.getSteps("Teriyaki Pineapple Chicken Meatballs")
                },
                16 => new Meal
                {
                    Title = "Teriyaki Chimkin Summer Rolls",
                    Ingredients = Utilities.getIngredients("Teriyaki Chimkin Summer Rolls"),
                    Steps = Utilities.getSteps("Teriyaki Chimkin Summer Rolls")
                },
                17 => new Meal
                {
                    Title = "Cream Cheese Chimkin",
                    Ingredients = Utilities.getIngredients("Cream Cheese Chimkin"),
                    Steps = Utilities.getSteps("Cream Cheese Chimkin")
                },
                18 => new Meal
                {
                    Title = "Smokey Chimkin with Green Goddess Sauce",
                    Ingredients = Utilities.getIngredients("Smokey Chimkin with Green Goddess Sauce"),
                    Steps = Utilities.getSteps("Smokey Chimkin with Green Goddess Sauce")
                },
                19 => new Meal
                {
                    Title = "Beefy Brothy Bowl",
                    Ingredients = Utilities.getIngredients("Beefy Brothy Bowl"),
                    Steps = Utilities.getSteps("Beefy Brothy Bowl")
                },
                20 => new Meal
                {
                    Title = "Diabetic Friendly CBR Bake",
                    Ingredients = Utilities.getIngredients("Diabetic Friendly CBR Bake"),
                    Steps = Utilities.getSteps("Diabetic Friendly CBR Bake")
                },
                21 => new Meal
                {
                    Title = "Peruvian Chimkin with Green Sauce",
                    Ingredients = Utilities.getIngredients("Peruvian Chimkin with Green Sauce"),
                    Steps = Utilities.getSteps("Peruvian Chimkin with Green Sauce")
                },
                22 => new Meal
                {
                    Title = "Southwest Chimkin Bowl",
                    Ingredients = Utilities.getIngredients("Southwest Chimkin Bowl"),
                    Steps = Utilities.getSteps("Southwest Chimkin Bowl")
                },
                23 => new Meal
                {
                    Title = "High Protein Grilled Chimkin Alfredo",
                    Ingredients = Utilities.getIngredients("High Protein Grilled Chimkin Alfredo"),
                    Steps = Utilities.getSteps("High Protein Grilled Chimkin Alfredo")
                },
                _ => new Meal
                {
                    Title = "Meal Name goes here",
                    Ingredients = Utilities.getIngredients(""),
                    Steps = Utilities.getSteps("")
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
