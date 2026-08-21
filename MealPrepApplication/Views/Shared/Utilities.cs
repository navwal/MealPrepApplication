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
            List<Items> list = new List<Items>
            {
                Potato_Thing.chimkin,
                Potato_Thing.garlic_powder,
                Potato_Thing.thyme,
                Potato_Thing.oregano,
                Potato_Thing.oil,
                Potato_Thing.season,
                new Items(0, "FOR POTATOES", ""),
                Potato_Thing.potato,
                Potato_Thing.lemon,
                Potato_Thing.juice,
                Potato_Thing.p_oil,
                Potato_Thing.p_oregano,
                Potato_Thing.flakes,
                Potato_Thing.salt,
                Potato_Thing.honey,
                Potato_Thing.chees
            };
            return list;
        }

        public static List<Items> get_Pork_Potato_Taco_Bowl()
        {
            List<Items> list = new List<Items>
            {
                Pork_Potato_Taco_Bowl.pork,
                Pork_Potato_Taco_Bowl.taco_season,
                new Items(0, "FOR POTATOES", ""),
                Pork_Potato_Taco_Bowl.potatoes,
                Pork_Potato_Taco_Bowl.paprika,
                Pork_Potato_Taco_Bowl.garlic_powder,
                Pork_Potato_Taco_Bowl.onion_powder,
                Pork_Potato_Taco_Bowl.salt,
                Pork_Potato_Taco_Bowl.pepper,
                new Items(0, "FOR SAUCE:", ""),
                Pork_Potato_Taco_Bowl.tomatoes,
                Pork_Potato_Taco_Bowl.onion,
                Pork_Potato_Taco_Bowl.cilantro,
                Pork_Potato_Taco_Bowl.lime,
                Pork_Potato_Taco_Bowl.yogurt,
                Pork_Potato_Taco_Bowl.adobo,
                Pork_Potato_Taco_Bowl.sauce_salt,
                Pork_Potato_Taco_Bowl.sauce_garlic_powder
            };
            return list;
        }

        public static List<Items> get_Chimkin_with_Mediterranean_Salsa()
        {
            List<Items> list = new List<Items>
            {
                Chimkin_with_Mediterranean_Salsa.chimkin,
                Chimkin_with_Mediterranean_Salsa.yogurt,
                Chimkin_with_Mediterranean_Salsa.garlic,
                Chimkin_with_Mediterranean_Salsa.lemons,
                Chimkin_with_Mediterranean_Salsa.oil,
                Chimkin_with_Mediterranean_Salsa.oregano,
                Chimkin_with_Mediterranean_Salsa.salt,
                Chimkin_with_Mediterranean_Salsa.pepper,
                new Items(0, "FOR SALSA:", ""),
                Chimkin_with_Mediterranean_Salsa.cucumber,
                Chimkin_with_Mediterranean_Salsa.tomato,
                Chimkin_with_Mediterranean_Salsa.olives,
                Chimkin_with_Mediterranean_Salsa.onion,
                Chimkin_with_Mediterranean_Salsa.avocado,
                Chimkin_with_Mediterranean_Salsa.feta,
                Chimkin_with_Mediterranean_Salsa.dill,
                Chimkin_with_Mediterranean_Salsa.salsa_lemons,
                Chimkin_with_Mediterranean_Salsa.vinegar,
                Chimkin_with_Mediterranean_Salsa.salsa_salt,
                Chimkin_with_Mediterranean_Salsa.salsa_pepper
            };
            return list;
        }

        public static List<Items> get_Cheesy_Asparagus_Stuffed_Chimkin()
        {
            List<Items> list = new List<Items>
            {
                Cheesy_Asparagus_Stuffed_Chimkin.chimkin,
                Cheesy_Asparagus_Stuffed_Chimkin.asparagus,
                Cheesy_Asparagus_Stuffed_Chimkin.mozzarella,
                Cheesy_Asparagus_Stuffed_Chimkin.sun_dried_tomato,
                Cheesy_Asparagus_Stuffed_Chimkin.paprika,
                Cheesy_Asparagus_Stuffed_Chimkin.salt,
                new Items(0, "", ""),
                Cheesy_Asparagus_Stuffed_Chimkin.basil,
                Cheesy_Asparagus_Stuffed_Chimkin.spinach,
                Cheesy_Asparagus_Stuffed_Chimkin.oil,
                Cheesy_Asparagus_Stuffed_Chimkin.parmesan,
                Cheesy_Asparagus_Stuffed_Chimkin.pinenuts,
                Cheesy_Asparagus_Stuffed_Chimkin.garlic,
                Cheesy_Asparagus_Stuffed_Chimkin.lemon,
                Cheesy_Asparagus_Stuffed_Chimkin.pesto_salt,
                Cheesy_Asparagus_Stuffed_Chimkin.pepper
            };
            return list;
        }

        public static List<Items> get_Balsamic_Chimkin()
        {
            List<Items> list = new List<Items>
            {
                Baked_Balsamic_Chimkin.chimkin,
                Baked_Balsamic_Chimkin.vinegar,
                Baked_Balsamic_Chimkin.mustard,
                Baked_Balsamic_Chimkin.thyme,
                Baked_Balsamic_Chimkin.garlic_salt,
                Baked_Balsamic_Chimkin.pepper,
                new Items(0, "FOR SAUCE", ""),
                Baked_Balsamic_Chimkin.cherry_tomato,
                Baked_Balsamic_Chimkin.mozzarella,
                Baked_Balsamic_Chimkin.basil,
                Baked_Balsamic_Chimkin.onion,
                Baked_Balsamic_Chimkin.sauce_vinegar,
                Baked_Balsamic_Chimkin.salt
            };
            return list;
        }

        public static List<Items> get_Mediterranean_Chimkin_with_Yogurt_Sauce()
        {
            List<Items> list = new List<Items>
            {
                Mediterranean_Chimkin_with_Yogurt_Sauce.chimkin,
                Mediterranean_Chimkin_with_Yogurt_Sauce.garlic,
                Mediterranean_Chimkin_with_Yogurt_Sauce.yogurt,
                Mediterranean_Chimkin_with_Yogurt_Sauce.lemon,
                Mediterranean_Chimkin_with_Yogurt_Sauce.tomato_paste,
                Mediterranean_Chimkin_with_Yogurt_Sauce.paprika,
                Mediterranean_Chimkin_with_Yogurt_Sauce.oil,
                Mediterranean_Chimkin_with_Yogurt_Sauce.cumin,
                Mediterranean_Chimkin_with_Yogurt_Sauce.oregano,
                Mediterranean_Chimkin_with_Yogurt_Sauce.salt,
                Mediterranean_Chimkin_with_Yogurt_Sauce.pepper,
                Mediterranean_Chimkin_with_Yogurt_Sauce.bell_pepper,
                Mediterranean_Chimkin_with_Yogurt_Sauce.onion,
                new Items(0 ,"FOR VEGGIES:", ""),
                Mediterranean_Chimkin_with_Yogurt_Sauce.veggie_oil,
                Mediterranean_Chimkin_with_Yogurt_Sauce.veggie_salt,
                Mediterranean_Chimkin_with_Yogurt_Sauce.veggie_lemon,
                Mediterranean_Chimkin_with_Yogurt_Sauce.rice,
                new Items(0,"FOR SAUCE:", ""),
                Mediterranean_Chimkin_with_Yogurt_Sauce.sauce_yogurt,
                Mediterranean_Chimkin_with_Yogurt_Sauce.sauce_lemon,
                Mediterranean_Chimkin_with_Yogurt_Sauce.sauce_garlic,
                Mediterranean_Chimkin_with_Yogurt_Sauce.dill,
                Mediterranean_Chimkin_with_Yogurt_Sauce.sauce_salt
            };
            return list;
        }

        public static List<Items> get_Spicy_Mediterranean_Chimkin_with_Cucumber_Salad()
        {
            List<Items> list = new List<Items>
            {
                Spicy_Mediterranean_Chimkim_with_Cucumber_Salad.chimkin,
                Spicy_Mediterranean_Chimkim_with_Cucumber_Salad.garlic,
                Spicy_Mediterranean_Chimkim_with_Cucumber_Salad.oil,
                Spicy_Mediterranean_Chimkim_with_Cucumber_Salad.lemon,
                Spicy_Mediterranean_Chimkim_with_Cucumber_Salad.paprika,
                Spicy_Mediterranean_Chimkim_with_Cucumber_Salad.oregano,
                Spicy_Mediterranean_Chimkim_with_Cucumber_Salad.cumin,
                Spicy_Mediterranean_Chimkim_with_Cucumber_Salad.salt,
                Spicy_Mediterranean_Chimkim_with_Cucumber_Salad.cayenne,
                Spicy_Mediterranean_Chimkim_with_Cucumber_Salad.pepper,
                new Items(0, "SALAD:", ""),
                Spicy_Mediterranean_Chimkim_with_Cucumber_Salad.cucumbers,
                Spicy_Mediterranean_Chimkim_with_Cucumber_Salad.onion,
                Spicy_Mediterranean_Chimkim_with_Cucumber_Salad.yogurt,
                Spicy_Mediterranean_Chimkim_with_Cucumber_Salad.salad_lemon,
                Spicy_Mediterranean_Chimkim_with_Cucumber_Salad.salad_garlic,
                Spicy_Mediterranean_Chimkim_with_Cucumber_Salad.dill,
                Spicy_Mediterranean_Chimkim_with_Cucumber_Salad.salad_salt,
                Spicy_Mediterranean_Chimkim_with_Cucumber_Salad.salad_pepper
            };
            return list;
        }

        public static List<Items> get_Chimkin_Enchilada_Boats()
        {
            List<Items> list = new List<Items>
            {
                Chimkin_Enchilada_Boats.zucchini,
                Chimkin_Enchilada_Boats.chimkin,
                Chimkin_Enchilada_Boats.beans,
                Chimkin_Enchilada_Boats.onion,
                Chimkin_Enchilada_Boats.garlic,
                Chimkin_Enchilada_Boats.cilantro,
                Chimkin_Enchilada_Boats.enchilada_sauce,
                Chimkin_Enchilada_Boats.chili_powder,
                Chimkin_Enchilada_Boats.cumin,
                Chimkin_Enchilada_Boats.oregano,
                Chimkin_Enchilada_Boats.salt,
                Chimkin_Enchilada_Boats.pepper,
                Chimkin_Enchilada_Boats.cheese,
                Chimkin_Enchilada_Boats.guac,
                Chimkin_Enchilada_Boats.sourcream,
                Chimkin_Enchilada_Boats.salsa
            };
            return list;
        }

        public static List<Items> get_Hot_Honey_Chimken_with_Peach_Salsa()
        {
            List<Items> itemList = new List<Items>
            {
                Hot_Honey_Chimken_with_Peach_Salse.chimkin,
                Hot_Honey_Chimken_with_Peach_Salse.oil,
                Hot_Honey_Chimken_with_Peach_Salse.paprika,
                Hot_Honey_Chimken_with_Peach_Salse.cumin,
                Hot_Honey_Chimken_with_Peach_Salse.salt,
                Hot_Honey_Chimken_with_Peach_Salse.pepper,
                new Items(0, "HOT HONEY SAUCE:", ""),
                Hot_Honey_Chimken_with_Peach_Salse.honey,
                Hot_Honey_Chimken_with_Peach_Salse.garlic,
                Hot_Honey_Chimken_with_Peach_Salse.pepper_flakes,
                Hot_Honey_Chimken_with_Peach_Salse.sauce_paprika,
                Hot_Honey_Chimken_with_Peach_Salse.sauce_salt,
                new Items(0, "SALSA:", ""),
                Hot_Honey_Chimken_with_Peach_Salse.peaches,
                Hot_Honey_Chimken_with_Peach_Salse.jollies,
                Hot_Honey_Chimken_with_Peach_Salse.onion,
                Hot_Honey_Chimken_with_Peach_Salse.cilantro,
                Hot_Honey_Chimken_with_Peach_Salse.lime
            };
            return itemList;
        }

        public static List<Items> get_Cilantro_Orange_Chimkin_Bites()
        {
            List<Items> itemList = new List<Items> { Cilantro_Orange_Chicken_Bites.chimkin,
                                                        Cilantro_Orange_Chicken_Bites.cumin,
                                                        Cilantro_Orange_Chicken_Bites.paprika,
                                                        Cilantro_Orange_Chicken_Bites.salt,
                                                        Cilantro_Orange_Chicken_Bites.cilantro,
                                                        Cilantro_Orange_Chicken_Bites.oranges,
                                                        Cilantro_Orange_Chicken_Bites.honey,
                                                        Cilantro_Orange_Chicken_Bites.garlic,
                                                        Cilantro_Orange_Chicken_Bites.white_vinegar,
                                                        Cilantro_Orange_Chicken_Bites.soy_sauce
            };
            return itemList;
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
