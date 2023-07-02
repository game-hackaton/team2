namespace thegame.Models;

public struct VectorDto
{
    public VectorDto(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X { get; set; }
    public int Y { get; set; }
    
    public static VectorDto operator +(VectorDto first,VectorDto second)
    {
        return new VectorDto(first.X + second.X, first.Y + second.Y);
    }
}