namespace MealPrepApplication.Meals
{
    public class Baked_Balsamic_Chimkin
    {
        public static List<Items> ingredients = new List<Items>
        {
            new Items(8, "Chimkin Breasts", "Chimkin"),
            new Items(1, "cup", "Balsamic Vinegar"),
            new Items(8, "tsp", "Dijon Mustard"),
            new Items(2, "tsp", "Thyme"),
            new Items(1, "taste", "Garlic Salt"),
            new Items(1, "taste", "Pepper")
    };

        public static List<Items> salsa = new List<Items> {
            new Items(0, "", "For Salsa:"),
            new Items(6, "cups", "Cherry Tomato halves"),
            new Items(2, "8oz package", "Mozzarella Pearls"),
            new Items(1, "cup", "Basil"),
            new Items(0.5, "of", "Red Onion"),
            new Items(0.5, "cup", "Balsamic Vinegar"),
            new Items(1, "taste", "Salt"),
    };
    }
}
