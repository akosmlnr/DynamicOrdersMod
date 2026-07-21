using System;
using Il2CppDummyDll;
using UnityEngine;

namespace VLB
{
	// Token: 0x0200015D RID: 349
	[Token(Token = "0x200015D")]
	public abstract class VolumetricLightBeamAbstractBase : MonoBehaviour
	{
		// Token: 0x06000665 RID: 1637
		[Token(Token = "0x6000665")]
		public abstract BeamGeometryAbstractBase GetBeamGeometry();

		// Token: 0x06000666 RID: 1638
		[Token(Token = "0x6000666")]
		protected abstract void SetBeamGeometryNull();

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x00004EC0 File Offset: 0x000030C0
		[Token(Token = "0x17000145")]
		public bool hasGeometry
		{
			[Token(Token = "0x6000667")]
			[Address(RVA = "0x7BFF40", Offset = "0x7BF140", VA = "0x1807BFF40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x00004ED8 File Offset: 0x000030D8
		[Token(Token = "0x17000146")]
		public Bounds bounds
		{
			[Token(Token = "0x6000668")]
			[Address(RVA = "0x7BFDC0", Offset = "0x7BEFC0", VA = "0x1807BFDC0")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x06000669 RID: 1641
		[Token(Token = "0x6000669")]
		public abstract bool IsScalable();

		// Token: 0x0600066A RID: 1642
		[Token(Token = "0x600066A")]
		public abstract Vector3 GetLossyScale();

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x00004EF0 File Offset: 0x000030F0
		[Token(Token = "0x17000147")]
		public int _INTERNAL_pluginVersion
		{
			[Token(Token = "0x600066B")]
			[Address(RVA = "0x492970", Offset = "0x491B70", VA = "0x180492970")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600066C")]
		[Address(RVA = "0x7BFC40", Offset = "0x7BEE40", VA = "0x1807BFC40")]
		public Light GetLightSpotAttachedSlow(out VolumetricLightBeamAbstractBase.AttachedLightType lightType)
		{
			return null;
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000148")]
		public Light lightSpotAttached
		{
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600066E")]
		[Address(RVA = "0x7BFD00", Offset = "0x7BEF00", VA = "0x1807BFD00")]
		protected void InitLightSpotAttachedCached()
		{
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600066F")]
		[Address(RVA = "0x7BFBB0", Offset = "0x7BEDB0", VA = "0x1807BFBB0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000670")]
		[Address(RVA = "0x7BFBB0", Offset = "0x7BEDB0", VA = "0x1807BFBB0")]
		protected void DestroyBeam()
		{
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000671")]
		[Address(RVA = "0x7BFDB0", Offset = "0x7BEFB0", VA = "0x1807BFDB0")]
		protected VolumetricLightBeamAbstractBase()
		{
		}

		// Token: 0x0400070D RID: 1805
		[Token(Token = "0x400070D")]
		public const string ClassName = "VolumetricLightBeamAbstractBase";

		// Token: 0x0400070E RID: 1806
		[Token(Token = "0x400070E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected int pluginVersion;

		// Token: 0x0400070F RID: 1807
		[Token(Token = "0x400070F")]
		[FieldOffset(Offset = "0x28")]
		protected Light m_CachedLightSpot;

		// Token: 0x0200015E RID: 350
		[Token(Token = "0x200015E")]
		public enum AttachedLightType
		{
			// Token: 0x04000711 RID: 1809
			[Token(Token = "0x4000711")]
			NoLight,
			// Token: 0x04000712 RID: 1810
			[Token(Token = "0x4000712")]
			OtherLight,
			// Token: 0x04000713 RID: 1811
			[Token(Token = "0x4000713")]
			SpotLight
		}
	}
}
