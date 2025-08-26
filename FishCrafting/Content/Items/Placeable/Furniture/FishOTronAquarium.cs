using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace FishCrafting.Content.Items.Placeable.Furniture
{
    internal class FishOTronAquarium : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fish-O-Tron Aquarium");
            Tooltip.SetDefault("This is a modded Aquarium.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.maxStack = 9999;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.Furniture.FishOTronAquarium>();
            Item.width = 36;
            Item.height = 36;
            Item.value = 500;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Fishotron, 1)
                .AddIngredient(ItemID.BottledWater, 1)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}
