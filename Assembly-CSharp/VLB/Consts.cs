using System;
using Il2CppDummyDll;
using UnityEngine;

namespace VLB
{
	// Token: 0x020000E4 RID: 228
	[Token(Token = "0x20000E4")]
	public static class Consts
	{
		// Token: 0x0400044C RID: 1100
		[Token(Token = "0x400044C")]
		public const string PluginFolder = "VolumetricLightBeam";

		// Token: 0x020000E5 RID: 229
		[Token(Token = "0x20000E5")]
		public static class Help
		{
			// Token: 0x0400044D RID: 1101
			[Token(Token = "0x400044D")]
			private const string UrlBase = "http://saladgamer.com/vlb-doc/";

			// Token: 0x0400044E RID: 1102
			[Token(Token = "0x400044E")]
			private const string UrlSuffix = "/";

			// Token: 0x0400044F RID: 1103
			[Token(Token = "0x400044F")]
			public const string UrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/";

			// Token: 0x04000450 RID: 1104
			[Token(Token = "0x4000450")]
			public const string UrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/";

			// Token: 0x04000451 RID: 1105
			[Token(Token = "0x4000451")]
			public const string UrlEffectFlicker = "http://saladgamer.com/vlb-doc/comp-effect-flicker/";

			// Token: 0x04000452 RID: 1106
			[Token(Token = "0x4000452")]
			public const string UrlEffectPulse = "http://saladgamer.com/vlb-doc/comp-effect-pulse/";

			// Token: 0x04000453 RID: 1107
			[Token(Token = "0x4000453")]
			public const string UrlEffectFromProfile = "http://saladgamer.com/vlb-doc/comp-effect-from-profile/";

			// Token: 0x04000454 RID: 1108
			[Token(Token = "0x4000454")]
			public const string UrlConfig = "http://saladgamer.com/vlb-doc/config/";

			// Token: 0x020000E6 RID: 230
			[Token(Token = "0x20000E6")]
			public static class SD
			{
				// Token: 0x04000455 RID: 1109
				[Token(Token = "0x4000455")]
				public const string UrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam-sd/";

				// Token: 0x04000456 RID: 1110
				[Token(Token = "0x4000456")]
				public const string UrlDynamicOcclusionRaycasting = "http://saladgamer.com/vlb-doc/comp-dynocclusion-sd-raycasting/";

				// Token: 0x04000457 RID: 1111
				[Token(Token = "0x4000457")]
				public const string UrlDynamicOcclusionDepthBuffer = "http://saladgamer.com/vlb-doc/comp-dynocclusion-sd-depthbuffer/";

				// Token: 0x04000458 RID: 1112
				[Token(Token = "0x4000458")]
				public const string UrlSkewingHandle = "http://saladgamer.com/vlb-doc/comp-skewinghandle-sd/";
			}

			// Token: 0x020000E7 RID: 231
			[Token(Token = "0x20000E7")]
			public static class HD
			{
				// Token: 0x04000459 RID: 1113
				[Token(Token = "0x4000459")]
				public const string UrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam-hd/";

				// Token: 0x0400045A RID: 1114
				[Token(Token = "0x400045A")]
				public const string UrlShadow = "http://saladgamer.com/vlb-doc/comp-shadow-hd/";

				// Token: 0x0400045B RID: 1115
				[Token(Token = "0x400045B")]
				public const string UrlCookie = "http://saladgamer.com/vlb-doc/comp-cookie-hd/";

				// Token: 0x0400045C RID: 1116
				[Token(Token = "0x400045C")]
				public const string UrlTrackRealtimeChangesOnLight = "http://saladgamer.com/vlb-doc/comp-trackrealtimechanges-hd/";
			}
		}

