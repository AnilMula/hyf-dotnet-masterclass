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

    [HttpGet("List")]
    public List<Meal> ListAllMeals()
    {

        return _repo.ListMeals().ToList();
    }

    [HttpPost("Add")]
    public void AddMeal([FromBody] Meal m)
    {
        _repo.AddMeal(m);
    }

    [HttpDelete("Delete")]
    public void DeleteMeal(int id)
    {
        _repo.DeleteMeal(id);
    }
}
