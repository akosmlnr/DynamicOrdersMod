using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Casino
{
	// Token: 0x02000762 RID: 1890
	[Token(Token = "0x2000762")]
	public class CasinoGamePlayerData
	{
		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x0600317A RID: 12666 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600317B RID: 12667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700080D")]
		public CasinoGamePlayers Parent
		{
			[Token(Token = "0x600317A")]
			[Address(RVA = "0x43FFF0", Offset = "0x43F1F0", VA = "0x18043FFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600317B")]
			[Address(RVA = "0x49B100", Offset = "0x49A300", VA = "0x18049B100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x0600317C RID: 12668 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600317D RID: 12669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700080E")]
		public Player Player
		{
			[Token(Token = "0x600317C")]
			[Address(RVA = "0x43FFD0", Offset = "0x43F1D0", VA = "0x18043FFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600317D")]
			[Address(RVA = "0x440000", Offset = "0x43F200", VA = "0x180440000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600317E RID: 12670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600317E")]
		[Address(RVA = "0x758AF0", Offset = "0x757CF0", VA = "0x180758AF0")]
		public CasinoGamePlayerData(CasinoGamePlayers parent, Player player)
		{
		}

		// Token: 0x0600317F RID: 12671 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600317F")]
		public T GetData<T>(string key)
		{
			return null;
		}

		// Token: 0x06003180 RID: 12672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003180")]
		public void SetData<T>(string key, T value, bool network = true)
		{
		}

		// Token: 0x04002474 RID: 9332
		[Token(Token = "0x4002474")]
		[FieldOffset(Offset = "0x20")]
		protected Dictionary<string, bool> bools;

		// Token: 0x04002475 RID: 9333
		[Token(Token = "0x4002475")]
		[FieldOffset(Offset = "0x28")]
		protected Dictionary<string, float> floats;
	}
}
