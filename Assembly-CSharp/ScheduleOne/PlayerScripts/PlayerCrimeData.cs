using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Law;
using ScheduleOne.NPCs;
using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x020005EF RID: 1519
	[Token(Token = "0x20005EF")]
	public class PlayerCrimeData : NetworkBehaviour
	{
		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x060024DA RID: 9434 RVA: 0x0000C0D8 File Offset: 0x0000A2D8
		// (set) Token: 0x060024DB RID: 9435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000671")]
		public PlayerCrimeData.EPursuitLevel CurrentPursuitLevel
		{
			[Token(Token = "0x60024DA")]
			[Address(RVA = "0x521B10", Offset = "0x520D10", VA = "0x180521B10")]
			[CompilerGenerated]
			get
			{
				return PlayerCrimeData.EPursuitLevel.None;
			}
			[Token(Token = "0x60024DB")]
			[Address(RVA = "0x6AAF10", Offset = "0x6AA110", VA = "0x1806AAF10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x060024DC RID: 9436 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		// (set) Token: 0x060024DD RID: 9437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000672")]
		public Vector3 LastKnownPosition
		{
			[Token(Token = "0x60024DC")]
			[Address(RVA = "0x6AAEC0", Offset = "0x6AA0C0", VA = "0x1806AAEC0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60024DD")]
			[Address(RVA = "0x6AAFA0", Offset = "0x6AA1A0", VA = "0x1806AAFA0")]
			[ServerRpc(RunLocally = true)]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x060024DE RID: 9438 RVA: 0x0000C108 File Offset: 0x0000A308
		// (set) Token: 0x060024DF RID: 9439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000673")]
		public float CurrentArrestProgress
		{
			[Token(Token = "0x60024DE")]
			[Address(RVA = "0x511750", Offset = "0x510950", VA = "0x180511750")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60024DF")]
			[Address(RVA = "0x57F890", Offset = "0x57EA90", VA = "0x18057F890")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x060024E0 RID: 9440 RVA: 0x0000C120 File Offset: 0x0000A320
		// (set) Token: 0x060024E1 RID: 9441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000674")]
		public float CurrentBodySearchProgress
		{
			[Token(Token = "0x60024E0")]
			[Address(RVA = "0x6AAEB0", Offset = "0x6AA0B0", VA = "0x1806AAEB0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60024E1")]
			[Address(RVA = "0x6AAF00", Offset = "0x6AA100", VA = "0x1806AAF00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x060024E2 RID: 9442 RVA: 0x0000C138 File Offset: 0x0000A338
		// (set) Token: 0x060024E3 RID: 9443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000675")]
		public int MinsSinceLastArrested
		{
			[Token(Token = "0x60024E2")]
			[Address(RVA = "0x6AAEE0", Offset = "0x6AA0E0", VA = "0x1806AAEE0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60024E3")]
			[Address(RVA = "0x6AB070", Offset = "0x6AA270", VA = "0x1806AB070")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x060024E4 RID: 9444 RVA: 0x0000C150 File Offset: 0x0000A350
		// (set) Token: 0x060024E5 RID: 9445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000676")]
		public float TimeSinceLastBodySearch
		{
			[Token(Token = "0x60024E4")]
			[Address(RVA = "0x6AAEF0", Offset = "0x6AA0F0", VA = "0x1806AAEF0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60024E5")]
			[Address(RVA = "0x6AB080", Offset = "0x6AA280", VA = "0x1806AB080")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x060024E6 RID: 9446 RVA: 0x0000C168 File Offset: 0x0000A368
		// (set) Token: 0x060024E7 RID: 9447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000677")]
		public bool EvadedArrest
		{
			[Token(Token = "0x60024E6")]
			[Address(RVA = "0x5887A0", Offset = "0x5879A0", VA = "0x1805887A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60024E7")]
			[Address(RVA = "0x588850", Offset = "0x587A50", VA = "0x180588850")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060024E8 RID: 9448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024E8")]
		[Address(RVA = "0x6A7840", Offset = "0x6A6A40", VA = "0x1806A7840", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024E9")]
		[Address(RVA = "0x6A9ED0", Offset = "0x6A90D0", VA = "0x1806A9ED0")]
		private void Start()
		{
		}

		// Token: 0x060024EA RID: 9450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024EA")]
		[Address(RVA = "0x6A8AB0", Offset = "0x6A7CB0", VA = "0x1806A8AB0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060024EB RID: 9451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024EB")]
		[Address(RVA = "0x6AA6A0", Offset = "0x6A98A0", VA = "0x1806AA6A0", Slot = "20")]
		protected virtual void Update()
		{
		}

		// Token: 0x060024EC RID: 9452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024EC")]
		[Address(RVA = "0x6A8720", Offset = "0x6A7920", VA = "0x1806A8720")]
		private void MinPass()
		{
		}

		// Token: 0x060024ED RID: 9453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024ED")]
		[Address(RVA = "0x6A84B0", Offset = "0x6A76B0", VA = "0x1806A84B0", Slot = "21")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x060024EE RID: 9454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024EE")]
		[Address(RVA = "0x6A9C40", Offset = "0x6A8E40", VA = "0x1806A9C40")]
		public void SetPursuitLevel(PlayerCrimeData.EPursuitLevel level)
		{
		}

		// Token: 0x060024EF RID: 9455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024EF")]
		[Address(RVA = "0x6A9B10", Offset = "0x6A8D10", VA = "0x1806A9B10")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		private void SetPursuitLevel_Server(PlayerCrimeData.EPursuitLevel level)
		{
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F0")]
		[Address(RVA = "0x6A7BF0", Offset = "0x6A6DF0", VA = "0x1806A7BF0")]
		public void Escalate()
		{
		}

		// Token: 0x060024F1 RID: 9457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F1")]
		[Address(RVA = "0x6A7B90", Offset = "0x6A6D90", VA = "0x1806A7B90")]
		public void Deescalate()
		{
		}

		// Token: 0x060024F2 RID: 9458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F2")]
		[Address(RVA = "0x6A8ED0", Offset = "0x6A80D0", VA = "0x1806A8ED0")]
		[ObserversRpc(RunLocally = true)]
		public void RecordLastKnownPosition(bool resetTimeSinceSighted)
		{
		}

		// Token: 0x060024F3 RID: 9459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F3")]
		[Address(RVA = "0x6A9A80", Offset = "0x6A8C80", VA = "0x1806A9A80")]
		public void SetArrestProgress(float progress)
		{
		}

		// Token: 0x060024F4 RID: 9460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F4")]
		[Address(RVA = "0x6A9110", Offset = "0x6A8310", VA = "0x1806A9110")]
		public void ResetBodysearchCooldown()
		{
		}

		// Token: 0x060024F5 RID: 9461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F5")]
		[Address(RVA = "0x6A9AD0", Offset = "0x6A8CD0", VA = "0x1806A9AD0")]
		public void SetBodySearchProgress(float progress)
		{
		}

		// Token: 0x060024F6 RID: 9462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F6")]
		[Address(RVA = "0x6A8C20", Offset = "0x6A7E20", VA = "0x1806A8C20")]
		private void OnDie()
		{
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F7")]
		[Address(RVA = "0x6A7470", Offset = "0x6A6670", VA = "0x1806A7470")]
		public void AddCrime(Crime crime, int quantity = 1)
		{
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F8")]
		[Address(RVA = "0x6A7B40", Offset = "0x6A6D40", VA = "0x1806A7B40")]
		public void ClearCrimes()
		{
		}

		// Token: 0x060024F9 RID: 9465 RVA: 0x0000C180 File Offset: 0x0000A380
		[Token(Token = "0x60024F9")]
		[Address(RVA = "0x6A83A0", Offset = "0x6A75A0", VA = "0x1806A83A0")]
		public bool IsCrimeOnRecord(Type crime)
		{
			return default(bool);
		}

		// Token: 0x060024FA RID: 9466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024FA")]
		[Address(RVA = "0x6A9B00", Offset = "0x6A8D00", VA = "0x1806A9B00")]
		public void SetEvaded()
		{
		}

		// Token: 0x060024FB RID: 9467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024FB")]
		[Address(RVA = "0x6A8C70", Offset = "0x6A7E70", VA = "0x1806A8C70")]
		private void OnSleepStart()
		{
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024FC")]
		[Address(RVA = "0x6AA4C0", Offset = "0x6A96C0", VA = "0x1806AA4C0")]
		private void UpdateEscalation()
		{
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024FD")]
		[Address(RVA = "0x6AA510", Offset = "0x6A9710", VA = "0x1806AA510")]
		private void UpdateTimeout()
		{
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024FE")]
		[Address(RVA = "0x6AA260", Offset = "0x6A9460", VA = "0x1806AA260")]
		private void TimeoutPursuit()
		{
		}

		// Token: 0x060024FF RID: 9471 RVA: 0x0000C198 File Offset: 0x0000A398
		[Token(Token = "0x60024FF")]
		[Address(RVA = "0x6A7EB0", Offset = "0x6A70B0", VA = "0x1806A7EB0")]
		public float GetSearchTime()
		{
			return 0f;
		}

		// Token: 0x06002500 RID: 9472 RVA: 0x0000C1B0 File Offset: 0x0000A3B0
		[Token(Token = "0x6002500")]
		[Address(RVA = "0x6A7F00", Offset = "0x6A7100", VA = "0x1806A7F00")]
		public float GetShotAccuracyMultiplier()
		{
			return 0f;
		}

		// Token: 0x06002501 RID: 9473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002501")]
		[Address(RVA = "0x6A9010", Offset = "0x6A8210", VA = "0x1806A9010")]
		public void RecordVehicleCollision(NPC victim)
		{
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002502")]
		[Address(RVA = "0x6A7A10", Offset = "0x6A6C10", VA = "0x1806A7A10")]
		private void CheckNearestOfficer()
		{
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002503")]
		[Address(RVA = "0x6AAD30", Offset = "0x6A9F30", VA = "0x1806AAD30")]
		public PlayerCrimeData()
		{
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002506")]
		[Address(RVA = "0x6A87A0", Offset = "0x6A79A0", VA = "0x1806A87A0", Slot = "22")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002507")]
		[Address(RVA = "0x6A8730", Offset = "0x6A7930", VA = "0x1806A8730", Slot = "23")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002508")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002509")]
		[Address(RVA = "0x6A9890", Offset = "0x6A8A90", VA = "0x1806A9890")]
		private void RpcWriter___Server_set_LastKnownPosition_4276783012(Vector3 value)
		{
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600250A")]
		[Address(RVA = "0x6A9380", Offset = "0x6A8580", VA = "0x1806A9380")]
		protected void RpcLogic___set_LastKnownPosition_4276783012(Vector3 value)
		{
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600250B")]
		[Address(RVA = "0x6A9520", Offset = "0x6A8720", VA = "0x1806A9520")]
		private void RpcReader___Server_set_LastKnownPosition_4276783012(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600250C")]
		[Address(RVA = "0x6A9760", Offset = "0x6A8960", VA = "0x1806A9760")]
		private void RpcWriter___Server_SetPursuitLevel_Server_2979171596(PlayerCrimeData.EPursuitLevel level)
		{
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600250D")]
		[Address(RVA = "0x6A9240", Offset = "0x6A8440", VA = "0x1806A9240")]
		private void RpcLogic___SetPursuitLevel_Server_2979171596(PlayerCrimeData.EPursuitLevel level)
		{
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600250E")]
		[Address(RVA = "0x6A94B0", Offset = "0x6A86B0", VA = "0x1806A94B0")]
		private void RpcReader___Server_SetPursuitLevel_Server_2979171596(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600250F")]
		[Address(RVA = "0x6A9620", Offset = "0x6A8820", VA = "0x1806A9620")]
		private void RpcWriter___Observers_RecordLastKnownPosition_1140765316(bool resetTimeSinceSighted)
		{
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002510")]
		[Address(RVA = "0x6A9120", Offset = "0x6A8320", VA = "0x1806A9120")]
		public void RpcLogic___RecordLastKnownPosition_1140765316(bool resetTimeSinceSighted)
		{
		}

		// Token: 0x06002511 RID: 9489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002511")]
		[Address(RVA = "0x6A9430", Offset = "0x6A8630", VA = "0x1806A9430")]
		private void RpcReader___Observers_RecordLastKnownPosition_1140765316(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06002512 RID: 9490 RVA: 0x0000C1E0 File Offset: 0x0000A3E0
		// (set) Token: 0x06002513 RID: 9491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000678")]
		public PlayerCrimeData.EPursuitLevel SyncAccessor_<CurrentPursuitLevel>k__BackingField
		{
			[Token(Token = "0x6002512")]
			[Address(RVA = "0x521B10", Offset = "0x520D10", VA = "0x180521B10")]
			get
			{
				return PlayerCrimeData.EPursuitLevel.None;
			}
			[Token(Token = "0x6002513")]
			[Address(RVA = "0x6AB090", Offset = "0x6AA290", VA = "0x1806AB090")]
			set
			{
			}
		}

		// Token: 0x06002514 RID: 9492 RVA: 0x0000C1F8 File Offset: 0x0000A3F8
		[Token(Token = "0x6002514")]
		[Address(RVA = "0x6A8CE0", Offset = "0x6A7EE0", VA = "0x1806A8CE0", Slot = "24")]
		public virtual bool ReadSyncVar___ScheduleOne.PlayerScripts.PlayerCrimeData(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06002515 RID: 9493 RVA: 0x0000C210 File Offset: 0x0000A410
		// (set) Token: 0x06002516 RID: 9494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000679")]
		public Vector3 SyncAccessor_<LastKnownPosition>k__BackingField
		{
			[Token(Token = "0x6002515")]
			[Address(RVA = "0x6AAEC0", Offset = "0x6AA0C0", VA = "0x1806AAEC0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6002516")]
			[Address(RVA = "0x6AB140", Offset = "0x6AA340", VA = "0x1806AB140")]
			set
			{
			}
		}

		// Token: 0x06002517 RID: 9495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002517")]
		[Address(RVA = "0x6A76A0", Offset = "0x6A68A0", VA = "0x1806A76A0")]
		private void Awake_UserLogic_ScheduleOne.PlayerScripts.PlayerCrimeData_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001CBB RID: 7355
		[Token(Token = "0x4001CBB")]
		public const float SEARCH_TIME_INVESTIGATING = 60f;

		// Token: 0x04001CBC RID: 7356
		[Token(Token = "0x4001CBC")]
		public const float SEARCH_TIME_ARRESTING = 25f;

		// Token: 0x04001CBD RID: 7357
		[Token(Token = "0x4001CBD")]
		public const float SEARCH_TIME_NONLETHAL = 30f;

		// Token: 0x04001CBE RID: 7358
		[Token(Token = "0x4001CBE")]
		public const float SEARCH_TIME_LETHAL = 40f;

		// Token: 0x04001CBF RID: 7359
		[Token(Token = "0x4001CBF")]
		public const float ESCALATION_TIME_ARRESTING = 25f;

		// Token: 0x04001CC0 RID: 7360
		[Token(Token = "0x4001CC0")]
		public const float ESCALATION_TIME_NONLETHAL = 120f;

		// Token: 0x04001CC1 RID: 7361
		[Token(Token = "0x4001CC1")]
		public const float SHOT_COOLDOWN_MIN = 2f;

		// Token: 0x04001CC2 RID: 7362
		[Token(Token = "0x4001CC2")]
		public const float SHOT_COOLDOWN_MAX = 8f;

		// Token: 0x04001CC3 RID: 7363
		[Token(Token = "0x4001CC3")]
		public const float VEHICLE_COLLISION_LIFETIME = 30f;

		// Token: 0x04001CC4 RID: 7364
		[Token(Token = "0x4001CC4")]
		public const float VEHICLE_COLLISION_LIMIT = 3f;

		// Token: 0x04001CC5 RID: 7365
		[Token(Token = "0x4001CC5")]
		[FieldOffset(Offset = "0x118")]
		public PoliceOfficer NearestOfficer;

		// Token: 0x04001CC6 RID: 7366
		[Token(Token = "0x4001CC6")]
		[FieldOffset(Offset = "0x120")]
		public Player Player;

		// Token: 0x04001CC7 RID: 7367
		[Token(Token = "0x4001CC7")]
		[FieldOffset(Offset = "0x128")]
		public AudioSourceController onPursuitEscapedSound;

		// Token: 0x04001CCA RID: 7370
		[Token(Token = "0x4001CCA")]
		[FieldOffset(Offset = "0x140")]
		public List<PoliceOfficer> Pursuers;

		// Token: 0x04001CCE RID: 7374
		[Token(Token = "0x4001CCE")]
		[FieldOffset(Offset = "0x154")]
		public float TimeSincePursuitStart;

		// Token: 0x04001CCF RID: 7375
		[Token(Token = "0x4001CCF")]
		[FieldOffset(Offset = "0x158")]
		public float CurrentPursuitLevelDuration;

		// Token: 0x04001CD0 RID: 7376
		[Token(Token = "0x4001CD0")]
		[FieldOffset(Offset = "0x15C")]
		public float TimeSinceSighted;

		// Token: 0x04001CD1 RID: 7377
		[Token(Token = "0x4001CD1")]
		[FieldOffset(Offset = "0x160")]
		public Dictionary<Crime, int> Crimes;

		// Token: 0x04001CD2 RID: 7378
		[Token(Token = "0x4001CD2")]
		[FieldOffset(Offset = "0x168")]
		public bool BodySearchPending;

		// Token: 0x04001CD5 RID: 7381
		[Token(Token = "0x4001CD5")]
		[FieldOffset(Offset = "0x178")]
		public Action<PlayerCrimeData.EPursuitLevel, PlayerCrimeData.EPursuitLevel> onPursuitLevelChange;

		// Token: 0x04001CD6 RID: 7382
		[Token(Token = "0x4001CD6")]
		[FieldOffset(Offset = "0x180")]
		protected List<PlayerCrimeData.VehicleCollisionInstance> Collisions;

		// Token: 0x04001CD7 RID: 7383
		[Token(Token = "0x4001CD7")]
		[FieldOffset(Offset = "0x188")]
		public SyncVar<PlayerCrimeData.EPursuitLevel> syncVar___<CurrentPursuitLevel>k__BackingField;

		// Token: 0x04001CD8 RID: 7384
		[Token(Token = "0x4001CD8")]
		[FieldOffset(Offset = "0x190")]
		public SyncVar<Vector3> syncVar___<LastKnownPosition>k__BackingField;

		// Token: 0x04001CD9 RID: 7385
		[Token(Token = "0x4001CD9")]
		[FieldOffset(Offset = "0x198")]
		private bool NetworkInitialize___EarlyScheduleOne.PlayerScripts.PlayerCrimeDataAssembly-CSharp.dll_Excuted;

		// Token: 0x04001CDA RID: 7386
		[Token(Token = "0x4001CDA")]
		[FieldOffset(Offset = "0x199")]
		private bool NetworkInitialize__LateScheduleOne.PlayerScripts.PlayerCrimeDataAssembly-CSharp.dll_Excuted;

		// Token: 0x020005F0 RID: 1520
		[Token(Token = "0x20005F0")]
		public class VehicleCollisionInstance
		{
			// Token: 0x06002518 RID: 9496 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002518")]
			[Address(RVA = "0x6B98C0", Offset = "0x6B8AC0", VA = "0x1806B98C0")]
			public VehicleCollisionInstance(NPC victim, float timeSince)
			{
			}

			// Token: 0x04001CDB RID: 7387
			[Token(Token = "0x4001CDB")]
			[FieldOffset(Offset = "0x10")]
			public NPC Victim;

			// Token: 0x04001CDC RID: 7388
			[Token(Token = "0x4001CDC")]
			[FieldOffset(Offset = "0x18")]
			public float TimeSince;
		}

		// Token: 0x020005F1 RID: 1521
		[Token(Token = "0x20005F1")]
		public enum EPursuitLevel
		{
			// Token: 0x04001CDE RID: 7390
			[Token(Token = "0x4001CDE")]
			None,
			// Token: 0x04001CDF RID: 7391
			[Token(Token = "0x4001CDF")]
			Investigating,
			// Token: 0x04001CE0 RID: 7392
			[Token(Token = "0x4001CE0")]
			Arresting,
			// Token: 0x04001CE1 RID: 7393
			[Token(Token = "0x4001CE1")]
			NonLethal,
			// Token: 0x04001CE2 RID: 7394
			[Token(Token = "0x4001CE2")]
			Lethal
		}
	}
}
