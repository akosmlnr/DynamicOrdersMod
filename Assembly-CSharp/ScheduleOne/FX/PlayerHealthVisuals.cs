using System;
using Beautify.Universal;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace ScheduleOne.FX
{
	// Token: 0x0200068A RID: 1674
	[Token(Token = "0x200068A")]
	public class PlayerHealthVisuals : MonoBehaviour
	{
		// Token: 0x06002B5E RID: 11102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B5E")]
		[Address(RVA = "0x704720", Offset = "0x703920", VA = "0x180704720")]
		private void Awake()
		{
		}

		// Token: 0x06002B5F RID: 11103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B5F")]
		[Address(RVA = "0x704CD0", Offset = "0x703ED0", VA = "0x180704CD0")]
		private void Spawned()
		{
		}

		// Token: 0x06002B60 RID: 11104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B60")]
		[Address(RVA = "0x704BA0", Offset = "0x703DA0", VA = "0x180704BA0")]
		private void MinPass()
		{
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B61")]
		[Address(RVA = "0x704E50", Offset = "0x704050", VA = "0x180704E50")]
		private void UpdateEffects(float newHealth)
		{
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B62")]
		[Address(RVA = "0x705140", Offset = "0x704340", VA = "0x180705140")]
		public PlayerHealthVisuals()
		{
		}

		// Token: 0x0400208D RID: 8333
		[Token(Token = "0x400208D")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public Volume[] PPVolumes;

		// Token: 0x0400208E RID: 8334
		[Token(Token = "0x400208E")]
		[FieldOffset(Offset = "0x28")]
		[Header("Vignette")]
		public float VignetteAlpha_MaxHealth;

		// Token: 0x0400208F RID: 8335
		[Token(Token = "0x400208F")]
		[FieldOffset(Offset = "0x2C")]
		public float VignetteAlpha_MinHealth;

		// Token: 0x04002090 RID: 8336
		[Token(Token = "0x4002090")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve OuterRingCurve;

		// Token: 0x04002091 RID: 8337
		[Token(Token = "0x4002091")]
		[FieldOffset(Offset = "0x38")]
		[Header("Saturation")]
		public float Saturation_MaxHealth;

		// Token: 0x04002092 RID: 8338
		[Token(Token = "0x4002092")]
		[FieldOffset(Offset = "0x3C")]
		public float Saturation_MinHealth;

		// Token: 0x04002093 RID: 8339
		[Token(Token = "0x4002093")]
		[FieldOffset(Offset = "0x40")]
		[Header("Chromatic Abberation")]
		public float ChromAb_MaxHealth;

		// Token: 0x04002094 RID: 8340
		[Token(Token = "0x4002094")]
		[FieldOffset(Offset = "0x44")]
		public float ChromAb_MinHealth;

		// Token: 0x04002095 RID: 8341
		[Token(Token = "0x4002095")]
		[FieldOffset(Offset = "0x48")]
		[Header("Lens Dirt")]
		public float LensDirt_MaxHealth;

		// Token: 0x04002096 RID: 8342
		[Token(Token = "0x4002096")]
		[FieldOffset(Offset = "0x4C")]
		public float LensDirt_MinHealth;

		// Token: 0x04002097 RID: 8343
		[Token(Token = "0x4002097")]
		[FieldOffset(Offset = "0x50")]
		private Beautify[] _beautifySettings;
	}
}
