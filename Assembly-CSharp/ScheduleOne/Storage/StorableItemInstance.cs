using System;
using FishNet.Serializing.Helping;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Storage
{
	// Token: 0x020008C7 RID: 2247
	[Token(Token = "0x20008C7")]
	[Serializable]
	public class StorableItemInstance : ItemInstance
	{
		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06003BAA RID: 15274 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000953")]
		[CodegenExclude]
		public virtual StoredItem StoredItem
		{
			[Token(Token = "0x6003BAA")]
			[Address(RVA = "0x81E2D0", Offset = "0x81D4D0", VA = "0x18081E2D0", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003BAB RID: 15275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BAB")]
		[Address(RVA = "0x81E1C0", Offset = "0x81D3C0", VA = "0x18081E1C0")]
		public StorableItemInstance(ItemDefinition definition, int quantity)
		{
		}

		// Token: 0x06003BAC RID: 15276 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003BAC")]
		[Address(RVA = "0x81DF50", Offset = "0x81D150", VA = "0x18081DF50", Slot = "16")]
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		// Token: 0x06003BAD RID: 15277 RVA: 0x00011490 File Offset: 0x0000F690
		[Token(Token = "0x6003BAD")]
		[Address(RVA = "0x81E0A0", Offset = "0x81D2A0", VA = "0x18081E0A0", Slot = "12")]
		public override float GetMonetaryValue()
		{
			return 0f;
		}
	}
}
