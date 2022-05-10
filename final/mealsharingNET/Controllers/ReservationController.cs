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
    [HttpPost("")]
    public async Task AddReservation([FromBody] Reservation r)
    {
        await _repo.AddReservation(r);
    }

    [HttpDelete("")]
    public async Task DeleteReservation(int id)
    {
        await _repo.DeleteReservation(id);
    }
    [HttpPut("")]
    public async Task UpdateReservation([FromBody] Reservation r)
    {
        await _repo.UpdateReservation(r);
    }
}
