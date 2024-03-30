using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic.CompilerServices;

namespace thegame.Models;

public class VectorDto
{
    public int X { get; set; }
    public int Y { get; set; }

    public static VectorDto operator +(VectorDto left, VectorDto right)
    {
        var x = left.X + right.X;
        var y = left.Y + right.Y;
        return new VectorDto() { X = x, Y = y };
    }
}