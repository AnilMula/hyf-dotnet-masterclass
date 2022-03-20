namespace mealsharingNET.Services;
using mealsharingNET.Models;

public interface IreservationRepository
{
    void AddReservation(Reservations reserve);
    List<Reservations> ListReservations();
    void FindReservationById(int id);
    void DeleteReservation(int id);

}