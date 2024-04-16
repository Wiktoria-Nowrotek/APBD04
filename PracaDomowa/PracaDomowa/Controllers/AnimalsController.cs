using Microsoft.AspNetCore.Mvc;
using PracaDomowa.Models;

namespace PracaDomowa.Controllers;

[Route("api/animals")]
[ApiController]
public class AnimalsController : ControllerBase
{
    private static readonly List<Animal> _animals = new()
    {
        new Animal { IdAnimal = 1, Name = "Puszek", Category = "kot", Weight = 5.45, FurColor = "biały" },
        new Animal { IdAnimal = 2, Name = "Burek", Category = "pies", Weight = 33.2, FurColor = "czarny" }, 
        new Animal { IdAnimal = 3, Name = "Ogryzek", Category = "chomik", Weight = 0.019, FurColor = "ciemnobrazowy" },
        new Animal { IdAnimal = 4, Name = "Roko", Category = "papuga", Weight = 0.27, FurColor = "zielony" }

    };
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok(_animals);
    }
    
    [HttpGet("{id:int}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = _animals.FirstOrDefault(a => a.IdAnimal == id);
        if (animal == null)
        {
            return NotFound($"Aniaml with id {id} was not found");
        }

        return Ok(animal);
    }

    [HttpPost]
    public IActionResult CreateAnimal(Animal animal)
    {
        _animals.Add(animal);
        return StatusCode(StatusCodes.Status201Created);
    }
    
    
}