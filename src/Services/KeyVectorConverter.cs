using System;
using System.Numerics;
using thegame.Models;

namespace thegame.Services;

public static class KeyVectorConverter
{
    public static VectorDto Convert(char key)
    {
        if (key == 37)
            return new VectorDto(-1, 0);
        if (key == 38)
            return new VectorDto(0, -1);
        if (key == 39)
            return new VectorDto(1, 0);
        if (key == 40)
            return new VectorDto(0, 1);
        return new VectorDto(0, 0);
    }
}