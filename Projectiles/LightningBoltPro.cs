using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Projectiles {
public class LightningBoltPro : ModProjectile
{
    public override void SetDefaults()
    {
			projectile.CloneDefaults(443);

			aiType = 443;
                                   projectile.magic = true;

        projectile.timeLeft = 500;
                                   Main.projFrames[projectile.type] = 4;
    }

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("LightningBoltPro");
       
    }



}}
