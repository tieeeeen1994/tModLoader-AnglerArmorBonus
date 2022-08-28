using AnglerArmorBonus.ModPlayers;
using Terraria;

namespace AnglerArmorBonus
{
    public static class Util
    {
        public static string Pluralize(this string word, int count)
        {
            if (count != 1) word += "s";
            return word;
        }

        public static AnglerArmorPlayer AnglerArmorPlayer(this Player player)
        {
            return player.GetModPlayer<AnglerArmorPlayer>();
        }

        public static bool Proc(int chance)
        {
            int rolledValue = Main.rand.Next(100);
            return rolledValue < chance;
        }
    }
}
