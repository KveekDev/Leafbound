using Leafbound.Content.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Leafbound.Content.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class LeafBreastplate : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 20;
            Item.defense = 1;
            Item.rare = ItemRarityID.White;
            Item.value = Item.sellPrice(silver: 3);
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<Leaf>(), 80);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();

        }
    }
}
