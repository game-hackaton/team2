using System;
using System.Linq;
using thegame.Models;

namespace thegame.Services;

public static class RandomFiller
{
    public static bool Fill(GameDto game)
    {
        var emptyTiles = game.Cells.Where(c => c.Value == 0).ToList();
        var rnd = new Random();
        return true;
    }
}