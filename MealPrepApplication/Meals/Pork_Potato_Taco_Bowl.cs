namespace MealPrepApplication.Meals
{
    public class Pork_Potato_Taco_Bowl
    {
        public static List<Items> ingredients = new List<Items> {
            new Items(4, "lbs", "Ground Pork"),
            new Items(2, "packets of", "Taco Seasoning")
            };
        public static List<Items> potatoes = new List<Items> {
            new Items(0, "", "For Potatoes:"),
            new Items(3, "lbs", "Potatoes"),
            new Items(3, "tsp", "Paprika"),
            new Items(3, "tsp", "Garlic Powder"),
            new Items(3, "tsp", "Onion Powder"),
            new Items(2, "tsp", "Salt"),
            new Items(2, "tsp", "Pepper")
            };
        public static List<Items> pico = new List<Items> {
            new Items(0, "", "For Pico de Gallo:"),
            new Items(4, "", "Tomatoes"),
            new Items(2, "", "Onions"),
            new Items(2, "small bunches", "Cilantro"),
            new Items(4, "", "Limes")
            };
        public static List<Items> sauce = new List<Items> {
            new Items(0, "", "For Chipotle Sauce"),
            new Items(6, "Tbsp", "Greek Yogurt"),
            new Items(6, "Tbsp", "Chipotle Adobo Sauce"),
            new Items(2.5, "tsp", "Salt"),
            new Items(2.5, "tsp", "Garlic Powder")
            };
    }
}
