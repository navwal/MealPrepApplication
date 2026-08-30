namespace MealPrepApplication.Meals
{
    public class Teriyaki_Pineapple_Chicken_Meatballs
    {
        public static List<Items> ingredients = new List<Items> {
            new Items(2, "lbs", "chimkin"),
            new Items(2, "", "eggs"),
            new Items(4, "tbsp", "Panko breadcrumbs"),
            new Items(2, "tbsp", "pineapple juice"),
            new Items(2, "tbsp", "soy sauce"),
            new Items(6, "cloves", "garlic"),
            new Items(0.66, "cup", "white onion"),
            new Items(.25, "tsp", "pepper"),
            new Items(2, "20oz cans", "pineapple chunks"),
            new Items(2, "", "red bell peppers"),
            new Items(2, "", "green bell peppers")
            };
        public static List<Items> sauce = new List<Items> {
            new Items(0, "", "For Sauce:"),
            new Items(.5, "cup", "soy sauce"),
            new Items(1, "cup", "water"),
            new Items(4, "cloves", "garlic"),
            new Items(4, "tbsp + 2 tsp", "honey"),
            new Items(4, "tsp", "rice vinegar"),
            new Items(2, "tbsp", "cornstarch"),
            new Items(2, "tbsp", "water for cornstarch")
            };
    }
}
