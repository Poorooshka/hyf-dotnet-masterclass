namespace mealsharingNET.Services;
using mealsharingNET.Models;

public interface IreservationRepository
{
    List<Reservations> ListReservations();
    void AddReservation(Reservations reservation);
    IEnumerable<Reservations> FindReservationByMealId(int id);
}