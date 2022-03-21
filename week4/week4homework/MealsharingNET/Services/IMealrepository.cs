namespace mealsharingNET.Services;
using mealsharingNET.Models;

public interface IMealrepository
{
    void AddMeal(Meals meal);
    List<Meals> ListMeals();
    Meals FindMealById(int id);
}