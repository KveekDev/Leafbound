using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Leafbound.Content.Items.Materials
{
    public class Leaf : ModItem
    {
        public override void SetDefaults()
        {
        Item.width = 16;
        Item.height = 16;
        Item.maxStack = 9999;
        Item.value = Item.sellPrice(copper: 1);
        Item.rare = ItemRarityID.White;
        }
    }
}