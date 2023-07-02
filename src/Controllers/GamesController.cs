using System;
using Microsoft.AspNetCore.Mvc;
using thegame.Services;

namespace thegame.Controllers;

[Route("api/games")]
public class GamesController : Controller
{

    [HttpPost]
    public IActionResult NewGame()
    {
        var game = GamesRepository.GetOrCreateGame();
        return new JsonResult(game);
    }

    [HttpGet]
    [Route("/{gameId}")]
    public IActionResult OpenGame(Guid gameId)
    {
        var game = GamesRepository.GetOrCreateGame();
        return new JsonResult(game);
    }
}