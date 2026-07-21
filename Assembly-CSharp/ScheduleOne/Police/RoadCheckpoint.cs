using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Misc;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product.Packaging;
using ScheduleOne.Vehicles;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Police
{
	// Token: 0x02000786 RID: 1926
	[Token(Token = "0x2000786")]
	public class RoadCheckpoint : NetworkBehaviour
	{
		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x0600332C RID: 13100 RVA: 0x0000F8E8 File Offset: 0x0000DAE8
		// (set) Token: 0x0600332D RID: 13101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000834")]
		public RoadCheckpoint.ECheckpointState ActivationState
		{
			[Token(Token = "0x600332C")]
			[Address(RVA = "0x5219B0", Offset = "0x520BB0", VA = "0x1805219B0")]
			[CompilerGenerated]
			get
			{
				return RoadCheckpoint.ECheckpointState.Disabled;
			}
			[Token(Token = "0x600332D")]
			[Address(RVA = "0x77EBC0", Offset = "0x77DDC0", VA = "0x18077EBC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x0600332E RID: 13102 RVA: 0x0000F900 File Offset: 0x0000DB00
		// (set) Token: 0x0600332F RID: 13103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000835")]
		public bool Gate1Open
		{
			[Token(Token = "0x600332E")]
			[Address(RVA = "0x511850", Offset = "0x510A50", VA = "0x180511850")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600332F")]
			[Address(RVA = "0x77E300", Offset = "0x77D500", VA = "0x18077E300")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06003330 RID: 13104 RVA: 0x0000F918 File Offset: 0x0000DB18
		// (set) Token: 0x06003331 RID: 13105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000836")]
		public bool Gate2Open
		{
			[Token(Token = "0x6003330")]
			[Address(RVA = "0x621930", Offset = "0x620B30", VA = "0x180621930")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003331")]
			[Address(RVA = "0x77E390", Offset = "0x77D590", VA = "0x18077E390")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003332 RID: 13106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003332")]
		[Address(RVA = "0x77D210", Offset = "0x77C410", VA = "0x18077D210", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003333")]
		[Address(RVA = "0x77E660", Offset = "0x77D860", VA = "0x18077E660", Slot = "20")]
		protected virtual void Update()
		{
		}

		// Token: 0x06003334 RID: 13108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003334")]
		[Address(RVA = "0x77CF70", Offset = "0x77C170", VA = "0x18077CF70", Slot = "21")]
		protected virtual void ApplyState()
		{
		}

		// Token: 0x06003335 RID: 13109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003335")]
		[Address(RVA = "0x77D380", Offset = "0x77C580", VA = "0x18077D380")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void Enable(NetworkConnection conn)
		{
		}

		// Token: 0x06003336 RID: 13110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003336")]
		[Address(RVA = "0x77D260", Offset = "0x77C460", VA = "0x18077D260")]
		[ObserversRpc(RunLocally = true)]
		public void Disable()
		{
		}

		// Token: 0x06003337 RID: 13111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003337")]
		[Address(RVA = "0x77E300", Offset = "0x77D500", VA = "0x18077E300")]
		public void SetGate1Open(bool o)
		{
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003338")]
		[Address(RVA = "0x77E390", Offset = "0x77D590", VA = "0x18077E390")]
		public void SetGate2Open(bool o)
		{
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003339")]
		[Address(RVA = "0x77DB30", Offset = "0x77CD30", VA = "0x18077DB30")]
		private void ResetTrafficCones()
		{
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600333A")]
		[Address(RVA = "0x77D920", Offset = "0x77CB20", VA = "0x18077D920")]
		public void PlayerDetected(Player player)
		{
		}

		// Token: 0x0600333B RID: 13115 RVA: 0x0000F930 File Offset: 0x0000DB30
		[Token(Token = "0x600333B")]
		[Address(RVA = "0x77E420", Offset = "0x77D620", VA = "0x18077E420")]
		private bool TryGetNearestAssignedNPC(out NPC npc, out float distance)
		{
			return default(bool);
		}

		// Token: 0x0600333C RID: 13116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600333C")]
		[Address(RVA = "0x77EAF0", Offset = "0x77DCF0", VA = "0x18077EAF0")]
		public RoadCheckpoint()
		{
		}

		// Token: 0x0600333D RID: 13117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600333D")]
		[Address(RVA = "0x77D650", Offset = "0x77C850", VA = "0x18077D650", Slot = "22")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600333E RID: 13118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600333E")]
		[Address(RVA = "0x77D5E0", Offset = "0x77C7E0", VA = "0x18077D5E0", Slot = "23")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600333F RID: 13119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600333F")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003340 RID: 13120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003340")]
		[Address(RVA = "0x77E0C0", Offset = "0x77D2C0", VA = "0x18077E0C0")]
		private void RpcWriter___Observers_Enable_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06003341 RID: 13121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003341")]
		[Address(RVA = "0x77DEC0", Offset = "0x77D0C0", VA = "0x18077DEC0")]
		public void RpcLogic___Enable_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06003342 RID: 13122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003342")]
		[Address(RVA = "0x77DF20", Offset = "0x77D120", VA = "0x18077DF20")]
		private void RpcReader___Observers_Enable_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003343 RID: 13123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003343")]
		[Address(RVA = "0x77E1D0", Offset = "0x77D3D0", VA = "0x18077E1D0")]
		private void RpcWriter___Target_Enable_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06003344 RID: 13124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003344")]
		[Address(RVA = "0x77DF60", Offset = "0x77D160", VA = "0x18077DF60")]
		private void RpcReader___Target_Enable_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003345 RID: 13125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003345")]
		[Address(RVA = "0x77DFA0", Offset = "0x77D1A0", VA = "0x18077DFA0")]
		private void RpcWriter___Observers_Disable_2166136261()
		{
		}

		// Token: 0x06003346 RID: 13126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003346")]
		[Address(RVA = "0x77DD30", Offset = "0x77CF30", VA = "0x18077DD30")]
		public void RpcLogic___Disable_2166136261()
		{
		}

		// Token: 0x06003347 RID: 13127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003347")]
		[Address(RVA = "0x77DEE0", Offset = "0x77D0E0", VA = "0x18077DEE0")]
		private void RpcReader___Observers_Disable_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06003348 RID: 13128 RVA: 0x0000F948 File Offset: 0x0000DB48
		// (set) Token: 0x06003349 RID: 13129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000837")]
		public bool SyncAccessor_<Gate1Open>k__BackingField
		{
			[Token(Token = "0x6003348")]
			[Address(RVA = "0x511850", Offset = "0x510A50", VA = "0x180511850")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003349")]
			[Address(RVA = "0x77EBD0", Offset = "0x77DDD0", VA = "0x18077EBD0")]
			set
			{
			}
		}

		// Token: 0x0600334A RID: 13130 RVA: 0x0000F960 File Offset: 0x0000DB60
		[Token(Token = "0x600334A")]
		[Address(RVA = "0x77D980", Offset = "0x77CB80", VA = "0x18077D980", Slot = "24")]
		public virtual bool ReadSyncVar___ScheduleOne.Police.RoadCheckpoint(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x0600334B RID: 13131 RVA: 0x0000F978 File Offset: 0x0000DB78
		// (set) Token: 0x0600334C RID: 13132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000838")]
		public bool SyncAccessor_<Gate2Open>k__BackingField
		{
			[Token(Token = "0x600334B")]
			[Address(RVA = "0x621930", Offset = "0x620B30", VA = "0x180621930")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600334C")]
			[Address(RVA = "0x77EC90", Offset = "0x77DE90", VA = "0x18077EC90")]
			set
			{
			}
		}

		// Token: 0x0600334D RID: 13133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600334D")]
		[Address(RVA = "0x77CFB0", Offset = "0x77C1B0", VA = "0x18077CFB0", Slot = "25")]
		protected virtual void Awake_UserLogic_ScheduleOne.Police.RoadCheckpoint_Assembly-CSharp.dll()
		{
		}

		// Token: 0x0400258B RID: 9611
		[Token(Token = "0x400258B")]
		public const float MAX_TIME_OPEN = 15f;

		// Token: 0x0400258D RID: 9613
		[Token(Token = "0x400258D")]
		[FieldOffset(Offset = "0x11C")]
		protected RoadCheckpoint.ECheckpointState appliedState;

		// Token: 0x04002590 RID: 9616
		[Token(Token = "0x4002590")]
		[FieldOffset(Offset = "0x128")]
		public List<NPC> AssignedNPCs;

		// Token: 0x04002591 RID: 9617
		[Token(Token = "0x4002591")]
		[FieldOffset(Offset = "0x130")]
		[Header("Settings")]
		public EStealthLevel MaxStealthLevel;

		// Token: 0x04002592 RID: 9618
		[Token(Token = "0x4002592")]
		[FieldOffset(Offset = "0x134")]
		public bool OpenForNPCs;

		// Token: 0x04002593 RID: 9619
		[Token(Token = "0x4002593")]
		[FieldOffset(Offset = "0x135")]
		public bool EnabledOnStart;

		// Token: 0x04002594 RID: 9620
		[Token(Token = "0x4002594")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		[Header("References")]
		protected GameObject container;

		// Token: 0x04002595 RID: 9621
		[Token(Token = "0x4002595")]
		[FieldOffset(Offset = "0x140")]
		public CarStopper Stopper1;

		// Token: 0x04002596 RID: 9622
		[Token(Token = "0x4002596")]
		[FieldOffset(Offset = "0x148")]
		public CarStopper Stopper2;

		// Token: 0x04002597 RID: 9623
		[Token(Token = "0x4002597")]
		[FieldOffset(Offset = "0x150")]
		public VehicleDetector SearchArea1;

		// Token: 0x04002598 RID: 9624
		[Token(Token = "0x4002598")]
		[FieldOffset(Offset = "0x158")]
		public VehicleDetector SearchArea2;

		// Token: 0x04002599 RID: 9625
		[Token(Token = "0x4002599")]
		[FieldOffset(Offset = "0x160")]
		public VehicleObstacle VehicleObstacle1;

		// Token: 0x0400259A RID: 9626
		[Token(Token = "0x400259A")]
		[FieldOffset(Offset = "0x168")]
		public VehicleObstacle VehicleObstacle2;

		// Token: 0x0400259B RID: 9627
		[Token(Token = "0x400259B")]
		[FieldOffset(Offset = "0x170")]
		public VehicleDetector NPCVehicleDetectionArea1;

		// Token: 0x0400259C RID: 9628
		[Token(Token = "0x400259C")]
		[FieldOffset(Offset = "0x178")]
		public VehicleDetector NPCVehicleDetectionArea2;

		// Token: 0x0400259D RID: 9629
		[Token(Token = "0x400259D")]
		[FieldOffset(Offset = "0x180")]
		public VehicleDetector ImmediateVehicleDetector;

		// Token: 0x0400259E RID: 9630
		[Token(Token = "0x400259E")]
		[FieldOffset(Offset = "0x188")]
		public Rigidbody[] TrafficCones;

		// Token: 0x0400259F RID: 9631
		[Token(Token = "0x400259F")]
		[FieldOffset(Offset = "0x190")]
		public Transform[] StandPoints;

		// Token: 0x040025A0 RID: 9632
		[Token(Token = "0x40025A0")]
		[FieldOffset(Offset = "0x198")]
		protected Dictionary<Rigidbody, Tuple<Vector3, Quaternion>> trafficConeOriginalTransforms;

		// Token: 0x040025A1 RID: 9633
		[Token(Token = "0x40025A1")]
		[FieldOffset(Offset = "0x1A0")]
		private float timeSinceGate1Open;

		// Token: 0x040025A2 RID: 9634
		[Token(Token = "0x40025A2")]
		[FieldOffset(Offset = "0x1A4")]
		private bool vehicleDetectedSinceGate1Open;

		// Token: 0x040025A3 RID: 9635
		[Token(Token = "0x40025A3")]
		[FieldOffset(Offset = "0x1A8")]
		private float timeSinceGate2Open;

		// Token: 0x040025A4 RID: 9636
		[Token(Token = "0x40025A4")]
		[FieldOffset(Offset = "0x1AC")]
		private bool vehicleDetectedSinceGate2Open;

		// Token: 0x040025A5 RID: 9637
		[Token(Token = "0x40025A5")]
		[FieldOffset(Offset = "0x1B0")]
		public UnityEvent<Player> onPlayerWalkThrough;

		// Token: 0x040025A6 RID: 9638
		[Token(Token = "0x40025A6")]
		[FieldOffset(Offset = "0x1B8")]
		public SyncVar<bool> syncVar___<Gate1Open>k__BackingField;

		// Token: 0x040025A7 RID: 9639
		[Token(Token = "0x40025A7")]
		[FieldOffset(Offset = "0x1C0")]
		public SyncVar<bool> syncVar___<Gate2Open>k__BackingField;

		// Token: 0x040025A8 RID: 9640
		[Token(Token = "0x40025A8")]
		[FieldOffset(Offset = "0x1C8")]
		private bool NetworkInitialize___EarlyScheduleOne.Police.RoadCheckpointAssembly-CSharp.dll_Excuted;

		// Token: 0x040025A9 RID: 9641
		[Token(Token = "0x40025A9")]
		[FieldOffset(Offset = "0x1C9")]
		private bool NetworkInitialize__LateScheduleOne.Police.RoadCheckpointAssembly-CSharp.dll_Excuted;

		// Token: 0x02000787 RID: 1927
		[Token(Token = "0x2000787")]
		public enum ECheckpointState
		{
			// Token: 0x040025AB RID: 9643
			[Token(Token = "0x40025AB")]
			Disabled,
			// Token: 0x040025AC RID: 9644
			[Token(Token = "0x40025AC")]
			Enabled
		}
	}
}
