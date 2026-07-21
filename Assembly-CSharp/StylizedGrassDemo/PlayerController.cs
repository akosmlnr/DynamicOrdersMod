using System;
using Il2CppDummyDll;
using UnityEngine;

namespace StylizedGrassDemo
{
	// Token: 0x0200016A RID: 362
	[Token(Token = "0x200016A")]
	public class PlayerController : MonoBehaviour
	{
		// Token: 0x06000693 RID: 1683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000693")]
		[Address(RVA = "0x7B4B00", Offset = "0x7B3D00", VA = "0x1807B4B00")]
		private void Start()
		{
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000694")]
		[Address(RVA = "0x7B48E0", Offset = "0x7B3AE0", VA = "0x1807B48E0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000695")]
		[Address(RVA = "0x7B4BB0", Offset = "0x7B3DB0", VA = "0x1807B4BB0")]
		private void Update()
		{
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x7B4E10", Offset = "0x7B4010", VA = "0x1807B4E10")]
		public PlayerController()
		{
		}

		// Token: 0x04000755 RID: 1877
		[Token(Token = "0x4000755")]
		[FieldOffset(Offset = "0x20")]
		public Camera cam;

		// Token: 0x04000756 RID: 1878
		[Token(Token = "0x4000756")]
		[FieldOffset(Offset = "0x28")]
		private float speed;

		// Token: 0x04000757 RID: 1879
		[Token(Token = "0x4000757")]
		[FieldOffset(Offset = "0x2C")]
		private float jumpForce;

		// Token: 0x04000758 RID: 1880
		[Token(Token = "0x4000758")]
		[FieldOffset(Offset = "0x30")]
		private Rigidbody rb;

		// Token: 0x04000759 RID: 1881
		[Token(Token = "0x4000759")]
		[FieldOffset(Offset = "0x38")]
		private bool isGrounded;

		// Token: 0x0400075A RID: 1882
		[Token(Token = "0x400075A")]
		[FieldOffset(Offset = "0x40")]
		public ParticleSystem landBendEffect;

		// Token: 0x0400075B RID: 1883
		[Token(Token = "0x400075B")]
		[FieldOffset(Offset = "0x48")]
		private RaycastHit raycastHit;
	}
}
