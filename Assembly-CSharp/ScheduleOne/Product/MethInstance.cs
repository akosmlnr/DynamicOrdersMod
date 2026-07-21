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
	// Token: 0x0200090D RID: 2317
	[Token(Token = "0x200090D")]
	[Serializable]
	public class MethInstance : ProductItemInstance
	{
		// Token: 0x06003DE1 RID: 15841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DE1")]
		[Address(RVA = "0x82C480", Offset = "0x82B680", VA = "0x18082C480")]
		public MethInstance(ItemDefinition definition, int quantity, EQuality quality, [Optional] PackagingDefinition packaging)
		{
		}

		// Token: 0x06003DE2 RID: 15842 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003DE2")]
		[Address(RVA = "0x82EBA0", Offset = "0x82DDA0", VA = "0x18082EBA0", Slot = "16")]
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		// Token: 0x06003DE3 RID: 15843 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003DE3")]
		[Address(RVA = "0x82EC50", Offset = "0x82DE50", VA = "0x18082EC50", Slot = "17")]
		public override ItemData GetItemData()
		{
			return null;
		}

		// Token: 0x06003DE4 RID: 15844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DE4")]
		[Address(RVA = "0x82E150", Offset = "0x82D350", VA = "0x18082E150", Slot = "23")]
		public override void ApplyEffectsToNPC(NPC npc)
		{
		}

		// Token: 0x06003DE5 RID: 15845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DE5")]
		[Address(RVA = "0x82E7A0", Offset = "0x82D9A0", VA = "0x18082E7A0", Slot = "24")]
		public override void ClearEffectsFromNPC(NPC npc)
		{
		}

		// Token: 0x06003DE6 RID: 15846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DE6")]
		[Address(RVA = "0x82E3A0", Offset = "0x82D5A0", VA = "0x18082E3A0", Slot = "25")]
		public override void ApplyEffectsToPlayer(Player player)
		{
		}

		// Token: 0x06003DE7 RID: 15847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DE7")]
		[Address(RVA = "0x82E8B0", Offset = "0x82DAB0", VA = "0x18082E8B0", Slot = "26")]
		public override void ClearEffectsFromPlayer(Player Player)
		{
		}
	}
}
