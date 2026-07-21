using System;
using FishNet.Serializing;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x0200063A RID: 1594
	[Token(Token = "0x200063A")]
	[Serializable]
	public class QualityItemInstance : StorableItemInstance
	{
		// Token: 0x06002747 RID: 10055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002747")]
		[Address(RVA = "0x6CC4E0", Offset = "0x6CB6E0", VA = "0x1806CC4E0")]
		public QualityItemInstance(ItemDefinition definition, int quantity, EQuality quality)
		{
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x0000CBB8 File Offset: 0x0000ADB8
		[Token(Token = "0x6002748")]
		[Address(RVA = "0x6CC270", Offset = "0x6CB470", VA = "0x1806CC270", Slot = "15")]
		public override bool CanStackWith(ItemInstance other, bool checkQuantities = true)
		{
			return default(bool);
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002749")]
		[Address(RVA = "0x6CC390", Offset = "0x6CB590", VA = "0x1806CC390", Slot = "16")]
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600274A")]
		[Address(RVA = "0x6CC420", Offset = "0x6CB620", VA = "0x1806CC420", Slot = "17")]
		public override ItemData GetItemData()
		{
			return null;
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600274B")]
		[Address(RVA = "0x6C0D70", Offset = "0x6BFF70", VA = "0x1806C0D70")]
		public void SetQuality(EQuality quality)
		{
		}

		// Token: 0x0600274C RID: 10060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600274C")]
		[Address(RVA = "0x6C0D80", Offset = "0x6BFF80", VA = "0x1806C0D80", Slot = "18")]
		public override void Write(Writer writer)
		{
		}

		// Token: 0x0600274D RID: 10061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600274D")]
		[Address(RVA = "0x6C0CC0", Offset = "0x6BFEC0", VA = "0x1806C0CC0", Slot = "19")]
		public override void Read(Reader reader)
		{
		}

		// Token: 0x04001E90 RID: 7824
		[Token(Token = "0x4001E90")]
		[FieldOffset(Offset = "0x30")]
		public EQuality Quality;
	}
}
