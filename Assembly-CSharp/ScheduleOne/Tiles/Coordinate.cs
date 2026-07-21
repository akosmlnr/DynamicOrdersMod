using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tiles
{
	// Token: 0x02000305 RID: 773
	[Token(Token = "0x2000305")]
	[Serializable]
	public class Coordinate
	{
		// Token: 0x06001253 RID: 4691 RVA: 0x00008718 File Offset: 0x00006918
		[Token(Token = "0x6001253")]
		[Address(RVA = "0xB1B780", Offset = "0xB1A980", VA = "0x180B1B780")]
		public static implicit operator Vector2(Coordinate c)
		{
			return default(Vector2);
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001254")]
		[Address(RVA = "0xB1B690", Offset = "0xB1A890", VA = "0x180B1B690")]
		public Coordinate()
		{
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001255")]
		[Address(RVA = "0xB1B650", Offset = "0xB1A850", VA = "0x180B1B650")]
		public Coordinate(int _x, int _y)
		{
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001256")]
		[Address(RVA = "0xB1B6B0", Offset = "0xB1A8B0", VA = "0x180B1B6B0")]
		public Coordinate(Vector2 vector)
		{
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x00008730 File Offset: 0x00006930
		[Token(Token = "0x6001257")]
		[Address(RVA = "0xB1B1D0", Offset = "0xB1A3D0", VA = "0x180B1B1D0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x00008748 File Offset: 0x00006948
		[Token(Token = "0x6001258")]
		[Address(RVA = "0xB1B140", Offset = "0xB1A340", VA = "0x180B1B140", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001259")]
		[Address(RVA = "0xB1B6E0", Offset = "0xB1A8E0", VA = "0x180B1B6E0")]
		public static Coordinate operator +(Coordinate a, Coordinate b)
		{
			return null;
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600125A")]
		[Address(RVA = "0xB1B7B0", Offset = "0xB1A9B0", VA = "0x180B1B7B0")]
		public static Coordinate operator -(Coordinate a, Coordinate b)
		{
			return null;
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x00008760 File Offset: 0x00006960
		[Token(Token = "0x600125B")]
		[Address(RVA = "0xB1B100", Offset = "0xB1A300", VA = "0x180B1B100")]
		private int CantorPair(int x, int y)
		{
			return 0;
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x00008778 File Offset: 0x00006978
		[Token(Token = "0x600125C")]
		[Address(RVA = "0xB1B490", Offset = "0xB1A690", VA = "0x180B1B490")]
		private int SignedCantorPair(int x, int y)
		{
			return 0;
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600125D")]
		[Address(RVA = "0xB1B530", Offset = "0xB1A730", VA = "0x180B1B530", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600125E")]
		[Address(RVA = "0xB1ADF0", Offset = "0xB19FF0", VA = "0x180B1ADF0")]
		public static List<CoordinatePair> BuildCoordinateMatches(Coordinate originCoord, int sizeX, int sizeY, float rot)
		{
			return null;
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600125F")]
		[Address(RVA = "0xB1B2E0", Offset = "0xB1A4E0", VA = "0x180B1B2E0")]
		public static Coordinate RotateCoordinates(Coordinate coord, float angle)
		{
			return null;
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x00008790 File Offset: 0x00006990
		[Token(Token = "0x6001260")]
		[Address(RVA = "0xB1B280", Offset = "0xB1A480", VA = "0x180B1B280")]
		private static int MathMod(int a, int b)
		{
			return 0;
		}

		// Token: 0x040010BC RID: 4284
		[Token(Token = "0x40010BC")]
		[FieldOffset(Offset = "0x10")]
		public int x;

		// Token: 0x040010BD RID: 4285
		[Token(Token = "0x40010BD")]
		[FieldOffset(Offset = "0x14")]
		public int y;
	}
}
