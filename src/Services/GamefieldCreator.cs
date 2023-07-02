using thegame.Models;

namespace thegame.Services;

public class GamefieldCreator
{
    public static CellDto[] Create(int width, int height)
    {
        var cells = new CellDto[width*height];
        for (var i = 0; i < width; i++)
        for (var j = 0; j < height; j++)
            cells[i * width + j] = new CellDto(new VectorDto(i,j));
        cells[0] = new CellDto(new VectorDto(0, 0), 1);
        cells[1] = new CellDto(new VectorDto(0, 1), 1);
        return cells;
    }
}