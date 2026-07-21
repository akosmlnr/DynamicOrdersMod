using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.GameTime
{
	// Token: 0x020002FA RID: 762
	[Token(Token = "0x20002FA")]
	[Serializable]
	public struct GameDateTime
	{
		// Token: 0x060011BA RID: 4538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011BA")]
		[Address(RVA = "0x53E580", Offset = "0x53D780", VA = "0x18053E580")]
		public GameDateTime(int _elapsedDays, int _time)
		{
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011BB")]
		[Address(RVA = "0xB1BEC0", Offset = "0xB1B0C0", VA = "0x180B1BEC0")]
		public GameDateTime(int _minSum)
		{
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011BC")]
		[Address(RVA = "0xB1BEA0", Offset = "0xB1B0A0", VA = "0x180B1BEA0")]
		public GameDateTime(GameDateTimeData data)
		{
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x000082B0 File Offset: 0x000064B0
		[Token(Token = "0x60011BD")]
		[Address(RVA = "0xB1BE30", Offset = "0xB1B030", VA = "0x180B1BE30")]
		public int GetMinSum()
		{
			return 0;
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x000082C8 File Offset: 0x000064C8
		[Token(Token = "0x60011BE")]
		[Address(RVA = "0xB1BD70", Offset = "0xB1AF70", VA = "0x180B1BD70")]
		public GameDateTime AddMins(int mins)
		{
			return default(GameDateTime);
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x000082E0 File Offset: 0x000064E0
		[Token(Token = "0x60011BF")]
		[Address(RVA = "0xB1BE10", Offset = "0xB1B010", VA = "0x180B1BE10")]
		public GameDateTime GetCopy()
		{
			return default(GameDateTime);
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x000082F8 File Offset: 0x000064F8
		[Token(Token = "0x60011C0")]
		[Address(RVA = "0xB1BFC0", Offset = "0xB1B1C0", VA = "0x180B1BFC0")]
		public static GameDateTime operator +(GameDateTime a, GameDateTime b)
		{
			return default(GameDateTime);
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x00008310 File Offset: 0x00006510
		[Token(Token = "0x60011C1")]
		[Address(RVA = "0xB1C450", Offset = "0xB1B650", VA = "0x180B1C450")]
		public static GameDateTime operator -(GameDateTime a, GameDateTime b)
		{
			return default(GameDateTime);
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x00008328 File Offset: 0x00006528
		[Token(Token = "0x60011C2")]
		[Address(RVA = "0xB1C1A0", Offset = "0xB1B3A0", VA = "0x180B1C1A0")]
		public static bool operator >(GameDateTime a, GameDateTime b)
		{
			return default(bool);
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x00008340 File Offset: 0x00006540
		[Token(Token = "0x60011C3")]
		[Address(RVA = "0xB1C0B0", Offset = "0xB1B2B0", VA = "0x180B1C0B0")]
		public static bool operator >=(GameDateTime a, GameDateTime b)
		{
			return default(bool);
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x00008358 File Offset: 0x00006558
		[Token(Token = "0x60011C4")]
		[Address(RVA = "0xB1C370", Offset = "0xB1B570", VA = "0x180B1C370")]
		public static bool operator <(GameDateTime a, GameDateTime b)
		{
			return default(bool);
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x00008370 File Offset: 0x00006570
		[Token(Token = "0x60011C5")]
		[Address(RVA = "0xB1C280", Offset = "0xB1B480", VA = "0x180B1C280")]
		public static bool operator <=(GameDateTime a, GameDateTime b)
		{
			return default(bool);
		}

		// Token: 0x0400106C RID: 4204
		[Token(Token = "0x400106C")]
		[FieldOffset(Offset = "0x0")]
		public int elapsedDays;

		// Token: 0x0400106D RID: 4205
		[Token(Token = "0x400106D")]
		[FieldOffset(Offset = "0x4")]
		public int time;
	}
}
