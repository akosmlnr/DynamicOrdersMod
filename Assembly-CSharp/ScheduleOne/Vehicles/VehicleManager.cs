using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020002A7 RID: 679
	[Token(Token = "0x20002A7")]
	public class VehicleManager : NetworkSingleton<VehicleManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06001002 RID: 4098 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700036E")]
		public string SaveFolderName
		{
			[Token(Token = "0x6001002")]
			[Address(RVA = "0xB15C70", Offset = "0xB14E70", VA = "0x180B15C70", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06001003 RID: 4099 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700036F")]
		public string SaveFileName
		{
			[Token(Token = "0x6001003")]
			[Address(RVA = "0xB15C40", Offset = "0xB14E40", VA = "0x180B15C40", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06001004 RID: 4100 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000370")]
		public Loader Loader
		{
			[Token(Token = "0x6001004")]
			[Address(RVA = "0x57F810", Offset = "0x57EA10", VA = "0x18057F810", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06001005 RID: 4101 RVA: 0x00007A28 File Offset: 0x00005C28
		[Token(Token = "0x17000371")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6001005")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001006 RID: 4102 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001007 RID: 4103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000372")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6001006")]
			[Address(RVA = "0x57F820", Offset = "0x57EA20", VA = "0x18057F820", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001007")]
			[Address(RVA = "0x57F870", Offset = "0x57EA70", VA = "0x18057F870", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001008 RID: 4104 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001009 RID: 4105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000373")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6001008")]
			[Address(RVA = "0x6BCCA0", Offset = "0x6BBEA0", VA = "0x1806BCCA0", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001009")]
			[Address(RVA = "0x6BCD20", Offset = "0x6BBF20", VA = "0x1806BCD20", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x0600100A RID: 4106 RVA: 0x00007A40 File Offset: 0x00005C40
		// (set) Token: 0x0600100B RID: 4107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000374")]
		public bool HasChanged
		{
			[Token(Token = "0x600100A")]
			[Address(RVA = "0x6BCC80", Offset = "0x6BBE80", VA = "0x1806BCC80", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600100B")]
			[Address(RVA = "0x6BCD10", Offset = "0x6BBF10", VA = "0x1806BCD10", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x0600100C RID: 4108 RVA: 0x00007A58 File Offset: 0x00005C58
		[Token(Token = "0x17000375")]
		public int LoadOrder
		{
			[Token(Token = "0x600100C")]
			[Address(RVA = "0x6BCC90", Offset = "0x6BBE90", VA = "0x1806BCC90", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600100D")]
		[Address(RVA = "0xB14510", Offset = "0xB13710", VA = "0x180B14510", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600100E")]
		[Address(RVA = "0xB15A40", Offset = "0xB14C40", VA = "0x180B15A40", Slot = "19")]
		protected override void Start()
		{
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600100F")]
		[Address(RVA = "0xB149A0", Offset = "0xB13BA0", VA = "0x180B149A0", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001010")]
		[Address(RVA = "0xB159F0", Offset = "0xB14BF0", VA = "0x180B159F0")]
		[ServerRpc(RequireOwnership = false)]
		public void SpawnVehicle(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned)
		{
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001011")]
		[Address(RVA = "0xB15450", Offset = "0xB14650", VA = "0x180B15450")]
		public LandVehicle SpawnAndReturnVehicle(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned)
		{
			return null;
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001012")]
		[Address(RVA = "0xB148C0", Offset = "0xB13AC0", VA = "0x180B148C0")]
		public LandVehicle GetVehiclePrefab(string vehicleCode)
		{
			return null;
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001013")]
		[Address(RVA = "0xB153B0", Offset = "0xB145B0", VA = "0x180B153B0")]
		public LandVehicle SpawnAndLoadVehicle(VehicleData data, string path, bool playerOwned)
		{
			return null;
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001014")]
		[Address(RVA = "0xB14A30", Offset = "0xB13C30", VA = "0x180B14A30")]
		public void LoadVehicle(VehicleData data, string path)
		{
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001015")]
		[Address(RVA = "0xB146D0", Offset = "0xB138D0", VA = "0x180B146D0", Slot = "50")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001016")]
		[Address(RVA = "0xB157E0", Offset = "0xB149E0", VA = "0x180B157E0")]
		public void SpawnLoanSharkVehicle(Vector3 position, Quaternion rot)
		{
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001017")]
		[Address(RVA = "0xB14590", Offset = "0xB13790", VA = "0x180B14590")]
		[ObserversRpc(RunLocally = true)]
		private void EnableLoanSharkVisuals(NetworkObject veh)
		{
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001018")]
		[Address(RVA = "0xB15A80", Offset = "0xB14C80", VA = "0x180B15A80")]
		public VehicleManager()
		{
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001019")]
		[Address(RVA = "0xB14BF0", Offset = "0xB13DF0", VA = "0x180B14BF0", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600101A")]
		[Address(RVA = "0xB14BA0", Offset = "0xB13DA0", VA = "0x180B14BA0", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600101B")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600101C")]
		[Address(RVA = "0xB15100", Offset = "0xB14300", VA = "0x180B15100")]
		private void RpcWriter___Server_SpawnVehicle_3323115898(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned)
		{
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600101D")]
		[Address(RVA = "0xB14DC0", Offset = "0xB13FC0", VA = "0x180B14DC0")]
		public void RpcLogic___SpawnVehicle_3323115898(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned)
		{
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600101E")]
		[Address(RVA = "0xB14E80", Offset = "0xB14080", VA = "0x180B14E80")]
		private void RpcReader___Server_SpawnVehicle_3323115898(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600101F")]
		[Address(RVA = "0xB14FC0", Offset = "0xB141C0", VA = "0x180B14FC0")]
		private void RpcWriter___Observers_EnableLoanSharkVisuals_3323014238(NetworkObject veh)
		{
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001020")]
		[Address(RVA = "0xB14CF0", Offset = "0xB13EF0", VA = "0x180B14CF0")]
		private void RpcLogic___EnableLoanSharkVisuals_3323014238(NetworkObject veh)
		{
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001021")]
		[Address(RVA = "0xB14E10", Offset = "0xB14010", VA = "0x180B14E10")]
		private void RpcReader___Observers_EnableLoanSharkVisuals_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001022")]
		[Address(RVA = "0xB144C0", Offset = "0xB136C0", VA = "0x180B144C0", Slot = "51")]
		protected virtual void Awake_UserLogic_ScheduleOne.Vehicles.VehicleManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04000E4F RID: 3663
		[Token(Token = "0x4000E4F")]
		[FieldOffset(Offset = "0x120")]
		public List<LandVehicle> AllVehicles;

		// Token: 0x04000E50 RID: 3664
		[Token(Token = "0x4000E50")]
		[FieldOffset(Offset = "0x128")]
		[Header("Vehicles")]
		public List<LandVehicle> VehiclePrefabs;

		// Token: 0x04000E51 RID: 3665
		[Token(Token = "0x4000E51")]
		[FieldOffset(Offset = "0x130")]
		public List<LandVehicle> PlayerOwnedVehicles;

		// Token: 0x04000E52 RID: 3666
		[Token(Token = "0x4000E52")]
		[FieldOffset(Offset = "0x138")]
		private VehiclesLoader loader;

		// Token: 0x04000E57 RID: 3671
		[Token(Token = "0x4000E57")]
		[FieldOffset(Offset = "0x158")]
		private bool NetworkInitialize___EarlyScheduleOne.Vehicles.VehicleManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04000E58 RID: 3672
		[Token(Token = "0x4000E58")]
		[FieldOffset(Offset = "0x159")]
		private bool NetworkInitialize__LateScheduleOne.Vehicles.VehicleManagerAssembly-CSharp.dll_Excuted;
	}
}
