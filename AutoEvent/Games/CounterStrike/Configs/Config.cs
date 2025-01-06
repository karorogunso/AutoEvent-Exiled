﻿using System.Collections.Generic;
using System.ComponentModel;
using AutoEvent.API;
using AutoEvent.Interfaces;
using Exiled.API.Enums;
using Exiled.API.Features;
using PlayerRoles;

namespace AutoEvent.Games.CounterStrike;
public class Config : EventConfig
{
    [Description("After how many seconds the round will end. [Default: 105]")]
    public int TotalTimeInSeconds { get; set; } = 105;
    
    [Description("A list of loadouts for team NTF")]
    public List<Loadout> NTFLoadouts = new()
    {
        new Loadout()
        {
            Roles = new Dictionary<RoleTypeId, int>(){ { RoleTypeId.NtfSpecialist, 100 } },
            Items = new List<ItemType>() { ItemType.GunE11SR, ItemType.GrenadeHE, ItemType.GrenadeFlash, ItemType.Radio, ItemType.ArmorCombat },
            Effects = new List<Effect>()
            {
                new Effect(EffectType.FogControl, 0, 3)
            },
            InfiniteAmmo = AmmoMode.InfiniteAmmo
        }
    };

    [Description("A list of loadouts for team Chaos Insurgency")]
    public List<Loadout> ChaosLoadouts = new()
    {
        new Loadout()
        {
            Roles = new Dictionary<RoleTypeId, int>(){ { RoleTypeId.ChaosRifleman, 100 } },
            Items = new List<ItemType>() { ItemType.GunAK, ItemType.GrenadeHE, ItemType.GrenadeFlash, ItemType.Radio, ItemType.ArmorCombat },
            Effects = new List<Effect>()
            {
                new Effect(EffectType.FogControl, 0, 3)
            },
            InfiniteAmmo = AmmoMode.InfiniteAmmo
        }
    };
}