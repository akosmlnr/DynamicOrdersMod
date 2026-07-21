using System;
using Il2CppDummyDll;

namespace ScheduleOne.Graffiti
{
	// Token: 0x0200064E RID: 1614
	[Token(Token = "0x200064E")]
	public class PixelData
	{
		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x060027C8 RID: 10184 RVA: 0x0000CE40 File Offset: 0x0000B040
		[Token(Token = "0x170006F0")]
		public byte StrokeRadiusRoundedUp
		{
			[Token(Token = "0x60027C8")]
			[Address(RVA = "0x6C9CA0", Offset = "0x6C8EA0", VA = "0x1806C9CA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x060027C9 RID: 10185 RVA: 0x0000CE58 File Offset: 0x0000B058
		[Token(Token = "0x170006F1")]
		public byte StrokeRadiusRoundedDown
		{
			[Token(Token = "0x60027C9")]
			[Address(RVA = "0x6C9C30", Offset = "0x6C8E30", VA = "0x1806C9C30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060027CA RID: 10186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027CA")]
		[Address(RVA = "0x6C9BE0", Offset = "0x6C8DE0", VA = "0x1806C9BE0")]
		public PixelData(UShort2 coordinate, ESprayColor color, byte strokeSize)
		{
		}

		// Token: 0x060027CB RID: 10187 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60027CB")]
		[Address(RVA = "0x6C9B40", Offset = "0x6C8D40", VA = "0x1806C9B40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x0000CE70 File Offset: 0x0000B070
		[Token(Token = "0x60027CC")]
		[Address(RVA = "0x6C99E0", Offset = "0x6C8BE0", VA = "0x1806C99E0")]
		public float GetPixelStrength(int pixelIndex)
		{
			return 0f;
		}

		// Token: 0x04001EDF RID: 7903
		[Token(Token = "0x4001EDF")]
		[FieldOffset(Offset = "0x10")]
		public UShort2 Coordinate;

		// Token: 0x04001EE0 RID: 7904
		[Token(Token = "0x4001EE0")]
		[FieldOffset(Offset = "0x14")]
		public ESprayColor Color;

		// Token: 0x04001EE1 RID: 7905
		[Token(Token = "0x4001EE1")]
		[FieldOffset(Offset = "0x15")]
		public byte StrokeSize;
	}
}
