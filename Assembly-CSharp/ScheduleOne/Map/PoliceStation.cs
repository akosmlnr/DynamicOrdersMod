using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Doors;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Police;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000553 RID: 1363
	[Token(Token = "0x2000553")]
	public class PoliceStation : NPCEnterableBuilding
	{
		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001E64 RID: 7780 RVA: 0x0000AD88 File Offset: 0x00008F88
		// (set) Token: 0x06001E65 RID: 7781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000578")]
		public float TimeSinceLastDispatch
		{
			[Token(Token = "0x6001E64")]
			[Address(RVA = "0x64ACF0", Offset = "0x649EF0", VA = "0x18064ACF0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001E65")]
			[Address(RVA = "0x64AE30", Offset = "0x64A030", VA = "0x18064AE30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001E66 RID: 7782 RVA: 0x0000ADA0 File Offset: 0x00008FA0
		[Token(Token = "0x17000579")]
		private int deployedVehicleCount
		{
			[Token(Token = "0x6001E66")]
			[Address(RVA = "0x64AD00", Offset = "0x649F00", VA = "0x18064AD00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E67")]
		[Address(RVA = "0x649960", Offset = "0x648B60", VA = "0x180649960", Slot = "7")]
		protected override void Awake()
		{
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E68")]
		[Address(RVA = "0x64A860", Offset = "0x649A60", VA = "0x18064A860")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E69")]
		[Address(RVA = "0x64AB50", Offset = "0x649D50", VA = "0x18064AB50")]
		private void Update()
		{
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E6A")]
		[Address(RVA = "0x649AC0", Offset = "0x648CC0", VA = "0x180649AC0")]
		private void CleanVehicleList()
		{
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E6B")]
		[Address(RVA = "0x649FC0", Offset = "0x6491C0", VA = "0x180649FC0")]
		public void Dispatch(int requestedOfficerCount, Player targetPlayer, PoliceStation.EDispatchType type = PoliceStation.EDispatchType.Auto, bool beginAsSighted = false)
		{
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001E6C")]
		[Address(RVA = "0x64A930", Offset = "0x649B30", VA = "0x18064A930")]
		public PoliceOfficer PullOfficer()
		{
			return null;
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001E6D")]
		[Address(RVA = "0x649BC0", Offset = "0x648DC0", VA = "0x180649BC0")]
		public LandVehicle CreateVehicle()
		{
			return null;
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E6E")]
		[Address(RVA = "0x64A650", Offset = "0x649850", VA = "0x18064A650", Slot = "8")]
		public override void NPCEnteredBuilding(NPC npc, StaticDoor door)
		{
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E6F")]
		[Address(RVA = "0x64A790", Offset = "0x649990", VA = "0x18064A790", Slot = "9")]
		public override void NPCExitedBuilding(NPC npc, StaticDoor door)
		{
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001E70")]
		[Address(RVA = "0x64A5D0", Offset = "0x6497D0", VA = "0x18064A5D0")]
		public static PoliceStation GetClosestPoliceStation(Vector3 point)
		{
			return null;
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E71")]
		[Address(RVA = "0x64AC20", Offset = "0x649E20", VA = "0x18064AC20")]
		public PoliceStation()
		{
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x0000ADB8 File Offset: 0x00008FB8
		[Token(Token = "0x6001E73")]
		[Address(RVA = "0x64A9F0", Offset = "0x649BF0", VA = "0x18064A9F0")]
		[CompilerGenerated]
		internal static bool <CreateVehicle>g__IsSpawnPointAvailable|21_0(Transform spawnPoint)
		{
			return default(bool);
		}

		// Token: 0x0400197A RID: 6522
		[Token(Token = "0x400197A")]
		[FieldOffset(Offset = "0x0")]
		public static List<PoliceStation> PoliceStations;

		// Token: 0x0400197B RID: 6523
		[Token(Token = "0x400197B")]
		[FieldOffset(Offset = "0x50")]
		public int VehicleLimit;

		// Token: 0x0400197C RID: 6524
		[Token(Token = "0x400197C")]
		[FieldOffset(Offset = "0x58")]
		[Header("References")]
		public Transform SpawnPoint;

		// Token: 0x0400197D RID: 6525
		[Token(Token = "0x400197D")]
		[FieldOffset(Offset = "0x60")]
		public Transform[] VehicleSpawnPoints;

		// Token: 0x0400197E RID: 6526
		[Token(Token = "0x400197E")]
		[FieldOffset(Offset = "0x68")]
		public Transform[] PossessedVehicleSpawnPoints;

		// Token: 0x0400197F RID: 6527
		[Token(Token = "0x400197F")]
		[FieldOffset(Offset = "0x70")]
		[Header("Prefabs")]
		public LandVehicle[] PoliceVehiclePrefabs;

		// Token: 0x04001980 RID: 6528
		[Token(Token = "0x4001980")]
		[FieldOffset(Offset = "0x78")]
		public List<PoliceOfficer> OfficerPool;

		// Token: 0x04001982 RID: 6530
		[Token(Token = "0x4001982")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private List<LandVehicle> deployedVehicles;

		// Token: 0x02000554 RID: 1364
		[Token(Token = "0x2000554")]
		public enum EDispatchType
		{
			// Token: 0x04001984 RID: 6532
			[Token(Token = "0x4001984")]
			Auto,
			// Token: 0x04001985 RID: 6533
			[Token(Token = "0x4001985")]
			UseVehicle,
			// Token: 0x04001986 RID: 6534
			[Token(Token = "0x4001986")]
			OnFoot
		}
	}
}
