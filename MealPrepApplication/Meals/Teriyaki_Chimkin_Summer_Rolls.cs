namespace MealPrepApplication.Meals
{
    public class Teriyaki_Chimkin_Summer_Rolls
    {
        public static List<Items> ingredients = new List<Items>
        {
            new Items(16, "Wrappers", "Rice Paper"),
            new Items(2, "large", "Bell Peppers"),
            new Items(2, "large", "Cucumbers"),
            new Items(2, "cups", "Shredded Cabbage"),
            new Items(2, "cups", "Shredded Carrot"),
            new Items(1, "bunch", "cilantro"),
            new Items(1, "bunch", "mint leaves"),
            new Items(4, "jalepenos", "Jollies")
    };

        public static List<Items> chimkin = new List<Items> {
            new Items(0, "", "For Chimkin:"),
            new Items(8, "large", "Chimkin Breasts"),
            new Items(2, "tbsp", "Minced Garlic"),
            new Items(2, "tsp", "Garlic Powder"),
            new Items(2, "tsp", "Onion Powder"),
            new Items(2, "tbsp", "Paprika"),
            new Items(1, "tsp", "Salt"),
            new Items(1, "tsp", "Pepper")
    };

        public static List<Items> sauce = new List<Items>
        {
            new Items(0, "", "For Sauce:"),
            new Items(12, "tbsp", "Peanut Butter Powder"),
            new Items(0.5, "cup", "water"),
            new Items(2, "tsp", "Soy Sauce"),
            new Items(4, "tsp", "Teriyaki Sauce"),
            new Items(4, "tsp", "Honey"),
            new Items(2, "tsp", "Minced Garlic"), 
            new Items(2, "tsp", "Siracha")
        };
    }
}
