namespace mealsharingNET.Models;

public class MealReservations
{
    public int ID { get; set; }
    public string FullName { get; set; }
    public int NoOfPersons { get; set; }
    public string Title { get; set; }
    public int MaxReservations { get; set; }
}