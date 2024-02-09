﻿using AutoEvent.Interfaces;

namespace AutoEvent.Games.Light;
public class Translation : EventTranslation
{
    public override string Name { get; set; } = "Red Light Green Light";
    public override string Description { get; set; } = "Reach the end of the finish line";
    public override string CommandName { get; set; } = "light";
    public string Start { get; set; } = "<color=#42aaff>Get ready to run</color>\nThe game start in: <color=red>{time}</color>";
    public string Cycle { get; set; } = "<b><color=#42aaff>{name}</color></b>\n<color=#aad9ff>{state}</color>\n<color=red>{time} seconds remaining</color>";
    public string AllDied { get; set; } = "<b><color=#42aaff>{name}</color></b>\n<color=red>No one was able to reach the finish line</color>";
    public string MoreWin { get; set; } = "<b><color=#42aaff>{name}</color></b>\n<color=red>{count} players win</color>";
    public string PlayerWin { get; set; } = "<b><color=#42aaff>{name}</color></b>\n<color=green>Winner: {winner}</color>";
    public string RedLight { get; set; } = "<color=red>Dont move</color>";
    public string GreenLight { get; set; } = "<color=green>Run</color>";
    public string RedLose { get; set; } = "<color=red>You run a red light</color>";
    public string NoTime { get; set; } = "<color=red>You didnt make it to the finish line!</color>";
    public string Hint { get; set; } = "<color=green>Press <color=yellow>[Alt]</color> to push the player</color>";
    public string HintWait { get; set; } = "<color=red>Wait few seconds</color>";
    public string HintReady { get; set; } = "<color=green>Ready</color>";
}