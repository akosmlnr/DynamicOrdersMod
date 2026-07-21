using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Configuration;
using ScheduleOne.Core;
using ScheduleOne.Core.Audio;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x02000BEF RID: 3055
	[Token(Token = "0x2000BEF")]
	public class SFXManager : Singleton<SFXManager>
	{
		// Token: 0x06005A46 RID: 23110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A46")]
		[Address(RVA = "0x9B2FC0", Offset = "0x9B21C0", VA = "0x1809B2FC0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005A47 RID: 23111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A47")]
		[Address(RVA = "0x9B30C0", Offset = "0x9B22C0", VA = "0x1809B30C0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06005A48 RID: 23112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A48")]
		[Address(RVA = "0x9B41E0", Offset = "0x9B33E0", VA = "0x1809B41E0")]
		private void Update()
		{
		}

		// Token: 0x06005A49 RID: 23113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A49")]
		[Address(RVA = "0x9B3500", Offset = "0x9B2700", VA = "0x1809B3500")]
		public void PlayImpactSound(EImpactSound material, Vector3 position, float momentum)
		{
		}

		// Token: 0x06005A4A RID: 23114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A4A")]
		[Address(RVA = "0x9B31F0", Offset = "0x9B23F0", VA = "0x1809B31F0")]
		public void PlayFootstepSound(EMaterialType materialType, float volume, Vector3 position)
		{
		}

		// Token: 0x06005A4B RID: 23115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A4B")]
		[Address(RVA = "0x9B3A00", Offset = "0x9B2C00", VA = "0x1809B3A00")]
		public void SetConfiguration(BaseConfiguration baseConfiguration)
		{
		}

		// Token: 0x06005A4C RID: 23116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A4C")]
		[Address(RVA = "0x9B3B80", Offset = "0x9B2D80", VA = "0x1809B3B80")]
		private void SetupSoundPool()
		{
		}

		// Token: 0x06005A4D RID: 23117 RVA: 0x00016E18 File Offset: 0x00015018
		[Token(Token = "0x6005A4D")]
		[Address(RVA = "0x9B4050", Offset = "0x9B3250", VA = "0x1809B4050")]
		private bool TryPullAudioSource(out AudioSourceController source)
		{
			return default(bool);
		}

		// Token: 0x06005A4E RID: 23118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A4E")]
		[Address(RVA = "0x9B4340", Offset = "0x9B3540", VA = "0x1809B4340")]
		public SFXManager()
		{
		}

		// Token: 0x04003C5C RID: 15452
		[Token(Token = "0x4003C5C")]
		[FieldOffset(Offset = "0x0")]
		private static float ImpactSoundMaxRangeSquared;

		// Token: 0x04003C5D RID: 15453
		[Token(Token = "0x4003C5D")]
		[FieldOffset(Offset = "0x28")]
		private List<AudioSourceController> _soundPool;

		// Token: 0x04003C5E RID: 15454
		[Token(Token = "0x4003C5E")]
		[FieldOffset(Offset = "0x30")]
		private List<AudioSourceController> _soundsInUse;

		// Token: 0x04003C5F RID: 15455
		[Token(Token = "0x4003C5F")]
		[FieldOffset(Offset = "0x38")]
		private SFXConfiguration _configuration;
	}
}
