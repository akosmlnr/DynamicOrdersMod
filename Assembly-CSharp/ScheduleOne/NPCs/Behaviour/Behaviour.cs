using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using Il2CppDummyDll;
using ScheduleOne.Management;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000ACF RID: 2767
	[Token(Token = "0x2000ACF")]
	public class Behaviour : NetworkBehaviour
	{
		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x06004F88 RID: 20360 RVA: 0x00014F58 File Offset: 0x00013158
		// (set) Token: 0x06004F89 RID: 20361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C09")]
		public bool Enabled
		{
			[Token(Token = "0x6004F88")]
			[Address(RVA = "0x9321C0", Offset = "0x9313C0", VA = "0x1809321C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004F89")]
			[Address(RVA = "0x932220", Offset = "0x931420", VA = "0x180932220")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x06004F8A RID: 20362 RVA: 0x00014F70 File Offset: 0x00013170
		// (set) Token: 0x06004F8B RID: 20363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C0A")]
		public bool Started
		{
			[Token(Token = "0x6004F8A")]
			[Address(RVA = "0x932200", Offset = "0x931400", VA = "0x180932200")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004F8B")]
			[Address(RVA = "0x932230", Offset = "0x931430", VA = "0x180932230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06004F8C RID: 20364 RVA: 0x00014F88 File Offset: 0x00013188
		// (set) Token: 0x06004F8D RID: 20365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C0B")]
		public bool Active
		{
			[Token(Token = "0x6004F8C")]
			[Address(RVA = "0x9321B0", Offset = "0x9313B0", VA = "0x1809321B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004F8D")]
			[Address(RVA = "0x932210", Offset = "0x931410", VA = "0x180932210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06004F8E RID: 20366 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004F8F RID: 20367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C0C")]
		public NPCBehaviour beh
		{
			[Token(Token = "0x6004F8E")]
			[Address(RVA = "0x57F810", Offset = "0x57EA10", VA = "0x18057F810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F8F")]
			[Address(RVA = "0x57F850", Offset = "0x57EA50", VA = "0x18057F850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06004F90 RID: 20368 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000C0D")]
		public NPC Npc
		{
			[Token(Token = "0x6004F90")]
			[Address(RVA = "0x9321D0", Offset = "0x9313D0", VA = "0x1809321D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004F91 RID: 20369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F91")]
		[Address(RVA = "0x931310", Offset = "0x930510", VA = "0x180931310", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x06004F92 RID: 20370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F92")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0", Slot = "16")]
		protected override void OnValidate()
		{
		}

		// Token: 0x06004F93 RID: 20371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F93")]
		[Address(RVA = "0x9317A0", Offset = "0x9309A0", VA = "0x1809317A0", Slot = "20")]
		public virtual void Enable()
		{
		}

		// Token: 0x06004F94 RID: 20372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F94")]
		[Address(RVA = "0x931770", Offset = "0x930970", VA = "0x180931770")]
		public void Enable_Server()
		{
		}

		// Token: 0x06004F95 RID: 20373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F95")]
		[Address(RVA = "0x931710", Offset = "0x930910", VA = "0x180931710")]
		public void Enable_Networked()
		{
		}

		// Token: 0x06004F96 RID: 20374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F96")]
		[Address(RVA = "0x931600", Offset = "0x930800", VA = "0x180931600", Slot = "21")]
		public virtual void Disable()
		{
		}

		// Token: 0x06004F97 RID: 20375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F97")]
		[Address(RVA = "0x9315D0", Offset = "0x9307D0", VA = "0x1809315D0")]
		public void Disable_Server()
		{
		}

		// Token: 0x06004F98 RID: 20376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F98")]
		[Address(RVA = "0x931570", Offset = "0x930770", VA = "0x180931570")]
		public void Disable_Networked(NetworkConnection conn)
		{
		}

		// Token: 0x06004F99 RID: 20377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F99")]
		[Address(RVA = "0x931150", Offset = "0x930350", VA = "0x180931150")]
		public void Activate_Server(NetworkConnection conn)
		{
		}

		// Token: 0x06004F9A RID: 20378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F9A")]
		[Address(RVA = "0x931180", Offset = "0x930380", VA = "0x180931180", Slot = "22")]
		public virtual void Activate()
		{
		}

		// Token: 0x06004F9B RID: 20379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F9B")]
		[Address(RVA = "0x931400", Offset = "0x930600", VA = "0x180931400")]
		public void Deactivate_Server()
		{
		}

		// Token: 0x06004F9C RID: 20380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F9C")]
		[Address(RVA = "0x9313A0", Offset = "0x9305A0", VA = "0x1809313A0")]
		public void Deactivate_Networked(NetworkConnection conn)
		{
		}

		// Token: 0x06004F9D RID: 20381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F9D")]
		[Address(RVA = "0x931430", Offset = "0x930630", VA = "0x180931430", Slot = "23")]
		public virtual void Deactivate()
		{
		}

		// Token: 0x06004F9E RID: 20382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F9E")]
		[Address(RVA = "0x931900", Offset = "0x930B00", VA = "0x180931900")]
		public void Pause_Server()
		{
		}

		// Token: 0x06004F9F RID: 20383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F9F")]
		[Address(RVA = "0x931930", Offset = "0x930B30", VA = "0x180931930", Slot = "24")]
		public virtual void Pause()
		{
		}

		// Token: 0x06004FA0 RID: 20384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FA0")]
		[Address(RVA = "0x931A50", Offset = "0x930C50", VA = "0x180931A50")]
		public void Resume_Server()
		{
		}

		// Token: 0x06004FA1 RID: 20385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FA1")]
		[Address(RVA = "0x931A80", Offset = "0x930C80", VA = "0x180931A80", Slot = "25")]
		public virtual void Resume()
		{
		}

		// Token: 0x06004FA2 RID: 20386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FA2")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "26")]
		public virtual void BehaviourUpdate()
		{
		}

		// Token: 0x06004FA3 RID: 20387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FA3")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "27")]
		public virtual void BehaviourLateUpdate()
		{
		}

		// Token: 0x06004FA4 RID: 20388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FA4")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "28")]
		public virtual void OnActiveTick()
		{
		}

		// Token: 0x06004FA5 RID: 20389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FA5")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "29")]
		public virtual void OnActiveUncappedMinutePass()
		{
		}

		// Token: 0x06004FA6 RID: 20390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FA6")]
		[Address(RVA = "0x931BE0", Offset = "0x930DE0", VA = "0x180931BE0")]
		protected void SetDestination(ITransitEntity transitEntity, bool teleportIfFail = true)
		{
		}

		// Token: 0x06004FA7 RID: 20391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FA7")]
		[Address(RVA = "0x931CD0", Offset = "0x930ED0", VA = "0x180931CD0", Slot = "30")]
		protected virtual void SetDestination(Vector3 position, bool teleportIfFail = true, float successThreshold = 1f)
		{
		}

		// Token: 0x06004FA8 RID: 20392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FA8")]
		[Address(RVA = "0x931FE0", Offset = "0x9311E0", VA = "0x180931FE0", Slot = "31")]
		protected virtual void WalkCallback(NPCMovement.WalkResult result)
		{
		}

		// Token: 0x06004FA9 RID: 20393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FA9")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void UpdateGameObjectName()
		{
		}

		// Token: 0x06004FAA RID: 20394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FAA")]
		[Address(RVA = "0x931B90", Offset = "0x930D90", VA = "0x180931B90")]
		public void SetCanUseUmbrellaDuringBehaviour(bool canUse)
		{
		}

		// Token: 0x06004FAB RID: 20395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FAB")]
		[Address(RVA = "0x9320D0", Offset = "0x9312D0", VA = "0x1809320D0")]
		public Behaviour()
		{
		}

		// Token: 0x06004FAC RID: 20396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FAC")]
		[Address(RVA = "0x9318E0", Offset = "0x930AE0", VA = "0x1809318E0", Slot = "32")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004FAD RID: 20397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FAD")]
		[Address(RVA = "0x9318C0", Offset = "0x930AC0", VA = "0x1809318C0", Slot = "33")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004FAE RID: 20398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FAE")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004FAF RID: 20399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FAF")]
		[Address(RVA = "0x9312B0", Offset = "0x9304B0", VA = "0x1809312B0", Slot = "34")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.Behaviour_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003728 RID: 14120
		[Token(Token = "0x4003728")]
		public const int MAX_CONSECUTIVE_PATHING_FAILURES = 5;

		// Token: 0x04003729 RID: 14121
		[Token(Token = "0x4003729")]
		[FieldOffset(Offset = "0x118")]
		public bool EnabledOnAwake;

		// Token: 0x0400372B RID: 14123
		[Token(Token = "0x400372B")]
		[FieldOffset(Offset = "0x120")]
		[Header("Settings")]
		public string Name;

		// Token: 0x0400372C RID: 14124
		[Token(Token = "0x400372C")]
		[FieldOffset(Offset = "0x128")]
		[Tooltip("Behaviour priority; higher = takes priority over lower number behaviour")]
		public int Priority;

		// Token: 0x0400372D RID: 14125
		[Token(Token = "0x400372D")]
		[FieldOffset(Offset = "0x12C")]
		[SerializeField]
		[Header("Umbrella")]
		private bool _canUseUmbrellaDuringBehaviour;

		// Token: 0x04003730 RID: 14128
		[Token(Token = "0x4003730")]
		[FieldOffset(Offset = "0x130")]
		[HideInInspector]
		public int BehaviourIndex;

		// Token: 0x04003732 RID: 14130
		[Token(Token = "0x4003732")]
		[FieldOffset(Offset = "0x140")]
		public UnityEvent onEnable;

		// Token: 0x04003733 RID: 14131
		[Token(Token = "0x4003733")]
		[FieldOffset(Offset = "0x148")]
		public UnityEvent onDisable;

		// Token: 0x04003734 RID: 14132
		[Token(Token = "0x4003734")]
		[FieldOffset(Offset = "0x150")]
		public UnityEvent onBegin;

		// Token: 0x04003735 RID: 14133
		[Token(Token = "0x4003735")]
		[FieldOffset(Offset = "0x158")]
		public UnityEvent onEnd;

		// Token: 0x04003736 RID: 14134
		[Token(Token = "0x4003736")]
		[FieldOffset(Offset = "0x160")]
		protected int consecutivePathingFailures;

		// Token: 0x04003737 RID: 14135
		[Token(Token = "0x4003737")]
		[FieldOffset(Offset = "0x164")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.BehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x04003738 RID: 14136
		[Token(Token = "0x4003738")]
		[FieldOffset(Offset = "0x165")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.BehaviourAssembly-CSharp.dll_Excuted;
	}
}