		// Token: 0x020000E8 RID: 232
		[Token(Token = "0x20000E8")]
		public static class Internal
		{
			// Token: 0x17000089 RID: 137
			// (get) Token: 0x06000388 RID: 904 RVA: 0x00003378 File Offset: 0x00001578
			[Token(Token = "0x17000089")]
			public static HideFlags ProceduralObjectsHideFlags
			{
				[Token(Token = "0x6000388")]
				[Address(RVA = "0x695BA0", Offset = "0x694DA0", VA = "0x180695BA0")]
				get
				{
					return HideFlags.None;
				}
			}

			// Token: 0x0400045D RID: 1117
			[Token(Token = "0x400045D")]
			[FieldOffset(Offset = "0x0")]
			public static readonly bool ProceduralObjectsVisibleInEditor;
		}

		// Token: 0x020000E9 RID: 233
		[Token(Token = "0x20000E9")]
		public static class Beam
		{
			// Token: 0x0400045E RID: 1118
			[Token(Token = "0x400045E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly Color FlatColor;

			// Token: 0x0400045F RID: 1119
			[Token(Token = "0x400045F")]
			public const ColorMode ColorModeDefault = ColorMode.Flat;

			// Token: 0x04000460 RID: 1120
			[Token(Token = "0x4000460")]
			public const float MultiplierDefault = 1f;

			// Token: 0x04000461 RID: 1121
			[Token(Token = "0x4000461")]
			public const float MultiplierMin = 0f;

			// Token: 0x04000462 RID: 1122
			[Token(Token = "0x4000462")]
			public const float IntensityDefault = 1f;

			// Token: 0x04000463 RID: 1123
			[Token(Token = "0x4000463")]
			public const float IntensityMin = 0f;

			// Token: 0x04000464 RID: 1124
			[Token(Token = "0x4000464")]
			public const float HDRPExposureWeightDefault = 0f;

			// Token: 0x04000465 RID: 1125
			[Token(Token = "0x4000465")]
			public const float HDRPExposureWeightMin = 0f;

			// Token: 0x04000466 RID: 1126
			[Token(Token = "0x4000466")]
			public const float HDRPExposureWeightMax = 1f;

			// Token: 0x04000467 RID: 1127
			[Token(Token = "0x4000467")]
			public const float SpotAngleDefault = 35f;

			// Token: 0x04000468 RID: 1128
			[Token(Token = "0x4000468")]
			public const float SpotAngleMin = 0.1f;

			// Token: 0x04000469 RID: 1129
			[Token(Token = "0x4000469")]
			public const float SpotAngleMax = 179.9f;

			// Token: 0x0400046A RID: 1130
			[Token(Token = "0x400046A")]
			public const float ConeRadiusStart = 0.1f;

			// Token: 0x0400046B RID: 1131
			[Token(Token = "0x400046B")]
			public const MeshType GeomMeshType = MeshType.Shared;

			// Token: 0x0400046C RID: 1132
			[Token(Token = "0x400046C")]
			public const int GeomSidesDefault = 18;

			// Token: 0x0400046D RID: 1133
			[Token(Token = "0x400046D")]
			public const int GeomSidesMin = 3;

			// Token: 0x0400046E RID: 1134
			[Token(Token = "0x400046E")]
			public const int GeomSidesMax = 256;

			// Token: 0x0400046F RID: 1135
			[Token(Token = "0x400046F")]
			public const int GeomSegmentsDefault = 5;

			// Token: 0x04000470 RID: 1136
			[Token(Token = "0x4000470")]
			public const int GeomSegmentsMin = 0;

			// Token: 0x04000471 RID: 1137
			[Token(Token = "0x4000471")]
			public const int GeomSegmentsMax = 64;

			// Token: 0x04000472 RID: 1138
			[Token(Token = "0x4000472")]
			public const bool GeomCap = false;

			// Token: 0x04000473 RID: 1139
			[Token(Token = "0x4000473")]
			public const bool ScalableDefault = true;

			// Token: 0x04000474 RID: 1140
			[Token(Token = "0x4000474")]
			public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic;

			// Token: 0x04000475 RID: 1141
			[Token(Token = "0x4000475")]
			public const float AttenuationCustomBlendingDefault = 0.5f;

			// Token: 0x04000476 RID: 1142
			[Token(Token = "0x4000476")]
			public const float AttenuationCustomBlendingMin = 0f;

			// Token: 0x04000477 RID: 1143
			[Token(Token = "0x4000477")]
			public const float AttenuationCustomBlendingMax = 1f;

			// Token: 0x04000478 RID: 1144
			[Token(Token = "0x4000478")]
			public const float FallOffStart = 0f;

			// Token: 0x04000479 RID: 1145
			[Token(Token = "0x4000479")]
			public const float FallOffEnd = 3f;

			// Token: 0x0400047A RID: 1146
			[Token(Token = "0x400047A")]
			public const float FallOffDistancesMinThreshold = 0.01f;

			// Token: 0x0400047B RID: 1147
			[Token(Token = "0x400047B")]
			public const float DepthBlendDistance = 2f;

			// Token: 0x0400047C RID: 1148
			[Token(Token = "0x400047C")]
			public const float CameraClippingDistance = 0.5f;

			// Token: 0x0400047D RID: 1149
			[Token(Token = "0x400047D")]
			public const NoiseMode NoiseModeDefault = NoiseMode.Disabled;

			// Token: 0x0400047E RID: 1150
			[Token(Token = "0x400047E")]
			public const float NoiseIntensityMin = 0f;

			// Token: 0x0400047F RID: 1151
			[Token(Token = "0x400047F")]
			public const float NoiseIntensityMax = 1f;

			// Token: 0x04000480 RID: 1152
			[Token(Token = "0x4000480")]
			public const float NoiseIntensityDefault = 0.5f;

			// Token: 0x04000481 RID: 1153
			[Token(Token = "0x4000481")]
			public const float NoiseScaleMin = 0.01f;

			// Token: 0x04000482 RID: 1154
			[Token(Token = "0x4000482")]
			public const float NoiseScaleMax = 2f;

			// Token: 0x04000483 RID: 1155
			[Token(Token = "0x4000483")]
			public const float NoiseScaleDefault = 0.5f;

			// Token: 0x04000484 RID: 1156
			[Token(Token = "0x4000484")]
			[FieldOffset(Offset = "0x10")]
			public static readonly Vector3 NoiseVelocityDefault;

			// Token: 0x04000485 RID: 1157
			[Token(Token = "0x4000485")]
			public const BlendingMode BlendingModeDefault = BlendingMode.Additive;

			// Token: 0x04000486 RID: 1158
			[Token(Token = "0x4000486")]
			public const ShaderAccuracy ShaderAccuracyDefault = ShaderAccuracy.Fast;

			// Token: 0x04000487 RID: 1159
			[Token(Token = "0x4000487")]
			public const float FadeOutBeginDefault = -150f;

			// Token: 0x04000488 RID: 1160
			[Token(Token = "0x4000488")]
			public const float FadeOutEndDefault = -200f;

			// Token: 0x04000489 RID: 1161
			[Token(Token = "0x4000489")]
			public const Dimensions DimensionsDefault = Dimensions.Dim3D;

			// Token: 0x020000EA RID: 234
			[Token(Token = "0x20000EA")]
			public static class SD
			{
				// Token: 0x0400048A RID: 1162
				[Token(Token = "0x400048A")]
				public const float FresnelPowMaxValue = 10f;

				// Token: 0x0400048B RID: 1163
				[Token(Token = "0x400048B")]
				public const float FresnelPow = 8f;

				// Token: 0x0400048C RID: 1164
				[Token(Token = "0x400048C")]
				public const float GlareFrontalDefault = 0.5f;

				// Token: 0x0400048D RID: 1165
				[Token(Token = "0x400048D")]
				public const float GlareBehindDefault = 0.5f;

				// Token: 0x0400048E RID: 1166
				[Token(Token = "0x400048E")]
				public const float GlareMin = 0f;

				// Token: 0x0400048F RID: 1167
				[Token(Token = "0x400048F")]
				public const float GlareMax = 1f;

				// Token: 0x04000490 RID: 1168
				[Token(Token = "0x4000490")]
				[FieldOffset(Offset = "0x0")]
				public static readonly Vector2 TiltDefault;

				// Token: 0x04000491 RID: 1169
				[Token(Token = "0x4000491")]
				[FieldOffset(Offset = "0x8")]
				public static readonly Vector3 SkewingLocalForwardDirectionDefault;

				// Token: 0x04000492 RID: 1170
				[Token(Token = "0x4000492")]
				public const Transform ClippingPlaneTransformDefault;
			}

			// Token: 0x020000EB RID: 235
			[Token(Token = "0x20000EB")]
			public static class HD
			{
				// Token: 0x04000493 RID: 1171
				[Token(Token = "0x4000493")]
				public const AttenuationEquationHD AttenuationEquationDefault = AttenuationEquationHD.Quadratic;

				// Token: 0x04000494 RID: 1172
				[Token(Token = "0x4000494")]
				public const float SideSoftnessDefault = 1f;

				// Token: 0x04000495 RID: 1173
				[Token(Token = "0x4000495")]
				public const float SideSoftnessMin = 0.0001f;

				// Token: 0x04000496 RID: 1174
				[Token(Token = "0x4000496")]
				public const float SideSoftnessMax = 10f;

				// Token: 0x04000497 RID: 1175
				[Token(Token = "0x4000497")]
				public const float JitteringFactorDefault = 0f;

				// Token: 0x04000498 RID: 1176
				[Token(Token = "0x4000498")]
				public const float JitteringFactorMin = 0f;

				// Token: 0x04000499 RID: 1177
				[Token(Token = "0x4000499")]
				public const int JitteringFrameRateDefault = 60;

				// Token: 0x0400049A RID: 1178
				[Token(Token = "0x400049A")]
				public const int JitteringFrameRateMin = 0;

				// Token: 0x0400049B RID: 1179
				[Token(Token = "0x400049B")]
				public const int JitteringFrameRateMax = 120;

				// Token: 0x0400049C RID: 1180
				[Token(Token = "0x400049C")]
				[FieldOffset(Offset = "0x0")]
				public static readonly MinMaxRangeFloat JitteringLerpRange;
			}
		}

		// Token: 0x020000EC RID: 236
		[Token(Token = "0x20000EC")]
		public static class DustParticles
		{
			// Token: 0x0400049D RID: 1181
			[Token(Token = "0x400049D")]
			public const float AlphaDefault = 0.5f;

			// Token: 0x0400049E RID: 1182
			[Token(Token = "0x400049E")]
			public const float SizeDefault = 0.01f;

			// Token: 0x0400049F RID: 1183
			[Token(Token = "0x400049F")]
			public const ParticlesDirection DirectionDefault = ParticlesDirection.Random;

			// Token: 0x040004A0 RID: 1184
			[Token(Token = "0x40004A0")]
			[FieldOffset(Offset = "0x0")]
			public static readonly Vector3 VelocityDefault;

			// Token: 0x040004A1 RID: 1185
			[Token(Token = "0x40004A1")]
			public const float DensityDefault = 5f;

			// Token: 0x040004A2 RID: 1186
			[Token(Token = "0x40004A2")]
			public const float DensityMin = 0f;

			// Token: 0x040004A3 RID: 1187
			[Token(Token = "0x40004A3")]
			public const float DensityMax = 1000f;

			// Token: 0x040004A4 RID: 1188
			[Token(Token = "0x40004A4")]
			[FieldOffset(Offset = "0xC")]
			public static readonly MinMaxRangeFloat SpawnDistanceRangeDefault;

			// Token: 0x040004A5 RID: 1189
			[Token(Token = "0x40004A5")]
			public const bool CullingEnabledDefault = false;

			// Token: 0x040004A6 RID: 1190
			[Token(Token = "0x40004A6")]
			public const float CullingMaxDistanceDefault = 10f;

			// Token: 0x040004A7 RID: 1191
			[Token(Token = "0x40004A7")]
			public const float CullingMaxDistanceMin = 1f;
		}

		// Token: 0x020000ED RID: 237
		[Token(Token = "0x20000ED")]
		public static class DynOcclusion
		{
			// Token: 0x040004A8 RID: 1192
			[Token(Token = "0x40004A8")]
			[FieldOffset(Offset = "0x0")]
			public static readonly LayerMask LayerMaskDefault;

			// Token: 0x040004A9 RID: 1193
			[Token(Token = "0x40004A9")]
			public const DynamicOcclusionUpdateRate UpdateRateDefault = DynamicOcclusionUpdateRate.EveryXFrames;

			// Token: 0x040004AA RID: 1194
			[Token(Token = "0x40004AA")]
			public const int WaitFramesCountDefault = 3;

			// Token: 0x040004AB RID: 1195
			[Token(Token = "0x40004AB")]
			public const Dimensions RaycastingDimensionsDefault = Dimensions.Dim3D;

			// Token: 0x040004AC RID: 1196
			[Token(Token = "0x40004AC")]
			public const bool RaycastingConsiderTriggersDefault = false;

			// Token: 0x040004AD RID: 1197
			[Token(Token = "0x40004AD")]
			public const float RaycastingMinOccluderAreaDefault = 0f;

			// Token: 0x040004AE RID: 1198
			[Token(Token = "0x40004AE")]
			public const float RaycastingMinSurfaceRatioDefault = 0.5f;

			// Token: 0x040004AF RID: 1199
			[Token(Token = "0x40004AF")]
			public const float RaycastingMinSurfaceRatioMin = 50f;

			// Token: 0x040004B0 RID: 1200
			[Token(Token = "0x40004B0")]
			public const float RaycastingMinSurfaceRatioMax = 100f;

			// Token: 0x040004B1 RID: 1201
			[Token(Token = "0x40004B1")]
			public const float RaycastingMaxSurfaceDotDefault = 0.25f;

			// Token: 0x040004B2 RID: 1202
			[Token(Token = "0x40004B2")]
			public const float RaycastingMaxSurfaceAngleMin = 45f;

			// Token: 0x040004B3 RID: 1203
			[Token(Token = "0x40004B3")]
			public const float RaycastingMaxSurfaceAngleMax = 90f;

			// Token: 0x040004B4 RID: 1204
			[Token(Token = "0x40004B4")]
			public const PlaneAlignment RaycastingPlaneAlignmentDefault = PlaneAlignment.Surface;

			// Token: 0x040004B5 RID: 1205
			[Token(Token = "0x40004B5")]
			public const float RaycastingPlaneOffsetDefault = 0.1f;

			// Token: 0x040004B6 RID: 1206
			[Token(Token = "0x40004B6")]
			public const float RaycastingFadeDistanceToSurfaceDefault = 0.25f;

			// Token: 0x040004B7 RID: 1207
			[Token(Token = "0x40004B7")]
			public const int DepthBufferDepthMapResolutionDefault = 128;

			// Token: 0x040004B8 RID: 1208
			[Token(Token = "0x40004B8")]
			public const bool DepthBufferOcclusionCullingDefault = true;

			// Token: 0x040004B9 RID: 1209
			[Token(Token = "0x40004B9")]
			public const float DepthBufferFadeDistanceToSurfaceDefault = 0f;
		}

		// Token: 0x020000EE RID: 238
		[Token(Token = "0x20000EE")]
		public static class Effects
		{
			// Token: 0x040004BA RID: 1210
			[Token(Token = "0x40004BA")]
			public const EffectAbstractBase.ComponentsToChange ComponentsToChangeDefault = (EffectAbstractBase.ComponentsToChange)2147483647;

			// Token: 0x040004BB RID: 1211
			[Token(Token = "0x40004BB")]
			public const bool RestoreIntensityOnDisableDefault = true;

			// Token: 0x040004BC RID: 1212
			[Token(Token = "0x40004BC")]
			public const float FrequencyDefault = 10f;

			// Token: 0x040004BD RID: 1213
			[Token(Token = "0x40004BD")]
			public const bool PerformPausesDefault = false;

			// Token: 0x040004BE RID: 1214
			[Token(Token = "0x40004BE")]
			public const bool RestoreIntensityOnPauseDefault = false;

			// Token: 0x040004BF RID: 1215
			[Token(Token = "0x40004BF")]
			[FieldOffset(Offset = "0x0")]
			public static readonly MinMaxRangeFloat FlickeringDurationDefault;

			// Token: 0x040004C0 RID: 1216
			[Token(Token = "0x40004C0")]
			[FieldOffset(Offset = "0x8")]
			public static readonly MinMaxRangeFloat PauseDurationDefault;

			// Token: 0x040004C1 RID: 1217
			[Token(Token = "0x40004C1")]
			[FieldOffset(Offset = "0x10")]
			public static readonly MinMaxRangeFloat IntensityAmplitudeDefault;

			// Token: 0x040004C2 RID: 1218
			[Token(Token = "0x40004C2")]
			public const float SmoothingDefault = 0.05f;
		}

		// Token: 0x020000EF RID: 239
		[Token(Token = "0x20000EF")]
		public static class Shadow
		{
			// Token: 0x06000390 RID: 912 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x69CAD0", Offset = "0x69BCD0", VA = "0x18069CAD0")]
			public static string GetErrorChangeRuntimeDepthMapResolution(VolumetricShadowHD comp)
			{
				return null;
			}

			// Token: 0x040004C3 RID: 1219
			[Token(Token = "0x40004C3")]
			public const float StrengthDefault = 1f;

			// Token: 0x040004C4 RID: 1220
			[Token(Token = "0x40004C4")]
			public const float StrengthMin = 0f;

			// Token: 0x040004C5 RID: 1221
			[Token(Token = "0x40004C5")]
			public const float StrengthMax = 1f;

			// Token: 0x040004C6 RID: 1222
			[Token(Token = "0x40004C6")]
			[FieldOffset(Offset = "0x0")]
			public static readonly LayerMask LayerMaskDefault;

			// Token: 0x040004C7 RID: 1223
			[Token(Token = "0x40004C7")]
			public const ShadowUpdateRate UpdateRateDefault = ShadowUpdateRate.EveryXFrames;

			// Token: 0x040004C8 RID: 1224
			[Token(Token = "0x40004C8")]
			public const int WaitFramesCountDefault = 3;

			// Token: 0x040004C9 RID: 1225
			[Token(Token = "0x40004C9")]
			public const int DepthMapResolutionDefault = 128;

			// Token: 0x040004CA RID: 1226
			[Token(Token = "0x40004CA")]
			public const bool OcclusionCullingDefault = true;
		}

		// Token: 0x020000F0 RID: 240
		[Token(Token = "0x20000F0")]
		public static class Cookie
		{
			// Token: 0x040004CB RID: 1227
			[Token(Token = "0x40004CB")]
			public const float ContributionDefault = 1f;

			// Token: 0x040004CC RID: 1228
			[Token(Token = "0x40004CC")]
			public const float ContributionMin = 0f;

			// Token: 0x040004CD RID: 1229
			[Token(Token = "0x40004CD")]
			public const float ContributionMax = 1f;

			// Token: 0x040004CE RID: 1230
			[Token(Token = "0x40004CE")]
			public const Texture CookieTextureDefault;

			// Token: 0x040004CF RID: 1231
			[Token(Token = "0x40004CF")]
			public const CookieChannel ChannelDefault = CookieChannel.Alpha;

			// Token: 0x040004D0 RID: 1232
			[Token(Token = "0x40004D0")]
			public const bool NegativeDefault = false;

			// Token: 0x040004D1 RID: 1233
			[Token(Token = "0x40004D1")]
			[FieldOffset(Offset = "0x0")]
			public static readonly Vector2 TranslationDefault;

			// Token: 0x040004D2 RID: 1234
			[Token(Token = "0x40004D2")]
			public const float RotationDefault = 0f;

			// Token: 0x040004D3 RID: 1235
			[Token(Token = "0x40004D3")]
			[FieldOffset(Offset = "0x8")]
			public static readonly Vector2 ScaleDefault;
		}

		// Token: 0x020000F1 RID: 241
		[Token(Token = "0x20000F1")]
		public static class Config
		{
			// Token: 0x040004D4 RID: 1236
			[Token(Token = "0x40004D4")]
			public const bool GeometryOverrideLayerDefault = true;

			// Token: 0x040004D5 RID: 1237
			[Token(Token = "0x40004D5")]
			public const int GeometryLayerIDDefault = 1;

			// Token: 0x040004D6 RID: 1238
			[Token(Token = "0x40004D6")]
			public const string GeometryTagDefault = "Untagged";

			// Token: 0x040004D7 RID: 1239
			[Token(Token = "0x40004D7")]
			public const string FadeOutCameraTagDefault = "MainCamera";

			// Token: 0x040004D8 RID: 1240
			[Token(Token = "0x40004D8")]
			public const RenderQueue GeometryRenderQueueDefault = RenderQueue.Transparent;

			// Token: 0x040004D9 RID: 1241
			[Token(Token = "0x40004D9")]
			public const RenderPipeline GeometryRenderPipelineDefault = RenderPipeline.BuiltIn;

			// Token: 0x040004DA RID: 1242
			[Token(Token = "0x40004DA")]
			public const RenderingMode GeometryRenderingModeDefault = RenderingMode.Default;

			// Token: 0x040004DB RID: 1243
			[Token(Token = "0x40004DB")]
			public const int Noise3DSizeDefault = 64;

			// Token: 0x040004DC RID: 1244
			[Token(Token = "0x40004DC")]
			public const float DitheringFactor = 0f;

			// Token: 0x040004DD RID: 1245
			[Token(Token = "0x40004DD")]
			public const bool UseLightColorTemperatureDefault = true;

			// Token: 0x040004DE RID: 1246
			[Token(Token = "0x40004DE")]
			public const bool FeatureEnabledDefault = true;

			// Token: 0x040004DF RID: 1247
			[Token(Token = "0x40004DF")]
			public const FeatureEnabledColorGradient FeatureEnabledColorGradientDefault = FeatureEnabledColorGradient.HighOnly;

			// Token: 0x040004E0 RID: 1248
			[Token(Token = "0x40004E0")]
			public const int SharedMeshSidesDefault = 24;

			// Token: 0x040004E1 RID: 1249
			[Token(Token = "0x40004E1")]
			public const int SharedMeshSidesMin = 3;

			// Token: 0x040004E2 RID: 1250
			[Token(Token = "0x40004E2")]
			public const int SharedMeshSidesMax = 256;

			// Token: 0x040004E3 RID: 1251
			[Token(Token = "0x40004E3")]
			public const int SharedMeshSegmentsDefault = 5;

			// Token: 0x040004E4 RID: 1252
			[Token(Token = "0x40004E4")]
			public const int SharedMeshSegmentsMin = 0;

			// Token: 0x040004E5 RID: 1253
			[Token(Token = "0x40004E5")]
			public const int SharedMeshSegmentsMax = 64;

			// Token: 0x020000F2 RID: 242
			[Token(Token = "0x20000F2")]
			public static class HD
			{
				// Token: 0x040004E6 RID: 1254
				[Token(Token = "0x40004E6")]
				public const RenderQueue GeometryRenderQueueDefault = (RenderQueue)3100;

				// Token: 0x040004E7 RID: 1255
				[Token(Token = "0x40004E7")]
				public const float CameraBlendingDistance = 0.5f;

				// Token: 0x040004E8 RID: 1256
				[Token(Token = "0x40004E8")]
				public const int RaymarchingQualitiesStepsMin = 2;
			}
		}
	}
}
