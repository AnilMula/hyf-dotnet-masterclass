namespace mealsharingNET.Models;

public class MealReserved
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string ShortDescription { get; set; }
    public bool IsVegetarian { get; set; }
    public double Cost { get; set; }
    public string ImageUrl { get; set; }
    public string Location { get; set; }
    public int MaxReservations { get; set; }

    public int Reserved { get; set; }
    public DateTime MealCreatedDate { get; set; }
    public DateTime MealServingDate { get; set; }

}