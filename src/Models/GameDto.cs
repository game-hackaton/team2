using System;
using thegame.Services;

namespace thegame.Models;

public class GameDto
{
    public GameDto(CellDto[] cells, bool monitorKeyboard, bool monitorMouseClicks, int width, int height, Guid id, bool isFinished, int score)
    {
        Cells = cells;
        MonitorKeyboard = monitorKeyboard;
        MonitorMouseClicks = monitorMouseClicks;
        Width = width;
        Height = height;
        Id = id;
        IsFinished = isFinished;
        Score = score;
    }

    public GameDto(int width = 4, int height = 4)
    {
        Cells = GamefieldCreator.Create(width, height);
        Width = width;
        Height = height;
        MonitorKeyboard = true;
        MonitorMouseClicks = true;
        Id = new Guid();
        IsFinished = false;
        Score = 0;
    }

    public CellDto[] Cells { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public bool MonitorKeyboard { get; set; }
    public bool MonitorMouseClicks { get; set; }
    public Guid Id { get; set; }
    public bool IsFinished { get; set; }
    public int Score { get; set; }
}