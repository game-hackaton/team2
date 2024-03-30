using System;
using System.Collections.Generic;
using thegame.Models;

namespace thegame.Services;

public static class GameStorage
{
    private static readonly Dictionary<Guid, GameDto> Games = new();

    public static void AddGame(GameDto game)
    {
        Games.TryAdd(game.Id, game);
    }

    public static GameDto GetGame(Guid guid)
    {
        Games.TryGetValue(guid, out var dto);
        return dto;
    }
}