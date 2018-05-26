using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MonoWolfRandomStuff.Projectiles {
    class MeteorSwordProjectile : ModProjectile {

        public override void SetDefaults() {
            projectile.CloneDefaults(ProjectileID.Meteor3);
            projectile.tileCollide = true;
            aiType = ProjectileID.Starfury;
        }

        public override bool PreKill(int timeLeft) {
            projectile.type = ProjectileID.Meteor3;
            return true;
        }
    }
}
