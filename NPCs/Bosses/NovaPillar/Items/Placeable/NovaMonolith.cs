using Terraria;
using Terraria.ModLoader;
using Tremor.NPCs.Bosses.NovaPillar.Tiles;

namespace Tremor.NPCs.Bosses.NovaPillar.Items.Placeable
{
	public class NovaMonolith : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 32;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.rare = 10;
			item.value = Item.buyPrice(0, 10, 0, 0);
			item.createTile = mod.TileType<NovaMonolithTile>();
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nova Monolith");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "NovaFragment", 15);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}