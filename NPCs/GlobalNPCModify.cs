using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MonoWolfRandomStuff.NPCs {
    class GlobalNPCModify : GlobalNPC {
        public override void NPCLoot(NPC npc) {
            if(npc.type == NPCID.MeteorHead) {
                if(Main.rand.Next(10) == 7) {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.height, npc.width, mod.ItemType("MeteoriteChunk"), Main.rand.Next(1, 3));
                }
            }
        }

    }
}
