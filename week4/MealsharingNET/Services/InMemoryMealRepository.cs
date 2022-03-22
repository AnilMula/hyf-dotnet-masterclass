namespace mealsharingNET.Services;
using mealsharingNET.Models;
public class InMemoryMealRepository : IMealRepository
{
    public List<Meal> Meals { get; set; } = new List<Meal>(){
        new Meal(){ID=1,Title="Pizza",Description="a good pizza"}
    };
    public void AddMeal(Meal meal)
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

    public List<Meal> ListMeals()
    {
        return Meals;
    }

    List<Meal> IMealRepository.ListMeals()
    {
        throw new NotImplementedException();
    }
}
