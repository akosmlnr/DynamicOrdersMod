using System;
using Il2CppDummyDll;
using UnityEngine;

namespace VolumetricFogAndMist2.Demos
{
	// Token: 0x02000165 RID: 357
	[Token(Token = "0x2000165")]
	public class CapsuleController : MonoBehaviour
	{
		// Token: 0x06000684 RID: 1668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x79FD50", Offset = "0x79EF50", VA = "0x18079FD50")]
		private void Update()
		{
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x79FF70", Offset = "0x79F170", VA = "0x18079FF70")]
		public CapsuleController()
		{
		}

		// Token: 0x04000727 RID: 1831
		[Token(Token = "0x4000727")]
		[FieldOffset(Offset = "0x20")]
		public VolumetricFog fogVolume;

		// Token: 0x04000728 RID: 1832
		[Token(Token = "0x4000728")]
		[FieldOffset(Offset = "0x28")]
		public float moveSpeed;

		// Token: 0x04000729 RID: 1833
		[Token(Token = "0x4000729")]
		[FieldOffset(Offset = "0x2C")]
		public float fogHoleRadius;

		// Token: 0x0400072A RID: 1834
		[Token(Token = "0x400072A")]
		[FieldOffset(Offset = "0x30")]
		public float clearDuration;

		// Token: 0x0400072B RID: 1835
		[Token(Token = "0x400072B")]
		[FieldOffset(Offset = "0x34")]
		public float distanceCheck;

		// Token: 0x0400072C RID: 1836
		[Token(Token = "0x400072C")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 lastPos;
	}
}
