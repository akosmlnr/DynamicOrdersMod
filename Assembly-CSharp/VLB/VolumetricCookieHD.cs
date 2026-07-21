using System;
using Il2CppDummyDll;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000115 RID: 277
	[Token(Token = "0x2000115")]
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-cookie-hd/")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(VolumetricLightBeamHD))]
	public class VolumetricCookieHD : MonoBehaviour
	{
		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x000034E0 File Offset: 0x000016E0
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009D")]
		public float contribution
		{
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x495AF0", Offset = "0x494CF0", VA = "0x180495AF0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x69E770", Offset = "0x69D970", VA = "0x18069E770")]
			set
			{
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009E")]
		public Texture cookieTexture
		{
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x69E790", Offset = "0x69D990", VA = "0x18069E790")]
			set
			{
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x000034F8 File Offset: 0x000016F8
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009F")]
		public CookieChannel channel
		{
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x4A63B0", Offset = "0x4A55B0", VA = "0x1804A63B0")]
			get
			{
				return CookieChannel.Red;
			}
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x69E760", Offset = "0x69D960", VA = "0x18069E760")]
			set
			{
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x00003510 File Offset: 0x00001710
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A0")]
		public bool negative
		{
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x58D090", Offset = "0x58C290", VA = "0x18058D090")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x69E820", Offset = "0x69DA20", VA = "0x18069E820")]
			set
			{
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x00003528 File Offset: 0x00001728
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A1")]
		public Vector2 translation
		{
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x574D90", Offset = "0x573F90", VA = "0x180574D90")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x69E8A0", Offset = "0x69DAA0", VA = "0x18069E8A0")]
			set
			{
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x00003540 File Offset: 0x00001740
		// (set) Token: 0x060003FE RID: 1022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A2")]
		public float rotation
		{
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x494490", Offset = "0x493690", VA = "0x180494490")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x69E830", Offset = "0x69DA30", VA = "0x18069E830")]
			set
			{
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x00003558 File Offset: 0x00001758
		// (set) Token: 0x06000400 RID: 1024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A3")]
		public Vector2 scale
		{
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x69E740", Offset = "0x69D940", VA = "0x18069E740")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000400")]
			[Address(RVA = "0x69E850", Offset = "0x69DA50", VA = "0x18069E850")]
			set
			{
			}
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x69E5C0", Offset = "0x69D7C0", VA = "0x18069E5C0")]
		private void SetDirty()
		{
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x69E240", Offset = "0x69D440", VA = "0x18069E240")]
		public static void ApplyMaterialProperties(VolumetricCookieHD instance, BeamGeometryHD geom)
		{
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x69E500", Offset = "0x69D700", VA = "0x18069E500")]
		private void Awake()
		{
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x69E5B0", Offset = "0x69D7B0", VA = "0x18069E5B0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x69E5B0", Offset = "0x69D7B0", VA = "0x18069E5B0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x69E5B0", Offset = "0x69D7B0", VA = "0x18069E5B0")]
		private void OnDidApplyAnimationProperties()
		{
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x69E640", Offset = "0x69D840", VA = "0x18069E640")]
		private void Start()
		{
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x69E550", Offset = "0x69D750", VA = "0x18069E550")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000409")]
		[Address(RVA = "0x69E6A0", Offset = "0x69D8A0", VA = "0x18069E6A0")]
		public VolumetricCookieHD()
		{
		}

		// Token: 0x04000589 RID: 1417
		[Token(Token = "0x4000589")]
		public const string ClassName = "VolumetricCookieHD";

		// Token: 0x0400058A RID: 1418
		[Token(Token = "0x400058A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_Contribution;

		// Token: 0x0400058B RID: 1419
		[Token(Token = "0x400058B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Texture m_CookieTexture;

		// Token: 0x0400058C RID: 1420
		[Token(Token = "0x400058C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CookieChannel m_Channel;

		// Token: 0x0400058D RID: 1421
		[Token(Token = "0x400058D")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool m_Negative;

		// Token: 0x0400058E RID: 1422
		[Token(Token = "0x400058E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector2 m_Translation;

		// Token: 0x0400058F RID: 1423
		[Token(Token = "0x400058F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_Rotation;

		// Token: 0x04000590 RID: 1424
		[Token(Token = "0x4000590")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Vector2 m_Scale;

		// Token: 0x04000591 RID: 1425
		[Token(Token = "0x4000591")]
		[FieldOffset(Offset = "0x50")]
		private VolumetricLightBeamHD m_Master;
	}
}
