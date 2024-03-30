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
        var testCells = new[]
        {
            new CellDto("1", new VectorDto {X = 0, Y = 0}, "empty", "", 0),
            new CellDto("2", new VectorDto {X = 1, Y = 0}, "empty", "", 0),
            new CellDto("3", new VectorDto {X = 2, Y = 0}, "wall", "", 0),
            new CellDto("4", new VectorDto {X = 3, Y = 0}, "wall", "", 0),
            new CellDto("5", new VectorDto {X = 4, Y = 0}, "wall", "", 0),
            new CellDto("6", new VectorDto {X = 5, Y = 0}, "wall", "", 0),
            new CellDto("7", new VectorDto {X = 6, Y = 0}, "wall", "", 0),
            new CellDto("35", new VectorDto {X = 7, Y = 0}, "empty", "", 0),

            new CellDto("8", new VectorDto {X = 0, Y = 1}, "wall", "", 0),
            new CellDto("9", new VectorDto {X = 1, Y = 1}, "wall", "", 0),
            new CellDto("10", new VectorDto {X = 2, Y = 1}, "wall", "", 0),
            new CellDto("11", new VectorDto {X = 3, Y = 1}, "empty", "", 0),
            new CellDto("12", new VectorDto {X = 4, Y = 1}, "empty", "", 0),
            new CellDto("13", new VectorDto {X = 5, Y = 1}, "empty", "", 0),
            new CellDto("14", new VectorDto {X = 6, Y = 1}, "wall", "", 0),
            new CellDto("35", new VectorDto {X = 7, Y = 1}, "empty", "", 0),

            new CellDto("15", new VectorDto {X = 0, Y = 2}, "wall", "", 0),
            new CellDto("16", new VectorDto {X = 1, Y = 2}, "target", "", 0),
            new CellDto("17", movingObjectPosition, "player", "", 20),
            new CellDto("18", new VectorDto {X = 3, Y = 2}, "box", "", 0),
            new CellDto("19", new VectorDto {X = 4, Y = 2}, "empty", "", 0),
            new CellDto("20", new VectorDto {X = 5, Y = 2}, "empty", "", 0),
            new CellDto("21", new VectorDto {X = 6, Y = 2}, "wall", "", 0),
            new CellDto("35", new VectorDto {X = 7, Y = 2}, "empty", "", 0),

            new CellDto("22", new VectorDto {X = 0, Y = 3}, "wall", "", 0),
            new CellDto("23", new VectorDto {X = 1, Y = 3}, "wall", "", 0),
            new CellDto("24", new VectorDto {X = 2, Y = 3}, "wall", "", 0),
            new CellDto("25", new VectorDto {X = 3, Y = 3}, "empty", "", 0),
            new CellDto("26", new VectorDto {X = 4, Y = 3}, "box", "", 0),
            new CellDto("27", new VectorDto {X = 5, Y = 3}, "target", "", 0),
            new CellDto("28", new VectorDto {X = 6, Y = 3}, "wall", "", 0),
            new CellDto("35", new VectorDto {X = 7, Y = 3}, "empty", "", 0),

            new CellDto("29", new VectorDto {X = 0, Y = 4}, "wall", "", 0),
            new CellDto("30", new VectorDto {X = 1, Y = 4}, "target", "", 0),
            new CellDto("31", new VectorDto {X = 2, Y = 4}, "wall", "", 0),
            new CellDto("32", new VectorDto {X = 3, Y = 4}, "wall", "", 0),
            new CellDto("33", new VectorDto {X = 4, Y = 4}, "box", "", 0),
            new CellDto("34", new VectorDto {X = 5, Y = 4}, "empty", "", 0),
            new CellDto("35", new VectorDto {X = 6, Y = 4}, "wall", "", 0),
            new CellDto("35", new VectorDto {X = 7, Y = 4}, "empty", "", 0),

            new CellDto("36", new VectorDto {X = 0, Y = 5}, "wall", "", 0),
            new CellDto("37", new VectorDto {X = 1, Y = 5}, "empty", "", 0),
            new CellDto("38", new VectorDto {X = 2, Y = 5}, "wall", "", 0),
            new CellDto("39", new VectorDto {X = 3, Y = 5}, "empty", "", 0),
            new CellDto("40", new VectorDto {X = 4, Y = 5}, "target", "", 0),
            new CellDto("41", new VectorDto {X = 5, Y = 5}, "empty", "", 0),
            new CellDto("42", new VectorDto {X = 6, Y = 5}, "wall", "", 0),
            new CellDto("42", new VectorDto {X = 7, Y = 5}, "wall", "", 0),

            new CellDto("43", new VectorDto {X = 0, Y = 6}, "wall", "", 0),
            new CellDto("44", new VectorDto {X = 1, Y = 6}, "box", "", 0),
            new CellDto("45", new VectorDto {X = 2, Y = 6}, "empty", "", 0),
            new CellDto("46", new VectorDto {X = 3, Y = 6}, "boxOnTarget", "", 0),
            new CellDto("47", new VectorDto {X = 4, Y = 6}, "box", "", 0),
            new CellDto("48", new VectorDto {X = 5, Y = 6}, "box", "", 0),
            new CellDto("49", new VectorDto {X = 6, Y = 6}, "target", "", 0),
            new CellDto("50", new VectorDto {X = 7, Y = 6}, "wall", "", 0),

            new CellDto("51", new VectorDto {X = 0, Y = 7}, "wall", "", 0),
            new CellDto("52", new VectorDto {X = 1, Y = 7}, "empty", "", 0),
            new CellDto("53", new VectorDto {X = 2, Y = 7}, "empty", "", 0),
            new CellDto("54", new VectorDto {X = 3, Y = 7}, "empty", "", 0),
            new CellDto("55", new VectorDto {X = 4, Y = 7}, "target", "", 0),
            new CellDto("56", new VectorDto {X = 5, Y = 7}, "empty", "", 0),
            new CellDto("57", new VectorDto {X = 6, Y = 7}, "empty", "", 0),
            new CellDto("58", new VectorDto {X = 7, Y = 7}, "wall", "", 0),

            new CellDto("59", new VectorDto {X = 0, Y = 8}, "wall", "", 0),
            new CellDto("60", new VectorDto {X = 1, Y = 8}, "wall", "", 0),
            new CellDto("61", new VectorDto {X = 2, Y = 8}, "wall", "", 0),
            new CellDto("62", new VectorDto {X = 3, Y = 8}, "wall", "", 0),
            new CellDto("63", new VectorDto {X = 4, Y = 8}, "wall", "", 0),
            new CellDto("64", new VectorDto {X = 5, Y = 8}, "wall", "", 0),
            new CellDto("65", new VectorDto {X = 6, Y = 8}, "wall", "", 0),
            new CellDto("66", new VectorDto {X = 7, Y = 8}, "wall", "", 0),
        };

        playerPosition = movingObjectPosition;
        return new GameDto(testCells, true, true, width, height, Guid.Empty, movingObjectPosition.X == 0, movingObjectPosition.Y);
    }
}