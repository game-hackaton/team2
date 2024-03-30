using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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

    public static int width = 8;
    public static int height = 8;

    public static GameDto AGameDto(VectorDto movingObjectPosition)
    {
        var testCells = GamesRepository.GenerateField(cells, movingObjectPosition);

        playerPosition = movingObjectPosition;

        return new GameDto(testCells, true, true, width, height, Guid.Empty, GameUtils.IsGameFinished(cells, playerPosition), movingObjectPosition.Y);
    }

    public static bool TryMove(VectorDto prevPos, VectorDto nextPos)
    {
        var nextType = GetCellType(nextPos);
        if (nextType == "wall")
        {
            return false;
        }

        if (nextType == "box" || nextType == "boxOnTarget")
        {
            var diff = nextPos - prevPos;
            var posAfterNext = nextPos + diff;
            var typeAfterNext = GetCellType(posAfterNext);
            if (TryMove(nextPos, posAfterNext))
            {
                if (nextType == "box")
                {
                    ChangeCellToType(nextPos, "empty");
                    if (typeAfterNext == "target")
                    {
                        ChangeCellToType(posAfterNext, "boxOnTarget");
                    }
                    else
                    {
                        ChangeCellToType(posAfterNext, "box");
                    }
                    
                }
                else if(nextType == "")
                {
                    ChangeCellToType(nextPos, "target");
                    if (typeAfterNext == "target")
                    {
                        ChangeCellToType(posAfterNext, "boxOnTarget");
                    }
                    else
                    {
                        ChangeCellToType(posAfterNext, "box");
                    }
                }
                return true;
            }

            return false;
        }

        return true;
    }

    private static string GetCellType(VectorDto pos)
    {
        var num = cells[pos.Y, pos.X];
        var type = GamesRepository.GetType(num);
        return type;
    }

    private static void ChangeCellToType(VectorDto pos, string type)
    {
        var num = GetType(type);
        cells[pos.Y, pos.X] = num;
    }

    public static int GetType(string val)
    {
        return val switch
        {
            "empty" => 0,
            "wall" => 1,
            "box" => 2,
            "target" => 3,
            "boxOnTarget" => 4,
            "player" => 5,
            _ => throw new ArgumentException("Unknow cell type. Please check if your input field is correct")
        };
    }
}