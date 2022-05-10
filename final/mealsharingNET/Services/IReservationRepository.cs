namespace mealsharingNET.Services;
using mealsharingNET.Models;

public interface IReservationRepository
{
    Task AddReservation(Reservation reserve);
    Task<IEnumerable<Reservation>> ListReservations();
    Task<Reservation> FindReservationById(int id);
    Task DeleteReservation(int id);
    Task UpdateReservation(Reservation reserve);

}