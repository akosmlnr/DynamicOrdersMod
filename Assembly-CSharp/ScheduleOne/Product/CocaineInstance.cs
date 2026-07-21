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
	// Token: 0x02000902 RID: 2306
	[Token(Token = "0x2000902")]
	[Serializable]
	public class CocaineInstance : ProductItemInstance
	{
		// Token: 0x06003DBA RID: 15802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DBA")]
		[Address(RVA = "0x82C480", Offset = "0x82B680", VA = "0x18082C480")]
		public CocaineInstance(ItemDefinition definition, int quantity, EQuality quality, [Optional] PackagingDefinition packaging)
		{
		}

		// Token: 0x06003DBB RID: 15803 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003DBB")]
		[Address(RVA = "0x82C2F0", Offset = "0x82B4F0", VA = "0x18082C2F0", Slot = "16")]
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		// Token: 0x06003DBC RID: 15804 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003DBC")]
		[Address(RVA = "0x82C3A0", Offset = "0x82B5A0", VA = "0x18082C3A0", Slot = "17")]
		public override ItemData GetItemData()
		{
			return null;
		}

		// Token: 0x06003DBD RID: 15805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DBD")]
		[Address(RVA = "0x82B750", Offset = "0x82A950", VA = "0x18082B750", Slot = "23")]
		public override void ApplyEffectsToNPC(NPC npc)
		{
		}

		// Token: 0x06003DBE RID: 15806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DBE")]
		[Address(RVA = "0x82BDF0", Offset = "0x82AFF0", VA = "0x18082BDF0", Slot = "24")]
		public override void ClearEffectsFromNPC(NPC npc)
		{
		}

		// Token: 0x06003DBF RID: 15807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DBF")]
		[Address(RVA = "0x82BA50", Offset = "0x82AC50", VA = "0x18082BA50", Slot = "25")]
		public override void ApplyEffectsToPlayer(Player player)
		{
		}

		// Token: 0x06003DC0 RID: 15808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DC0")]
		[Address(RVA = "0x82BFF0", Offset = "0x82B1F0", VA = "0x18082BFF0", Slot = "26")]
		public override void ClearEffectsFromPlayer(Player Player)
		{
		}

		// Token: 0x04002D39 RID: 11577
		[Token(Token = "0x4002D39")]
		private const float WorkSpeedMultiplier = 1.2f;
	}
}
