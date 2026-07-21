using System;
using Il2CppDummyDll;
using UnityEngine;

namespace StylizedGrassDemo
{
	// Token: 0x02000169 RID: 361
	[Token(Token = "0x2000169")]
	public class OrbitCamera : MonoBehaviour
	{
		// Token: 0x06000690 RID: 1680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000690")]
		[Address(RVA = "0x7B4640", Offset = "0x7B3840", VA = "0x1807B4640")]
		private void Start()
		{
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x7B40B0", Offset = "0x7B32B0", VA = "0x1807B40B0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000692")]
		[Address(RVA = "0x7B4740", Offset = "0x7B3940", VA = "0x1807B4740")]
		public OrbitCamera()
		{
		}

		// Token: 0x04000749 RID: 1865
		[Token(Token = "0x4000749")]
		[FieldOffset(Offset = "0x20")]
		[Space]
		public Transform pivot;

		// Token: 0x0400074A RID: 1866
		[Token(Token = "0x400074A")]
		[FieldOffset(Offset = "0x28")]
		[Space]
		public bool enableMouse;

		// Token: 0x0400074B RID: 1867
		[Token(Token = "0x400074B")]
		[FieldOffset(Offset = "0x2C")]
		public float idleRotationSpeed;

		// Token: 0x0400074C RID: 1868
		[Token(Token = "0x400074C")]
		[FieldOffset(Offset = "0x30")]
		public float lookSmoothSpeed;

		// Token: 0x0400074D RID: 1869
		[Token(Token = "0x400074D")]
		[FieldOffset(Offset = "0x34")]
		public float moveSmoothSpeed;

		// Token: 0x0400074E RID: 1870
		[Token(Token = "0x400074E")]
		[FieldOffset(Offset = "0x38")]
		public float scrollSmoothSpeed;

		// Token: 0x0400074F RID: 1871
		[Token(Token = "0x400074F")]
		[FieldOffset(Offset = "0x40")]
		private Transform cam;

		// Token: 0x04000750 RID: 1872
		[Token(Token = "0x4000750")]
		[FieldOffset(Offset = "0x48")]
		private float cameraRotSide;

		// Token: 0x04000751 RID: 1873
		[Token(Token = "0x4000751")]
		[FieldOffset(Offset = "0x4C")]
		private float cameraRotUp;

		// Token: 0x04000752 RID: 1874
		[Token(Token = "0x4000752")]
		[FieldOffset(Offset = "0x50")]
		private float cameraRotSideCur;

		// Token: 0x04000753 RID: 1875
		[Token(Token = "0x4000753")]
		[FieldOffset(Offset = "0x54")]
		private float cameraRotUpCur;

		// Token: 0x04000754 RID: 1876
		[Token(Token = "0x4000754")]
		[FieldOffset(Offset = "0x58")]
		private float distance;
	}
}
