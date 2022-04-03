namespace mealsharingNET.Models;

public class Meals
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public DateTime MealServingDate { get; set; }
    public int MaxReservations { get; set; }
    public double Price { get; set; }
    public DateTime MealCreatedDate { get; set; }

}

