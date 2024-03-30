using System.Collections.Generic;
using thegame.Models;

namespace thegame.Services;

public static class Levels
{
    public static readonly Level First = new(Level.First, new VectorDto {X = 2, Y = 2});

    public static readonly Level Second = new(Level.Second, new VectorDto {X = 1, Y = 1});

    public static readonly List<Level> AvailableLevels = new()
    {
        First, Second
    };
}