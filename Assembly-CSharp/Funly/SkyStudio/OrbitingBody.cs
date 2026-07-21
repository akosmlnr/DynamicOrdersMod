using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000196 RID: 406
	[Token(Token = "0x2000196")]
	[ExecuteInEditMode]
	public class OrbitingBody : MonoBehaviour
	{
		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001A4")]
		public Transform positionTransform
		{
			[Token(Token = "0x600080C")]
			[Address(RVA = "0x8D9730", Offset = "0x8D8930", VA = "0x1808D9730")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001A5")]
		public RotateBody rotateBody
		{
			[Token(Token = "0x600080D")]
			[Address(RVA = "0x8D97E0", Offset = "0x8D89E0", VA = "0x1808D97E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600080F RID: 2063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A6")]
		public SpherePoint Point
		{
			[Token(Token = "0x600080E")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			get
			{
				return null;
			}
			[Token(Token = "0x600080F")]
			[Address(RVA = "0x8D9980", Offset = "0x8D8B80", VA = "0x1808D9980")]
			set
			{
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x000058F8 File Offset: 0x00003AF8
		[Token(Token = "0x170001A7")]
		public Vector3 BodyGlobalDirection
		{
			[Token(Token = "0x6000810")]
			[Address(RVA = "0x4D86A0", Offset = "0x4D78A0", VA = "0x1804D86A0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001A8")]
		public Light BodyLight
		{
			[Token(Token = "0x6000811")]
			[Address(RVA = "0x8D9600", Offset = "0x8D8800", VA = "0x1808D9600")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000812")]
		[Address(RVA = "0x8D9520", Offset = "0x8D8720", VA = "0x1808D9520")]
		public void ResetOrbit()
		{
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000813")]
		[Address(RVA = "0x8D93E0", Offset = "0x8D85E0", VA = "0x1808D93E0")]
		public void LayoutOribit()
		{
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000814")]
		[Address(RVA = "0x8D9510", Offset = "0x8D8710", VA = "0x1808D9510")]
		private void OnValidate()
		{
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000815")]
		[Address(RVA = "0x8D9550", Offset = "0x8D8750", VA = "0x1808D9550")]
		public OrbitingBody()
		{
		}

		// Token: 0x040008E7 RID: 2279
		[Token(Token = "0x40008E7")]
		[FieldOffset(Offset = "0x20")]
		private Transform m_PositionTransform;

		// Token: 0x040008E8 RID: 2280
		[Token(Token = "0x40008E8")]
		[FieldOffset(Offset = "0x28")]
		private RotateBody m_RotateBody;

		// Token: 0x040008E9 RID: 2281
		[Token(Token = "0x40008E9")]
		[FieldOffset(Offset = "0x30")]
		private SpherePoint m_SpherePoint;

		// Token: 0x040008EA RID: 2282
		[Token(Token = "0x40008EA")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 m_CachedWorldDirection;

		// Token: 0x040008EB RID: 2283
		[Token(Token = "0x40008EB")]
		[FieldOffset(Offset = "0x48")]
		private Light m_BodyLight;
	}
}
