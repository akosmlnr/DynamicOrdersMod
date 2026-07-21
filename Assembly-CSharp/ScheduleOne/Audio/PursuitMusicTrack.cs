using System;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x02000BE6 RID: 3046
	[Token(Token = "0x2000BE6")]
	public class PursuitMusicTrack : MusicTrack
	{
		// Token: 0x06005A21 RID: 23073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A21")]
		[Address(RVA = "0x9B2380", Offset = "0x9B1580", VA = "0x1809B2380", Slot = "8")]
		protected virtual void Start()
		{
		}

		// Token: 0x06005A22 RID: 23074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A22")]
		[Address(RVA = "0x9B1EB0", Offset = "0x9B10B0", VA = "0x1809B1EB0")]
		private void OnLoadComplete()
		{
		}

		// Token: 0x06005A23 RID: 23075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A23")]
		[Address(RVA = "0x9B21F0", Offset = "0x9B13F0", VA = "0x1809B21F0")]
		private void RegisterEvent()
		{
		}

		// Token: 0x06005A24 RID: 23076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A24")]
		[Address(RVA = "0x9B2470", Offset = "0x9B1670", VA = "0x1809B2470", Slot = "7")]
		protected override void Update()
		{
		}

		// Token: 0x06005A25 RID: 23077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A25")]
		[Address(RVA = "0x9B21C0", Offset = "0x9B13C0", VA = "0x1809B21C0")]
		private void PursuitLevelChange(PlayerCrimeData.EPursuitLevel oldLevel, PlayerCrimeData.EPursuitLevel newLevel)
		{
		}

		// Token: 0x06005A26 RID: 23078 RVA: 0x00016D70 File Offset: 0x00014F70
		[Token(Token = "0x6005A26")]
		[Address(RVA = "0x9B1D70", Offset = "0x9B0F70", VA = "0x1809B1D70")]
		private float GetNewVolume()
		{
			return 0f;
		}

		// Token: 0x06005A27 RID: 23079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A27")]
		[Address(RVA = "0x9B1D60", Offset = "0x9B0F60", VA = "0x1809B1D60")]
		public PursuitMusicTrack()
		{
		}

		// Token: 0x04003C47 RID: 15431
		[Token(Token = "0x4003C47")]
		private const float OutOfSightTimeToDipMusic = 8f;

		// Token: 0x04003C48 RID: 15432
		[Token(Token = "0x4003C48")]
		private const float MinMusicVolume = 0.6f;

		// Token: 0x04003C49 RID: 15433
		[Token(Token = "0x4003C49")]
		private const float MusicChangeRate_Down = 0.04f;

		// Token: 0x04003C4A RID: 15434
		[Token(Token = "0x4003C4A")]
		private const float MusicChangeRate_Up = 2f;

		// Token: 0x04003C4B RID: 15435
		[Token(Token = "0x4003C4B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private PlayerCrimeData.EPursuitLevel _pursuitLevelToActivate;
	}
}
