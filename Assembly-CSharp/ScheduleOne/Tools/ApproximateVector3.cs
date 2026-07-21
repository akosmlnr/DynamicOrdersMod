using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x0200084B RID: 2123
	[Token(Token = "0x200084B")]
	public struct ApproximateVector3
	{
		// Token: 0x060038CA RID: 14538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038CA")]
		[Address(RVA = "0x7F6EA0", Offset = "0x7F60A0", VA = "0x1807F6EA0")]
		public ApproximateVector3(float x, float y, float z)
		{
		}

		// Token: 0x060038CB RID: 14539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038CB")]
		[Address(RVA = "0x7F6E60", Offset = "0x7F6060", VA = "0x1807F6E60")]
		public ApproximateVector3(Vector3 vector)
		{
		}

		// Token: 0x060038CC RID: 14540 RVA: 0x00010B18 File Offset: 0x0000ED18
		[Token(Token = "0x60038CC")]
		[Address(RVA = "0x7F6E10", Offset = "0x7F6010", VA = "0x1807F6E10")]
		public Vector3 ToVector3()
		{
			return default(Vector3);
		}

		// Token: 0x040029DA RID: 10714
		[Token(Token = "0x40029DA")]
		[FieldOffset(Offset = "0x0")]
		public short X;

		// Token: 0x040029DB RID: 10715
		[Token(Token = "0x40029DB")]
		[FieldOffset(Offset = "0x2")]
		public short Y;

		// Token: 0x040029DC RID: 10716
		[Token(Token = "0x40029DC")]
		[FieldOffset(Offset = "0x4")]
		public short Z;
	}
}
