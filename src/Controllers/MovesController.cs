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
        var game = TestData.AGameDto(userInput.ClickedPos ?? new VectorDto {X = 1, Y = 1});
        if (userInput.ClickedPos != null)
            game.Cells.First(c => c.Type == "player").Pos = userInput.ClickedPos;
        return Ok(game);
    }
}