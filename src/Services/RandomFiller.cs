using System;
using System.Linq;
using thegame.Models;

namespace thegame.Services;

public static class RandomFiller
{
    public static bool Fill(CellDto[] cells)
    {
        var emptyTiles = cells.Where(c => c.Value == 0).ToList();
        if (emptyTiles.Count == 0) return false;
        var rnd = new Random();
        var next = rnd.Next(emptyTiles.Count);
        emptyTiles[next].Value = 1;
        return true;
    }
}