using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace VLB
{
	// Token: 0x0200013B RID: 315
	[Token(Token = "0x200013B")]
	[AddComponentMenu("")]
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam-sd/")]
	public class BeamGeometrySD : BeamGeometryAbstractBase, MaterialModifier.Interface
	{
		// Token: 0x06000503 RID: 1283 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x4E09D0", Offset = "0x4DFBD0", VA = "0x1804E09D0", Slot = "4")]
		protected override VolumetricLightBeamAbstractBase GetMaster()
		{
			return null;
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x00004098 File Offset: 0x00002298
		// (set) Token: 0x06000505 RID: 1285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F2")]
		private bool visible
		{
			[Token(Token = "0x6000504")]
			[Address(RVA = "0x690E20", Offset = "0x690020", VA = "0x180690E20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000505")]
			[Address(RVA = "0x690E80", Offset = "0x690080", VA = "0x180690E80")]
			set
			{
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x000040B0 File Offset: 0x000022B0
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F3")]
		public int sortingLayerID
		{
			[Token(Token = "0x6000506")]
			[Address(RVA = "0x690DE0", Offset = "0x68FFE0", VA = "0x180690DE0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000507")]
			[Address(RVA = "0x690E40", Offset = "0x690040", VA = "0x180690E40")]
			set
			{
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x000040C8 File Offset: 0x000022C8
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F4")]
		public int sortingOrder
		{
			[Token(Token = "0x6000508")]
			[Address(RVA = "0x690E00", Offset = "0x690000", VA = "0x180690E00")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x690E60", Offset = "0x690060", VA = "0x180690E60")]
			set
			{
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x000040E0 File Offset: 0x000022E0
		[Token(Token = "0x170000F5")]
		public bool _INTERNAL_IsFadeOutCoroutineRunning
		{
			[Token(Token = "0x600050A")]
			[Address(RVA = "0x690C50", Offset = "0x68FE50", VA = "0x180690C50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x000040F8 File Offset: 0x000022F8
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x68E250", Offset = "0x68D450", VA = "0x18068E250")]
		private float ComputeFadeOutFactor(Transform camTransform)
		{
			return 0f;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x68DF70", Offset = "0x68D170", VA = "0x18068DF70")]
		private IEnumerator CoUpdateFadeOut()
		{
			return null;
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x68DFE0", Offset = "0x68D1E0", VA = "0x18068DFE0")]
		private void ComputeFadeOutFactor()
		{
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x68F3C0", Offset = "0x68E5C0", VA = "0x18068F3C0")]
		private void SetFadeOutFactorProp(float value)
		{
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x68F940", Offset = "0x68EB40", VA = "0x18068F940")]
		private void StopFadeOutCoroutine()
		{
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x68F1C0", Offset = "0x68E3C0", VA = "0x18068F1C0")]
		public void RestartFadeOutCoroutine()
		{
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x68EC70", Offset = "0x68DE70", VA = "0x18068EC70")]
		public void OnMasterEnable()
		{
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x68EC10", Offset = "0x68DE10", VA = "0x18068EC10")]
		public void OnMasterDisable()
		{
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x68EB00", Offset = "0x68DD00", VA = "0x18068EB00")]
		private void OnDisable()
		{
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x00004110 File Offset: 0x00002310
		[Token(Token = "0x170000F6")]
		public static bool isCustomRenderPipelineSupported
		{
			[Token(Token = "0x6000514")]
			[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x00004128 File Offset: 0x00002328
		[Token(Token = "0x170000F7")]
		private bool shouldUseGPUInstancedMaterial
		{
			[Token(Token = "0x6000515")]
			[Address(RVA = "0x690D50", Offset = "0x68FF50", VA = "0x180690D50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x68EB90", Offset = "0x68DD90", VA = "0x18068EB90")]
		private void OnEnable()
		{
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000517")]
		[Address(RVA = "0x68E5F0", Offset = "0x68D7F0", VA = "0x18068E5F0")]
		public void Initialize(VolumetricLightBeamSD master)
		{
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x68EE70", Offset = "0x68E070", VA = "0x18068EE70")]
		public void RegenerateMesh(bool masterEnabled)
		{
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00004140 File Offset: 0x00002340
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x68E390", Offset = "0x68D590", VA = "0x18068E390")]
		private Vector3 ComputeLocalMatrix()
		{
			return default(Vector3);
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x00004158 File Offset: 0x00002358
		[Token(Token = "0x170000F8")]
		private bool isNoiseEnabled
		{
			[Token(Token = "0x600051A")]
			[Address(RVA = "0x690CF0", Offset = "0x68FEF0", VA = "0x180690CF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x00004170 File Offset: 0x00002370
		[Token(Token = "0x170000F9")]
		private bool isDepthBlendEnabled
		{
			[Token(Token = "0x600051B")]
			[Address(RVA = "0x690C60", Offset = "0x68FE60", VA = "0x180690C60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00004188 File Offset: 0x00002388
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x68E4B0", Offset = "0x68D6B0", VA = "0x18068E4B0")]
		private MaterialManager.StaticPropertiesSD ComputeMaterialStaticProperties()
		{
			return default(MaterialManager.StaticPropertiesSD);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x000041A0 File Offset: 0x000023A0
		[Token(Token = "0x600051D")]
		[Address(RVA = "0x68DCB0", Offset = "0x68CEB0", VA = "0x18068DCB0")]
		private bool ApplyMaterial()
		{
			return default(bool);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600051E")]
		[Address(RVA = "0x68F480", Offset = "0x68E680", VA = "0x18068F480", Slot = "5")]
		public void SetMaterialProp(int nameID, float value)
		{
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x68F780", Offset = "0x68E980", VA = "0x18068F780", Slot = "6")]
		public void SetMaterialProp(int nameID, Vector4 value)
		{
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x68F690", Offset = "0x68E890", VA = "0x18068F690", Slot = "7")]
		public void SetMaterialProp(int nameID, Color value)
		{
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x68F560", Offset = "0x68E760", VA = "0x18068F560", Slot = "8")]
		public void SetMaterialProp(int nameID, Matrix4x4 value)
		{
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x68F870", Offset = "0x68EA70", VA = "0x18068F870", Slot = "9")]
		public void SetMaterialProp(int nameID, Texture value)
		{
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000523")]
		[Address(RVA = "0x68E980", Offset = "0x68DB80", VA = "0x18068E980")]
		private void MaterialChangeStart()
		{
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000524")]
		[Address(RVA = "0x68EA30", Offset = "0x68DC30", VA = "0x18068EA30")]
		private void MaterialChangeStop()
		{
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x68F2F0", Offset = "0x68E4F0", VA = "0x18068F2F0")]
		public void SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x68FCE0", Offset = "0x68EEE0", VA = "0x18068FCE0")]
		public void UpdateMaterialAndBounds()
		{
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x690AC0", Offset = "0x68FCC0", VA = "0x180690AC0")]
		private void UpdateMatricesPropertiesForGPUInstancingSRP()
		{
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x68EAE0", Offset = "0x68DCE0", VA = "0x18068EAE0")]
		private void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
		{
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000529")]
		[Address(RVA = "0x68ED80", Offset = "0x68DF80", VA = "0x18068ED80")]
		private void OnWillRenderObject()
		{
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x68ECB0", Offset = "0x68DEB0", VA = "0x18068ECB0")]
		private void OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x68F990", Offset = "0x68EB90", VA = "0x18068F990")]
		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052C")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public BeamGeometrySD()
		{
		}

		// Token: 0x04000622 RID: 1570
		[Token(Token = "0x4000622")]
		[FieldOffset(Offset = "0x80")]
		private VolumetricLightBeamSD m_Master;

		// Token: 0x04000623 RID: 1571
		[Token(Token = "0x4000623")]
		[FieldOffset(Offset = "0x88")]
		private MeshType m_CurrentMeshType;

		// Token: 0x04000624 RID: 1572
		[Token(Token = "0x4000624")]
		[FieldOffset(Offset = "0x90")]
		private MaterialModifier.Callback m_MaterialModifierCallback;

		// Token: 0x04000625 RID: 1573
		[Token(Token = "0x4000625")]
		[FieldOffset(Offset = "0x98")]
		private Coroutine m_CoFadeOut;

		// Token: 0x04000626 RID: 1574
		[Token(Token = "0x4000626")]
		[FieldOffset(Offset = "0xA0")]
		private Camera m_CurrentCameraRenderingSRP;
	}
}
