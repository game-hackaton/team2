using System;
using System.Linq;
using thegame.Models;

namespace thegame.Services;

public static class RandomFiller
{
    private static Random _random = new();
    public static bool Fill(CellDto[] cells)
    {
        var emptyTiles = cells.Where(c => c.Value == 0).ToList();
        if (emptyTiles.Count == 0) return false;
        var tileIndex = _random.Next(emptyTiles.Count);
        emptyTiles[tileIndex].Value = TileValue();
        return true;
    }

    private static int TileValue()
    {
        var dice = _random.Next(10);
        return dice <= 7 ? 2 : 4;
    }
}