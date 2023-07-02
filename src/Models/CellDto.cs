using System;

namespace thegame.Models;

public class CellDto
{
    /// <summary>
    /// Frontend animate transition of the cell from old to new state.
    /// </summary>
    /// <param name="id">Id is used to identificate cell to apply right animation</param>
    /// <param name="pos">Logical position of the cell in the game grid. Upper left corner is `new Vec(0, 0)`</param>
    /// <param name="type">Frontend apply images and other styling to the cell according to this type</param>
    /// <param name="content">Frontend can put this text in the cell</param>
    /// <param name="zIndex">Frontend render cells with higher zIndex above cells with lower zIndex</param>
    public CellDto(VectorDto pos, int value = 0, int zIndex = 0)
    {
        Id = Guid.NewGuid().ToString();
        Pos = pos;
        Value = value;
        ZIndex = zIndex;
    }

    public string Id { get; set; }
    public VectorDto Pos { get; set; }
    public int ZIndex { get; set; }
    public string Type => "tile-" + Value;
    public int Value { get; set; }

    public string Content => Value == 0? "":Value.ToString();
    
}