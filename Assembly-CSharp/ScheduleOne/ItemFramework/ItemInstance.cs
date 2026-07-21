using System;
using FishNet.Serializing;
using Il2CppDummyDll;
using ScheduleOne.Core.Items.Framework;
using ScheduleOne.Equipping;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x0200062B RID: 1579
	[Token(Token = "0x200062B")]
	[Serializable]
	public abstract class ItemInstance : BaseItemInstance
	{
		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x060026CC RID: 9932 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170006BD")]
		public ItemDefinition Definition
		{
			[Token(Token = "0x60026CC")]
			[Address(RVA = "0x6C4900", Offset = "0x6C3B00", VA = "0x1806C4900")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x060026CD RID: 9933 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170006BE")]
		public virtual Equippable Equippable
		{
			[Token(Token = "0x60026CD")]
			[Address(RVA = "0x6C4A60", Offset = "0x6C3C60", VA = "0x1806C4A60", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026CE")]
		[Address(RVA = "0x6C48B0", Offset = "0x6C3AB0", VA = "0x1806C48B0")]
		public ItemInstance(ItemDefinition definition, int quantity)
		{
		}

		// Token: 0x060026CF RID: 9935 RVA: 0x0000C9A8 File Offset: 0x0000ABA8
		[Token(Token = "0x60026CF")]
		[Address(RVA = "0x6C4640", Offset = "0x6C3840", VA = "0x1806C4640", Slot = "15")]
		public virtual bool CanStackWith(ItemInstance other, bool checkQuantities = true)
		{
			return default(bool);
		}

		// Token: 0x060026D0 RID: 9936
		[Token(Token = "0x60026D0")]
		public abstract ItemInstance GetCopy(int overrideQuantity = -1);

		// Token: 0x060026D1 RID: 9937 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60026D1")]
		[Address(RVA = "0x6C4770", Offset = "0x6C3970", VA = "0x1806C4770", Slot = "17")]
		public virtual ItemData GetItemData()
		{
			return null;
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026D2")]
		[Address(RVA = "0x6C4860", Offset = "0x6C3A60", VA = "0x1806C4860", Slot = "18")]
		public virtual void Write(Writer writer)
		{
		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026D3")]
		[Address(RVA = "0x6C47F0", Offset = "0x6C39F0", VA = "0x1806C47F0", Slot = "19")]
		public virtual void Read(Reader reader)
		{
		}

		// Token: 0x060026D4 RID: 9940 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60026D4")]
		[Address(RVA = "0x6C46D0", Offset = "0x6C38D0", VA = "0x1806C46D0")]
		public static ItemInstance CreateInstanceAndRead(Reader reader)
		{
			return null;
		}
	}
}
