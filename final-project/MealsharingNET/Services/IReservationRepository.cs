using mealsharingNET.Models;
namespace mealsharingNET.Services;

public interface IReservationRepository
{
    Task<List<Reservations>> ListReservations();
    Task AddReservation(Reservations reservation);
    Task<IEnumerable<Reservations>> FindReservationByMealId(int id);
}