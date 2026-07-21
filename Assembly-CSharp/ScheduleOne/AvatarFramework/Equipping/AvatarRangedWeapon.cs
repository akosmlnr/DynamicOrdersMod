using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Combat;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x0200083A RID: 2106
	[Token(Token = "0x200083A")]
	public class AvatarRangedWeapon : AvatarWeapon
	{
		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x0600386C RID: 14444 RVA: 0x00010980 File Offset: 0x0000EB80
		// (set) Token: 0x0600386D RID: 14445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008EF")]
		public bool IsRaised
		{
			[Token(Token = "0x600386C")]
			[Address(RVA = "0x514930", Offset = "0x513B30", VA = "0x180514930")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600386D")]
			[Address(RVA = "0x7F7DF0", Offset = "0x7F6FF0", VA = "0x1807F7DF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600386E RID: 14446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600386E")]
		[Address(RVA = "0x7F7140", Offset = "0x7F6340", VA = "0x1807F7140", Slot = "5")]
		public override void Equip(Avatar _avatar)
		{
		}

		// Token: 0x0600386F RID: 14447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600386F")]
		[Address(RVA = "0x7F7C80", Offset = "0x7F6E80", VA = "0x1807F7C80", Slot = "7")]
		public override void Unequip()
		{
		}

		// Token: 0x06003870 RID: 14448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003870")]
		[Address(RVA = "0x7F7A60", Offset = "0x7F6C60", VA = "0x1807F7A60", Slot = "11")]
		public virtual void SetIsRaised(bool raised)
		{
		}

		// Token: 0x06003871 RID: 14449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003871")]
		[Address(RVA = "0x7F7CC0", Offset = "0x7F6EC0", VA = "0x1807F7CC0")]
		private void Update()
		{
		}

		// Token: 0x06003872 RID: 14450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003872")]
		[Address(RVA = "0x7F78A0", Offset = "0x7F6AA0", VA = "0x1807F78A0", Slot = "8")]
		public override void ReceiveMessage(string message, object data)
		{
		}

		// Token: 0x06003873 RID: 14451 RVA: 0x00010998 File Offset: 0x0000EB98
		[Token(Token = "0x6003873")]
		[Address(RVA = "0x7F70E0", Offset = "0x7F62E0", VA = "0x1807F70E0")]
		public bool CanShoot()
		{
			return default(bool);
		}

		// Token: 0x06003874 RID: 14452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003874")]
		[Address(RVA = "0x7F7AE0", Offset = "0x7F6CE0", VA = "0x1807F7AE0", Slot = "12")]
		protected virtual void Shoot(Vector3 endPoint)
		{
		}

		// Token: 0x06003875 RID: 14453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003875")]
		[Address(RVA = "0x7F6ED0", Offset = "0x7F60D0", VA = "0x1807F6ED0", Slot = "13")]
		public virtual void ApplyHitToDamageable(IDamageable damageable, Vector3 hitPoint)
		{
		}

		// Token: 0x06003876 RID: 14454 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003876")]
		[Address(RVA = "0x7F79F0", Offset = "0x7F6BF0", VA = "0x1807F79F0")]
		private IEnumerator Reload()
		{
			return null;
		}

		// Token: 0x06003877 RID: 14455 RVA: 0x000109B0 File Offset: 0x0000EBB0
		[Token(Token = "0x6003877")]
		[Address(RVA = "0x7F7270", Offset = "0x7F6470", VA = "0x1807F7270")]
		public bool IsTargetInLoS(ICombatTargetable target)
		{
			return default(bool);
		}

		// Token: 0x06003878 RID: 14456 RVA: 0x000109C8 File Offset: 0x0000EBC8
		[Token(Token = "0x6003878")]
		[Address(RVA = "0x7F7250", Offset = "0x7F6450", VA = "0x1807F7250", Slot = "14")]
		public virtual float GetIdealUseRange()
		{
			return 0f;
		}

		// Token: 0x06003879 RID: 14457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003879")]
		[Address(RVA = "0x7F7D40", Offset = "0x7F6F40", VA = "0x1807F7D40")]
		public AvatarRangedWeapon()
		{
		}

		// Token: 0x0400296E RID: 10606
		[Token(Token = "0x400296E")]
		[FieldOffset(Offset = "0x90")]
		[Header("Weapon Settings")]
		public int MagazineSize;

		// Token: 0x0400296F RID: 10607
		[Token(Token = "0x400296F")]
		[FieldOffset(Offset = "0x94")]
		public float ReloadTime;

		// Token: 0x04002970 RID: 10608
		[Token(Token = "0x4002970")]
		[FieldOffset(Offset = "0x98")]
		public float MaxFireRate;

		// Token: 0x04002971 RID: 10609
		[Token(Token = "0x4002971")]
		[FieldOffset(Offset = "0x9C")]
		public float EquipTime;

		// Token: 0x04002972 RID: 10610
		[Token(Token = "0x4002972")]
		[FieldOffset(Offset = "0xA0")]
		public float RaiseTime;

		// Token: 0x04002973 RID: 10611
		[Token(Token = "0x4002973")]
		[FieldOffset(Offset = "0xA4")]
		public float Damage;

		// Token: 0x04002974 RID: 10612
		[Token(Token = "0x4002974")]
		[FieldOffset(Offset = "0xA8")]
		public float ImpactForce;

		// Token: 0x04002975 RID: 10613
		[Token(Token = "0x4002975")]
		[FieldOffset(Offset = "0xAC")]
		public bool CanShootWhileMoving;

		// Token: 0x04002976 RID: 10614
		[Token(Token = "0x4002976")]
		[FieldOffset(Offset = "0xB0")]
		public int MaxMovingShotsBeforeReposition;

		// Token: 0x04002977 RID: 10615
		[Token(Token = "0x4002977")]
		[FieldOffset(Offset = "0xB4")]
		public int MaxStationaryShotsBeforeReposition;

		// Token: 0x04002978 RID: 10616
		[Token(Token = "0x4002978")]
		[FieldOffset(Offset = "0xB8")]
		public bool RepositionAfterHit;

		// Token: 0x04002979 RID: 10617
		[Token(Token = "0x4002979")]
		[FieldOffset(Offset = "0xBC")]
		[Header("Accuracy")]
		public float HitChance_MinRange;

		// Token: 0x0400297A RID: 10618
		[Token(Token = "0x400297A")]
		[FieldOffset(Offset = "0xC0")]
		public float HitChance_MaxRange;

		// Token: 0x0400297B RID: 10619
		[Token(Token = "0x400297B")]
		[FieldOffset(Offset = "0xC4")]
		[Header("Aiming")]
		public float AimTime_Min;

		// Token: 0x0400297C RID: 10620
		[Token(Token = "0x400297C")]
		[FieldOffset(Offset = "0xC8")]
		public float AimTime_Max;

		// Token: 0x0400297D RID: 10621
		[Token(Token = "0x400297D")]
		[FieldOffset(Offset = "0xD0")]
		[Header("References")]
		public Transform MuzzlePoint;

		// Token: 0x0400297E RID: 10622
		[Token(Token = "0x400297E")]
		[FieldOffset(Offset = "0xD8")]
		public AudioSourceController FireSound;

		// Token: 0x0400297F RID: 10623
		[Token(Token = "0x400297F")]
		[FieldOffset(Offset = "0xE0")]
		[Header("Animation Settings")]
		public string LoweredAnimationTrigger;

		// Token: 0x04002980 RID: 10624
		[Token(Token = "0x4002980")]
		[FieldOffset(Offset = "0xE8")]
		public string RaisedAnimationTrigger;

		// Token: 0x04002981 RID: 10625
		[Token(Token = "0x4002981")]
		[FieldOffset(Offset = "0xF0")]
		public string RecoilAnimationTrigger;

		// Token: 0x04002983 RID: 10627
		[Token(Token = "0x4002983")]
		[FieldOffset(Offset = "0xF9")]
		private bool isReloading;

		// Token: 0x04002984 RID: 10628
		[Token(Token = "0x4002984")]
		[FieldOffset(Offset = "0xFC")]
		private float timeEquipped;

		// Token: 0x04002985 RID: 10629
		[Token(Token = "0x4002985")]
		[FieldOffset(Offset = "0x100")]
		private float timeRaised;

		// Token: 0x04002986 RID: 10630
		[Token(Token = "0x4002986")]
		[FieldOffset(Offset = "0x104")]
		private float timeSinceLastShot;

		// Token: 0x04002987 RID: 10631
		[Token(Token = "0x4002987")]
		[FieldOffset(Offset = "0x108")]
		private int currentAmmo;
	}
}
