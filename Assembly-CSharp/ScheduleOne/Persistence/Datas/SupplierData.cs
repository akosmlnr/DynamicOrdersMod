using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004A6 RID: 1190
	[Token(Token = "0x20004A6")]
	[Serializable]
	public class SupplierData : NPCData
	{
		// Token: 0x06001AF7 RID: 6903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF7")]
		[Address(RVA = "0x619460", Offset = "0x618660", VA = "0x180619460")]
		public SupplierData(string id, int _timeSinceMeetingStart, int _timeSinceLastMeetingEnd, float _debt, int _minsUntilDeadDropReady, StringIntPair[] _deaddropItems, bool _debtReminderSent)
		{
		}

		// Token: 0x040016E1 RID: 5857
		[Token(Token = "0x40016E1")]
		[FieldOffset(Offset = "0x30")]
		public int timeSinceMeetingStart;

		// Token: 0x040016E2 RID: 5858
		[Token(Token = "0x40016E2")]
		[FieldOffset(Offset = "0x34")]
		public int timeSinceLastMeetingEnd;

		// Token: 0x040016E3 RID: 5859
		[Token(Token = "0x40016E3")]
		[FieldOffset(Offset = "0x38")]
		public float debt;

		// Token: 0x040016E4 RID: 5860
		[Token(Token = "0x40016E4")]
		[FieldOffset(Offset = "0x3C")]
		public int minsUntilDeadDropReady;

		// Token: 0x040016E5 RID: 5861
		[Token(Token = "0x40016E5")]
		[FieldOffset(Offset = "0x40")]
		public StringIntPair[] deaddropItems;

		// Token: 0x040016E6 RID: 5862
		[Token(Token = "0x40016E6")]
		[FieldOffset(Offset = "0x48")]
		public bool debtReminderSent;
	}
}
