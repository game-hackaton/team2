using System;
using System.Collections.Generic;
using thegame.Models;

namespace thegame.Services;

public class GamesRepository
{
    public static CellDto[] GenerateField(int[,] cells, VectorDto movingObjectPosition)
    {
        var result = new List<CellDto>();

        var currentId = 0;
        var rows = cells.GetLength(0);
        var cols = cells.GetLength(1);

        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < cols; j++)
            {
                string type = null;
                var zIndex = -1;
                if (i == movingObjectPosition.Y && j == movingObjectPosition.X)
                {
                    type = "player";
                    zIndex = 30;
                }
                
                result.Add(new CellDto(currentId.ToString(),
                    new VectorDto {X = j, Y = i},
                    type ?? GetType(cells[i, j]),
                    "",
                    zIndex == -1 ? GetZIndex(cells[i, j]) : zIndex));
                
                currentId++;
            }
        }

        return result.ToArray();
    }

    private static string GetType(int val)
    {
        return val switch
        {
            0 => "empty",
            1 => "wall",
            2 => "box",
            3 => "target",
            4 => "boxOnTarget",
            5 => "player",
            _ => throw new ArgumentException("Unknow cell type. Please check if your input field is correct")
        };
    }
    
    private static int GetZIndex(int val)
    {
        return val switch
        {
            0 => 0,
            1 => 50,
            2 => 40,
            3 => 20,
            4 => 40,
            5 => 30,
            _ => throw new ArgumentException("Unknow cell type. Please check if your input field is correct")
        };
    }
}