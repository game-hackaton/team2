using System;
using thegame.Models;

namespace thegame.Services;

public class TestData
{
    public static VectorDto playerPosition;
    public static GameDto AGameDto(VectorDto movingObjectPosition)
    {
        var width = 8;
        var height = 9;
        var cells = new[,]
        {
            {0, 0, 1, 1, 1, 1, 1, 0},
            {1, 1, 1, 0, 0, 0, 1, 0},
            {1, 3, 5, 2, 0, 0, 1, 0},
            {1, 1, 1, 0, 2, 3, 1, 0},
            {1, 3, 1, 1, 2, 0, 1, 0},
            {1, 0, 1, 0, 3, 0, 1, 1},
            {1, 2, 0, 4, 2, 2, 3, 1},
            {1, 0, 0, 0, 3, 0, 0, 1},
            {1, 1, 1, 1, 1, 1, 1, 1}
        };
        var testCells = GamesRepository.GenerateField(cells);

        playerPosition = movingObjectPosition;
        return new GameDto(testCells, true, true, width, height, Guid.Empty, movingObjectPosition.X == 0, movingObjectPosition.Y);
    }
}