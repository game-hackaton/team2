using System;
using Microsoft.AspNetCore.Mvc;
using thegame.Models;
using thegame.Services;

namespace thegame.Controllers;

[Route("api/games/{level}")]
public class GamesController : Controller
{
    [HttpPost]
    public IActionResult Index([FromRoute]int level)
    {
        return Ok(TestData.AGameDto(new VectorDto {X = 2, Y = 2}, new Guid()));
    }
}