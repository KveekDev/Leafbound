using Leafbound.Content.Items.Armor;
using Terraria;
using Terraria.ModLoader;

namespace Leafbound.Content.Players
{
    public class LeafArmorPlayer : ModPlayer
    {
        public override void UpdateEquips()
        {
            bool hasHelmet = Player.armor[0].type == ModContent.ItemType<LeafHelmet>();
            bool hasBreastplate = Player.armor[1].type == ModContent.ItemType<LeafBreastplate>();
            bool hasGreaves = Player.armor[2].type == ModContent.ItemType<LeafGreaves>();
            if (hasHelmet && hasBreastplate && hasGreaves)
            {
                Player.moveSpeed += 0.05f;
            }
            LeafCloak = hasHelmet && hasBreastplate && hasGreaves && Player.velocity == Microsoft.Xna.Framework.Vector2.Zero;
        }
        public bool LeafCloak { get; set; }
        
    }
}