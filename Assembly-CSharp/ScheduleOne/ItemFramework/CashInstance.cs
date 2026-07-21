using System;
using System.Runtime.CompilerServices;
using FishNet.Serializing;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000643 RID: 1603
	[Token(Token = "0x2000643")]
	[Serializable]
	public class CashInstance : StorableItemInstance
	{
		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06002774 RID: 10100 RVA: 0x0000CC60 File Offset: 0x0000AE60
		// (set) Token: 0x06002775 RID: 10101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006DC")]
		public float Balance
		{
			[Token(Token = "0x6002774")]
			[Address(RVA = "0x495790", Offset = "0x494990", VA = "0x180495790")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002775")]
			[Address(RVA = "0x49B870", Offset = "0x49AA70", VA = "0x18049B870")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06002776 RID: 10102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002776")]
		[Address(RVA = "0x6B9CD0", Offset = "0x6B8ED0", VA = "0x1806B9CD0")]
		public CashInstance(ItemDefinition definition, int quantity)
		{
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002777")]
		[Address(RVA = "0x6B9A90", Offset = "0x6B8C90", VA = "0x1806B9A90", Slot = "16")]
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		// Token: 0x06002778 RID: 10104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002778")]
		[Address(RVA = "0x6B9A40", Offset = "0x6B8C40", VA = "0x1806B9A40")]
		public void ChangeBalance(float amount)
		{
		}

		// Token: 0x06002779 RID: 10105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002779")]
		[Address(RVA = "0x6B9C20", Offset = "0x6B8E20", VA = "0x1806B9C20")]
		public void SetBalance(float newBalance, bool blockClear = false)
		{
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600277A")]
		[Address(RVA = "0x6B9B10", Offset = "0x6B8D10", VA = "0x1806B9B10", Slot = "17")]
		public override ItemData GetItemData()
		{
			return null;
		}

		// Token: 0x0600277B RID: 10107 RVA: 0x0000CC78 File Offset: 0x0000AE78
		[Token(Token = "0x600277B")]
		[Address(RVA = "0x495790", Offset = "0x494990", VA = "0x180495790", Slot = "12")]
		public override float GetMonetaryValue()
		{
			return 0f;
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600277C")]
		[Address(RVA = "0x6B9C70", Offset = "0x6B8E70", VA = "0x1806B9C70", Slot = "18")]
		public override void Write(Writer writer)
		{
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600277D")]
		[Address(RVA = "0x6B9BA0", Offset = "0x6B8DA0", VA = "0x1806B9BA0", Slot = "19")]
		public override void Read(Reader reader)
		{
		}

		// Token: 0x04001EA9 RID: 7849
		[Token(Token = "0x4001EA9")]
		public const float MAX_BALANCE = 1E+09f;
	}
}
