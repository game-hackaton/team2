using System;
using System.Collections.Generic;
using System.Linq;
using thegame.Models;

namespace thegame.Services;

public class GamesRepository
{
    private Dictionary<Guid,GameDto> Games { get; set; }

    public List<GameDto> GetAll()
    {
        return Games.Values.ToList();
    }

    public GameDto GetGame(Guid id)
    {
        return Games[id];
    }

    public GameDto CreateGame()
    {
        var newGame = new GameDto();
        Games.Add(newGame.Id, newGame);
        return newGame;
    }
}