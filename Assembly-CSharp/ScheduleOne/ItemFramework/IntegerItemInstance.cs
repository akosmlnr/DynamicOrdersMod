using System;
using FishNet.Serializing;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000627 RID: 1575
	[Token(Token = "0x2000627")]
	public class IntegerItemInstance : StorableItemInstance
	{
		// Token: 0x060026C1 RID: 9921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026C1")]
		[Address(RVA = "0x6C0DE0", Offset = "0x6BFFE0", VA = "0x1806C0DE0")]
		public IntegerItemInstance(ItemDefinition definition, int quantity, int value)
		{
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60026C2")]
		[Address(RVA = "0x6C0BA0", Offset = "0x6BFDA0", VA = "0x1806C0BA0", Slot = "16")]
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026C3")]
		[Address(RVA = "0x6C0B90", Offset = "0x6BFD90", VA = "0x1806C0B90")]
		public void ChangeValue(int change)
		{
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026C4")]
		[Address(RVA = "0x6C0D70", Offset = "0x6BFF70", VA = "0x1806C0D70")]
		public void SetValue(int value)
		{
		}

		// Token: 0x060026C5 RID: 9925 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60026C5")]
		[Address(RVA = "0x6C0C30", Offset = "0x6BFE30", VA = "0x1806C0C30", Slot = "17")]
		public override ItemData GetItemData()
		{
			return null;
		}

		// Token: 0x060026C6 RID: 9926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026C6")]
		[Address(RVA = "0x6C0D80", Offset = "0x6BFF80", VA = "0x1806C0D80", Slot = "18")]
		public override void Write(Writer writer)
		{
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026C7")]
		[Address(RVA = "0x6C0CC0", Offset = "0x6BFEC0", VA = "0x1806C0CC0", Slot = "19")]
		public override void Read(Reader reader)
		{
		}

		// Token: 0x04001E47 RID: 7751
		[Token(Token = "0x4001E47")]
		[FieldOffset(Offset = "0x30")]
		public int Value;
	}
}
