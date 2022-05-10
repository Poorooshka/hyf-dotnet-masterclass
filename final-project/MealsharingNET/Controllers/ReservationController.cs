using Microsoft.AspNetCore.Mvc;
using mealsharingNET.Models;
using mealsharingNET.Services;
namespace mealsharingNET.Controllers;

[ApiController]
[Route("api/reservations")]
public class ReservationsController : ControllerBase
{
    private IReservationRepository _repo;

    public ReservationsController(IReservationRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("")]
    public async Task<List<Reservations>> ListAllReservations()
    {
        return await _repo.ListReservations();
    }

    [HttpPost("")]
    public async Task AddReservation([FromBody] Reservations r)
    {
        await _repo.AddReservation(r);
    }

    [HttpGet("{id}")]
    public async Task<IEnumerable<Reservations>> FindReservationByMealId(int id)
    {
        return await _repo.FindReservationByMealId(id);
    }
}