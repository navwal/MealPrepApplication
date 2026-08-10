using MealPrepApplication.Meals;
namespace MealPrepApplication.Models
{
    public class Meal
    {
        public string Title { get; set; } = "";
        public List<Items> Ingredients { get; set; } = new();
    }
}
