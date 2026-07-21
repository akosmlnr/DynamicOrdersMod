using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Police
{
	// Token: 0x02000780 RID: 1920
	[Token(Token = "0x2000780")]
	public class Investigation
	{
		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x060032BC RID: 12988 RVA: 0x0000F7F8 File Offset: 0x0000D9F8
		// (set) Token: 0x060032BD RID: 12989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700082C")]
		public float CurrentProgress
		{
			[Token(Token = "0x60032BC")]
			[Address(RVA = "0x475910", Offset = "0x474B10", VA = "0x180475910")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60032BD")]
			[Address(RVA = "0x492A10", Offset = "0x491C10", VA = "0x180492A10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x060032BE RID: 12990 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060032BF RID: 12991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700082D")]
		public Player Target
		{
			[Token(Token = "0x60032BE")]
			[Address(RVA = "0x43FFD0", Offset = "0x43F1D0", VA = "0x18043FFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60032BF")]
			[Address(RVA = "0x440000", Offset = "0x43F200", VA = "0x180440000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060032C0 RID: 12992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032C0")]
		[Address(RVA = "0x76E7A0", Offset = "0x76D9A0", VA = "0x18076E7A0")]
		public Investigation(Player target)
		{
		}

		// Token: 0x060032C1 RID: 12993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032C1")]
		[Address(RVA = "0x621A90", Offset = "0x620C90", VA = "0x180621A90")]
		public void ChangeProgress(float progress)
		{
		}
	}
}
