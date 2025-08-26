using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace FishCrafting.Content.Items
{
    internal class AnglerFish : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Angler-Fish");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 3;
		}

		public override void SetDefaults()
		{
			Item.consumable = true;
			Item.useStyle = ItemUseStyleID.EatFood;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useTurn = true;
			Item.UseSound = SoundID.Item3;

			//Item.questItem = true;
			Item.maxStack = 1;
			Item.width = 26;
			Item.height = 26;
			//Item.uniqueStack = true; // Make this item only stack one time.
			Item.rare = ItemRarityID.Red; // Sets the item's rarity. This exact line uses a special rarity for quest items.
		}

        //public override bool IsQuestFish() => true; // Makes the item a quest fish

        //public override bool IsAnglerQuestAvailable() => true; // Makes the quest only appear in hard mode. Adding a '!' before Main.hardMode makes it ONLY available in pre-hardmode.

        //public override void AnglerQuestChat(ref string description, ref string catchLocation)
        //{
        //	// How the angler describes the fish to the player.
        //	description = "I've heard stories of a fish that looks just like me. Go fetch!";
        //	// What it says on the bottom of the angler's text box of how to catch the fish.
        //	catchLocation = "Caught at the ocean";
        //}

        public override bool? UseItem(Player player)
        {
			int npcId = NPC.FindFirstNPC(NPCID.Angler);

			Mod.Logger.WarnFormat("NPC For Angler found: {0}", npcId);

			Mod.Logger.WarnFormat("Angler ID: {0}", NPCID.Angler);
			// Angler ID is 369 NPCID.Angler

			NPC npc = Main.npc[npcId];
			npc.StrikeNPC(100000, 0, 0);

			

            return true;
        }
    }
}
