using System;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000887 RID: 2183
	[Token(Token = "0x2000887")]
	public class PlayerSmoothedVelocityCalculator : SmoothedVelocityCalculator
	{
		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x060039CD RID: 14797 RVA: 0x00010EC0 File Offset: 0x0000F0C0
		[Token(Token = "0x17000911")]
		public override Vector3 Velocity
		{
			[Token(Token = "0x60039CD")]
			[Address(RVA = "0x80CE70", Offset = "0x80C070", VA = "0x18080CE70", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060039CE RID: 14798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039CE")]
		[Address(RVA = "0x80CE60", Offset = "0x80C060", VA = "0x18080CE60")]
		public PlayerSmoothedVelocityCalculator()
		{
		}

		// Token: 0x04002A8B RID: 10891
		[Token(Token = "0x4002A8B")]
		[FieldOffset(Offset = "0x58")]
		public Player Player;
	}
}
