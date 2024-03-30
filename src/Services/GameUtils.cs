using System.Linq;

namespace thegame.Services;

public static class GameUtils
{
    public static bool IsGameFinished(int[,] cells)
    {
        var hasUnplacedBoxes = false;

        foreach (var cell in cells)
            if (cell == 2)
                hasUnplacedBoxes = true;

        return !hasUnplacedBoxes;
    }

    public static int GetScore(int[,] cells) => cells.Cast<int>().Count(cell => cell == 4);
}