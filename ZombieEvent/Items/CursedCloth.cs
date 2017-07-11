using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.ZombieEvent.Items {
public class CursedCloth : ModItem
{
    public override void SetDefaults()
    {

        item.width = 16;
        item.height = 16;
        item.maxStack = 99;
        item.rare = 4;
    }

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Cursed Cloth");
      Tooltip.SetDefault("");
    }


}}
