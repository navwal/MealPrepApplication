namespace MealPrepApplication.Meals
{
    public class Cheesy_Asparagus_Stuffed_Chimkin
    {
        public static List<Items> ingredients = new List<Items> {
            new Items(8, "_", "Chimkin Breasts"),
            new Items(24, "_", "Asparagus"),
            new Items(16, "oz", "Mozzarella"),
            new Items(8, "oz", "Sun Dried Tomatoes"),
            new Items(2, "tsp", "Pepper"),
            new Items(2, "tsp", "Salt")
        };

        public static List<Items> sauce = new List<Items> {
            new Items(0, "", "For Pesto:"),
            new Items(1, "cup", "Basil Leaves"),
            new Items(1, "cup", "Spinach"),
            new Items(0.5, "cup", "Olive Oil"),
            new Items(4, "tbsp", "Shredded Parmesan"),
            new Items(4, "tbsp", "Roasted Pinenuts"),
            new Items(2, "cloves", "Garlic"),
            new Items(4, "tsp", "Lemon Juice"),
            new Items(0.5, "tsp", "Salt"),
            new Items(0.25, "tsp", "Pepper")
        };
    }
}
