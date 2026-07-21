using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace VLB
{
	// Token: 0x020000E3 RID: 227
	[Token(Token = "0x20000E3")]
	[HelpURL("http://saladgamer.com/vlb-doc/config/")]
	public class Config : ScriptableObject
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000365 RID: 869 RVA: 0x00003240 File Offset: 0x00001440
		// (set) Token: 0x06000366 RID: 870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007F")]
		public RenderPipeline renderPipeline
		{
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x4A63B0", Offset = "0x4A55B0", VA = "0x1804A63B0")]
			get
			{
				return RenderPipeline.BuiltIn;
			}
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x693100", Offset = "0x692300", VA = "0x180693100")]
			set
			{
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000367 RID: 871 RVA: 0x00003258 File Offset: 0x00001458
		// (set) Token: 0x06000368 RID: 872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000080")]
		public RenderingMode renderingMode
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x4CBFB0", Offset = "0x4CB1B0", VA = "0x1804CBFB0")]
			get
			{
				return RenderingMode.MultiPass;
			}
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x693160", Offset = "0x692360", VA = "0x180693160")]
			set
			{
			}
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00003270 File Offset: 0x00001470
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x6921A0", Offset = "0x6913A0", VA = "0x1806921A0")]
		public bool IsSRPBatcherSupported()
		{
			return default(bool);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00003288 File Offset: 0x00001488
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x691CF0", Offset = "0x690EF0", VA = "0x180691CF0")]
		public RenderingMode GetActualRenderingMode(ShaderMode shaderMode)
		{
			return RenderingMode.MultiPass;
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600036B RID: 875 RVA: 0x000032A0 File Offset: 0x000014A0
		[Token(Token = "0x17000081")]
		public bool SD_useSinglePassShader
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x692F50", Offset = "0x692150", VA = "0x180692F50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600036C RID: 876 RVA: 0x000032B8 File Offset: 0x000014B8
		[Token(Token = "0x17000082")]
		public bool SD_requiresDoubleSidedMesh
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x692F50", Offset = "0x692150", VA = "0x180692F50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x691D70", Offset = "0x690F70", VA = "0x180691D70")]
		public Shader GetBeamShader(ShaderMode mode)
		{
			return null;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x691D50", Offset = "0x690F50", VA = "0x180691D50")]
		private ref Shader GetBeamShaderInternal(ShaderMode mode)
		{
			return null;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x000032D0 File Offset: 0x000014D0
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x692170", Offset = "0x691370", VA = "0x180692170")]
		private int GetRenderQueueInternal(ShaderMode mode)
		{
			return 0;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x692210", Offset = "0x691410", VA = "0x180692210")]
		public Material NewMaterialTransient(ShaderMode mode, bool gpuInstanced)
		{
			return null;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x692D90", Offset = "0x691F90", VA = "0x180692D90")]
		public void SetURPScriptableRendererIndexToDepthCamera(Camera camera)
		{
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000372 RID: 882 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000083")]
		public Transform fadeOutCameraTransform
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x692FB0", Offset = "0x6921B0", VA = "0x180692FB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x691C60", Offset = "0x690E60", VA = "0x180691C60")]
		public void ForceUpdateFadeOutCamera()
		{
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000374 RID: 884 RVA: 0x000032E8 File Offset: 0x000014E8
		[Token(Token = "0x17000084")]
		public int defaultRaymarchingQualityUniqueID
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x5CC030", Offset = "0x5CB230", VA = "0x1805CC030")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x691F90", Offset = "0x691190", VA = "0x180691F90")]
		public RaymarchingQuality GetRaymarchingQualityForIndex(int index)
		{
			return null;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x691FC0", Offset = "0x6911C0", VA = "0x180691FC0")]
		public RaymarchingQuality GetRaymarchingQualityForUniqueID(int id)
		{
			return null;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00003300 File Offset: 0x00001500
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x692010", Offset = "0x691210", VA = "0x180692010")]
		public int GetRaymarchingQualityIndexForUniqueID(int id)
		{
			return 0;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00003318 File Offset: 0x00001518
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x692180", Offset = "0x691380", VA = "0x180692180")]
		public bool IsRaymarchingQualityUniqueIDValid(int id)
		{
			return default(bool);
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000379 RID: 889 RVA: 0x00003330 File Offset: 0x00001530
		[Token(Token = "0x17000085")]
		public int raymarchingQualitiesCount
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x6930D0", Offset = "0x6922D0", VA = "0x1806930D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x691A10", Offset = "0x690C10", VA = "0x180691A10")]
		private void CreateDefaultRaymarchingQualityPreset(bool onlyIfNeeded)
		{
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600037B RID: 891 RVA: 0x00003348 File Offset: 0x00001548
		[Token(Token = "0x17000086")]
		public bool isHDRPExposureWeightSupported
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x6930C0", Offset = "0x6922C0", VA = "0x1806930C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600037C RID: 892 RVA: 0x00003360 File Offset: 0x00001560
		[Token(Token = "0x17000087")]
		public bool hasRenderPipelineMismatch
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x693090", Offset = "0x692290", VA = "0x180693090")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x692650", Offset = "0x691850", VA = "0x180692650")]
		[RuntimeInitializeOnLoadMethod]
		private static void OnStartup()
		{
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x692BD0", Offset = "0x691DD0", VA = "0x180692BD0")]
		public void Reset()
		{
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x692860", Offset = "0x691A60", VA = "0x180692860")]
		private void RefreshGlobalShaderProperties()
		{
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x692990", Offset = "0x691B90", VA = "0x180692990")]
		public void ResetInternalData()
		{
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x692430", Offset = "0x691630", VA = "0x180692430")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x692620", Offset = "0x691820", VA = "0x180692620")]
		private void OnEnable()
		{
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000384 RID: 900 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000088")]
		public static Config Instance
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x692F40", Offset = "0x692140", VA = "0x180692F40")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x6921D0", Offset = "0x6913D0", VA = "0x1806921D0")]
		private static Config LoadAssetInternal(string assetName)
		{
			return null;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x691D90", Offset = "0x690F90", VA = "0x180691D90")]
		private static Config GetInstance(bool assertIfNotFound)
		{
			return null;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x692E10", Offset = "0x692010", VA = "0x180692E10")]
		public Config()
		{
		}

		// Token: 0x04000424 RID: 1060
		[Token(Token = "0x4000424")]
		public const string ClassName = "Config";

		// Token: 0x04000425 RID: 1061
		[Token(Token = "0x4000425")]
		public const string kAssetName = "VLBConfigOverride";

		// Token: 0x04000426 RID: 1062
		[Token(Token = "0x4000426")]
		public const string kAssetNameExt = ".asset";

		// Token: 0x04000427 RID: 1063
		[Token(Token = "0x4000427")]
		[FieldOffset(Offset = "0x18")]
		public bool geometryOverrideLayer;

		// Token: 0x04000428 RID: 1064
		[Token(Token = "0x4000428")]
		[FieldOffset(Offset = "0x1C")]
		public int geometryLayerID;

		// Token: 0x04000429 RID: 1065
		[Token(Token = "0x4000429")]
		[FieldOffset(Offset = "0x20")]
		public string geometryTag;

		// Token: 0x0400042A RID: 1066
		[Token(Token = "0x400042A")]
		[FieldOffset(Offset = "0x28")]
		public int geometryRenderQueue;

		// Token: 0x0400042B RID: 1067
		[Token(Token = "0x400042B")]
		[FieldOffset(Offset = "0x2C")]
		public int geometryRenderQueueHD;

		// Token: 0x0400042C RID: 1068
		[Token(Token = "0x400042C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("renderPipeline")]
		[FormerlySerializedAs("_RenderPipeline")]
		private RenderPipeline m_RenderPipeline;

		// Token: 0x0400042D RID: 1069
		[Token(Token = "0x400042D")]
		[FieldOffset(Offset = "0x34")]
		[FormerlySerializedAs("_RenderingMode")]
		[SerializeField]
		[FormerlySerializedAs("renderingMode")]
		private RenderingMode m_RenderingMode;

		// Token: 0x0400042E RID: 1070
		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x38")]
		public float ditheringFactor;

		// Token: 0x0400042F RID: 1071
		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0x3C")]
		public bool useLightColorTemperature;

		// Token: 0x04000430 RID: 1072
		[Token(Token = "0x4000430")]
		[FieldOffset(Offset = "0x40")]
		public int sharedMeshSides;

		// Token: 0x04000431 RID: 1073
		[Token(Token = "0x4000431")]
		[FieldOffset(Offset = "0x44")]
		public int sharedMeshSegments;

		// Token: 0x04000432 RID: 1074
		[Token(Token = "0x4000432")]
		[FieldOffset(Offset = "0x48")]
		public float hdBeamsCameraBlendingDistance;

		// Token: 0x04000433 RID: 1075
		[Token(Token = "0x4000433")]
		[FieldOffset(Offset = "0x4C")]
		public int urpDepthCameraScriptableRendererIndex;

		// Token: 0x04000434 RID: 1076
		[Token(Token = "0x4000434")]
		[FieldOffset(Offset = "0x50")]
		[Range(0.01f, 2f)]
		public float globalNoiseScale;

		// Token: 0x04000435 RID: 1077
		[Token(Token = "0x4000435")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 globalNoiseVelocity;

		// Token: 0x04000436 RID: 1078
		[Token(Token = "0x4000436")]
		[FieldOffset(Offset = "0x60")]
		public string fadeOutCameraTag;

		// Token: 0x04000437 RID: 1079
		[Token(Token = "0x4000437")]
		[FieldOffset(Offset = "0x68")]
		[HighlightNull]
		public Texture3D noiseTexture3D;

		// Token: 0x04000438 RID: 1080
		[Token(Token = "0x4000438")]
		[FieldOffset(Offset = "0x70")]
		[HighlightNull]
		public ParticleSystem dustParticlesPrefab;

		// Token: 0x04000439 RID: 1081
		[Token(Token = "0x4000439")]
		[FieldOffset(Offset = "0x78")]
		[HighlightNull]
		public Texture2D ditheringNoiseTexture;

		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0x80")]
		[HighlightNull]
		public Texture2D jitteringNoiseTexture;

		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0x88")]
		public FeatureEnabledColorGradient featureEnabledColorGradient;

		// Token: 0x0400043C RID: 1084
		[Token(Token = "0x400043C")]
		[FieldOffset(Offset = "0x8C")]
		public bool featureEnabledDepthBlend;

		// Token: 0x0400043D RID: 1085
		[Token(Token = "0x400043D")]
		[FieldOffset(Offset = "0x8D")]
		public bool featureEnabledNoise3D;

		// Token: 0x0400043E RID: 1086
		[Token(Token = "0x400043E")]
		[FieldOffset(Offset = "0x8E")]
		public bool featureEnabledDynamicOcclusion;

		// Token: 0x0400043F RID: 1087
		[Token(Token = "0x400043F")]
		[FieldOffset(Offset = "0x8F")]
		public bool featureEnabledMeshSkewing;

		// Token: 0x04000440 RID: 1088
		[Token(Token = "0x4000440")]
		[FieldOffset(Offset = "0x90")]
		public bool featureEnabledShaderAccuracyHigh;

		// Token: 0x04000441 RID: 1089
		[Token(Token = "0x4000441")]
		[FieldOffset(Offset = "0x91")]
		public bool featureEnabledShadow;

		// Token: 0x04000442 RID: 1090
		[Token(Token = "0x4000442")]
		[FieldOffset(Offset = "0x92")]
		public bool featureEnabledCookie;

		// Token: 0x04000443 RID: 1091
		[Token(Token = "0x4000443")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RaymarchingQuality[] m_RaymarchingQualities;

		// Token: 0x04000444 RID: 1092
		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private int m_DefaultRaymarchingQualityUniqueID;

		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private int pluginVersion;

		// Token: 0x04000446 RID: 1094
		[Token(Token = "0x4000446")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Material _DummyMaterial;

		// Token: 0x04000447 RID: 1095
		[Token(Token = "0x4000447")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Material _DummyMaterialHD;

		// Token: 0x04000448 RID: 1096
		[Token(Token = "0x4000448")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Shader _BeamShader;

		// Token: 0x04000449 RID: 1097
		[Token(Token = "0x4000449")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Shader _BeamShaderHD;

		// Token: 0x0400044A RID: 1098
		[Token(Token = "0x400044A")]
		[FieldOffset(Offset = "0xC8")]
		private Transform m_CachedFadeOutCamera;

		// Token: 0x0400044B RID: 1099
		[Token(Token = "0x400044B")]
		[FieldOffset(Offset = "0x0")]
		private static Config ms_Instance;
	}
}
