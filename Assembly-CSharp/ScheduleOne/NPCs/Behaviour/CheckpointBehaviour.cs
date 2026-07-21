using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Dialogue;
using ScheduleOne.Law;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Police;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000AD2 RID: 2770
	[Token(Token = "0x2000AD2")]
	public class CheckpointBehaviour : Behaviour
	{
		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x06004FE4 RID: 20452 RVA: 0x00015018 File Offset: 0x00013218
		// (set) Token: 0x06004FE5 RID: 20453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C11")]
		public CheckpointManager.ECheckpointLocation AssignedCheckpoint
		{
			[Token(Token = "0x6004FE4")]
			[Address(RVA = "0x57F830", Offset = "0x57EA30", VA = "0x18057F830")]
			[CompilerGenerated]
			get
			{
				return CheckpointManager.ECheckpointLocation.Western;
			}
			[Token(Token = "0x6004FE5")]
			[Address(RVA = "0x57F8A0", Offset = "0x57EAA0", VA = "0x18057F8A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06004FE6 RID: 20454 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004FE7 RID: 20455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C12")]
		public RoadCheckpoint Checkpoint
		{
			[Token(Token = "0x6004FE6")]
			[Address(RVA = "0x628900", Offset = "0x627B00", VA = "0x180628900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FE7")]
			[Address(RVA = "0x628A30", Offset = "0x627C30", VA = "0x180628A30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06004FE8 RID: 20456 RVA: 0x00015030 File Offset: 0x00013230
		// (set) Token: 0x06004FE9 RID: 20457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C13")]
		public bool IsSearching
		{
			[Token(Token = "0x6004FE8")]
			[Address(RVA = "0x6288D0", Offset = "0x627AD0", VA = "0x1806288D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004FE9")]
			[Address(RVA = "0x628A10", Offset = "0x627C10", VA = "0x180628A10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06004FEA RID: 20458 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004FEB RID: 20459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C14")]
		public LandVehicle CurrentSearchedVehicle
		{
			[Token(Token = "0x6004FEA")]
			[Address(RVA = "0x630320", Offset = "0x62F520", VA = "0x180630320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FEB")]
			[Address(RVA = "0x6303E0", Offset = "0x62F5E0", VA = "0x1806303E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06004FEC RID: 20460 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004FED RID: 20461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C15")]
		public Player Initiator
		{
			[Token(Token = "0x6004FEC")]
			[Address(RVA = "0x71D4E0", Offset = "0x71C6E0", VA = "0x18071D4E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FED")]
			[Address(RVA = "0x82A9F0", Offset = "0x829BF0", VA = "0x18082A9F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06004FEE RID: 20462 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000C16")]
		private Transform standPoint
		{
			[Token(Token = "0x6004FEE")]
			[Address(RVA = "0x93A270", Offset = "0x939470", VA = "0x18093A270")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x06004FEF RID: 20463 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000C17")]
		private DialogueDatabase dialogueDatabase
		{
			[Token(Token = "0x6004FEF")]
			[Address(RVA = "0x93A230", Offset = "0x939430", VA = "0x18093A230")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004FF0 RID: 20464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FF0")]
		[Address(RVA = "0x936AB0", Offset = "0x935CB0", VA = "0x180936AB0", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x06004FF1 RID: 20465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FF1")]
		[Address(RVA = "0x938650", Offset = "0x937850", VA = "0x180938650", Slot = "25")]
		public override void Resume()
		{
		}

		// Token: 0x06004FF2 RID: 20466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FF2")]
		[Address(RVA = "0x936DA0", Offset = "0x935FA0", VA = "0x180936DA0", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x06004FF3 RID: 20467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FF3")]
		[Address(RVA = "0x937EE0", Offset = "0x9370E0", VA = "0x180937EE0", Slot = "24")]
		public override void Pause()
		{
		}

		// Token: 0x06004FF4 RID: 20468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FF4")]
		[Address(RVA = "0x9376D0", Offset = "0x9368D0", VA = "0x1809376D0", Slot = "28")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x06004FF5 RID: 20469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FF5")]
		[Address(RVA = "0x939BF0", Offset = "0x938DF0", VA = "0x180939BF0")]
		[ObserversRpc(RunLocally = true)]
		public void SetCheckpoint(CheckpointManager.ECheckpointLocation loc)
		{
		}

		// Token: 0x06004FF6 RID: 20470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FF6")]
		[Address(RVA = "0x939D20", Offset = "0x938F20", VA = "0x180939D20")]
		[ObserversRpc(RunLocally = true)]
		public void SetInitiator(NetworkObject init)
		{
		}

		// Token: 0x06004FF7 RID: 20471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FF7")]
		[Address(RVA = "0x939FD0", Offset = "0x9391D0", VA = "0x180939FD0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void StartSearch(NetworkObject targetVehicle, NetworkObject initiator)
		{
		}

		// Token: 0x06004FF8 RID: 20472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FF8")]
		[Address(RVA = "0x93A120", Offset = "0x939320", VA = "0x18093A120")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void StopSearch()
		{
		}

		// Token: 0x06004FF9 RID: 20473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FF9")]
		[Address(RVA = "0x939E90", Offset = "0x939090", VA = "0x180939E90")]
		[ObserversRpc(RunLocally = true)]
		public void SetIsSearching(bool s)
		{
		}

		// Token: 0x06004FFA RID: 20474 RVA: 0x00015048 File Offset: 0x00013248
		[Token(Token = "0x6004FFA")]
		[Address(RVA = "0x937370", Offset = "0x936570", VA = "0x180937370")]
		private Vector3 GetSearchPoint()
		{
			return default(Vector3);
		}

		// Token: 0x06004FFB RID: 20475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FFB")]
		[Address(RVA = "0x936C80", Offset = "0x935E80", VA = "0x180936C80")]
		[ObserversRpc(RunLocally = true)]
		private void ConcludeSearch()
		{
		}

		// Token: 0x06004FFC RID: 20476 RVA: 0x00015060 File Offset: 0x00013260
		[Token(Token = "0x6004FFC")]
		[Address(RVA = "0x936F70", Offset = "0x936170", VA = "0x180936F70")]
		private bool DoesVehicleContainIllicitItems()
		{
			return default(bool);
		}

		// Token: 0x06004FFD RID: 20477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FFD")]
		[Address(RVA = "0x938000", Offset = "0x937200", VA = "0x180938000")]
		private void PlayerWalkedThroughCheckPoint(Player player)
		{
		}

		// Token: 0x06004FFE RID: 20478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FFE")]
		[Address(RVA = "0x936AA0", Offset = "0x935CA0", VA = "0x180936AA0")]
		public CheckpointBehaviour()
		{
		}

		// Token: 0x06004FFF RID: 20479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FFF")]
		[Address(RVA = "0x9374D0", Offset = "0x9366D0", VA = "0x1809374D0", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005000 RID: 20480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005000")]
		[Address(RVA = "0x9374A0", Offset = "0x9366A0", VA = "0x1809374A0", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005001 RID: 20481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005001")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005002 RID: 20482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005002")]
		[Address(RVA = "0x9395C0", Offset = "0x9387C0", VA = "0x1809395C0")]
		private void RpcWriter___Observers_SetCheckpoint_4087078542(CheckpointManager.ECheckpointLocation loc)
		{
		}

		// Token: 0x06005003 RID: 20483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005003")]
		[Address(RVA = "0x57F8A0", Offset = "0x57EAA0", VA = "0x18057F8A0")]
		public void RpcLogic___SetCheckpoint_4087078542(CheckpointManager.ECheckpointLocation loc)
		{
		}

		// Token: 0x06005004 RID: 20484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005004")]
		[Address(RVA = "0x939220", Offset = "0x938420", VA = "0x180939220")]
		private void RpcReader___Observers_SetCheckpoint_4087078542(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005005 RID: 20485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005005")]
		[Address(RVA = "0x939700", Offset = "0x938900", VA = "0x180939700")]
		private void RpcWriter___Observers_SetInitiator_3323014238(NetworkObject init)
		{
		}

		// Token: 0x06005006 RID: 20486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005006")]
		[Address(RVA = "0x938D00", Offset = "0x937F00", VA = "0x180938D00")]
		public void RpcLogic___SetInitiator_3323014238(NetworkObject init)
		{
		}

		// Token: 0x06005007 RID: 20487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005007")]
		[Address(RVA = "0x939270", Offset = "0x938470", VA = "0x180939270")]
		private void RpcReader___Observers_SetInitiator_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005008 RID: 20488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005008")]
		[Address(RVA = "0x939980", Offset = "0x938B80", VA = "0x180939980")]
		private void RpcWriter___Server_StartSearch_3694055493(NetworkObject targetVehicle, NetworkObject initiator)
		{
		}

		// Token: 0x06005009 RID: 20489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005009")]
		[Address(RVA = "0x938E20", Offset = "0x938020", VA = "0x180938E20")]
		public void RpcLogic___StartSearch_3694055493(NetworkObject targetVehicle, NetworkObject initiator)
		{
		}

		// Token: 0x0600500A RID: 20490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600500A")]
		[Address(RVA = "0x9393A0", Offset = "0x9385A0", VA = "0x1809393A0")]
		private void RpcReader___Server_StartSearch_3694055493(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600500B RID: 20491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600500B")]
		[Address(RVA = "0x939AE0", Offset = "0x938CE0", VA = "0x180939AE0")]
		private void RpcWriter___Server_StopSearch_2166136261()
		{
		}

		// Token: 0x0600500C RID: 20492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600500C")]
		[Address(RVA = "0x9390B0", Offset = "0x9382B0", VA = "0x1809390B0")]
		public void RpcLogic___StopSearch_2166136261()
		{
		}

		// Token: 0x0600500D RID: 20493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600500D")]
		[Address(RVA = "0x939450", Offset = "0x938650", VA = "0x180939450")]
		private void RpcReader___Server_StopSearch_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600500E RID: 20494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600500E")]
		[Address(RVA = "0x939840", Offset = "0x938A40", VA = "0x180939840")]
		private void RpcWriter___Observers_SetIsSearching_1140765316(bool s)
		{
		}

		// Token: 0x0600500F RID: 20495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600500F")]
		[Address(RVA = "0x938D70", Offset = "0x937F70", VA = "0x180938D70")]
		public void RpcLogic___SetIsSearching_1140765316(bool s)
		{
		}

		// Token: 0x06005010 RID: 20496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005010")]
		[Address(RVA = "0x939320", Offset = "0x938520", VA = "0x180939320")]
		private void RpcReader___Observers_SetIsSearching_1140765316(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005011 RID: 20497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005011")]
		[Address(RVA = "0x9394A0", Offset = "0x9386A0", VA = "0x1809394A0")]
		private void RpcWriter___Observers_ConcludeSearch_2166136261()
		{
		}

		// Token: 0x06005012 RID: 20498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005012")]
		[Address(RVA = "0x938820", Offset = "0x937A20", VA = "0x180938820")]
		private void RpcLogic___ConcludeSearch_2166136261()
		{
		}

		// Token: 0x06005013 RID: 20499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005013")]
		[Address(RVA = "0x9391E0", Offset = "0x9383E0", VA = "0x1809391E0")]
		private void RpcReader___Observers_ConcludeSearch_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005014 RID: 20500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005014")]
		[Address(RVA = "0x935FD0", Offset = "0x9351D0", VA = "0x180935FD0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x04003759 RID: 14169
		[Token(Token = "0x4003759")]
		public const float LOOK_TIME = 1.5f;

		// Token: 0x0400375F RID: 14175
		[Token(Token = "0x400375F")]
		[FieldOffset(Offset = "0x190")]
		private float currentLookTime;

		// Token: 0x04003760 RID: 14176
		[Token(Token = "0x4003760")]
		[FieldOffset(Offset = "0x194")]
		private bool trunkOpened;

		// Token: 0x04003761 RID: 14177
		[Token(Token = "0x4003761")]
		[FieldOffset(Offset = "0x195")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.CheckpointBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x04003762 RID: 14178
		[Token(Token = "0x4003762")]
		[FieldOffset(Offset = "0x196")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.CheckpointBehaviourAssembly-CSharp.dll_Excuted;
	}
}
