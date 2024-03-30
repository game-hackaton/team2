namespace thegame.Models;

public class GameState
{
    public VectorDto playerPosition;
    
    public int[,] cells =
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

    public int width = 8;
    public int height = 9;
}