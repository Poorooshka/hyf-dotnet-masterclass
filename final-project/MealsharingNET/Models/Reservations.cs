namespace mealsharingNET.Models;

public class Reservations
{
    public int ID { get; set; }
    public int NumberOfGuests { get; set; }
    public int MealID { get; set; }
    public DateTime ReserveDate { get; set; }
    public int Phone { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}

