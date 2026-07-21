using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000B03 RID: 2819
	[Token(Token = "0x2000B03")]
	public class StartDryingRackBehaviour : Behaviour
	{
		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x06005285 RID: 21125 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06005286 RID: 21126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C5B")]
		public DryingRack Rack
		{
			[Token(Token = "0x6005285")]
			[Address(RVA = "0x5887E0", Offset = "0x5879E0", VA = "0x1805887E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005286")]
			[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x06005287 RID: 21127 RVA: 0x00015990 File Offset: 0x00013B90
		// (set) Token: 0x06005288 RID: 21128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C5C")]
		public bool WorkInProgress
		{
			[Token(Token = "0x6005287")]
			[Address(RVA = "0x5887A0", Offset = "0x5879A0", VA = "0x1805887A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005288")]
			[Address(RVA = "0x588850", Offset = "0x587A50", VA = "0x180588850")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005289 RID: 21129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005289")]
		[Address(RVA = "0x9704E0", Offset = "0x96F6E0", VA = "0x1809704E0", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x0600528A RID: 21130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600528A")]
		[Address(RVA = "0x971180", Offset = "0x970380", VA = "0x180971180", Slot = "25")]
		public override void Resume()
		{
		}

		// Token: 0x0600528B RID: 21131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600528B")]
		[Address(RVA = "0x971060", Offset = "0x970260", VA = "0x180971060", Slot = "24")]
		public override void Pause()
		{
		}

		// Token: 0x0600528C RID: 21132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600528C")]
		[Address(RVA = "0x947550", Offset = "0x946750", VA = "0x180947550", Slot = "21")]
		public override void Disable()
		{
		}

		// Token: 0x0600528D RID: 21133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600528D")]
		[Address(RVA = "0x970750", Offset = "0x96F950", VA = "0x180970750", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x0600528E RID: 21134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600528E")]
		[Address(RVA = "0x970D20", Offset = "0x96FF20", VA = "0x180970D20", Slot = "28")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x0600528F RID: 21135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600528F")]
		[Address(RVA = "0x971460", Offset = "0x970660", VA = "0x180971460")]
		private void StartWork()
		{
		}

		// Token: 0x06005290 RID: 21136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005290")]
		[Address(RVA = "0x970500", Offset = "0x96F700", VA = "0x180970500")]
		public void AssignRack(DryingRack rack)
		{
		}

		// Token: 0x06005291 RID: 21137 RVA: 0x000159A8 File Offset: 0x00013BA8
		[Token(Token = "0x6005291")]
		[Address(RVA = "0x970940", Offset = "0x96FB40", VA = "0x180970940")]
		public bool IsAtStation()
		{
			return default(bool);
		}

		// Token: 0x06005292 RID: 21138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005292")]
		[Address(RVA = "0x970870", Offset = "0x96FA70", VA = "0x180970870")]
		public void GoToStation()
		{
		}

		// Token: 0x06005293 RID: 21139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005293")]
		[Address(RVA = "0x970630", Offset = "0x96F830", VA = "0x180970630")]
		[ObserversRpc(RunLocally = true)]
		public void BeginAction()
		{
		}

		// Token: 0x06005294 RID: 21140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005294")]
		[Address(RVA = "0x948FE0", Offset = "0x9481E0", VA = "0x180948FE0")]
		private void StopCauldron()
		{
		}

		// Token: 0x06005295 RID: 21141 RVA: 0x000159C0 File Offset: 0x00013BC0
		[Token(Token = "0x6005295")]
		[Address(RVA = "0x970A20", Offset = "0x96FC20", VA = "0x180970A20")]
		public bool IsRackReady(DryingRack rack)
		{
			return default(bool);
		}

		// Token: 0x06005296 RID: 21142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005296")]
		[Address(RVA = "0x936AA0", Offset = "0x935CA0", VA = "0x180936AA0")]
		public StartDryingRackBehaviour()
		{
		}

		// Token: 0x06005297 RID: 21143 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005297")]
		[Address(RVA = "0x971560", Offset = "0x970760", VA = "0x180971560")]
		[CompilerGenerated]
		private IEnumerator <BeginAction>g__Package|20_0()
		{
			return null;
		}

		// Token: 0x06005298 RID: 21144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005298")]
		[Address(RVA = "0x970C90", Offset = "0x96FE90", VA = "0x180970C90", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005299 RID: 21145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005299")]
		[Address(RVA = "0x948840", Offset = "0x947A40", VA = "0x180948840", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600529A RID: 21146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600529A")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600529B RID: 21147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600529B")]
		[Address(RVA = "0x971350", Offset = "0x970550", VA = "0x180971350")]
		private void RpcWriter___Observers_BeginAction_2166136261()
		{
		}

		// Token: 0x0600529C RID: 21148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600529C")]
		[Address(RVA = "0x9711A0", Offset = "0x9703A0", VA = "0x1809711A0")]
		public void RpcLogic___BeginAction_2166136261()
		{
		}

		// Token: 0x0600529D RID: 21149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600529D")]
		[Address(RVA = "0x971310", Offset = "0x970510", VA = "0x180971310")]
		private void RpcReader___Observers_BeginAction_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600529E RID: 21150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600529E")]
		[Address(RVA = "0x935FD0", Offset = "0x9351D0", VA = "0x180935FD0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x0400383E RID: 14398
		[Token(Token = "0x400383E")]
		public const float TIME_PER_ITEM = 1f;

		// Token: 0x04003841 RID: 14401
		[Token(Token = "0x4003841")]
		[FieldOffset(Offset = "0x178")]
		private Coroutine workRoutine;

		// Token: 0x04003842 RID: 14402
		[Token(Token = "0x4003842")]
		[FieldOffset(Offset = "0x180")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StartDryingRackBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x04003843 RID: 14403
		[Token(Token = "0x4003843")]
		[FieldOffset(Offset = "0x181")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StartDryingRackBehaviourAssembly-CSharp.dll_Excuted;
	}
}
