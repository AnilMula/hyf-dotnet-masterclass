namespace mealsharingNET.Services;
using mealsharingNET.Models;

public class InMemoryReservationRepository : IReservationRepository
{
    private List<Reservation> Reservations { get; set; } = new List<Reservation>(){
        new Reservation(){ID=1,MealID=1,FullName="anil",Mobile=234567,Email="abc@abc.com", ReserveDate=new DateTime(2022,03,19), NoOfPersons = 5 },
        new Reservation(){ID=2,MealID=1,FullName="stephan",Mobile=936568,Email="abc@abc.com", ReserveDate=new DateTime(2022,03,19), NoOfPersons = 5 }
    };
    public async Task AddReservation(Reservation reserve)
    {
        Reservations.Add(reserve);
        await Task.CompletedTask;
    }

    public async Task DeleteReservation(int id)
    {
        Reservations.RemoveAll(r => r.ID == id);
        await Task.CompletedTask;
    }
    public async Task<Reservation> FindReservationById(int id)
    {
        var reservation = Reservations.Where(reservation => reservation.ID == id).SingleOrDefault();
        return await Task.FromResult(reservation);
    }
    public async Task<IEnumerable<Reservation>> ListReservations()
    {
        return await Task.FromResult(Reservations);
    }

    public Task UpdateReservation(Reservation reserve)
    {
        throw new NotImplementedException();
    }
}
