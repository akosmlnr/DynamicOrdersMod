using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.Delivery
{
	// Token: 0x02000734 RID: 1844
	[Token(Token = "0x2000734")]
	[Serializable]
	public class DeliveryReceipt
	{
		// Token: 0x06003043 RID: 12355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003043")]
		[Address(RVA = "0x7642F0", Offset = "0x7634F0", VA = "0x1807642F0")]
		public DeliveryReceipt(string deliveryID, string storeName, string destinationCode, int loadingDockIndex, StringIntPair[] items)
		{
		}

		// Token: 0x06003044 RID: 12356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003044")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public DeliveryReceipt()
		{
		}

		// Token: 0x04002388 RID: 9096
		[Token(Token = "0x4002388")]
		[FieldOffset(Offset = "0x10")]
		public string DeliveryID;

		// Token: 0x04002389 RID: 9097
		[Token(Token = "0x4002389")]
		[FieldOffset(Offset = "0x18")]
		public string StoreName;

		// Token: 0x0400238A RID: 9098
		[Token(Token = "0x400238A")]
		[FieldOffset(Offset = "0x20")]
		public string DestinationCode;

		// Token: 0x0400238B RID: 9099
		[Token(Token = "0x400238B")]
		[FieldOffset(Offset = "0x28")]
		public int LoadingDockIndex;

		// Token: 0x0400238C RID: 9100
		[Token(Token = "0x400238C")]
		[FieldOffset(Offset = "0x30")]
		public StringIntPair[] Items;
	}
}
