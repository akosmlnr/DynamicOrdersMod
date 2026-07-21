using System;
using Il2CppDummyDll;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000153 RID: 339
	[Token(Token = "0x2000153")]
	public static class TransformUtils
	{
		// Token: 0x0600060A RID: 1546 RVA: 0x000049E0 File Offset: 0x00002BE0
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x7B9C10", Offset = "0x7B8E10", VA = "0x1807B9C10")]
		public static TransformUtils.Packed GetWorldPacked(this Transform self)
		{
			return default(TransformUtils.Packed);
		}

		// Token: 0x02000154 RID: 340
		[Token(Token = "0x2000154")]
		public struct Packed
		{
			// Token: 0x0600060B RID: 1547 RVA: 0x000049F8 File Offset: 0x00002BF8
			[Token(Token = "0x600060B")]
			[Address(RVA = "0x7B4770", Offset = "0x7B3970", VA = "0x1807B4770")]
			public bool IsSame(Transform transf)
			{
				return default(bool);
			}

			// Token: 0x040006E0 RID: 1760
			[Token(Token = "0x40006E0")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 position;

			// Token: 0x040006E1 RID: 1761
			[Token(Token = "0x40006E1")]
			[FieldOffset(Offset = "0xC")]
			public Quaternion rotation;

			// Token: 0x040006E2 RID: 1762
			[Token(Token = "0x40006E2")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 lossyScale;
		}
	}
}
