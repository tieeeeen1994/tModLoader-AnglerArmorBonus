using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AnglerArmorBonus.GlobalItems
{
    public class AnglerArmorSetBonus : GlobalItem
    {
        public override bool AppliesToEntity(Item item, bool lateInstantiation)
        {
            return item.type == ItemID.AnglerHat ||
                   item.type == ItemID.AnglerVest ||
                   item.type == ItemID.AnglerPants;
        }

        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            string armorSet = "";
            if (head.type == ItemID.AnglerHat && body.type == ItemID.AnglerVest && legs.type == ItemID.AnglerPants)
            {
                armorSet = "Angler Fishing Set";
            }
            return armorSet;
        }

        public override void UpdateArmorSet(Player player, string set)
        {
            SetBonusDescription(ref player.setBonus);
            player.AnglerArmorPlayer().anglerSetBonus = true;
        }

        private void SetBonusDescription(ref string description)
        {
            description = "";
            if (AnglerArmorBonus.HasExtraFishingLines)
            {
                description += $"Adds {AnglerArmorBonus.ServerConfig.extraFishingLines} extra fishing " +
                               $"{"line".Pluralize(AnglerArmorBonus.ServerConfig.extraFishingLines)}.";
            }
            if (AnglerArmorBonus.HasExtraFishingLines && AnglerArmorBonus.HasDoubleCatch) description += "\n";
            if (AnglerArmorBonus.HasDoubleCatch)
            {
                description += "Has a chance to double ";
                if (AnglerArmorBonus.HasTripleCatch) description += "or triple ";
                description += "your catch!";
            }
        }
    }
}
