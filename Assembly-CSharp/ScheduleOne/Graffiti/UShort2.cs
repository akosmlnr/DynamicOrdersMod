using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Graffiti
{
	// Token: 0x02000654 RID: 1620
	[Token(Token = "0x2000654")]
	[Serializable]
	public struct UShort2
	{
		// Token: 0x0600285D RID: 10333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600285D")]
		[Address(RVA = "0x6EABA0", Offset = "0x6E9DA0", VA = "0x1806EABA0")]
		public UShort2(ushort x, ushort y)
		{
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600285E")]
		[Address(RVA = "0x6EAB10", Offset = "0x6E9D10", VA = "0x1806EAB10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600285F RID: 10335 RVA: 0x0000D098 File Offset: 0x0000B298
		[Token(Token = "0x600285F")]
		[Address(RVA = "0x6EABB0", Offset = "0x6E9DB0", VA = "0x1806EABB0")]
		public static UShort2 operator +(UShort2 a, UShort2 b)
		{
			return default(UShort2);
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x0000D0B0 File Offset: 0x0000B2B0
		[Token(Token = "0x6002860")]
		[Address(RVA = "0x6EABF0", Offset = "0x6E9DF0", VA = "0x1806EABF0")]
		public static UShort2 operator -(UShort2 a, UShort2 b)
		{
			return default(UShort2);
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x0000D0C8 File Offset: 0x0000B2C8
		[Token(Token = "0x6002861")]
		[Address(RVA = "0x6EABD0", Offset = "0x6E9DD0", VA = "0x1806EABD0")]
		public static implicit operator Vector2(UShort2 uShort2)
		{
			return default(Vector2);
		}

		// Token: 0x04001F20 RID: 7968
		[Token(Token = "0x4001F20")]
		[FieldOffset(Offset = "0x0")]
		public ushort X;

		// Token: 0x04001F21 RID: 7969
		[Token(Token = "0x4001F21")]
		[FieldOffset(Offset = "0x2")]
		public ushort Y;
	}
}
