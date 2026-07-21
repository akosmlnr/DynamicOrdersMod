using System;
using Il2CppDummyDll;
using ScheduleOne.GameTime;
using ScheduleOne.Quests;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200045C RID: 1116
	[Token(Token = "0x200045C")]
	public class CustomerData : SaveData
	{
		// Token: 0x06001A93 RID: 6803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A93")]
		[Address(RVA = "0x603400", Offset = "0x602600", VA = "0x180603400")]
		public CustomerData(float dependence, float[] productAffinities, int timeSinceLastDealCompleted, int timeSinceLastDealOffered, int offeredDeals, int completedDeals, bool isContractOffered, ContractInfo offeredContract, GameDateTime offeredTime, int timeSincePlayerApproached, int timeSinceInstantDealOffered, bool hasBeenRecommended)
		{
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A94")]
		[Address(RVA = "0x6034C0", Offset = "0x6026C0", VA = "0x1806034C0")]
		public CustomerData()
		{
		}

		// Token: 0x04001641 RID: 5697
		[Token(Token = "0x4001641")]
		[FieldOffset(Offset = "0x28")]
		public float Dependence;

		// Token: 0x04001642 RID: 5698
		[Token(Token = "0x4001642")]
		[FieldOffset(Offset = "0x30")]
		public float[] ProductAffinities;

		// Token: 0x04001643 RID: 5699
		[Token(Token = "0x4001643")]
		[FieldOffset(Offset = "0x38")]
		public int TimeSinceLastDealCompleted;

		// Token: 0x04001644 RID: 5700
		[Token(Token = "0x4001644")]
		[FieldOffset(Offset = "0x3C")]
		public int TimeSinceLastDealOffered;

		// Token: 0x04001645 RID: 5701
		[Token(Token = "0x4001645")]
		[FieldOffset(Offset = "0x40")]
		public int OfferedDeals;

		// Token: 0x04001646 RID: 5702
		[Token(Token = "0x4001646")]
		[FieldOffset(Offset = "0x44")]
		public int CompletedDeals;

		// Token: 0x04001647 RID: 5703
		[Token(Token = "0x4001647")]
		[FieldOffset(Offset = "0x48")]
		public bool IsContractOffered;

		// Token: 0x04001648 RID: 5704
		[Token(Token = "0x4001648")]
		[FieldOffset(Offset = "0x50")]
		public ContractInfo OfferedContract;

		// Token: 0x04001649 RID: 5705
		[Token(Token = "0x4001649")]
		[FieldOffset(Offset = "0x58")]
		public GameDateTime OfferedContractTime;

		// Token: 0x0400164A RID: 5706
		[Token(Token = "0x400164A")]
		[FieldOffset(Offset = "0x60")]
		public int TimeSincePlayerApproached;

		// Token: 0x0400164B RID: 5707
		[Token(Token = "0x400164B")]
		[FieldOffset(Offset = "0x64")]
		public int TimeSinceInstantDealOffered;

		// Token: 0x0400164C RID: 5708
		[Token(Token = "0x400164C")]
		[FieldOffset(Offset = "0x68")]
		public bool HasBeenRecommended;
	}
}
