using Microsoft.AspNetCore.Mvc;
using mealsharingNET.Models;
using mealsharingNET.Services;
namespace mealsharingNET.Controllers;

[ApiController]
[Route("meals")]
public class MealsController : ControllerBase
{
    private IMealRepository _repo;

    public MealsController(IMealRepository repo)
    {
        _repo = repo;
    }

    [HttpGet]
    public async Task<IEnumerable<Meal>> ListAllMeals()
    {

        return await _repo.ListMeals();
    }
    [HttpGet("{id}")]
    public async Task<Meal> GetMeal(int id)
    {
        var meal = await _repo.FindMealById(id);
        return meal;
    }
    [HttpPost("Add")]
    public async Task AddMeal([FromBody] Meal m)
    {
        await _repo.AddMeal(m);
    }

    [HttpDelete("Delete")]
    public async Task DeleteMeal(int id)
    {
        await _repo.DeleteMeal(id);
    }
}
