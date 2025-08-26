using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using TutorialMod.Content.Projectiles.Weapons;

namespace TutorialMod.Content.Items.Weapons
{
    internal class TutorialShortsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tutorial Shortsword");
            Tooltip.SetDefault("This is a modded shortsword");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {

            Item.width = 32;
            Item.height = 32;

            // Use and Animation Style
            Item.useStyle = ItemUseStyleID.Rapier;
            Item.useTime = 12;
            Item.useAnimation = 12;

            // Dmg Values
            Item.DamageType = DamageClass.Melee;
            Item.damage = 17;
            Item.knockBack = 4f;

            // Misc
            Item.value = Item.buyPrice(silver: 20);
            Item.rare = ItemRarityID.Blue;

            // Sound
            Item.UseSound = SoundID.Item1;

            Item.noUseGraphic = true;
            Item.noMelee = true;

            Item.shootSpeed = 2.1f;
            Item.shoot = ModContent.ProjectileType<TutorialShortswordProjectile>();
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<TutorialItem>(), 8)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
