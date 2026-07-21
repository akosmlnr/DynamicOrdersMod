using System;
using Il2CppDummyDll;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A38 RID: 2616
	[Token(Token = "0x2000A38")]
	public class ExitAction
	{
		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x06004A15 RID: 18965 RVA: 0x00014220 File Offset: 0x00012420
		// (set) Token: 0x06004A16 RID: 18966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B90")]
		public bool Used
		{
			[Token(Token = "0x6004A15")]
			[Address(RVA = "0x66E350", Offset = "0x66D550", VA = "0x18066E350")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A16")]
			[Address(RVA = "0x8F4FA0", Offset = "0x8F41A0", VA = "0x1808F4FA0")]
			set
			{
			}
		}

		// Token: 0x06004A17 RID: 18967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A17")]
		[Address(RVA = "0x8F4F90", Offset = "0x8F4190", VA = "0x1808F4F90")]
		public void Use()
		{
		}

		// Token: 0x06004A18 RID: 18968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A18")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public ExitAction()
		{
		}

		// Token: 0x04003478 RID: 13432
		[Token(Token = "0x4003478")]
		[FieldOffset(Offset = "0x10")]
		public ExitType exitType;

		// Token: 0x04003479 RID: 13433
		[Token(Token = "0x4003479")]
		[FieldOffset(Offset = "0x14")]
		private bool used;
	}
}
