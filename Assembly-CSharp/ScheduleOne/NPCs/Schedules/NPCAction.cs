using System;
using System.Runtime.CompilerServices;
using FishNet.Object;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x02000B3D RID: 2877
	[Token(Token = "0x2000B3D")]
	[Serializable]
	public abstract class NPCAction : NetworkBehaviour
	{
		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x060055EE RID: 21998 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000C9A")]
		protected string ActionName
		{
			[Token(Token = "0x60055EE")]
			[Address(RVA = "0x979C80", Offset = "0x978E80", VA = "0x180979C80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x060055EF RID: 21999 RVA: 0x00016140 File Offset: 0x00014340
		[Token(Token = "0x17000C9B")]
		public bool IsEvent
		{
			[Token(Token = "0x60055EF")]
			[Address(RVA = "0x979D60", Offset = "0x978F60", VA = "0x180979D60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x060055F0 RID: 22000 RVA: 0x00016158 File Offset: 0x00014358
		[Token(Token = "0x17000C9C")]
		public bool IsSignal
		{
			[Token(Token = "0x60055F0")]
			[Address(RVA = "0x979DE0", Offset = "0x978FE0", VA = "0x180979DE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x060055F1 RID: 22001 RVA: 0x00016170 File Offset: 0x00014370
		[Token(Token = "0x17000C9D")]
		public bool IsActive
		{
			[Token(Token = "0x60055F1")]
			[Address(RVA = "0x979CB0", Offset = "0x978EB0", VA = "0x180979CB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x060055F2 RID: 22002 RVA: 0x00016188 File Offset: 0x00014388
		// (set) Token: 0x060055F3 RID: 22003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C9E")]
		public bool HasStarted
		{
			[Token(Token = "0x60055F2")]
			[Address(RVA = "0x51C070", Offset = "0x51B270", VA = "0x18051C070")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60055F3")]
			[Address(RVA = "0x61FCB0", Offset = "0x61EEB0", VA = "0x18061FCB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x060055F4 RID: 22004 RVA: 0x000161A0 File Offset: 0x000143A0
		[Token(Token = "0x17000C9F")]
		public virtual int Priority
		{
			[Token(Token = "0x60055F4")]
			[Address(RVA = "0x511A30", Offset = "0x510C30", VA = "0x180511A30", Slot = "19")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x060055F5 RID: 22005 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CA0")]
		protected NPCMovement movement
		{
			[Token(Token = "0x60055F5")]
			[Address(RVA = "0x979E60", Offset = "0x979060", VA = "0x180979E60")]
			get
			{
				return null;
			}
		}

		// Token: 0x060055F6 RID: 22006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055F6")]
		[Address(RVA = "0x9789D0", Offset = "0x977BD0", VA = "0x1809789D0", Slot = "20")]
		public virtual void Awake()
		{
		}

		// Token: 0x060055F7 RID: 22007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055F7")]
		[Address(RVA = "0x9791A0", Offset = "0x9783A0", VA = "0x1809791A0", Slot = "16")]
		protected override void OnValidate()
		{
		}

		// Token: 0x060055F8 RID: 22008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055F8")]
		[Address(RVA = "0x978B20", Offset = "0x977D20", VA = "0x180978B20")]
		private void GetReferences()
		{
		}

		// Token: 0x060055F9 RID: 22009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055F9")]
		[Address(RVA = "0x9798F0", Offset = "0x978AF0", VA = "0x1809798F0", Slot = "21")]
		protected virtual void Start()
		{
		}

		// Token: 0x060055FA RID: 22010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055FA")]
		[Address(RVA = "0x979010", Offset = "0x978210", VA = "0x180979010")]
		private void OnDestroy()
		{
		}

		// Token: 0x060055FB RID: 22011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055FB")]
		[Address(RVA = "0x979A90", Offset = "0x978C90", VA = "0x180979A90", Slot = "22")]
		public virtual void Started()
		{
		}

		// Token: 0x060055FC RID: 22012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055FC")]
		[Address(RVA = "0x978EA0", Offset = "0x9780A0", VA = "0x180978EA0", Slot = "23")]
		public virtual void LateStarted()
		{
		}

		// Token: 0x060055FD RID: 22013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055FD")]
		[Address(RVA = "0x978DB0", Offset = "0x977FB0", VA = "0x180978DB0", Slot = "24")]
		public virtual void JumpTo()
		{
		}

		// Token: 0x060055FE RID: 22014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055FE")]
		[Address(RVA = "0x978A20", Offset = "0x977C20", VA = "0x180978A20", Slot = "25")]
		public virtual void End()
		{
		}

		// Token: 0x060055FF RID: 22015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055FF")]
		[Address(RVA = "0x978C10", Offset = "0x977E10", VA = "0x180978C10", Slot = "26")]
		public virtual void Interrupt()
		{
		}

		// Token: 0x06005600 RID: 22016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005600")]
		[Address(RVA = "0x9793B0", Offset = "0x9785B0", VA = "0x1809793B0", Slot = "27")]
		public virtual void Resume()
		{
		}

		// Token: 0x06005601 RID: 22017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005601")]
		[Address(RVA = "0x979280", Offset = "0x978480", VA = "0x180979280", Slot = "28")]
		public virtual void ResumeFailed()
		{
		}

		// Token: 0x06005602 RID: 22018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005602")]
		[Address(RVA = "0x979830", Offset = "0x978A30", VA = "0x180979830", Slot = "29")]
		public virtual void Skipped()
		{
		}

		// Token: 0x06005603 RID: 22019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005603")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "30")]
		public virtual void ActiveUpdate()
		{
		}

		// Token: 0x06005604 RID: 22020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005604")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "31")]
		public virtual void OnActiveTick()
		{
		}

		// Token: 0x06005605 RID: 22021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005605")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "32")]
		public virtual void OnActiveMinPass()
		{
		}

		// Token: 0x06005606 RID: 22022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005606")]
		[Address(RVA = "0x9791C0", Offset = "0x9783C0", VA = "0x1809791C0", Slot = "33")]
		public virtual void PendingMinPassed()
		{
		}

		// Token: 0x06005607 RID: 22023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005607")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "34")]
		public virtual void MinPassed()
		{
		}

		// Token: 0x06005608 RID: 22024 RVA: 0x000161B8 File Offset: 0x000143B8
		[Token(Token = "0x6005608")]
		[Address(RVA = "0x979800", Offset = "0x978A00", VA = "0x180979800", Slot = "35")]
		public virtual bool ShouldStart()
		{
			return default(bool);
		}

		// Token: 0x06005609 RID: 22025
		[Token(Token = "0x6005609")]
		public abstract string GetName();

		// Token: 0x0600560A RID: 22026
		[Token(Token = "0x600560A")]
		public abstract string GetTimeDescription();

		// Token: 0x0600560B RID: 22027
		[Token(Token = "0x600560B")]
		public abstract int GetEndTime();

		// Token: 0x0600560C RID: 22028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600560C")]
		[Address(RVA = "0x9795D0", Offset = "0x9787D0", VA = "0x1809795D0")]
		protected void SetDestination(Vector3 position, bool teleportIfFail = true)
		{
		}

		// Token: 0x0600560D RID: 22029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600560D")]
		[Address(RVA = "0x979B80", Offset = "0x978D80", VA = "0x180979B80", Slot = "39")]
		protected virtual void WalkCallback(NPCMovement.WalkResult result)
		{
		}

		// Token: 0x0600560E RID: 22030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600560E")]
		[Address(RVA = "0x6783F0", Offset = "0x6775F0", VA = "0x1806783F0", Slot = "40")]
		public virtual void SetStartTime(int startTime)
		{
		}

		// Token: 0x0600560F RID: 22031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600560F")]
		[Address(RVA = "0x979540", Offset = "0x978740", VA = "0x180979540")]
		protected void SetCanUseUmbrella(bool canUse)
		{
		}

		// Token: 0x06005610 RID: 22032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005610")]
		[Address(RVA = "0x979130", Offset = "0x978330", VA = "0x180979130", Slot = "41")]
		protected virtual void OnStart()
		{
		}

		// Token: 0x06005611 RID: 22033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005611")]
		[Address(RVA = "0x979C70", Offset = "0x978E70", VA = "0x180979C70")]
		protected NPCAction()
		{
		}

		// Token: 0x06005612 RID: 22034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005612")]
		[Address(RVA = "0x978FF0", Offset = "0x9781F0", VA = "0x180978FF0", Slot = "42")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005613 RID: 22035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005613")]
		[Address(RVA = "0x978FD0", Offset = "0x9781D0", VA = "0x180978FD0", Slot = "43")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005614 RID: 22036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005614")]
		[Address(RVA = "0x978F90", Offset = "0x978190", VA = "0x180978F90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005615 RID: 22037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005615")]
		[Address(RVA = "0x9789C0", Offset = "0x977BC0", VA = "0x1809789C0", Slot = "44")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.Schedules.NPCAction_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040039B4 RID: 14772
		[Token(Token = "0x40039B4")]
		public const int MAX_CONSECUTIVE_PATHING_FAILURES = 5;

		// Token: 0x040039B6 RID: 14774
		[Token(Token = "0x40039B6")]
		[FieldOffset(Offset = "0x11C")]
		[SerializeField]
		protected int priority;

		// Token: 0x040039B7 RID: 14775
		[Token(Token = "0x40039B7")]
		[FieldOffset(Offset = "0x120")]
		[Header("Timing Settings")]
		public int StartTime;

		// Token: 0x040039B8 RID: 14776
		[Token(Token = "0x40039B8")]
		[FieldOffset(Offset = "0x124")]
		[Header("Umbrella Use")]
		[SerializeField]
		private bool _canUseUmbrella;

		// Token: 0x040039B9 RID: 14777
		[Token(Token = "0x40039B9")]
		[FieldOffset(Offset = "0x128")]
		protected NPC npc;

		// Token: 0x040039BA RID: 14778
		[Token(Token = "0x40039BA")]
		[FieldOffset(Offset = "0x130")]
		protected NPCScheduleManager schedule;

		// Token: 0x040039BB RID: 14779
		[Token(Token = "0x40039BB")]
		[FieldOffset(Offset = "0x138")]
		public Action onEnded;

		// Token: 0x040039BC RID: 14780
		[Token(Token = "0x40039BC")]
		[FieldOffset(Offset = "0x140")]
		protected int consecutivePathingFailures;

		// Token: 0x040039BD RID: 14781
		[Token(Token = "0x40039BD")]
		[FieldOffset(Offset = "0x144")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCActionAssembly-CSharp.dll_Excuted;

		// Token: 0x040039BE RID: 14782
		[Token(Token = "0x40039BE")]
		[FieldOffset(Offset = "0x145")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCActionAssembly-CSharp.dll_Excuted;
	}
}
