using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Projectiles {
public class GrassGlaviePro : ModProjectile
{
    public override void SetDefaults()
    {
			projectile.CloneDefaults(66);

			aiType = 66;
                        projectile.tileCollide = false;
    }

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("GrassGlaviePro");
       
    }


    public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
    {
        if(Main.rand.Next(2) == 0)
        {
            target.AddBuff(20, 180, false);
        }

    }

    public override void AI()
    {
        if(Main.rand.Next(3) == 0)
        {
            Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 44, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
        }
    }
}}
