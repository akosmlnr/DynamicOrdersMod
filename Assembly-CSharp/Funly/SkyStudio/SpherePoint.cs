using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001E7 RID: 487
	[Token(Token = "0x20001E7")]
	[Serializable]
	public class SpherePoint
	{
		// Token: 0x06000A58 RID: 2648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x917810", Offset = "0x916A10", VA = "0x180917810")]
		public SpherePoint(float horizontalRotation, float verticalRotation)
		{
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A59")]
		[Address(RVA = "0xA000E0", Offset = "0x9FF2E0", VA = "0x180A000E0")]
		public SpherePoint(Vector3 worldDirection)
		{
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0xA00090", Offset = "0x9FF290", VA = "0x180A00090")]
		public void SetFromWorldDirection(Vector3 worldDirection)
		{
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00006720 File Offset: 0x00004920
		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0xA00000", Offset = "0x9FF200", VA = "0x180A00000")]
		public Vector3 GetWorldDirection()
		{
			return default(Vector3);
		}

		// Token: 0x04000B2B RID: 2859
		[Token(Token = "0x4000B2B")]
		[FieldOffset(Offset = "0x10")]
		public float horizontalRotation;

		// Token: 0x04000B2C RID: 2860
		[Token(Token = "0x4000B2C")]
		[FieldOffset(Offset = "0x14")]
		public float verticalRotation;

		// Token: 0x04000B2D RID: 2861
		[Token(Token = "0x4000B2D")]
		public const float MinHorizontalRotation = -3.1415927f;

		// Token: 0x04000B2E RID: 2862
		[Token(Token = "0x4000B2E")]
		public const float MaxHorizontalRotation = 3.1415927f;

		// Token: 0x04000B2F RID: 2863
		[Token(Token = "0x4000B2F")]
		public const float MinVerticalRotation = -1.5707964f;

		// Token: 0x04000B30 RID: 2864
		[Token(Token = "0x4000B30")]
		public const float MaxVerticalRotation = 1.5707964f;
	}
}
