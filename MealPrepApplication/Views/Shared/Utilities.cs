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
                case "Grilled Balsamic Chicken with Burrata and Peaches":
                    list = get_Balsamic_Chicken_with_Peaches_Burrata();
                    break;
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
                                                                new Items(),
                                                                new Items(0, "For the", "Sauce"),
                                                                new Items(),
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

        public static List<Items> get_Balsamic_Chicken_with_Peaches_Burrata()
        {
            List<Items> itemList = new List<Items> {Balsamic_Chicken_with_Peaches_Burrata.chicken,
                                                        Balsamic_Chicken_with_Peaches_Burrata.balsamic_vinegar,
                                                        Balsamic_Chicken_with_Peaches_Burrata.olive_oil,
                                                        Balsamic_Chicken_with_Peaches_Burrata.dijon_mustard,
                                                        Balsamic_Chicken_with_Peaches_Burrata.garlic_cloves,
                                                        Balsamic_Chicken_with_Peaches_Burrata.salt,
                                                        Balsamic_Chicken_with_Peaches_Burrata.pepper,
                                                        Balsamic_Chicken_with_Peaches_Burrata.oregano,
                                                        Balsamic_Chicken_with_Peaches_Burrata.burrata,
                                                        Balsamic_Chicken_with_Peaches_Burrata.peaches,
                                                        Balsamic_Chicken_with_Peaches_Burrata.basil};
            return itemList;
        }
    }
}
