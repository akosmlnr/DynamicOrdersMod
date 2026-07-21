using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vehicles;
using ScheduleOne.Vehicles.AI;
using ScheduleOne.Vision;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000B30 RID: 2864
	[Token(Token = "0x2000B30")]
	public class VehiclePursuitBehaviour : Behaviour
	{
		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x06005508 RID: 21768 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06005509 RID: 21769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C89")]
		public Player Target
		{
			[Token(Token = "0x6005508")]
			[Address(RVA = "0x5887E0", Offset = "0x5879E0", VA = "0x1805887E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005509")]
			[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x0600550A RID: 21770 RVA: 0x00015F60 File Offset: 0x00014160
		// (set) Token: 0x0600550B RID: 21771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C8A")]
		public bool IsTargetRecentlyVisible
		{
			[Token(Token = "0x600550A")]
			[Address(RVA = "0x98F000", Offset = "0x98E200", VA = "0x18098F000")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600550B")]
			[Address(RVA = "0x98F0C0", Offset = "0x98E2C0", VA = "0x18098F0C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x0600550C RID: 21772 RVA: 0x00015F78 File Offset: 0x00014178
		// (set) Token: 0x0600550D RID: 21773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C8B")]
		public bool IsTargetImmediatelyVisible
		{
			[Token(Token = "0x600550C")]
			[Address(RVA = "0x98EFF0", Offset = "0x98E1F0", VA = "0x18098EFF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600550D")]
			[Address(RVA = "0x98F0B0", Offset = "0x98E2B0", VA = "0x18098F0B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x0600550E RID: 21774 RVA: 0x00015F90 File Offset: 0x00014190
		[Token(Token = "0x17000C8C")]
		private bool isDriving
		{
			[Token(Token = "0x600550E")]
			[Address(RVA = "0x98F010", Offset = "0x98E210", VA = "0x18098F010")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x0600550F RID: 21775 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000C8D")]
		private VehicleAgent Agent
		{
			[Token(Token = "0x600550F")]
			[Address(RVA = "0x98C3B0", Offset = "0x98B5B0", VA = "0x18098C3B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005510 RID: 21776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005510")]
		[Address(RVA = "0x98CD60", Offset = "0x98BF60", VA = "0x18098CD60", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x06005511 RID: 21777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005511")]
		[Address(RVA = "0x98DC60", Offset = "0x98CE60", VA = "0x18098DC60")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005512 RID: 21778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005512")]
		[Address(RVA = "0x98CDB0", Offset = "0x98BFB0", VA = "0x18098CDB0")]
		public void BeginAsSighted()
		{
		}

		// Token: 0x06005513 RID: 21779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005513")]
		[Address(RVA = "0x98C9D0", Offset = "0x98BBD0", VA = "0x18098C9D0", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x06005514 RID: 21780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005514")]
		[Address(RVA = "0x98E040", Offset = "0x98D240", VA = "0x18098E040", Slot = "25")]
		public override void Resume()
		{
		}

		// Token: 0x06005515 RID: 21781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005515")]
		[Address(RVA = "0x98DDA0", Offset = "0x98CFA0", VA = "0x18098DDA0", Slot = "24")]
		public override void Pause()
		{
		}

		// Token: 0x06005516 RID: 21782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005516")]
		[Address(RVA = "0x98D0C0", Offset = "0x98C2C0", VA = "0x18098D0C0", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x06005517 RID: 21783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005517")]
		[Address(RVA = "0x98CA90", Offset = "0x98BC90", VA = "0x18098CA90", Slot = "35")]
		public virtual void AssignTarget(Player target)
		{
		}

		// Token: 0x06005518 RID: 21784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005518")]
		[Address(RVA = "0x98E3E0", Offset = "0x98D5E0", VA = "0x18098E3E0")]
		private void StartPursuit()
		{
		}

		// Token: 0x06005519 RID: 21785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005519")]
		[Address(RVA = "0x98CDC0", Offset = "0x98BFC0", VA = "0x18098CDC0", Slot = "26")]
		public override void BehaviourUpdate()
		{
		}

		// Token: 0x0600551A RID: 21786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600551A")]
		[Address(RVA = "0x98D9D0", Offset = "0x98CBD0", VA = "0x18098D9D0", Slot = "28")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x0600551B RID: 21787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600551B")]
		[Address(RVA = "0x98D4F0", Offset = "0x98C6F0", VA = "0x18098D4F0", Slot = "36")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x0600551C RID: 21788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600551C")]
		[Address(RVA = "0x98E7E0", Offset = "0x98D9E0", VA = "0x18098E7E0")]
		private void UpdateDestination()
		{
		}

		// Token: 0x0600551D RID: 21789 RVA: 0x00015FA8 File Offset: 0x000141A8
		[Token(Token = "0x600551D")]
		[Address(RVA = "0x98D640", Offset = "0x98C840", VA = "0x18098D640")]
		private bool IsTargetValid()
		{
			return default(bool);
		}

		// Token: 0x0600551E RID: 21790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600551E")]
		[Address(RVA = "0x98CE10", Offset = "0x98C010", VA = "0x18098CE10")]
		private void CheckExitVehicle()
		{
		}

		// Token: 0x0600551F RID: 21791 RVA: 0x00015FC0 File Offset: 0x000141C0
		[Token(Token = "0x600551F")]
		[Address(RVA = "0x98D510", Offset = "0x98C710", VA = "0x18098D510")]
		private Vector3 GetPlayerChasePoint()
		{
			return default(Vector3);
		}

		// Token: 0x06005520 RID: 21792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005520")]
		[Address(RVA = "0x98E110", Offset = "0x98D310", VA = "0x18098E110")]
		private void SetAggressiveDriving(bool aggressive)
		{
		}

		// Token: 0x06005521 RID: 21793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005521")]
		[Address(RVA = "0x98D3B0", Offset = "0x98C5B0", VA = "0x18098D3B0")]
		private void DriveTo(Vector3 location)
		{
		}

		// Token: 0x06005522 RID: 21794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005522")]
		[Address(RVA = "0x98D7C0", Offset = "0x98C9C0", VA = "0x18098D7C0")]
		private void NavigationCallback(VehicleAgent.ENavigationResult status)
		{
		}

		// Token: 0x06005523 RID: 21795 RVA: 0x00015FD8 File Offset: 0x000141D8
		[Token(Token = "0x6005523")]
		[Address(RVA = "0x98BB90", Offset = "0x98AD90", VA = "0x18098BB90")]
		private bool IsAsCloseAsPossible(Vector3 pos, out Vector3 closestPosition)
		{
			return default(bool);
		}

		// Token: 0x06005524 RID: 21796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005524")]
		[Address(RVA = "0x98CED0", Offset = "0x98C0D0", VA = "0x18098CED0")]
		protected void CheckTargetVisibility()
		{
		}

		// Token: 0x06005525 RID: 21797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005525")]
		[Address(RVA = "0x98D740", Offset = "0x98C940", VA = "0x18098D740")]
		public void MarkPlayerVisible()
		{
		}

		// Token: 0x06005526 RID: 21798 RVA: 0x00015FF0 File Offset: 0x000141F0
		[Token(Token = "0x6005526")]
		[Address(RVA = "0x98D6F0", Offset = "0x98C8F0", VA = "0x18098D6F0")]
		protected bool IsTargetVisible()
		{
			return default(bool);
		}

		// Token: 0x06005527 RID: 21799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005527")]
		[Address(RVA = "0x98DF20", Offset = "0x98D120", VA = "0x18098DF20")]
		private void ProcessVisionEvent(VisionEventReceipt visionEventReceipt)
		{
		}

		// Token: 0x06005528 RID: 21800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005528")]
		[Address(RVA = "0x98DE70", Offset = "0x98D070", VA = "0x18098DE70")]
		private void ProcessThirdPartyVisionEvent(VisionEventReceipt visionEventReceipt)
		{
		}

		// Token: 0x06005529 RID: 21801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005529")]
		[Address(RVA = "0x98E6B0", Offset = "0x98D8B0", VA = "0x18098E6B0", Slot = "37")]
		protected virtual void TargetSpotted()
		{
		}

		// Token: 0x0600552A RID: 21802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600552A")]
		[Address(RVA = "0x98D8C0", Offset = "0x98CAC0", VA = "0x18098D8C0")]
		[ServerRpc(RequireOwnership = false)]
		public void NotifyServerTargetSeen()
		{
		}

		// Token: 0x0600552B RID: 21803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600552B")]
		[Address(RVA = "0x98EF80", Offset = "0x98E180", VA = "0x18098EF80")]
		public VehiclePursuitBehaviour()
		{
		}

		// Token: 0x0600552C RID: 21804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600552C")]
		[Address(RVA = "0x98D830", Offset = "0x98CA30", VA = "0x18098D830", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600552D RID: 21805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600552D")]
		[Address(RVA = "0x98D810", Offset = "0x98CA10", VA = "0x18098D810", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600552E RID: 21806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600552E")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600552F RID: 21807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600552F")]
		[Address(RVA = "0x98D8C0", Offset = "0x98CAC0", VA = "0x18098D8C0")]
		private void RpcWriter___Server_NotifyServerTargetSeen_2166136261()
		{
		}

		// Token: 0x06005530 RID: 21808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005530")]
		[Address(RVA = "0x98E060", Offset = "0x98D260", VA = "0x18098E060")]
		public void RpcLogic___NotifyServerTargetSeen_2166136261()
		{
		}

		// Token: 0x06005531 RID: 21809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005531")]
		[Address(RVA = "0x98E0B0", Offset = "0x98D2B0", VA = "0x18098E0B0")]
		private void RpcReader___Server_NotifyServerTargetSeen_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005532 RID: 21810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005532")]
		[Address(RVA = "0x98CAC0", Offset = "0x98BCC0", VA = "0x18098CAC0", Slot = "38")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.VehiclePursuitBehaviour_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003959 RID: 14681
		[Token(Token = "0x4003959")]
		public const float RECENT_VISIBILITY_THRESHOLD = 5f;

		// Token: 0x0400395A RID: 14682
		[Token(Token = "0x400395A")]
		public const float EXIT_VEHICLE_MAX_SPEED = 4f;

		// Token: 0x0400395B RID: 14683
		[Token(Token = "0x400395B")]
		public const float CLOSE_ENOUGH_THRESHOLD = 10f;

		// Token: 0x0400395C RID: 14684
		[Token(Token = "0x400395C")]
		public const float UPDATE_FREQUENCY = 0.2f;

		// Token: 0x0400395D RID: 14685
		[Token(Token = "0x400395D")]
		public const float STATIONARY_THRESHOLD = 1f;

		// Token: 0x0400395E RID: 14686
		[Token(Token = "0x400395E")]
		public const float TIME_STATIONARY_TO_EXIT = 3f;

		// Token: 0x04003960 RID: 14688
		[Token(Token = "0x4003960")]
		[FieldOffset(Offset = "0x170")]
		[Header("Settings")]
		public AnimationCurve RepathDistanceThresholdMap;

		// Token: 0x04003961 RID: 14689
		[Token(Token = "0x4003961")]
		[FieldOffset(Offset = "0x178")]
		public LandVehicle vehicle;

		// Token: 0x04003962 RID: 14690
		[Token(Token = "0x4003962")]
		[FieldOffset(Offset = "0x180")]
		private bool initialContactMade;

		// Token: 0x04003963 RID: 14691
		[Token(Token = "0x4003963")]
		[FieldOffset(Offset = "0x181")]
		private bool aggressiveDrivingEnabled;

		// Token: 0x04003966 RID: 14694
		[Token(Token = "0x4003966")]
		[FieldOffset(Offset = "0x184")]
		private float timeSinceLastSighting;

		// Token: 0x04003967 RID: 14695
		[Token(Token = "0x4003967")]
		[FieldOffset(Offset = "0x188")]
		private bool visionEventReceived;

		// Token: 0x04003968 RID: 14696
		[Token(Token = "0x4003968")]
		[FieldOffset(Offset = "0x18C")]
		private int consecutiveVehiclePathingFailures;

		// Token: 0x04003969 RID: 14697
		[Token(Token = "0x4003969")]
		[FieldOffset(Offset = "0x190")]
		private float timeStationary;

		// Token: 0x0400396A RID: 14698
		[Token(Token = "0x400396A")]
		[FieldOffset(Offset = "0x194")]
		private Vector3 currentDriveTarget;

		// Token: 0x0400396B RID: 14699
		[Token(Token = "0x400396B")]
		[FieldOffset(Offset = "0x1A0")]
		private int targetChanges;

		// Token: 0x0400396C RID: 14700
		[Token(Token = "0x400396C")]
		[FieldOffset(Offset = "0x1A4")]
		private float timeSincePursuitStart;

		// Token: 0x0400396D RID: 14701
		[Token(Token = "0x400396D")]
		[FieldOffset(Offset = "0x1A8")]
		private bool beginAsSighted;

		// Token: 0x0400396E RID: 14702
		[Token(Token = "0x400396E")]
		[FieldOffset(Offset = "0x1A9")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.VehiclePursuitBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x0400396F RID: 14703
		[Token(Token = "0x400396F")]
		[FieldOffset(Offset = "0x1AA")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.VehiclePursuitBehaviourAssembly-CSharp.dll_Excuted;
	}
}
