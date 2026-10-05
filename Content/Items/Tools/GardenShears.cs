using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Leafbound.Content.Items.Materials;
using Terraria.Audio;
using Microsoft.Xna.Framework;
namespace Leafbound.Content.Items.Tools
{
    public class GardenShears : ModItem
    {
        public override void SetDefaults()
        {
        Item.width = 20;
        Item.height = 20;
        Item.useTime = 20;
        Item.useAnimation = 20;
        Item.useStyle = ItemUseStyleID.Swing;
        Item.autoReuse = true;
        Item.useTurn = true;
        Item.rare = ItemRarityID.White;
        Item.value = Item.sellPrice(silver: 2);
        Item.axe = 5;
        Item.tileBoost = 0;
        }

        public override void SetStaticDefaults()
        {
            
        }

        public override bool? UseItem(Player player)
        {
            int i = Player.tileTargetX;
            int j = Player.tileTargetY;
            Tile targetTile = Main.tile[i,j];

            if (targetTile.HasTile && targetTile.TileType == TileID.Trees)
            {
                Vector2 pos = new Vector2(i * 16, j * 16);
                SoundEngine.PlaySound(SoundID.Dig,pos);
                for (int d = 0; d < 5; d++ )
                {
                    Dust.NewDust(pos,16,16,DustID.WoodFurniture);
                }

                if (Main.rand.Next(100)<30)
                {
                    SoundEngine.PlaySound(SoundID.Grass,pos);
                    for (int d = 0; d < 10; d++)
                    {
                        Dust.NewDust(pos,16,16,DustID.Grass);
                    }

                    Item.NewItem(new EntitySource_ItemUse(player, Item), i * 16, j * 16, 16, 16, ModContent.ItemType<Leaf>());
                }
                return true;
            }
            return base.UseItem(player);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddRecipeGroup(RecipeGroupID.IronBar, 5);
            recipe.AddIngredient(ItemID.Wood, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }    
}