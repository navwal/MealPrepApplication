namespace MealPrepApplication.Meals
{
    public class Mediterranean_Chimkin_with_Yogurt_Sauce
    {
        public static List<Items> ingredients = new List<Items> {
            new Items(4, "lbs", "Chimkin"),
            new Items(10, "cloves", "Garlic"),
            new Items(6, "tbsp", "Plain Greek Yogurt"),
            new Items(4, "tbsp", "Lemon Juice"),
            new Items(2, "tbsp", "Tomato Paste"),
            new Items(2, "tbsp", "Paprika"),
            new Items(1, "tbsp", "Olive Oil"),
            new Items(1, "tbsp", "Cumin"),
            new Items(1, "tbsp", "Oregano"),
            new Items(2, "tsp", "Salt"),
            new Items(0.5, "tsp", "Pepper"),
            new Items(6, "", "Bell Peppers"),
            new Items(2, "", "Red Onions")
            };
        public static List<Items> veggies = new List<Items> {
            new Items(0, "", "For Veggies:"),
            new Items(1, "", "Olive Oil"),
            new Items(1, "", "Salt")
            };
        public static List<Items> sauce = new List<Items> {
            new Items(0, "", "For Sauce:"),
            new Items(1, "cup", "Plain Greek Yogurt"),
            new Items(2, "tbsp", "Lemon Juice"),
            new Items(2, "cloves", "Garlic"),
            new Items(2, "tbsp", "Dill"),
            new Items(1, "taste", "Salt")
            };
    }
}
