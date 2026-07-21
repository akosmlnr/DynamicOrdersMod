using System;
using Il2CppDummyDll;
using UnityEngine;

namespace LiquidVolumeFX
{
	// Token: 0x02000175 RID: 373
	[Token(Token = "0x2000175")]
	public class RandomRotation : MonoBehaviour
	{
		// Token: 0x060006C8 RID: 1736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x7B5A10", Offset = "0x7B4C10", VA = "0x1807B5A10")]
		private void Start()
		{
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x7B5A30", Offset = "0x7B4C30", VA = "0x1807B5A30")]
		private void Update()
		{
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x7B5B30", Offset = "0x7B4D30", VA = "0x1807B5B30")]
		public RandomRotation()
		{
		}

		// Token: 0x04000771 RID: 1905
		[Token(Token = "0x4000771")]
		[FieldOffset(Offset = "0x20")]
		[Range(1f, 50f)]
		public float speed;

		// Token: 0x04000772 RID: 1906
		[Token(Token = "0x4000772")]
		[FieldOffset(Offset = "0x24")]
		[Range(1f, 30f)]
		public float randomChangeInterval;

		// Token: 0x04000773 RID: 1907
		[Token(Token = "0x4000773")]
		[FieldOffset(Offset = "0x28")]
		private float lastTime;

		// Token: 0x04000774 RID: 1908
		[Token(Token = "0x4000774")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 v;

		// Token: 0x04000775 RID: 1909
		[Token(Token = "0x4000775")]
		[FieldOffset(Offset = "0x38")]
		private float randomization;
	}
}
