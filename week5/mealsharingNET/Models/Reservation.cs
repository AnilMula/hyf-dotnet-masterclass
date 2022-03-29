namespace mealsharingNET.Models;

public class Reservation
{
    public int ID { get; set; }
    public int MealID { get; set; }
    public string FullName { get; set; }
    public int Mobile { get; set; }
    public string Email { get; set; }
    public DateTime ReserveDate { get; set; }
    public int NoOfPersons { get; set; }
}