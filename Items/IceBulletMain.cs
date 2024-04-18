using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace TheArsenalV2.Items
{
    public class IceBulletMain : ModProjectile, ILocalizedModType
    {
        public new string LocalizationCategory => "Projectiles.Ranged";

        public override void SetStaticDefaults()
        {
            ProjectileID.Sets.TrailCacheLength[Projectile.type] = 3;
            ProjectileID.Sets.TrailingMode[Projectile.type] = 0;
        }

        public override void SetDefaults()
        {
            Projectile.width = 1;
            Projectile.height = 2;
            Projectile.aiStyle = ProjAIStyleID.Arrow;
            AIType = ProjectileID.Bullet;
            Projectile.timeLeft = 180;
            Projectile.friendly = true;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.coldDamage = true;
            Projectile.penetrate = 1;       
            Projectile.usesLocalNPCImmunity = false;
            Projectile.localNPCHitCooldown = -1;
            Projectile.extraUpdates = 2;
            // Speed at which the projectile travels
            Projectile.velocity = new Vector2(0, 0);
            // The luminosity of the projectile
            Projectile.light = 0.5f;
        }

        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            target.AddBuff(BuffID.Slow, 180);
        }
    }
}