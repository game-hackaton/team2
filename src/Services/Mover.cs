using System;
using System.Collections.Generic;
using System.Linq;
using thegame.Models;

namespace thegame.Services;

public class Mover
{
    public static GameDto Move(GameDto game, VectorDto direction)
    {
        var hasMoved = false;
        var hasMovedLastCheck = true;
        //TODO Optimize
        while (hasMovedLastCheck)
        {
            hasMovedLastCheck = false;
            foreach (var cell in game.Cells.Where(c=>c.Value!=0))
            {
                if (!CanMove(game, cell.Pos, direction)) continue;
                Move(game, cell.Pos, direction);
                hasMovedLastCheck = true;
                hasMoved = true;
            }
        }

        if(hasMoved)
            RandomFiller.Fill(game.Cells);
        return game;
    }

    private static void Move(GameDto game, VectorDto pos, VectorDto direction)
    {
        var newPos = pos + direction;
        if(game.Cells[game.Width * newPos.X + newPos.Y].Value ==0)
            game.Cells[game.Width * newPos.X + newPos.Y].Value = game.Cells[game.Width * pos.X + pos.Y].Value;
        else
        {
            game.Cells[game.Width * newPos.X + newPos.Y].Value = game.Cells[game.Width * pos.X + pos.Y].Value*2;
            game.Score += game.Cells[game.Width * newPos.X + newPos.Y].Value;
        }
            
        game.Cells[game.Width * pos.X + pos.Y].Value = 0;
    }

    private static bool CanMove(GameDto game, VectorDto pos, VectorDto direction)
    {
        var newPos = pos + direction;
        var value = game.Cells[game.Width * pos.X + pos.Y].Value;
        if (!(WithinBorder(newPos.X, game.Width)
              && WithinBorder(newPos.Y, game.Height))) return false;
        var otherValue = game.Cells[game.Width * newPos.X + newPos.Y].Value;
        return  otherValue== 0 || otherValue == value;
    }

    private static bool WithinBorder(int newPosX, int gameWidth)
    {
        return gameWidth > newPosX && newPosX >= 0;
    }
}