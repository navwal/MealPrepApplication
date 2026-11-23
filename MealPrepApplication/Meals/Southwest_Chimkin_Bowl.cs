namespace MealPrepApplication.Meals
{
    public class Southwest_Chimkin_Bowl
    {
        public static List<Items> ingredients = new List<Items>
        {
            new Items(2, "lbs", "Chimkin"),
            new Items(2, "Large", "Butternut Squash"),
            new Items(2, "tbsp", "Avocado Oil"),
            new Items(2, "tsp", "Chili Powder"), 
            new Items(2, "mashed", "Avocados"),
            new Items(1, "taste", "Salt"),
            new Items(1, "taste", "Pepper")
        };

        public static List<Items> salsa = new List<Items>
        {
            new Items(0, "", "For Salsa:"),
            new Items(2, "cans", "Black Beans"),
            new Items(3, "cups", "Corn"),
            new Items(0.5, "cups", "Diced Red Onion"),
            new Items(0.5, "chopped", "Cilantro"),
            new Items(2, "juiced", "Limes"),
            new Items(1, "taste", "Salt")
        };

        public static List<Items> chipotle = new List<Items>
        {
            new Items(0, "", "For Chipotle Honey Sauce"),
            new Items(1, "cup", "Sour Cream"),
            new Items(3, "tbsp", "Lime juice"),
            new Items(4, "tsp", "Chipotle Adobe Sauce"),
            new Items(2, "tsp", "Honey"),
            new Items(1, "tsp", "Salt")
        };
    }
}
