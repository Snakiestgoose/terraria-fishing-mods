using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace TutorialMod.Content.Items.Armours
{
    [AutoloadEquip(EquipType.Body)]
    internal class TutorialBreastplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            // For the texture, one is image, other is actually what's used for player. Top half is male, bottom female

            Item.width = 18;
            Item.height = 18;

            Item.value = Item.buyPrice(gold: 1);
            Item.rare = ItemRarityID.Blue;

            Item.defense = 6;
        }

        public override void UpdateEquip(Player player)
        {
            // Give Buff Immunity  
            player.buffImmune[BuffID.Frozen] = true;

            // Increase Health or Mana
            player.statLifeMax2 += 20;
            player.statManaMax2 += 20;

            // Inc Max Minions
            player.maxMinions += 2;

            // Inc Speed
            player.moveSpeed += 0.07f;

        }
    }
}
