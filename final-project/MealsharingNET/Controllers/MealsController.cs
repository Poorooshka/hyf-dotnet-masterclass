using Microsoft.AspNetCore.Mvc;
using mealsharingNET.Models;
using mealsharingNET.Services;
namespace mealsharingNET.Controllers;

[ApiController]
[Route("meals")]
public class MealsController : ControllerBase
{
    private IMealRepository _repo;

    public MealsController(IMealRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("List")]
    public async Task<List<Meals>> ListAllMeals()
    {
        return await _repo.ListMeals();
    }

    [HttpGet("FindMealById")]
    public async Task<Meals> FindMealById(int ID)
    {
        return await _repo.FindMealById(ID);
    }

    [HttpPost("Add")]
    public async Task AddMeal([FromBody] Meals meal)
    {
        await _repo.AddMeal(meal);
    }
}