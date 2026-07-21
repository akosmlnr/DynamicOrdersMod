using System;
using Il2CppDummyDll;
using UnityEngine;

namespace LiquidVolumeFX
{
	// Token: 0x02000174 RID: 372
	[Token(Token = "0x2000174")]
	public class CubeSpawn : MonoBehaviour
	{
		// Token: 0x060006C6 RID: 1734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x7A02C0", Offset = "0x79F4C0", VA = "0x1807A02C0")]
		private void Start()
		{
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x7A0640", Offset = "0x79F840", VA = "0x1807A0640")]
		public CubeSpawn()
		{
		}

		// Token: 0x0400076C RID: 1900
		[Token(Token = "0x400076C")]
		[FieldOffset(Offset = "0x20")]
		public int instances;

		// Token: 0x0400076D RID: 1901
		[Token(Token = "0x400076D")]
		[FieldOffset(Offset = "0x24")]
		public float radius;

		// Token: 0x0400076E RID: 1902
		[Token(Token = "0x400076E")]
		[FieldOffset(Offset = "0x28")]
		public float jitter;

		// Token: 0x0400076F RID: 1903
		[Token(Token = "0x400076F")]
		[FieldOffset(Offset = "0x2C")]
		public float expansion;

		// Token: 0x04000770 RID: 1904
		[Token(Token = "0x4000770")]
		[FieldOffset(Offset = "0x30")]
		public float laps;
	}
}
