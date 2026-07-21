using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.NPCs;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product.Packaging;

namespace ScheduleOne.Product
{
	// Token: 0x02000946 RID: 2374
	[Token(Token = "0x2000946")]
	[Serializable]
	public class WeedInstance : ProductItemInstance
	{
		// Token: 0x06003F9C RID: 16284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F9C")]
		[Address(RVA = "0x82C480", Offset = "0x82B680", VA = "0x18082C480")]
		public WeedInstance(ItemDefinition definition, int quantity, EQuality quality, [Optional] PackagingDefinition packaging)
		{
		}

		// Token: 0x06003F9D RID: 16285 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003F9D")]
		[Address(RVA = "0x86C290", Offset = "0x86B490", VA = "0x18086C290", Slot = "16")]
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		// Token: 0x06003F9E RID: 16286 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003F9E")]
		[Address(RVA = "0x86C340", Offset = "0x86B540", VA = "0x18086C340", Slot = "17")]
		public override ItemData GetItemData()
		{
			return null;
		}

		// Token: 0x06003F9F RID: 16287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F9F")]
		[Address(RVA = "0x86BA60", Offset = "0x86AC60", VA = "0x18086BA60", Slot = "23")]
		public override void ApplyEffectsToNPC(NPC npc)
		{
		}

		// Token: 0x06003FA0 RID: 16288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FA0")]
		[Address(RVA = "0x86BF20", Offset = "0x86B120", VA = "0x18086BF20", Slot = "24")]
		public override void ClearEffectsFromNPC(NPC npc)
		{
		}

		// Token: 0x06003FA1 RID: 16289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FA1")]
		[Address(RVA = "0x86BB90", Offset = "0x86AD90", VA = "0x18086BB90", Slot = "25")]
		public override void ApplyEffectsToPlayer(Player player)
		{
		}

		// Token: 0x06003FA2 RID: 16290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FA2")]
		[Address(RVA = "0x86BFB0", Offset = "0x86B1B0", VA = "0x18086BFB0", Slot = "26")]
		public override void ClearEffectsFromPlayer(Player Player)
		{
		}
	}
}
