using Microsoft.AspNetCore.Mvc;
using mealsharingNET.Models;
using mealsharingNET.Services;
namespace mealsharingNET.Controllers;

[ApiController]
[Route("api/meals")]
public class MealsController : ControllerBase
{
    private IMealRepository _repo;

    public MealsController(IMealRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("")]
    public async Task<List<Meals>> GetMeals()
    {
        return await _repo.ListMeals();
    }

    [HttpGet("{id}")]
    public async Task<Meals> GetMealById(int id)
    {
        return await _repo.FindMealById(id);
    }

    [HttpPost("")]
    public async Task AddMeal([FromBody] Meals meal)
    {
        await _repo.AddMeal(meal);
    }
}