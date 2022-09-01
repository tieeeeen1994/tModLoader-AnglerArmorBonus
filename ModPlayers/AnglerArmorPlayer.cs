using System;
using Terraria;
using Terraria.ModLoader;
using static AnglerArmorBonus.Util;

namespace AnglerArmorBonus.ModPlayers
{
    public class AnglerArmorPlayer : ModPlayer
    {
        public bool anglerSetBonus = false;

        public override void ResetEffects() => anglerSetBonus = false;

        public override void ModifyCaughtFish(Item fish)
        {
            if (AnglerArmorBonus.HasDoubleCatch && anglerSetBonus && Proc(AnglerArmorBonus.ServerConfig.doubleCatchChance))
            {
                if (AnglerArmorBonus.HasTripleCatch && Proc(AnglerArmorBonus.ServerConfig.tripleCatchChance)) fish.stack *= 3;
                else fish.stack *= 2;

                if (AnglerArmorBonus.ServerConfig.maxStackLimit && fish.stack > fish.maxStack) fish.stack = fish.maxStack;
            }
        }
    }
}
