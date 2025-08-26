using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishCrafting.Content.Items
{
    internal class CopperShortsword : GlobalItem
    {
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.CopperShortsword)
			{ 
				item.damage = 50;       
			}
		}
		
	}
}
