using Leafbound.Content.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Leafbound.Content.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class LeafGreaves : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 18;
            Item.defense = 1;
            Item.rare = ItemRarityID.White;
            Item.value = Item.sellPrice(silver: 2);
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<Leaf>(), 60);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();

        }
    }
}