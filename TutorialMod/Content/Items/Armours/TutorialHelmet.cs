using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.Localization;

namespace TutorialMod.Content.Items.Armours
{
    [AutoloadEquip(EquipType.Head)]
    internal class TutorialHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;

            //ArmorIDs.Head.Sets.DrawHead[Item.headSlot] = false; // Don't draw head
            //ArmorIDs.Head.Sets.DrawHatHair[Item.headSlot] = true; // Draw hair EX: wizard hat
            //ArmorIDs.Head.Sets.DrawFullHair[Item.headSlot] = true; // EX: mask
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

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            bool bodyMatch = body.type == ModContent.ItemType<TutorialBreastplate>();
            bool legsMatch = legs.type == ModContent.ItemType<TutorialLeggings>();

            return bodyMatch && legsMatch;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = Language.GetTextValue("Mods.TutorialMod.ItemSetBonus.TutorialSet");

            player.moveSpeed += 0.10f;

        }
    }
}
