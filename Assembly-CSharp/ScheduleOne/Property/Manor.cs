using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Core;
using ScheduleOne.Persistence.Datas;
using UnityEngine;

namespace ScheduleOne.Property
{
	// Token: 0x0200035E RID: 862
	[Token(Token = "0x200035E")]
	public class Manor : Property
	{
		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001522 RID: 5410 RVA: 0x00009108 File Offset: 0x00007308
		// (set) Token: 0x06001523 RID: 5411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000429")]
		public Manor.EManorState ManorState
		{
			[Token(Token = "0x6001522")]
			[Address(RVA = "0x59CEC0", Offset = "0x59C0C0", VA = "0x18059CEC0")]
			[CompilerGenerated]
			get
			{
				return Manor.EManorState.Original;
			}
			[Token(Token = "0x6001523")]
			[Address(RVA = "0x59CEF0", Offset = "0x59C0F0", VA = "0x18059CEF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06001524 RID: 5412 RVA: 0x00009120 File Offset: 0x00007320
		// (set) Token: 0x06001525 RID: 5413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700042A")]
		public int DaysSinceStateChange
		{
			[Token(Token = "0x6001524")]
			[Address(RVA = "0x59CEB0", Offset = "0x59C0B0", VA = "0x18059CEB0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001525")]
			[Address(RVA = "0x59CEE0", Offset = "0x59C0E0", VA = "0x18059CEE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06001526 RID: 5414 RVA: 0x00009138 File Offset: 0x00007338
		// (set) Token: 0x06001527 RID: 5415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700042B")]
		public bool TunnelDug
		{
			[Token(Token = "0x6001526")]
			[Address(RVA = "0x59CED0", Offset = "0x59C0D0", VA = "0x18059CED0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001527")]
			[Address(RVA = "0x59CF00", Offset = "0x59C100", VA = "0x18059CF00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001528")]
		[Address(RVA = "0x59B1E0", Offset = "0x59A3E0", VA = "0x18059B1E0", Slot = "42")]
		public override void Awake()
		{
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001529")]
		[Address(RVA = "0x59BCB0", Offset = "0x59AEB0", VA = "0x18059BCB0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600152A")]
		[Address(RVA = "0x59CCF0", Offset = "0x59BEF0", VA = "0x18059CCF0", Slot = "44")]
		protected override void Start()
		{
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600152B")]
		[Address(RVA = "0x59BD70", Offset = "0x59AF70", VA = "0x18059BD70", Slot = "48")]
		protected override void RecieveOwned()
		{
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600152C")]
		[Address(RVA = "0x59C7E0", Offset = "0x59B9E0", VA = "0x18059C7E0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetManorState(NetworkConnection conn, Manor.EManorState state, bool resetStateChangeTimer)
		{
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600152D")]
		[Address(RVA = "0x59B2E0", Offset = "0x59A4E0", VA = "0x18059B2E0")]
		[Button]
		public void Explode()
		{
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600152E")]
		[Address(RVA = "0x59BD20", Offset = "0x59AF20", VA = "0x18059BD20")]
		[Button]
		public void Rebuild()
		{
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600152F")]
		[Address(RVA = "0x59C7B0", Offset = "0x59B9B0", VA = "0x18059C7B0")]
		public void SetDestroyedIfOriginal()
		{
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001530")]
		[Address(RVA = "0x59B2D0", Offset = "0x59A4D0", VA = "0x18059B2D0")]
		public void DigTunnel()
		{
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001531")]
		[Address(RVA = "0x59CA80", Offset = "0x59BC80", VA = "0x18059CA80")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void SetTunnelDug(NetworkConnection conn, bool dug)
		{
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00009150 File Offset: 0x00007350
		[Token(Token = "0x6001532")]
		[Address(RVA = "0x59B2C0", Offset = "0x59A4C0", VA = "0x18059B2C0", Slot = "50")]
		public override bool CanBePurchased()
		{
			return default(bool);
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001533")]
		[Address(RVA = "0x59BBD0", Offset = "0x59ADD0", VA = "0x18059BBD0")]
		private void OnSleepEnd()
		{
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x00009168 File Offset: 0x00007368
		[Token(Token = "0x6001534")]
		[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "49")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001535")]
		[Address(RVA = "0x59B570", Offset = "0x59A770", VA = "0x18059B570", Slot = "52")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001536")]
		[Address(RVA = "0x59B920", Offset = "0x59AB20", VA = "0x18059B920", Slot = "55")]
		public override void Load(PropertyData propertyData, string dataString)
		{
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001537")]
		[Address(RVA = "0x59CE50", Offset = "0x59C050", VA = "0x18059CE50")]
		public Manor()
		{
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001538")]
		[Address(RVA = "0x59BA70", Offset = "0x59AC70", VA = "0x18059BA70", Slot = "58")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001539")]
		[Address(RVA = "0x59BA40", Offset = "0x59AC40", VA = "0x18059BA40", Slot = "59")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600153A")]
		[Address(RVA = "0x595D90", Offset = "0x594F90", VA = "0x180595D90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600153B")]
		[Address(RVA = "0x59C240", Offset = "0x59B440", VA = "0x18059C240")]
		private void RpcWriter___Observers_SetManorState_365422978(NetworkConnection conn, Manor.EManorState state, bool resetStateChangeTimer)
		{
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600153C")]
		[Address(RVA = "0x59BDC0", Offset = "0x59AFC0", VA = "0x18059BDC0")]
		private void RpcLogic___SetManorState_365422978(NetworkConnection conn, Manor.EManorState state, bool resetStateChangeTimer)
		{
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600153D")]
		[Address(RVA = "0x59BFE0", Offset = "0x59B1E0", VA = "0x18059BFE0")]
		private void RpcReader___Observers_SetManorState_365422978(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600153E")]
		[Address(RVA = "0x59C4F0", Offset = "0x59B6F0", VA = "0x18059C4F0")]
		private void RpcWriter___Target_SetManorState_365422978(NetworkConnection conn, Manor.EManorState state, bool resetStateChangeTimer)
		{
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600153F")]
		[Address(RVA = "0x59C110", Offset = "0x59B310", VA = "0x18059C110")]
		private void RpcReader___Target_SetManorState_365422978(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001540")]
		[Address(RVA = "0x59C3B0", Offset = "0x59B5B0", VA = "0x18059C3B0")]
		private void RpcWriter___Observers_SetTunnelDug_214505783(NetworkConnection conn, bool dug)
		{
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001541")]
		[Address(RVA = "0x59BFA0", Offset = "0x59B1A0", VA = "0x18059BFA0")]
		public void RpcLogic___SetTunnelDug_214505783(NetworkConnection conn, bool dug)
		{
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001542")]
		[Address(RVA = "0x59C080", Offset = "0x59B280", VA = "0x18059C080")]
		private void RpcReader___Observers_SetTunnelDug_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001543")]
		[Address(RVA = "0x59C650", Offset = "0x59B850", VA = "0x18059C650")]
		private void RpcWriter___Target_SetTunnelDug_214505783(NetworkConnection conn, bool dug)
		{
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001544")]
		[Address(RVA = "0x59C1B0", Offset = "0x59B3B0", VA = "0x18059C1B0")]
		private void RpcReader___Target_SetTunnelDug_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001545")]
		[Address(RVA = "0x59B120", Offset = "0x59A320", VA = "0x18059B120", Slot = "61")]
		protected virtual void Awake_UserLogic_ScheduleOne.Property.Manor_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040012F2 RID: 4850
		[Token(Token = "0x40012F2")]
		public const int REBUILD_AFTER_DAYS = 2;

		// Token: 0x040012F3 RID: 4851
		[Token(Token = "0x40012F3")]
		public const int REBUILD_DURATION_DAYS = 3;

		// Token: 0x040012F7 RID: 4855
		[Token(Token = "0x40012F7")]
		[FieldOffset(Offset = "0x260")]
		[Header("References")]
		public GameObject OriginalContainer;

		// Token: 0x040012F8 RID: 4856
		[Token(Token = "0x40012F8")]
		[FieldOffset(Offset = "0x268")]
		public GameObject DestroyedContainer;

		// Token: 0x040012F9 RID: 4857
		[Token(Token = "0x40012F9")]
		[FieldOffset(Offset = "0x270")]
		public GameObject RebuiltContainer;

		// Token: 0x040012FA RID: 4858
		[Token(Token = "0x40012FA")]
		[FieldOffset(Offset = "0x278")]
		public GameObject DestructionFXContainer;

		// Token: 0x040012FB RID: 4859
		[Token(Token = "0x40012FB")]
		[FieldOffset(Offset = "0x280")]
		public GameObject TunnelBlocker;

		// Token: 0x040012FC RID: 4860
		[Token(Token = "0x40012FC")]
		[FieldOffset(Offset = "0x288")]
		public GameObject TunnelCollapse;

		// Token: 0x040012FD RID: 4861
		[Token(Token = "0x40012FD")]
		[FieldOffset(Offset = "0x290")]
		public GameObject ConstructionContainer;

		// Token: 0x040012FE RID: 4862
		[Token(Token = "0x40012FE")]
		[FieldOffset(Offset = "0x298")]
		public AudioSourceController[] ExplosionSounds;

		// Token: 0x040012FF RID: 4863
		[Token(Token = "0x40012FF")]
		[FieldOffset(Offset = "0x2A0")]
		public GameObject[] DisableOnRebuild;

		// Token: 0x04001300 RID: 4864
		[Token(Token = "0x4001300")]
		[FieldOffset(Offset = "0x2A8")]
		public Action onRebuildComplete;

		// Token: 0x04001301 RID: 4865
		[Token(Token = "0x4001301")]
		[FieldOffset(Offset = "0x2B0")]
		private bool NetworkInitialize___EarlyScheduleOne.Property.ManorAssembly-CSharp.dll_Excuted;

		// Token: 0x04001302 RID: 4866
		[Token(Token = "0x4001302")]
		[FieldOffset(Offset = "0x2B1")]
		private bool NetworkInitialize__LateScheduleOne.Property.ManorAssembly-CSharp.dll_Excuted;

		// Token: 0x0200035F RID: 863
		[Token(Token = "0x200035F")]
		public enum EManorState
		{
			// Token: 0x04001304 RID: 4868
			[Token(Token = "0x4001304")]
			Original,
			// Token: 0x04001305 RID: 4869
			[Token(Token = "0x4001305")]
			Destroyed,
			// Token: 0x04001306 RID: 4870
			[Token(Token = "0x4001306")]
			Rebuilt
		}
	}
}
