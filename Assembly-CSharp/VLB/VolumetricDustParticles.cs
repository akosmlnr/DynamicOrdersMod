using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace VLB
{
	// Token: 0x0200015B RID: 347
	[Token(Token = "0x200015B")]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dustparticles/")]
	[RequireComponent(typeof(VolumetricLightBeamAbstractBase))]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class VolumetricDustParticles : MonoBehaviour
	{
		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x00004E48 File Offset: 0x00003048
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013F")]
		public bool isCulled
		{
			[Token(Token = "0x600064D")]
			[Address(RVA = "0x4D4760", Offset = "0x4D3960", VA = "0x1804D4760")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600064E")]
			[Address(RVA = "0x4D4AE0", Offset = "0x4D3CE0", VA = "0x1804D4AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x00004E60 File Offset: 0x00003060
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000140")]
		public float alphaAdditionalRuntime
		{
			[Token(Token = "0x600064F")]
			[Address(RVA = "0x4B4220", Offset = "0x4B3420", VA = "0x1804B4220")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000650")]
			[Address(RVA = "0x7BFB90", Offset = "0x7BED90", VA = "0x1807BFB90")]
			set
			{
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x00004E78 File Offset: 0x00003078
		[Token(Token = "0x17000141")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x7BFA20", Offset = "0x7BEC20", VA = "0x1807BFA20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x00004E90 File Offset: 0x00003090
		[Token(Token = "0x17000142")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x7BFA70", Offset = "0x7BEC70", VA = "0x1807BFA70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x00004EA8 File Offset: 0x000030A8
		[Token(Token = "0x17000143")]
		public int particlesMaxCount
		{
			[Token(Token = "0x6000653")]
			[Address(RVA = "0x7BFAF0", Offset = "0x7BECF0", VA = "0x1807BFAF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000144")]
		public Camera mainCamera
		{
			[Token(Token = "0x6000654")]
			[Address(RVA = "0x7BF840", Offset = "0x7BEA40", VA = "0x1807BF840")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x7BEF60", Offset = "0x7BE160", VA = "0x1807BEF60")]
		private void Start()
		{
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x7BD880", Offset = "0x7BCA80", VA = "0x1807BD880")]
		private void InstantiateParticleSystem()
		{
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x7BDC10", Offset = "0x7BCE10", VA = "0x1807BDC10")]
		private void OnEnable()
		{
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000658")]
		[Address(RVA = "0x7BDD60", Offset = "0x7BCF60", VA = "0x1807BDD60")]
		private void SetActive(bool active)
		{
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000659")]
		[Address(RVA = "0x7BDCC0", Offset = "0x7BCEC0", VA = "0x1807BDCC0")]
		private void SetActiveAndPlay()
		{
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x7BDC20", Offset = "0x7BCE20", VA = "0x1807BDC20")]
		private void Play()
		{
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x7BDC00", Offset = "0x7BCE00", VA = "0x1807BDC00")]
		private void OnDisable()
		{
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x7BDAF0", Offset = "0x7BCCF0", VA = "0x1807BDAF0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x7BF590", Offset = "0x7BE790", VA = "0x1807BF590")]
		private void Update()
		{
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x7BDE00", Offset = "0x7BD000", VA = "0x1807BDE00")]
		private void SetParticleProperties()
		{
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x7BD800", Offset = "0x7BCA00", VA = "0x1807BD800")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000660")]
		[Address(RVA = "0x7BF050", Offset = "0x7BE250", VA = "0x1807BF050")]
		private void UpdateCulling()
		{
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x7BF740", Offset = "0x7BE940", VA = "0x1807BF740")]
		public VolumetricDustParticles()
		{
		}

		// Token: 0x040006F5 RID: 1781
		[Token(Token = "0x40006F5")]
		public const string ClassName = "VolumetricDustParticles";

		// Token: 0x040006F6 RID: 1782
		[Token(Token = "0x40006F6")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float alpha;

		// Token: 0x040006F7 RID: 1783
		[Token(Token = "0x40006F7")]
		[FieldOffset(Offset = "0x24")]
		[Range(0.0001f, 0.1f)]
		public float size;

		// Token: 0x040006F8 RID: 1784
		[Token(Token = "0x40006F8")]
		[FieldOffset(Offset = "0x28")]
		public ParticlesDirection direction;

		// Token: 0x040006F9 RID: 1785
		[Token(Token = "0x40006F9")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 velocity;

		// Token: 0x040006FA RID: 1786
		[Token(Token = "0x40006FA")]
		[FieldOffset(Offset = "0x38")]
		[Obsolete("Use 'velocity' instead")]
		public float speed;

		// Token: 0x040006FB RID: 1787
		[Token(Token = "0x40006FB")]
		[FieldOffset(Offset = "0x3C")]
		public float density;

		// Token: 0x040006FC RID: 1788
		[Token(Token = "0x40006FC")]
		[FieldOffset(Offset = "0x40")]
		[MinMaxRange(0f, 1f)]
		public MinMaxRangeFloat spawnDistanceRange;

		// Token: 0x040006FD RID: 1789
		[Token(Token = "0x40006FD")]
		[FieldOffset(Offset = "0x48")]
		[Obsolete("Use 'spawnDistanceRange' instead")]
		public float spawnMinDistance;

		// Token: 0x040006FE RID: 1790
		[Token(Token = "0x40006FE")]
		[FieldOffset(Offset = "0x4C")]
		[Obsolete("Use 'spawnDistanceRange' instead")]
		public float spawnMaxDistance;

		// Token: 0x040006FF RID: 1791
		[Token(Token = "0x40006FF")]
		[FieldOffset(Offset = "0x50")]
		public bool cullingEnabled;

		// Token: 0x04000700 RID: 1792
		[Token(Token = "0x4000700")]
		[FieldOffset(Offset = "0x54")]
		public float cullingMaxDistance;

		// Token: 0x04000702 RID: 1794
		[Token(Token = "0x4000702")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_AlphaAdditionalRuntime;

		// Token: 0x04000703 RID: 1795
		[Token(Token = "0x4000703")]
		[FieldOffset(Offset = "0x60")]
		private ParticleSystem m_Particles;

		// Token: 0x04000704 RID: 1796
		[Token(Token = "0x4000704")]
		[FieldOffset(Offset = "0x68")]
		private ParticleSystemRenderer m_Renderer;

		// Token: 0x04000705 RID: 1797
		[Token(Token = "0x4000705")]
		[FieldOffset(Offset = "0x70")]
		private Material m_Material;

		// Token: 0x04000706 RID: 1798
		[Token(Token = "0x4000706")]
		[FieldOffset(Offset = "0x78")]
		private Gradient m_GradientCached;

		// Token: 0x04000707 RID: 1799
		[Token(Token = "0x4000707")]
		[FieldOffset(Offset = "0x80")]
		private bool m_RuntimePropertiesDirty;

		// Token: 0x04000708 RID: 1800
		[Token(Token = "0x4000708")]
		[FieldOffset(Offset = "0x0")]
		private static bool ms_NoMainCameraLogged;

		// Token: 0x04000709 RID: 1801
		[Token(Token = "0x4000709")]
		[FieldOffset(Offset = "0x8")]
		private static Camera ms_MainCamera;

		// Token: 0x0400070A RID: 1802
		[Token(Token = "0x400070A")]
		[FieldOffset(Offset = "0x88")]
		private VolumetricLightBeamAbstractBase m_Master;
	}
}
