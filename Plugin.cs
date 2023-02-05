﻿using System;
using System.IO;
using AutoEvent.Interfaces;
using Exiled.API.Features;

namespace AutoEvent
{
    public class AutoEvent : Plugin<Config>
    {
        public override string Name => "Auto_Event";
        public override string Author => "Ported to Exiled [by KoToXleB]";
        public override Version Version => new Version(4, 0, 0);
        public static IEvent ActiveEvent = null;
        public override void OnEnabled()
        {
            if (!Config.IsEnabled) return;
            // Проверка на директорию музыки
            if (!Directory.Exists(Path.Combine(Paths.Configs, "Music"))) Directory.CreateDirectory(Path.Combine(Paths.Configs, "Music"));
        }
        public override void OnDisabled()
        {
        }
    }
}
