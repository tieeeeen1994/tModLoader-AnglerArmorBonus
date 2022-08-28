using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace AnglerArmorBonus.GlobalItems
{
    public class FishingLines : GlobalItem
    {
        private const float bobberSpread = 75f;
        private const float spreadMultiplier = .05f;

        public override bool AppliesToEntity(Item item, bool lateInstantiation) => item.fishingPole != 0;

        public override bool Shoot(Item item, Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            if (player.AnglerArmorPlayer().anglerSetBonus && AnglerArmorBonus.HasExtraFishingLines)
            {
                for (int i = 0; i < AnglerArmorBonus.ServerConfig.extraFishingLines; i++)
                {
                    Vector2 bobberSpeed = velocity + new Vector2(Main.rand.NextFloat(-bobberSpread, bobberSpread) * spreadMultiplier, Main.rand.NextFloat(-bobberSpread, bobberSpread) * spreadMultiplier);
                    Projectile.NewProjectile(source, position, bobberSpeed, type, 0, 0f, player.whoAmI, 0f, 0f);
                }
            }
            return true;
        }
    }
}
