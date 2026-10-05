using Leafbound.Content.Players;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Leafbound.Content
{
    public class LeafGlobalNPC : GlobalNPC
    {
        public override bool PreAI(NPC npc)
        {
            Player player = Main.LocalPlayer;
            LeafArmorPlayer modPlayer = player.GetModPlayer<LeafArmorPlayer>();

            if (!modPlayer.LeafCloak)
            {
                return true;
            }

            if (npc.type == NPCID.DemonEye || npc.type == NPCID.JungleBat)
            {
                npc.target = 255;
                npc.netUpdate = true;
                return false;
            }

            return true;
        }
    }
}