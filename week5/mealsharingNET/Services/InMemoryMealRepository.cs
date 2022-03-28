namespace mealsharingNET.Services;
using mealsharingNET.Models;
public class InMemoryMealRepository : IMealRepository
{
    public List<Meal> Meals { get; set; } = new List<Meal>(){
        new Meal(){ID=1,Title="Pizza",ShortDescription="a good pizza"}
    };
    public async Task AddMeal(Meal meal)
    {
        Meals.Add(meal);
        await Task.CompletedTask;
    }

    public async Task DeleteMeal(int id)
    {
        Meals.RemoveAll(m => m.ID == id);
        await Task.CompletedTask;
    }

    public async Task<Meal> FindMealById(int id)
    {
        var meal = Meals.Where(meal => meal.ID == id).SingleOrDefault();
        return await Task.FromResult(meal);
    }
    public async Task<IEnumerable<Meal>> ListMeals()
    {
        return await Task.FromResult(Meals);
    }
}
