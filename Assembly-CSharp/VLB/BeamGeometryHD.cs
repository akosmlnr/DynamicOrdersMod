using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace VLB
{
	// Token: 0x02000110 RID: 272
	[Token(Token = "0x2000110")]
	[AddComponentMenu("")]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam-hd/")]
	[ExecuteInEditMode]
	public class BeamGeometryHD : BeamGeometryAbstractBase
	{
		// Token: 0x060003C7 RID: 967 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x4E09D0", Offset = "0x4DFBD0", VA = "0x1804E09D0", Slot = "4")]
		protected override VolumetricLightBeamAbstractBase GetMaster()
		{
			return null;
		}

		// Token: 0x17000094 RID: 148
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000094")]
		public bool visible
		{
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x68DC20", Offset = "0x68CE20", VA = "0x18068DC20")]
			set
			{
			}
		}

		// Token: 0x17000095 RID: 149
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000095")]
		public int sortingLayerID
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x68DB20", Offset = "0x68CD20", VA = "0x18068DB20")]
			set
			{
			}
		}

		// Token: 0x17000096 RID: 150
		// (set) Token: 0x060003CA RID: 970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000096")]
		public int sortingOrder
		{
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x68DBA0", Offset = "0x68CDA0", VA = "0x18068DBA0")]
			set
			{
			}
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x68C190", Offset = "0x68B390", VA = "0x18068C190")]
		private void OnDisable()
		{
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00003408 File Offset: 0x00001608
		[Token(Token = "0x17000097")]
		public static bool isCustomRenderPipelineSupported
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060003CD RID: 973 RVA: 0x00003420 File Offset: 0x00001620
		[Token(Token = "0x17000098")]
		private bool shouldUseGPUInstancedMaterial
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x68DA30", Offset = "0x68CC30", VA = "0x18068DA30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x68C220", Offset = "0x68B420", VA = "0x18068C220")]
		private void OnEnable()
		{
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x68BB90", Offset = "0x68AD90", VA = "0x18068BB90")]
		public void Initialize(VolumetricLightBeamHD master)
		{
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x68C490", Offset = "0x68B690", VA = "0x18068C490")]
		public void RegenerateMesh()
		{
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00003438 File Offset: 0x00001638
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x68B840", Offset = "0x68AA40", VA = "0x18068B840")]
		private Vector3 ComputeLocalMatrix()
		{
			return default(Vector3);
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00003450 File Offset: 0x00001650
		[Token(Token = "0x17000099")]
		private bool isNoiseEnabled
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x68D9E0", Offset = "0x68CBE0", VA = "0x18068D9E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00003468 File Offset: 0x00001668
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x68B9C0", Offset = "0x68ABC0", VA = "0x18068B9C0")]
		private MaterialManager.StaticPropertiesHD ComputeMaterialStaticProperties()
		{
			return default(MaterialManager.StaticPropertiesHD);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00003480 File Offset: 0x00001680
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x68B660", Offset = "0x68A860", VA = "0x18068B660")]
		private bool ApplyMaterial()
		{
			return default(bool);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x68C830", Offset = "0x68BA30", VA = "0x18068C830")]
		public void SetMaterialProp(int nameID, float value)
		{
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x68C740", Offset = "0x68B940", VA = "0x18068C740")]
		public void SetMaterialProp(int nameID, Vector4 value)
		{
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x68C5A0", Offset = "0x68B7A0", VA = "0x18068C5A0")]
		public void SetMaterialProp(int nameID, Color value)
		{
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x68C9A0", Offset = "0x68BBA0", VA = "0x18068C9A0")]
		public void SetMaterialProp(int nameID, Matrix4x4 value)
		{
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x68C910", Offset = "0x68BB10", VA = "0x18068C910")]
		public void SetMaterialProp(int nameID, Texture value)
		{
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x68C690", Offset = "0x68B890", VA = "0x18068C690")]
		public void SetMaterialProp(int nameID, BeamGeometryHD.InvalidTexture invalidTexture)
		{
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x68C010", Offset = "0x68B210", VA = "0x18068C010")]
		private void MaterialChangeStart()
		{
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x68C0C0", Offset = "0x68B2C0", VA = "0x18068C0C0")]
		private void MaterialChangeStop()
		{
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x68CAD0", Offset = "0x68BCD0", VA = "0x18068CAD0")]
		public void SetPropertyDirty(DirtyProps prop)
		{
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x68D3A0", Offset = "0x68C5A0", VA = "0x18068D3A0")]
		private void UpdateMaterialAndBounds()
		{
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x68D840", Offset = "0x68CA40", VA = "0x18068D840")]
		private void UpdateMatricesPropertiesForGPUInstancingSRP()
		{
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x68C170", Offset = "0x68B370", VA = "0x18068C170")]
		private void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
		{
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x68C450", Offset = "0x68B650", VA = "0x18068C450")]
		private void OnWillRenderObject()
		{
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x68C290", Offset = "0x68B490", VA = "0x18068C290")]
		private void OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x68CB60", Offset = "0x68BD60", VA = "0x18068CB60")]
		private void UpdateDirtyMaterialProperties()
		{
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x68D440", Offset = "0x68C640", VA = "0x18068D440")]
		private void UpdateMaterialPropertiesForCamera(Camera cam)
		{
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public BeamGeometryHD()
		{
		}

		// Token: 0x04000579 RID: 1401
		[Token(Token = "0x4000579")]
		[FieldOffset(Offset = "0x80")]
		private VolumetricLightBeamHD m_Master;

		// Token: 0x0400057A RID: 1402
		[Token(Token = "0x400057A")]
		[FieldOffset(Offset = "0x88")]
		private VolumetricCookieHD m_Cookie;

		// Token: 0x0400057B RID: 1403
		[Token(Token = "0x400057B")]
		[FieldOffset(Offset = "0x90")]
		private VolumetricShadowHD m_Shadow;

		// Token: 0x0400057C RID: 1404
		[Token(Token = "0x400057C")]
		[FieldOffset(Offset = "0x98")]
		private Camera m_CurrentCameraRenderingSRP;

		// Token: 0x0400057D RID: 1405
		[Token(Token = "0x400057D")]
		[FieldOffset(Offset = "0xA0")]
		private DirtyProps m_DirtyProps;

		// Token: 0x02000111 RID: 273
		[Token(Token = "0x2000111")]
		public enum InvalidTexture
		{
			// Token: 0x0400057F RID: 1407
			[Token(Token = "0x400057F")]
			Null,
			// Token: 0x04000580 RID: 1408
			[Token(Token = "0x4000580")]
			NoDepth
		}
	}
}
