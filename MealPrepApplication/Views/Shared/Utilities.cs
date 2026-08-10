using Microsoft.AspNetCore.SignalR;
using MealPrepApplication.Meals;
using System.Runtime.InteropServices;

namespace MealPrepApplication.Views.Shared
{
    public class Utilities
    {
        public static List<Items> getIngredients(string mealname)
        {
            List<Items> list = new List<Items>();

            switch (mealname)
            {
                case "Marry Me Chicken Meatballs":
                    list = get_Marry_Me_Chicken_Meatballs_list();
                    break;
                default:
                    break;
            }
            return list;
        }

        public static List<Items> get_Marry_Me_Chicken_Meatballs_list()
        {
            List<Items> itemList = new List<Items> {Marry_Me_Chicken_Meatballs.ground_chicken,
                                                                Marry_Me_Chicken_Meatballs.parmesan,
                                                                Marry_Me_Chicken_Meatballs.breadcrumbs,
                                                                Marry_Me_Chicken_Meatballs.onion,
                                                                Marry_Me_Chicken_Meatballs.garlic,
                                                                Marry_Me_Chicken_Meatballs.egg,
                                                                Marry_Me_Chicken_Meatballs.italian_seasoning,
                                                                Marry_Me_Chicken_Meatballs.salt,
                                                                Marry_Me_Chicken_Meatballs.pepper,
                                                                new Items(0000000, "For the", "Sauce"),
                                                                Marry_Me_Chicken_Meatballs.sauce_onion,
                                                                Marry_Me_Chicken_Meatballs.sauce_garlic,
                                                                Marry_Me_Chicken_Meatballs.sauce_broth,
                                                                Marry_Me_Chicken_Meatballs.heavy_cream,
                                                                Marry_Me_Chicken_Meatballs.tomato_paste,
                                                                Marry_Me_Chicken_Meatballs.sauce_parmesan,
                                                                Marry_Me_Chicken_Meatballs.sauce_sundried_tomatoes,
                                                                Marry_Me_Chicken_Meatballs.sauce_pepper_flakes,
                                                                Marry_Me_Chicken_Meatballs.sauce_italian_seasoning};
            return itemList;
        }
    }
}
