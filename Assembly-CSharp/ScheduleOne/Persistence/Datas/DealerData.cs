using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004A2 RID: 1186
	[Token(Token = "0x20004A2")]
	public class DealerData : NPCData
	{
		// Token: 0x06001AF3 RID: 6899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF3")]
		[Address(RVA = "0x603650", Offset = "0x602850", VA = "0x180603650")]
		public DealerData(string id, bool recruited, string[] assignedCustomerIDs, string[] activeContractGUIDs, float cash, ItemSet overflowItems, bool hasBeenRecommended)
		{
		}

		// Token: 0x040016CD RID: 5837
		[Token(Token = "0x40016CD")]
		[FieldOffset(Offset = "0x30")]
		public bool Recruited;

		// Token: 0x040016CE RID: 5838
		[Token(Token = "0x40016CE")]
		[FieldOffset(Offset = "0x38")]
		public string[] AssignedCustomerIDs;

		// Token: 0x040016CF RID: 5839
		[Token(Token = "0x40016CF")]
		[FieldOffset(Offset = "0x40")]
		public string[] ActiveContractGUIDs;

		// Token: 0x040016D0 RID: 5840
		[Token(Token = "0x40016D0")]
		[FieldOffset(Offset = "0x48")]
		public float Cash;

		// Token: 0x040016D1 RID: 5841
		[Token(Token = "0x40016D1")]
		[FieldOffset(Offset = "0x50")]
		public ItemSet OverflowItems;

		// Token: 0x040016D2 RID: 5842
		[Token(Token = "0x40016D2")]
		[FieldOffset(Offset = "0x58")]
		public bool HasBeenRecommended;
	}
}
