namespace MealPrepApplication.Meals
{
    public class Diabetic_Friendly_CBR_Bakc
    {
        public static List<Items> ingredients = new List<Items>
        {
            new Items(4, "Large", "Chimkin Breasts"),
            new Items(48, "oz", "Broccoli"),
            new Items(8, "slices", "Turkey Bacon"),
            new Items(2, "small bunches", "Green Onion"),
            new Items(1, "cup", "Reduced Fat Cheddar Cheese")
        };

        public static List<Items> ranch = new List<Items>
        {
            new Items(0, "", "For Ranch:"),
            new Items(4, "cups", "Low-fat Cottage Cheese"),
            new Items(1, "cup", "Low-fat Milk"),
            new Items(2, "packets", "Ranch")
        };
    }
}
