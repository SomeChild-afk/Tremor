using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Projectiles {
public class TurtlePitchfork : ModProjectile
{
    public override void SetDefaults()
    {
			projectile.CloneDefaults(66);

			aiType = 66;
    }

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("TurtlePitchfork");
       
    }


}}
