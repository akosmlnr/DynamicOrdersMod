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
	// Token: 0x02000AFF RID: 2815
	[Token(Token = "0x2000AFF")]
	public class StartCauldronBehaviour : Behaviour
	{
		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x06005248 RID: 21064 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06005249 RID: 21065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C54")]
		public Cauldron Station
		{
			[Token(Token = "0x6005248")]
			[Address(RVA = "0x5887E0", Offset = "0x5879E0", VA = "0x1805887E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005249")]
			[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x0600524A RID: 21066 RVA: 0x000158D0 File Offset: 0x00013AD0
		// (set) Token: 0x0600524B RID: 21067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C55")]
		public bool WorkInProgress
		{
			[Token(Token = "0x600524A")]
			[Address(RVA = "0x5887A0", Offset = "0x5879A0", VA = "0x1805887A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600524B")]
			[Address(RVA = "0x588850", Offset = "0x587A50", VA = "0x180588850")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600524C RID: 21068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600524C")]
		[Address(RVA = "0x957970", Offset = "0x956B70", VA = "0x180957970", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x0600524D RID: 21069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600524D")]
		[Address(RVA = "0x958480", Offset = "0x957680", VA = "0x180958480", Slot = "25")]
		public override void Resume()
		{
		}

		// Token: 0x0600524E RID: 21070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600524E")]
		[Address(RVA = "0x958370", Offset = "0x957570", VA = "0x180958370", Slot = "24")]
		public override void Pause()
		{
		}

		// Token: 0x0600524F RID: 21071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600524F")]
		[Address(RVA = "0x947550", Offset = "0x946750", VA = "0x180947550", Slot = "21")]
		public override void Disable()
		{
		}

		// Token: 0x06005250 RID: 21072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005250")]
		[Address(RVA = "0x957C50", Offset = "0x956E50", VA = "0x180957C50", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x06005251 RID: 21073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005251")]
		[Address(RVA = "0x9580B0", Offset = "0x9572B0", VA = "0x1809580B0", Slot = "28")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x06005252 RID: 21074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005252")]
		[Address(RVA = "0x958760", Offset = "0x957960", VA = "0x180958760")]
		private void StartWork()
		{
		}

		// Token: 0x06005253 RID: 21075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005253")]
		[Address(RVA = "0x957990", Offset = "0x956B90", VA = "0x180957990")]
		public void AssignStation(Cauldron station)
		{
		}

		// Token: 0x06005254 RID: 21076 RVA: 0x000158E8 File Offset: 0x00013AE8
		[Token(Token = "0x6005254")]
		[Address(RVA = "0x957DE0", Offset = "0x956FE0", VA = "0x180957DE0")]
		public bool IsAtStation()
		{
			return default(bool);
		}

		// Token: 0x06005255 RID: 21077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005255")]
		[Address(RVA = "0x957D60", Offset = "0x956F60", VA = "0x180957D60")]
		public void GoToStation()
		{
		}

		// Token: 0x06005256 RID: 21078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005256")]
		[Address(RVA = "0x957B30", Offset = "0x956D30", VA = "0x180957B30")]
		[ObserversRpc(RunLocally = true)]
		public void BeginCauldron()
		{
		}

		// Token: 0x06005257 RID: 21079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005257")]
		[Address(RVA = "0x958860", Offset = "0x957A60", VA = "0x180958860")]
		private void StopCauldron()
		{
		}

		// Token: 0x06005258 RID: 21080 RVA: 0x00015900 File Offset: 0x00013B00
		[Token(Token = "0x6005258")]
		[Address(RVA = "0x957E70", Offset = "0x957070", VA = "0x180957E70")]
		public bool IsStationReady(Cauldron station)
		{
			return default(bool);
		}

		// Token: 0x06005259 RID: 21081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005259")]
		[Address(RVA = "0x936AA0", Offset = "0x935CA0", VA = "0x180936AA0")]
		public StartCauldronBehaviour()
		{
		}

		// Token: 0x0600525A RID: 21082 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600525A")]
		[Address(RVA = "0x958970", Offset = "0x957B70", VA = "0x180958970")]
		[CompilerGenerated]
		private IEnumerator <BeginCauldron>g__Package|20_0()
		{
			return null;
		}

		// Token: 0x0600525B RID: 21083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600525B")]
		[Address(RVA = "0x958020", Offset = "0x957220", VA = "0x180958020", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600525C RID: 21084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600525C")]
		[Address(RVA = "0x948840", Offset = "0x947A40", VA = "0x180948840", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600525D RID: 21085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600525D")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600525E RID: 21086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600525E")]
		[Address(RVA = "0x958650", Offset = "0x957850", VA = "0x180958650")]
		private void RpcWriter___Observers_BeginCauldron_2166136261()
		{
		}

		// Token: 0x0600525F RID: 21087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600525F")]
		[Address(RVA = "0x9584A0", Offset = "0x9576A0", VA = "0x1809584A0")]
		public void RpcLogic___BeginCauldron_2166136261()
		{
		}

		// Token: 0x06005260 RID: 21088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005260")]
		[Address(RVA = "0x958610", Offset = "0x957810", VA = "0x180958610")]
		private void RpcReader___Observers_BeginCauldron_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005261 RID: 21089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005261")]
		[Address(RVA = "0x935FD0", Offset = "0x9351D0", VA = "0x180935FD0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x04003825 RID: 14373
		[Token(Token = "0x4003825")]
		public const float START_CAULDRON_TIME = 15f;

		// Token: 0x04003828 RID: 14376
		[Token(Token = "0x4003828")]
		[FieldOffset(Offset = "0x178")]
		private Coroutine workRoutine;

		// Token: 0x04003829 RID: 14377
		[Token(Token = "0x4003829")]
		[FieldOffset(Offset = "0x180")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StartCauldronBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x0400382A RID: 14378
		[Token(Token = "0x400382A")]
		[FieldOffset(Offset = "0x181")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StartCauldronBehaviourAssembly-CSharp.dll_Excuted;
	}
}
