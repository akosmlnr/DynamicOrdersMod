using System;
using Il2CppDummyDll;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000144 RID: 324
	[Token(Token = "0x2000144")]
	public static class GlobalMeshSD
	{
		// Token: 0x0600057C RID: 1404 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x7A6370", Offset = "0x7A5570", VA = "0x1807A6370")]
		public static Mesh Get()
		{
			return null;
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600057D")]
		[Address(RVA = "0x7A62A0", Offset = "0x7A54A0", VA = "0x1807A62A0")]
		public static void Destroy()
		{
		}

		// Token: 0x0400065B RID: 1627
		[Token(Token = "0x400065B")]
		[FieldOffset(Offset = "0x0")]
		private static Mesh ms_Mesh;

		// Token: 0x0400065C RID: 1628
		[Token(Token = "0x400065C")]
		[FieldOffset(Offset = "0x8")]
		private static bool ms_DoubleSided;
	}
}
