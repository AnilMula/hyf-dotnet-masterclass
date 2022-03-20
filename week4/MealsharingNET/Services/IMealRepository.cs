namespace mealsharingNET.Services;
using mealsharingNET.Models;

public interface IMealrepository
{
    void AddMeal(Meals meal);
    List<Meals> ListMeals();
    void FindMealById(int id);
    void DeleteMeal(int id);

}