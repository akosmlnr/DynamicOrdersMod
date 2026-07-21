using System;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Combat;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.FX
{
	// Token: 0x02000686 RID: 1670
	[Token(Token = "0x2000686")]
	public class FXManager : Singleton<FXManager>
	{
		// Token: 0x06002B49 RID: 11081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B49")]
		[Address(RVA = "0x701EF0", Offset = "0x7010F0", VA = "0x180701EF0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06002B4A RID: 11082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B4A")]
		[Address(RVA = "0x701560", Offset = "0x700760", VA = "0x180701560")]
		public void CreateImpactFX(Impact impact, IDamageable target)
		{
		}

		// Token: 0x06002B4B RID: 11083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B4B")]
		[Address(RVA = "0x7011A0", Offset = "0x7003A0", VA = "0x1807011A0")]
		public void CreateBulletTrail(Vector3 start, Vector3 dir, float speed, float range, LayerMask mask)
		{
		}

		// Token: 0x06002B4C RID: 11084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B4C")]
		[Address(RVA = "0x701C00", Offset = "0x700E00", VA = "0x180701C00")]
		private void PlayImpact(AudioClip clip, Vector3 position, float volume)
		{
		}

		// Token: 0x06002B4D RID: 11085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B4D")]
		[Address(RVA = "0x701E40", Offset = "0x701040", VA = "0x180701E40")]
		private void PlayParticles(GameObject prefab, Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x06002B4E RID: 11086 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002B4E")]
		[Address(RVA = "0x701980", Offset = "0x700B80", VA = "0x180701980")]
		private AudioClip GetImpactSound(Impact impact, IDamageable target)
		{
			return null;
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002B4F")]
		[Address(RVA = "0x7018D0", Offset = "0x700AD0", VA = "0x1807018D0")]
		private GameObject GetImpactParticles(Impact impact, IDamageable target)
		{
			return null;
		}

		// Token: 0x06002B50 RID: 11088 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002B50")]
		[Address(RVA = "0x701AE0", Offset = "0x700CE0", VA = "0x180701AE0")]
		private AudioSourceController GetSource()
		{
			return null;
		}

		// Token: 0x06002B51 RID: 11089 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002B51")]
		[Address(RVA = "0x701AA0", Offset = "0x700CA0", VA = "0x180701AA0")]
		private static AudioClip GetRandomClip(AudioClip[] clips)
		{
			return null;
		}

		// Token: 0x06002B52 RID: 11090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B52")]
		[Address(RVA = "0x701F30", Offset = "0x701130", VA = "0x180701F30")]
		public FXManager()
		{
		}

		// Token: 0x0400207F RID: 8319
		[Token(Token = "0x400207F")]
		[FieldOffset(Offset = "0x28")]
		public AudioClip[] PunchImpactsClips;

		// Token: 0x04002080 RID: 8320
		[Token(Token = "0x4002080")]
		[FieldOffset(Offset = "0x30")]
		public AudioClip[] SlashImpactClips;

		// Token: 0x04002081 RID: 8321
		[Token(Token = "0x4002081")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public AudioSourceController[] ImpactSources;

		// Token: 0x04002082 RID: 8322
		[Token(Token = "0x4002082")]
		[FieldOffset(Offset = "0x40")]
		[Header("Particle Prefabs")]
		public GameObject PunchParticlePrefab;

		// Token: 0x04002083 RID: 8323
		[Token(Token = "0x4002083")]
		[FieldOffset(Offset = "0x48")]
		[Header("Trails")]
		public TrailRenderer BulletTrail;
	}
}
