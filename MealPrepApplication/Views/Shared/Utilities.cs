using Microsoft.AspNetCore.SignalR;
using MealPrepApplication.Meals;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace MealPrepApplication.Views.Shared
{
    public class Utilities
    {
        public static List<Items> getIngredients(string mealname)
        {
            List<Items> list = new List<Items>();

            switch (mealname)
            {
                case "Chimkin Carnitas Tacos w/ Avocado Sauce":
                    list = get_Chicken_Carnitas_Tacos_with_Avocado_Sauce();
                    break;
                case "Cilantro Orange Chimkin Bites":
                    list = get_Cilantro_Orange_Chimkin_Bites();
                    break;
                case "Grilled Balsamic Chicken with Burrata and Peaches":
                    list = get_Balsamic_Chicken_with_Peaches_Burrata();
                    break;
                case "Marry Me Chicken Meatballs":
                    list = get_Marry_Me_Chicken_Meatballs_list();
                    break;
                case "Hot Honey Chimken w/ Peach Salsa":
                    list = get_Hot_Honey_Chimken_with_Peach_Salsa();
                    break;
                case "Chimkin Enchilada Boats":
                    list = get_Chimkin_Enchilada_Boats();
                    break;
                case "Spicy Mediterranean chimkin w/ Cucumber Salad":
                    list = get_Spicy_Mediterranean_Chimkin_with_Cucumber_Salad();
                    break;
                case "(Sheet pan) Mediterranean chimkin w/ Yogurt sauce":
                    list = get_Mediterranean_Chimkin_with_Yogurt_Sauce();
                    break;
                case "Balsamic Chimkin":
                    list = get_Balsamic_Chimkin();
                    break;
                case "Cheesy Asparagus Stuffed Chimkin":
                    list = get_Cheesy_Asparagus_Stuffed_Chimkin();
                    break;
                case "Chimkin w/ Mediterranean Salsa":
                    list = get_Chimkin_with_Mediterranean_Salsa();
                    break;
                case "Pork/Potato Taco Bowl":
                    list = get_Pork_Potato_Taco_Bowl();
                    break;
                case "Potato Thing":
                    list = get_Potato_Thing();
                    break;
                case "Meal Prep":
                    list = get_Meal_Prep();
                    break;
                case "Teriyaki Pineapple Chicken Meatballs":
                    list = get_Teriyaki_Pineapple_Chicken_Meatballs();
                    break;
                default:
                    break;
            }
            return list;
        }

        public static string getSteps(string mealname)
        {
            string str = "";

            switch (mealname)
            {
                case "Chimkin Carnitas Tacos w/ Avocado Sauce":
                    str = getSteps_Chicken_Carnitas_Tacos_with_Avocado_Sauce();
                    break;
                case "Cilantro Orange Chimkin Bites":
                    str = getSteps_Cilantro_Orange_Chimkin_Bites();
                    break;
                case "Grilled Balsamic Chicken with Burrata and Peaches":
                    str = getSteps_Balsamic_Chicken_with_Peaches_Burrata();
                    break;
                case "Marry Me Chicken Meatballs":
                    str = getSteps_Marry_Me_Chicken_Meatballs_list();
                    break;
                case "Hot Honey Chimken w/ Peach Salsa":
                    str = getSteps_Hot_Honey_Chimken_with_Peach_Salsa();
                    break;
                case "Chimkin Enchilada Boats":
                    str = getSteps_Chimkin_Enchilada_Boats();
                    break;
                case "Spicy Mediterranean chimkin w/ Cucumber Salad":
                    str = getSteps_Spicy_Mediterranean_Chimkin_with_Cucumber_Salad();
                    break;
                case "(Sheet pan) Mediterranean chimkin w/ Yogurt sauce":
                    str = getSteps_Mediterranean_Chimkin_with_Yogurt_Sauce();
                    break;
                case "Balsamic Chimkin":
                    str = getSteps_Balsamic_Chimkin();
                    break;
                case "Cheesy Asparagus Stuffed Chimkin":
                    str = getSteps_Cheesy_Asparagus_Stuffed_Chimkin();
                    break;
                case "Chimkin w/ Mediterranean Salsa":
                    str = getSteps_Chimkin_with_Mediterranean_Salsa();
                    break;
                case "Pork/Potato Taco Bowl":
                    str = getSteps_Pork_Potato_Taco_Bowl();
                    break;
                case "Potato Thing":
                    str = getSteps_Potato_Thing();
                    break;
                case "Meal Prep":
                    str = getSteps_Meal_Prep();
                    break;
                case "Teriyaki Pineapple Chicken Meatballs":
                    str = getSteps_Teriyaki_Pineapple_Chicken_Meatballs();
                    break;
                default:
                    break;
            }
            return str;
        }

        #region Ingredients
        public static List<Items> get_Meal_Prep()
        {
            List<Items> list = new List<Items>
            {
                Meal_Prep.pasta,
                Meal_Prep.beef,
                Meal_Prep.tomato,
                Meal_Prep.garlic,
                Meal_Prep.bells,
                Meal_Prep.cheese,
                Meal_Prep.salt,
                Meal_Prep.pepper,
                Meal_Prep.italian,
                Meal_Prep.paprika,
                Meal_Prep.garlic_powder,
                Meal_Prep.onion_powder
            };
            return list;
        }

        public static List<Items> get_Potato_Thing()
        {
            List<Items> ingredients = Potato_Thing.ingredients;
            List<Items> potatoes = Potato_Thing.potatoes;
            List<Items> itemList = ingredients.Concat(potatoes).ToList();
            return itemList;
        }

        public static List<Items> get_Pork_Potato_Taco_Bowl()
        {
            List<Items> ingredients = Pork_Potato_Taco_Bowl.ingredients;
            List<Items> potato = Pork_Potato_Taco_Bowl.potatoes;
            List<Items> pico = Pork_Potato_Taco_Bowl.pico;
            List<Items> sauce = Pork_Potato_Taco_Bowl.sauce;
            List<Items> savory = ingredients.Concat(potato).ToList();
            List<Items> sauces = pico.Concat(sauce).ToList();
            List<Items> itemList = savory.Concat(sauces).ToList();
            return itemList;
        }

        public static List<Items> get_Chimkin_with_Mediterranean_Salsa()
        {
            List<Items> ingredients = Chimkin_with_Mediterranean_Salsa.ingredients;
            List<Items> salsa = Chimkin_with_Mediterranean_Salsa.salsa;
            List<Items> itemList = ingredients.Concat(salsa).ToList();
            return itemList;
        }

        public static List<Items> get_Cheesy_Asparagus_Stuffed_Chimkin()
        {
            List<Items> ingredients = Cheesy_Asparagus_Stuffed_Chimkin.ingredients;
            List<Items> sauce = Cheesy_Asparagus_Stuffed_Chimkin.sauce;
            List<Items> itemList = ingredients.Concat(sauce).ToList();
            return itemList;
        }

        public static List<Items> get_Balsamic_Chimkin()
        {
            List<Items> ingredients = Baked_Balsamic_Chimkin.ingredients;
            List<Items> salsa = Baked_Balsamic_Chimkin.salsa;
            List<Items> itemList = ingredients.Concat(salsa).ToList();
            return itemList;
        }

        public static List<Items> get_Mediterranean_Chimkin_with_Yogurt_Sauce()
        {
            List<Items> ingredients = Mediterranean_Chimkin_with_Yogurt_Sauce.ingredients;
            List<Items> veggies = Mediterranean_Chimkin_with_Yogurt_Sauce.veggies;
            List<Items> sauce = Mediterranean_Chimkin_with_Yogurt_Sauce.sauce;
            List<Items> veggie_sauce = veggies.Concat(sauce).ToList();
            List<Items> itemList = ingredients.Concat(veggie_sauce).ToList();
            return itemList;
        }

        public static List<Items> get_Spicy_Mediterranean_Chimkin_with_Cucumber_Salad()
        {
            List<Items> ingredients = Spicy_Mediterranean_Chimkim_with_Cucumber_Salad.ingredients;
            List<Items> salad = Spicy_Mediterranean_Chimkim_with_Cucumber_Salad.salad;
            List<Items> itemList = ingredients.Concat(salad).ToList();
            return itemList;
        }

        public static List<Items> get_Chimkin_Enchilada_Boats()
        {
            List<Items> itemList = Chimkin_Enchilada_Boats.ingredients;
            return itemList;
        }

        public static List<Items> get_Hot_Honey_Chimken_with_Peach_Salsa()
        {
            List<Items> ingredients = Hot_Honey_Chimken_with_Peach_Salse.ingredients;
            List<Items> honey = Hot_Honey_Chimken_with_Peach_Salse.honey;
            List<Items> salsa = Hot_Honey_Chimken_with_Peach_Salse.salsa;
            List<Items> hot_salsa = honey.Concat(salsa).ToList();
            List<Items> itemList = ingredients.Concat(hot_salsa).ToList();
            return itemList;
        }

        public static List<Items> get_Cilantro_Orange_Chimkin_Bites()
        {
            List<Items> ingredients = Cilantro_Orange_Chicken_Bites.ingredients;
            List<Items> sauce = Cilantro_Orange_Chicken_Bites.sauce;
            List<Items> itemList = ingredients.Concat(sauce).ToList();
            return itemList;
        }

        public static List<Items> get_Marry_Me_Chicken_Meatballs_list()
        {
            List<Items> ingredients = Marry_Me_Chicken_Meatballs.ingredients;
            List<Items> sauce = Marry_Me_Chicken_Meatballs.sauce;
            List<Items> itemList = ingredients.Concat(sauce).ToList();
            return itemList;
        }

        public static List<Items> get_Balsamic_Chicken_with_Peaches_Burrata()
        {
            List<Items> ingredients = Balsamic_Chicken_with_Peaches_Burrata.ingredients;
            List<Items> salsa = Balsamic_Chicken_with_Peaches_Burrata.salsa;
            List<Items> itemList = ingredients.Concat(salsa).ToList();
            return itemList;
        }

        public static List<Items> get_Teriyaki_Pineapple_Chicken_Meatballs()
        {
            List<Items> ingredients = Teriyaki_Pineapple_Chicken_Meatballs.ingredients;
            List<Items> sauce = Teriyaki_Pineapple_Chicken_Meatballs.sauce;
            List<Items> itemList = ingredients.Concat(sauce).ToList();
            return itemList;
        }

        public static List<Items> get_Chicken_Carnitas_Tacos_with_Avocado_Sauce()
        {
            List<Items> ingredients = Chicken_Carnitas_Tacos_with_Avocado_Sauce.ingredients;
            List<Items> sauce = Chicken_Carnitas_Tacos_with_Avocado_Sauce.sauce;
            List<Items> itemlist = ingredients.Concat(sauce).ToList();
            return itemlist;
        }

        #endregion

        #region Steps

        public static string getSteps_Chicken_Carnitas_Tacos_with_Avocado_Sauce()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Steps", "Chimkin_carnitas_tacos_with_avocado_sauce.txt");
            string fileContent = "";

            try
            {
                if (System.IO.File.Exists(filePath))
                {
                    fileContent = System.IO.File.ReadAllText(filePath);
                }
                else
                {
                    fileContent = "File not found.";
                }
            }
            catch (IOException ex)
            {
                fileContent = $"Error reading file: {ex.Message}";
            }

            return fileContent;
        }

        public static string getSteps_Cilantro_Orange_Chimkin_Bites()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Steps", "Cilantro_Orange_Chimkin_Bites.txt");
            string fileContent = "";

            try
            {
                if (System.IO.File.Exists(filePath))
                {
                    fileContent = System.IO.File.ReadAllText(filePath);
                }
                else
                {
                    fileContent = "File not found.";
                }
            }
            catch (IOException ex)
            {
                fileContent = $"Error reading file: {ex.Message}";
            }

            return fileContent;
        }

        public static string getSteps_Balsamic_Chicken_with_Peaches_Burrata()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Steps", "Balsamic_chimkin_with_peaches_burrata.txt");
            string fileContent = "";

            try
            {
                if (System.IO.File.Exists(filePath))
                {
                    fileContent = System.IO.File.ReadAllText(filePath);
                }
                else
                {
                    fileContent = "File not found.";
                }
            }
            catch (IOException ex)
            {
                fileContent = $"Error reading file: {ex.Message}";
            }

            return fileContent;
        }

        public static string getSteps_Marry_Me_Chicken_Meatballs_list()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Steps", "Marry_me_chimkin_meatballs.txt");
            string fileContent = "";

            try
            {
                if (System.IO.File.Exists(filePath))
                {
                    fileContent = System.IO.File.ReadAllText(filePath);
                }
                else
                {
                    fileContent = "File not found.";
                }
            }
            catch (IOException ex)
            {
                fileContent = $"Error reading file: {ex.Message}";
            }

            return fileContent;
        }

        public static string getSteps_Hot_Honey_Chimken_with_Peach_Salsa()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Steps", "Hot_honey_chimkin_with_peach_salsa.txt");
            string fileContent = "";

            try
            {
                if (System.IO.File.Exists(filePath))
                {
                    fileContent = System.IO.File.ReadAllText(filePath);
                }
                else
                {
                    fileContent = "File not found.";
                }
            }
            catch (IOException ex)
            {
                fileContent = $"Error reading file: {ex.Message}";
            }

            return fileContent;
        }

        public static string getSteps_Chimkin_Enchilada_Boats()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Steps", "Chimkin_enchilada_boats.txt");
            string fileContent = "";

            try
            {
                if (System.IO.File.Exists(filePath))
                {
                    fileContent = System.IO.File.ReadAllText(filePath);
                }
                else
                {
                    fileContent = "File not found.";
                }
            }
            catch (IOException ex)
            {
                fileContent = $"Error reading file: {ex.Message}";
            }

            return fileContent;
        }

        public static string getSteps_Spicy_Mediterranean_Chimkin_with_Cucumber_Salad()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Steps", "Spicy_med_chimkin_cucumber_salad.txt");
            string fileContent = "";

            try
            {
                if (System.IO.File.Exists(filePath))
                {
                    fileContent = System.IO.File.ReadAllText(filePath);
                }
                else
                {
                    fileContent = "File not found.";
                }
            }
            catch (IOException ex)
            {
                fileContent = $"Error reading file: {ex.Message}";
            }

            return fileContent;
        }

        public static string getSteps_Mediterranean_Chimkin_with_Yogurt_Sauce()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Steps", "Mediterranean_Chimken_with_yogurt_sauce.txt");
            string fileContent = "";

            try
            {
                if (System.IO.File.Exists(filePath))
                {
                    fileContent = System.IO.File.ReadAllText(filePath);
                }
                else
                {
                    fileContent = "File not found.";
                }
            }
            catch (IOException ex)
            {
                fileContent = $"Error reading file: {ex.Message}";
            }

            return fileContent;
        }

        public static string getSteps_Balsamic_Chimkin()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Steps", "Baked_balsamic_chimkin.txt");
            string fileContent = "";

            try
            {
                if (System.IO.File.Exists(filePath))
                {
                    fileContent = System.IO.File.ReadAllText(filePath);
                }
                else
                {
                    fileContent = "File not found.";
                }
            }
            catch (IOException ex)
            {
                fileContent = $"Error reading file: {ex.Message}";
            }

            return fileContent;
        }

        public static string getSteps_Cheesy_Asparagus_Stuffed_Chimkin()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Steps", "Cheesy_asparagus_stuffed_chimkin.txt");
            string fileContent = "";

            try
            {
                if (System.IO.File.Exists(filePath))
                {
                    fileContent = System.IO.File.ReadAllText(filePath);
                }
                else
                {
                    fileContent = "File not found.";
                }
            }
            catch (IOException ex)
            {
                fileContent = $"Error reading file: {ex.Message}";
            }

            return fileContent;
        }

        public static string getSteps_Chimkin_with_Mediterranean_Salsa()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Steps", "Chimkin_with_mediterranean_salsa.txt");
            string fileContent = "";

            try
            {
                if (System.IO.File.Exists(filePath))
                {
                    fileContent = System.IO.File.ReadAllText(filePath);
                }
                else
                {
                    fileContent = "File not found.";
                }
            }
            catch (IOException ex)
            {
                fileContent = $"Error reading file: {ex.Message}";
            }

            return fileContent;
        }

        public static string getSteps_Pork_Potato_Taco_Bowl()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Steps", "Pork_Potato_Taco_Bowl.txt");
            string fileContent = "";

            try
            {
                if (System.IO.File.Exists(filePath))
                {
                    fileContent = System.IO.File.ReadAllText(filePath);
                }
                else
                {
                    fileContent = "File not found.";
                }
            }
            catch (IOException ex)
            {
                fileContent = $"Error reading file: {ex.Message}";
            }

            return fileContent;
        }

        public static string getSteps_Potato_Thing()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Steps", "Potato_Thing.txt");
            string fileContent = "";

            try
            {
                if (System.IO.File.Exists(filePath))
                {
                    fileContent = System.IO.File.ReadAllText(filePath);
                }
                else
                {
                    fileContent = "File not found.";
                }
            }
            catch (IOException ex)
            {
                fileContent = $"Error reading file: {ex.Message}";
            }

            return fileContent;
        }

        public static string getSteps_Meal_Prep()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Steps", "Test.txt");
            string fileContent = "";

            try
            {
                if (System.IO.File.Exists(filePath))
                {
                    fileContent = System.IO.File.ReadAllText(filePath);
                }
                else
                {
                    fileContent = "File not found.";
                }
            }
            catch (IOException ex)
            {
                fileContent = $"Error reading file: {ex.Message}";
            }

            return fileContent;
        }

        public static string getSteps_Teriyaki_Pineapple_Chicken_Meatballs()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Steps", "Teriyaki_pineapple_chimkin_meatballs.txt");
            string fileContent = "";

            try
            {
                if (System.IO.File.Exists(filePath))
                {
                    fileContent = System.IO.File.ReadAllText(filePath);
                }
                else
                {
                    fileContent = "File not found.";
                }
            }
            catch (IOException ex)
            {
                fileContent = $"Error reading file: {ex.Message}";
            }

            return fileContent;
        }

        #endregion
    }
}
