﻿using System;
using thegame.Models;

namespace thegame.Services;

public class TestData
{
    public static VectorDto playerPosition;
    
    public static int[,] cells = 
    {
        {0, 0, 1, 1, 1, 1, 1, 0},
        {1, 1, 1, 0, 0, 0, 1, 0},
        {1, 3, 0, 2, 0, 0, 1, 0},
        {1, 1, 1, 0, 2, 3, 1, 0},
        {1, 3, 1, 1, 2, 0, 1, 0},
        {1, 0, 1, 0, 3, 0, 1, 1},
        {1, 2, 0, 4, 2, 2, 3, 1},
        {1, 0, 0, 0, 3, 0, 0, 1},
        {1, 1, 1, 1, 1, 1, 1, 1}
    };
    
    public static GameDto AGameDto(VectorDto movingObjectPosition)
    {
        var width = 8;
        var height = 9;
        var testCells = GamesRepository.GenerateField(cells, movingObjectPosition);

        playerPosition = movingObjectPosition;

        return new GameDto(testCells, true, true, width, height, Guid.Empty, GameUtils.IsGameFinished(cells), GameUtils.GetScore(cells));
    }
    
    
}