using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.Police
{
	// Token: 0x02000782 RID: 1922
	[Token(Token = "0x2000782")]
	public class Offense
	{
		// Token: 0x060032D6 RID: 13014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D6")]
		[Address(RVA = "0x770D10", Offset = "0x76FF10", VA = "0x180770D10")]
		public Offense(List<Offense.Charge> _charges)
		{
		}

		// Token: 0x0400255B RID: 9563
		[Token(Token = "0x400255B")]
		[FieldOffset(Offset = "0x10")]
		public List<Offense.Charge> charges;

		// Token: 0x0400255C RID: 9564
		[Token(Token = "0x400255C")]
		[FieldOffset(Offset = "0x18")]
		public List<string> penalties;

		// Token: 0x02000783 RID: 1923
		[Token(Token = "0x2000783")]
		public class Charge
		{
			// Token: 0x060032D7 RID: 13015 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60032D7")]
			[Address(RVA = "0x76E700", Offset = "0x76D900", VA = "0x18076E700")]
			public Charge(string _chargeName, int _crimeIndex, int _quantity)
			{
			}

			// Token: 0x0400255D RID: 9565
			[Token(Token = "0x400255D")]
			[FieldOffset(Offset = "0x10")]
			public string chargeName;

			// Token: 0x0400255E RID: 9566
			[Token(Token = "0x400255E")]
			[FieldOffset(Offset = "0x18")]
			public int crimeIndex;

			// Token: 0x0400255F RID: 9567
			[Token(Token = "0x400255F")]
			[FieldOffset(Offset = "0x1C")]
			public int quantity;
		}
	}
}
