using Terraria.ID;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{ 
[AutoloadEquip(EquipType.Body)]
    public class SamuraiChestplate : ModItem
    {

        public override void SetDefaults()
        {

            item.width = 30;
            item.height = 18;

            item.value = 100000;
            item.rare = 5;
            item.defense = 14;
        }

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Samurai Fullplate");
      Tooltip.SetDefault("Increases melee speed by 25%");
    }


        public override void UpdateEquip(Player player)
        {
            player.meleeSpeed += 0.25f;
        }
    }
}
