using System;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Combat;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000836 RID: 2102
	[Token(Token = "0x2000836")]
	public class AvatarMeleeWeapon : AvatarWeapon
	{
		// Token: 0x0600385F RID: 14431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600385F")]
		[Address(RVA = "0x7EB2A0", Offset = "0x7EA4A0", VA = "0x1807EB2A0", Slot = "7")]
		public override void Unequip()
		{
		}

		// Token: 0x06003860 RID: 14432 RVA: 0x00010950 File Offset: 0x0000EB50
		[Token(Token = "0x6003860")]
		[Address(RVA = "0x7EB270", Offset = "0x7EA470", VA = "0x1807EB270", Slot = "10")]
		public override bool IsReadyToAttack()
		{
			return default(bool);
		}

		// Token: 0x06003861 RID: 14433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003861")]
		[Address(RVA = "0x7EB050", Offset = "0x7EA250", VA = "0x1807EB050", Slot = "9")]
		public override void Attack()
		{
		}

		// Token: 0x06003862 RID: 14434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003862")]
		[Address(RVA = "0x7EB370", Offset = "0x7EA570", VA = "0x1807EB370")]
		public AvatarMeleeWeapon()
		{
		}

		// Token: 0x04002957 RID: 10583
		[Token(Token = "0x4002957")]
		[FieldOffset(Offset = "0x90")]
		[Header("References")]
		public AudioSourceController AttackSound;

		// Token: 0x04002958 RID: 10584
		[Token(Token = "0x4002958")]
		[FieldOffset(Offset = "0x98")]
		public AudioSourceController HitSound;

		// Token: 0x04002959 RID: 10585
		[Token(Token = "0x4002959")]
		[FieldOffset(Offset = "0xA0")]
		[Header("Melee Weapon settings")]
		public EImpactType ImpactType;

		// Token: 0x0400295A RID: 10586
		[Token(Token = "0x400295A")]
		[FieldOffset(Offset = "0xA4")]
		public float AttackRange;

		// Token: 0x0400295B RID: 10587
		[Token(Token = "0x400295B")]
		[FieldOffset(Offset = "0xA8")]
		public float AttackRadius;

		// Token: 0x0400295C RID: 10588
		[Token(Token = "0x400295C")]
		[FieldOffset(Offset = "0xAC")]
		public float Damage;

		// Token: 0x0400295D RID: 10589
		[Token(Token = "0x400295D")]
		[FieldOffset(Offset = "0xB0")]
		public float ImpactForce;

		// Token: 0x0400295E RID: 10590
		[Token(Token = "0x400295E")]
		[FieldOffset(Offset = "0xB8")]
		public AvatarMeleeWeapon.MeleeAttack[] Attacks;

		// Token: 0x0400295F RID: 10591
		[Token(Token = "0x400295F")]
		[FieldOffset(Offset = "0xC0")]
		public float GruntChance;

		// Token: 0x04002960 RID: 10592
		[Token(Token = "0x4002960")]
		[FieldOffset(Offset = "0xC8")]
		private Coroutine attackRoutine;

		// Token: 0x02000837 RID: 2103
		[Token(Token = "0x2000837")]
		[Serializable]
		public class MeleeAttack
		{
			// Token: 0x06003863 RID: 14435 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003863")]
			[Address(RVA = "0x7F3870", Offset = "0x7F2A70", VA = "0x1807F3870")]
			public MeleeAttack()
			{
			}

			// Token: 0x04002961 RID: 10593
			[Token(Token = "0x4002961")]
			[FieldOffset(Offset = "0x10")]
			public float RangeMultiplier;

			// Token: 0x04002962 RID: 10594
			[Token(Token = "0x4002962")]
			[FieldOffset(Offset = "0x14")]
			public float DamageMultiplier;

			// Token: 0x04002963 RID: 10595
			[Token(Token = "0x4002963")]
			[FieldOffset(Offset = "0x18")]
			public string AnimationTrigger;

			// Token: 0x04002964 RID: 10596
			[Token(Token = "0x4002964")]
			[FieldOffset(Offset = "0x20")]
			public float DamageDelay;

			// Token: 0x04002965 RID: 10597
			[Token(Token = "0x4002965")]
			[FieldOffset(Offset = "0x24")]
			public float AttackSoundDelay;

			// Token: 0x04002966 RID: 10598
			[Token(Token = "0x4002966")]
			[FieldOffset(Offset = "0x28")]
			public AudioClip[] AttackClips;

			// Token: 0x04002967 RID: 10599
			[Token(Token = "0x4002967")]
			[FieldOffset(Offset = "0x30")]
			public AudioClip[] HitClips;
		}
	}
}
