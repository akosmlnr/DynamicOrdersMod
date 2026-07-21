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
	// Token: 0x02000B09 RID: 2825
	[Token(Token = "0x2000B09")]
	public class StopDryingRackBehaviour : Behaviour
	{
		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x060052DC RID: 21212 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060052DD RID: 21213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C65")]
		public DryingRack Rack
		{
			[Token(Token = "0x60052DC")]
			[Address(RVA = "0x5887E0", Offset = "0x5879E0", VA = "0x1805887E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60052DD")]
			[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x060052DE RID: 21214 RVA: 0x00015AB0 File Offset: 0x00013CB0
		// (set) Token: 0x060052DF RID: 21215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C66")]
		public bool WorkInProgress
		{
			[Token(Token = "0x60052DE")]
			[Address(RVA = "0x5887A0", Offset = "0x5879A0", VA = "0x1805887A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60052DF")]
			[Address(RVA = "0x588850", Offset = "0x587A50", VA = "0x180588850")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060052E0 RID: 21216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052E0")]
		[Address(RVA = "0x973620", Offset = "0x972820", VA = "0x180973620", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x060052E1 RID: 21217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052E1")]
		[Address(RVA = "0x974290", Offset = "0x973490", VA = "0x180974290", Slot = "25")]
		public override void Resume()
		{
		}

		// Token: 0x060052E2 RID: 21218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052E2")]
		[Address(RVA = "0x948BB0", Offset = "0x947DB0", VA = "0x180948BB0", Slot = "24")]
		public override void Pause()
		{
		}

		// Token: 0x060052E3 RID: 21219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052E3")]
		[Address(RVA = "0x947550", Offset = "0x946750", VA = "0x180947550", Slot = "21")]
		public override void Disable()
		{
		}

		// Token: 0x060052E4 RID: 21220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052E4")]
		[Address(RVA = "0x973900", Offset = "0x972B00", VA = "0x180973900", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x060052E5 RID: 21221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052E5")]
		[Address(RVA = "0x973F50", Offset = "0x973150", VA = "0x180973F50", Slot = "28")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x060052E6 RID: 21222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052E6")]
		[Address(RVA = "0x974570", Offset = "0x973770", VA = "0x180974570")]
		private void StartWork()
		{
		}

		// Token: 0x060052E7 RID: 21223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052E7")]
		[Address(RVA = "0x973640", Offset = "0x972840", VA = "0x180973640")]
		public void AssignRack(DryingRack rack)
		{
		}

		// Token: 0x060052E8 RID: 21224 RVA: 0x00015AC8 File Offset: 0x00013CC8
		[Token(Token = "0x60052E8")]
		[Address(RVA = "0x973AF0", Offset = "0x972CF0", VA = "0x180973AF0")]
		public bool IsAtStation()
		{
			return default(bool);
		}

		// Token: 0x060052E9 RID: 21225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052E9")]
		[Address(RVA = "0x973A20", Offset = "0x972C20", VA = "0x180973A20")]
		public void GoToStation()
		{
		}

		// Token: 0x060052EA RID: 21226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052EA")]
		[Address(RVA = "0x9737E0", Offset = "0x9729E0", VA = "0x1809737E0")]
		[ObserversRpc(RunLocally = true)]
		public void BeginAction()
		{
		}

		// Token: 0x060052EB RID: 21227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052EB")]
		[Address(RVA = "0x948FE0", Offset = "0x9481E0", VA = "0x180948FE0")]
		private void StopCauldron()
		{
		}

		// Token: 0x060052EC RID: 21228 RVA: 0x00015AE0 File Offset: 0x00013CE0
		[Token(Token = "0x60052EC")]
		[Address(RVA = "0x973BD0", Offset = "0x972DD0", VA = "0x180973BD0")]
		public bool IsRackReady(DryingRack rack)
		{
			return default(bool);
		}

		// Token: 0x060052ED RID: 21229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052ED")]
		[Address(RVA = "0x936AA0", Offset = "0x935CA0", VA = "0x180936AA0")]
		public StopDryingRackBehaviour()
		{
		}

		// Token: 0x060052EE RID: 21230 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60052EE")]
		[Address(RVA = "0x9746C0", Offset = "0x9738C0", VA = "0x1809746C0")]
		[CompilerGenerated]
		private IEnumerator <BeginAction>g__Package|20_0()
		{
			return null;
		}

		// Token: 0x060052F0 RID: 21232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052F0")]
		[Address(RVA = "0x973EC0", Offset = "0x9730C0", VA = "0x180973EC0", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060052F1 RID: 21233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052F1")]
		[Address(RVA = "0x948840", Offset = "0x947A40", VA = "0x180948840", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060052F2 RID: 21234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052F2")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060052F3 RID: 21235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052F3")]
		[Address(RVA = "0x974460", Offset = "0x973660", VA = "0x180974460")]
		private void RpcWriter___Observers_BeginAction_2166136261()
		{
		}

		// Token: 0x060052F4 RID: 21236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052F4")]
		[Address(RVA = "0x9742B0", Offset = "0x9734B0", VA = "0x1809742B0")]
		public void RpcLogic___BeginAction_2166136261()
		{
		}

		// Token: 0x060052F5 RID: 21237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052F5")]
		[Address(RVA = "0x974420", Offset = "0x973620", VA = "0x180974420")]
		private void RpcReader___Observers_BeginAction_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060052F6 RID: 21238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052F6")]
		[Address(RVA = "0x935FD0", Offset = "0x9351D0", VA = "0x180935FD0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x0400385E RID: 14430
		[Token(Token = "0x400385E")]
		public const float TIME_PER_ITEM = 1f;

		// Token: 0x04003861 RID: 14433
		[Token(Token = "0x4003861")]
		[FieldOffset(Offset = "0x178")]
		private Coroutine workRoutine;

		// Token: 0x04003862 RID: 14434
		[Token(Token = "0x4003862")]
		[FieldOffset(Offset = "0x180")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StopDryingRackBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x04003863 RID: 14435
		[Token(Token = "0x4003863")]
		[FieldOffset(Offset = "0x181")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StopDryingRackBehaviourAssembly-CSharp.dll_Excuted;
	}
}
