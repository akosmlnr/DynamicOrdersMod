using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200009D RID: 157
	[Token(Token = "0x200009D")]
	[Serializable]
	public class AntialiasingModel : PostProcessingModel
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060002AB RID: 683 RVA: 0x00002C28 File Offset: 0x00000E28
		// (set) Token: 0x060002AC RID: 684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000041")]
		public AntialiasingModel.Settings settings
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x49B7A0", Offset = "0x49A9A0", VA = "0x18049B7A0")]
			get
			{
				return default(AntialiasingModel.Settings);
			}
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x49B850", Offset = "0x49AA50", VA = "0x18049B850")]
			set
			{
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x565580", Offset = "0x564780", VA = "0x180565580", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x5655B0", Offset = "0x5647B0", VA = "0x1805655B0")]
		public AntialiasingModel()
		{
		}

		// Token: 0x04000321 RID: 801
		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AntialiasingModel.Settings m_Settings;

		// Token: 0x0200009E RID: 158
		[Token(Token = "0x200009E")]
		public enum Method
		{
			// Token: 0x04000323 RID: 803
			[Token(Token = "0x4000323")]
			Fxaa,
			// Token: 0x04000324 RID: 804
			[Token(Token = "0x4000324")]
			Taa
		}

		// Token: 0x0200009F RID: 159
		[Token(Token = "0x200009F")]
		public enum FxaaPreset
		{
			// Token: 0x04000326 RID: 806
			[Token(Token = "0x4000326")]
			ExtremePerformance,
			// Token: 0x04000327 RID: 807
			[Token(Token = "0x4000327")]
			Performance,
			// Token: 0x04000328 RID: 808
			[Token(Token = "0x4000328")]
			Default,
			// Token: 0x04000329 RID: 809
			[Token(Token = "0x4000329")]
			Quality,
			// Token: 0x0400032A RID: 810
			[Token(Token = "0x400032A")]
			ExtremeQuality
		}

		// Token: 0x020000A0 RID: 160
		[Token(Token = "0x20000A0")]
		[Serializable]
		public struct FxaaQualitySettings
		{
			// Token: 0x0400032B RID: 811
			[Token(Token = "0x400032B")]
			[FieldOffset(Offset = "0x0")]
			[Range(0f, 1f)]
			[Tooltip("The amount of desired sub-pixel aliasing removal. Effects the sharpeness of the output.")]
			public float subpixelAliasingRemovalAmount;

			// Token: 0x0400032C RID: 812
			[Token(Token = "0x400032C")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
			[Range(0.063f, 0.333f)]
			public float edgeDetectionThreshold;

			// Token: 0x0400032D RID: 813
			[Token(Token = "0x400032D")]
			[FieldOffset(Offset = "0x8")]
			[Range(0f, 0.0833f)]
			[Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
			public float minimumRequiredLuminance;

			// Token: 0x0400032E RID: 814
			[Token(Token = "0x400032E")]
			[FieldOffset(Offset = "0x0")]
			public static AntialiasingModel.FxaaQualitySettings[] presets;
		}

		// Token: 0x020000A1 RID: 161
		[Token(Token = "0x20000A1")]
		[Serializable]
		public struct FxaaConsoleSettings
		{
			// Token: 0x0400032F RID: 815
			[Token(Token = "0x400032F")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("The amount of spread applied to the sampling coordinates while sampling for subpixel information.")]
			[Range(0.33f, 0.5f)]
			public float subpixelSpreadAmount;

			// Token: 0x04000330 RID: 816
			[Token(Token = "0x4000330")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("This value dictates how sharp the edges in the image are kept; a higher value implies sharper edges.")]
			[Range(2f, 8f)]
			public float edgeSharpnessAmount;

			// Token: 0x04000331 RID: 817
			[Token(Token = "0x4000331")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
			[Range(0.125f, 0.25f)]
			public float edgeDetectionThreshold;

			// Token: 0x04000332 RID: 818
			[Token(Token = "0x4000332")]
			[FieldOffset(Offset = "0xC")]
			[Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
			[Range(0.04f, 0.06f)]
			public float minimumRequiredLuminance;

			// Token: 0x04000333 RID: 819
			[Token(Token = "0x4000333")]
			[FieldOffset(Offset = "0x0")]
			public static AntialiasingModel.FxaaConsoleSettings[] presets;
		}

		// Token: 0x020000A2 RID: 162
		[Token(Token = "0x20000A2")]
		[Serializable]
		public struct FxaaSettings
		{
			// Token: 0x17000042 RID: 66
			// (get) Token: 0x060002B1 RID: 689 RVA: 0x00002C40 File Offset: 0x00000E40
			[Token(Token = "0x17000042")]
			public static AntialiasingModel.FxaaSettings defaultSettings
			{
				[Token(Token = "0x60002B1")]
				[Address(RVA = "0x56E800", Offset = "0x56DA00", VA = "0x18056E800")]
				get
				{
					return default(AntialiasingModel.FxaaSettings);
				}
			}

			// Token: 0x04000334 RID: 820
			[Token(Token = "0x4000334")]
			[FieldOffset(Offset = "0x0")]
			public AntialiasingModel.FxaaPreset preset;
		}

		// Token: 0x020000A3 RID: 163
		[Token(Token = "0x20000A3")]
		[Serializable]
		public struct TaaSettings
		{
			// Token: 0x17000043 RID: 67
			// (get) Token: 0x060002B2 RID: 690 RVA: 0x00002C58 File Offset: 0x00000E58
			[Token(Token = "0x17000043")]
			public static AntialiasingModel.TaaSettings defaultSettings
			{
				[Token(Token = "0x60002B2")]
				[Address(RVA = "0x574DC0", Offset = "0x573FC0", VA = "0x180574DC0")]
				get
				{
					return default(AntialiasingModel.TaaSettings);
				}
			}

			// Token: 0x04000335 RID: 821
			[Token(Token = "0x4000335")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("The diameter (in texels) inside which jitter samples are spread. Smaller values result in crisper but more aliased output, while larger values result in more stable but blurrier output.")]
			[Range(0.1f, 1f)]
			public float jitterSpread;

			// Token: 0x04000336 RID: 822
			[Token(Token = "0x4000336")]
			[FieldOffset(Offset = "0x4")]
			[Range(0f, 3f)]
			[Tooltip("Controls the amount of sharpening applied to the color buffer.")]
			public float sharpen;

			// Token: 0x04000337 RID: 823
			[Token(Token = "0x4000337")]
			[FieldOffset(Offset = "0x8")]
			[Range(0f, 0.99f)]
			[Tooltip("The blend coefficient for a stationary fragment. Controls the percentage of history sample blended into the final color.")]
			public float stationaryBlending;

			// Token: 0x04000338 RID: 824
			[Token(Token = "0x4000338")]
			[FieldOffset(Offset = "0xC")]
			[Range(0f, 0.99f)]
			[Tooltip("The blend coefficient for a fragment with significant motion. Controls the percentage of history sample blended into the final color.")]
			public float motionBlending;
		}

		// Token: 0x020000A4 RID: 164
		[Token(Token = "0x20000A4")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000044 RID: 68
			// (get) Token: 0x060002B3 RID: 691 RVA: 0x00002C70 File Offset: 0x00000E70
			[Token(Token = "0x17000044")]
			public static AntialiasingModel.Settings defaultSettings
			{
				[Token(Token = "0x60002B3")]
				[Address(RVA = "0x69CA10", Offset = "0x69BC10", VA = "0x18069CA10")]
				get
				{
					return default(AntialiasingModel.Settings);
				}
			}

			// Token: 0x04000339 RID: 825
			[Token(Token = "0x4000339")]
			[FieldOffset(Offset = "0x0")]
			public AntialiasingModel.Method method;

			// Token: 0x0400033A RID: 826
			[Token(Token = "0x400033A")]
			[FieldOffset(Offset = "0x4")]
			public AntialiasingModel.FxaaSettings fxaaSettings;

			// Token: 0x0400033B RID: 827
			[Token(Token = "0x400033B")]
			[FieldOffset(Offset = "0x8")]
			public AntialiasingModel.TaaSettings taaSettings;
		}
	}
}
