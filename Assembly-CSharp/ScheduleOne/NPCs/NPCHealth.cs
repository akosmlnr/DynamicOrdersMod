using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs
{
	// Token: 0x02000A4C RID: 2636
	[Token(Token = "0x2000A4C")]
	[DisallowMultipleComponent]
	public class NPCHealth : NetworkBehaviour
	{
		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06004BA7 RID: 19367 RVA: 0x000145E0 File Offset: 0x000127E0
		// (set) Token: 0x06004BA8 RID: 19368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BC2")]
		public float Health
		{
			[Token(Token = "0x6004BA7")]
			[Address(RVA = "0x5C0FA0", Offset = "0x5C01A0", VA = "0x1805C0FA0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004BA8")]
			[Address(RVA = "0x91ADC0", Offset = "0x919FC0", VA = "0x18091ADC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x06004BA9 RID: 19369 RVA: 0x000145F8 File Offset: 0x000127F8
		[Token(Token = "0x17000BC3")]
		public float NormalizedHealth
		{
			[Token(Token = "0x6004BA9")]
			[Address(RVA = "0x91ADA0", Offset = "0x919FA0", VA = "0x18091ADA0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06004BAA RID: 19370 RVA: 0x00014610 File Offset: 0x00012810
		// (set) Token: 0x06004BAB RID: 19371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BC4")]
		public bool IsDead
		{
			[Token(Token = "0x6004BAA")]
			[Address(RVA = "0x5219C0", Offset = "0x520BC0", VA = "0x1805219C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004BAB")]
			[Address(RVA = "0x8C6A90", Offset = "0x8C5C90", VA = "0x1808C6A90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x06004BAC RID: 19372 RVA: 0x00014628 File Offset: 0x00012828
		// (set) Token: 0x06004BAD RID: 19373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BC5")]
		public bool IsKnockedOut
		{
			[Token(Token = "0x6004BAC")]
			[Address(RVA = "0x521A80", Offset = "0x520C80", VA = "0x180521A80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004BAD")]
			[Address(RVA = "0x91AE50", Offset = "0x91A050", VA = "0x18091AE50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06004BAE RID: 19374 RVA: 0x00014640 File Offset: 0x00012840
		// (set) Token: 0x06004BAF RID: 19375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BC6")]
		public int DaysPassedSinceDeath
		{
			[Token(Token = "0x6004BAE")]
			[Address(RVA = "0x5219D0", Offset = "0x520BD0", VA = "0x1805219D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004BAF")]
			[Address(RVA = "0x6783F0", Offset = "0x6775F0", VA = "0x1806783F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06004BB0 RID: 19376 RVA: 0x00014658 File Offset: 0x00012858
		// (set) Token: 0x06004BB1 RID: 19377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BC7")]
		public int HoursSinceAttackedByPlayer
		{
			[Token(Token = "0x6004BB0")]
			[Address(RVA = "0x5D6EC0", Offset = "0x5D60C0", VA = "0x1805D6EC0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004BB1")]
			[Address(RVA = "0x5D6EE0", Offset = "0x5D60E0", VA = "0x1805D6EE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004BB2 RID: 19378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BB2")]
		[Address(RVA = "0x919FB0", Offset = "0x9191B0", VA = "0x180919FB0", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x06004BB3 RID: 19379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BB3")]
		[Address(RVA = "0x91AA00", Offset = "0x919C00", VA = "0x18091AA00")]
		private void Start()
		{
		}

		// Token: 0x06004BB4 RID: 19380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BB4")]
		[Address(RVA = "0x91A4A0", Offset = "0x9196A0", VA = "0x18091A4A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004BB5 RID: 19381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BB5")]
		[Address(RVA = "0x91A610", Offset = "0x919810", VA = "0x18091A610", Slot = "6")]
		public override void OnStartServer()
		{
		}

		// Token: 0x06004BB6 RID: 19382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BB6")]
		[Address(RVA = "0x91A230", Offset = "0x919430", VA = "0x18091A230")]
		public void Load(NPCHealthData healthData)
		{
		}

		// Token: 0x06004BB7 RID: 19383 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004BB7")]
		[Address(RVA = "0x919BD0", Offset = "0x918DD0", VA = "0x180919BD0")]
		private IEnumerator AfflictWithLethalEffect()
		{
			return null;
		}

		// Token: 0x06004BB8 RID: 19384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BB8")]
		[Address(RVA = "0x79A6B0", Offset = "0x7998B0", VA = "0x18079A6B0", Slot = "20")]
		protected virtual void OnHourPass()
		{
		}

		// Token: 0x06004BB9 RID: 19385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BB9")]
		[Address(RVA = "0x91A8C0", Offset = "0x919AC0", VA = "0x18091A8C0")]
		public void SetAfflictedWithLethalEffect(bool value)
		{
		}

		// Token: 0x06004BBA RID: 19386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BBA")]
		[Address(RVA = "0x91A940", Offset = "0x919B40", VA = "0x18091A940")]
		public void SleepStart()
		{
		}

		// Token: 0x06004BBB RID: 19387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BBB")]
		[Address(RVA = "0x91A490", Offset = "0x919690", VA = "0x18091A490", Slot = "21")]
		public virtual void NotifyAttackedByPlayer(Player player)
		{
		}

		// Token: 0x06004BBC RID: 19388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BBC")]
		[Address(RVA = "0x91AC50", Offset = "0x919E50", VA = "0x18091AC50")]
		public void TakeDamage(float damage, bool isLethal = true)
		{
		}

		// Token: 0x06004BBD RID: 19389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BBD")]
		[Address(RVA = "0x91A000", Offset = "0x919200", VA = "0x18091A000", Slot = "22")]
		public virtual void Die()
		{
		}

		// Token: 0x06004BBE RID: 19390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BBE")]
		[Address(RVA = "0x91A120", Offset = "0x919320", VA = "0x18091A120", Slot = "23")]
		public virtual void KnockOut()
		{
		}

		// Token: 0x06004BBF RID: 19391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BBF")]
		[Address(RVA = "0x91A790", Offset = "0x919990", VA = "0x18091A790", Slot = "24")]
		public virtual void Revive()
		{
		}

		// Token: 0x06004BC0 RID: 19392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC0")]
		[Address(RVA = "0x91A780", Offset = "0x919980", VA = "0x18091A780")]
		public void RestoreHealth()
		{
		}

		// Token: 0x06004BC1 RID: 19393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC1")]
		[Address(RVA = "0x91AD70", Offset = "0x919F70", VA = "0x18091AD70")]
		public NPCHealth()
		{
		}

		// Token: 0x06004BC2 RID: 19394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC2")]
		[Address(RVA = "0x91A330", Offset = "0x919530", VA = "0x18091A330", Slot = "25")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004BC3 RID: 19395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC3")]
		[Address(RVA = "0x91A2E0", Offset = "0x9194E0", VA = "0x18091A2E0", Slot = "26")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004BC4 RID: 19396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC4")]
		[Address(RVA = "0x6E33D0", Offset = "0x6E25D0", VA = "0x1806E33D0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06004BC5 RID: 19397 RVA: 0x00014670 File Offset: 0x00012870
		// (set) Token: 0x06004BC6 RID: 19398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BC8")]
		public float SyncAccessor_<Health>k__BackingField
		{
			[Token(Token = "0x6004BC5")]
			[Address(RVA = "0x5C0FA0", Offset = "0x5C01A0", VA = "0x1805C0FA0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004BC6")]
			[Address(RVA = "0x91AE60", Offset = "0x91A060", VA = "0x18091AE60")]
			set
			{
			}
		}

		// Token: 0x06004BC7 RID: 19399 RVA: 0x00014688 File Offset: 0x00012888
		[Token(Token = "0x6004BC7")]
		[Address(RVA = "0x91A640", Offset = "0x919840", VA = "0x18091A640", Slot = "27")]
		public virtual bool ReadSyncVar___ScheduleOne.NPCs.NPCHealth(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x06004BC8 RID: 19400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC8")]
		[Address(RVA = "0x919C40", Offset = "0x918E40", VA = "0x180919C40", Slot = "28")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.NPCHealth_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003521 RID: 13601
		[Token(Token = "0x4003521")]
		public const int REVIVE_DAYS = 3;

		// Token: 0x04003527 RID: 13607
		[Token(Token = "0x4003527")]
		[FieldOffset(Offset = "0x128")]
		[Header("Settings")]
		public bool Invincible;

		// Token: 0x04003528 RID: 13608
		[Token(Token = "0x4003528")]
		[FieldOffset(Offset = "0x12C")]
		public float MaxHealth;

		// Token: 0x04003529 RID: 13609
		[Token(Token = "0x4003529")]
		[FieldOffset(Offset = "0x130")]
		public bool CanRevive;

		// Token: 0x0400352A RID: 13610
		[Token(Token = "0x400352A")]
		[FieldOffset(Offset = "0x138")]
		private NPC npc;

		// Token: 0x0400352B RID: 13611
		[Token(Token = "0x400352B")]
		[FieldOffset(Offset = "0x140")]
		public UnityEvent onDie;

		// Token: 0x0400352C RID: 13612
		[Token(Token = "0x400352C")]
		[FieldOffset(Offset = "0x148")]
		public UnityEvent onKnockedOut;

		// Token: 0x0400352D RID: 13613
		[Token(Token = "0x400352D")]
		[FieldOffset(Offset = "0x150")]
		public UnityEvent onDieOrKnockedOut;

		// Token: 0x0400352E RID: 13614
		[Token(Token = "0x400352E")]
		[FieldOffset(Offset = "0x158")]
		public UnityEvent onRevive;

		// Token: 0x0400352F RID: 13615
		[Token(Token = "0x400352F")]
		[FieldOffset(Offset = "0x160")]
		public Action<float> onTakeDamage;

		// Token: 0x04003530 RID: 13616
		[Token(Token = "0x4003530")]
		[FieldOffset(Offset = "0x168")]
		private bool AfflictedWithLethalEffect;

		// Token: 0x04003531 RID: 13617
		[Token(Token = "0x4003531")]
		[FieldOffset(Offset = "0x170")]
		public SyncVar<float> syncVar___<Health>k__BackingField;

		// Token: 0x04003532 RID: 13618
		[Token(Token = "0x4003532")]
		[FieldOffset(Offset = "0x178")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.NPCHealthAssembly-CSharp.dll_Excuted;

		// Token: 0x04003533 RID: 13619
		[Token(Token = "0x4003533")]
		[FieldOffset(Offset = "0x179")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.NPCHealthAssembly-CSharp.dll_Excuted;
	}
}
