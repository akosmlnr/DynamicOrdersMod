using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace VLB
{
	// Token: 0x0200011C RID: 284
	[Token(Token = "0x200011C")]
	public static class MaterialManager
	{
		// Token: 0x0600049B RID: 1179 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x696510", Offset = "0x695710", VA = "0x180696510")]
		public static Material NewMaterialPersistent(Shader shader, bool gpuInstanced)
		{
			return null;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x696460", Offset = "0x695660", VA = "0x180696460")]
		public static Material GetInstancedMaterial(uint groupID, ref MaterialManager.StaticPropertiesSD staticProps)
		{
			return null;
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x696040", Offset = "0x695240", VA = "0x180696040")]
		public static Material GetInstancedMaterial(uint groupID, ref MaterialManager.StaticPropertiesHD staticProps)
		{
			return null;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x6960F0", Offset = "0x6952F0", VA = "0x1806960F0")]
		private static Material GetInstancedMaterial(Hashtable groups, uint groupID, ref MaterialManager.IStaticProperties staticProps)
		{
			return null;
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x696610", Offset = "0x695810", VA = "0x180696610")]
		private static void SetBlendingMode(this Material mat, int nameID, BlendMode value)
		{
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x696610", Offset = "0x695810", VA = "0x180696610")]
		private static void SetStencilRef(this Material mat, int nameID, int value)
		{
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x696610", Offset = "0x695810", VA = "0x180696610")]
		private static void SetStencilComp(this Material mat, int nameID, CompareFunction value)
		{
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x696610", Offset = "0x695810", VA = "0x180696610")]
		private static void SetStencilOp(this Material mat, int nameID, StencilOp value)
		{
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x696610", Offset = "0x695810", VA = "0x180696610")]
		private static void SetCull(this Material mat, int nameID, CullMode value)
		{
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x696610", Offset = "0x695810", VA = "0x180696610")]
		private static void SetZWrite(this Material mat, int nameID, MaterialManager.ZWrite value)
		{
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x696610", Offset = "0x695810", VA = "0x180696610")]
		private static void SetZTest(this Material mat, int nameID, CompareFunction value)
		{
		}

		// Token: 0x040005C6 RID: 1478
		[Token(Token = "0x40005C6")]
		[FieldOffset(Offset = "0x0")]
		public static MaterialPropertyBlock materialPropertyBlock;

		// Token: 0x040005C7 RID: 1479
		[Token(Token = "0x40005C7")]
		[FieldOffset(Offset = "0x8")]
		private static readonly BlendMode[] BlendingMode_SrcFactor;

		// Token: 0x040005C8 RID: 1480
		[Token(Token = "0x40005C8")]
		[FieldOffset(Offset = "0x10")]
		private static readonly BlendMode[] BlendingMode_DstFactor;

		// Token: 0x040005C9 RID: 1481
		[Token(Token = "0x40005C9")]
		[FieldOffset(Offset = "0x18")]
		private static readonly bool[] BlendingMode_AlphaAsBlack;

		// Token: 0x040005CA RID: 1482
		[Token(Token = "0x40005CA")]
		[FieldOffset(Offset = "0x20")]
		private static Hashtable ms_MaterialsGroupSD;

		// Token: 0x040005CB RID: 1483
		[Token(Token = "0x40005CB")]
		[FieldOffset(Offset = "0x28")]
		private static Hashtable ms_MaterialsGroupHD;

		// Token: 0x0200011D RID: 285
		[Token(Token = "0x200011D")]
		public enum BlendingMode
		{
			// Token: 0x040005CD RID: 1485
			[Token(Token = "0x40005CD")]
			Additive,
			// Token: 0x040005CE RID: 1486
			[Token(Token = "0x40005CE")]
			SoftAdditive,
			// Token: 0x040005CF RID: 1487
			[Token(Token = "0x40005CF")]
			TraditionalTransparency,
			// Token: 0x040005D0 RID: 1488
			[Token(Token = "0x40005D0")]
			Count
		}

		// Token: 0x0200011E RID: 286
		[Token(Token = "0x200011E")]
		public enum ColorGradient
		{
			// Token: 0x040005D2 RID: 1490
			[Token(Token = "0x40005D2")]
			Off,
			// Token: 0x040005D3 RID: 1491
			[Token(Token = "0x40005D3")]
			MatrixLow,
			// Token: 0x040005D4 RID: 1492
			[Token(Token = "0x40005D4")]
			MatrixHigh,
			// Token: 0x040005D5 RID: 1493
			[Token(Token = "0x40005D5")]
			Count
		}

		// Token: 0x0200011F RID: 287
		[Token(Token = "0x200011F")]
		public enum Noise3D
		{
			// Token: 0x040005D7 RID: 1495
			[Token(Token = "0x40005D7")]
			Off,
			// Token: 0x040005D8 RID: 1496
			[Token(Token = "0x40005D8")]
			On,
			// Token: 0x040005D9 RID: 1497
			[Token(Token = "0x40005D9")]
			Count
		}

		// Token: 0x02000120 RID: 288
		[Token(Token = "0x2000120")]
		public static class SD
		{
			// Token: 0x02000121 RID: 289
			[Token(Token = "0x2000121")]
			public enum DepthBlend
			{
				// Token: 0x040005DB RID: 1499
				[Token(Token = "0x40005DB")]
				Off,
				// Token: 0x040005DC RID: 1500
				[Token(Token = "0x40005DC")]
				On,
				// Token: 0x040005DD RID: 1501
				[Token(Token = "0x40005DD")]
				Count
			}

			// Token: 0x02000122 RID: 290
			[Token(Token = "0x2000122")]
			public enum DynamicOcclusion
			{
				// Token: 0x040005DF RID: 1503
				[Token(Token = "0x40005DF")]
				Off,
				// Token: 0x040005E0 RID: 1504
				[Token(Token = "0x40005E0")]
				ClippingPlane,
				// Token: 0x040005E1 RID: 1505
				[Token(Token = "0x40005E1")]
				DepthTexture,
				// Token: 0x040005E2 RID: 1506
				[Token(Token = "0x40005E2")]
				Count
			}

			// Token: 0x02000123 RID: 291
			[Token(Token = "0x2000123")]
			public enum MeshSkewing
			{
				// Token: 0x040005E4 RID: 1508
				[Token(Token = "0x40005E4")]
				Off,
				// Token: 0x040005E5 RID: 1509
				[Token(Token = "0x40005E5")]
				On,
				// Token: 0x040005E6 RID: 1510
				[Token(Token = "0x40005E6")]
				Count
			}

			// Token: 0x02000124 RID: 292
			[Token(Token = "0x2000124")]
			public enum ShaderAccuracy
			{
				// Token: 0x040005E8 RID: 1512
				[Token(Token = "0x40005E8")]
				Fast,
				// Token: 0x040005E9 RID: 1513
				[Token(Token = "0x40005E9")]
				High,
				// Token: 0x040005EA RID: 1514
				[Token(Token = "0x40005EA")]
				Count
			}
		}

		// Token: 0x02000125 RID: 293
		[Token(Token = "0x2000125")]
		public static class HD
		{
			// Token: 0x02000126 RID: 294
			[Token(Token = "0x2000126")]
			public enum Attenuation
			{
				// Token: 0x040005EC RID: 1516
				[Token(Token = "0x40005EC")]
				Linear,
				// Token: 0x040005ED RID: 1517
				[Token(Token = "0x40005ED")]
				Quadratic,
				// Token: 0x040005EE RID: 1518
				[Token(Token = "0x40005EE")]
				Count
			}

			// Token: 0x02000127 RID: 295
			[Token(Token = "0x2000127")]
			public enum Shadow
			{
				// Token: 0x040005F0 RID: 1520
				[Token(Token = "0x40005F0")]
				Off,
				// Token: 0x040005F1 RID: 1521
				[Token(Token = "0x40005F1")]
				On,
				// Token: 0x040005F2 RID: 1522
				[Token(Token = "0x40005F2")]
				Count
			}

			// Token: 0x02000128 RID: 296
			[Token(Token = "0x2000128")]
			public enum Cookie
			{
				// Token: 0x040005F4 RID: 1524
				[Token(Token = "0x40005F4")]
				Off,
				// Token: 0x040005F5 RID: 1525
				[Token(Token = "0x40005F5")]
				SingleChannel,
				// Token: 0x040005F6 RID: 1526
				[Token(Token = "0x40005F6")]
				RGBA,
				// Token: 0x040005F7 RID: 1527
				[Token(Token = "0x40005F7")]
				Count
			}
		}

		// Token: 0x02000129 RID: 297
		[Token(Token = "0x2000129")]
		private interface IStaticProperties
		{
			// Token: 0x060004A7 RID: 1191
			[Token(Token = "0x60004A7")]
			int GetPropertiesCount();

			// Token: 0x060004A8 RID: 1192
			[Token(Token = "0x60004A8")]
			int GetMaterialID();

			// Token: 0x060004A9 RID: 1193
			[Token(Token = "0x60004A9")]
			void ApplyToMaterial(Material mat);

			// Token: 0x060004AA RID: 1194
			[Token(Token = "0x60004AA")]
			ShaderMode GetShaderMode();
		}

		// Token: 0x0200012A RID: 298
		[Token(Token = "0x200012A")]
		public struct StaticPropertiesSD : MaterialManager.IStaticProperties
		{
			// Token: 0x060004AB RID: 1195 RVA: 0x00003B70 File Offset: 0x00001D70
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x490CA0", Offset = "0x48FEA0", VA = "0x180490CA0", Slot = "7")]
			public ShaderMode GetShaderMode()
			{
				return ShaderMode.SD;
			}

			// Token: 0x170000D9 RID: 217
			// (get) Token: 0x060004AC RID: 1196 RVA: 0x00003B88 File Offset: 0x00001D88
			[Token(Token = "0x170000D9")]
			public static int staticPropertiesCount
			{
				[Token(Token = "0x60004AC")]
				[Address(RVA = "0x69D550", Offset = "0x69C750", VA = "0x18069D550")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060004AD RID: 1197 RVA: 0x00003BA0 File Offset: 0x00001DA0
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x69D550", Offset = "0x69C750", VA = "0x18069D550", Slot = "4")]
			public int GetPropertiesCount()
			{
				return 0;
			}

			// Token: 0x170000DA RID: 218
			// (get) Token: 0x060004AE RID: 1198 RVA: 0x00003BB8 File Offset: 0x00001DB8
			[Token(Token = "0x170000DA")]
			private int blendingModeID
			{
				[Token(Token = "0x60004AE")]
				[Address(RVA = "0x4C1260", Offset = "0x4C0460", VA = "0x1804C1260")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170000DB RID: 219
			// (get) Token: 0x060004AF RID: 1199 RVA: 0x00003BD0 File Offset: 0x00001DD0
			[Token(Token = "0x170000DB")]
			private int noise3DID
			{
				[Token(Token = "0x60004AF")]
				[Address(RVA = "0x69D620", Offset = "0x69C820", VA = "0x18069D620")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170000DC RID: 220
			// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00003BE8 File Offset: 0x00001DE8
			[Token(Token = "0x170000DC")]
			private int depthBlendID
			{
				[Token(Token = "0x60004B0")]
				[Address(RVA = "0x69D560", Offset = "0x69C760", VA = "0x18069D560")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170000DD RID: 221
			// (get) Token: 0x060004B1 RID: 1201 RVA: 0x00003C00 File Offset: 0x00001E00
			[Token(Token = "0x170000DD")]
			private int colorGradientID
			{
				[Token(Token = "0x60004B1")]
				[Address(RVA = "0x69D070", Offset = "0x69C270", VA = "0x18069D070")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170000DE RID: 222
			// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00003C18 File Offset: 0x00001E18
			[Token(Token = "0x170000DE")]
			private int dynamicOcclusionID
			{
				[Token(Token = "0x60004B2")]
				[Address(RVA = "0x69D5A0", Offset = "0x69C7A0", VA = "0x18069D5A0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170000DF RID: 223
			// (get) Token: 0x060004B3 RID: 1203 RVA: 0x00003C30 File Offset: 0x00001E30
			[Token(Token = "0x170000DF")]
			private int meshSkewingID
			{
				[Token(Token = "0x60004B3")]
				[Address(RVA = "0x69D5E0", Offset = "0x69C7E0", VA = "0x18069D5E0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170000E0 RID: 224
			// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00003C48 File Offset: 0x00001E48
			[Token(Token = "0x170000E0")]
			private int shaderAccuracyID
			{
				[Token(Token = "0x60004B4")]
				[Address(RVA = "0x69D660", Offset = "0x69C860", VA = "0x18069D660")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060004B5 RID: 1205 RVA: 0x00003C60 File Offset: 0x00001E60
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x69D420", Offset = "0x69C620", VA = "0x18069D420", Slot = "5")]
			public int GetMaterialID()
			{
				return 0;
			}

			// Token: 0x060004B6 RID: 1206 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x69D170", Offset = "0x69C370", VA = "0x18069D170", Slot = "6")]
			public void ApplyToMaterial(Material mat)
			{
			}

			// Token: 0x040005F8 RID: 1528
			[Token(Token = "0x40005F8")]
			[FieldOffset(Offset = "0x0")]
			public MaterialManager.BlendingMode blendingMode;

			// Token: 0x040005F9 RID: 1529
			[Token(Token = "0x40005F9")]
			[FieldOffset(Offset = "0x4")]
			public MaterialManager.Noise3D noise3D;

			// Token: 0x040005FA RID: 1530
			[Token(Token = "0x40005FA")]
			[FieldOffset(Offset = "0x8")]
			public MaterialManager.SD.DepthBlend depthBlend;

			// Token: 0x040005FB RID: 1531
			[Token(Token = "0x40005FB")]
			[FieldOffset(Offset = "0xC")]
			public MaterialManager.ColorGradient colorGradient;

			// Token: 0x040005FC RID: 1532
			[Token(Token = "0x40005FC")]
			[FieldOffset(Offset = "0x10")]
			public MaterialManager.SD.DynamicOcclusion dynamicOcclusion;

			// Token: 0x040005FD RID: 1533
			[Token(Token = "0x40005FD")]
			[FieldOffset(Offset = "0x14")]
			public MaterialManager.SD.MeshSkewing meshSkewing;

			// Token: 0x040005FE RID: 1534
			[Token(Token = "0x40005FE")]
			[FieldOffset(Offset = "0x18")]
			public MaterialManager.SD.ShaderAccuracy shaderAccuracy;
		}

		// Token: 0x0200012B RID: 299
		[Token(Token = "0x200012B")]
		public struct StaticPropertiesHD : MaterialManager.IStaticProperties
		{
			// Token: 0x060004B7 RID: 1207 RVA: 0x00003C78 File Offset: 0x00001E78
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x56A480", Offset = "0x569680", VA = "0x18056A480", Slot = "7")]
			public ShaderMode GetShaderMode()
			{
				return ShaderMode.SD;
			}

			// Token: 0x170000E1 RID: 225
			// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00003C90 File Offset: 0x00001E90
			[Token(Token = "0x170000E1")]
			public static int staticPropertiesCount
			{
				[Token(Token = "0x60004B8")]
				[Address(RVA = "0x69D010", Offset = "0x69C210", VA = "0x18069D010")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060004B9 RID: 1209 RVA: 0x00003CA8 File Offset: 0x00001EA8
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x69D010", Offset = "0x69C210", VA = "0x18069D010", Slot = "4")]
			public int GetPropertiesCount()
			{
				return 0;
			}

			// Token: 0x170000E2 RID: 226
			// (get) Token: 0x060004BA RID: 1210 RVA: 0x00003CC0 File Offset: 0x00001EC0
			[Token(Token = "0x170000E2")]
			private int blendingModeID
			{
				[Token(Token = "0x60004BA")]
				[Address(RVA = "0x4C1260", Offset = "0x4C0460", VA = "0x1804C1260")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x060004BB RID: 1211 RVA: 0x00003CD8 File Offset: 0x00001ED8
			[Token(Token = "0x170000E3")]
			private int attenuationID
			{
				[Token(Token = "0x60004BB")]
				[Address(RVA = "0x509C20", Offset = "0x508E20", VA = "0x180509C20")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170000E4 RID: 228
			// (get) Token: 0x060004BC RID: 1212 RVA: 0x00003CF0 File Offset: 0x00001EF0
			[Token(Token = "0x170000E4")]
			private int noise3DID
			{
				[Token(Token = "0x60004BC")]
				[Address(RVA = "0x69D130", Offset = "0x69C330", VA = "0x18069D130")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170000E5 RID: 229
			// (get) Token: 0x060004BD RID: 1213 RVA: 0x00003D08 File Offset: 0x00001F08
			[Token(Token = "0x170000E5")]
			private int colorGradientID
			{
				[Token(Token = "0x60004BD")]
				[Address(RVA = "0x69D070", Offset = "0x69C270", VA = "0x18069D070")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170000E6 RID: 230
			// (get) Token: 0x060004BE RID: 1214 RVA: 0x00003D20 File Offset: 0x00001F20
			[Token(Token = "0x170000E6")]
			private int dynamicOcclusionID
			{
				[Token(Token = "0x60004BE")]
				[Address(RVA = "0x69D0F0", Offset = "0x69C2F0", VA = "0x18069D0F0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170000E7 RID: 231
			// (get) Token: 0x060004BF RID: 1215 RVA: 0x00003D38 File Offset: 0x00001F38
			[Token(Token = "0x170000E7")]
			private int cookieID
			{
				[Token(Token = "0x60004BF")]
				[Address(RVA = "0x69D0B0", Offset = "0x69C2B0", VA = "0x18069D0B0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170000E8 RID: 232
			// (get) Token: 0x060004C0 RID: 1216 RVA: 0x00003D50 File Offset: 0x00001F50
			[Token(Token = "0x170000E8")]
			private int raymarchingQualityID
			{
				[Token(Token = "0x60004C0")]
				[Address(RVA = "0x457F70", Offset = "0x457170", VA = "0x180457F70")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060004C1 RID: 1217 RVA: 0x00003D68 File Offset: 0x00001F68
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x69CEE0", Offset = "0x69C0E0", VA = "0x18069CEE0", Slot = "5")]
			public int GetMaterialID()
			{
				return 0;
			}

			// Token: 0x060004C2 RID: 1218 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x69CB80", Offset = "0x69BD80", VA = "0x18069CB80", Slot = "6")]
			public void ApplyToMaterial(Material mat)
			{
			}

			// Token: 0x040005FF RID: 1535
			[Token(Token = "0x40005FF")]
			[FieldOffset(Offset = "0x0")]
			public MaterialManager.BlendingMode blendingMode;

			// Token: 0x04000600 RID: 1536
			[Token(Token = "0x4000600")]
			[FieldOffset(Offset = "0x4")]
			public MaterialManager.HD.Attenuation attenuation;

			// Token: 0x04000601 RID: 1537
			[Token(Token = "0x4000601")]
			[FieldOffset(Offset = "0x8")]
			public MaterialManager.Noise3D noise3D;

			// Token: 0x04000602 RID: 1538
			[Token(Token = "0x4000602")]
			[FieldOffset(Offset = "0xC")]
			public MaterialManager.ColorGradient colorGradient;

			// Token: 0x04000603 RID: 1539
			[Token(Token = "0x4000603")]
			[FieldOffset(Offset = "0x10")]
			public MaterialManager.HD.Shadow shadow;

			// Token: 0x04000604 RID: 1540
			[Token(Token = "0x4000604")]
			[FieldOffset(Offset = "0x14")]
			public MaterialManager.HD.Cookie cookie;

			// Token: 0x04000605 RID: 1541
			[Token(Token = "0x4000605")]
			[FieldOffset(Offset = "0x18")]
			public int raymarchingQualityIndex;
		}

		// Token: 0x0200012C RID: 300
		[Token(Token = "0x200012C")]
		private class MaterialsGroup
		{
			// Token: 0x060004C3 RID: 1219 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x696890", Offset = "0x695A90", VA = "0x180696890")]
			public MaterialsGroup(int count)
			{
			}

			// Token: 0x04000606 RID: 1542
			[Token(Token = "0x4000606")]
			[FieldOffset(Offset = "0x10")]
			public Material[] materials;
		}

		// Token: 0x0200012D RID: 301
		[Token(Token = "0x200012D")]
		private enum ZWrite
		{
			// Token: 0x04000608 RID: 1544
			[Token(Token = "0x4000608")]
			Off,
			// Token: 0x04000609 RID: 1545
			[Token(Token = "0x4000609")]
			On
		}
	}
}
