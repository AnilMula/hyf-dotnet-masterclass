using Microsoft.AspNetCore.Mvc;
using mealsharingNET.Models;
using mealsharingNET.Services;
namespace mealsharingNET.Controllers;

[ApiController]
[Route("reservations")]
public class ReservationsController : ControllerBase
{
    private IReservationRepository _repo;

    public ReservationsController(IReservationRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("List")]
    public List<Reservation> ListAllReservations()
    {

        return _repo.ListReservations().ToList();
    }

    [HttpPost("Add")]
    public void AddReservation([FromBody] Reservation r)
    {
        _repo.AddReservation(r);
    }

    [HttpDelete("Delete")]
    public void DeleteReservations(int id)
    {
        _repo.DeleteReservation(id);
    }
}
