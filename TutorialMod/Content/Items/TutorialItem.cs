using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace TutorialMod.Content.Items
{
    internal class TutorialItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tutorial Item");
            Tooltip.SetDefault("This is a Tutorial Material");
            // Set Research lvl
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100; 
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.value = Item.buyPrice(copper: 5);
            Item.maxStack = 999;
        }

    }
}
