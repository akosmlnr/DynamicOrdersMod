using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Combat;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x02000955 RID: 2389
	[Token(Token = "0x2000955")]
	public class Equippable_MeleeWeapon : Equippable_AvatarViewmodel
	{
		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06003FE8 RID: 16360 RVA: 0x000122B8 File Offset: 0x000104B8
		[Token(Token = "0x170009F3")]
		public bool IsLoading
		{
			[Token(Token = "0x6003FE8")]
			[Address(RVA = "0x853B70", Offset = "0x852D70", VA = "0x180853B70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06003FE9 RID: 16361 RVA: 0x000122D0 File Offset: 0x000104D0
		// (set) Token: 0x06003FEA RID: 16362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F4")]
		public bool IsAttacking
		{
			[Token(Token = "0x6003FE9")]
			[Address(RVA = "0x674710", Offset = "0x673910", VA = "0x180674710")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003FEA")]
			[Address(RVA = "0x6747B0", Offset = "0x6739B0", VA = "0x1806747B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003FEB RID: 16363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FEB")]
		[Address(RVA = "0x8539B0", Offset = "0x852BB0", VA = "0x1808539B0", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x06003FEC RID: 16364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FEC")]
		[Address(RVA = "0x8525F0", Offset = "0x8517F0", VA = "0x1808525F0", Slot = "4")]
		public override void Equip(ItemInstance item)
		{
		}

		// Token: 0x06003FED RID: 16365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FED")]
		[Address(RVA = "0x8534C0", Offset = "0x8526C0", VA = "0x1808534C0", Slot = "5")]
		public override void Unequip()
		{
		}

		// Token: 0x06003FEE RID: 16366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FEE")]
		[Address(RVA = "0x853570", Offset = "0x852770", VA = "0x180853570")]
		private void UpdateCooldown()
		{
		}

		// Token: 0x06003FEF RID: 16367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FEF")]
		[Address(RVA = "0x8535F0", Offset = "0x8527F0", VA = "0x1808535F0")]
		private void UpdateInput()
		{
		}

		// Token: 0x06003FF0 RID: 16368 RVA: 0x000122E8 File Offset: 0x000104E8
		[Token(Token = "0x6003FF0")]
		[Address(RVA = "0x852550", Offset = "0x851750", VA = "0x180852550")]
		private bool CanStartLoading()
		{
			return default(bool);
		}

		// Token: 0x06003FF1 RID: 16369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FF1")]
		[Address(RVA = "0x853320", Offset = "0x852520", VA = "0x180853320")]
		private void StartLoad()
		{
		}

		// Token: 0x06003FF2 RID: 16370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FF2")]
		[Address(RVA = "0x852EE0", Offset = "0x8520E0", VA = "0x180852EE0")]
		private void Release()
		{
		}

		// Token: 0x06003FF3 RID: 16371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FF3")]
		[Address(RVA = "0x852D20", Offset = "0x851F20", VA = "0x180852D20")]
		private void Hit(float power)
		{
		}

		// Token: 0x06003FF4 RID: 16372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FF4")]
		[Address(RVA = "0x852600", Offset = "0x851800", VA = "0x180852600")]
		private void ExecuteHit(float power)
		{
		}

		// Token: 0x06003FF5 RID: 16373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FF5")]
		[Address(RVA = "0x853AD0", Offset = "0x852CD0", VA = "0x180853AD0")]
		public Equippable_MeleeWeapon()
		{
		}

		// Token: 0x04002E91 RID: 11921
		[Token(Token = "0x4002E91")]
		[FieldOffset(Offset = "0x9C")]
		[Header("Basic Settings")]
		public EImpactType ImpactType;

		// Token: 0x04002E92 RID: 11922
		[Token(Token = "0x4002E92")]
		[FieldOffset(Offset = "0xA0")]
		public float Range;

		// Token: 0x04002E93 RID: 11923
		[Token(Token = "0x4002E93")]
		[FieldOffset(Offset = "0xA4")]
		public float HitRadius;

		// Token: 0x04002E94 RID: 11924
		[Token(Token = "0x4002E94")]
		[FieldOffset(Offset = "0xA8")]
		[Header("Timing")]
		public float MaxLoadTime;

		// Token: 0x04002E95 RID: 11925
		[Token(Token = "0x4002E95")]
		[FieldOffset(Offset = "0xAC")]
		public float MinCooldown;

		// Token: 0x04002E96 RID: 11926
		[Token(Token = "0x4002E96")]
		[FieldOffset(Offset = "0xB0")]
		public float MaxCooldown;

		// Token: 0x04002E97 RID: 11927
		[Token(Token = "0x4002E97")]
		[FieldOffset(Offset = "0xB4")]
		public float MinHitDelay;

		// Token: 0x04002E98 RID: 11928
		[Token(Token = "0x4002E98")]
		[FieldOffset(Offset = "0xB8")]
		public float MaxHitDelay;

		// Token: 0x04002E99 RID: 11929
		[Token(Token = "0x4002E99")]
		[FieldOffset(Offset = "0xBC")]
		[Header("Damage")]
		public float MinDamage;

		// Token: 0x04002E9A RID: 11930
		[Token(Token = "0x4002E9A")]
		[FieldOffset(Offset = "0xC0")]
		public float MaxDamage;

		// Token: 0x04002E9B RID: 11931
		[Token(Token = "0x4002E9B")]
		[FieldOffset(Offset = "0xC4")]
		public float MinForce;

		// Token: 0x04002E9C RID: 11932
		[Token(Token = "0x4002E9C")]
		[FieldOffset(Offset = "0xC8")]
		public float MaxForce;

		// Token: 0x04002E9D RID: 11933
		[Token(Token = "0x4002E9D")]
		[FieldOffset(Offset = "0xCC")]
		[Header("Stamina Settings")]
		public float MinStaminaCost;

		// Token: 0x04002E9E RID: 11934
		[Token(Token = "0x4002E9E")]
		[FieldOffset(Offset = "0xD0")]
		public float MaxStaminaCost;

		// Token: 0x04002E9F RID: 11935
		[Token(Token = "0x4002E9F")]
		[FieldOffset(Offset = "0xD8")]
		[Header("Sound")]
		public AudioSourceController WhooshSound;

		// Token: 0x04002EA0 RID: 11936
		[Token(Token = "0x4002EA0")]
		[FieldOffset(Offset = "0xE0")]
		public float WhooshSoundPitch;

		// Token: 0x04002EA1 RID: 11937
		[Token(Token = "0x4002EA1")]
		[FieldOffset(Offset = "0xE8")]
		public AudioSourceController ImpactSound;

		// Token: 0x04002EA2 RID: 11938
		[Token(Token = "0x4002EA2")]
		[FieldOffset(Offset = "0xF0")]
		[Header("Animation")]
		public string SwingAnimationTrigger;

		// Token: 0x04002EA3 RID: 11939
		[Token(Token = "0x4002EA3")]
		[FieldOffset(Offset = "0xF8")]
		private float load;

		// Token: 0x04002EA4 RID: 11940
		[Token(Token = "0x4002EA4")]
		[FieldOffset(Offset = "0xFC")]
		private float remainingCooldown;

		// Token: 0x04002EA5 RID: 11941
		[Token(Token = "0x4002EA5")]
		[FieldOffset(Offset = "0x100")]
		private Coroutine hitRoutine;

		// Token: 0x04002EA6 RID: 11942
		[Token(Token = "0x4002EA6")]
		[FieldOffset(Offset = "0x108")]
		private bool loadQueued;

		// Token: 0x04002EA7 RID: 11943
		[Token(Token = "0x4002EA7")]
		[FieldOffset(Offset = "0x109")]
		private bool clickReleased;
	}
}
