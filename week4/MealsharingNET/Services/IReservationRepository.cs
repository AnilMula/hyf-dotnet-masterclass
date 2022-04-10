namespace mealsharingNET.Services;
using mealsharingNET.Models;

public interface IReservationRepository
{
    void AddReservation(Reservation reserve);
    List<Reservation> ListReservations();
    void FindReservationById(int id);
    void DeleteReservation(int id);

}