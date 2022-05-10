using Microsoft.AspNetCore.Mvc;
using mealsharingNET.Models;
using mealsharingNET.Services;
namespace mealsharingNET.Controllers;

[ApiController]
[Route("meals")]
public class MealsController : ControllerBase
{
    private IMealrepository _repo;

    public MealsController(IMealrepository repo)
    {
        _repo = repo;
    }

    [HttpGet("List")]
    public List<Meals> ListAllMeals()
    {
        return _repo.ListMeals().ToList();
    }

    [HttpPost("Add")]
    public void AddMeal([FromBody] Meals meal)
    {
        _repo.AddMeal(meal);
    }

    [HttpGet("FindMealById")]
    public Meals FindMealById(int ID)
    {
        return _repo.FindMealById(ID);
    }
}