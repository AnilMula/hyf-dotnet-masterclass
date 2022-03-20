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

    [HttpDelete("Delete")]
    public void DeleteReservations(int id)
    {
        _repo.DeleteReservation(id);
    }
}
