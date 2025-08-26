using Terraria;
using Terraria.ModLoader;

namespace FishCrafting.Content.Buffs
{
	public class FishyCarrot : ModBuff
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fishy Carrot");
			Description.SetDefault("Fishy");
			Main.buffNoTimeDisplay[Type] = true; // The time remaining won't display on this buff
			Main.buffNoSave[Type] = true; // This buff won't save when you exit the world
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.mount.SetMount(ModContent.MountType<Mounts.FishyCarrot>(), player);
			player.buffTime[buffIndex] = 10; // reset buff time
		}
	}
}
