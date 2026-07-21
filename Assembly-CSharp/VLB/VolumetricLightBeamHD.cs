using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000116 RID: 278
	[Token(Token = "0x2000116")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[SelectionBase]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam-hd/")]
	public class VolumetricLightBeamHD : VolumetricLightBeamAbstractBase
	{
		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x00003570 File Offset: 0x00001770
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A4")]
		public bool colorFromLight
		{
			[Token(Token = "0x600040A")]
			[Address(RVA = "0x496D60", Offset = "0x495F60", VA = "0x180496D60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600040B")]
			[Address(RVA = "0x6A07E0", Offset = "0x69F9E0", VA = "0x1806A07E0")]
			set
			{
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x00003588 File Offset: 0x00001788
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A5")]
		public ColorMode colorMode
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0x6A0280", Offset = "0x69F480", VA = "0x1806A0280")]
			get
			{
				return ColorMode.Flat;
			}
			[Token(Token = "0x600040D")]
			[Address(RVA = "0x6A0840", Offset = "0x69FA40", VA = "0x1806A0840")]
			set
			{
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x000035A0 File Offset: 0x000017A0
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A6")]
		public Color colorFlat
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0x4F8560", Offset = "0x4F7760", VA = "0x1804F8560")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600040F")]
			[Address(RVA = "0x6A0730", Offset = "0x69F930", VA = "0x1806A0730")]
			set
			{
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A7")]
		public Gradient colorGradient
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x4C0310", Offset = "0x4BF510", VA = "0x1804C0310")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000411")]
			[Address(RVA = "0x6A07F0", Offset = "0x69F9F0", VA = "0x1806A07F0")]
			set
			{
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x000035B8 File Offset: 0x000017B8
		[Token(Token = "0x170000A8")]
		private bool useColorFromAttachedLightSpot
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x6A0450", Offset = "0x69F650", VA = "0x1806A0450")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x000035D0 File Offset: 0x000017D0
		[Token(Token = "0x170000A9")]
		private bool useColorTemperatureFromAttachedLightSpot
		{
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x6A04B0", Offset = "0x69F6B0", VA = "0x1806A04B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x000035E8 File Offset: 0x000017E8
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AA")]
		public float intensity
		{
			[Token(Token = "0x6000414")]
			[Address(RVA = "0x4B3A40", Offset = "0x4B2C40", VA = "0x1804B3A40")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000415")]
			[Address(RVA = "0x6A0A30", Offset = "0x69FC30", VA = "0x1806A0A30")]
			set
			{
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x00003600 File Offset: 0x00001800
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AB")]
		public float intensityMultiplier
		{
			[Token(Token = "0x6000416")]
			[Address(RVA = "0x4B4830", Offset = "0x4B3A30", VA = "0x1804B4830")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000417")]
			[Address(RVA = "0x6A0A10", Offset = "0x69FC10", VA = "0x1806A0A10")]
			set
			{
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x00003618 File Offset: 0x00001818
		[Token(Token = "0x170000AC")]
		public bool useIntensityFromAttachedLightSpot
		{
			[Token(Token = "0x6000418")]
			[Address(RVA = "0x6A05C0", Offset = "0x69F7C0", VA = "0x1806A05C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x00003630 File Offset: 0x00001830
		// (set) Token: 0x0600041A RID: 1050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AD")]
		public float hdrpExposureWeight
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0x4B4220", Offset = "0x4B3420", VA = "0x1804B4220")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600041A")]
			[Address(RVA = "0x6A09D0", Offset = "0x69FBD0", VA = "0x1806A09D0")]
			set
			{
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x00003648 File Offset: 0x00001848
		// (set) Token: 0x0600041C RID: 1052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AE")]
		public BlendingMode blendingMode
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x4B47D0", Offset = "0x4B39D0", VA = "0x1804B47D0")]
			get
			{
				return BlendingMode.Additive;
			}
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x6A06F0", Offset = "0x69F8F0", VA = "0x1806A06F0")]
			set
			{
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x00003660 File Offset: 0x00001860
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AF")]
		public float spotAngle
		{
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x4B3A60", Offset = "0x4B2C60", VA = "0x1804B3A60")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x6A0EE0", Offset = "0x6A00E0", VA = "0x1806A0EE0")]
			set
			{
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x00003678 File Offset: 0x00001878
		// (set) Token: 0x06000420 RID: 1056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B0")]
		public float spotAngleMultiplier
		{
			[Token(Token = "0x600041F")]
			[Address(RVA = "0x4CB750", Offset = "0x4CA950", VA = "0x1804CB750")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000420")]
			[Address(RVA = "0x6A0EC0", Offset = "0x6A00C0", VA = "0x1806A0EC0")]
			set
			{
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x00003690 File Offset: 0x00001890
		[Token(Token = "0x170000B1")]
		public bool useSpotAngleFromAttachedLightSpot
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x6A0630", Offset = "0x69F830", VA = "0x1806A0630")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x000036A8 File Offset: 0x000018A8
		[Token(Token = "0x170000B2")]
		public float coneAngle
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x6A02C0", Offset = "0x69F4C0", VA = "0x1806A02C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x000036C0 File Offset: 0x000018C0
		// (set) Token: 0x06000424 RID: 1060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B3")]
		public float coneRadiusStart
		{
			[Token(Token = "0x6000423")]
			[Address(RVA = "0x4CBF90", Offset = "0x4CB190", VA = "0x1804CBF90")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x6A08E0", Offset = "0x69FAE0", VA = "0x1806A08E0")]
			set
			{
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x000036D8 File Offset: 0x000018D8
		// (set) Token: 0x06000426 RID: 1062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B4")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x6A0300", Offset = "0x69F500", VA = "0x1806A0300")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x6A0880", Offset = "0x69FA80", VA = "0x1806A0880")]
			set
			{
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x000036F0 File Offset: 0x000018F0
		[Token(Token = "0x170000B5")]
		public float coneVolume
		{
			[Token(Token = "0x6000427")]
			[Address(RVA = "0x6A0320", Offset = "0x69F520", VA = "0x1806A0320")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00003708 File Offset: 0x00001908
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x69F6D0", Offset = "0x69E8D0", VA = "0x18069F6D0")]
		public float GetConeApexOffsetZ(bool counterApplyScaleForUnscalableBeam)
		{
			return 0f;
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x00003720 File Offset: 0x00001920
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B6")]
		public bool scalable
		{
			[Token(Token = "0x6000429")]
			[Address(RVA = "0x674740", Offset = "0x673940", VA = "0x180674740")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600042A")]
			[Address(RVA = "0x6A0E50", Offset = "0x6A0050", VA = "0x1806A0E50")]
			set
			{
			}
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00003738 File Offset: 0x00001938
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x674740", Offset = "0x673940", VA = "0x180674740", Slot = "6")]
		public override bool IsScalable()
		{
			return default(bool);
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x00003750 File Offset: 0x00001950
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B7")]
		public AttenuationEquationHD attenuationEquation
		{
			[Token(Token = "0x600042C")]
			[Address(RVA = "0x69FEE0", Offset = "0x69F0E0", VA = "0x18069FEE0")]
			get
			{
				return AttenuationEquationHD.Linear;
			}
			[Token(Token = "0x600042D")]
			[Address(RVA = "0x6A06B0", Offset = "0x69F8B0", VA = "0x1806A06B0")]
			set
			{
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x00003768 File Offset: 0x00001968
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B8")]
		public float fallOffStart
		{
			[Token(Token = "0x600042E")]
			[Address(RVA = "0x4CBF80", Offset = "0x4CB180", VA = "0x1804CBF80")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600042F")]
			[Address(RVA = "0x6A0990", Offset = "0x69FB90", VA = "0x1806A0990")]
			set
			{
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x00003780 File Offset: 0x00001980
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B9")]
		public float fallOffEnd
		{
			[Token(Token = "0x6000430")]
			[Address(RVA = "0x4CB730", Offset = "0x4CA930", VA = "0x1804CB730")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000431")]
			[Address(RVA = "0x6A0940", Offset = "0x69FB40", VA = "0x1806A0940")]
			set
			{
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x00003798 File Offset: 0x00001998
		[Token(Token = "0x170000BA")]
		public float maxGeometryDistance
		{
			[Token(Token = "0x6000432")]
			[Address(RVA = "0x4CB730", Offset = "0x4CA930", VA = "0x1804CB730")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x000037B0 File Offset: 0x000019B0
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BB")]
		public float fallOffEndMultiplier
		{
			[Token(Token = "0x6000433")]
			[Address(RVA = "0x6A0380", Offset = "0x69F580", VA = "0x1806A0380")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000434")]
			[Address(RVA = "0x6A0920", Offset = "0x69FB20", VA = "0x1806A0920")]
			set
			{
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x000037C8 File Offset: 0x000019C8
		[Token(Token = "0x170000BC")]
		public bool useFallOffEndFromAttachedLightSpot
		{
			[Token(Token = "0x6000435")]
			[Address(RVA = "0x6A0550", Offset = "0x69F750", VA = "0x1806A0550")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x000037E0 File Offset: 0x000019E0
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BD")]
		public float sideSoftness
		{
			[Token(Token = "0x6000436")]
			[Address(RVA = "0x64ACF0", Offset = "0x649EF0", VA = "0x18064ACF0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x6A0E70", Offset = "0x6A0070", VA = "0x1806A0E70")]
			set
			{
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x000037F8 File Offset: 0x000019F8
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BE")]
		public float jitteringFactor
		{
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x6A03A0", Offset = "0x69F5A0", VA = "0x1806A03A0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x6A0A80", Offset = "0x69FC80", VA = "0x1806A0A80")]
			set
			{
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x00003810 File Offset: 0x00001A10
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BF")]
		public int jitteringFrameRate
		{
			[Token(Token = "0x600043A")]
			[Address(RVA = "0x4B40D0", Offset = "0x4B32D0", VA = "0x1804B40D0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600043B")]
			[Address(RVA = "0x6A0AD0", Offset = "0x69FCD0", VA = "0x1806A0AD0")]
			set
			{
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x00003828 File Offset: 0x00001A28
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C0")]
		public MinMaxRangeFloat jitteringLerpRange
		{
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x6A03B0", Offset = "0x69F5B0", VA = "0x1806A03B0")]
			get
			{
				return default(MinMaxRangeFloat);
			}
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x6A0B10", Offset = "0x69FD10", VA = "0x1806A0B10")]
			set
			{
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C1")]
		public NoiseMode noiseMode
		{
			[Token(Token = "0x600043E")]
			[Address(RVA = "0x4B48F0", Offset = "0x4B3AF0", VA = "0x1804B48F0")]
			get
			{
				return NoiseMode.Disabled;
			}
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x6A0BC0", Offset = "0x69FDC0", VA = "0x1806A0BC0")]
			set
			{
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x00003858 File Offset: 0x00001A58
		[Token(Token = "0x170000C2")]
		public bool isNoiseEnabled
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x6A0390", Offset = "0x69F590", VA = "0x1806A0390")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x00003870 File Offset: 0x00001A70
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C3")]
		public float noiseIntensity
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x6A03D0", Offset = "0x69F5D0", VA = "0x1806A03D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x6A0B70", Offset = "0x69FD70", VA = "0x1806A0B70")]
			set
			{
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x00003888 File Offset: 0x00001A88
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C4")]
		public bool noiseScaleUseGlobal
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x6A03F0", Offset = "0x69F5F0", VA = "0x1806A03F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000444")]
			[Address(RVA = "0x6A0C50", Offset = "0x69FE50", VA = "0x1806A0C50")]
			set
			{
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x000038A0 File Offset: 0x00001AA0
		// (set) Token: 0x06000446 RID: 1094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C5")]
		public float noiseScaleLocal
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x6A03E0", Offset = "0x69F5E0", VA = "0x1806A03E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x6A0C00", Offset = "0x69FE00", VA = "0x1806A0C00")]
			set
			{
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x000038B8 File Offset: 0x00001AB8
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C6")]
		public bool noiseVelocityUseGlobal
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0x4D49B0", Offset = "0x4D3BB0", VA = "0x1804D49B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x6A0D30", Offset = "0x69FF30", VA = "0x1806A0D30")]
			set
			{
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x000038D0 File Offset: 0x00001AD0
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C7")]
		public Vector3 noiseVelocityLocal
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x4D48B0", Offset = "0x4D3AB0", VA = "0x1804D48B0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600044A")]
			[Address(RVA = "0x6A0C90", Offset = "0x69FE90", VA = "0x1806A0C90")]
			set
			{
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x000038E8 File Offset: 0x00001AE8
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C8")]
		public int raymarchingQualityID
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x6A0400", Offset = "0x69F600", VA = "0x1806A0400")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x6A0D70", Offset = "0x69FF70", VA = "0x1806A0D70")]
			set
			{
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x00003900 File Offset: 0x00001B00
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C9")]
		public int raymarchingQualityIndex
		{
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x6A0410", Offset = "0x69F610", VA = "0x1806A0410")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x6A0DB0", Offset = "0x69FFB0", VA = "0x1806A0DB0")]
			set
			{
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600044F")]
		[Address(RVA = "0x4B4760", Offset = "0x4B3960", VA = "0x1804B4760", Slot = "4")]
		public override BeamGeometryAbstractBase GetBeamGeometry()
		{
			return null;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000450")]
		[Address(RVA = "0x69FC30", Offset = "0x69EE30", VA = "0x18069FC30", Slot = "5")]
		protected override void SetBeamGeometryNull()
		{
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x00003918 File Offset: 0x00001B18
		[Token(Token = "0x170000CA")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x6A01B0", Offset = "0x69F3B0", VA = "0x1806A01B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x00003930 File Offset: 0x00001B30
		[Token(Token = "0x170000CB")]
		public Quaternion beamInternalLocalRotation
		{
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x69FFE0", Offset = "0x69F1E0", VA = "0x18069FFE0")]
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x00003948 File Offset: 0x00001B48
		[Token(Token = "0x170000CC")]
		public Vector3 beamLocalForward
		{
			[Token(Token = "0x6000453")]
			[Address(RVA = "0x6A0100", Offset = "0x69F300", VA = "0x1806A0100")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00003960 File Offset: 0x00001B60
		[Token(Token = "0x170000CD")]
		public Vector3 beamGlobalForward
		{
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x69FEF0", Offset = "0x69F0F0", VA = "0x18069FEF0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00003978 File Offset: 0x00001B78
		[Token(Token = "0x6000455")]
		[Address(RVA = "0x69F9E0", Offset = "0x69EBE0", VA = "0x18069F9E0", Slot = "7")]
		public override Vector3 GetLossyScale()
		{
			return default(Vector3);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x69F650", Offset = "0x69E850", VA = "0x18069F650")]
		public VolumetricCookieHD GetAdditionalComponentCookie()
		{
			return null;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000457")]
		[Address(RVA = "0x69F690", Offset = "0x69E890", VA = "0x18069F690")]
		public VolumetricShadowHD GetAdditionalComponentShadow()
		{
			return null;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000458")]
		[Address(RVA = "0x69FC50", Offset = "0x69EE50", VA = "0x18069FC50")]
		public void SetPropertyDirty(DirtyProps flags)
		{
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00003990 File Offset: 0x00001B90
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x490CA0", Offset = "0x48FEA0", VA = "0x180490CA0", Slot = "8")]
		public virtual Dimensions GetDimensions()
		{
			return Dimensions.Dim3D;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x000039A8 File Offset: 0x00001BA8
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "9")]
		public virtual bool DoesSupportSorting2D()
		{
			return default(bool);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x000039C0 File Offset: 0x00001BC0
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x490CA0", Offset = "0x48FEA0", VA = "0x180490CA0", Slot = "10")]
		public virtual int GetSortingLayerID()
		{
			return 0;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x000039D8 File Offset: 0x00001BD8
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x490CA0", Offset = "0x48FEA0", VA = "0x180490CA0", Slot = "11")]
		public virtual int GetSortingOrder()
		{
			return 0;
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x000039F0 File Offset: 0x00001BF0
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CE")]
		public uint _INTERNAL_InstancedMaterialGroupID
		{
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x69FED0", Offset = "0x69F0D0", VA = "0x18069FED0")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x6A06A0", Offset = "0x69F8A0", VA = "0x1806A06A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00003A08 File Offset: 0x00001C08
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x69F960", Offset = "0x69EB60", VA = "0x18069F960")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return 0f;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00003A20 File Offset: 0x00001C20
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x69F780", Offset = "0x69E980", VA = "0x18069F780")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return 0f;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000461")]
		[Address(RVA = "0x69F1E0", Offset = "0x69E3E0", VA = "0x18069F1E0", Slot = "12")]
		public virtual void GenerateGeometry()
		{
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x69FD70", Offset = "0x69EF70", VA = "0x18069FD70", Slot = "13")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000463")]
		[Address(RVA = "0x69FD40", Offset = "0x69EF40", VA = "0x18069FD40")]
		private void Start()
		{
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x69FBB0", Offset = "0x69EDB0", VA = "0x18069FBB0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x69FB30", Offset = "0x69ED30", VA = "0x18069FB30")]
		private void OnDisable()
		{
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x69FB00", Offset = "0x69ED00", VA = "0x18069FB00")]
		private void OnDidApplyAnimationProperties()
		{
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000467")]
		[Address(RVA = "0x69EC20", Offset = "0x69DE20", VA = "0x18069EC20")]
		public void AssignPropertiesFromAttachedSpotLight()
		{
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000468")]
		[Address(RVA = "0x69F0C0", Offset = "0x69E2C0", VA = "0x18069F0C0")]
		private void ClampProperties()
		{
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x69FDA0", Offset = "0x69EFA0", VA = "0x18069FDA0")]
		private void ValidateProperties()
		{
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046A")]
		[Address(RVA = "0x69FAE0", Offset = "0x69ECE0", VA = "0x18069FAE0")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x69E900", Offset = "0x69DB00", VA = "0x18069E900")]
		public VolumetricLightBeamHD()
		{
		}

		// Token: 0x04000592 RID: 1426
		[Token(Token = "0x4000592")]
		public new const string ClassName = "VolumetricLightBeamHD";

		// Token: 0x04000593 RID: 1427
		[Token(Token = "0x4000593")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_ColorFromLight;

		// Token: 0x04000594 RID: 1428
		[Token(Token = "0x4000594")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private ColorMode m_ColorMode;

		// Token: 0x04000595 RID: 1429
		[Token(Token = "0x4000595")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color m_ColorFlat;

		// Token: 0x04000596 RID: 1430
		[Token(Token = "0x4000596")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Gradient m_ColorGradient;

		// Token: 0x04000597 RID: 1431
		[Token(Token = "0x4000597")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BlendingMode m_BlendingMode;

		// Token: 0x04000598 RID: 1432
		[Token(Token = "0x4000598")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_Intensity;

		// Token: 0x04000599 RID: 1433
		[Token(Token = "0x4000599")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_IntensityMultiplier;

		// Token: 0x0400059A RID: 1434
		[Token(Token = "0x400059A")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_HDRPExposureWeight;

		// Token: 0x0400059B RID: 1435
		[Token(Token = "0x400059B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float m_SpotAngle;

		// Token: 0x0400059C RID: 1436
		[Token(Token = "0x400059C")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_SpotAngleMultiplier;

		// Token: 0x0400059D RID: 1437
		[Token(Token = "0x400059D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_ConeRadiusStart;

		// Token: 0x0400059E RID: 1438
		[Token(Token = "0x400059E")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private bool m_Scalable;

		// Token: 0x0400059F RID: 1439
		[Token(Token = "0x400059F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float m_FallOffStart;

		// Token: 0x040005A0 RID: 1440
		[Token(Token = "0x40005A0")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float m_FallOffEnd;

		// Token: 0x040005A1 RID: 1441
		[Token(Token = "0x40005A1")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float m_FallOffEndMultiplier;

		// Token: 0x040005A2 RID: 1442
		[Token(Token = "0x40005A2")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private AttenuationEquationHD m_AttenuationEquation;

		// Token: 0x040005A3 RID: 1443
		[Token(Token = "0x40005A3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float m_SideSoftness;

		// Token: 0x040005A4 RID: 1444
		[Token(Token = "0x40005A4")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private int m_RaymarchingQualityID;

		// Token: 0x040005A5 RID: 1445
		[Token(Token = "0x40005A5")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float m_JitteringFactor;

		// Token: 0x040005A6 RID: 1446
		[Token(Token = "0x40005A6")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private int m_JitteringFrameRate;

		// Token: 0x040005A7 RID: 1447
		[Token(Token = "0x40005A7")]
		[FieldOffset(Offset = "0x90")]
		[MinMaxRange(0f, 1f)]
		[SerializeField]
		private MinMaxRangeFloat m_JitteringLerpRange;

		// Token: 0x040005A8 RID: 1448
		[Token(Token = "0x40005A8")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private NoiseMode m_NoiseMode;

		// Token: 0x040005A9 RID: 1449
		[Token(Token = "0x40005A9")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float m_NoiseIntensity;

		// Token: 0x040005AA RID: 1450
		[Token(Token = "0x40005AA")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private bool m_NoiseScaleUseGlobal;

		// Token: 0x040005AB RID: 1451
		[Token(Token = "0x40005AB")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private float m_NoiseScaleLocal;

		// Token: 0x040005AC RID: 1452
		[Token(Token = "0x40005AC")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private bool m_NoiseVelocityUseGlobal;

		// Token: 0x040005AD RID: 1453
		[Token(Token = "0x40005AD")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private Vector3 m_NoiseVelocityLocal;

		// Token: 0x040005AF RID: 1455
		[Token(Token = "0x40005AF")]
		[FieldOffset(Offset = "0xC0")]
		protected BeamGeometryHD m_BeamGeom;
	}
}
