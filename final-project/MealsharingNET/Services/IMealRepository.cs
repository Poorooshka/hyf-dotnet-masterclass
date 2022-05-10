using mealsharingNET.Models;
namespace mealsharingNET.Services;

public interface IMealRepository
{
    Task AddMeal(Meals meal);
    Task<List<Meals>> ListMeals();
    Task<Meals> FindMealById(int id);
}