using System;
using System.Linq;
using System.Runtime.InteropServices;
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
        var nextPos = InputKeyMapper.Map(userInput.KeyPressed) + TestData._instances[gameId].playerPosition;
        if (TestData.TryMove(TestData._instances[gameId].playerPosition, nextPos, gameId))
        {
            var game = TestData.AGameDto(nextPos, gameId);
            game.Cells.First(c => c.Type == "player").Pos = nextPos;
            return Ok(game);
        }
        
        return Ok(TestData.AGameDto(TestData._instances[gameId].playerPosition, gameId));
    }
}