using System;
using Il2CppDummyDll;
using UnityEngine;

namespace LiquidVolumeFX
{
	// Token: 0x02000179 RID: 377
	[Token(Token = "0x2000179")]
	public class FlaskAnimator : MonoBehaviour
	{
		// Token: 0x060006D2 RID: 1746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x7A5480", Offset = "0x7A4680", VA = "0x1807A5480")]
		private void Awake()
		{
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x7A5500", Offset = "0x7A4700", VA = "0x1807A5500")]
		private void Update()
		{
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x7A58C0", Offset = "0x7A4AC0", VA = "0x1807A58C0")]
		public FlaskAnimator()
		{
		}

		// Token: 0x04000785 RID: 1925
		[Token(Token = "0x4000785")]
		[FieldOffset(Offset = "0x20")]
		public float speed;

		// Token: 0x04000786 RID: 1926
		[Token(Token = "0x4000786")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 initialPosition;

		// Token: 0x04000787 RID: 1927
		[Token(Token = "0x4000787")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 finalPosition;

		// Token: 0x04000788 RID: 1928
		[Token(Token = "0x4000788")]
		[FieldOffset(Offset = "0x3C")]
		public float duration;

		// Token: 0x04000789 RID: 1929
		[Token(Token = "0x4000789")]
		[FieldOffset(Offset = "0x40")]
		public float delay;

		// Token: 0x0400078A RID: 1930
		[Token(Token = "0x400078A")]
		[FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float level;

		// Token: 0x0400078B RID: 1931
		[Token(Token = "0x400078B")]
		[FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float minRange;

		// Token: 0x0400078C RID: 1932
		[Token(Token = "0x400078C")]
		[FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float maxRange;

		// Token: 0x0400078D RID: 1933
		[Token(Token = "0x400078D")]
		[FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		public float acceleration;

		// Token: 0x0400078E RID: 1934
		[Token(Token = "0x400078E")]
		[FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float rotationSpeed;

		// Token: 0x0400078F RID: 1935
		[Token(Token = "0x400078F")]
		[FieldOffset(Offset = "0x58")]
		[Range(0f, 2f)]
		public float alphaDuration;

		// Token: 0x04000790 RID: 1936
		[Token(Token = "0x4000790")]
		[FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float finalRefractionBlur;

		// Token: 0x04000791 RID: 1937
		[Token(Token = "0x4000791")]
		[FieldOffset(Offset = "0x60")]
		private LiquidVolume liquid;

		// Token: 0x04000792 RID: 1938
		[Token(Token = "0x4000792")]
		[FieldOffset(Offset = "0x68")]
		private float direction;
	}
}
