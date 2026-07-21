using System;
using Il2CppDummyDll;
using ScheduleOne.GameTime;

namespace ScheduleOne.Cartel
{
	// Token: 0x0200079A RID: 1946
	[Token(Token = "0x200079A")]
	[Serializable]
	public class CartelDealInfo
	{
		// Token: 0x060033E4 RID: 13284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033E4")]
		[Address(RVA = "0x7910B0", Offset = "0x7902B0", VA = "0x1807910B0")]
		public CartelDealInfo(string requestedProductID, int requestedProductQuantity, int payment, GameDateTime dueTime, CartelDealInfo.EStatus status)
		{
		}

		// Token: 0x060033E5 RID: 13285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033E5")]
		[Address(RVA = "0x791040", Offset = "0x790240", VA = "0x180791040")]
		public CartelDealInfo()
		{
		}

		// Token: 0x060033E6 RID: 13286 RVA: 0x0000FC30 File Offset: 0x0000DE30
		[Token(Token = "0x60033E6")]
		[Address(RVA = "0x790FC0", Offset = "0x7901C0", VA = "0x180790FC0")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x040025F6 RID: 9718
		[Token(Token = "0x40025F6")]
		[FieldOffset(Offset = "0x10")]
		public string RequestedProductID;

		// Token: 0x040025F7 RID: 9719
		[Token(Token = "0x40025F7")]
		[FieldOffset(Offset = "0x18")]
		public int RequestedProductQuantity;

		// Token: 0x040025F8 RID: 9720
		[Token(Token = "0x40025F8")]
		[FieldOffset(Offset = "0x1C")]
		public int PaymentAmount;

		// Token: 0x040025F9 RID: 9721
		[Token(Token = "0x40025F9")]
		[FieldOffset(Offset = "0x20")]
		public GameDateTime DueTime;

		// Token: 0x040025FA RID: 9722
		[Token(Token = "0x40025FA")]
		[FieldOffset(Offset = "0x28")]
		public CartelDealInfo.EStatus Status;

		// Token: 0x0200079B RID: 1947
		[Token(Token = "0x200079B")]
		public enum EStatus
		{
			// Token: 0x040025FC RID: 9724
			[Token(Token = "0x40025FC")]
			Pending,
			// Token: 0x040025FD RID: 9725
			[Token(Token = "0x40025FD")]
			Overdue
		}
	}
}
