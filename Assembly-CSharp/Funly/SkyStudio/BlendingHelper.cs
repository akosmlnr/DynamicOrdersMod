using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001A3 RID: 419
	[Token(Token = "0x20001A3")]
	public class BlendingHelper
	{
		// Token: 0x06000831 RID: 2097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000831")]
		[Address(RVA = "0x8D2830", Offset = "0x8D1A30", VA = "0x1808D2830")]
		public BlendingHelper(ProfileBlendingState state)
		{
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000832")]
		[Address(RVA = "0x8D2800", Offset = "0x8D1A00", VA = "0x1808D2800")]
		public void UpdateState(ProfileBlendingState state)
		{
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00005958 File Offset: 0x00003B58
		[Token(Token = "0x6000833")]
		[Address(RVA = "0x8D2570", Offset = "0x8D1770", VA = "0x1808D2570")]
		public Color ProfileColorForKey(SkyProfile profile, string key)
		{
			return default(Color);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00005970 File Offset: 0x00003B70
		[Token(Token = "0x6000834")]
		[Address(RVA = "0x8D2660", Offset = "0x8D1860", VA = "0x1808D2660")]
		public float ProfileNumberForKey(SkyProfile profile, string key)
		{
			return 0f;
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000835")]
		[Address(RVA = "0x8D2730", Offset = "0x8D1930", VA = "0x1808D2730")]
		public SpherePoint ProfileSpherePointForKey(SkyProfile profile, string key)
		{
			return null;
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000836")]
		[Address(RVA = "0x8D1D80", Offset = "0x8D0F80", VA = "0x1808D1D80")]
		public void BlendColor(string key)
		{
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000837")]
		[Address(RVA = "0x8D1A60", Offset = "0x8D0C60", VA = "0x1808D1A60")]
		public void BlendColorOut(string key)
		{
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x8D1880", Offset = "0x8D0A80", VA = "0x1808D1880")]
		public void BlendColorIn(string key)
		{
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000839")]
		[Address(RVA = "0x8D1C50", Offset = "0x8D0E50", VA = "0x1808D1C50")]
		public void BlendColor(string key, Color from, Color to, float progress)
		{
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x8D20C0", Offset = "0x8D12C0", VA = "0x1808D20C0")]
		public void BlendNumber(string key)
		{
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083B")]
		[Address(RVA = "0x8D1F90", Offset = "0x8D1190", VA = "0x1808D1F90")]
		public void BlendNumberOut(string key, float toValue = 0f)
		{
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083C")]
		[Address(RVA = "0x8D1F30", Offset = "0x8D1130", VA = "0x1808D1F30")]
		public void BlendNumberIn(string key, float fromValue = 0f)
		{
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083D")]
		[Address(RVA = "0x8D1FF0", Offset = "0x8D11F0", VA = "0x1808D1FF0")]
		public void BlendNumber(string key, float from, float to, float progress)
		{
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083E")]
		[Address(RVA = "0x8D22D0", Offset = "0x8D14D0", VA = "0x1808D22D0")]
		public void BlendSpherePoint(string key)
		{
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083F")]
		[Address(RVA = "0x8D2130", Offset = "0x8D1330", VA = "0x1808D2130")]
		public void BlendSpherePoint(string key, SpherePoint from, SpherePoint to, float progress)
		{
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00005988 File Offset: 0x00003B88
		[Token(Token = "0x6000840")]
		[Address(RVA = "0x8D24D0", Offset = "0x8D16D0", VA = "0x1808D24D0")]
		public ProfileFeatureBlendingMode GetFeatureAnimationMode(string featureKey)
		{
			return ProfileFeatureBlendingMode.None;
		}

		// Token: 0x04000907 RID: 2311
		[Token(Token = "0x4000907")]
		[FieldOffset(Offset = "0x10")]
		private ProfileBlendingState m_State;
	}
}
