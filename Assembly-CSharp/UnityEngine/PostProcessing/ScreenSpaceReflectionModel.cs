using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000C9 RID: 201
	[Token(Token = "0x20000C9")]
	[Serializable]
	public class ScreenSpaceReflectionModel : PostProcessingModel
	{
		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00002FD0 File Offset: 0x000011D0
		// (set) Token: 0x060002FB RID: 763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000068")]
		public ScreenSpaceReflectionModel.Settings settings
		{
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x69C590", Offset = "0x69B790", VA = "0x18069C590")]
			get
			{
				return default(ScreenSpaceReflectionModel.Settings);
			}
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x69C5C0", Offset = "0x69B7C0", VA = "0x18069C5C0")]
			set
			{
			}
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x69C490", Offset = "0x69B690", VA = "0x18069C490", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x69C510", Offset = "0x69B710", VA = "0x18069C510")]
		public ScreenSpaceReflectionModel()
		{
		}

		// Token: 0x040003BB RID: 955
		[Token(Token = "0x40003BB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ScreenSpaceReflectionModel.Settings m_Settings;

		// Token: 0x020000CA RID: 202
		[Token(Token = "0x20000CA")]
		public enum SSRResolution
		{
			// Token: 0x040003BD RID: 957
			[Token(Token = "0x40003BD")]
			High,
			// Token: 0x040003BE RID: 958
			[Token(Token = "0x40003BE")]
			Low = 2
		}

		// Token: 0x020000CB RID: 203
		[Token(Token = "0x20000CB")]
		public enum SSRReflectionBlendType
		{
			// Token: 0x040003C0 RID: 960
			[Token(Token = "0x40003C0")]
			PhysicallyBased,
			// Token: 0x040003C1 RID: 961
			[Token(Token = "0x40003C1")]
			Additive
		}

		// Token: 0x020000CC RID: 204
		[Token(Token = "0x20000CC")]
		[Serializable]
		public struct IntensitySettings
		{
			// Token: 0x040003C2 RID: 962
			[Token(Token = "0x40003C2")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Nonphysical multiplier for the SSR reflections. 1.0 is physically based.")]
			[Range(0f, 2f)]
			public float reflectionMultiplier;

			// Token: 0x040003C3 RID: 963
			[Token(Token = "0x40003C3")]
			[FieldOffset(Offset = "0x4")]
			[Range(0f, 1000f)]
			[Tooltip("How far away from the maxDistance to begin fading SSR.")]
			public float fadeDistance;

			// Token: 0x040003C4 RID: 964
			[Token(Token = "0x40003C4")]
			[FieldOffset(Offset = "0x8")]
			[Range(0f, 1f)]
			[Tooltip("Amplify Fresnel fade out. Increase if floor reflections look good close to the surface and bad farther 'under' the floor.")]
			public float fresnelFade;

			// Token: 0x040003C5 RID: 965
			[Token(Token = "0x40003C5")]
			[FieldOffset(Offset = "0xC")]
			[Tooltip("Higher values correspond to a faster Fresnel fade as the reflection changes from the grazing angle.")]
			[Range(0.1f, 10f)]
			public float fresnelFadePower;
		}

		// Token: 0x020000CD RID: 205
		[Token(Token = "0x20000CD")]
		[Serializable]
		public struct ReflectionSettings
		{
			// Token: 0x040003C6 RID: 966
			[Token(Token = "0x40003C6")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("How the reflections are blended into the render.")]
			public ScreenSpaceReflectionModel.SSRReflectionBlendType blendType;

			// Token: 0x040003C7 RID: 967
			[Token(Token = "0x40003C7")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("Half resolution SSRR is much faster, but less accurate.")]
			public ScreenSpaceReflectionModel.SSRResolution reflectionQuality;

			// Token: 0x040003C8 RID: 968
			[Token(Token = "0x40003C8")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("Maximum reflection distance in world units.")]
			[Range(0.1f, 300f)]
			public float maxDistance;

			// Token: 0x040003C9 RID: 969
			[Token(Token = "0x40003C9")]
			[FieldOffset(Offset = "0xC")]
			[Tooltip("Max raytracing length.")]
			[Range(16f, 1024f)]
			public int iterationCount;

			// Token: 0x040003CA RID: 970
			[Token(Token = "0x40003CA")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("Log base 2 of ray tracing coarse step size. Higher traces farther, lower gives better quality silhouettes.")]
			[Range(1f, 16f)]
			public int stepSize;

			// Token: 0x040003CB RID: 971
			[Token(Token = "0x40003CB")]
			[FieldOffset(Offset = "0x14")]
			[Tooltip("Typical thickness of columns, walls, furniture, and other objects that reflection rays might pass behind.")]
			[Range(0.01f, 10f)]
			public float widthModifier;

			// Token: 0x040003CC RID: 972
			[Token(Token = "0x40003CC")]
			[FieldOffset(Offset = "0x18")]
			[Range(0.1f, 8f)]
			[Tooltip("Blurriness of reflections.")]
			public float reflectionBlur;

			// Token: 0x040003CD RID: 973
			[Token(Token = "0x40003CD")]
			[FieldOffset(Offset = "0x1C")]
			[Tooltip("Disable for a performance gain in scenes where most glossy objects are horizontal, like floors, water, and tables. Leave on for scenes with glossy vertical objects.")]
			public bool reflectBackfaces;
		}

		// Token: 0x020000CE RID: 206
		[Token(Token = "0x20000CE")]
		[Serializable]
		public struct ScreenEdgeMask
		{
			// Token: 0x040003CE RID: 974
			[Token(Token = "0x40003CE")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Higher = fade out SSRR near the edge of the screen so that reflections don't pop under camera motion.")]
			[Range(0f, 1f)]
			public float intensity;
		}

		// Token: 0x020000CF RID: 207
		[Token(Token = "0x20000CF")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000069 RID: 105
			// (get) Token: 0x060002FE RID: 766 RVA: 0x00002FE8 File Offset: 0x000011E8
			[Token(Token = "0x17000069")]
			public static ScreenSpaceReflectionModel.Settings defaultSettings
			{
				[Token(Token = "0x60002FE")]
				[Address(RVA = "0x69C610", Offset = "0x69B810", VA = "0x18069C610")]
				get
				{
					return default(ScreenSpaceReflectionModel.Settings);
				}
			}

			// Token: 0x040003CF RID: 975
			[Token(Token = "0x40003CF")]
			[FieldOffset(Offset = "0x0")]
			public ScreenSpaceReflectionModel.ReflectionSettings reflection;

			// Token: 0x040003D0 RID: 976
			[Token(Token = "0x40003D0")]
			[FieldOffset(Offset = "0x20")]
			public ScreenSpaceReflectionModel.IntensitySettings intensity;

			// Token: 0x040003D1 RID: 977
			[Token(Token = "0x40003D1")]
			[FieldOffset(Offset = "0x30")]
			public ScreenSpaceReflectionModel.ScreenEdgeMask screenEdgeMask;
		}
	}
}
