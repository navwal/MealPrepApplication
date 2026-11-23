namespace MealPrepApplication.Meals
{
    public class Peruvian_Chimkin_With_Green_Sauce
    {
        public static List<Items> ingredients = new List<Items>
        {
            new Items(4, "lbs", "Chimkin Thighs"),
            new Items(1, "cup", "Soy Sauce"),
            new Items(1.5, "cup", "Cilantro"),
            new Items(12, "cloves", "Garlic"),
            new Items(6, "tbsp", "White Vinegar"),
            new Items(3, "tbsp", "Olive Oil"),
            new Items(3, "tsp", "Paprika"),
            new Items(2, "tsp", "Cumin"),
            new Items(1.5, "tsp", "Oregano"),
            new Items(0.5, "tsp", "Cayenne")
        };

        public static List<Items> sauce = new List<Items>
        {
            new Items(0, "", "For Sauce:"),
            new Items(1, "cup", "Sour Cream"),
            new Items(2, "Chopped", "Jollies"),
            new Items(4, "cloves", "Garlic"),
            new Items(2, "cup", "Cilantro"),
            new Items(4, "tbsp", "Cojita Cheese"),
            new Items(2, "tbsp", "Lime Juice"),
            new Items(2, "tsp", "Red Wine Vinegar"),
            new Items(1, "taste", "Salt"),
            new Items(1, "taste", "Pepper")
        };

        public static List<Items> potatoes = new List<Items>
        {
            new Items(0, "", "For Potatoes:"),
            new Items(3, "lbs", "Golden Baby Potatoes"),
            new Items(2, "tbsp", "Oil"),
            new Items(2, "tsp", "Chili Powder"),
            new Items(2, "tsp", "Paprika"),
            new Items(2, "tsp", "Salt"),
            new Items(1, "tsp", "Garlic Powder"),
            new Items(0.5, "tsp", "Pepper")
        };

        public static List<Items> veggie = new List<Items>
        {
            new Items(0, "", "For Asparagus:"),
            new Items(2, "bundles", "Asparagus"),
            new Items(1, "some", "Oil"),
            new Items(1, "some", "Salt"),
            new Items(1, "some", "Pepper")
        };
    }
}
