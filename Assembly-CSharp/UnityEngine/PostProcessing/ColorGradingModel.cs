using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000B0 RID: 176
	[Token(Token = "0x20000B0")]
	[Serializable]
	public class ColorGradingModel : PostProcessingModel
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00002DC0 File Offset: 0x00000FC0
		// (set) Token: 0x060002CC RID: 716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000051")]
		public ColorGradingModel.Settings settings
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x6918B0", Offset = "0x690AB0", VA = "0x1806918B0")]
			get
			{
				return default(ColorGradingModel.Settings);
			}
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x691930", Offset = "0x690B30", VA = "0x180691930")]
			set
			{
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060002CD RID: 717 RVA: 0x00002DD8 File Offset: 0x00000FD8
		// (set) Token: 0x060002CE RID: 718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000052")]
		public bool isDirty
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x511850", Offset = "0x510A50", VA = "0x180511850")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x5A4550", Offset = "0x5A3750", VA = "0x1805A4550")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060002CF RID: 719 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000053")]
		public RenderTexture bakedLut
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x521AC0", Offset = "0x520CC0", VA = "0x180521AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x58D260", Offset = "0x58C460", VA = "0x18058D260")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x691680", Offset = "0x690880", VA = "0x180691680", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x617530", Offset = "0x616730", VA = "0x180617530", Slot = "5")]
		public override void OnValidate()
		{
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x6917A0", Offset = "0x6909A0", VA = "0x1806917A0")]
		public ColorGradingModel()
		{
		}

		// Token: 0x0400035F RID: 863
		[Token(Token = "0x400035F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ColorGradingModel.Settings m_Settings;

		// Token: 0x020000B1 RID: 177
		[Token(Token = "0x20000B1")]
		public enum Tonemapper
		{
			// Token: 0x04000363 RID: 867
			[Token(Token = "0x4000363")]
			None,
			// Token: 0x04000364 RID: 868
			[Token(Token = "0x4000364")]
			ACES,
			// Token: 0x04000365 RID: 869
			[Token(Token = "0x4000365")]
			Neutral
		}

		// Token: 0x020000B2 RID: 178
		[Token(Token = "0x20000B2")]
		[Serializable]
		public struct TonemappingSettings
		{
			// Token: 0x17000054 RID: 84
			// (get) Token: 0x060002D4 RID: 724 RVA: 0x00002DF0 File Offset: 0x00000FF0
			[Token(Token = "0x17000054")]
			public static ColorGradingModel.TonemappingSettings defaultSettings
			{
				[Token(Token = "0x60002D4")]
				[Address(RVA = "0x69D6A0", Offset = "0x69C8A0", VA = "0x18069D6A0")]
				get
				{
					return default(ColorGradingModel.TonemappingSettings);
				}
			}

			// Token: 0x04000366 RID: 870
			[Token(Token = "0x4000366")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Tonemapping algorithm to use at the end of the color grading process. Use \"Neutral\" if you need a customizable tonemapper or \"Filmic\" to give a standard filmic look to your scenes.")]
			public ColorGradingModel.Tonemapper tonemapper;

			// Token: 0x04000367 RID: 871
			[Token(Token = "0x4000367")]
			[FieldOffset(Offset = "0x4")]
			[Range(-0.1f, 0.1f)]
			public float neutralBlackIn;

			// Token: 0x04000368 RID: 872
			[Token(Token = "0x4000368")]
			[FieldOffset(Offset = "0x8")]
			[Range(1f, 20f)]
			public float neutralWhiteIn;

			// Token: 0x04000369 RID: 873
			[Token(Token = "0x4000369")]
			[FieldOffset(Offset = "0xC")]
			[Range(-0.09f, 0.1f)]
			public float neutralBlackOut;

			// Token: 0x0400036A RID: 874
			[Token(Token = "0x400036A")]
			[FieldOffset(Offset = "0x10")]
			[Range(1f, 19f)]
			public float neutralWhiteOut;

			// Token: 0x0400036B RID: 875
			[Token(Token = "0x400036B")]
			[FieldOffset(Offset = "0x14")]
			[Range(0.1f, 20f)]
			public float neutralWhiteLevel;

			// Token: 0x0400036C RID: 876
			[Token(Token = "0x400036C")]
			[FieldOffset(Offset = "0x18")]
			[Range(1f, 10f)]
			public float neutralWhiteClip;
		}

		// Token: 0x020000B3 RID: 179
		[Token(Token = "0x20000B3")]
		[Serializable]
		public struct BasicSettings
		{
			// Token: 0x17000055 RID: 85
			// (get) Token: 0x060002D5 RID: 725 RVA: 0x00002E08 File Offset: 0x00001008
			[Token(Token = "0x17000055")]
			public static ColorGradingModel.BasicSettings defaultSettings
			{
				[Token(Token = "0x60002D5")]
				[Address(RVA = "0x68A370", Offset = "0x689570", VA = "0x18068A370")]
				get
				{
					return default(ColorGradingModel.BasicSettings);
				}
			}

			// Token: 0x0400036D RID: 877
			[Token(Token = "0x400036D")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Adjusts the overall exposure of the scene in EV units. This is applied after HDR effect and right before tonemapping so it won't affect previous effects in the chain.")]
			public float postExposure;

			// Token: 0x0400036E RID: 878
			[Token(Token = "0x400036E")]
			[FieldOffset(Offset = "0x4")]
			[Range(-100f, 100f)]
			[Tooltip("Sets the white balance to a custom color temperature.")]
			public float temperature;

			// Token: 0x0400036F RID: 879
			[Token(Token = "0x400036F")]
			[FieldOffset(Offset = "0x8")]
			[Range(-100f, 100f)]
			[Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
			public float tint;

			// Token: 0x04000370 RID: 880
			[Token(Token = "0x4000370")]
			[FieldOffset(Offset = "0xC")]
			[Range(-180f, 180f)]
			[Tooltip("Shift the hue of all colors.")]
			public float hueShift;

			// Token: 0x04000371 RID: 881
			[Token(Token = "0x4000371")]
			[FieldOffset(Offset = "0x10")]
			[Range(0f, 2f)]
			[Tooltip("Pushes the intensity of all colors.")]
			public float saturation;

			// Token: 0x04000372 RID: 882
			[Token(Token = "0x4000372")]
			[FieldOffset(Offset = "0x14")]
			[Range(0f, 2f)]
			[Tooltip("Expands or shrinks the overall range of tonal values.")]
			public float contrast;
		}

		// Token: 0x020000B4 RID: 180
		[Token(Token = "0x20000B4")]
		[Serializable]
		public struct ChannelMixerSettings
		{
			// Token: 0x17000056 RID: 86
			// (get) Token: 0x060002D6 RID: 726 RVA: 0x00002E20 File Offset: 0x00001020
			[Token(Token = "0x17000056")]
			public static ColorGradingModel.ChannelMixerSettings defaultSettings
			{
				[Token(Token = "0x60002D6")]
				[Address(RVA = "0x691220", Offset = "0x690420", VA = "0x180691220")]
				get
				{
					return default(ColorGradingModel.ChannelMixerSettings);
				}
			}

			// Token: 0x04000373 RID: 883
			[Token(Token = "0x4000373")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 red;

			// Token: 0x04000374 RID: 884
			[Token(Token = "0x4000374")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 green;

			// Token: 0x04000375 RID: 885
			[Token(Token = "0x4000375")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 blue;

			// Token: 0x04000376 RID: 886
			[Token(Token = "0x4000376")]
			[FieldOffset(Offset = "0x24")]
			[HideInInspector]
			public int currentEditingChannel;
		}

		// Token: 0x020000B5 RID: 181
		[Token(Token = "0x20000B5")]
		[Serializable]
		public struct LogWheelsSettings
		{
			// Token: 0x17000057 RID: 87
			// (get) Token: 0x060002D7 RID: 727 RVA: 0x00002E38 File Offset: 0x00001038
			[Token(Token = "0x17000057")]
			public static ColorGradingModel.LogWheelsSettings defaultSettings
			{
				[Token(Token = "0x60002D7")]
				[Address(RVA = "0x695C30", Offset = "0x694E30", VA = "0x180695C30")]
				get
				{
					return default(ColorGradingModel.LogWheelsSettings);
				}
			}

			// Token: 0x04000377 RID: 887
			[Token(Token = "0x4000377")]
			[FieldOffset(Offset = "0x0")]
			[Trackball("GetSlopeValue")]
			public Color slope;

			// Token: 0x04000378 RID: 888
			[Token(Token = "0x4000378")]
			[FieldOffset(Offset = "0x10")]
			[Trackball("GetPowerValue")]
			public Color power;

			// Token: 0x04000379 RID: 889
			[Token(Token = "0x4000379")]
			[FieldOffset(Offset = "0x20")]
			[Trackball("GetOffsetValue")]
			public Color offset;
		}

		// Token: 0x020000B6 RID: 182
		[Token(Token = "0x20000B6")]
		[Serializable]
		public struct LinearWheelsSettings
		{
			// Token: 0x17000058 RID: 88
			// (get) Token: 0x060002D8 RID: 728 RVA: 0x00002E50 File Offset: 0x00001050
			[Token(Token = "0x17000058")]
			public static ColorGradingModel.LinearWheelsSettings defaultSettings
			{
				[Token(Token = "0x60002D8")]
				[Address(RVA = "0x695C30", Offset = "0x694E30", VA = "0x180695C30")]
				get
				{
					return default(ColorGradingModel.LinearWheelsSettings);
				}
			}

			// Token: 0x0400037A RID: 890
			[Token(Token = "0x400037A")]
			[FieldOffset(Offset = "0x0")]
			[Trackball("GetLiftValue")]
			public Color lift;

			// Token: 0x0400037B RID: 891
			[Token(Token = "0x400037B")]
			[FieldOffset(Offset = "0x10")]
			[Trackball("GetGammaValue")]
			public Color gamma;

			// Token: 0x0400037C RID: 892
			[Token(Token = "0x400037C")]
			[FieldOffset(Offset = "0x20")]
			[Trackball("GetGainValue")]
			public Color gain;
		}

		// Token: 0x020000B7 RID: 183
		[Token(Token = "0x20000B7")]
		public enum ColorWheelMode
		{
			// Token: 0x0400037E RID: 894
			[Token(Token = "0x400037E")]
			Linear,
			// Token: 0x0400037F RID: 895
			[Token(Token = "0x400037F")]
			Log
		}

		// Token: 0x020000B8 RID: 184
		[Token(Token = "0x20000B8")]
		[Serializable]
		public struct ColorWheelsSettings
		{
			// Token: 0x17000059 RID: 89
			// (get) Token: 0x060002D9 RID: 729 RVA: 0x00002E68 File Offset: 0x00001068
			[Token(Token = "0x17000059")]
			public static ColorGradingModel.ColorWheelsSettings defaultSettings
			{
				[Token(Token = "0x60002D9")]
				[Address(RVA = "0x6919E0", Offset = "0x690BE0", VA = "0x1806919E0")]
				get
				{
					return default(ColorGradingModel.ColorWheelsSettings);
				}
			}

			// Token: 0x04000380 RID: 896
			[Token(Token = "0x4000380")]
			[FieldOffset(Offset = "0x0")]
			public ColorGradingModel.ColorWheelMode mode;

			// Token: 0x04000381 RID: 897
			[Token(Token = "0x4000381")]
			[FieldOffset(Offset = "0x4")]
			[TrackballGroup]
			public ColorGradingModel.LogWheelsSettings log;

			// Token: 0x04000382 RID: 898
			[Token(Token = "0x4000382")]
			[FieldOffset(Offset = "0x34")]
			[TrackballGroup]
			public ColorGradingModel.LinearWheelsSettings linear;
		}

		// Token: 0x020000B9 RID: 185
		[Token(Token = "0x20000B9")]
		[Serializable]
		public struct CurvesSettings
		{
			// Token: 0x1700005A RID: 90
			// (get) Token: 0x060002DA RID: 730 RVA: 0x00002E80 File Offset: 0x00001080
			[Token(Token = "0x1700005A")]
			public static ColorGradingModel.CurvesSettings defaultSettings
			{
				[Token(Token = "0x60002DA")]
				[Address(RVA = "0x693280", Offset = "0x692480", VA = "0x180693280")]
				get
				{
					return default(ColorGradingModel.CurvesSettings);
				}
			}

			// Token: 0x04000383 RID: 899
			[Token(Token = "0x4000383")]
			[FieldOffset(Offset = "0x0")]
			public ColorGradingCurve master;

			// Token: 0x04000384 RID: 900
			[Token(Token = "0x4000384")]
			[FieldOffset(Offset = "0x8")]
			public ColorGradingCurve red;

			// Token: 0x04000385 RID: 901
			[Token(Token = "0x4000385")]
			[FieldOffset(Offset = "0x10")]
			public ColorGradingCurve green;

			// Token: 0x04000386 RID: 902
			[Token(Token = "0x4000386")]
			[FieldOffset(Offset = "0x18")]
			public ColorGradingCurve blue;

			// Token: 0x04000387 RID: 903
			[Token(Token = "0x4000387")]
			[FieldOffset(Offset = "0x20")]
			public ColorGradingCurve hueVShue;

			// Token: 0x04000388 RID: 904
			[Token(Token = "0x4000388")]
			[FieldOffset(Offset = "0x28")]
			public ColorGradingCurve hueVSsat;

			// Token: 0x04000389 RID: 905
			[Token(Token = "0x4000389")]
			[FieldOffset(Offset = "0x30")]
			public ColorGradingCurve satVSsat;

			// Token: 0x0400038A RID: 906
			[Token(Token = "0x400038A")]
			[FieldOffset(Offset = "0x38")]
			public ColorGradingCurve lumVSsat;

			// Token: 0x0400038B RID: 907
			[Token(Token = "0x400038B")]
			[FieldOffset(Offset = "0x40")]
			[HideInInspector]
			public int e_CurrentEditingCurve;

			// Token: 0x0400038C RID: 908
			[Token(Token = "0x400038C")]
			[FieldOffset(Offset = "0x44")]
			[HideInInspector]
			public bool e_CurveY;

			// Token: 0x0400038D RID: 909
			[Token(Token = "0x400038D")]
			[FieldOffset(Offset = "0x45")]
			[HideInInspector]
			public bool e_CurveR;

			// Token: 0x0400038E RID: 910
			[Token(Token = "0x400038E")]
			[FieldOffset(Offset = "0x46")]
			[HideInInspector]
			public bool e_CurveG;

			// Token: 0x0400038F RID: 911
			[Token(Token = "0x400038F")]
			[FieldOffset(Offset = "0x47")]
			[HideInInspector]
			public bool e_CurveB;
		}

		// Token: 0x020000BA RID: 186
		[Token(Token = "0x20000BA")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x1700005B RID: 91
			// (get) Token: 0x060002DB RID: 731 RVA: 0x00002E98 File Offset: 0x00001098
			[Token(Token = "0x1700005B")]
			public static ColorGradingModel.Settings defaultSettings
			{
				[Token(Token = "0x60002DB")]
				[Address(RVA = "0x69C860", Offset = "0x69BA60", VA = "0x18069C860")]
				get
				{
					return default(ColorGradingModel.Settings);
				}
			}

			// Token: 0x04000390 RID: 912
			[Token(Token = "0x4000390")]
			[FieldOffset(Offset = "0x0")]
			public ColorGradingModel.TonemappingSettings tonemapping;

			// Token: 0x04000391 RID: 913
			[Token(Token = "0x4000391")]
			[FieldOffset(Offset = "0x1C")]
			public ColorGradingModel.BasicSettings basic;

			// Token: 0x04000392 RID: 914
			[Token(Token = "0x4000392")]
			[FieldOffset(Offset = "0x34")]
			public ColorGradingModel.ChannelMixerSettings channelMixer;

			// Token: 0x04000393 RID: 915
			[Token(Token = "0x4000393")]
			[FieldOffset(Offset = "0x5C")]
			public ColorGradingModel.ColorWheelsSettings colorWheels;

			// Token: 0x04000394 RID: 916
			[Token(Token = "0x4000394")]
			[FieldOffset(Offset = "0xC0")]
			public ColorGradingModel.CurvesSettings curves;
		}
	}
}
