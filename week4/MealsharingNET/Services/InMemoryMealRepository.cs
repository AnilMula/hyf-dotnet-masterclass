namespace mealsharingNET.Services;
using mealsharingNET.Models;
public class InMemoryMealRepository : IMealrepository
{
    public List<Meals> Meals { get; set; } = new List<Meals>(){
        new Meals(){ID=1,Title="Pizza",Description="a good pizza"}
    };
    public void AddMeal(Meals meal)
    {
        Meals.Add(meal);
    }

    public void DeleteMeal(int id)
    {
        Meals.RemoveAll(m => m.ID == id);
    }

    public void FindMealById(int id)
    {
        Meals.Find(m => m.ID == id);
    }

    public List<Meals> ListMeals()
    {
        return Meals;
    }

}
