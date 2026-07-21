using System;
using Il2CppDummyDll;
using UnityEngine;

namespace LiquidVolumeFX
{
	// Token: 0x0200017B RID: 379
	[Token(Token = "0x200017B")]
	public class SpotlightAnimator : MonoBehaviour
	{
		// Token: 0x060006D8 RID: 1752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x7B7BB0", Offset = "0x7B6DB0", VA = "0x1807B7BB0")]
		private void Awake()
		{
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x7B7C20", Offset = "0x7B6E20", VA = "0x1807B7C20")]
		private void Update()
		{
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x7B7EA0", Offset = "0x7B70A0", VA = "0x1807B7EA0")]
		public SpotlightAnimator()
		{
		}

		// Token: 0x04000797 RID: 1943
		[Token(Token = "0x4000797")]
		[FieldOffset(Offset = "0x20")]
		public float lightOnDelay;

		// Token: 0x04000798 RID: 1944
		[Token(Token = "0x4000798")]
		[FieldOffset(Offset = "0x24")]
		public float targetIntensity;

		// Token: 0x04000799 RID: 1945
		[Token(Token = "0x4000799")]
		[FieldOffset(Offset = "0x28")]
		public float initialIntensity;

		// Token: 0x0400079A RID: 1946
		[Token(Token = "0x400079A")]
		[FieldOffset(Offset = "0x2C")]
		public float duration;

		// Token: 0x0400079B RID: 1947
		[Token(Token = "0x400079B")]
		[FieldOffset(Offset = "0x30")]
		public float nextColorInterval;

		// Token: 0x0400079C RID: 1948
		[Token(Token = "0x400079C")]
		[FieldOffset(Offset = "0x34")]
		public float colorChangeDuration;

		// Token: 0x0400079D RID: 1949
		[Token(Token = "0x400079D")]
		[FieldOffset(Offset = "0x38")]
		private Light spotLight;

		// Token: 0x0400079E RID: 1950
		[Token(Token = "0x400079E")]
		[FieldOffset(Offset = "0x40")]
		private float lastColorChange;

		// Token: 0x0400079F RID: 1951
		[Token(Token = "0x400079F")]
		[FieldOffset(Offset = "0x44")]
		private float colorChangeStarted;

		// Token: 0x040007A0 RID: 1952
		[Token(Token = "0x40007A0")]
		[FieldOffset(Offset = "0x48")]
		private Color currentColor;

		// Token: 0x040007A1 RID: 1953
		[Token(Token = "0x40007A1")]
		[FieldOffset(Offset = "0x58")]
		private Color nextColor;

		// Token: 0x040007A2 RID: 1954
		[Token(Token = "0x40007A2")]
		[FieldOffset(Offset = "0x68")]
		private bool changingColor;
	}
}
