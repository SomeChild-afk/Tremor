using Terraria.ID;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items { [AutoloadEquip(EquipType.Legs)]
public class ArcherGreaves : ModItem
{


    public override void SetDefaults()
    {

        item.width = 22;
        item.height = 18;
        item.value = 1000;
        item.rare = 2;
        item.vanity = true;
    }

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Archer Greaves");
      Tooltip.SetDefault("");
    }

}}
