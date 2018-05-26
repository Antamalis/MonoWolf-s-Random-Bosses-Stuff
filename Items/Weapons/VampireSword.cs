using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MonoWolfRandomStuff.Items.Weapons {

	public class VampireSword : ModItem
	{
		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Vampire sword");
			Tooltip.SetDefault("This will satisfy your need of blood");
		}

		public override void SetDefaults(){
			item.damage = 42;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.useTurn = true;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
            int healingAmount = (int)(damage * 0.05f);
            player.statLife += healingAmount;
            player.HealEffect(healingAmount, true);
        }

    }
}
