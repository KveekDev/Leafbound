using Leafbound.Content.Items.Tools;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Leafbound.Content
{
    public class LeafGlobalTile : GlobalTile
    {
        public override void KillTile(int i, int j, int type, ref bool fail, ref bool effectOnly, ref bool noItem)
        {
            if (type  != TileID.Trees)
            {
                return;
            }

            Player player = Main.LocalPlayer;
            if (player.HeldItem.type != ModContent.ItemType<GardenShears>())
            {
                return;
            }

            fail = true;
        }
    }
}