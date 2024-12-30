﻿using System.Collections.Generic;
using System.ComponentModel;
using AutoEvent.API;
using AutoEvent.API.Season.Enum;
using AutoEvent.Interfaces;
using PlayerRoles;
using UnityEngine;

namespace AutoEvent.Games.GunGame;
public class Config : EventConfig
{
    public Config()
    {
        if (AvailableMaps is null)
        {
            AvailableMaps = new List<MapChance>();
        }

        if (AvailableMaps.Count < 1)
        {
            AvailableMaps.Add(new MapChance(50, new MapInfo("Shipment", new Vector3(93f, 1020f, -43f) )));
            AvailableMaps.Add(new MapChance(50, new MapInfo("Shipment_Xmas2025", new Vector3(93f, 1020f, -43f)), SeasonFlags.Christmas));
            AvailableMaps.Add(new MapChance(50, new MapInfo("Shipment_Halloween2024", new Vector3(93f, 1020f, -43f)), SeasonFlags.Halloween));
        }
    }
    
    [Description("A list of guns a player can get.")]
    public List<GunRole> Guns { get; set; } = new()
    {
        new GunRole(ItemType.GunCOM15, 0),
        new GunRole(ItemType.GunCOM18, 2),
        new GunRole(ItemType.GunRevolver, 4),
        new GunRole(ItemType.GunCom45, 6),
        new GunRole(ItemType.GunFSP9, 8),
        new GunRole(ItemType.GunCrossvec, 10),
        new GunRole(ItemType.GunAK, 12),
        new GunRole(ItemType.GunShotgun, 14),
        new GunRole(ItemType.GunE11SR, 16),
        new GunRole(ItemType.GunRevolver, 18),
        new GunRole(ItemType.GunA7, 20),
        new GunRole(ItemType.ParticleDisruptor, 22),
        new GunRole(ItemType.GunAK, 24),
        new GunRole(ItemType.GunE11SR, 26),
        new GunRole(ItemType.GunLogicer, 28),
        new GunRole(ItemType.GunFRMG0, 30),
        new GunRole(ItemType.Jailbird, 32),
        new GunRole(ItemType.None, 34),
    };

    [Description("The loadouts a player can get.")]
    public List<Loadout> Loadouts { get; set; } = new()
    {
        new Loadout()
        {
            Health = 100,
            InfiniteAmmo = AmmoMode.InfiniteAmmo,
            Roles = new Dictionary<RoleTypeId, int>()
            {
                { RoleTypeId.ClassD, 20 },
                { RoleTypeId.Scientist, 20 },
                { RoleTypeId.NtfSergeant, 20 },
                { RoleTypeId.ChaosRifleman, 20 },
                { RoleTypeId.FacilityGuard, 20 },
            }
        }
    };
}

public class GunRole
{
    public GunRole() { }

    public GunRole(ItemType item, int killsRequired)
    {
        Item = item;
        KillsRequired = killsRequired;
    }

    [Description("The weapon that the player will recieve once they get to this role.")]
    public ItemType Item { get; set; } = ItemType.GunCOM15;
    
    [Description("Total kills needed to get this gun. [Default: 1]")]
    public int KillsRequired { get; set; } = 1;
}