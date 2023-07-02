using System;
using System.Collections.Generic;
using System.Linq;
using thegame.Models;

namespace thegame.Services;

public static class GamesRepository
{
    private static Dictionary<Guid, GameDto> Games { get; set; } = new();

    public static List<GameDto> GetAll()
    {
        return Games.Values.ToList();
    }

    public static GameDto GetOrCreateGame(Guid id = new())
    {
        if (Games.ContainsKey(id)) return Games[id];
        var newGame = new GameDto();
        Games.Add(newGame.Id, newGame);
        return newGame;
    }
}