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

    [HttpGet]
    public async Task<IEnumerable<Reservation>> ListAllReservations()
    {

        return await _repo.ListReservations();
    }
    [HttpGet("{id}")]
    public async Task<Reservation> GetReservation(int id)
    {
        var reservation = await _repo.FindReservationById(id);
        return reservation;
    }
    [HttpPost("Add")]
    public async Task AddReservation([FromBody] Reservation r)
    {
        await _repo.AddReservation(r);
    }

    [HttpDelete("Delete")]
    public async Task DeleteReservations(int id)
    {
        await _repo.DeleteReservation(id);
    }
}
