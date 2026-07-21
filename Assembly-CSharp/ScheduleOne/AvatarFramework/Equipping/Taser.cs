using System;
using System.Collections;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Combat;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x0200083D RID: 2109
	[Token(Token = "0x200083D")]
	public class Taser : AvatarRangedWeapon
	{
		// Token: 0x06003886 RID: 14470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003886")]
		[Address(RVA = "0x80F080", Offset = "0x80E280", VA = "0x18080F080", Slot = "5")]
		public override void Equip(Avatar _avatar)
		{
		}

		// Token: 0x06003887 RID: 14471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003887")]
		[Address(RVA = "0x80F300", Offset = "0x80E500", VA = "0x18080F300", Slot = "12")]
		protected override void Shoot(Vector3 endPoint)
		{
		}

		// Token: 0x06003888 RID: 14472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003888")]
		[Address(RVA = "0x80EFD0", Offset = "0x80E1D0", VA = "0x18080EFD0", Slot = "13")]
		public override void ApplyHitToDamageable(IDamageable damageable, Vector3 hitPoint)
		{
		}

		// Token: 0x06003889 RID: 14473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003889")]
		[Address(RVA = "0x80F260", Offset = "0x80E460", VA = "0x18080F260", Slot = "11")]
		public override void SetIsRaised(bool raised)
		{
		}

		// Token: 0x0600388A RID: 14474 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600388A")]
		[Address(RVA = "0x80F1D0", Offset = "0x80E3D0", VA = "0x18080F1D0")]
		private IEnumerator Flash(Vector3 endPoint)
		{
			return null;
		}

		// Token: 0x0600388B RID: 14475 RVA: 0x00010A28 File Offset: 0x0000EC28
		[Token(Token = "0x600388B")]
		[Address(RVA = "0x4B4830", Offset = "0x4B3A30", VA = "0x1804B4830", Slot = "14")]
		public override float GetIdealUseRange()
		{
			return 0f;
		}

		// Token: 0x0600388C RID: 14476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600388C")]
		[Address(RVA = "0x7F7D40", Offset = "0x7F6F40", VA = "0x1807F7D40")]
		public Taser()
		{
		}

		// Token: 0x04002994 RID: 10644
		[Token(Token = "0x4002994")]
		public const float TaseDuration = 2f;

		// Token: 0x04002995 RID: 10645
		[Token(Token = "0x4002995")]
		public const float TaseMoveSpeedMultiplier = 0.5f;

		// Token: 0x04002996 RID: 10646
		[Token(Token = "0x4002996")]
		[FieldOffset(Offset = "0x110")]
		[Header("References")]
		public GameObject FlashObject;

		// Token: 0x04002997 RID: 10647
		[Token(Token = "0x4002997")]
		[FieldOffset(Offset = "0x118")]
		public AudioSourceController ChargeSound;

		// Token: 0x04002998 RID: 10648
		[Token(Token = "0x4002998")]
		[FieldOffset(Offset = "0x120")]
		[Header("Prefabs")]
		public GameObject RayPrefab;

		// Token: 0x04002999 RID: 10649
		[Token(Token = "0x4002999")]
		[FieldOffset(Offset = "0x128")]
		private Coroutine flashRoutine;
	}
}
