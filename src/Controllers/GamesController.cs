using Microsoft.AspNetCore.Mvc;
using thegame.Models;
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
}