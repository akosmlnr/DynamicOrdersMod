using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Animation
{
	// Token: 0x0200081E RID: 2078
	[Token(Token = "0x200081E")]
	public static class AAId
	{
		// Token: 0x060037D3 RID: 14291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037D3")]
		[Address(RVA = "0x7E0340", Offset = "0x7DF540", VA = "0x1807E0340")]
		[RuntimeInitializeOnLoadMethod]
		private static void Init()
		{
		}

		// Token: 0x060037D4 RID: 14292 RVA: 0x000107A0 File Offset: 0x0000E9A0
		[Token(Token = "0x60037D4")]
		[Address(RVA = "0x7E0220", Offset = "0x7DF420", VA = "0x1807E0220")]
		public static int Get(string id)
		{
			return 0;
		}

		// Token: 0x040028B0 RID: 10416
		[Token(Token = "0x40028B0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int DIRECTION;

		// Token: 0x040028B1 RID: 10417
		[Token(Token = "0x40028B1")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int STRAFE;

		// Token: 0x040028B2 RID: 10418
		[Token(Token = "0x40028B2")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int TIME_AIRBORNE;

		// Token: 0x040028B3 RID: 10419
		[Token(Token = "0x40028B3")]
		[FieldOffset(Offset = "0xC")]
		public static readonly int IS_CROUCHED;

		// Token: 0x040028B4 RID: 10420
		[Token(Token = "0x40028B4")]
		[FieldOffset(Offset = "0x10")]
		public static readonly int IS_GROUNDED;

		// Token: 0x040028B5 RID: 10421
		[Token(Token = "0x40028B5")]
		[FieldOffset(Offset = "0x14")]
		public static readonly int JUMP;

		// Token: 0x040028B6 RID: 10422
		[Token(Token = "0x40028B6")]
		[FieldOffset(Offset = "0x18")]
		public static readonly int FLINCH_FORWARD;

		// Token: 0x040028B7 RID: 10423
		[Token(Token = "0x40028B7")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly int FLINCH_BACKWARD;

		// Token: 0x040028B8 RID: 10424
		[Token(Token = "0x40028B8")]
		[FieldOffset(Offset = "0x20")]
		public static readonly int FLINCH_LEFT;

		// Token: 0x040028B9 RID: 10425
		[Token(Token = "0x40028B9")]
		[FieldOffset(Offset = "0x24")]
		public static readonly int FLINCH_RIGHT;

		// Token: 0x040028BA RID: 10426
		[Token(Token = "0x40028BA")]
		[FieldOffset(Offset = "0x28")]
		public static readonly int FLINCH_HEAVY_FORWARD;

		// Token: 0x040028BB RID: 10427
		[Token(Token = "0x40028BB")]
		[FieldOffset(Offset = "0x2C")]
		public static readonly int FLINCH_HEAVY_BACKWARD;

		// Token: 0x040028BC RID: 10428
		[Token(Token = "0x40028BC")]
		[FieldOffset(Offset = "0x30")]
		public static readonly int FLINCH_HEAVY_LEFT;

		// Token: 0x040028BD RID: 10429
		[Token(Token = "0x40028BD")]
		[FieldOffset(Offset = "0x34")]
		public static readonly int FLINCH_HEAVY_RIGHT;

		// Token: 0x040028BE RID: 10430
		[Token(Token = "0x40028BE")]
		[FieldOffset(Offset = "0x38")]
		public static readonly int STANDUP_BACK;

		// Token: 0x040028BF RID: 10431
		[Token(Token = "0x40028BF")]
		[FieldOffset(Offset = "0x3C")]
		public static readonly int STANDUP_FRONT;

		// Token: 0x040028C0 RID: 10432
		[Token(Token = "0x40028C0")]
		[FieldOffset(Offset = "0x40")]
		public static readonly int SITTING;

		// Token: 0x040028C1 RID: 10433
		[Token(Token = "0x40028C1")]
		[FieldOffset(Offset = "0x48")]
		private static Dictionary<string, int> s_CustomHashes;
	}
}
