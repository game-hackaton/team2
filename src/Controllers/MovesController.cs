using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using thegame.Models;
using thegame.Services;

namespace thegame.Controllers;

[Route("api/games/{gameId}/moves")]
public class MovesController : Controller
{
    [HttpPost]
    public IActionResult Moves(Guid gameId, [FromBody]UserInputDto userInput)
    {
        var nextPos = InputKeyMapper.Map(userInput.KeyPressed) + TestData.playerPosition;
        var game = TestData.AGameDto(nextPos);
        game.Cells.First(c => c.Type == "player").Pos = nextPos;
        return Ok(game);
    }
}