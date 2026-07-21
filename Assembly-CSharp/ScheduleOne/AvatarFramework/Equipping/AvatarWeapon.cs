using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x0200083C RID: 2108
	[Token(Token = "0x200083C")]
	public class AvatarWeapon : AvatarEquippable
	{
		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06003880 RID: 14464 RVA: 0x000109F8 File Offset: 0x0000EBF8
		// (set) Token: 0x06003881 RID: 14465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008F2")]
		public float LastUseTime
		{
			[Token(Token = "0x6003880")]
			[Address(RVA = "0x7F7F80", Offset = "0x7F7180", VA = "0x1807F7F80")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003881")]
			[Address(RVA = "0x7F7F90", Offset = "0x7F7190", VA = "0x1807F7F90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003882 RID: 14466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003882")]
		[Address(RVA = "0x7F7E20", Offset = "0x7F7020", VA = "0x1807F7E20", Slot = "5")]
		public override void Equip(Avatar _avatar)
		{
		}

		// Token: 0x06003883 RID: 14467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003883")]
		[Address(RVA = "0x7F7E00", Offset = "0x7F7000", VA = "0x1807F7E00", Slot = "9")]
		public virtual void Attack()
		{
		}

		// Token: 0x06003884 RID: 14468 RVA: 0x00010A10 File Offset: 0x0000EC10
		[Token(Token = "0x6003884")]
		[Address(RVA = "0x7F7F20", Offset = "0x7F7120", VA = "0x1807F7F20", Slot = "10")]
		public virtual bool IsReadyToAttack()
		{
			return default(bool);
		}

		// Token: 0x06003885 RID: 14469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003885")]
		[Address(RVA = "0x7F7F60", Offset = "0x7F7160", VA = "0x1807F7F60")]
		public AvatarWeapon()
		{
		}

		// Token: 0x0400298B RID: 10635
		[Token(Token = "0x400298B")]
		[FieldOffset(Offset = "0x58")]
		[Header("Range settings")]
		public float MinUseRange;

		// Token: 0x0400298C RID: 10636
		[Token(Token = "0x400298C")]
		[FieldOffset(Offset = "0x5C")]
		public float MaxUseRange;

		// Token: 0x0400298D RID: 10637
		[Token(Token = "0x400298D")]
		[FieldOffset(Offset = "0x60")]
		[Header("Cooldown settings")]
		public float CooldownDuration;

		// Token: 0x0400298E RID: 10638
		[Token(Token = "0x400298E")]
		[FieldOffset(Offset = "0x68")]
		[Header("Equipping")]
		public AudioClip[] EquipClips;

		// Token: 0x0400298F RID: 10639
		[Token(Token = "0x400298F")]
		[FieldOffset(Offset = "0x70")]
		public AudioSourceController EquipSound;

		// Token: 0x04002990 RID: 10640
		[Token(Token = "0x4002990")]
		[FieldOffset(Offset = "0x78")]
		public float EquipDuration;

		// Token: 0x04002992 RID: 10642
		[Token(Token = "0x4002992")]
		[FieldOffset(Offset = "0x80")]
		public UnityEvent onSuccessfulHit;

		// Token: 0x04002993 RID: 10643
		[Token(Token = "0x4002993")]
		[FieldOffset(Offset = "0x88")]
		private float _timeOnEquip;
	}
}
