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
        game.IsFinished = IsFinished(game);
        return game;
    }

    private static bool IsFinished(GameDto game)
    {
        var cells = game.Cells;
        var emptyTiles = cells.Where(c => c.Value == 0).ToList();
        if (emptyTiles.Count != 0) return false;
        for(var i = 0; i<game.Width;i++)
        for(var j = 0; j<game.Height-1;j++)
            if (GetCellByPos(game, i, j).Value == GetCellByPos(game, i, j + 1).Value)
                return false;
        for(var i = 0; i<game.Width-1;i++)
        for(var j = 0; j<game.Height;j++)
            if (GetCellByPos(game, i, j).Value == GetCellByPos(game, i+1, j).Value)
                return false;
        return true;
    }

    private static CellDto GetCellByPos(GameDto game, VectorDto pos)
    {
        return game.Cells[game.Width * pos.X + pos.Y];
    }
    
    private static CellDto GetCellByPos(GameDto game, int x, int y)
    {
        return game.Cells[game.Width *x + y];
    }

    private static void Move(GameDto game, VectorDto pos, VectorDto direction)
    {
        var newPos = pos + direction;
        if(GetCellByPos(game, newPos).Value ==0)
            GetCellByPos(game, newPos).Value = GetCellByPos(game, pos).Value;
        else
        {
            GetCellByPos(game, newPos).Value = GetCellByPos(game, pos).Value*2;
            game.Score += GetCellByPos(game, newPos).Value;
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