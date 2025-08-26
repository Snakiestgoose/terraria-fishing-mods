using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace FishCrafting.Content.Tiles.Furniture
{
    internal class TestAquarium : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileLighted[Type] = true;
            Main.tileLavaDeath[Type] = true;

            Main.tileFrameImportant[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.Width = 2;
            TileObjectData.newTile.Height = 2;
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 16 };
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.newTile.CoordinatePadding = 2; 
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.Table | AnchorType.SolidTile | AnchorType.SolidWithTop, TileObjectData.newTile.Width, 0);

            AnimationFrameHeight = 36;

            TileObjectData.addTile(Type);

            //ModTranslation name = CreateMapEntryName();
            //name.SetDefault("Test Aquarium");
            //AddMapEntry(new Color(238, 145, 105), name);

        }

        public override void AnimateTile(ref int frame, ref int frameCounter)
		{
            frameCounter++;
            if (frameCounter % 8 == 0) //replace 10 with duration of frame in ticks
            {
                if (frameCounter < 176)
                {
                    frame++;
                    frame %= 11;
                }
                else
                {
                    frame++;
                    frame %= 17;
                    if (frame == 0)
                    {
                        frame = 4;
                        frameCounter = 0;
                    }
                }

            }
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            Tile tile = Main.tile[i, j];
            if (tile.TileFrameX == 0)
            {
                r = 1f;
                g = 0.75f;
                b = 1f;
            }
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ModContent.ItemType<Items.Placeable.Furniture.TestAquarium>());
        }
    }
}
