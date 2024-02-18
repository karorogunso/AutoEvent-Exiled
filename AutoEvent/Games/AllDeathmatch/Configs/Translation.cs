﻿using AutoEvent.Interfaces;

namespace AutoEvent.Games.AllDeathmatch;
public class Translation : EventTranslation
{
    public override string Name { get; set; } = "All Deathmatch";
    public override string Description { get; set; } = "Fight against each other in all deathmatch.";
    public override string CommandName { get; set; } = "dm";
    public string Cycle { get; set; } = "<size=30><i><b>{name}</b>\n<color=red>You - {kills}/{needKills} kills</color>\nRound Time: {time}</i></size>";
    public string NoPlayers { get; set; } = "<color=red>The game is over by the admin\nYour kills {count}</color>";
    public string TimeEnd { get; set; } = "<color=red>The game is over in time\nYour kills {count}</color>";
    public string WinnerEnd { get; set; } = "<b><color=red>Winner - <color=yellow>{winner}</color></color></b>\nYour kills <color=red>{count}</color></color>\nGame Time - <color=#008000>{time}</color></i>";
}