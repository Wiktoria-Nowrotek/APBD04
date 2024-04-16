using Microsoft.AspNetCore.Mvc;

namespace PracaDomowa.Models;

[Route("api/animals")]
[ApiController]
public class AnimalsController : ControllerBase
{
    public string GetAnimals()
    {
        return "cat,dog,hamster"
    }
}