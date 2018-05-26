using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MonoWolfRandomStuff.Items.Materials {
    public class MeteoriteChunk : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Meteorite Chunk");
            Tooltip.SetDefault("It's still hot to the touch");
        }

        public override void SetDefaults() {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 100;
            item.rare = 1;
        }
    }
}
