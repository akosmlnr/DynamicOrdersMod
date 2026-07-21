using System;
using Il2CppDummyDll;
using UnityEngine;

namespace StylizedGrassDemo
{
	// Token: 0x02000168 RID: 360
	[Token(Token = "0x2000168")]
	public class MoveInCircle : MonoBehaviour
	{
		// Token: 0x0600068D RID: 1677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600068D")]
		[Address(RVA = "0x7B3FC0", Offset = "0x7B31C0", VA = "0x1807B3FC0")]
		private void Update()
		{
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600068E")]
		[Address(RVA = "0x7B3FC0", Offset = "0x7B31C0", VA = "0x1807B3FC0")]
		private void Move()
		{
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600068F")]
		[Address(RVA = "0x7B4090", Offset = "0x7B3290", VA = "0x1807B4090")]
		public MoveInCircle()
		{
		}

		// Token: 0x04000746 RID: 1862
		[Token(Token = "0x4000746")]
		[FieldOffset(Offset = "0x20")]
		public float radius;

		// Token: 0x04000747 RID: 1863
		[Token(Token = "0x4000747")]
		[FieldOffset(Offset = "0x24")]
		public float speed;

		// Token: 0x04000748 RID: 1864
		[Token(Token = "0x4000748")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 offset;
	}
}
