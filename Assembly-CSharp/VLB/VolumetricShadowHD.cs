using System;
using Il2CppDummyDll;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000118 RID: 280
	[Token(Token = "0x2000118")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-shadow-hd/")]
	[RequireComponent(typeof(VolumetricLightBeamHD))]
	public class VolumetricShadowHD : MonoBehaviour
	{
		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x00003AC8 File Offset: 0x00001CC8
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D2")]
		public float strength
		{
			[Token(Token = "0x6000477")]
			[Address(RVA = "0x495AF0", Offset = "0x494CF0", VA = "0x180495AF0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000478")]
			[Address(RVA = "0x6A22C0", Offset = "0x6A14C0", VA = "0x1806A22C0")]
			set
			{
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x00003AE0 File Offset: 0x00001CE0
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D3")]
		public ShadowUpdateRate updateRate
		{
			[Token(Token = "0x6000479")]
			[Address(RVA = "0x49B290", Offset = "0x49A490", VA = "0x18049B290")]
			get
			{
				return (ShadowUpdateRate)0;
			}
			[Token(Token = "0x600047A")]
			[Address(RVA = "0x49B2B0", Offset = "0x49A4B0", VA = "0x18049B2B0")]
			set
			{
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x00003AF8 File Offset: 0x00001CF8
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D4")]
		public int waitXFrames
		{
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x492960", Offset = "0x491B60", VA = "0x180492960")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x4929B0", Offset = "0x491BB0", VA = "0x1804929B0")]
			set
			{
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x00003B10 File Offset: 0x00001D10
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D5")]
		public LayerMask layerMask
		{
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x6A20F0", Offset = "0x6A12F0", VA = "0x1806A20F0")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x6A22B0", Offset = "0x6A14B0", VA = "0x1806A22B0")]
			set
			{
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x00003B28 File Offset: 0x00001D28
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D6")]
		public bool useOcclusionCulling
		{
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x496D60", Offset = "0x495F60", VA = "0x180496D60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x6A22E0", Offset = "0x6A14E0", VA = "0x1806A22E0")]
			set
			{
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x00003B40 File Offset: 0x00001D40
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D7")]
		public int depthMapResolution
		{
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x4CBFB0", Offset = "0x4CB1B0", VA = "0x1804CBFB0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x6A2100", Offset = "0x6A1300", VA = "0x1806A2100")]
			set
			{
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x6A1AA0", Offset = "0x6A0CA0", VA = "0x1806A1AA0")]
		public void ProcessOcclusionManually()
		{
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x6A1EC0", Offset = "0x6A10C0", VA = "0x1806A1EC0")]
		public void UpdateDepthCameraProperties()
		{
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x6A1AB0", Offset = "0x6A0CB0", VA = "0x1806A1AB0")]
		private void ProcessOcclusion(VolumetricShadowHD.ProcessOcclusionSource source)
		{
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x6A0F30", Offset = "0x6A0130", VA = "0x1806A0F30")]
		public static void ApplyMaterialProperties(VolumetricShadowHD instance, BeamGeometryHD geom)
		{
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x6A1210", Offset = "0x6A0410", VA = "0x1806A1210")]
		private void Awake()
		{
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x6A1890", Offset = "0x6A0A90", VA = "0x1806A1890")]
		private void OnEnable()
		{
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x6A1800", Offset = "0x6A0A00", VA = "0x1806A1800")]
		private void OnDisable()
		{
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x6A1260", Offset = "0x6A0460", VA = "0x1806A1260")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x6A1A70", Offset = "0x6A0C70", VA = "0x1806A1A70")]
		private void ProcessOcclusionInternal()
		{
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x6A17C0", Offset = "0x6A09C0", VA = "0x1806A17C0")]
		private void OnBeamEnabled()
		{
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x6A1980", Offset = "0x6A0B80", VA = "0x1806A1980")]
		public void OnWillCameraRenderThisBeam(Camera cam, BeamGeometryHD beamGeom)
		{
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x6A1F60", Offset = "0x6A1160", VA = "0x1806A1F60")]
		private void Update()
		{
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x6A1CA0", Offset = "0x6A0EA0", VA = "0x1806A1CA0")]
		private void UpdateDepthCameraPropertiesAccordingToBeam()
		{
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x6A13C0", Offset = "0x6A05C0", VA = "0x1806A13C0")]
		private void InstantiateOrActivateDepthCamera()
		{
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x6A1260", Offset = "0x6A0460", VA = "0x1806A1260")]
		private void DestroyDepthCamera()
		{
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x6A1920", Offset = "0x6A0B20", VA = "0x1806A1920")]
		private void OnValidateProperties()
		{
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x6A1C20", Offset = "0x6A0E20", VA = "0x1806A1C20")]
		private void SetDirty()
		{
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x00003B58 File Offset: 0x00001D58
		[Token(Token = "0x170000D8")]
		public int _INTERNAL_LastFrameRendered
		{
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x54A4F0", Offset = "0x5496F0", VA = "0x18054A4F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x6A2060", Offset = "0x6A1260", VA = "0x1806A2060")]
		public VolumetricShadowHD()
		{
		}

		// Token: 0x040005B2 RID: 1458
		[Token(Token = "0x40005B2")]
		public const string ClassName = "VolumetricShadowHD";

		// Token: 0x040005B3 RID: 1459
		[Token(Token = "0x40005B3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_Strength;

		// Token: 0x040005B4 RID: 1460
		[Token(Token = "0x40005B4")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ShadowUpdateRate m_UpdateRate;

		// Token: 0x040005B5 RID: 1461
		[Token(Token = "0x40005B5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int m_WaitXFrames;

		// Token: 0x040005B6 RID: 1462
		[Token(Token = "0x40005B6")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private LayerMask m_LayerMask;

		// Token: 0x040005B7 RID: 1463
		[Token(Token = "0x40005B7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_UseOcclusionCulling;

		// Token: 0x040005B8 RID: 1464
		[Token(Token = "0x40005B8")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int m_DepthMapResolution;

		// Token: 0x040005B9 RID: 1465
		[Token(Token = "0x40005B9")]
		[FieldOffset(Offset = "0x38")]
		private VolumetricLightBeamHD m_Master;

		// Token: 0x040005BA RID: 1466
		[Token(Token = "0x40005BA")]
		[FieldOffset(Offset = "0x40")]
		private TransformUtils.Packed m_TransformPacked;

		// Token: 0x040005BB RID: 1467
		[Token(Token = "0x40005BB")]
		[FieldOffset(Offset = "0x68")]
		private int m_LastFrameRendered;

		// Token: 0x040005BC RID: 1468
		[Token(Token = "0x40005BC")]
		[FieldOffset(Offset = "0x70")]
		private Camera m_DepthCamera;

		// Token: 0x040005BD RID: 1469
		[Token(Token = "0x40005BD")]
		[FieldOffset(Offset = "0x78")]
		private bool m_NeedToUpdateOcclusionNextFrame;

		// Token: 0x040005BE RID: 1470
		[Token(Token = "0x40005BE")]
		[FieldOffset(Offset = "0x0")]
		public static bool _INTERNAL_ApplyRandomFrameOffset;

		// Token: 0x02000119 RID: 281
		[Token(Token = "0x2000119")]
		private enum ProcessOcclusionSource
		{
			// Token: 0x040005C0 RID: 1472
			[Token(Token = "0x40005C0")]
			RenderLoop,
			// Token: 0x040005C1 RID: 1473
			[Token(Token = "0x40005C1")]
			OnEnable,
			// Token: 0x040005C2 RID: 1474
			[Token(Token = "0x40005C2")]
			EditorUpdate,
			// Token: 0x040005C3 RID: 1475
			[Token(Token = "0x40005C3")]
			User
		}
	}
}
