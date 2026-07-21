using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace VLB
{
	// Token: 0x020000E2 RID: 226
	[Token(Token = "0x20000E2")]
	public abstract class BeamGeometryAbstractBase : MonoBehaviour
	{
		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000359 RID: 857 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600035A RID: 858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007C")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600035B RID: 859 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600035C RID: 860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007D")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600035D RID: 861 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600035E RID: 862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007E")]
		public Mesh coneMesh
		{
			[Token(Token = "0x600035D")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600035F RID: 863
		[Token(Token = "0x600035F")]
		protected abstract VolumetricLightBeamAbstractBase GetMaster();

		// Token: 0x06000360 RID: 864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x68B4E0", Offset = "0x68A6E0", VA = "0x18068B4E0")]
		private void Start()
		{
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x68B5C0", Offset = "0x68A7C0", VA = "0x18068B5C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x68B4E0", Offset = "0x68A6E0", VA = "0x18068B4E0")]
		private void DestroyInvalidOwner()
		{
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x68B450", Offset = "0x68A650", VA = "0x18068B450")]
		public static void DestroyBeamGeometryGameObject(BeamGeometryAbstractBase beamGeom)
		{
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		protected BeamGeometryAbstractBase()
		{
		}

		// Token: 0x04000422 RID: 1058
		[Token(Token = "0x4000422")]
		[FieldOffset(Offset = "0x38")]
		protected Matrix4x4 m_ColorGradientMatrix;

		// Token: 0x04000423 RID: 1059
		[Token(Token = "0x4000423")]
		[FieldOffset(Offset = "0x78")]
		protected Material m_CustomMaterial;
	}
}
