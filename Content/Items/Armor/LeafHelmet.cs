using Leafbound.Content.Items.Armor;
using Leafbound.Content.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Leafbound.Content.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class LeafHelmet : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 16;
            Item.defense = 1;
            Item.rare = ItemRarityID.White;
            Item.value = Item.sellPrice(silver: 1);
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == Item.type && body.type == ModContent.ItemType<LeafBreastplate>() && legs.type == ModContent.ItemType<LeafGreaves>();
        }
        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Increases movement speed by 5%";
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<Leaf>(), 40);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();

        }
    }
}