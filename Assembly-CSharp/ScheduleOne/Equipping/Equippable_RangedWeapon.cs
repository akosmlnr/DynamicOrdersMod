using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.ItemFramework;
using ScheduleOne.Storage;
using ScheduleOne.Trash;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Equipping
{
	// Token: 0x0200095A RID: 2394
	[Token(Token = "0x200095A")]
	public class Equippable_RangedWeapon : Equippable_AvatarViewmodel
	{
		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06004007 RID: 16391 RVA: 0x00012330 File Offset: 0x00010530
		// (set) Token: 0x06004008 RID: 16392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F8")]
		public float Aim
		{
			[Token(Token = "0x6004007")]
			[Address(RVA = "0x7B1350", Offset = "0x7B0550", VA = "0x1807B1350")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004008")]
			[Address(RVA = "0x857A60", Offset = "0x856C60", VA = "0x180857A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06004009 RID: 16393 RVA: 0x00012348 File Offset: 0x00010548
		// (set) Token: 0x0600400A RID: 16394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F9")]
		public float Accuracy
		{
			[Token(Token = "0x6004009")]
			[Address(RVA = "0x6A03D0", Offset = "0x69F5D0", VA = "0x1806A03D0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600400A")]
			[Address(RVA = "0x857A50", Offset = "0x856C50", VA = "0x180857A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x0600400B RID: 16395 RVA: 0x00012360 File Offset: 0x00010560
		// (set) Token: 0x0600400C RID: 16396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009FA")]
		public float TimeSinceFire
		{
			[Token(Token = "0x600400B")]
			[Address(RVA = "0x7B1340", Offset = "0x7B0540", VA = "0x1807B1340")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600400C")]
			[Address(RVA = "0x857AA0", Offset = "0x856CA0", VA = "0x180857AA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x0600400D RID: 16397 RVA: 0x00012378 File Offset: 0x00010578
		// (set) Token: 0x0600400E RID: 16398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009FB")]
		public bool IsReloading
		{
			[Token(Token = "0x600400D")]
			[Address(RVA = "0x857920", Offset = "0x856B20", VA = "0x180857920")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600400E")]
			[Address(RVA = "0x857A90", Offset = "0x856C90", VA = "0x180857A90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x0600400F RID: 16399 RVA: 0x00012390 File Offset: 0x00010590
		// (set) Token: 0x06004010 RID: 16400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009FC")]
		public bool IsCocked
		{
			[Token(Token = "0x600400F")]
			[Address(RVA = "0x857900", Offset = "0x856B00", VA = "0x180857900")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004010")]
			[Address(RVA = "0x857A70", Offset = "0x856C70", VA = "0x180857A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06004011 RID: 16401 RVA: 0x000123A8 File Offset: 0x000105A8
		// (set) Token: 0x06004012 RID: 16402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009FD")]
		public bool IsCocking
		{
			[Token(Token = "0x6004011")]
			[Address(RVA = "0x857910", Offset = "0x856B10", VA = "0x180857910")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004012")]
			[Address(RVA = "0x857A80", Offset = "0x856C80", VA = "0x180857A80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06004013 RID: 16403 RVA: 0x000123C0 File Offset: 0x000105C0
		[Token(Token = "0x170009FE")]
		public int Ammo
		{
			[Token(Token = "0x6004013")]
			[Address(RVA = "0x8578E0", Offset = "0x856AE0", VA = "0x1808578E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06004014 RID: 16404 RVA: 0x000123D8 File Offset: 0x000105D8
		[Token(Token = "0x170009FF")]
		private float fov
		{
			[Token(Token = "0x6004014")]
			[Address(RVA = "0x857930", Offset = "0x856B30", VA = "0x180857930")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06004015 RID: 16405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004015")]
		[Address(RVA = "0x854860", Offset = "0x853A60", VA = "0x180854860", Slot = "4")]
		public override void Equip(ItemInstance item)
		{
		}

		// Token: 0x06004016 RID: 16406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004016")]
		[Address(RVA = "0x8566D0", Offset = "0x8558D0", VA = "0x1808566D0", Slot = "5")]
		public override void Unequip()
		{
		}

		// Token: 0x06004017 RID: 16407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004017")]
		[Address(RVA = "0x857650", Offset = "0x856850", VA = "0x180857650", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x06004018 RID: 16408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004018")]
		[Address(RVA = "0x856B20", Offset = "0x855D20", VA = "0x180856B20")]
		private void UpdateInput()
		{
		}

		// Token: 0x06004019 RID: 16409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004019")]
		[Address(RVA = "0x856920", Offset = "0x855B20", VA = "0x180856920")]
		private void UpdateAnim()
		{
		}

		// Token: 0x0600401A RID: 16410 RVA: 0x000123F0 File Offset: 0x000105F0
		[Token(Token = "0x600401A")]
		[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0")]
		private bool CanAim()
		{
			return default(bool);
		}

		// Token: 0x0600401B RID: 16411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600401B")]
		[Address(RVA = "0x854A60", Offset = "0x853C60", VA = "0x180854A60", Slot = "9")]
		public virtual void Fire()
		{
		}

		// Token: 0x0600401C RID: 16412 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600401C")]
		[Address(RVA = "0x855D40", Offset = "0x854F40", VA = "0x180855D40", Slot = "10")]
		protected virtual Vector3[] GetBulletDirections()
		{
			return null;
		}

		// Token: 0x0600401D RID: 16413 RVA: 0x00012408 File Offset: 0x00010608
		[Token(Token = "0x600401D")]
		[Address(RVA = "0x856370", Offset = "0x855570", VA = "0x180856370")]
		protected static Vector3 SpreadDirection(Vector3 direction, float maxAngle)
		{
			return default(Vector3);
		}

		// Token: 0x0600401E RID: 16414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600401E")]
		[Address(RVA = "0x856270", Offset = "0x855470", VA = "0x180856270", Slot = "11")]
		public virtual void Reload()
		{
		}

		// Token: 0x0600401F RID: 16415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600401F")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "12")]
		protected virtual void NotifyIncrementalReload()
		{
		}

		// Token: 0x06004020 RID: 16416 RVA: 0x00012420 File Offset: 0x00010620
		[Token(Token = "0x6004020")]
		[Address(RVA = "0x8561A0", Offset = "0x8553A0", VA = "0x1808561A0")]
		private bool IsReloadReady(bool ignoreTiming)
		{
			return default(bool);
		}

		// Token: 0x06004021 RID: 16417 RVA: 0x00012438 File Offset: 0x00010638
		[Token(Token = "0x6004021")]
		[Address(RVA = "0x855E90", Offset = "0x855090", VA = "0x180855E90", Slot = "13")]
		protected virtual bool GetMagazine(out StorableItemInstance mag)
		{
			return default(bool);
		}

		// Token: 0x06004022 RID: 16418 RVA: 0x00012450 File Offset: 0x00010650
		[Token(Token = "0x6004022")]
		[Address(RVA = "0x8542D0", Offset = "0x8534D0", VA = "0x1808542D0")]
		private bool CanFire(bool checkAmmo = true)
		{
			return default(bool);
		}

		// Token: 0x06004023 RID: 16419 RVA: 0x00012468 File Offset: 0x00010668
		[Token(Token = "0x6004023")]
		[Address(RVA = "0x854260", Offset = "0x853460", VA = "0x180854260")]
		private bool CanCock()
		{
			return default(bool);
		}

		// Token: 0x06004024 RID: 16420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004024")]
		[Address(RVA = "0x8547E0", Offset = "0x8539E0", VA = "0x1808547E0")]
		private void Cock()
		{
		}

		// Token: 0x06004025 RID: 16421 RVA: 0x00012480 File Offset: 0x00010680
		[Token(Token = "0x6004025")]
		[Address(RVA = "0x856150", Offset = "0x855350", VA = "0x180856150")]
		protected float GetSpreadAngle()
		{
			return 0f;
		}

		// Token: 0x06004026 RID: 16422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004026")]
		[Address(RVA = "0x854340", Offset = "0x853540", VA = "0x180854340")]
		private void CheckAimingAtNPC()
		{
		}

		// Token: 0x06004027 RID: 16423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004027")]
		[Address(RVA = "0x857750", Offset = "0x856950", VA = "0x180857750")]
		public Equippable_RangedWeapon()
		{
		}

		// Token: 0x06004028 RID: 16424 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004028")]
		[Address(RVA = "0x856660", Offset = "0x855860", VA = "0x180856660")]
		[CompilerGenerated]
		private IEnumerator <Reload>g__ReloadRoutine|87_0()
		{
			return null;
		}

		// Token: 0x06004029 RID: 16425 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004029")]
		[Address(RVA = "0x8565F0", Offset = "0x8557F0", VA = "0x1808565F0")]
		[CompilerGenerated]
		private IEnumerator <Cock>g__CockRoutine|93_0()
		{
			return null;
		}

		// Token: 0x04002EB1 RID: 11953
		[Token(Token = "0x4002EB1")]
		public const float NPC_AIM_DETECTION_RANGE = 10f;

		// Token: 0x04002EB8 RID: 11960
		[Token(Token = "0x4002EB8")]
		[FieldOffset(Offset = "0xA8")]
		public int MagazineSize;

		// Token: 0x04002EB9 RID: 11961
		[Token(Token = "0x4002EB9")]
		[FieldOffset(Offset = "0xAC")]
		[Header("Aim Settings")]
		public float AimDuration;

		// Token: 0x04002EBA RID: 11962
		[Token(Token = "0x4002EBA")]
		[FieldOffset(Offset = "0xB0")]
		public float MinAimFOVReduction;

		// Token: 0x04002EBB RID: 11963
		[Token(Token = "0x4002EBB")]
		[FieldOffset(Offset = "0xB4")]
		public float MaxAimFOVReduction;

		// Token: 0x04002EBC RID: 11964
		[Token(Token = "0x4002EBC")]
		[FieldOffset(Offset = "0xB8")]
		[Header("Firing")]
		public AudioSourceController FireSound;

		// Token: 0x04002EBD RID: 11965
		[Token(Token = "0x4002EBD")]
		[FieldOffset(Offset = "0xC0")]
		public AudioSourceController EmptySound;

		// Token: 0x04002EBE RID: 11966
		[Token(Token = "0x4002EBE")]
		[FieldOffset(Offset = "0xC8")]
		public float FireCooldown;

		// Token: 0x04002EBF RID: 11967
		[Token(Token = "0x4002EBF")]
		[FieldOffset(Offset = "0xD0")]
		public string[] FireAnimTriggers;

		// Token: 0x04002EC0 RID: 11968
		[Token(Token = "0x4002EC0")]
		[FieldOffset(Offset = "0xD8")]
		public float AccuracyChangeDuration;

		// Token: 0x04002EC1 RID: 11969
		[Token(Token = "0x4002EC1")]
		[FieldOffset(Offset = "0xDC")]
		public float AccuracyDropPerShot;

		// Token: 0x04002EC2 RID: 11970
		[Token(Token = "0x4002EC2")]
		[FieldOffset(Offset = "0xE0")]
		[Header("Raycasting")]
		public float Range;

		// Token: 0x04002EC3 RID: 11971
		[Token(Token = "0x4002EC3")]
		[FieldOffset(Offset = "0xE4")]
		public float RayRadius;

		// Token: 0x04002EC4 RID: 11972
		[Token(Token = "0x4002EC4")]
		[FieldOffset(Offset = "0xE8")]
		[Header("Spread")]
		public float MinSpread;

		// Token: 0x04002EC5 RID: 11973
		[Token(Token = "0x4002EC5")]
		[FieldOffset(Offset = "0xEC")]
		public float MaxSpread;

		// Token: 0x04002EC6 RID: 11974
		[Token(Token = "0x4002EC6")]
		[FieldOffset(Offset = "0xF0")]
		[Header("Damage")]
		public float Damage;

		// Token: 0x04002EC7 RID: 11975
		[Token(Token = "0x4002EC7")]
		[FieldOffset(Offset = "0xF4")]
		public float ImpactForce;

		// Token: 0x04002EC8 RID: 11976
		[Token(Token = "0x4002EC8")]
		[FieldOffset(Offset = "0xF8")]
		public float HeadshotMultiplier;

		// Token: 0x04002EC9 RID: 11977
		[Token(Token = "0x4002EC9")]
		[FieldOffset(Offset = "0xFC")]
		[Header("Reloading")]
		public bool CanReload;

		// Token: 0x04002ECA RID: 11978
		[Token(Token = "0x4002ECA")]
		[FieldOffset(Offset = "0x100")]
		public Equippable_RangedWeapon.EReloadType ReloadType;

		// Token: 0x04002ECB RID: 11979
		[Token(Token = "0x4002ECB")]
		[FieldOffset(Offset = "0x108")]
		public StorableItemDefinition Magazine;

		// Token: 0x04002ECC RID: 11980
		[Token(Token = "0x4002ECC")]
		[FieldOffset(Offset = "0x110")]
		public float ReloadStartTime;

		// Token: 0x04002ECD RID: 11981
		[Token(Token = "0x4002ECD")]
		[FieldOffset(Offset = "0x114")]
		public float ReloadIndividalTime;

		// Token: 0x04002ECE RID: 11982
		[Token(Token = "0x4002ECE")]
		[FieldOffset(Offset = "0x118")]
		public float ReloadEndTime;

		// Token: 0x04002ECF RID: 11983
		[Token(Token = "0x4002ECF")]
		[FieldOffset(Offset = "0x120")]
		public string ReloadStartAnimTrigger;

		// Token: 0x04002ED0 RID: 11984
		[Token(Token = "0x4002ED0")]
		[FieldOffset(Offset = "0x128")]
		public string ReloadIndividualAnimTrigger;

		// Token: 0x04002ED1 RID: 11985
		[Token(Token = "0x4002ED1")]
		[FieldOffset(Offset = "0x130")]
		public string ReloadEndAnimTrigger;

		// Token: 0x04002ED2 RID: 11986
		[Token(Token = "0x4002ED2")]
		[FieldOffset(Offset = "0x138")]
		public TrashItem ReloadTrash;

		// Token: 0x04002ED3 RID: 11987
		[Token(Token = "0x4002ED3")]
		[FieldOffset(Offset = "0x140")]
		[Header("Cocking")]
		public bool MustBeCocked;

		// Token: 0x04002ED4 RID: 11988
		[Token(Token = "0x4002ED4")]
		[FieldOffset(Offset = "0x141")]
		public bool CockedByDefault;

		// Token: 0x04002ED5 RID: 11989
		[Token(Token = "0x4002ED5")]
		[FieldOffset(Offset = "0x142")]
		public bool AutoCockAfterReload;

		// Token: 0x04002ED6 RID: 11990
		[Token(Token = "0x4002ED6")]
		[FieldOffset(Offset = "0x144")]
		public float CockTime;

		// Token: 0x04002ED7 RID: 11991
		[Token(Token = "0x4002ED7")]
		[FieldOffset(Offset = "0x148")]
		public string CockAnimTrigger;

		// Token: 0x04002ED8 RID: 11992
		[Token(Token = "0x4002ED8")]
		[FieldOffset(Offset = "0x150")]
		[Header("Effects")]
		public float TracerSpeed;

		// Token: 0x04002ED9 RID: 11993
		[Token(Token = "0x4002ED9")]
		[FieldOffset(Offset = "0x158")]
		public UnityEvent onFire;

		// Token: 0x04002EDA RID: 11994
		[Token(Token = "0x4002EDA")]
		[FieldOffset(Offset = "0x160")]
		public UnityEvent onReloadStart;

		// Token: 0x04002EDB RID: 11995
		[Token(Token = "0x4002EDB")]
		[FieldOffset(Offset = "0x168")]
		public UnityEvent onReloadIndividual;

		// Token: 0x04002EDC RID: 11996
		[Token(Token = "0x4002EDC")]
		[FieldOffset(Offset = "0x170")]
		public UnityEvent onReloadEnd;

		// Token: 0x04002EDD RID: 11997
		[Token(Token = "0x4002EDD")]
		[FieldOffset(Offset = "0x178")]
		public UnityEvent onCockStart;

		// Token: 0x04002EDE RID: 11998
		[Token(Token = "0x4002EDE")]
		[FieldOffset(Offset = "0x180")]
		protected IntegerItemInstance weaponItem;

		// Token: 0x04002EDF RID: 11999
		[Token(Token = "0x4002EDF")]
		[FieldOffset(Offset = "0x188")]
		private bool aimStarted;

		// Token: 0x04002EE0 RID: 12000
		[Token(Token = "0x4002EE0")]
		[FieldOffset(Offset = "0x18C")]
		private float aimVelocity;

		// Token: 0x04002EE1 RID: 12001
		[Token(Token = "0x4002EE1")]
		[FieldOffset(Offset = "0x190")]
		private Coroutine reloadRoutine;

		// Token: 0x04002EE2 RID: 12002
		[Token(Token = "0x4002EE2")]
		[FieldOffset(Offset = "0x198")]
		private bool shotQueued;

		// Token: 0x04002EE3 RID: 12003
		[Token(Token = "0x4002EE3")]
		[FieldOffset(Offset = "0x199")]
		private bool reloadQueued;

		// Token: 0x04002EE4 RID: 12004
		[Token(Token = "0x4002EE4")]
		[FieldOffset(Offset = "0x19C")]
		private float timeSincePrimaryClick;

		// Token: 0x04002EE5 RID: 12005
		[Token(Token = "0x4002EE5")]
		[FieldOffset(Offset = "0x1A0")]
		private float timeSinceReloadStart;

		// Token: 0x04002EE6 RID: 12006
		[Token(Token = "0x4002EE6")]
		[FieldOffset(Offset = "0x1A4")]
		private float timeSinceAimStart;

		// Token: 0x04002EE7 RID: 12007
		[Token(Token = "0x4002EE7")]
		[FieldOffset(Offset = "0x1A8")]
		private bool interruptReload;

		// Token: 0x0200095B RID: 2395
		[Token(Token = "0x200095B")]
		public enum EReloadType
		{
			// Token: 0x04002EE9 RID: 12009
			[Token(Token = "0x4002EE9")]
			Magazine,
			// Token: 0x04002EEA RID: 12010
			[Token(Token = "0x4002EEA")]
			Incremental
		}
	}
}
