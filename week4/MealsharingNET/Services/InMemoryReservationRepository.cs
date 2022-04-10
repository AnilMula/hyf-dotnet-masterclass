namespace mealsharingNET.Services;
using mealsharingNET.Models;

public class InMemoryReservationRepository : IReservationRepository
{
    private List<Reservation> Reservations { get; set; } = new List<Reservation>(){
        new Reservation(){ID=1,MealID=1,Name="anil",Mobile=234567,Email="abc@abc.com", ReserveDate=new DateTime(2022,03,19), NoOfPersons = 5 },
        new Reservation(){ID=2,MealID=1,Name="stephan",Mobile=936568,Email="abc@abc.com", ReserveDate=new DateTime(2022,03,19), NoOfPersons = 5 }
    };
    public void AddReservation(Reservation reserve)
    {
        Reservations.Add(reserve);
    }

    public void DeleteReservation(int id)
    {
        Reservations.RemoveAll(r => r.ID == id);
    }
    public void FindReservationById(int id)
    {
        Reservations.Find(r => r.ID == id);
    }
    public List<Reservation> ListReservations()
    {
        return Reservations;
    }

    List<Reservation> IReservationRepository.ListReservations()
    {
        throw new NotImplementedException();
    }
}
