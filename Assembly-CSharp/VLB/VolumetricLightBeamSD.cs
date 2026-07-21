using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace VLB
{
	// Token: 0x02000147 RID: 327
	[Token(Token = "0x2000147")]
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam-sd/")]
	[DisallowMultipleComponent]
	[SelectionBase]
	public class VolumetricLightBeamSD : VolumetricLightBeamAbstractBase
	{
		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x00004428 File Offset: 0x00002628
		[Token(Token = "0x17000106")]
		public ColorMode usedColorMode
		{
			[Token(Token = "0x600058D")]
			[Address(RVA = "0x7C2E60", Offset = "0x7C2060", VA = "0x1807C2E60")]
			get
			{
				return ColorMode.Flat;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x00004440 File Offset: 0x00002640
		[Token(Token = "0x17000107")]
		private bool useColorFromAttachedLightSpot
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0x7C2C30", Offset = "0x7C1E30", VA = "0x1807C2C30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x00004458 File Offset: 0x00002658
		[Token(Token = "0x17000108")]
		private bool useColorTemperatureFromAttachedLightSpot
		{
			[Token(Token = "0x600058F")]
			[Address(RVA = "0x7C2C90", Offset = "0x7C1E90", VA = "0x1807C2C90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x00004470 File Offset: 0x00002670
		// (set) Token: 0x06000591 RID: 1425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000109")]
		[Obsolete("Use 'intensityGlobal' or 'intensityInside' instead")]
		public float alphaInside
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x4B3A40", Offset = "0x4B2C40", VA = "0x1804B3A40")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x7C2F60", Offset = "0x7C2160", VA = "0x1807C2F60")]
			set
			{
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x00004488 File Offset: 0x00002688
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010A")]
		[Obsolete("Use 'intensityGlobal' or 'intensityOutside' instead")]
		public float alphaOutside
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x4B4830", Offset = "0x4B3A30", VA = "0x1804B4830")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x7C2F70", Offset = "0x7C2170", VA = "0x1807C2F70")]
			set
			{
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x000044A0 File Offset: 0x000026A0
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010B")]
		public float intensityGlobal
		{
			[Token(Token = "0x6000594")]
			[Address(RVA = "0x4B4830", Offset = "0x4B3A30", VA = "0x1804B4830")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x7C3250", Offset = "0x7C2450", VA = "0x1807C3250")]
			set
			{
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x000044B8 File Offset: 0x000026B8
		[Token(Token = "0x1700010C")]
		public bool useIntensityFromAttachedLightSpot
		{
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x7C2DA0", Offset = "0x7C1FA0", VA = "0x1807C2DA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000597")]
		[Address(RVA = "0x7C0A30", Offset = "0x7BFC30", VA = "0x1807C0A30")]
		public void GetInsideAndOutsideIntensity(out float inside, out float outside)
		{
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x000044D0 File Offset: 0x000026D0
		[Token(Token = "0x1700010D")]
		public bool useSpotAngleFromAttachedLightSpot
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x7C2E00", Offset = "0x7C2000", VA = "0x1807C2E00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x000044E8 File Offset: 0x000026E8
		[Token(Token = "0x1700010E")]
		public float coneAngle
		{
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x7C1E60", Offset = "0x7C1060", VA = "0x1807C1E60")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x00004500 File Offset: 0x00002700
		// (set) Token: 0x0600059B RID: 1435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010F")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x600059A")]
			[Address(RVA = "0x7C2100", Offset = "0x7C1300", VA = "0x1807C2100")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x7C2F80", Offset = "0x7C2180", VA = "0x1807C2F80")]
			set
			{
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x00004518 File Offset: 0x00002718
		[Token(Token = "0x17000110")]
		public float coneVolume
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x7C2160", Offset = "0x7C1360", VA = "0x1807C2160")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x00004530 File Offset: 0x00002730
		[Token(Token = "0x17000111")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x600059D")]
			[Address(RVA = "0x7C1F10", Offset = "0x7C1110", VA = "0x1807C1F10")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x00004548 File Offset: 0x00002748
		[Token(Token = "0x17000112")]
		public Vector3 coneApexPositionLocal
		{
			[Token(Token = "0x600059E")]
			[Address(RVA = "0x7C20D0", Offset = "0x7C12D0", VA = "0x1807C20D0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x00004560 File Offset: 0x00002760
		[Token(Token = "0x17000113")]
		public Vector3 coneApexPositionGlobal
		{
			[Token(Token = "0x600059F")]
			[Address(RVA = "0x7C1FE0", Offset = "0x7C11E0", VA = "0x1807C1FE0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00004578 File Offset: 0x00002778
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "6")]
		public override bool IsScalable()
		{
			return default(bool);
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x00004590 File Offset: 0x00002790
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000114")]
		public int geomSides
		{
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x7C2250", Offset = "0x7C1450", VA = "0x1807C2250")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x7C3150", Offset = "0x7C2350", VA = "0x1807C3150")]
			set
			{
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x000045A8 File Offset: 0x000027A8
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000115")]
		public int geomSegments
		{
			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x7C2220", Offset = "0x7C1420", VA = "0x1807C2220")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x7C3050", Offset = "0x7C2250", VA = "0x1807C3050")]
			set
			{
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x000045C0 File Offset: 0x000027C0
		[Token(Token = "0x17000116")]
		public Vector3 skewingLocalForwardDirectionNormalized
		{
			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x7C2A80", Offset = "0x7C1C80", VA = "0x1807C2A80")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x000045D8 File Offset: 0x000027D8
		[Token(Token = "0x17000117")]
		public bool canHaveMeshSkewing
		{
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x7C1E50", Offset = "0x7C1050", VA = "0x1807C1E50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x000045F0 File Offset: 0x000027F0
		[Token(Token = "0x17000118")]
		public bool hasMeshSkewing
		{
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x7C2280", Offset = "0x7C1480", VA = "0x1807C2280")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x00004608 File Offset: 0x00002808
		[Token(Token = "0x17000119")]
		public Vector4 additionalClippingPlane
		{
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x7C1960", Offset = "0x7C0B60", VA = "0x1807C1960")]
			get
			{
				return default(Vector4);
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x00004620 File Offset: 0x00002820
		[Token(Token = "0x1700011A")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x7C1AD0", Offset = "0x7C0CD0", VA = "0x1807C1AD0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x00004638 File Offset: 0x00002838
		// (set) Token: 0x060005AB RID: 1451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011B")]
		[Obsolete("Use 'fallOffStart' instead")]
		public float fadeStart
		{
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x7C2210", Offset = "0x7C1410", VA = "0x1807C2210")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x7C3040", Offset = "0x7C2240", VA = "0x1807C3040")]
			set
			{
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x00004650 File Offset: 0x00002850
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011C")]
		[Obsolete("Use 'fallOffEnd' instead")]
		public float fadeEnd
		{
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x7C2200", Offset = "0x7C1400", VA = "0x1807C2200")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x7C2FF0", Offset = "0x7C21F0", VA = "0x1807C2FF0")]
			set
			{
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x00004668 File Offset: 0x00002868
		// (set) Token: 0x060005AF RID: 1455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011D")]
		[Obsolete("Use 'fallOffEndFromLight' instead")]
		public bool fadeEndFromLight
		{
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x7C21F0", Offset = "0x7C13F0", VA = "0x1807C21F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x7C2FE0", Offset = "0x7C21E0", VA = "0x1807C2FE0")]
			set
			{
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x00004680 File Offset: 0x00002880
		[Token(Token = "0x1700011E")]
		public bool useFallOffEndFromAttachedLightSpot
		{
			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x7C2D30", Offset = "0x7C1F30", VA = "0x1807C2D30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x00004698 File Offset: 0x00002898
		[Token(Token = "0x1700011F")]
		public float maxGeometryDistance
		{
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x7C2430", Offset = "0x7C1630", VA = "0x1807C2430")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x000046B0 File Offset: 0x000028B0
		[Token(Token = "0x17000120")]
		public bool isNoiseEnabled
		{
			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x7C23A0", Offset = "0x7C15A0", VA = "0x1807C23A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x000046C8 File Offset: 0x000028C8
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000121")]
		[Obsolete("Use 'noiseMode' instead")]
		public bool noiseEnabled
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x7C23A0", Offset = "0x7C15A0", VA = "0x1807C23A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x7C3260", Offset = "0x7C2460", VA = "0x1807C3260")]
			set
			{
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x000046E0 File Offset: 0x000028E0
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000122")]
		public float fadeOutBegin
		{
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x511190", Offset = "0x510390", VA = "0x180511190")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x7C3000", Offset = "0x7C2200", VA = "0x1807C3000")]
			set
			{
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x000046F8 File Offset: 0x000028F8
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000123")]
		public float fadeOutEnd
		{
			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x5112E0", Offset = "0x5104E0", VA = "0x1805112E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x7C3020", Offset = "0x7C2220", VA = "0x1807C3020")]
			set
			{
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x00004710 File Offset: 0x00002910
		[Token(Token = "0x17000124")]
		public bool isFadeOutEnabled
		{
			[Token(Token = "0x60005B9")]
			[Address(RVA = "0x7C2370", Offset = "0x7C1570", VA = "0x1807C2370")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x00004728 File Offset: 0x00002928
		[Token(Token = "0x17000125")]
		public bool isTilted
		{
			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x7C23B0", Offset = "0x7C15B0", VA = "0x1807C23B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x00004740 File Offset: 0x00002940
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000126")]
		public int sortingLayerID
		{
			[Token(Token = "0x60005BB")]
			[Address(RVA = "0x511A30", Offset = "0x510C30", VA = "0x180511A30")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x7C3280", Offset = "0x7C2480", VA = "0x1807C3280")]
			set
			{
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060005BE RID: 1470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000127")]
		public string sortingLayerName
		{
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x7C2C20", Offset = "0x7C1E20", VA = "0x1807C2C20")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x7C3310", Offset = "0x7C2510", VA = "0x1807C3310")]
			set
			{
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x00004758 File Offset: 0x00002958
		// (set) Token: 0x060005C0 RID: 1472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000128")]
		public int sortingOrder
		{
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x5219D0", Offset = "0x520BD0", VA = "0x1805219D0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x7C33B0", Offset = "0x7C25B0", VA = "0x1807C33B0")]
			set
			{
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x00004770 File Offset: 0x00002970
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000129")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x60005C1")]
			[Address(RVA = "0x51C070", Offset = "0x51B270", VA = "0x18051C070")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x7C3440", Offset = "0x7C2640", VA = "0x1807C3440")]
			set
			{
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x00004788 File Offset: 0x00002988
		[Token(Token = "0x1700012A")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x7C2360", Offset = "0x7C1560", VA = "0x1807C2360")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x5A44F0", Offset = "0x5A36F0", VA = "0x1805A44F0", Slot = "4")]
		public override BeamGeometryAbstractBase GetBeamGeometry()
		{
			return null;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x7C1200", Offset = "0x7C0400", VA = "0x1807C1200", Slot = "5")]
		protected override void SetBeamGeometryNull()
		{
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x000047A0 File Offset: 0x000029A0
		[Token(Token = "0x1700012B")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x7C1D80", Offset = "0x7C0F80", VA = "0x1807C1D80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x000047B8 File Offset: 0x000029B8
		[Token(Token = "0x1700012C")]
		public Quaternion beamInternalLocalRotation
		{
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x7C1BE0", Offset = "0x7C0DE0", VA = "0x1807C1BE0")]
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x000047D0 File Offset: 0x000029D0
		[Token(Token = "0x1700012D")]
		public Vector3 beamLocalForward
		{
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x7C1CE0", Offset = "0x7C0EE0", VA = "0x1807C1CE0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x000047E8 File Offset: 0x000029E8
		[Token(Token = "0x1700012E")]
		public Vector3 beamGlobalForward
		{
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x7C1B00", Offset = "0x7C0D00", VA = "0x1807C1B00")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00004800 File Offset: 0x00002A00
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x7C0D90", Offset = "0x7BFF90", VA = "0x1807C0D90", Slot = "7")]
		public override Vector3 GetLossyScale()
		{
			return default(Vector3);
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x00004818 File Offset: 0x00002A18
		[Token(Token = "0x1700012F")]
		public float raycastDistance
		{
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x7C2820", Offset = "0x7C1A20", VA = "0x1807C2820")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00004830 File Offset: 0x00002A30
		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x7C0630", Offset = "0x7BF830", VA = "0x1807C0630")]
		private Vector3 ComputeRaycastGlobalVector(Vector3 localVec)
		{
			return default(Vector3);
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x00004848 File Offset: 0x00002A48
		[Token(Token = "0x17000130")]
		public Vector3 raycastGlobalForward
		{
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x7C28D0", Offset = "0x7C1AD0", VA = "0x1807C28D0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x00004860 File Offset: 0x00002A60
		[Token(Token = "0x17000131")]
		public Vector3 raycastGlobalUp
		{
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x7C2A00", Offset = "0x7C1C00", VA = "0x1807C2A00")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x00004878 File Offset: 0x00002A78
		[Token(Token = "0x17000132")]
		public Vector3 raycastGlobalRight
		{
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x7C2980", Offset = "0x7C1B80", VA = "0x1807C2980")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x00004890 File Offset: 0x00002A90
		// (set) Token: 0x060005D1 RID: 1489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000133")]
		public MaterialManager.SD.DynamicOcclusion _INTERNAL_DynamicOcclusionMode
		{
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x7C1920", Offset = "0x7C0B20", VA = "0x1807C1920")]
			get
			{
				return MaterialManager.SD.DynamicOcclusion.Off;
			}
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x7C2F50", Offset = "0x7C2150", VA = "0x1807C2F50")]
			set
			{
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x000048A8 File Offset: 0x00002AA8
		[Token(Token = "0x17000134")]
		public MaterialManager.SD.DynamicOcclusion _INTERNAL_DynamicOcclusionMode_Runtime
		{
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x7C18D0", Offset = "0x7C0AD0", VA = "0x1807C18D0")]
			get
			{
				return MaterialManager.SD.DynamicOcclusion.Off;
			}
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x7C1590", Offset = "0x7C0790", VA = "0x1807C1590")]
		public void _INTERNAL_SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060005D4 RID: 1492 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005D5 RID: 1493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000004")]
		public event VolumetricLightBeamSD.OnWillCameraRenderCB onWillCameraRenderThisBeam
		{
			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x7C1820", Offset = "0x7C0A20", VA = "0x1807C1820")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x7C2EA0", Offset = "0x7C20A0", VA = "0x1807C2EA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x7C1560", Offset = "0x7C0760", VA = "0x1807C1560")]
		public void _INTERNAL_OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x7C10D0", Offset = "0x7C02D0", VA = "0x1807C10D0")]
		public void RegisterOnBeamGeometryInitializedCallback(VolumetricLightBeamSD.OnBeamGeometryInitialized cb)
		{
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x7C0390", Offset = "0x7BF590", VA = "0x1807C0390")]
		private void CallOnBeamGeometryInitializedCallback()
		{
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x7C1220", Offset = "0x7C0420", VA = "0x1807C1220")]
		private void SetFadeOutValue(ref float propToChange, float value)
		{
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x7C1030", Offset = "0x7C0230", VA = "0x1807C1030")]
		private void OnFadeOutStateChanged()
		{
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x000048C0 File Offset: 0x00002AC0
		// (set) Token: 0x060005DC RID: 1500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000135")]
		public uint _INTERNAL_InstancedMaterialGroupID
		{
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x630330", Offset = "0x62F530", VA = "0x180630330")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x630400", Offset = "0x62F600", VA = "0x180630400")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000136")]
		public string meshStats
		{
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x7C2460", Offset = "0x7C1660", VA = "0x1807C2460")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x000048D8 File Offset: 0x00002AD8
		[Token(Token = "0x17000137")]
		public int meshVerticesCount
		{
			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x7C2760", Offset = "0x7C1960", VA = "0x1807C2760")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x000048F0 File Offset: 0x00002AF0
		[Token(Token = "0x17000138")]
		public int meshTrianglesCount
		{
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x7C2680", Offset = "0x7C1880", VA = "0x1807C2680")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00004908 File Offset: 0x00002B08
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x7C0D10", Offset = "0x7BFF10", VA = "0x1807C0D10")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return 0f;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00004920 File Offset: 0x00002B20
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x7C0A60", Offset = "0x7BFC60", VA = "0x1807C0A60")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return 0f;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x62A7D0", Offset = "0x6299D0", VA = "0x18062A7D0")]
		[Obsolete("Use 'GenerateGeometry()' instead")]
		public void Generate()
		{
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x7C0860", Offset = "0x7BFA60", VA = "0x1807C0860", Slot = "8")]
		public virtual void GenerateGeometry()
		{
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x7C14B0", Offset = "0x7C06B0", VA = "0x1807C14B0", Slot = "9")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x7C13F0", Offset = "0x7C05F0", VA = "0x1807C13F0")]
		private void Start()
		{
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x7C0FB0", Offset = "0x7C01B0", VA = "0x1807C0FB0")]
		private void OnEnable()
		{
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x7C0F20", Offset = "0x7C0120", VA = "0x1807C0F20")]
		private void OnDisable()
		{
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x7C1310", Offset = "0x7C0510", VA = "0x1807C1310")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x7C05C0", Offset = "0x7BF7C0", VA = "0x1807C05C0")]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x7BFFB0", Offset = "0x7BF1B0", VA = "0x1807BFFB0")]
		private void AssignPropertiesFromAttachedSpotLight()
		{
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x7C03E0", Offset = "0x7BF5E0", VA = "0x1807C03E0")]
		private void ClampProperties()
		{
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x7C1540", Offset = "0x7C0740", VA = "0x1807C1540")]
		private void ValidateProperties()
		{
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x7C0E80", Offset = "0x7C0080", VA = "0x1807C0E80")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x7C1640", Offset = "0x7C0840", VA = "0x1807C1640")]
		public VolumetricLightBeamSD()
		{
		}

		// Token: 0x04000663 RID: 1635
		[Token(Token = "0x4000663")]
		public new const string ClassName = "VolumetricLightBeamSD";

		// Token: 0x04000664 RID: 1636
		[Token(Token = "0x4000664")]
		[FieldOffset(Offset = "0x30")]
		public bool colorFromLight;

		// Token: 0x04000665 RID: 1637
		[Token(Token = "0x4000665")]
		[FieldOffset(Offset = "0x34")]
		public ColorMode colorMode;

		// Token: 0x04000666 RID: 1638
		[Token(Token = "0x4000666")]
		[FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("colorValue")]
		[ColorUsage(false, true)]
		public Color color;

		// Token: 0x04000667 RID: 1639
		[Token(Token = "0x4000667")]
		[FieldOffset(Offset = "0x48")]
		public Gradient colorGradient;

		// Token: 0x04000668 RID: 1640
		[Token(Token = "0x4000668")]
		[FieldOffset(Offset = "0x50")]
		public bool intensityFromLight;

		// Token: 0x04000669 RID: 1641
		[Token(Token = "0x4000669")]
		[FieldOffset(Offset = "0x51")]
		public bool intensityModeAdvanced;

		// Token: 0x0400066A RID: 1642
		[Token(Token = "0x400066A")]
		[FieldOffset(Offset = "0x54")]
		[FormerlySerializedAs("alphaInside")]
		[Min(0f)]
		public float intensityInside;

		// Token: 0x0400066B RID: 1643
		[Token(Token = "0x400066B")]
		[FieldOffset(Offset = "0x58")]
		[FormerlySerializedAs("alphaOutside")]
		[FormerlySerializedAs("alpha")]
		[Min(0f)]
		public float intensityOutside;

		// Token: 0x0400066C RID: 1644
		[Token(Token = "0x400066C")]
		[FieldOffset(Offset = "0x5C")]
		[Min(0f)]
		public float intensityMultiplier;

		// Token: 0x0400066D RID: 1645
		[Token(Token = "0x400066D")]
		[FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		public float hdrpExposureWeight;

		// Token: 0x0400066E RID: 1646
		[Token(Token = "0x400066E")]
		[FieldOffset(Offset = "0x64")]
		public BlendingMode blendingMode;

		// Token: 0x0400066F RID: 1647
		[Token(Token = "0x400066F")]
		[FieldOffset(Offset = "0x68")]
		[FormerlySerializedAs("angleFromLight")]
		public bool spotAngleFromLight;

		// Token: 0x04000670 RID: 1648
		[Token(Token = "0x4000670")]
		[FieldOffset(Offset = "0x6C")]
		[Range(0.1f, 179.9f)]
		public float spotAngle;

		// Token: 0x04000671 RID: 1649
		[Token(Token = "0x4000671")]
		[FieldOffset(Offset = "0x70")]
		[Min(0f)]
		public float spotAngleMultiplier;

		// Token: 0x04000672 RID: 1650
		[Token(Token = "0x4000672")]
		[FieldOffset(Offset = "0x74")]
		[FormerlySerializedAs("radiusStart")]
		public float coneRadiusStart;

		// Token: 0x04000673 RID: 1651
		[Token(Token = "0x4000673")]
		[FieldOffset(Offset = "0x78")]
		public ShaderAccuracy shaderAccuracy;

		// Token: 0x04000674 RID: 1652
		[Token(Token = "0x4000674")]
		[FieldOffset(Offset = "0x7C")]
		public MeshType geomMeshType;

		// Token: 0x04000675 RID: 1653
		[Token(Token = "0x4000675")]
		[FieldOffset(Offset = "0x80")]
		[FormerlySerializedAs("geomSides")]
		public int geomCustomSides;

		// Token: 0x04000676 RID: 1654
		[Token(Token = "0x4000676")]
		[FieldOffset(Offset = "0x84")]
		public int geomCustomSegments;

		// Token: 0x04000677 RID: 1655
		[Token(Token = "0x4000677")]
		[FieldOffset(Offset = "0x88")]
		public Vector3 skewingLocalForwardDirection;

		// Token: 0x04000678 RID: 1656
		[Token(Token = "0x4000678")]
		[FieldOffset(Offset = "0x98")]
		public Transform clippingPlaneTransform;

		// Token: 0x04000679 RID: 1657
		[Token(Token = "0x4000679")]
		[FieldOffset(Offset = "0xA0")]
		public bool geomCap;

		// Token: 0x0400067A RID: 1658
		[Token(Token = "0x400067A")]
		[FieldOffset(Offset = "0xA4")]
		public AttenuationEquation attenuationEquation;

		// Token: 0x0400067B RID: 1659
		[Token(Token = "0x400067B")]
		[FieldOffset(Offset = "0xA8")]
		[Range(0f, 1f)]
		public float attenuationCustomBlending;

		// Token: 0x0400067C RID: 1660
		[Token(Token = "0x400067C")]
		[FieldOffset(Offset = "0xAC")]
		[FormerlySerializedAs("fadeStart")]
		public float fallOffStart;

		// Token: 0x0400067D RID: 1661
		[Token(Token = "0x400067D")]
		[FieldOffset(Offset = "0xB0")]
		[FormerlySerializedAs("fadeEnd")]
		public float fallOffEnd;

		// Token: 0x0400067E RID: 1662
		[Token(Token = "0x400067E")]
		[FieldOffset(Offset = "0xB4")]
		[FormerlySerializedAs("fadeEndFromLight")]
		public bool fallOffEndFromLight;

		// Token: 0x0400067F RID: 1663
		[Token(Token = "0x400067F")]
		[FieldOffset(Offset = "0xB8")]
		[Min(0f)]
		public float fallOffEndMultiplier;

		// Token: 0x04000680 RID: 1664
		[Token(Token = "0x4000680")]
		[FieldOffset(Offset = "0xBC")]
		public float depthBlendDistance;

		// Token: 0x04000681 RID: 1665
		[Token(Token = "0x4000681")]
		[FieldOffset(Offset = "0xC0")]
		public float cameraClippingDistance;

		// Token: 0x04000682 RID: 1666
		[Token(Token = "0x4000682")]
		[FieldOffset(Offset = "0xC4")]
		[Range(0f, 1f)]
		public float glareFrontal;

		// Token: 0x04000683 RID: 1667
		[Token(Token = "0x4000683")]
		[FieldOffset(Offset = "0xC8")]
		[Range(0f, 1f)]
		public float glareBehind;

		// Token: 0x04000684 RID: 1668
		[Token(Token = "0x4000684")]
		[FieldOffset(Offset = "0xCC")]
		[FormerlySerializedAs("fresnelPowOutside")]
		public float fresnelPow;

		// Token: 0x04000685 RID: 1669
		[Token(Token = "0x4000685")]
		[FieldOffset(Offset = "0xD0")]
		public NoiseMode noiseMode;

		// Token: 0x04000686 RID: 1670
		[Token(Token = "0x4000686")]
		[FieldOffset(Offset = "0xD4")]
		[Range(0f, 1f)]
		public float noiseIntensity;

		// Token: 0x04000687 RID: 1671
		[Token(Token = "0x4000687")]
		[FieldOffset(Offset = "0xD8")]
		public bool noiseScaleUseGlobal;

		// Token: 0x04000688 RID: 1672
		[Token(Token = "0x4000688")]
		[FieldOffset(Offset = "0xDC")]
		[Range(0.01f, 2f)]
		public float noiseScaleLocal;

		// Token: 0x04000689 RID: 1673
		[Token(Token = "0x4000689")]
		[FieldOffset(Offset = "0xE0")]
		public bool noiseVelocityUseGlobal;

		// Token: 0x0400068A RID: 1674
		[Token(Token = "0x400068A")]
		[FieldOffset(Offset = "0xE4")]
		public Vector3 noiseVelocityLocal;

		// Token: 0x0400068B RID: 1675
		[Token(Token = "0x400068B")]
		[FieldOffset(Offset = "0xF0")]
		public Dimensions dimensions;

		// Token: 0x0400068C RID: 1676
		[Token(Token = "0x400068C")]
		[FieldOffset(Offset = "0xF4")]
		public Vector2 tiltFactor;

		// Token: 0x0400068D RID: 1677
		[Token(Token = "0x400068D")]
		[FieldOffset(Offset = "0xFC")]
		private MaterialManager.SD.DynamicOcclusion m_INTERNAL_DynamicOcclusionMode;

		// Token: 0x0400068E RID: 1678
		[Token(Token = "0x400068E")]
		[FieldOffset(Offset = "0x100")]
		private bool m_INTERNAL_DynamicOcclusionMode_Runtime;

		// Token: 0x04000690 RID: 1680
		[Token(Token = "0x4000690")]
		[FieldOffset(Offset = "0x110")]
		private VolumetricLightBeamSD.OnBeamGeometryInitialized m_OnBeamGeometryInitialized;

		// Token: 0x04000691 RID: 1681
		[Token(Token = "0x4000691")]
		[FieldOffset(Offset = "0x118")]
		[FormerlySerializedAs("trackChangesDuringPlaytime")]
		[SerializeField]
		private bool _TrackChangesDuringPlaytime;

		// Token: 0x04000692 RID: 1682
		[Token(Token = "0x4000692")]
		[FieldOffset(Offset = "0x11C")]
		[SerializeField]
		private int _SortingLayerID;

		// Token: 0x04000693 RID: 1683
		[Token(Token = "0x4000693")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private int _SortingOrder;

		// Token: 0x04000694 RID: 1684
		[Token(Token = "0x4000694")]
		[FieldOffset(Offset = "0x124")]
		[FormerlySerializedAs("fadeOutBegin")]
		[SerializeField]
		private float _FadeOutBegin;

		// Token: 0x04000695 RID: 1685
		[Token(Token = "0x4000695")]
		[FieldOffset(Offset = "0x128")]
		[FormerlySerializedAs("fadeOutEnd")]
		[SerializeField]
		private float _FadeOutEnd;

		// Token: 0x04000697 RID: 1687
		[Token(Token = "0x4000697")]
		[FieldOffset(Offset = "0x130")]
		private BeamGeometrySD m_BeamGeom;

		// Token: 0x04000698 RID: 1688
		[Token(Token = "0x4000698")]
		[FieldOffset(Offset = "0x138")]
		private Coroutine m_CoPlaytimeUpdate;

		// Token: 0x02000148 RID: 328
		// (Invoke) Token: 0x060005F0 RID: 1520
		[Token(Token = "0x2000148")]
		public delegate void OnWillCameraRenderCB(Camera cam);

		// Token: 0x02000149 RID: 329
		// (Invoke) Token: 0x060005F4 RID: 1524
		[Token(Token = "0x2000149")]
		public delegate void OnBeamGeometryInitialized();
	}
}
