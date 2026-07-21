using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.Dialogue;
using ScheduleOne.FX;
using ScheduleOne.Law;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vehicles;
using ScheduleOne.Vision;
using ScheduleOne.VoiceOver;
using UnityEngine;

namespace ScheduleOne.Police
{
	// Token: 0x02000784 RID: 1924
	[Token(Token = "0x2000784")]
	public class PoliceOfficer : NPC
	{
		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x060032D8 RID: 13016 RVA: 0x0000F810 File Offset: 0x0000DA10
		// (set) Token: 0x060032D9 RID: 13017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700082E")]
		public bool IgnorePlayers
		{
			[Token(Token = "0x60032D8")]
			[Address(RVA = "0x72EFB0", Offset = "0x72E1B0", VA = "0x18072EFB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60032D9")]
			[Address(RVA = "0x776F10", Offset = "0x776110", VA = "0x180776F10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x060032DA RID: 13018 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700082F")]
		public NetworkObject PursuitTarget
		{
			[Token(Token = "0x60032DA")]
			[Address(RVA = "0x776E30", Offset = "0x776030", VA = "0x180776E30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x060032DB RID: 13019 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060032DC RID: 13020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000830")]
		public LandVehicle AssignedVehicle
		{
			[Token(Token = "0x60032DB")]
			[Address(RVA = "0x6F2D00", Offset = "0x6F1F00", VA = "0x1806F2D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60032DC")]
			[Address(RVA = "0x700530", Offset = "0x6FF730", VA = "0x180700530")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060032DD RID: 13021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032DD")]
		[Address(RVA = "0x771EB0", Offset = "0x7710B0", VA = "0x180771EB0", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x060032DE RID: 13022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032DE")]
		[Address(RVA = "0x775FA0", Offset = "0x7751A0", VA = "0x180775FA0", Slot = "88")]
		protected override void Start()
		{
		}

		// Token: 0x060032DF RID: 13023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032DF")]
		[Address(RVA = "0x773D90", Offset = "0x772F90", VA = "0x180773D90", Slot = "89")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060032E0 RID: 13024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032E0")]
		[Address(RVA = "0x776C80", Offset = "0x775E80", VA = "0x180776C80")]
		protected void Update()
		{
		}

		// Token: 0x060032E1 RID: 13025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032E1")]
		[Address(RVA = "0x773E70", Offset = "0x773070", VA = "0x180773E70", Slot = "92")]
		protected override void OnTick()
		{
		}

		// Token: 0x060032E2 RID: 13026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032E2")]
		[Address(RVA = "0x776810", Offset = "0x775A10", VA = "0x180776810")]
		private void UpdateVision()
		{
		}

		// Token: 0x060032E3 RID: 13027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032E3")]
		[Address(RVA = "0x772900", Offset = "0x771B00", VA = "0x180772900")]
		private void CheckDeactivation()
		{
		}

		// Token: 0x060032E4 RID: 13028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032E4")]
		[Address(RVA = "0x772170", Offset = "0x771370", VA = "0x180772170", Slot = "130")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public virtual void BeginFootPursuit_Networked(string playerCode, bool includeColleagues = true)
		{
		}

		// Token: 0x060032E5 RID: 13029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032E5")]
		[Address(RVA = "0x7722C0", Offset = "0x7714C0", VA = "0x1807722C0")]
		[ObserversRpc(RunLocally = true)]
		private void BeginFootPursuit(string playerCode)
		{
		}

		// Token: 0x060032E6 RID: 13030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032E6")]
		[Address(RVA = "0x772400", Offset = "0x771600", VA = "0x180772400", Slot = "131")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public virtual void BeginVehiclePursuit_Networked(string playerCode, NetworkObject vehicle, bool beginAsSighted)
		{
		}

		// Token: 0x060032E7 RID: 13031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032E7")]
		[Address(RVA = "0x772580", Offset = "0x771780", VA = "0x180772580")]
		[ObserversRpc(RunLocally = true)]
		private void BeginVehiclePursuit(string playerCode, NetworkObject vehicle, bool beginAsSighted)
		{
		}

		// Token: 0x060032E8 RID: 13032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032E8")]
		[Address(RVA = "0x771F00", Offset = "0x771100", VA = "0x180771F00", Slot = "132")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public virtual void BeginBodySearch_Networked(string playerCode)
		{
		}

		// Token: 0x060032E9 RID: 13033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032E9")]
		[Address(RVA = "0x772030", Offset = "0x771230", VA = "0x180772030")]
		[ObserversRpc(RunLocally = true)]
		private void BeginBodySearch(string playerCode)
		{
		}

		// Token: 0x060032EA RID: 13034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032EA")]
		[Address(RVA = "0x771A50", Offset = "0x770C50", VA = "0x180771A50", Slot = "133")]
		[ObserversRpc(RunLocally = true)]
		public virtual void AssignToCheckpoint(CheckpointManager.ECheckpointLocation location)
		{
		}

		// Token: 0x060032EB RID: 13035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032EB")]
		[Address(RVA = "0x776160", Offset = "0x775360", VA = "0x180776160")]
		public void UnassignFromCheckpoint()
		{
		}

		// Token: 0x060032EC RID: 13036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032EC")]
		[Address(RVA = "0x775E80", Offset = "0x775080", VA = "0x180775E80")]
		public void StartFootPatrol(PatrolGroup group, bool warpToStartPoint)
		{
		}

		// Token: 0x060032ED RID: 13037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032ED")]
		[Address(RVA = "0x775F20", Offset = "0x775120", VA = "0x180775F20")]
		public void StartVehiclePatrol(VehiclePatrolRoute route, LandVehicle vehicle)
		{
		}

		// Token: 0x060032EE RID: 13038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032EE")]
		[Address(RVA = "0x771B80", Offset = "0x770D80", VA = "0x180771B80", Slot = "134")]
		public virtual void AssignToSentryLocation(SentryLocation location)
		{
		}

		// Token: 0x060032EF RID: 13039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032EF")]
		[Address(RVA = "0x7761E0", Offset = "0x7753E0", VA = "0x1807761E0")]
		public void UnassignFromSentryLocation()
		{
		}

		// Token: 0x060032F0 RID: 13040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032F0")]
		[Address(RVA = "0x771A00", Offset = "0x770C00", VA = "0x180771A00")]
		public void Activate()
		{
		}

		// Token: 0x060032F1 RID: 13041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032F1")]
		[Address(RVA = "0x773550", Offset = "0x772750", VA = "0x180773550")]
		public void Deactivate()
		{
		}

		// Token: 0x060032F2 RID: 13042 RVA: 0x0000F828 File Offset: 0x0000DA28
		[Token(Token = "0x60032F2")]
		[Address(RVA = "0x775D70", Offset = "0x774F70", VA = "0x180775D70")]
		protected bool ShouldNoticeGeneralCrime(Player player)
		{
			return default(bool);
		}

		// Token: 0x060032F3 RID: 13043 RVA: 0x0000F840 File Offset: 0x0000DA40
		[Token(Token = "0x60032F3")]
		[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "112")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x060032F4 RID: 13044 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60032F4")]
		[Address(RVA = "0x773730", Offset = "0x772930", VA = "0x180773730", Slot = "109")]
		public override string GetNameAddress()
		{
			return null;
		}

		// Token: 0x060032F5 RID: 13045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032F5")]
		[Address(RVA = "0x776280", Offset = "0x775480", VA = "0x180776280")]
		private void UpdateChatter()
		{
		}

		// Token: 0x060032F6 RID: 13046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032F6")]
		[Address(RVA = "0x773F00", Offset = "0x773100", VA = "0x180773F00")]
		private void ProcessVisionEvent(VisionEventReceipt visionEventReceipt)
		{
		}

		// Token: 0x060032F7 RID: 13047 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60032F7")]
		[Address(RVA = "0x773770", Offset = "0x772970", VA = "0x180773770")]
		public static PoliceOfficer GetNearestOfficer(Vector3 position, out float distanceToTarget, bool onlyConscious = true)
		{
			return null;
		}

		// Token: 0x060032F8 RID: 13048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032F8")]
		[Address(RVA = "0x775BC0", Offset = "0x774DC0", VA = "0x180775BC0")]
		[ServerRpc(RequireOwnership = false)]
		public void SetIgnorePlayers(bool ignore)
		{
		}

		// Token: 0x060032F9 RID: 13049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032F9")]
		[Address(RVA = "0x775D20", Offset = "0x774F20", VA = "0x180775D20")]
		public void SetRandomAvoidancePriority()
		{
		}

		// Token: 0x060032FA RID: 13050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032FA")]
		[Address(RVA = "0x775CF0", Offset = "0x774EF0", VA = "0x180775CF0")]
		public void SetAvoidancePriority(int priority)
		{
		}

		// Token: 0x060032FB RID: 13051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032FB")]
		[Address(RVA = "0x776230", Offset = "0x775430", VA = "0x180776230", Slot = "135")]
		public virtual void UpdateBodySearch()
		{
		}

		// Token: 0x060032FC RID: 13052 RVA: 0x0000F858 File Offset: 0x0000DA58
		[Token(Token = "0x60032FC")]
		[Address(RVA = "0x772840", Offset = "0x771A40", VA = "0x180772840")]
		private bool CanInvestigate()
		{
			return default(bool);
		}

		// Token: 0x060032FD RID: 13053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032FD")]
		[Address(RVA = "0x776340", Offset = "0x775540", VA = "0x180776340")]
		private void UpdateExistingInvestigation()
		{
		}

		// Token: 0x060032FE RID: 13054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032FE")]
		[Address(RVA = "0x772FF0", Offset = "0x7721F0", VA = "0x180772FF0")]
		private void CheckNewInvestigation()
		{
		}

		// Token: 0x060032FF RID: 13055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032FF")]
		[Address(RVA = "0x776050", Offset = "0x775250", VA = "0x180776050")]
		private void StopBodySearchInvestigation()
		{
		}

		// Token: 0x06003300 RID: 13056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003300")]
		[Address(RVA = "0x772710", Offset = "0x771910", VA = "0x180772710")]
		public void BodySearchLocalPlayer()
		{
		}

		// Token: 0x06003301 RID: 13057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003301")]
		[Address(RVA = "0x773470", Offset = "0x772670", VA = "0x180773470")]
		public void ConductBodySearch(Player player)
		{
		}

		// Token: 0x06003302 RID: 13058 RVA: 0x0000F870 File Offset: 0x0000DA70
		[Token(Token = "0x6003302")]
		[Address(RVA = "0x772770", Offset = "0x771970", VA = "0x180772770")]
		private bool CanInvestigatePlayer(Player player)
		{
			return default(bool);
		}

		// Token: 0x06003303 RID: 13059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003303")]
		[Address(RVA = "0x776DF0", Offset = "0x775FF0", VA = "0x180776DF0")]
		public PoliceOfficer()
		{
		}

		// Token: 0x06003305 RID: 13061 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003305")]
		[Address(RVA = "0x7760F0", Offset = "0x7752F0", VA = "0x1807760F0")]
		[CompilerGenerated]
		private IEnumerator <Deactivate>g__Wait|65_0()
		{
			return null;
		}

		// Token: 0x06003307 RID: 13063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003307")]
		[Address(RVA = "0x7739F0", Offset = "0x772BF0", VA = "0x1807739F0", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003308 RID: 13064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003308")]
		[Address(RVA = "0x773990", Offset = "0x772B90", VA = "0x180773990", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003309 RID: 13065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003309")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600330A RID: 13066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600330A")]
		[Address(RVA = "0x775900", Offset = "0x774B00", VA = "0x180775900")]
		private void RpcWriter___Server_BeginFootPursuit_Networked_310431262(string playerCode, bool includeColleagues = true)
		{
		}

		// Token: 0x0600330B RID: 13067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600330B")]
		[Address(RVA = "0x774490", Offset = "0x773690", VA = "0x180774490", Slot = "136")]
		public virtual void RpcLogic___BeginFootPursuit_Networked_310431262(string playerCode, bool includeColleagues = true)
		{
		}

		// Token: 0x0600330C RID: 13068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600330C")]
		[Address(RVA = "0x774F50", Offset = "0x774150", VA = "0x180774F50")]
		private void RpcReader___Server_BeginFootPursuit_Networked_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600330D RID: 13069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600330D")]
		[Address(RVA = "0x775520", Offset = "0x774720", VA = "0x180775520")]
		private void RpcWriter___Observers_BeginFootPursuit_3615296227(string playerCode)
		{
		}

		// Token: 0x0600330E RID: 13070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600330E")]
		[Address(RVA = "0x774380", Offset = "0x773580", VA = "0x180774380")]
		private void RpcLogic___BeginFootPursuit_3615296227(string playerCode)
		{
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600330F")]
		[Address(RVA = "0x774DC0", Offset = "0x773FC0", VA = "0x180774DC0")]
		private void RpcReader___Observers_BeginFootPursuit_3615296227(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003310 RID: 13072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003310")]
		[Address(RVA = "0x775A60", Offset = "0x774C60", VA = "0x180775A60")]
		private void RpcWriter___Server_BeginVehiclePursuit_Networked_1834136777(string playerCode, NetworkObject vehicle, bool beginAsSighted)
		{
		}

		// Token: 0x06003311 RID: 13073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003311")]
		[Address(RVA = "0x772580", Offset = "0x771780", VA = "0x180772580", Slot = "137")]
		public virtual void RpcLogic___BeginVehiclePursuit_Networked_1834136777(string playerCode, NetworkObject vehicle, bool beginAsSighted)
		{
		}

		// Token: 0x06003312 RID: 13074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003312")]
		[Address(RVA = "0x775000", Offset = "0x774200", VA = "0x180775000")]
		private void RpcReader___Server_BeginVehiclePursuit_Networked_1834136777(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003313")]
		[Address(RVA = "0x775660", Offset = "0x774860", VA = "0x180775660")]
		private void RpcWriter___Observers_BeginVehiclePursuit_1834136777(string playerCode, NetworkObject vehicle, bool beginAsSighted)
		{
		}

		// Token: 0x06003314 RID: 13076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003314")]
		[Address(RVA = "0x7749F0", Offset = "0x773BF0", VA = "0x1807749F0")]
		private void RpcLogic___BeginVehiclePursuit_1834136777(string playerCode, NetworkObject vehicle, bool beginAsSighted)
		{
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003315")]
		[Address(RVA = "0x774E20", Offset = "0x774020", VA = "0x180774E20")]
		private void RpcReader___Observers_BeginVehiclePursuit_1834136777(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003316")]
		[Address(RVA = "0x7757D0", Offset = "0x7749D0", VA = "0x1807757D0")]
		private void RpcWriter___Server_BeginBodySearch_Networked_3615296227(string playerCode)
		{
		}

		// Token: 0x06003317 RID: 13079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003317")]
		[Address(RVA = "0x772030", Offset = "0x771230", VA = "0x180772030", Slot = "138")]
		public virtual void RpcLogic___BeginBodySearch_Networked_3615296227(string playerCode)
		{
		}

		// Token: 0x06003318 RID: 13080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003318")]
		[Address(RVA = "0x774EE0", Offset = "0x7740E0", VA = "0x180774EE0")]
		private void RpcReader___Server_BeginBodySearch_Networked_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003319 RID: 13081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003319")]
		[Address(RVA = "0x7753E0", Offset = "0x7745E0", VA = "0x1807753E0")]
		private void RpcWriter___Observers_BeginBodySearch_3615296227(string playerCode)
		{
		}

		// Token: 0x0600331A RID: 13082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600331A")]
		[Address(RVA = "0x774250", Offset = "0x773450", VA = "0x180774250")]
		private void RpcLogic___BeginBodySearch_3615296227(string playerCode)
		{
		}

		// Token: 0x0600331B RID: 13083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600331B")]
		[Address(RVA = "0x774D60", Offset = "0x773F60", VA = "0x180774D60")]
		private void RpcReader___Observers_BeginBodySearch_3615296227(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600331C")]
		[Address(RVA = "0x7752A0", Offset = "0x7744A0", VA = "0x1807752A0")]
		private void RpcWriter___Observers_AssignToCheckpoint_4087078542(CheckpointManager.ECheckpointLocation location)
		{
		}

		// Token: 0x0600331D RID: 13085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600331D")]
		[Address(RVA = "0x7740E0", Offset = "0x7732E0", VA = "0x1807740E0", Slot = "139")]
		public virtual void RpcLogic___AssignToCheckpoint_4087078542(CheckpointManager.ECheckpointLocation location)
		{
		}

		// Token: 0x0600331E RID: 13086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600331E")]
		[Address(RVA = "0x774D10", Offset = "0x773F10", VA = "0x180774D10")]
		private void RpcReader___Observers_AssignToCheckpoint_4087078542(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600331F RID: 13087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600331F")]
		[Address(RVA = "0x775BC0", Offset = "0x774DC0", VA = "0x180775BC0")]
		private void RpcWriter___Server_SetIgnorePlayers_1140765316(bool ignore)
		{
		}

		// Token: 0x06003320 RID: 13088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003320")]
		[Address(RVA = "0x774BA0", Offset = "0x773DA0", VA = "0x180774BA0")]
		public void RpcLogic___SetIgnorePlayers_1140765316(bool ignore)
		{
		}

		// Token: 0x06003321 RID: 13089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003321")]
		[Address(RVA = "0x7750E0", Offset = "0x7742E0", VA = "0x1807750E0")]
		private void RpcReader___Server_SetIgnorePlayers_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06003322 RID: 13090 RVA: 0x0000F8A0 File Offset: 0x0000DAA0
		// (set) Token: 0x06003323 RID: 13091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000831")]
		public bool SyncAccessor_<IgnorePlayers>k__BackingField
		{
			[Token(Token = "0x6003322")]
			[Address(RVA = "0x72EFB0", Offset = "0x72E1B0", VA = "0x18072EFB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003323")]
			[Address(RVA = "0x776FA0", Offset = "0x7761A0", VA = "0x180776FA0")]
			set
			{
			}
		}

		// Token: 0x06003324 RID: 13092 RVA: 0x0000F8B8 File Offset: 0x0000DAB8
		[Token(Token = "0x6003324")]
		[Address(RVA = "0x773FA0", Offset = "0x7731A0", VA = "0x180773FA0", Slot = "140")]
		public virtual bool ReadSyncVar___ScheduleOne.Police.PoliceOfficer(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x06003325 RID: 13093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003325")]
		[Address(RVA = "0x771BD0", Offset = "0x770DD0", VA = "0x180771BD0", Slot = "141")]
		protected virtual void Awake_UserLogic_ScheduleOne.Police.PoliceOfficer_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002560 RID: 9568
		[Token(Token = "0x4002560")]
		public const float DEACTIVATION_TIME = 1f;

		// Token: 0x04002561 RID: 9569
		[Token(Token = "0x4002561")]
		public const float INVESTIGATION_COOLDOWN = 60f;

		// Token: 0x04002562 RID: 9570
		[Token(Token = "0x4002562")]
		public const float INVESTIGATION_MAX_DISTANCE = 8f;

		// Token: 0x04002563 RID: 9571
		[Token(Token = "0x4002563")]
		public const float INVESTIGATION_MIN_VISIBILITY = 0.2f;

		// Token: 0x04002564 RID: 9572
		[Token(Token = "0x4002564")]
		public const float INVESTIGATION_CHECK_INTERVAL = 1f;

		// Token: 0x04002565 RID: 9573
		[Token(Token = "0x4002565")]
		public const float BODY_SEARCH_CHANCE_DEFAULT = 0.1f;

		// Token: 0x04002566 RID: 9574
		[Token(Token = "0x4002566")]
		public const float MIN_CHATTER_INTERVAL = 15f;

		// Token: 0x04002567 RID: 9575
		[Token(Token = "0x4002567")]
		public const float MAX_CHATTER_INTERVAL = 45f;

		// Token: 0x04002568 RID: 9576
		[Token(Token = "0x4002568")]
		[FieldOffset(Offset = "0x0")]
		public static Action<VisionEventReceipt> OnPoliceVisionEvent;

		// Token: 0x04002569 RID: 9577
		[Token(Token = "0x4002569")]
		[FieldOffset(Offset = "0x8")]
		public static List<PoliceOfficer> Officers;

		// Token: 0x0400256C RID: 9580
		[Token(Token = "0x400256C")]
		[FieldOffset(Offset = "0x338")]
		[Header("References")]
		public PursuitBehaviour PursuitBehaviour;

		// Token: 0x0400256D RID: 9581
		[Token(Token = "0x400256D")]
		[FieldOffset(Offset = "0x340")]
		public VehiclePursuitBehaviour VehiclePursuitBehaviour;

		// Token: 0x0400256E RID: 9582
		[Token(Token = "0x400256E")]
		[FieldOffset(Offset = "0x348")]
		public BodySearchBehaviour BodySearchBehaviour;

		// Token: 0x0400256F RID: 9583
		[Token(Token = "0x400256F")]
		[FieldOffset(Offset = "0x350")]
		public CheckpointBehaviour CheckpointBehaviour;

		// Token: 0x04002570 RID: 9584
		[Token(Token = "0x4002570")]
		[FieldOffset(Offset = "0x358")]
		public FootPatrolBehaviour FootPatrolBehaviour;

		// Token: 0x04002571 RID: 9585
		[Token(Token = "0x4002571")]
		[FieldOffset(Offset = "0x360")]
		public ProximityCircle ProxCircle;

		// Token: 0x04002572 RID: 9586
		[Token(Token = "0x4002572")]
		[FieldOffset(Offset = "0x368")]
		public VehiclePatrolBehaviour VehiclePatrolBehaviour;

		// Token: 0x04002573 RID: 9587
		[Token(Token = "0x4002573")]
		[FieldOffset(Offset = "0x370")]
		public SentryBehaviour SentryBehaviour;

		// Token: 0x04002574 RID: 9588
		[Token(Token = "0x4002574")]
		[FieldOffset(Offset = "0x378")]
		public PoliceChatterVO ChatterVO;

		// Token: 0x04002575 RID: 9589
		[Token(Token = "0x4002575")]
		[FieldOffset(Offset = "0x380")]
		public ScheduleOne.NPCs.Behaviour.Behaviour[] DeactivationBlockingBehaviours;

		// Token: 0x04002576 RID: 9590
		[Token(Token = "0x4002576")]
		[FieldOffset(Offset = "0x388")]
		[Header("Dialogue")]
		public DialogueContainer CheckpointDialogue;

		// Token: 0x04002577 RID: 9591
		[Token(Token = "0x4002577")]
		[FieldOffset(Offset = "0x390")]
		[Header("Tools")]
		public AvatarEquippable BatonPrefab;

		// Token: 0x04002578 RID: 9592
		[Token(Token = "0x4002578")]
		[FieldOffset(Offset = "0x398")]
		public AvatarEquippable TaserPrefab;

		// Token: 0x04002579 RID: 9593
		[Token(Token = "0x4002579")]
		[FieldOffset(Offset = "0x3A0")]
		public AvatarEquippable GunPrefab;

		// Token: 0x0400257A RID: 9594
		[Token(Token = "0x400257A")]
		[FieldOffset(Offset = "0x3A8")]
		[Header("Settings")]
		public bool AutoDeactivate;

		// Token: 0x0400257B RID: 9595
		[Token(Token = "0x400257B")]
		[FieldOffset(Offset = "0x3A9")]
		public bool ChatterEnabled;

		// Token: 0x0400257C RID: 9596
		[Token(Token = "0x400257C")]
		[FieldOffset(Offset = "0x3AC")]
		[Header("Behaviour Settings")]
		[Range(0f, 1f)]
		public float Suspicion;

		// Token: 0x0400257D RID: 9597
		[Token(Token = "0x400257D")]
		[FieldOffset(Offset = "0x3B0")]
		[Range(0f, 1f)]
		public float Leniency;

		// Token: 0x0400257E RID: 9598
		[Token(Token = "0x400257E")]
		[FieldOffset(Offset = "0x3B4")]
		[Header("Body Search Settings")]
		[Range(0f, 1f)]
		public float BodySearchChance;

		// Token: 0x0400257F RID: 9599
		[Token(Token = "0x400257F")]
		[FieldOffset(Offset = "0x3B8")]
		[Range(1f, 10f)]
		public float BodySearchDuration;

		// Token: 0x04002580 RID: 9600
		[Token(Token = "0x4002580")]
		[FieldOffset(Offset = "0x3C0")]
		[HideInInspector]
		public PoliceBelt belt;

		// Token: 0x04002581 RID: 9601
		[Token(Token = "0x4002581")]
		[FieldOffset(Offset = "0x3C8")]
		private float timeSinceReadyToPool;

		// Token: 0x04002582 RID: 9602
		[Token(Token = "0x4002582")]
		[FieldOffset(Offset = "0x3CC")]
		private float timeSinceOutOfSight;

		// Token: 0x04002583 RID: 9603
		[Token(Token = "0x4002583")]
		[FieldOffset(Offset = "0x3D0")]
		private float chatterCountDown;

		// Token: 0x04002584 RID: 9604
		[Token(Token = "0x4002584")]
		[FieldOffset(Offset = "0x3D8")]
		private Investigation currentBodySearchInvestigation;

		// Token: 0x04002585 RID: 9605
		[Token(Token = "0x4002585")]
		[FieldOffset(Offset = "0x3E0")]
		public SyncVar<bool> syncVar___<IgnorePlayers>k__BackingField;

		// Token: 0x04002586 RID: 9606
		[Token(Token = "0x4002586")]
		[FieldOffset(Offset = "0x3E8")]
		private bool NetworkInitialize___EarlyScheduleOne.Police.PoliceOfficerAssembly-CSharp.dll_Excuted;

		// Token: 0x04002587 RID: 9607
		[Token(Token = "0x4002587")]
		[FieldOffset(Offset = "0x3E9")]
		private bool NetworkInitialize__LateScheduleOne.Police.PoliceOfficerAssembly-CSharp.dll_Excuted;
	}
}
