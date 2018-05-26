using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MonoWolfRandomStuff.Items.Weapons {
    public class MeteoriteSword : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Meteorite sword");
            Tooltip.SetDefault("It's raining meteorites!");
        }

        public override void SetDefaults() {
            item.damage = 13;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 35;
            item.useAnimation = 35;
            item.useStyle = 1;
            item.knockBack = 4;
            item.value = 5000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
            item.shoot = 9;
            item.shootSpeed = 20;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MeteoriteBar, 12);
            recipe.AddIngredient(mod, "MeteoriteChunk", 6);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack) {
            type = mod.ProjectileType("MeteorSwordProjectile");
            damage = (int)(item.damage * 1.2f);
            return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
        }
    }
}
