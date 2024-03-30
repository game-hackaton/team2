using System;
using System.Collections.Generic;
using thegame.Models;

namespace thegame.Services;

public class TestData
{
    /*public static VectorDto playerPosition;

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
    public static int height = 9;*/

    public static Dictionary<Guid, GameState> _instances = new();
    
    public static GameDto AGameDto(VectorDto movingObjectPosition, Guid id)
    {
        if (!_instances.ContainsKey(id))
            _instances[id] = new GameState();
        
        var testCells = GamesRepository.GenerateField(_instances[id].cells, movingObjectPosition);

        _instances[id].playerPosition = movingObjectPosition;

        return new GameDto(testCells, true, true, _instances[id].width, _instances[id].height, id, GameUtils.IsGameFinished(_instances[id].cells), GameUtils.GetScore(_instances[id].cells));
    }

    public static bool TryMove(VectorDto prevPos, VectorDto nextPos, Guid id)
    {
        var nextType = GetCellType(nextPos, id);
        if (nextType == "wall")
        {
            return false;
        }

        if (nextType == "box" || nextType == "boxOnTarget")
        {
            var diff = nextPos - prevPos;
            var posAfterNext = nextPos + diff;
            var typeAfterNext = GetCellType(posAfterNext, id);
            if (typeAfterNext == "box" || typeAfterNext == "boxOnTarget" || typeAfterNext == "wall")
                return false;

            if (nextType == "box")
            {
                ChangeCellToType(nextPos, "empty", id);
                if (typeAfterNext == "target")
                {
                    ChangeCellToType(posAfterNext, "boxOnTarget", id);
                }
                else
                {
                    ChangeCellToType(posAfterNext, "box", id);
                }

            }
            else if (nextType == "boxOnTarget")
            {
                ChangeCellToType(nextPos, "target", id);
                if (typeAfterNext == "target")
                {
                    ChangeCellToType(posAfterNext, "boxOnTarget", id);
                }
                else
                {
                    ChangeCellToType(posAfterNext, "box", id);
                }
            }
            return true;
        }

        return true;
    }

    private static string GetCellType(VectorDto pos, Guid id)
    {
        var num = _instances[id].cells[pos.Y, pos.X];
        var type = GamesRepository.GetType(num);
        return type;
    }

    private static void ChangeCellToType(VectorDto pos, string type, Guid id)
    {
        var num = GetType(type);
        _instances[id].cells[pos.Y, pos.X] = num;
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