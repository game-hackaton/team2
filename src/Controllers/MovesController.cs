using System;
using System.Linq;
using System.Numerics;
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
        var game = GamesRepository.GetOrCreateGame(gameId);
        if (game == null) return NotFound();
        VectorDto direction;
        if (userInput == null) return Ok(game);
        direction = KeyVectorConverter.Convert((char)userInput.KeyPressed);
        if (direction.X == direction.Y) return Ok(game);
        game = Mover.Move(game, direction);
        return Ok(game);
    }
}