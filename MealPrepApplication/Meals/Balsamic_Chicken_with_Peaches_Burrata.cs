namespace MealPrepApplication.Meals
{
    public class Balsamic_Chicken_with_Peaches_Burrata
    {
        public static List<Items> ingredients = new List<Items> {
            new Items(4, "lbs", "Chicken"),
            new Items(0.5, "cup", "Balsamic Vinegar"),
            new Items(4, "tbsp", "Olive Oil"),
            new Items(2, "tbsp", "Dijon Mustard"),
            new Items(4, "cloves", "Garlic"),
            new Items(2, "tsp", "Salt"),
            new Items(1, "tsp", "dried Oregano"),
            new Items(0.5, "tsp", "Pepper")
    };

        public static List<Items> salsa = new List<Items> {
            new Items(0, "", "For Topping"),
            new Items(16, "oz", "fresh Burrata"),
            new Items(8, "_", "Peaches"),
            new Items(0.5, "cup", "fresh Basil")
    };
    }
}
