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
                case "Chimkin Carnitas Tacos w/ Avocado Sauce":
                    list = get_Chicken_Carnitas_Tacos_with_Avocado_Sauce();
                    break;
                case "Grilled Balsamic Chicken with Burrata and Peaches":
                    list = get_Balsamic_Chicken_with_Peaches_Burrata();
                    break;
                case "Marry Me Chicken Meatballs":
                    list = get_Marry_Me_Chicken_Meatballs_list();
                    break;
                case "Teriyaki Pineapple Chicken Meatballs":
                    list = get_Teriyaki_Pineapple_Chicken_Meatballs();
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
                                                                new Items(),
                                                                new Items(0, "For the", "Sauce:"),
                                                                new Items(),
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

        public static List<Items> get_Teriyaki_Pineapple_Chicken_Meatballs()
        {
            List<Items> itemList = new List<Items>
            {
                Teriyaki_Pineapple_Chicken_Meatballs.chimkin,
                Teriyaki_Pineapple_Chicken_Meatballs.egg,
                Teriyaki_Pineapple_Chicken_Meatballs.breadcrumbs,
                Teriyaki_Pineapple_Chicken_Meatballs.pineapple_juice,
                Teriyaki_Pineapple_Chicken_Meatballs.soy_sauce,
                Teriyaki_Pineapple_Chicken_Meatballs.garlic,
                Teriyaki_Pineapple_Chicken_Meatballs.onion,
                Teriyaki_Pineapple_Chicken_Meatballs.pepper,
                Teriyaki_Pineapple_Chicken_Meatballs.pineapple,
                Teriyaki_Pineapple_Chicken_Meatballs.red_bell,
                Teriyaki_Pineapple_Chicken_Meatballs.green_bell,
                new Items(),
                new Items(),
                new Items(0, "For the", "Sauce:"),
                new Items(),
                new Items(),
                Teriyaki_Pineapple_Chicken_Meatballs.sauce_soy_sauce,
                Teriyaki_Pineapple_Chicken_Meatballs.water,
                Teriyaki_Pineapple_Chicken_Meatballs.sauce_garlic,
                Teriyaki_Pineapple_Chicken_Meatballs.honey,
                Teriyaki_Pineapple_Chicken_Meatballs.rice_vinegar,
                Teriyaki_Pineapple_Chicken_Meatballs.cornstarch,
                Teriyaki_Pineapple_Chicken_Meatballs.water_cornstarch
            };
            return itemList;
        }

        public static List<Items> get_Chicken_Carnitas_Tacos_with_Avocado_Sauce()
        {
            List<Items> itemlist = new List<Items>
            {
                Chicken_Carnitas_Tacos_with_Avocado_Sauce.chimkin,
                Chicken_Carnitas_Tacos_with_Avocado_Sauce.oranges,
                Chicken_Carnitas_Tacos_with_Avocado_Sauce.limes,
                Chicken_Carnitas_Tacos_with_Avocado_Sauce.garlic,
                Chicken_Carnitas_Tacos_with_Avocado_Sauce.jollies,
                Chicken_Carnitas_Tacos_with_Avocado_Sauce.cilantro,
                Chicken_Carnitas_Tacos_with_Avocado_Sauce.olive_oil,
                Chicken_Carnitas_Tacos_with_Avocado_Sauce.chili_powder,
                Chicken_Carnitas_Tacos_with_Avocado_Sauce.oregano,
                Chicken_Carnitas_Tacos_with_Avocado_Sauce.cumin,
                Chicken_Carnitas_Tacos_with_Avocado_Sauce.salt,
                Chicken_Carnitas_Tacos_with_Avocado_Sauce.pepper,
                Chicken_Carnitas_Tacos_with_Avocado_Sauce.tortillas,
                Chicken_Carnitas_Tacos_with_Avocado_Sauce.onion,
                Chicken_Carnitas_Tacos_with_Avocado_Sauce.cheese,
                new Items(), new Items(),
                new Items(0, "For the", "Sauce:"),
                new Items(), new Items(),
                Chicken_Carnitas_Tacos_with_Avocado_Sauce.avocados,
                Chicken_Carnitas_Tacos_with_Avocado_Sauce.sauce_garlic,
                Chicken_Carnitas_Tacos_with_Avocado_Sauce.sauce_cilantro,
                Chicken_Carnitas_Tacos_with_Avocado_Sauce.garlic_salt
            };
            return itemlist;
        }
    }
}
