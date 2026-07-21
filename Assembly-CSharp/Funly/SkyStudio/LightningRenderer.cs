using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001EE RID: 494
	[Token(Token = "0x20001EE")]
	[RequireComponent(typeof(AudioSource))]
	public class LightningRenderer : BaseSpriteInstancedRenderer
	{
		// Token: 0x06000A9D RID: 2717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x9F9C40", Offset = "0x9F8E40", VA = "0x1809F9C40")]
		private void Start()
		{
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x00006990 File Offset: 0x00004B90
		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x9F9120", Offset = "0x9F8320", VA = "0x1809F9120", Slot = "4")]
		protected override Bounds CalculateMeshBounds()
		{
			return default(Bounds);
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x9F9550", Offset = "0x9F8750", VA = "0x1809F9550", Slot = "5")]
		protected override BaseSpriteItemData CreateSpriteItemData()
		{
			return null;
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x000069A8 File Offset: 0x00004BA8
		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x9F9930", Offset = "0x9F8B30", VA = "0x1809F9930", Slot = "6")]
		protected override bool IsRenderingEnabled()
		{
			return default(bool);
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x9F9190", Offset = "0x9F8390", VA = "0x1809F9190", Slot = "8")]
		protected override void CalculateSpriteTRS(BaseSpriteItemData data, out Vector3 spritePosition, out Quaternion spriteRotation, out Vector3 spriteScale)
		{
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x9F94D0", Offset = "0x9F86D0", VA = "0x1809F94D0", Slot = "9")]
		protected override void ConfigureSpriteItemData(BaseSpriteItemData data)
		{
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "10")]
		protected override void PrepareDataArraysForRendering(int instanceId, BaseSpriteItemData data)
		{
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x9F9B10", Offset = "0x9F8D10", VA = "0x1809F9B10", Slot = "11")]
		protected override void PopulatePropertyBlockForRendering(ref MaterialPropertyBlock propertyBlock)
		{
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x000069C0 File Offset: 0x00004BC0
		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x9F95A0", Offset = "0x9F87A0", VA = "0x1809F95A0", Slot = "7")]
		protected override int GetNextSpawnCount()
		{
			return 0;
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x9F9FB0", Offset = "0x9F91B0", VA = "0x1809F9FB0")]
		public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay, LightningArtItem artItem)
		{
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x9F9CF0", Offset = "0x9F8EF0", VA = "0x1809F9CF0")]
		private void SyncDataFromSkyProfile()
		{
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x9F9630", Offset = "0x9F8830", VA = "0x1809F9630")]
		private LightningSpawnArea GetRandomLightningSpawnArea()
		{
			return null;
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x9F9A20", Offset = "0x9F8C20", VA = "0x1809F9A20")]
		private void PlayThunderBoltSound()
		{
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x9F8FB0", Offset = "0x9F81B0", VA = "0x1809F8FB0")]
		public static void AddSpawnArea(LightningSpawnArea area)
		{
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x9F9B70", Offset = "0x9F8D70", VA = "0x1809F9B70")]
		public static void RemoveSpawnArea(LightningSpawnArea area)
		{
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x000069D8 File Offset: 0x00004BD8
		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x9F9800", Offset = "0x9F8A00", VA = "0x1809F9800")]
		private Vector3 GetRandomWorldPositionInsideSpawnArea(LightningSpawnArea area)
		{
			return default(Vector3);
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x000069F0 File Offset: 0x00004BF0
		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x9F90E0", Offset = "0x9F82E0", VA = "0x1809F90E0")]
		private float CalculateLightningBoltScaleForArea(LightningSpawnArea area)
		{
			return 0f;
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x9FA190", Offset = "0x9F9390", VA = "0x1809FA190")]
		public LightningRenderer()
		{
		}

		// Token: 0x04000B54 RID: 2900
		[Token(Token = "0x4000B54")]
		[FieldOffset(Offset = "0x0")]
		private static List<LightningSpawnArea> m_SpawnAreas;

		// Token: 0x04000B55 RID: 2901
		[Token(Token = "0x4000B55")]
		[FieldOffset(Offset = "0x98")]
		private float m_LightningProbability;

		// Token: 0x04000B56 RID: 2902
		[Token(Token = "0x4000B56")]
		[FieldOffset(Offset = "0x9C")]
		private float m_NextSpawnTime;

		// Token: 0x04000B57 RID: 2903
		[Token(Token = "0x4000B57")]
		[FieldOffset(Offset = "0xA0")]
		private SkyProfile m_SkyProfile;

		// Token: 0x04000B58 RID: 2904
		[Token(Token = "0x4000B58")]
		[FieldOffset(Offset = "0xA8")]
		private LightningArtItem m_Style;

		// Token: 0x04000B59 RID: 2905
		[Token(Token = "0x4000B59")]
		[FieldOffset(Offset = "0xB0")]
		private float m_TimeOfDay;

		// Token: 0x04000B5A RID: 2906
		[Token(Token = "0x4000B5A")]
		[FieldOffset(Offset = "0xB8")]
		private AudioSource m_AudioSource;

		// Token: 0x04000B5B RID: 2907
		[Token(Token = "0x4000B5B")]
		[FieldOffset(Offset = "0xC0")]
		private float m_LightningIntensity;

		// Token: 0x04000B5C RID: 2908
		[Token(Token = "0x4000B5C")]
		[FieldOffset(Offset = "0xC4")]
		private float m_ThunderSoundDelay;

		// Token: 0x04000B5D RID: 2909
		[Token(Token = "0x4000B5D")]
		[FieldOffset(Offset = "0xC8")]
		private float m_SpawnCoolDown;

		// Token: 0x04000B5E RID: 2910
		[Token(Token = "0x4000B5E")]
		private const float k_ProbabiltyCheckInterval = 0.5f;
	}
}
