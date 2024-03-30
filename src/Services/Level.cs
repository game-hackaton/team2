using thegame.Models;

namespace thegame.Services;

public record Level(int[,] Cells, VectorDto StartPos)
{
    public static readonly int[,] First = 
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
    
    public static readonly int[,] Second =
    {
        {1, 1, 1, 1, 1},
        {1, 0, 2, 3, 1},
        {1, 1, 1, 1, 1}
    };
}