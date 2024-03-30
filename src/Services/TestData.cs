using System;
using thegame.Models;

namespace thegame.Services;

public class TestData
{
    public static GameDto AGameDto(VectorDto movingObjectPosition)
    {
        var width = 10;
        var height = 8;
        var testCells = new[]
        {
            new CellDto("1", new VectorDto {X = 0, Y = 0}, "empty", "", 0),
            new CellDto("2", new VectorDto {X = 1, Y = 0}, "empty", "", 0),
            new CellDto("3", new VectorDto {X = 2, Y = 0}, "wall", "", 0),
            new CellDto("4", new VectorDto {X = 3, Y = 0}, "wall", "", 0),
            new CellDto("5", new VectorDto {X = 4, Y = 0}, "wall", "", 0),
            new CellDto("6", new VectorDto {X = 5, Y = 0}, "wall", "", 0),
            new CellDto("7", new VectorDto {X = 6, Y = 0}, "wall", "", 0),

            new CellDto("8", new VectorDto {X = 0, Y = 1}, "wall", "", 0),
            new CellDto("9", new VectorDto {X = 1, Y = 1}, "wall", "", 0),
            new CellDto("10", new VectorDto {X = 2, Y = 1}, "wall", "", 0),
            new CellDto("11", new VectorDto {X = 3, Y = 1}, "empty", "", 0),
            new CellDto("12", new VectorDto {X = 4, Y = 1}, "empty", "", 0),
            new CellDto("13", new VectorDto {X = 5, Y = 1}, "empty", "", 0),
            new CellDto("14", new VectorDto {X = 6, Y = 1}, "wall", "", 0),

            new CellDto("15", new VectorDto {X = 0, Y = 2}, "wall", "", 0),
            new CellDto("16", new VectorDto {X = 1, Y = 2}, "target", "", 0),
            new CellDto("17", new VectorDto {X = 2, Y = 2}, "player", "", 20),
            new CellDto("18", new VectorDto {X = 3, Y = 2}, "box", "", 0),
            new CellDto("19", new VectorDto {X = 4, Y = 2}, "empty", "", 0),
            new CellDto("20", new VectorDto {X = 5, Y = 2}, "empty", "", 0),
            new CellDto("21", new VectorDto {X = 6, Y = 2}, "wall", "", 0),

            new CellDto("22", new VectorDto {X = 0, Y = 3}, "wall", "", 0),
            new CellDto("23", new VectorDto {X = 1, Y = 3}, "wall", "", 0),
            new CellDto("24", new VectorDto {X = 2, Y = 3}, "wall", "", 0),
            new CellDto("25", new VectorDto {X = 3, Y = 3}, "empty", "", 0),
            new CellDto("26", new VectorDto {X = 4, Y = 3}, "box", "", 0),
            new CellDto("27", new VectorDto {X = 5, Y = 3}, "target", "", 0),
            new CellDto("28", new VectorDto {X = 6, Y = 3}, "wall", "", 0),

            new CellDto("29", new VectorDto {X = 0, Y = 4}, "wall", "", 0),
            new CellDto("30", new VectorDto {X = 1, Y = 4}, "target", "", 0),
            new CellDto("31", new VectorDto {X = 2, Y = 4}, "wall", "", 0),
            new CellDto("32", new VectorDto {X = 3, Y = 4}, "wall", "", 0),
            new CellDto("33", new VectorDto {X = 4, Y = 4}, "box", "", 0),
            new CellDto("34", new VectorDto {X = 5, Y = 4}, "empty", "", 0),
            new CellDto("35", new VectorDto {X = 6, Y = 4}, "wall", "", 0),
        };
        return new GameDto(testCells, true, true, width, height, Guid.Empty, movingObjectPosition.X == 0, movingObjectPosition.Y);
    }
}