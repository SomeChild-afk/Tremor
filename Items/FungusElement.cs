using Terraria.ID;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items {
public class FungusElement : ModItem
{

    public override void SetDefaults()
    {

        item.width = 14;
        item.height = 22;
        item.rare = 3;
        item.maxStack = 999;
        item.value = 100;
    }

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Fungus Element");
      Tooltip.SetDefault("");
    }

}}
