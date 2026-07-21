using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;

namespace ScheduleOne.Economy
{
	// Token: 0x02000694 RID: 1684
	[Token(Token = "0x2000694")]
	[Serializable]
	public class ContractReceipt
	{
		// Token: 0x06002B93 RID: 11155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B93")]
		[Address(RVA = "0x707590", Offset = "0x706790", VA = "0x180707590")]
		public ContractReceipt(int receiptId, EContractParty completedBy, string customerID, GameDateTime completionTime, StringIntPair[] items, float amountPaid)
		{
		}

		// Token: 0x06002B94 RID: 11156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B94")]
		[Address(RVA = "0x7074D0", Offset = "0x7066D0", VA = "0x1807074D0")]
		public ContractReceipt()
		{
		}

		// Token: 0x040020D2 RID: 8402
		[Token(Token = "0x40020D2")]
		[FieldOffset(Offset = "0x10")]
		public int ReceiptId;

		// Token: 0x040020D3 RID: 8403
		[Token(Token = "0x40020D3")]
		[FieldOffset(Offset = "0x14")]
		public EContractParty CompletedBy;

		// Token: 0x040020D4 RID: 8404
		[Token(Token = "0x40020D4")]
		[FieldOffset(Offset = "0x18")]
		public string CustomerId;

		// Token: 0x040020D5 RID: 8405
		[Token(Token = "0x40020D5")]
		[FieldOffset(Offset = "0x20")]
		public GameDateTime CompletionTime;

		// Token: 0x040020D6 RID: 8406
		[Token(Token = "0x40020D6")]
		[FieldOffset(Offset = "0x28")]
		public StringIntPair[] Items;

		// Token: 0x040020D7 RID: 8407
		[Token(Token = "0x40020D7")]
		[FieldOffset(Offset = "0x30")]
		public float AmountPaid;
	}
}
