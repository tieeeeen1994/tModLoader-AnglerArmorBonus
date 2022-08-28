using AnglerArmorBonus.Configs;
using Terraria.ModLoader;

namespace AnglerArmorBonus
{
	public class AnglerArmorBonus : Mod
	{
		public static ServerConfig ServerConfig => ModContent.GetInstance<ServerConfig>();

        public static bool HasExtraFishingLines => ServerConfig.extraFishingLines > 0;

        public static bool HasDoubleCatch => ServerConfig.doubleCatchChance > 0;

        public static bool HasTripleCatch => ServerConfig.tripleCatchChance > 0;
    }
}