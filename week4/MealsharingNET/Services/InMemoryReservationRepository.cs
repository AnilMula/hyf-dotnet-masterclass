namespace mealsharingNET.Services;
using mealsharingNET.Models;

public class InMemoryReservationRepository : IreservationRepository
{
    private List<Reservations> Reservations { get; set; } = new List<Reservations>(){
        new Reservations(){ID=1,MealID=1,Name="anil",Mobile=234567,Email="abc@abc.com", ReserveDate=new DateTime(2022,03,19), NoOfPersons = 5 },
        new Reservations(){ID=2,MealID=1,Name="stephan",Mobile=936568,Email="abc@abc.com", ReserveDate=new DateTime(2022,03,19), NoOfPersons = 5 }
    };
    public void AddReservation(Reservations reserve)
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
    public List<Reservations> ListReservations()
    {
        return Reservations;
    }

}
