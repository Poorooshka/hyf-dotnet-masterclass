using Dapper;
using mealsharingNET.Models;
using MySql.Data.MySqlClient;

namespace mealsharingNET.Services;

public class ReservationRepository : IReservationRepository
{
    public async Task<List<Reservations>> ListReservations()
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var reservations = await connection.QueryAsync<Reservations>("SELECT * FROM reservations");
        return reservations.ToList();
    }

    public async Task<IEnumerable<Reservations>> FindReservationByMealId(int mealID)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var reservations = await connection.QueryAsync<Reservations>("SELECT * FROM reservations Where MealID=@ID", new { ID = mealID });
        return reservations;
    }
    public async Task AddReservation(Reservations reservation)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var reservations = await connection.ExecuteAsync("INSERT INTO reservations VALUES(@ID, @NumberOfGuests, @MealID, @ReserveDate, @Phone, @Name, @Email)", reservation);
    }
}