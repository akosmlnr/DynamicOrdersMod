using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.StationFramework;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000B0B RID: 2827
	[Token(Token = "0x2000B0B")]
	public class UseSpawnStationBehaviour : Behaviour
	{
		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x060052FD RID: 21245 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060052FE RID: 21246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C69")]
		public MushroomSpawnStation Station
		{
			[Token(Token = "0x60052FD")]
			[Address(RVA = "0x5887E0", Offset = "0x5879E0", VA = "0x1805887E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60052FE")]
			[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060052FF RID: 21247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052FF")]
		[Address(RVA = "0x9772E0", Offset = "0x9764E0", VA = "0x1809772E0")]
		public void AssignStation(MushroomSpawnStation station)
		{
		}

		// Token: 0x06005300 RID: 21248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005300")]
		[Address(RVA = "0x94CB50", Offset = "0x94BD50", VA = "0x18094CB50", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x06005301 RID: 21249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005301")]
		[Address(RVA = "0x977510", Offset = "0x976710", VA = "0x180977510", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x06005302 RID: 21250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005302")]
		[Address(RVA = "0x94D750", Offset = "0x94C950", VA = "0x18094D750", Slot = "25")]
		public override void Resume()
		{
		}

		// Token: 0x06005303 RID: 21251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005303")]
		[Address(RVA = "0x977C00", Offset = "0x976E00", VA = "0x180977C00", Slot = "24")]
		public override void Pause()
		{
		}

		// Token: 0x06005304 RID: 21252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005304")]
		[Address(RVA = "0x9778C0", Offset = "0x976AC0", VA = "0x1809778C0", Slot = "28")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x06005305 RID: 21253 RVA: 0x00015B28 File Offset: 0x00013D28
		[Token(Token = "0x6005305")]
		[Address(RVA = "0x977630", Offset = "0x976830", VA = "0x180977630")]
		public bool IsAtStation()
		{
			return default(bool);
		}

		// Token: 0x06005306 RID: 21254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005306")]
		[Address(RVA = "0x977560", Offset = "0x976760", VA = "0x180977560")]
		public void GoToStation()
		{
		}

		// Token: 0x06005307 RID: 21255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005307")]
		[Address(RVA = "0x9773F0", Offset = "0x9765F0", VA = "0x1809773F0")]
		[ObserversRpc(RunLocally = true)]
		public void BeginWork()
		{
		}

		// Token: 0x06005308 RID: 21256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005308")]
		[Address(RVA = "0x977E30", Offset = "0x977030", VA = "0x180977E30")]
		private void StopWork()
		{
		}

		// Token: 0x06005309 RID: 21257 RVA: 0x00015B40 File Offset: 0x00013D40
		[Token(Token = "0x6005309")]
		[Address(RVA = "0x977710", Offset = "0x976910", VA = "0x180977710")]
		public bool IsStationReady(MushroomSpawnStation station)
		{
			return default(bool);
		}

		// Token: 0x0600530A RID: 21258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600530A")]
		[Address(RVA = "0x936AA0", Offset = "0x935CA0", VA = "0x180936AA0")]
		public UseSpawnStationBehaviour()
		{
		}

		// Token: 0x0600530B RID: 21259 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600530B")]
		[Address(RVA = "0x977F70", Offset = "0x977170", VA = "0x180977F70")]
		[CompilerGenerated]
		private IEnumerator <BeginWork>g__Package|17_0()
		{
			return null;
		}

		// Token: 0x0600530C RID: 21260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600530C")]
		[Address(RVA = "0x977830", Offset = "0x976A30", VA = "0x180977830", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600530D RID: 21261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600530D")]
		[Address(RVA = "0x948840", Offset = "0x947A40", VA = "0x180948840", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600530E RID: 21262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600530E")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600530F RID: 21263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600530F")]
		[Address(RVA = "0x977D20", Offset = "0x976F20", VA = "0x180977D20")]
		private void RpcWriter___Observers_BeginWork_2166136261()
		{
		}

		// Token: 0x06005310 RID: 21264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005310")]
		[Address(RVA = "0x977C30", Offset = "0x976E30", VA = "0x180977C30")]
		public void RpcLogic___BeginWork_2166136261()
		{
		}

		// Token: 0x06005311 RID: 21265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005311")]
		[Address(RVA = "0x977CE0", Offset = "0x976EE0", VA = "0x180977CE0")]
		private void RpcReader___Observers_BeginWork_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005312 RID: 21266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005312")]
		[Address(RVA = "0x935FD0", Offset = "0x9351D0", VA = "0x180935FD0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x04003867 RID: 14439
		[Token(Token = "0x4003867")]
		private const float TaskDuration = 6f;

		// Token: 0x04003868 RID: 14440
		[Token(Token = "0x4003868")]
		private const float ProximityThreshold = 0.6f;

		// Token: 0x04003869 RID: 14441
		[Token(Token = "0x4003869")]
		private const string AnimationBoolName = "UsePackagingStation";

		// Token: 0x0400386B RID: 14443
		[Token(Token = "0x400386B")]
		[FieldOffset(Offset = "0x170")]
		private bool _currentlyUsingStation;

		// Token: 0x0400386C RID: 14444
		[Token(Token = "0x400386C")]
		[FieldOffset(Offset = "0x178")]
		private Coroutine _workRoutine;

		// Token: 0x0400386D RID: 14445
		[Token(Token = "0x400386D")]
		[FieldOffset(Offset = "0x180")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.UseSpawnStationBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x0400386E RID: 14446
		[Token(Token = "0x400386E")]
		[FieldOffset(Offset = "0x181")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.UseSpawnStationBehaviourAssembly-CSharp.dll_Excuted;
	}
}
