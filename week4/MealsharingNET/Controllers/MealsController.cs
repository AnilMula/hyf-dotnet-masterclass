using Microsoft.AspNetCore.Mvc;
using mealsharingNET.Models;
using mealsharingNET.Services;
namespace mealsharingNET.Controllers;

[ApiController]
[Route("meals")]
public class MealsController : ControllerBase
{
    private IMealrepository _repo;

    public MealsController(IMealrepository repo)
    {
        _repo = repo;
    }

    [HttpGet("List")]
    public List<Meals> ListAllMeals()
    {

        return _repo.ListMeals().ToList();
    }

    [HttpPost("Add")]
    public void AddMeal([FromBody] Meals m)
    {
        _repo.AddMeal(m);
    }

    [HttpDelete("Delete")]
    public void DeleteCar(int id)
    {
        _repo.DeleteMeal(id);
    }
}
