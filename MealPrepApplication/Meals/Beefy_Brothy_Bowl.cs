namespace MealPrepApplication.Meals
{
    public class Beefy_Brothy_Bowl
    {
        public static List<Items> ingredients = new List<Items>
        {
            new Items(2, "lbs", "90% Lean Beef"),
            new Items(2, "tsp", "Garlic Powder"),
            new Items(2, "tsp", "Onion Powder"),
            new Items(2, "tsp", "Paprika"),
            new Items(3, "tsp", "Beef Bullion"),
            new Items(4, "tsp", "Chili Crisp Oil"),
            new Items(3, "tsp", "Honey"),
            new Items(2, "tsp", "Pepper")
        };

        public static List<Items> broth = new List<Items>
        {
            new Items(0, "", "For Broth:"),
            new Items(32, "oz", "Beef Bone Broth"),
            new Items(2, "cans", "Coconut Milk"),
            new Items(2, "tsp", "Curry Powder"),
            new Items(2, "tsp", "Garlic Powder"),
            new Items(4, "tsp", "Chili Crisp Oil"),
            new Items(3, "tsp", "Beef Bullion"),
            new Items(2, "tbsp", "Soy Sauce"),
            new Items(1, "taste", "Salt")
        };
    }
}
