using System;
using Il2CppDummyDll;
using ScheduleOne.Cartel;
using ScheduleOne.Map;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200045A RID: 1114
	[Token(Token = "0x200045A")]
	[Serializable]
	public class CartelData : SaveData
	{
		// Token: 0x06001A91 RID: 6801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A91")]
		[Address(RVA = "0x6025D0", Offset = "0x6017D0", VA = "0x1806025D0")]
		public CartelData(ECartelStatus status, int hoursSinceStatusChange, CartelInfluence.RegionInfluenceData[] regionInfluence, int hoursUntilNextGlobalActivity, CartelRegionalActivityData[] regionalActivityData, CartelDealInfo activeCartelDeal, int hoursUntilNextDealRequest)
		{
		}

		// Token: 0x0400163A RID: 5690
		[Token(Token = "0x400163A")]
		[FieldOffset(Offset = "0x28")]
		public ECartelStatus Status;

		// Token: 0x0400163B RID: 5691
		[Token(Token = "0x400163B")]
		[FieldOffset(Offset = "0x2C")]
		public int HoursSinceStatusChange;

		// Token: 0x0400163C RID: 5692
		[Token(Token = "0x400163C")]
		[FieldOffset(Offset = "0x30")]
		public CartelInfluence.RegionInfluenceData[] RegionInfluence;

		// Token: 0x0400163D RID: 5693
		[Token(Token = "0x400163D")]
		[FieldOffset(Offset = "0x38")]
		public int HoursUntilNextGlobalActivity;

		// Token: 0x0400163E RID: 5694
		[Token(Token = "0x400163E")]
		[FieldOffset(Offset = "0x40")]
		public CartelRegionalActivityData[] RegionalActivityData;

		// Token: 0x0400163F RID: 5695
		[Token(Token = "0x400163F")]
		[FieldOffset(Offset = "0x48")]
		public CartelDealInfo ActiveCartelDeal;

		// Token: 0x04001640 RID: 5696
		[Token(Token = "0x4001640")]
		[FieldOffset(Offset = "0x50")]
		public int HoursUntilNextDealRequest;

		// Token: 0x0200045B RID: 1115
		[Token(Token = "0x200045B")]
		[Serializable]
		public class RegionIntDict : SerializableDictionary<EMapRegion, int>
		{
			// Token: 0x06001A92 RID: 6802 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001A92")]
			[Address(RVA = "0x616C10", Offset = "0x615E10", VA = "0x180616C10")]
			public RegionIntDict()
			{
			}
		}
	}
}
