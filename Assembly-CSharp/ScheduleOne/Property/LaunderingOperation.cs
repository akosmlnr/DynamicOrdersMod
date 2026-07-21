using System;
using Il2CppDummyDll;

namespace ScheduleOne.Property
{
	// Token: 0x0200035D RID: 861
	[Token(Token = "0x200035D")]
	public class LaunderingOperation
	{
		// Token: 0x06001521 RID: 5409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001521")]
		[Address(RVA = "0x59B0C0", Offset = "0x59A2C0", VA = "0x18059B0C0")]
		public LaunderingOperation(Business _business, float _amount, int _minutesSinceStarted)
		{
		}

		// Token: 0x040012EE RID: 4846
		[Token(Token = "0x40012EE")]
		[FieldOffset(Offset = "0x10")]
		public Business business;

		// Token: 0x040012EF RID: 4847
		[Token(Token = "0x40012EF")]
		[FieldOffset(Offset = "0x18")]
		public float amount;

		// Token: 0x040012F0 RID: 4848
		[Token(Token = "0x40012F0")]
		[FieldOffset(Offset = "0x1C")]
		public int minutesSinceStarted;

		// Token: 0x040012F1 RID: 4849
		[Token(Token = "0x40012F1")]
		[FieldOffset(Offset = "0x20")]
		public int completionTime_Minutes;
	}
}
