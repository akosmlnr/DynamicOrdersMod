using System;
using Il2CppDummyDll;
using UnityEngine;

namespace VLB_Samples
{
	// Token: 0x02000162 RID: 354
	[Token(Token = "0x2000162")]
	public class FreeCameraController : MonoBehaviour
	{
		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x00004F08 File Offset: 0x00003108
		// (set) Token: 0x0600067C RID: 1660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000149")]
		private bool useMouseView
		{
			[Token(Token = "0x600067B")]
			[Address(RVA = "0x4943C0", Offset = "0x4935C0", VA = "0x1804943C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600067C")]
			[Address(RVA = "0x7A6270", Offset = "0x7A5470", VA = "0x1807A6270")]
			set
			{
			}
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600067D")]
		[Address(RVA = "0x7A59C0", Offset = "0x7A4BC0", VA = "0x1807A59C0")]
		private void Start()
		{
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600067E")]
		[Address(RVA = "0x7A5AB0", Offset = "0x7A4CB0", VA = "0x1807A5AB0")]
		private void Update()
		{
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600067F")]
		[Address(RVA = "0x7A6240", Offset = "0x7A5440", VA = "0x1807A6240")]
		public FreeCameraController()
		{
		}

		// Token: 0x04000718 RID: 1816
		[Token(Token = "0x4000718")]
		[FieldOffset(Offset = "0x20")]
		public float cameraSensitivity;

		// Token: 0x04000719 RID: 1817
		[Token(Token = "0x4000719")]
		[FieldOffset(Offset = "0x24")]
		public float speedNormal;

		// Token: 0x0400071A RID: 1818
		[Token(Token = "0x400071A")]
		[FieldOffset(Offset = "0x28")]
		public float speedFactorSlow;

		// Token: 0x0400071B RID: 1819
		[Token(Token = "0x400071B")]
		[FieldOffset(Offset = "0x2C")]
		public float speedFactorFast;

		// Token: 0x0400071C RID: 1820
		[Token(Token = "0x400071C")]
		[FieldOffset(Offset = "0x30")]
		public float speedClimb;

		// Token: 0x0400071D RID: 1821
		[Token(Token = "0x400071D")]
		[FieldOffset(Offset = "0x34")]
		private float rotationH;

		// Token: 0x0400071E RID: 1822
		[Token(Token = "0x400071E")]
		[FieldOffset(Offset = "0x38")]
		private float rotationV;

		// Token: 0x0400071F RID: 1823
		[Token(Token = "0x400071F")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_UseMouseView;
	}
}
