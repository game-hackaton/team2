using System.Collections.Generic;
using System.Linq;
using thegame.Models;

namespace thegame.Services;

public class Mover
{
    public static GameDto Move(GameDto game, VectorDto direction)
    {
        bool hasMoved = true;
        //TODO Optimize
        while (hasMoved)
        {
            hasMoved = false;
            foreach (var cell in game.Cells.Where(c=>c.Value!=0))
            {
                if (!CanMove(game, cell.Pos, direction)) continue;
                Move(game, cell.Pos, direction);
                hasMoved = true;
            }
        }

        return game;
    }

    private static void Move(GameDto game, VectorDto pos, VectorDto direction)
    {
        var newPos = pos + direction;
        game.Cells[game.Width * newPos.X + newPos.Y].Value = game.Cells[game.Width * pos.X + pos.Y].Value;
        game.Cells[game.Width * pos.X + pos.Y].Value = 0;
    }

    private static bool CanMove(GameDto game, VectorDto pos, VectorDto direction)
    {
        var newPos = pos + direction;
        return WithinBorder(newPos.X, game.Width) && WithinBorder(newPos.Y, game.Height)
                                                  && game.Cells[game.Width * newPos.X + newPos.Y].Value == 0;
    }

    private static bool WithinBorder(int newPosX, int gameWidth)
    {
        return gameWidth > newPosX && newPosX >= 0;
    }
}