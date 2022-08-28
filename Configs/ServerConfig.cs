using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace AnglerArmorBonus.Configs
{
    public class ServerConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Label("Extra Fishing Lines")]
        [Tooltip("Determines the number of extra fishing lines for the Angler Armor Set Bonus.")]
        [DefaultValue(2)]
        [Range(0, 99)]
        [Increment(1)]
        public int extraFishingLines;

        [Label("Double Catch Chance")]
        [Tooltip("Determines the chance to get double the amount of the usual catch per fishing line.")]
        [DefaultValue(20)]
        [Range(0, 100)]
        [Increment(1)]
        public int doubleCatchChance;

        [Label("Triple Catch Chance")]
        [Tooltip("Determines the chance to get triple the amount of the usual catch per fishing line.\nThis check will only proceed if Double Catch Chance is successful.")]
        [DefaultValue(10)]
        [Range(0, 100)]
        [Increment(1)]
        public int tripleCatchChance;
    }
}
