using System;
using Il2CppDummyDll;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000155 RID: 341
	[Token(Token = "0x2000155")]
	[RequireComponent(typeof(VolumetricLightBeamAbstractBase))]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-triggerzone/")]
	[DisallowMultipleComponent]
	public class TriggerZone : MonoBehaviour
	{
		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x00004A10 File Offset: 0x00002C10
		[Token(Token = "0x1700013D")]
		private TriggerZone.TriggerZoneUpdateRate updateRate
		{
			[Token(Token = "0x600060C")]
			[Address(RVA = "0x7BA6F0", Offset = "0x7B98F0", VA = "0x1807BA6F0")]
			get
			{
				return TriggerZone.TriggerZoneUpdateRate.OnEnable;
			}
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x7BA4B0", Offset = "0x7B96B0", VA = "0x1807BA4B0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x7BA6C0", Offset = "0x7B98C0", VA = "0x1807BA6C0")]
		private void OnOcclusionProcessed()
		{
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x7B9CA0", Offset = "0x7B8EA0", VA = "0x1807B9CA0")]
		private void ComputeZone()
		{
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x7BA6D0", Offset = "0x7B98D0", VA = "0x1807BA6D0")]
		public TriggerZone()
		{
		}

		// Token: 0x040006E3 RID: 1763
		[Token(Token = "0x40006E3")]
		public const string ClassName = "TriggerZone";

		// Token: 0x040006E4 RID: 1764
		[Token(Token = "0x40006E4")]
		[FieldOffset(Offset = "0x20")]
		public bool setIsTrigger;

		// Token: 0x040006E5 RID: 1765
		[Token(Token = "0x40006E5")]
		[FieldOffset(Offset = "0x24")]
		public float rangeMultiplier;

		// Token: 0x040006E6 RID: 1766
		[Token(Token = "0x40006E6")]
		private const int kMeshColliderNumSides = 8;

		// Token: 0x040006E7 RID: 1767
		[Token(Token = "0x40006E7")]
		[FieldOffset(Offset = "0x28")]
		private VolumetricLightBeamAbstractBase m_Beam;

		// Token: 0x040006E8 RID: 1768
		[Token(Token = "0x40006E8")]
		[FieldOffset(Offset = "0x30")]
		private DynamicOcclusionRaycasting m_DynamicOcclusionRaycasting;

		// Token: 0x040006E9 RID: 1769
		[Token(Token = "0x40006E9")]
		[FieldOffset(Offset = "0x38")]
		private PolygonCollider2D m_PolygonCollider2D;

		// Token: 0x02000156 RID: 342
		[Token(Token = "0x2000156")]
		private enum TriggerZoneUpdateRate
		{
			// Token: 0x040006EB RID: 1771
			[Token(Token = "0x40006EB")]
			OnEnable,
			// Token: 0x040006EC RID: 1772
			[Token(Token = "0x40006EC")]
			OnOcclusionChange
		}
	}
}
