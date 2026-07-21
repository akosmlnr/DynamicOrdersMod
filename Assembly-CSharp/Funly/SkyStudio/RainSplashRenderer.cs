using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001F3 RID: 499
	[Token(Token = "0x20001F3")]
	public class RainSplashRenderer : BaseSpriteInstancedRenderer
	{
		// Token: 0x06000ABF RID: 2751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x9FCF70", Offset = "0x9FC170", VA = "0x1809FCF70")]
		private void Start()
		{
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x00006A08 File Offset: 0x00004C08
		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x9FC690", Offset = "0x9FB890", VA = "0x1809FC690", Slot = "4")]
		protected override Bounds CalculateMeshBounds()
		{
			return default(Bounds);
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x9FC960", Offset = "0x9FBB60", VA = "0x1809FC960", Slot = "5")]
		protected override BaseSpriteItemData CreateSpriteItemData()
		{
			return null;
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00006A20 File Offset: 0x00004C20
		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x9FCBB0", Offset = "0x9FBDB0", VA = "0x1809FCBB0", Slot = "6")]
		protected override bool IsRenderingEnabled()
		{
			return default(bool);
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x00006A38 File Offset: 0x00004C38
		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0x9FCB60", Offset = "0x9FBD60", VA = "0x1809FCB60", Slot = "7")]
		protected override int GetNextSpawnCount()
		{
			return 0;
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x9FC6B0", Offset = "0x9FB8B0", VA = "0x1809FC6B0", Slot = "8")]
		protected override void CalculateSpriteTRS(BaseSpriteItemData data, out Vector3 spritePosition, out Quaternion spriteRotation, out Vector3 spriteScale)
		{
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x9FC770", Offset = "0x9FB970", VA = "0x1809FC770", Slot = "9")]
		protected override void ConfigureSpriteItemData(BaseSpriteItemData data)
		{
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x9FCDE0", Offset = "0x9FBFE0", VA = "0x1809FCDE0", Slot = "10")]
		protected override void PrepareDataArraysForRendering(int instanceId, BaseSpriteItemData data)
		{
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x9FCCD0", Offset = "0x9FBED0", VA = "0x1809FCCD0", Slot = "11")]
		protected override void PopulatePropertyBlockForRendering(ref MaterialPropertyBlock propertyBlock)
		{
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x9FD440", Offset = "0x9FC640", VA = "0x1809FD440")]
		public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay, RainSplashArtItem style)
		{
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x9FD0D0", Offset = "0x9FC2D0", VA = "0x1809FD0D0")]
		private void SyncDataFromSkyProfile()
		{
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00006A50 File Offset: 0x00004C50
		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x9FC9B0", Offset = "0x9FBBB0", VA = "0x1809FC9B0")]
		private Vector3 CreateWorldSplashPoint()
		{
			return default(Vector3);
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x9FD500", Offset = "0x9FC700", VA = "0x1809FD500")]
		public RainSplashRenderer()
		{
		}

		// Token: 0x04000B6A RID: 2922
		[Token(Token = "0x4000B6A")]
		[FieldOffset(Offset = "0x98")]
		private Camera m_DepthCamera;

		// Token: 0x04000B6B RID: 2923
		[Token(Token = "0x4000B6B")]
		[FieldOffset(Offset = "0xA0")]
		private float[] m_StartSplashYPositions;

		// Token: 0x04000B6C RID: 2924
		[Token(Token = "0x4000B6C")]
		[FieldOffset(Offset = "0xA8")]
		private float[] m_DepthUs;

		// Token: 0x04000B6D RID: 2925
		[Token(Token = "0x4000B6D")]
		[FieldOffset(Offset = "0xB0")]
		private float[] m_DepthVs;

		// Token: 0x04000B6E RID: 2926
		[Token(Token = "0x4000B6E")]
		[FieldOffset(Offset = "0xB8")]
		private float m_SplashAreaStart;

		// Token: 0x04000B6F RID: 2927
		[Token(Token = "0x4000B6F")]
		[FieldOffset(Offset = "0xBC")]
		private float m_SplashAreaLength;

		// Token: 0x04000B70 RID: 2928
		[Token(Token = "0x4000B70")]
		[FieldOffset(Offset = "0xC0")]
		private float m_SplashScale;

		// Token: 0x04000B71 RID: 2929
		[Token(Token = "0x4000B71")]
		[FieldOffset(Offset = "0xC4")]
		private float m_SplashScaleVarience;

		// Token: 0x04000B72 RID: 2930
		[Token(Token = "0x4000B72")]
		[FieldOffset(Offset = "0xC8")]
		private float m_SplashItensity;

		// Token: 0x04000B73 RID: 2931
		[Token(Token = "0x4000B73")]
		[FieldOffset(Offset = "0xCC")]
		private float m_SplashSurfaceOffset;

		// Token: 0x04000B74 RID: 2932
		[Token(Token = "0x4000B74")]
		[FieldOffset(Offset = "0xD0")]
		private SkyProfile m_SkyProfile;

		// Token: 0x04000B75 RID: 2933
		[Token(Token = "0x4000B75")]
		[FieldOffset(Offset = "0xD8")]
		private float m_TimeOfDay;

		// Token: 0x04000B76 RID: 2934
		[Token(Token = "0x4000B76")]
		[FieldOffset(Offset = "0xE0")]
		private RainSplashArtItem m_Style;

		// Token: 0x04000B77 RID: 2935
		[Token(Token = "0x4000B77")]
		[FieldOffset(Offset = "0xE8")]
		private Bounds m_Bounds;
	}
}
