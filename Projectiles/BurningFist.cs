using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class BurningFist : ModProjectile
	{
				 public override void SetDefaults()
    {

			projectile.CloneDefaults(668);	
			projectile.width = 28;
			projectile.height = 38;		
			aiType = 668;
            projectile.timeLeft = 400;
			projectile.penetrate = 1;
			projectile.friendly = true;
    }

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Burning Fist");
       
    }
	
        public override void Kill(int timeLeft)
        {
            Player player = Main.player[projectile.owner];			
                if (projectile.owner == Main.myPlayer)
                {
                    int num220 = Main.rand.Next(3, 6);
                    for (int num221 = 0; num221 < num220; num221++)
                    {
                        Vector2 value17 = new Vector2((float)Main.rand.Next(-100, 101), (float)Main.rand.Next(-100, 101));
                        value17.Normalize();
                        value17 *= (float)Main.rand.Next(10, 201) * 0.01f;
                        Projectile.NewProjectile(projectile.position.X, projectile.position.Y, value17.X, value17.Y, 15, projectile.damage, 1f, projectile.owner, 0f, (float)Main.rand.Next(-45, 1));
                    }
                }
				
			   Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 62);
   projectile.position.X = projectile.position.X + (float)(projectile.width / 2);
   projectile.position.Y = projectile.position.Y + (float)(projectile.height / 2);
   projectile.width = 80;
   projectile.height = 80;
   projectile.position.X = projectile.position.X - (float)(projectile.width / 2);
   projectile.position.Y = projectile.position.Y - (float)(projectile.height / 2);
   for (int num628 = 0; num628 < 40; num628++)
   {
    int num629 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 31, 0f, 0f, 100, default(Color), 2f);
    Main.dust[num629].velocity *= 3f;
    if (Main.rand.Next(2) == 0)
    {
     Main.dust[num629].scale = 0.5f;
     Main.dust[num629].fadeIn = 1f + (float)Main.rand.Next(10) * 0.1f;
    }
   }
   for (int num630 = 0; num630 < 70; num630++)
   {
    int num631 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 6, 0f, 0f, 100, default(Color), 3f);
    Main.dust[num631].noGravity = true;
    Main.dust[num631].velocity *= 5f;
    num631 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 6, 0f, 0f, 100, default(Color), 2f);
    Main.dust[num631].velocity *= 2f;
   }
   for (int num632 = 0; num632 < 3; num632++)
   {
    float scaleFactor10 = 0.33f;
    if (num632 == 1)
    {
     scaleFactor10 = 0.66f;
    }
    if (num632 == 2)
    {
     scaleFactor10 = 1f;
    }
    int num633 = Gore.NewGore(new Vector2(projectile.position.X + (float)(projectile.width / 2) - 24f, projectile.position.Y + (float)(projectile.height / 2) - 24f), default(Vector2), Main.rand.Next(61, 64), 1f);
    Main.gore[num633].velocity *= scaleFactor10;
    Gore expr_13E6D_cp_0 = Main.gore[num633];
    expr_13E6D_cp_0.velocity.X = expr_13E6D_cp_0.velocity.X + 1f;
    Gore expr_13E8D_cp_0 = Main.gore[num633];
    expr_13E8D_cp_0.velocity.Y = expr_13E8D_cp_0.velocity.Y + 1f;
    num633 = Gore.NewGore(new Vector2(projectile.position.X + (float)(projectile.width / 2) - 24f, projectile.position.Y + (float)(projectile.height / 2) - 24f), default(Vector2), Main.rand.Next(61, 64), 2f);
    Main.gore[num633].velocity *= scaleFactor10;
    Gore expr_13F30_cp_0 = Main.gore[num633];
    expr_13F30_cp_0.velocity.X = expr_13F30_cp_0.velocity.X - 1f;
    Gore expr_13F50_cp_0 = Main.gore[num633];
    expr_13F50_cp_0.velocity.Y = expr_13F50_cp_0.velocity.Y + 1f;
    num633 = Gore.NewGore(new Vector2(projectile.position.X + (float)(projectile.width / 2) - 24f, projectile.position.Y + (float)(projectile.height / 2) - 24f), default(Vector2), Main.rand.Next(61, 64), 1f);
    Main.gore[num633].velocity *= scaleFactor10;
    Gore expr_13FF3_cp_0 = Main.gore[num633];
    expr_13FF3_cp_0.velocity.X = expr_13FF3_cp_0.velocity.X + 1f;
    Gore expr_14013_cp_0 = Main.gore[num633];
    expr_14013_cp_0.velocity.Y = expr_14013_cp_0.velocity.Y - 1f;
    num633 = Gore.NewGore(new Vector2(projectile.position.X + (float)(projectile.width / 2) - 24f, projectile.position.Y + (float)(projectile.height / 2) - 24f), default(Vector2), Main.rand.Next(61, 64), 1f);
    Main.gore[num633].velocity *= scaleFactor10;
    Gore expr_140B6_cp_0 = Main.gore[num633];
    expr_140B6_cp_0.velocity.X = expr_140B6_cp_0.velocity.X - 1f;
    Gore expr_140D6_cp_0 = Main.gore[num633];
    expr_140D6_cp_0.velocity.Y = expr_140D6_cp_0.velocity.Y - 1f;
   }
   projectile.position.X = projectile.position.X + (float)(projectile.width / 2);
   projectile.position.Y = projectile.position.Y + (float)(projectile.height / 2);
   projectile.width = 10;
   projectile.height = 10;
   projectile.position.X = projectile.position.X - (float)(projectile.width / 2);
   projectile.position.Y = projectile.position.Y - (float)(projectile.height / 2);	

		}


      public override bool CanHitPlayer(Player target)
        {
            return false;
        }

        public override bool? CanHitNPC(NPC target)
        {
            return (target.friendly) ? false : true;
        }

    

}
}
