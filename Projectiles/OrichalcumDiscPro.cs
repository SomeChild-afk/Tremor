using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Projectiles {
public class OrichalcumDiscPro : ModProjectile
{
    public override void SetDefaults()
    {
			projectile.CloneDefaults(106);

			aiType = 106;
    }

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("OrichalcumDiscPro");
       
    }


}}
