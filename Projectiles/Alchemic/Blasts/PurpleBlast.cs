using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Projectiles.Alchemic.Blasts {
public class PurpleBlast : ModProjectile
{
    public override void SetDefaults()
    {
              projectile.timeLeft = 420;
			projectile.width = 52;
			projectile.height = 52;
                        projectile.friendly = true;
            Main.projFrames[projectile.type] = 5;
				projectile.tileCollide = false;
				projectile.penetrate = -1;
    }

		public override Color? GetAlpha(Color lightColor)
		{
			return Color.White;
		}

        public override void ModifyHitNPC(NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            if (Main.rand.Next(1, 101) <= Main.player[projectile.owner].GetModPlayer<MPlayer>(mod).alchemistCrit)
            {
                crit = true;
            }
        }

        public override void AI()
        {													
			projectile.frameCounter++;
			if (projectile.frameCounter > 2)
			{
				projectile.frame++;
				projectile.frameCounter = 0;
			}
			if (projectile.frame >= 5)
                        {projectile.Kill();}
        }

    public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
    {
        if(Main.rand.Next(3) == 0)
        {
            target.AddBuff(70, 180, false);
        }

    }

}}