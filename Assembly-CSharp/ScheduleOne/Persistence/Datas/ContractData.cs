using System;
using Il2CppDummyDll;
using ScheduleOne.Product;
using ScheduleOne.Quests;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004C9 RID: 1225
	[Token(Token = "0x20004C9")]
	[Serializable]
	public class ContractData : QuestData
	{
		// Token: 0x06001B1C RID: 6940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B1C")]
		[Address(RVA = "0x603310", Offset = "0x602510", VA = "0x180603310")]
		public ContractData(string guid, EQuestState state, bool isTracked, string title, string desc, bool isTimed, GameDateTimeData expiry, QuestEntryData[] entries, string customerGUID, float payment, ProductList productList, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, int pickupScheduleIndex, GameDateTimeData acceptTime)
		{
		}

		// Token: 0x04001743 RID: 5955
		[Token(Token = "0x4001743")]
		[FieldOffset(Offset = "0x60")]
		public string CustomerGUID;

		// Token: 0x04001744 RID: 5956
		[Token(Token = "0x4001744")]
		[FieldOffset(Offset = "0x68")]
		public float Payment;

		// Token: 0x04001745 RID: 5957
		[Token(Token = "0x4001745")]
		[FieldOffset(Offset = "0x70")]
		public ProductList ProductList;

		// Token: 0x04001746 RID: 5958
		[Token(Token = "0x4001746")]
		[FieldOffset(Offset = "0x78")]
		public string DeliveryLocationGUID;

		// Token: 0x04001747 RID: 5959
		[Token(Token = "0x4001747")]
		[FieldOffset(Offset = "0x80")]
		public QuestWindowConfig DeliveryWindow;

		// Token: 0x04001748 RID: 5960
		[Token(Token = "0x4001748")]
		[FieldOffset(Offset = "0x88")]
		public int PickupScheduleIndex;

		// Token: 0x04001749 RID: 5961
		[Token(Token = "0x4001749")]
		[FieldOffset(Offset = "0x90")]
		public GameDateTimeData AcceptTime;
	}
}
