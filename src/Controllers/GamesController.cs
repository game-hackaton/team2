using Microsoft.AspNetCore.Mvc;
using thegame.Models;
using thegame.Services;

namespace thegame.Controllers;

[Route("api/games")]
public class GamesController : Controller
{
    private readonly GamesRepository _gamesRepository = new();
    [HttpPost]
    public IActionResult NewGame()
    {
        var game = _gamesRepository.CreateGame();
        return new JsonResult(game);
    }
}