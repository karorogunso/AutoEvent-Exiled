﻿using AutoEvent.Interfaces;

namespace AutoEvent.Games.Knives;
public class Translation : EventTranslation
{
    public Translation()
    {
        Name = "Knives of Death";
        Description = "Knife players against each other on a 35hp map from cs 1.6";
        CommandName = "knives";
    }
    public string Cycle { get; set; } = "<color=#D71868><b><i>{name}</i></b></color>\n<color=yellow><color=blue>{mtfcount} MTF</color> <color=red>VS</color> <color=green>{chaoscount} CHAOS</color></color>";
    public string ChaosWin { get; set; } = "<color=#D71868><b><i>{name}</i></b></color>\n<color=yellow>WINNERS: <color=green>CHAOS</color></color>";
    public string MtfWin { get; set; } = "<color=#D71868><b><i>{name}</i></b></color>\n<color=yellow>WINNERS: <color=#42AAFF>MTF</color></color>";
}