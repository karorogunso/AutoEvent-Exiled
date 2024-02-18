﻿using AutoEvent.Interfaces;

namespace AutoEvent.Games.Lava;
public class Translation : EventTranslation
{
    public override string Name { get; set; } = "The floor is LAVA";
    public override string Description { get; set; } = "Survival, in which you need to avoid lava and shoot at others.";
    public override string CommandName { get; set; } = "lava";
    public string Start { get; set; } = "<size=100><color=red>{time}</color></size>\nTake weapons and climb up.";
    public string Cycle { get; set; } = "<size=20><color=red><b>Alive: {count} players</b></color></size>";
    public string Win { get; set; } = "<color=red><b>Winner\nPlayer - {winner}</b></color>";
    public string AllDead { get; set; } = "<color=red><b>No one survived to the end.</b></color>";
    public string Died { get; set; } = "<color=red>Burned in Lava</color>";
}