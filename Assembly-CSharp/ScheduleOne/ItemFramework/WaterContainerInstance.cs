using System;
using System.Runtime.CompilerServices;
using FishNet.Serializing;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000641 RID: 1601
	[Token(Token = "0x2000641")]
	[Serializable]
	public class WaterContainerInstance : StorableItemInstance
	{
		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06002766 RID: 10086 RVA: 0x0000CC30 File Offset: 0x0000AE30
		// (set) Token: 0x06002767 RID: 10087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D9")]
		public float CurrentFillAmount
		{
			[Token(Token = "0x6002766")]
			[Address(RVA = "0x495790", Offset = "0x494990", VA = "0x180495790")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002767")]
			[Address(RVA = "0x49B870", Offset = "0x49AA70", VA = "0x18049B870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06002768 RID: 10088 RVA: 0x0000CC48 File Offset: 0x0000AE48
		[Token(Token = "0x170006DA")]
		public float NormalizedFillAmount
		{
			[Token(Token = "0x6002768")]
			[Address(RVA = "0x6D1D50", Offset = "0x6D0F50", VA = "0x1806D1D50")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06002769 RID: 10089 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170006DB")]
		public WaterContainerDefinition WaterContainerDefinition
		{
			[Token(Token = "0x6002769")]
			[Address(RVA = "0x6D1D90", Offset = "0x6D0F90", VA = "0x1806D1D90")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600276A")]
		[Address(RVA = "0x6D1D20", Offset = "0x6D0F20", VA = "0x1806D1D20")]
		public WaterContainerInstance(ItemDefinition definition, int quantity, float fillAmount)
		{
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600276B")]
		[Address(RVA = "0x6D1BA0", Offset = "0x6D0DA0", VA = "0x1806D1BA0", Slot = "16")]
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600276C")]
		[Address(RVA = "0x6D1B30", Offset = "0x6D0D30", VA = "0x1806D1B30")]
		public void ChangeFillAmount(float change)
		{
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600276D")]
		[Address(RVA = "0x6D1AA0", Offset = "0x6D0CA0", VA = "0x1806D1AA0")]
		public void ChangeFillAmountByPercentage(float percentage)
		{
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600276E")]
		[Address(RVA = "0x6D1CC0", Offset = "0x6D0EC0", VA = "0x1806D1CC0")]
		public void SetFillAmount(float amount)
		{
		}

		// Token: 0x0600276F RID: 10095 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600276F")]
		[Address(RVA = "0x6D1C30", Offset = "0x6D0E30", VA = "0x1806D1C30", Slot = "17")]
		public override ItemData GetItemData()
		{
			return null;
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002770")]
		[Address(RVA = "0x6B9C70", Offset = "0x6B8E70", VA = "0x1806B9C70", Slot = "18")]
		public override void Write(Writer writer)
		{
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002771")]
		[Address(RVA = "0x6B9BA0", Offset = "0x6B8DA0", VA = "0x1806B9BA0", Slot = "19")]
		public override void Read(Reader reader)
		{
		}
	}
}
