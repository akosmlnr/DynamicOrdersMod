using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000AE9 RID: 2793
	[Token(Token = "0x2000AE9")]
	public class FinishLabOvenBehaviour : Behaviour
	{
		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06005137 RID: 20791 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06005138 RID: 20792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C36")]
		public LabOven targetOven
		{
			[Token(Token = "0x6005137")]
			[Address(RVA = "0x5887E0", Offset = "0x5879E0", VA = "0x1805887E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005138")]
			[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005139 RID: 20793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005139")]
		[Address(RVA = "0x94EF90", Offset = "0x94E190", VA = "0x18094EF90", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x0600513A RID: 20794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600513A")]
		[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
		public void SetTargetOven(LabOven oven)
		{
		}

		// Token: 0x0600513B RID: 20795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600513B")]
		[Address(RVA = "0x94F2B0", Offset = "0x94E4B0", VA = "0x18094F2B0", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x0600513C RID: 20796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600513C")]
		[Address(RVA = "0x94F6E0", Offset = "0x94E8E0", VA = "0x18094F6E0", Slot = "28")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x0600513D RID: 20797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600513D")]
		[Address(RVA = "0x94F0A0", Offset = "0x94E2A0", VA = "0x18094F0A0", Slot = "26")]
		public override void BehaviourUpdate()
		{
		}

		// Token: 0x0600513E RID: 20798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600513E")]
		[Address(RVA = "0x94FC80", Offset = "0x94EE80", VA = "0x18094FC80")]
		[ObserversRpc(RunLocally = true)]
		private void StartAction()
		{
		}

		// Token: 0x0600513F RID: 20799 RVA: 0x00015378 File Offset: 0x00013578
		[Token(Token = "0x600513F")]
		[Address(RVA = "0x94F150", Offset = "0x94E350", VA = "0x18094F150")]
		private bool CanActionStart()
		{
			return default(bool);
		}

		// Token: 0x06005140 RID: 20800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005140")]
		[Address(RVA = "0x94FDA0", Offset = "0x94EFA0", VA = "0x18094FDA0")]
		private void StopAction()
		{
		}

		// Token: 0x06005141 RID: 20801 RVA: 0x00015390 File Offset: 0x00013590
		[Token(Token = "0x6005141")]
		[Address(RVA = "0x94F3A0", Offset = "0x94E5A0", VA = "0x18094F3A0")]
		private Vector3 GetStationAccessPoint()
		{
			return default(Vector3);
		}

		// Token: 0x06005142 RID: 20802 RVA: 0x000153A8 File Offset: 0x000135A8
		[Token(Token = "0x6005142")]
		[Address(RVA = "0x94F4A0", Offset = "0x94E6A0", VA = "0x18094F4A0")]
		private bool IsAtStation()
		{
			return default(bool);
		}

		// Token: 0x06005143 RID: 20803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005143")]
		[Address(RVA = "0x936AA0", Offset = "0x935CA0", VA = "0x180936AA0")]
		public FinishLabOvenBehaviour()
		{
		}

		// Token: 0x06005144 RID: 20804 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005144")]
		[Address(RVA = "0x94FE90", Offset = "0x94F090", VA = "0x18094FE90")]
		[CompilerGenerated]
		private IEnumerator <StartAction>g__ActionRoutine|12_0()
		{
			return null;
		}

		// Token: 0x06005145 RID: 20805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005145")]
		[Address(RVA = "0x94F650", Offset = "0x94E850", VA = "0x18094F650", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005146 RID: 20806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005146")]
		[Address(RVA = "0x948840", Offset = "0x947A40", VA = "0x180948840", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005147 RID: 20807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005147")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005148 RID: 20808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005148")]
		[Address(RVA = "0x94FB70", Offset = "0x94ED70", VA = "0x18094FB70")]
		private void RpcWriter___Observers_StartAction_2166136261()
		{
		}

		// Token: 0x06005149 RID: 20809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005149")]
		[Address(RVA = "0x94FA50", Offset = "0x94EC50", VA = "0x18094FA50")]
		private void RpcLogic___StartAction_2166136261()
		{
		}

		// Token: 0x0600514A RID: 20810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600514A")]
		[Address(RVA = "0x94FB30", Offset = "0x94ED30", VA = "0x18094FB30")]
		private void RpcReader___Observers_StartAction_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600514B RID: 20811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600514B")]
		[Address(RVA = "0x94EEA0", Offset = "0x94E0A0", VA = "0x18094EEA0", Slot = "35")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.FinishLabOvenBehaviour_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040037C2 RID: 14274
		[Token(Token = "0x40037C2")]
		public const float HARVEST_TIME = 10f;

		// Token: 0x040037C4 RID: 14276
		[Token(Token = "0x40037C4")]
		[FieldOffset(Offset = "0x170")]
		private Chemist chemist;

		// Token: 0x040037C5 RID: 14277
		[Token(Token = "0x40037C5")]
		[FieldOffset(Offset = "0x178")]
		private Coroutine actionRoutine;

		// Token: 0x040037C6 RID: 14278
		[Token(Token = "0x40037C6")]
		[FieldOffset(Offset = "0x180")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.FinishLabOvenBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x040037C7 RID: 14279
		[Token(Token = "0x40037C7")]
		[FieldOffset(Offset = "0x181")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.FinishLabOvenBehaviourAssembly-CSharp.dll_Excuted;
	}
}
