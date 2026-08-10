namespace MealPrepApplication.Meals
{
    public class Items
    {
        public double item_amt { get; set; }
        public string item_unit { get; set; }
        public string item_id { get; set; }

        public Items()
        {
            item_amt = 0;
            item_unit = "";
            item_id = "";
        }

        //Overloaded constructor
        public Items(double item_amt, string item_unit, string item_id)
        {
            this.item_amt = item_amt;
            this.item_unit = item_unit;
            this.item_id = item_id;
        }


    }
}
