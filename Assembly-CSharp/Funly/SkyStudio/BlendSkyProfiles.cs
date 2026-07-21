using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001AE RID: 430
	[Token(Token = "0x20001AE")]
	public class BlendSkyProfiles : MonoBehaviour
	{
		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000872 RID: 2162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B6")]
		public SkyProfile fromProfile
		{
			[Token(Token = "0x6000871")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000872")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B7")]
		public SkyProfile toProfile
		{
			[Token(Token = "0x6000873")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000874")]
			[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B8")]
		public SkyProfile blendedProfile
		{
			[Token(Token = "0x6000875")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000876")]
			[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000877")]
		[Address(RVA = "0x8D0B40", Offset = "0x8CFD40", VA = "0x1808D0B40")]
		public SkyProfile StartBlending(TimeOfDayController controller, SkyProfile fromProfile, SkyProfile toProfile, float duration)
		{
			return null;
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000878")]
		[Address(RVA = "0x8D0AF0", Offset = "0x8CFCF0", VA = "0x1808D0AF0")]
		public void CancelBlending()
		{
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000879")]
		[Address(RVA = "0x8D10A0", Offset = "0x8D02A0", VA = "0x1808D10A0")]
		public void TearDownBlending()
		{
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600087A")]
		[Address(RVA = "0x8D17F0", Offset = "0x8D09F0", VA = "0x1808D17F0")]
		private void Update()
		{
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600087B")]
		[Address(RVA = "0x8D1160", Offset = "0x8D0360", VA = "0x1808D1160")]
		private void UpdateBlendedProfile()
		{
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x000059D0 File Offset: 0x00003BD0
		[Token(Token = "0x600087C")]
		[Address(RVA = "0x8D0B00", Offset = "0x8CFD00", VA = "0x1808D0B00")]
		private float PercentForMode(ProfileFeatureBlendingMode mode, float percent)
		{
			return 0f;
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600087D")]
		[Address(RVA = "0x8D1860", Offset = "0x8D0A60", VA = "0x1808D1860")]
		public BlendSkyProfiles()
		{
		}

		// Token: 0x0400090C RID: 2316
		[Token(Token = "0x400090C")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Called when blending finishes.")]
		public Action<BlendSkyProfiles> onBlendComplete;

		// Token: 0x0400090D RID: 2317
		[Token(Token = "0x400090D")]
		[FieldOffset(Offset = "0x40")]
		[HideInInspector]
		private float m_StartTime;

		// Token: 0x0400090E RID: 2318
		[Token(Token = "0x400090E")]
		[FieldOffset(Offset = "0x44")]
		[HideInInspector]
		private float m_EndTime;

		// Token: 0x0400090F RID: 2319
		[Token(Token = "0x400090F")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("Blender used for basic sky background properties.")]
		public FeatureBlender skyBlender;

		// Token: 0x04000910 RID: 2320
		[Token(Token = "0x4000910")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Blender used for the sun properties.")]
		public FeatureBlender sunBlender;

		// Token: 0x04000911 RID: 2321
		[Token(Token = "0x4000911")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("Blender used moon properties.")]
		public FeatureBlender moonBlender;

		// Token: 0x04000912 RID: 2322
		[Token(Token = "0x4000912")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("Blender used cloud properties.")]
		public FeatureBlender cloudBlender;

		// Token: 0x04000913 RID: 2323
		[Token(Token = "0x4000913")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("Blender used star layer 1 properties.")]
		public FeatureBlender starLayer1Blender;

		// Token: 0x04000914 RID: 2324
		[Token(Token = "0x4000914")]
		[FieldOffset(Offset = "0x70")]
		[Tooltip("Blender used star layer 2 properties.")]
		public FeatureBlender starLayer2Blender;

		// Token: 0x04000915 RID: 2325
		[Token(Token = "0x4000915")]
		[FieldOffset(Offset = "0x78")]
		[Tooltip("Blender used star layer 3 properties.")]
		public FeatureBlender starLayer3Blender;

		// Token: 0x04000916 RID: 2326
		[Token(Token = "0x4000916")]
		[FieldOffset(Offset = "0x80")]
		[Tooltip("Blender used by the rain downfall feature.")]
		public FeatureBlender rainBlender;

		// Token: 0x04000917 RID: 2327
		[Token(Token = "0x4000917")]
		[FieldOffset(Offset = "0x88")]
		[Tooltip("Blender used by the rain splash feature.")]
		public FeatureBlender rainSplashBlender;

		// Token: 0x04000918 RID: 2328
		[Token(Token = "0x4000918")]
		[FieldOffset(Offset = "0x90")]
		[Tooltip("Blender used for lightning feature properties.")]
		public FeatureBlender lightningBlender;

		// Token: 0x04000919 RID: 2329
		[Token(Token = "0x4000919")]
		[FieldOffset(Offset = "0x98")]
		[Tooltip("Blender used for fog properties.")]
		public FeatureBlender fogBlender;

		// Token: 0x0400091A RID: 2330
		[Token(Token = "0x400091A")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_IsBlendingFirstHalf;

		// Token: 0x0400091B RID: 2331
		[Token(Token = "0x400091B")]
		[FieldOffset(Offset = "0xA8")]
		private ProfileBlendingState m_State;

		// Token: 0x0400091C RID: 2332
		[Token(Token = "0x400091C")]
		[FieldOffset(Offset = "0xD0")]
		private TimeOfDayController m_TimeOfDayController;

		// Token: 0x0400091D RID: 2333
		[Token(Token = "0x400091D")]
		[FieldOffset(Offset = "0xD8")]
		private BlendingHelper blendingHelper;
	}
}
