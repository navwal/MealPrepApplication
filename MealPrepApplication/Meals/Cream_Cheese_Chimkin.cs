namespace MealPrepApplication.Meals
{
    public class Cream_Cheese_Chimkin
    {
        public static List<Items> ingredients = new List<Items>
        {
            new Items(2, "lbs", "Chimkin Breast"),
            new Items(4, "tsp", "Daily Blend"),
            new Items(2, "tsp", "Paprika"),
            new Items(2, "tsp", "Bella Blend"),
            new Items(4, "tsp", "Butter"),
            new Items(4, "tsp", "Olive Oil")
        };

        public static List<Items> sauce = new List<Items>
        {
            new Items(0, "", "For Sauce:"),
            new Items(4, "diced", "Shallots"),
            new Items(1.5, "cups", "Chimkin Stock"),
            new Items(8, "tbsp", "Light Cream Cheese"),
            new Items(2, "tsp", "Dijon Mustard"),
            new Items(1, "leftover", "Chimkin Juice"),
            new Items(2, "bunch", "Diced Chives")
        };
    }
}
