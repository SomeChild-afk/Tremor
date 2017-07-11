using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{ 
[AutoloadEquip(EquipType.Body)]
	public class CursedKnightBreastplate : ModItem
	{

		public override void SetDefaults()
		{

			item.width = 18;
			item.height = 18;
			item.value = 30000;

			item.rare = 9;
		}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Cursed Knight Breastplate");
      Tooltip.SetDefault("'Great for impersonating devs!'");
    }

	}
}
