namespace MealPrepApplication.Meals
{
    public class Hot_Honey_Chimken_with_Peach_Salse
    {
        public static List<Items> ingredients = new List<Items> {
            new Items(3, "lbs", "Chimkin (about 8)"),
            new Items(1, "", "Oil"),
            new Items(1, "season", "Paprika"),
            new Items(1, "season", "Cumin"),
            new Items(1, "season", "Salt"),
            new Items(1, "season", "Pepper")
        };
        public static List<Items> honey = new List<Items> {
            new Items(0, "", "For Hot Honey:"),
            new Items(2, "cups", "Honey"),
            new Items(8, "cloves", "Garlic"),
            new Items(2, "tsp", "Red Pepper Flakes"),
            new Items(2, "tsp", "Paprika"),
            new Items(2, "tsp", "salt")
        };
        public static List<Items> salsa = new List<Items> {
            new Items(0, "", "For Salsa:"),
            new Items(8, "", "Peaches"),
            new Items(2, "", "Jalapenos"),
            new Items(0.5, "cup", "Red Onion"),
            new Items(0.5, "cup", "Cilantro"),
            new Items(2, "", "Limes")
        };
    }
}
