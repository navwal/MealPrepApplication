namespace MealPrepApplication.Meals
{
    public class Potato_Thing
    {
        public static List<Items> ingredients = new List<Items> {
            new Items(3, "lbs", "Chimkin"),
            new Items(1, "tsp", "Garlic Powder"),
            new Items(1, "tsp", "Thyme"),
            new Items(1, "tsp", "Oregano"),
            new Items(4, "tsp", "Olive Oil"),
            new Items(1, "taste", "Salt"),
            new Items(1, "taste", "Pepper")
            };
        public static List<Items> potatoes = new List<Items> {
            new Items(0, "", "For Potatoes:"),
            new Items(6, "", "Potatoes"),
            new Items(1, "zest", "Lemon"),
            new Items(1, "juice", "Lemon"),
            new Items(6, "tsp", "Olive Oil"),
            new Items(2, "tsp", "Oregano"),
            new Items(2, "tsp", "Chili Flakes"),
            new Items(2, "tsp", "Salt"),
            new Items(2, "tsp", "Honey"),
            new Items(1, "amount", "Feta Cheese")
            };
    }
}
