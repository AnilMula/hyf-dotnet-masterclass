namespace mealsharingNET.Services;
using mealsharingNET.Models;

public interface IMealRepository
{
    void AddMeal(Meal meal);
    List<Meal> ListMeals();
    void FindMealById(int id);
    void DeleteMeal(int id);

}