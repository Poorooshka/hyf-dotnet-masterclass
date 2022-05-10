using Dapper;
using mealsharingNET.Models;
using MySql.Data.MySqlClient;

namespace mealsharingNET.Services;

public class MealRepository : IMealRepository
{
    public async Task<List<Meals>> ListMeals()
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var meals = await connection.QueryAsync<Meals>("SELECT * FROM meals");
        return meals.ToList();
    }

    public async Task<Meals> FindMealById(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var meals = await connection.QueryFirstAsync<Meals>("SELECT * FROM meals Where id=@ID", new { ID = id });
        return meals;
    }
    public async Task AddMeal(Meals meal)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var meals = await connection.ExecuteAsync("INSERT INTO meals VALUES(@ID, @Title, @Description, @Location, @MealServingDate, @MaxReservations, @Price, @MealCreatedDate)", meal);
    }
}
