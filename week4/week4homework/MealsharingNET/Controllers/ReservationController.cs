using Microsoft.AspNetCore.Mvc;
using mealsharingNET.Models;
using mealsharingNET.Services;
namespace mealsharingNET.Controllers;

[ApiController]
[Route("reservations")]
public class ReservationsController : ControllerBase
{
    private IreservationRepository _repo;

    public ReservationsController(IreservationRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("List")]
    public List<Reservations> ListAllReservations()
    {
        return _repo.ListReservations().ToList();
    }

    [HttpPost("Add")]
    public void AddReservation([FromBody] Reservations r)
    {
        _repo.AddReservation(r);
    }

    [HttpGet("FindReservationByMealId")]
    public List<Reservations> FindReservationByMealId(int id)
    {
        return _repo.FindReservationByMealId(id).ToList();
    }
}