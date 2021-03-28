﻿namespace Qurre.API.Controllers
{
    public static class Lights
    {
        public static bool IsLightsOff { get; }

        public static void Intensivity(float intensive);
        public static void Intensivity(float intensive, ZoneType zone);
        public static void TurnOff(float duration, bool onlyHeavy = false);
    }
}