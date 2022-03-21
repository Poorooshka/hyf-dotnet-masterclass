namespace mealsharingNET.Services;
using mealsharingNET.Models;

public class InMemoryReservationRepository : IreservationRepository
{
    private List<Reservations> Reservations { get; set; } = new List<Reservations>(){
        new Reservations(){ID=1,MealID=1,Name="Nash",Mobile=5467876,Email="nash@yahoo.com", ReserveDate=new DateTime(2022,03,21), NumberOfGuests = 6 },
        new Reservations(){ID=2,MealID=1,Name="Ivan",Mobile=9876789,Email="Ivan@gmail.com", ReserveDate=new DateTime(2022,03,21), NumberOfGuests = 10 }
    };
    public List<Reservations> ListReservations()
    {
        return Reservations;
    }

    public void AddReservation(Reservations r)
    {
        Reservations.Add(r);
    }
    public IEnumerable<Reservations> FindReservationByMealId(int id)
    {
        return Reservations.Where(r => r.MealID == id);
    }

}