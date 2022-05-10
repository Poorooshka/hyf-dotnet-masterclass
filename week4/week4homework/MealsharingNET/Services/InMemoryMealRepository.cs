namespace mealsharingNET.Services;
using mealsharingNET.Models;
public class InMemoryMealRepository : IMealrepository
{
    public List<Meals> Meals { get; set; } = new List<Meals>(){
        new Meals(){ID=1,Title="Spaghetti", Description="pasta, meatballs and tomato sauce"},
    };
    public List<Meals> ListMeals()
    {
        return Meals;
    }
    public void AddMeal(Meals meal)
    {
        Meals.Add(meal);
    }

    public Meals FindMealById(int id)
    {
        return Meals.Find(meal => meal.ID == id);
    }
}