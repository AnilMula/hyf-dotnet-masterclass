namespace mealsharingNET.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using mealsharingNET.Models;
using MySql.Data.MySqlClient;
using Dapper;
public class MealRepository : IMealRepository
{
    public async Task AddMeal(Meal meal)
    {

        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var mealId = await connection.ExecuteAsync("INSERT INTO Meal VALUES (@ID, @Title, @ShortDescription, @IsVegetarian, @Cost, @ImageUrl,@Location,@MaxReservations, @MealCreatedDate, @MealServingDate)", meal);
    }

    public async Task DeleteMeal(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        await connection.ExecuteAsync("DELETE FROM Meal WHERE id=@ID", new { ID = id });
    }

    public async Task<Meal> FindMealById(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var meal = await connection.QueryFirstAsync<Meal>("SELECT * FROM meal WHERE ID=@MealId", new { MealId = id });
        return meal;
    }

    public async Task<IEnumerable<Meal>> ListMeals()
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var meals = await connection.QueryAsync<Meal>("SELECT * FROM meal");
        return meals;
    }

    public async Task<IEnumerable<MealReserved>> MealsReserved()
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var meals = await connection.QueryAsync<MealReserved>("SELECT meal.* , sum(NoOfPersons) as reserved from meal inner join reservation where meal.ID in (select meal.id from meal) group by meal.id");
        return meals;
    }

    public async Task<IEnumerable<MealReservations>> ReservedMeals(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var meals = await connection.QueryAsync<MealReservations>("SELECT meal.ID, Title, MaxReservations, FullName, NoOfPersons from meal inner join reservation where meal.ID = @MealId", new { MealId = id });
        return meals;
    }

    public async Task UpdateMeal(Meal meal)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        await connection.ExecuteAsync("UPDATE meal SET cost = @Cost WHERE id = @ID ", meal);
    }
}