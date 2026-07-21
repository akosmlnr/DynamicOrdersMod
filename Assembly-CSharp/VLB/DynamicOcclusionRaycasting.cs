using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace VLB
{
	// Token: 0x02000141 RID: 321
	[Token(Token = "0x2000141")]
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dynocclusion-sd-raycasting/")]
	public class DynamicOcclusionRaycasting : DynamicOcclusionAbstractBase
	{
		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x00004230 File Offset: 0x00002430
		// (set) Token: 0x0600055B RID: 1371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000FD")]
		[Obsolete("Use 'fadeDistanceToSurface' instead")]
		public float fadeDistanceToPlane
		{
			[Token(Token = "0x600055A")]
			[Address(RVA = "0x4B4750", Offset = "0x4B3950", VA = "0x1804B4750")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x7A4B40", Offset = "0x7A3D40", VA = "0x1807A4B40")]
			set
			{
			}
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00004248 File Offset: 0x00002448
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x7A37C0", Offset = "0x7A29C0", VA = "0x1807A37C0")]
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return default(bool);
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x7A3790", Offset = "0x7A2990", VA = "0x1807A3790", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00004260 File Offset: 0x00002460
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x56A480", Offset = "0x569680", VA = "0x18056A480", Slot = "5")]
		protected override MaterialManager.SD.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return MaterialManager.SD.DynamicOcclusion.Off;
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x00004278 File Offset: 0x00002478
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000FE")]
		public Plane planeEquationWS
		{
			[Token(Token = "0x600055F")]
			[Address(RVA = "0x7A4AA0", Offset = "0x7A3CA0", VA = "0x1807A4AA0")]
			[CompilerGenerated]
			get
			{
				return default(Plane);
			}
			[Token(Token = "0x6000560")]
			[Address(RVA = "0x7A48F0", Offset = "0x7A3AF0", VA = "0x1807A48F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x7A4230", Offset = "0x7A3430", VA = "0x1807A4230", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000562")]
		[Address(RVA = "0x7A3970", Offset = "0x7A2B70", VA = "0x1807A3970", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x7A3950", Offset = "0x7A2B50", VA = "0x1807A3950", Slot = "13")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x7A4900", Offset = "0x7A3B00", VA = "0x1807A4900")]
		private void Start()
		{
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00004290 File Offset: 0x00002490
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x7A3670", Offset = "0x7A2870", VA = "0x1807A3670")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x000042A8 File Offset: 0x000024A8
		[Token(Token = "0x170000FF")]
		private QueryTriggerInteraction queryTriggerInteraction
		{
			[Token(Token = "0x6000566")]
			[Address(RVA = "0x7A4AB0", Offset = "0x7A3CB0", VA = "0x1807A4AB0")]
			get
			{
				return QueryTriggerInteraction.UseGlobal;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x000042C0 File Offset: 0x000024C0
		[Token(Token = "0x17000100")]
		private float raycastMaxDistance
		{
			[Token(Token = "0x6000567")]
			[Address(RVA = "0x7A4AC0", Offset = "0x7A3CC0", VA = "0x1807A4AC0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x000042D8 File Offset: 0x000024D8
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x7A3390", Offset = "0x7A2590", VA = "0x1807A3390")]
		private DynamicOcclusionRaycasting.HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return default(DynamicOcclusionRaycasting.HitResult);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x000042F0 File Offset: 0x000024F0
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x7A3010", Offset = "0x7A2210", VA = "0x1807A3010")]
		private DynamicOcclusionRaycasting.HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			return default(DynamicOcclusionRaycasting.HitResult);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00004308 File Offset: 0x00002508
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x7A2C20", Offset = "0x7A1E20", VA = "0x1807A2C20")]
		private DynamicOcclusionRaycasting.HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			return default(DynamicOcclusionRaycasting.HitResult);
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00004320 File Offset: 0x00002520
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x7A3440", Offset = "0x7A2640", VA = "0x1807A3440")]
		private uint GetDirectionCount()
		{
			return 0U;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00004338 File Offset: 0x00002538
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x7A3460", Offset = "0x7A2660", VA = "0x1807A3460")]
		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00004350 File Offset: 0x00002550
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x7A38B0", Offset = "0x7A2AB0", VA = "0x1807A38B0")]
		private bool IsHitValid(ref DynamicOcclusionRaycasting.HitResult hit, Vector3 forwardVec)
		{
			return default(bool);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00004368 File Offset: 0x00002568
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x7A3BC0", Offset = "0x7A2DC0", VA = "0x1807A3BC0", Slot = "6")]
		protected override bool OnProcessOcclusion(DynamicOcclusionAbstractBase.ProcessOcclusionSource source)
		{
			return default(bool);
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x7A4670", Offset = "0x7A3870", VA = "0x1807A4670")]
		private void SetHit(ref DynamicOcclusionRaycasting.HitResult hit)
		{
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x7A4570", Offset = "0x7A3770", VA = "0x1807A4570")]
		private void SetHitNull()
		{
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000571")]
		[Address(RVA = "0x7A39B0", Offset = "0x7A2BB0", VA = "0x1807A39B0", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000572")]
		[Address(RVA = "0x7A4340", Offset = "0x7A3540", VA = "0x1807A4340")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x7A4280", Offset = "0x7A3480", VA = "0x1807A4280")]
		private void SetClippingPlaneOff()
		{
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x7A48F0", Offset = "0x7A3AF0", VA = "0x1807A48F0")]
		private void SetPlaneWS(Plane planeWS)
		{
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x7A49D0", Offset = "0x7A3BD0", VA = "0x1807A49D0")]
		public DynamicOcclusionRaycasting()
		{
		}

		// Token: 0x04000641 RID: 1601
		[Token(Token = "0x4000641")]
		public new const string ClassName = "DynamicOcclusionRaycasting";

		// Token: 0x04000642 RID: 1602
		[Token(Token = "0x4000642")]
		[FieldOffset(Offset = "0x70")]
		public Dimensions dimensions;

		// Token: 0x04000643 RID: 1603
		[Token(Token = "0x4000643")]
		[FieldOffset(Offset = "0x74")]
		public LayerMask layerMask;

		// Token: 0x04000644 RID: 1604
		[Token(Token = "0x4000644")]
		[FieldOffset(Offset = "0x78")]
		public bool considerTriggers;

		// Token: 0x04000645 RID: 1605
		[Token(Token = "0x4000645")]
		[FieldOffset(Offset = "0x7C")]
		public float minOccluderArea;

		// Token: 0x04000646 RID: 1606
		[Token(Token = "0x4000646")]
		[FieldOffset(Offset = "0x80")]
		public float minSurfaceRatio;

		// Token: 0x04000647 RID: 1607
		[Token(Token = "0x4000647")]
		[FieldOffset(Offset = "0x84")]
		public float maxSurfaceDot;

		// Token: 0x04000648 RID: 1608
		[Token(Token = "0x4000648")]
		[FieldOffset(Offset = "0x88")]
		public PlaneAlignment planeAlignment;

		// Token: 0x04000649 RID: 1609
		[Token(Token = "0x4000649")]
		[FieldOffset(Offset = "0x8C")]
		public float planeOffset;

		// Token: 0x0400064A RID: 1610
		[Token(Token = "0x400064A")]
		[FieldOffset(Offset = "0x90")]
		[FormerlySerializedAs("fadeDistanceToPlane")]
		public float fadeDistanceToSurface;

		// Token: 0x0400064B RID: 1611
		[Token(Token = "0x400064B")]
		[FieldOffset(Offset = "0x98")]
		private DynamicOcclusionRaycasting.HitResult m_CurrentHit;

		// Token: 0x0400064C RID: 1612
		[Token(Token = "0x400064C")]
		[FieldOffset(Offset = "0xC8")]
		private float m_RangeMultiplier;

		// Token: 0x0400064E RID: 1614
		[Token(Token = "0x400064E")]
		[FieldOffset(Offset = "0xDC")]
		private uint m_PrevNonSubHitDirectionId;

		// Token: 0x02000142 RID: 322
		[Token(Token = "0x2000142")]
		public struct HitResult
		{
			// Token: 0x06000576 RID: 1398 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000576")]
			[Address(RVA = "0x7A6980", Offset = "0x7A5B80", VA = "0x1807A6980")]
			public HitResult(ref RaycastHit hit3D)
			{
			}

			// Token: 0x06000577 RID: 1399 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000577")]
			[Address(RVA = "0x7A68C0", Offset = "0x7A5AC0", VA = "0x1807A68C0")]
			public HitResult(ref RaycastHit2D hit2D)
			{
			}

			// Token: 0x17000101 RID: 257
			// (get) Token: 0x06000578 RID: 1400 RVA: 0x00004380 File Offset: 0x00002580
			[Token(Token = "0x17000101")]
			public bool hasCollider
			{
				[Token(Token = "0x6000578")]
				[Address(RVA = "0x7A6B30", Offset = "0x7A5D30", VA = "0x1807A6B30")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000102 RID: 258
			// (get) Token: 0x06000579 RID: 1401 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000102")]
			public string name
			{
				[Token(Token = "0x6000579")]
				[Address(RVA = "0x7A6BC0", Offset = "0x7A5DC0", VA = "0x1807A6BC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000103 RID: 259
			// (get) Token: 0x0600057A RID: 1402 RVA: 0x00004398 File Offset: 0x00002598
			[Token(Token = "0x17000103")]
			public Bounds bounds
			{
				[Token(Token = "0x600057A")]
				[Address(RVA = "0x7A6A20", Offset = "0x7A5C20", VA = "0x1807A6A20")]
				get
				{
					return default(Bounds);
				}
			}

			// Token: 0x0600057B RID: 1403 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x7A6880", Offset = "0x7A5A80", VA = "0x1807A6880")]
			public void SetNull()
			{
			}

			// Token: 0x0400064F RID: 1615
			[Token(Token = "0x400064F")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 point;

			// Token: 0x04000650 RID: 1616
			[Token(Token = "0x4000650")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 normal;

			// Token: 0x04000651 RID: 1617
			[Token(Token = "0x4000651")]
			[FieldOffset(Offset = "0x18")]
			public float distance;

			// Token: 0x04000652 RID: 1618
			[Token(Token = "0x4000652")]
			[FieldOffset(Offset = "0x20")]
			private Collider2D collider2D;

			// Token: 0x04000653 RID: 1619
			[Token(Token = "0x4000653")]
			[FieldOffset(Offset = "0x28")]
			private Collider collider3D;
		}

		// Token: 0x02000143 RID: 323
		[Token(Token = "0x2000143")]
		private enum Direction
		{
			// Token: 0x04000655 RID: 1621
			[Token(Token = "0x4000655")]
			Up,
			// Token: 0x04000656 RID: 1622
			[Token(Token = "0x4000656")]
			Down,
			// Token: 0x04000657 RID: 1623
			[Token(Token = "0x4000657")]
			Left,
			// Token: 0x04000658 RID: 1624
			[Token(Token = "0x4000658")]
			Right,
			// Token: 0x04000659 RID: 1625
			[Token(Token = "0x4000659")]
			Max2D = 1,
			// Token: 0x0400065A RID: 1626
			[Token(Token = "0x400065A")]
			Max3D = 3
		}
	}
}
