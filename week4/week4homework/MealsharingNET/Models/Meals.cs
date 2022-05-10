namespace mealsharingNET.Models;

public class Meals
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public double Cost { get; set; }
    public string Location { get; set; }
    public int MaxReservations { get; set; }
    public DateTime MealCreatedDate { get; set; }
    public DateTime MealServingDate { get; set; }

}