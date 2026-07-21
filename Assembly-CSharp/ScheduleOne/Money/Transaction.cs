using System;
using Il2CppDummyDll;

namespace ScheduleOne.Money
{
	// Token: 0x02000521 RID: 1313
	[Token(Token = "0x2000521")]
	public class Transaction
	{
		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001D06 RID: 7430 RVA: 0x0000A8C0 File Offset: 0x00008AC0
		[Token(Token = "0x1700054B")]
		public float total_Amount
		{
			[Token(Token = "0x6001D06")]
			[Address(RVA = "0x632E40", Offset = "0x632040", VA = "0x180632E40")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D07")]
		[Address(RVA = "0x632D70", Offset = "0x631F70", VA = "0x180632D70")]
		public Transaction(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
		}

		// Token: 0x04001877 RID: 6263
		[Token(Token = "0x4001877")]
		[FieldOffset(Offset = "0x10")]
		public string transaction_Name;

		// Token: 0x04001878 RID: 6264
		[Token(Token = "0x4001878")]
		[FieldOffset(Offset = "0x18")]
		public float unit_Amount;

		// Token: 0x04001879 RID: 6265
		[Token(Token = "0x4001879")]
		[FieldOffset(Offset = "0x1C")]
		public float quantity;

		// Token: 0x0400187A RID: 6266
		[Token(Token = "0x400187A")]
		[FieldOffset(Offset = "0x20")]
		public string transaction_Note;
	}
}
