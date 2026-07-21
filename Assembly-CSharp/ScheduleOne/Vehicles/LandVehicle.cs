using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Component.Ownership;
using FishNet.Component.Transforming;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using Pathfinding;
using ScheduleOne.Combat;
using ScheduleOne.DevUtilities;
using ScheduleOne.Graffiti;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Map;
using ScheduleOne.Money;
using ScheduleOne.NPCs;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Storage;
using ScheduleOne.Tools;
using ScheduleOne.Vehicles.AI;
using ScheduleOne.Vehicles.Modification;
using ScheduleOne.Weather;
using UnityEngine;
using UnityEngine.AI;

namespace ScheduleOne.Vehicles
{
	// Token: 0x02000297 RID: 663
	[Token(Token = "0x2000297")]
	[RequireComponent(typeof(NetworkTransform))]
	[RequireComponent(typeof(PhysicsDamageable))]
	[RequireComponent(typeof(PredictedOwner))]
	public class LandVehicle : NetworkBehaviour, IGUIDRegisterable, ISaveable, IWeatherEntity
	{
		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700033B")]
		public string VehicleName
		{
			[Token(Token = "0x6000ED6")]
			[Address(RVA = "0x58D0A0", Offset = "0x58C2A0", VA = "0x18058D0A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700033C")]
		public string VehicleCode
		{
			[Token(Token = "0x6000ED7")]
			[Address(RVA = "0x521AC0", Offset = "0x520CC0", VA = "0x180521AC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000ED8 RID: 3800 RVA: 0x00007560 File Offset: 0x00005760
		[Token(Token = "0x1700033D")]
		public float VehiclePrice
		{
			[Token(Token = "0x6000ED8")]
			[Address(RVA = "0x6288E0", Offset = "0x627AE0", VA = "0x1806288E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000ED9 RID: 3801 RVA: 0x00007578 File Offset: 0x00005778
		// (set) Token: 0x06000EDA RID: 3802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700033E")]
		public bool IsPlayerOwned
		{
			[Token(Token = "0x6000ED9")]
			[Address(RVA = "0xAF64F0", Offset = "0xAF56F0", VA = "0x180AF64F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000EDA")]
			[Address(RVA = "0xAF6B20", Offset = "0xAF5D20", VA = "0x180AF6B20")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000EDB RID: 3803 RVA: 0x00007590 File Offset: 0x00005790
		// (set) Token: 0x06000EDC RID: 3804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700033F")]
		public bool IsVisible
		{
			[Token(Token = "0x6000EDB")]
			[Address(RVA = "0xAF6520", Offset = "0xAF5720", VA = "0x180AF6520")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000EDC")]
			[Address(RVA = "0xAF6B40", Offset = "0xAF5D40", VA = "0x180AF6B40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000EDD RID: 3805 RVA: 0x000075A8 File Offset: 0x000057A8
		// (set) Token: 0x06000EDE RID: 3806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000340")]
		public Guid GUID
		{
			[Token(Token = "0x6000EDD")]
			[Address(RVA = "0xAF64A0", Offset = "0xAF56A0", VA = "0x180AF64A0", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6000EDE")]
			[Address(RVA = "0xAF6A90", Offset = "0xAF5C90", VA = "0x180AF6A90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000EDF RID: 3807 RVA: 0x000075C0 File Offset: 0x000057C0
		[Token(Token = "0x17000341")]
		public Vector3 BoundingBoxDimensions
		{
			[Token(Token = "0x6000EDF")]
			[Address(RVA = "0xAF6120", Offset = "0xAF5320", VA = "0x180AF6120")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000342")]
		public Transform driverEntryPoint
		{
			[Token(Token = "0x6000EE0")]
			[Address(RVA = "0xAF6910", Offset = "0xAF5B10", VA = "0x180AF6910")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000EE1 RID: 3809 RVA: 0x000075D8 File Offset: 0x000057D8
		[Token(Token = "0x17000343")]
		public float ActualMaxSteeringAngle
		{
			[Token(Token = "0x6000EE1")]
			[Address(RVA = "0xAF6100", Offset = "0xAF5300", VA = "0x180AF6100")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000EE2 RID: 3810 RVA: 0x000075F0 File Offset: 0x000057F0
		// (set) Token: 0x06000EE3 RID: 3811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000344")]
		public bool MaxSteerAngleOverridden
		{
			[Token(Token = "0x6000EE2")]
			[Address(RVA = "0xAF6550", Offset = "0xAF5750", VA = "0x180AF6550")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000EE3")]
			[Address(RVA = "0xAF6B70", Offset = "0xAF5D70", VA = "0x180AF6B70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000EE4 RID: 3812 RVA: 0x00007608 File Offset: 0x00005808
		// (set) Token: 0x06000EE5 RID: 3813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000345")]
		public float OverriddenMaxSteerAngle
		{
			[Token(Token = "0x6000EE4")]
			[Address(RVA = "0x8036D0", Offset = "0x8028D0", VA = "0x1808036D0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000EE5")]
			[Address(RVA = "0x803850", Offset = "0x802A50", VA = "0x180803850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x00007620 File Offset: 0x00005820
		[Token(Token = "0x17000346")]
		public int Capacity
		{
			[Token(Token = "0x6000EE6")]
			[Address(RVA = "0xAF62B0", Offset = "0xAF54B0", VA = "0x180AF62B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x00007638 File Offset: 0x00005838
		[Token(Token = "0x17000347")]
		public int CurrentPlayerOccupancy
		{
			[Token(Token = "0x6000EE7")]
			[Address(RVA = "0xAF62D0", Offset = "0xAF54D0", VA = "0x180AF62D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x00007650 File Offset: 0x00005850
		// (set) Token: 0x06000EE9 RID: 3817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000348")]
		public bool LocalPlayerIsDriver
		{
			[Token(Token = "0x6000EE8")]
			[Address(RVA = "0xAF6530", Offset = "0xAF5730", VA = "0x180AF6530")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000EE9")]
			[Address(RVA = "0xAF6B50", Offset = "0xAF5D50", VA = "0x180AF6B50")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000EEA RID: 3818 RVA: 0x00007668 File Offset: 0x00005868
		// (set) Token: 0x06000EEB RID: 3819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000349")]
		public bool LocalPlayerIsInVehicle
		{
			[Token(Token = "0x6000EEA")]
			[Address(RVA = "0xAF6540", Offset = "0xAF5740", VA = "0x180AF6540")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000EEB")]
			[Address(RVA = "0xAF6B60", Offset = "0xAF5D60", VA = "0x180AF6B60")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000EEC RID: 3820 RVA: 0x00007680 File Offset: 0x00005880
		// (set) Token: 0x06000EED RID: 3821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700034A")]
		public bool IsOccupied
		{
			[Token(Token = "0x6000EEC")]
			[Address(RVA = "0xAF64D0", Offset = "0xAF56D0", VA = "0x180AF64D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000EED")]
			[Address(RVA = "0xAF6AC0", Offset = "0xAF5CC0", VA = "0x180AF6AC0")]
			set
			{
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000EEE RID: 3822 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700034B")]
		public Player DriverPlayer
		{
			[Token(Token = "0x6000EEE")]
			[Address(RVA = "0xAF63F0", Offset = "0xAF55F0", VA = "0x180AF63F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000EEF RID: 3823 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700034C")]
		public List<Player> OccupantPlayers
		{
			[Token(Token = "0x6000EEF")]
			[Address(RVA = "0xAF6560", Offset = "0xAF5760", VA = "0x180AF6560")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000EF0 RID: 3824 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000EF1 RID: 3825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700034D")]
		public NPC[] OccupantNPCs
		{
			[Token(Token = "0x6000EF0")]
			[Address(RVA = "0x8035F0", Offset = "0x8027F0", VA = "0x1808035F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EF1")]
			[Address(RVA = "0x8037D0", Offset = "0x8029D0", VA = "0x1808037D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000EF2 RID: 3826 RVA: 0x00007698 File Offset: 0x00005898
		// (set) Token: 0x06000EF3 RID: 3827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700034E")]
		public float Speed_Kmh
		{
			[Token(Token = "0x6000EF2")]
			[Address(RVA = "0xAF6840", Offset = "0xAF5A40", VA = "0x180AF6840")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000EF3")]
			[Address(RVA = "0xAF6B90", Offset = "0xAF5D90", VA = "0x180AF6B90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x000076B0 File Offset: 0x000058B0
		// (set) Token: 0x06000EF5 RID: 3829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700034F")]
		public bool IsPhysicallySimulated
		{
			[Token(Token = "0x6000EF4")]
			[Address(RVA = "0xAF64E0", Offset = "0xAF56E0", VA = "0x180AF64E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000EF5")]
			[Address(RVA = "0xAF6B10", Offset = "0xAF5D10", VA = "0x180AF6B10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x000076C8 File Offset: 0x000058C8
		// (set) Token: 0x06000EF7 RID: 3831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000350")]
		public float currentThrottle
		{
			[Token(Token = "0x6000EF6")]
			[Address(RVA = "0x66BB70", Offset = "0x66AD70", VA = "0x18066BB70")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000EF7")]
			[Address(RVA = "0x66C210", Offset = "0x66B410", VA = "0x18066C210")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x000076E0 File Offset: 0x000058E0
		// (set) Token: 0x06000EF9 RID: 3833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000351")]
		public float CurrentSteerAngle
		{
			[Token(Token = "0x6000EF8")]
			[Address(RVA = "0x8DD960", Offset = "0x8DCB60", VA = "0x1808DD960")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000EF9")]
			[Address(RVA = "0xAF6A00", Offset = "0xAF5C00", VA = "0x180AF6A00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000EFA RID: 3834 RVA: 0x000076F8 File Offset: 0x000058F8
		// (set) Token: 0x06000EFB RID: 3835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000352")]
		public bool BrakesApplied
		{
			[Token(Token = "0x6000EFA")]
			[Address(RVA = "0xAF62A0", Offset = "0xAF54A0", VA = "0x180AF62A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000EFB")]
			[Address(RVA = "0xAEFF00", Offset = "0xAEF100", VA = "0x180AEFF00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000EFC RID: 3836 RVA: 0x00007710 File Offset: 0x00005910
		// (set) Token: 0x06000EFD RID: 3837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000353")]
		public bool IsReversing
		{
			[Token(Token = "0x6000EFC")]
			[Address(RVA = "0xAF6500", Offset = "0xAF5700", VA = "0x180AF6500")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000EFD")]
			[Address(RVA = "0xAF0190", Offset = "0xAEF390", VA = "0x180AF0190")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000EFE RID: 3838 RVA: 0x00007728 File Offset: 0x00005928
		// (set) Token: 0x06000EFF RID: 3839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000354")]
		public bool HandbrakeApplied
		{
			[Token(Token = "0x6000EFE")]
			[Address(RVA = "0xAF64B0", Offset = "0xAF56B0", VA = "0x180AF64B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000EFF")]
			[Address(RVA = "0xAF6AA0", Offset = "0xAF5CA0", VA = "0x180AF6AA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x00007740 File Offset: 0x00005940
		[Token(Token = "0x17000355")]
		public float boundingBaseOffset
		{
			[Token(Token = "0x6000F00")]
			[Address(RVA = "0xAF6850", Offset = "0xAF5A50", VA = "0x180AF6850")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x00007758 File Offset: 0x00005958
		[Token(Token = "0x17000356")]
		private float timeSinceSpawn
		{
			[Token(Token = "0x6000F01")]
			[Address(RVA = "0xAF69E0", Offset = "0xAF5BE0", VA = "0x180AF69E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000F02 RID: 3842 RVA: 0x00007770 File Offset: 0x00005970
		[Token(Token = "0x17000357")]
		public float timeSinceLastOccupied
		{
			[Token(Token = "0x6000F02")]
			[Address(RVA = "0xAF69C0", Offset = "0xAF5BC0", VA = "0x180AF69C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000F03 RID: 3843 RVA: 0x00007788 File Offset: 0x00005988
		// (set) Token: 0x06000F04 RID: 3844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000358")]
		public EVehicleColor OwnedColor
		{
			[Token(Token = "0x6000F03")]
			[Address(RVA = "0xAF6770", Offset = "0xAF5970", VA = "0x180AF6770")]
			[CompilerGenerated]
			get
			{
				return EVehicleColor.Black;
			}
			[Token(Token = "0x6000F04")]
			[Address(RVA = "0xAF6B80", Offset = "0xAF5D80", VA = "0x180AF6B80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000F05 RID: 3845 RVA: 0x000077A0 File Offset: 0x000059A0
		[Token(Token = "0x17000359")]
		public bool isParked
		{
			[Token(Token = "0x6000F05")]
			[Address(RVA = "0xAF6960", Offset = "0xAF5B60", VA = "0x180AF6960")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000F06 RID: 3846 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000F07 RID: 3847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700035A")]
		public ParkingLot CurrentParkingLot
		{
			[Token(Token = "0x6000F06")]
			[Address(RVA = "0x803760", Offset = "0x802960", VA = "0x180803760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F07")]
			[Address(RVA = "0x835030", Offset = "0x834230", VA = "0x180835030")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000F08 RID: 3848 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000F09 RID: 3849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700035B")]
		public ParkingSpot CurrentParkingSpot
		{
			[Token(Token = "0x6000F08")]
			[Address(RVA = "0x803620", Offset = "0x802820", VA = "0x180803620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F09")]
			[Address(RVA = "0x803820", Offset = "0x802A20", VA = "0x180803820")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000F0A RID: 3850 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700035C")]
		public string SaveFolderName
		{
			[Token(Token = "0x6000F0A")]
			[Address(RVA = "0xAF67B0", Offset = "0xAF59B0", VA = "0x180AF67B0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000F0B RID: 3851 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700035D")]
		public string SaveFileName
		{
			[Token(Token = "0x6000F0B")]
			[Address(RVA = "0xAF6780", Offset = "0xAF5980", VA = "0x180AF6780", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000F0C RID: 3852 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700035E")]
		public Loader Loader
		{
			[Token(Token = "0x6000F0C")]
			[Address(RVA = "0x66B560", Offset = "0x66A760", VA = "0x18066B560", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000F0D RID: 3853 RVA: 0x000077B8 File Offset: 0x000059B8
		[Token(Token = "0x1700035F")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6000F0D")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000F0E RID: 3854 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000F0F RID: 3855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000360")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6000F0E")]
			[Address(RVA = "0x66B540", Offset = "0x66A740", VA = "0x18066B540", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F0F")]
			[Address(RVA = "0x66BD90", Offset = "0x66AF90", VA = "0x18066BD90", Slot = "27")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000F10 RID: 3856 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000F11 RID: 3857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000361")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6000F10")]
			[Address(RVA = "0x834F80", Offset = "0x834180", VA = "0x180834F80", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F11")]
			[Address(RVA = "0x8760A0", Offset = "0x8752A0", VA = "0x1808760A0", Slot = "29")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000F12 RID: 3858 RVA: 0x000077D0 File Offset: 0x000059D0
		// (set) Token: 0x06000F13 RID: 3859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000362")]
		public bool HasChanged
		{
			[Token(Token = "0x6000F12")]
			[Address(RVA = "0xAF64C0", Offset = "0xAF56C0", VA = "0x180AF64C0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000F13")]
			[Address(RVA = "0xAF6AB0", Offset = "0xAF5CB0", VA = "0x180AF6AB0", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000363")]
		private Transform ScheduleOne.Weather.IWeatherEntity.Transform
		{
			[Token(Token = "0x6000F14")]
			[Address(RVA = "0x4E0C70", Offset = "0x4DFE70", VA = "0x1804E0C70", Slot = "47")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000F15 RID: 3861 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000F16 RID: 3862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000364")]
		private string ScheduleOne.Weather.IWeatherEntity.WeatherVolume
		{
			[Token(Token = "0x6000F15")]
			[Address(RVA = "0x875F80", Offset = "0x875180", VA = "0x180875F80", Slot = "45")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F16")]
			[Address(RVA = "0x88BC80", Offset = "0x88AE80", VA = "0x18088BC80", Slot = "46")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000F17 RID: 3863 RVA: 0x000077E8 File Offset: 0x000059E8
		// (set) Token: 0x06000F18 RID: 3864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000365")]
		public bool IsUnderCover
		{
			[Token(Token = "0x6000F17")]
			[Address(RVA = "0xAF6510", Offset = "0xAF5710", VA = "0x180AF6510", Slot = "50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000F18")]
			[Address(RVA = "0xAF6B30", Offset = "0xAF5D30", VA = "0x180AF6B30", Slot = "51")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F19")]
		[Address(RVA = "0xAEB340", Offset = "0xAEA540", VA = "0x180AEB340", Slot = "52")]
		public virtual void Awake()
		{
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1A")]
		[Address(RVA = "0xAED9A0", Offset = "0xAECBA0", VA = "0x180AED9A0", Slot = "53")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1B")]
		[Address(RVA = "0xAEED50", Offset = "0xAEDF50", VA = "0x180AEED50", Slot = "6")]
		public override void OnStartServer()
		{
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1C")]
		[Address(RVA = "0xAEEB10", Offset = "0xAEDD10", VA = "0x180AEEB10", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1D")]
		[Address(RVA = "0xAEED20", Offset = "0xAEDF20", VA = "0x180AEED20", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1E")]
		[Address(RVA = "0xAF3050", Offset = "0xAF2250", VA = "0x180AF3050")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void SetIsPlayerOwned(NetworkConnection conn, bool playerOwned)
		{
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1F")]
		[Address(RVA = "0xAEF820", Offset = "0xAEEA20", VA = "0x180AEF820")]
		private void RefreshPoI()
		{
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F20")]
		[Address(RVA = "0xAF2D70", Offset = "0xAF1F70", VA = "0x180AF2D70", Slot = "21")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F21")]
		[Address(RVA = "0xAF40B0", Offset = "0xAF32B0", VA = "0x180AF40B0", Slot = "54")]
		protected virtual void Start()
		{
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F22")]
		[Address(RVA = "0xAEC390", Offset = "0xAEB590", VA = "0x180AEC390")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F23")]
		[Address(RVA = "0xAEE760", Offset = "0xAED960", VA = "0x180AEE760", Slot = "55")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F24")]
		[Address(RVA = "0xAED120", Offset = "0xAEC320", VA = "0x180AED120")]
		private void GetNetworth(MoneyManager.FloatContainer container)
		{
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F25")]
		[Address(RVA = "0xAF56B0", Offset = "0xAF48B0", VA = "0x180AF56B0", Slot = "56")]
		protected virtual void Update()
		{
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F26")]
		[Address(RVA = "0xAEC3E0", Offset = "0xAEB5E0", VA = "0x180AEC3E0", Slot = "57")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F27")]
		[Address(RVA = "0xAEDA80", Offset = "0xAECC80", VA = "0x180AEDA80")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F28")]
		[Address(RVA = "0xAF4DC0", Offset = "0xAF3FC0", VA = "0x180AF4DC0")]
		private void UpdateSpeedCalculation()
		{
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F29")]
		[Address(RVA = "0xAF47B0", Offset = "0xAF39B0", VA = "0x180AF47B0")]
		private void UpdateOutOfBounds()
		{
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F2A")]
		[Address(RVA = "0xAEE730", Offset = "0xAED930", VA = "0x180AEE730")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F2B")]
		[Address(RVA = "0xAF1EC0", Offset = "0xAF10C0", VA = "0x180AF1EC0", Slot = "58")]
		[ServerRpc(RequireOwnership = false)]
		protected virtual void SetOwner(NetworkConnection conn)
		{
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F2C")]
		[Address(RVA = "0xAEE9F0", Offset = "0xAEDBF0", VA = "0x180AEE9F0", Slot = "59")]
		[ObserversRpc]
		protected virtual void OnOwnerChanged()
		{
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F2D")]
		[Address(RVA = "0xAF3C50", Offset = "0xAF2E50", VA = "0x180AF3C50")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetTransform_Server(Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F2E")]
		[Address(RVA = "0xAF3CE0", Offset = "0xAF2EE0", VA = "0x180AF3CE0")]
		[ObserversRpc(RunLocally = true)]
		public void SetTransform(Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F2F")]
		[Address(RVA = "0xAEB410", Offset = "0xAEA610", VA = "0x180AEB410")]
		public void DestroyVehicle()
		{
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F30")]
		[Address(RVA = "0xAF5400", Offset = "0xAF4600", VA = "0x180AF5400", Slot = "60")]
		protected virtual void UpdateThrottle()
		{
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F31")]
		[Address(RVA = "0xAEA640", Offset = "0xAE9840", VA = "0x180AEA640", Slot = "61")]
		protected virtual void ApplyThrottle()
		{
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F32")]
		[Address(RVA = "0xAEA4B0", Offset = "0xAE96B0", VA = "0x180AEA4B0")]
		private void ApplyDownForce()
		{
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F33")]
		[Address(RVA = "0xAF54D0", Offset = "0xAF46D0", VA = "0x180AF54D0")]
		private void UpdateTurnOver()
		{
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F34")]
		[Address(RVA = "0xAF4FB0", Offset = "0xAF41B0", VA = "0x180AF4FB0", Slot = "62")]
		protected virtual void UpdateSteerAngle()
		{
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F35")]
		[Address(RVA = "0xAF2160", Offset = "0xAF1360", VA = "0x180AF2160")]
		[ServerRpc(RequireOwnership = false)]
		private void SetSteeringAngle(float sa)
		{
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F36")]
		[Address(RVA = "0xAF2DE0", Offset = "0xAF1FE0", VA = "0x180AF2DE0")]
		private void SetIsBraking(bool braking)
		{
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F37")]
		[Address(RVA = "0xAF2F20", Offset = "0xAF2120", VA = "0x180AF2F20")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SetIsBreaking_Server(bool braking)
		{
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F38")]
		[Address(RVA = "0xAF33E0", Offset = "0xAF25E0", VA = "0x180AF33E0")]
		private void SetIsReversing(bool reversing)
		{
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F39")]
		[Address(RVA = "0xAF32B0", Offset = "0xAF24B0", VA = "0x180AF32B0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SetIsReversing_Server(bool reversing)
		{
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F3A")]
		[Address(RVA = "0xAEA5B0", Offset = "0xAE97B0", VA = "0x180AEA5B0", Slot = "63")]
		protected virtual void ApplySteerAngle()
		{
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F3B")]
		[Address(RVA = "0xAEA260", Offset = "0xAE9460", VA = "0x180AEA260")]
		public void AlignTo(Transform target, EParkingAlignment type, bool network = false)
		{
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F3C")]
		[Address(RVA = "0xAEC870", Offset = "0xAEBA70", VA = "0x180AEC870")]
		public Tuple<Vector3, Quaternion> GetAlignmentTransform(Transform target, EParkingAlignment type)
		{
			return null;
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x00007800 File Offset: 0x00005A00
		[Token(Token = "0x6000F3D")]
		[Address(RVA = "0x6288E0", Offset = "0x627AE0", VA = "0x1806288E0")]
		public float GetVehicleValue()
		{
			return 0f;
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F3E")]
		[Address(RVA = "0xAEEF00", Offset = "0xAEE100", VA = "0x180AEEF00")]
		public void OverrideMaxSteerAngle(float maxAngle)
		{
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F3F")]
		[Address(RVA = "0xAEFDA0", Offset = "0xAEEFA0", VA = "0x180AEFDA0")]
		public void ResetMaxSteerAngle()
		{
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F40")]
		[Address(RVA = "0xAF3520", Offset = "0xAF2720", VA = "0x180AF3520")]
		public void SetObstaclesActive(bool active)
		{
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F41")]
		[Address(RVA = "0xAF4B10", Offset = "0xAF3D10", VA = "0x180AF4B10")]
		private void UpdatePhysicallySimulated(bool forceApply = false)
		{
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x00007818 File Offset: 0x00005A18
		[Token(Token = "0x6000F42")]
		[Address(RVA = "0xAF3E90", Offset = "0xAF3090", VA = "0x180AF3E90")]
		private bool ShouldBePhysicallySimulated()
		{
			return default(bool);
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F43")]
		[Address(RVA = "0xAED060", Offset = "0xAEC260", VA = "0x180AED060")]
		public VehicleSeat GetFirstFreeSeat()
		{
			return null;
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F44")]
		[Address(RVA = "0xAF3990", Offset = "0xAF2B90", VA = "0x180AF3990")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetSeatOccupant(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F45")]
		[Address(RVA = "0xAF3820", Offset = "0xAF2A20", VA = "0x180AF3820")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SetSeatOccupant_Server(int seatIndex, NetworkConnection conn)
		{
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F46")]
		[Address(RVA = "0xAED8B0", Offset = "0xAECAB0", VA = "0x180AED8B0")]
		private void Hovered()
		{
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F47")]
		[Address(RVA = "0xAEDA30", Offset = "0xAECC30", VA = "0x180AEDA30")]
		private void Interacted()
		{
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F48")]
		[Address(RVA = "0xAF4080", Offset = "0xAF3280", VA = "0x180AF4080")]
		private void StartVehicle()
		{
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F49")]
		[Address(RVA = "0xAF4740", Offset = "0xAF3940", VA = "0x180AF4740")]
		private void StopVehicle()
		{
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F4A")]
		[Address(RVA = "0xAEB5D0", Offset = "0xAEA7D0", VA = "0x180AEB5D0")]
		private void EnterVehicle()
		{
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F4B")]
		[Address(RVA = "0xAEBF40", Offset = "0xAEB140", VA = "0x180AEBF40")]
		public void ExitVehicle()
		{
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F4C")]
		[Address(RVA = "0xAEB5C0", Offset = "0xAEA7C0", VA = "0x180AEB5C0")]
		private void EndJustExited()
		{
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F4D")]
		[Address(RVA = "0xAECFE0", Offset = "0xAEC1E0", VA = "0x180AECFE0")]
		public Transform GetExitPoint(int seatIndex = 0)
		{
			return null;
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F4E")]
		[Address(RVA = "0xAECC50", Offset = "0xAEBE50", VA = "0x180AECC50")]
		private Transform GetClosestExitPoint(Vector3 pos)
		{
			return null;
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F4F")]
		[Address(RVA = "0xAED310", Offset = "0xAEC510", VA = "0x180AED310")]
		private Transform GetValidExitPoint(List<Transform> possibleExitPoints)
		{
			return null;
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F50")]
		[Address(RVA = "0xAE9FD0", Offset = "0xAE91D0", VA = "0x180AE9FD0")]
		public void AddNPCOccupant(NPC npc)
		{
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F51")]
		[Address(RVA = "0xAEFB10", Offset = "0xAEED10", VA = "0x180AEFB10")]
		public void RemoveNPCOccupant(NPC npc)
		{
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x00007830 File Offset: 0x00005A30
		[Token(Token = "0x6000F52")]
		[Address(RVA = "0xAEB390", Offset = "0xAEA590", VA = "0x180AEB390", Slot = "64")]
		public virtual bool CanBeRecovered()
		{
			return default(bool);
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F53")]
		[Address(RVA = "0xAEF650", Offset = "0xAEE850", VA = "0x180AEF650", Slot = "65")]
		public virtual void RecoverVehicle()
		{
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F54")]
		[Address(RVA = "0xAF2C30", Offset = "0xAF1E30", VA = "0x180AF2C30")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendOwnedColor(EVehicleColor col)
		{
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F55")]
		[Address(RVA = "0xAF35A0", Offset = "0xAF27A0", VA = "0x180AF35A0", Slot = "66")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		protected virtual void SetOwnedColor(NetworkConnection conn, EVehicleColor col)
		{
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F56")]
		[Address(RVA = "0xAEA480", Offset = "0xAE9680", VA = "0x180AEA480")]
		public void ApplyColor(EVehicleColor col)
		{
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F57")]
		[Address(RVA = "0xAEA570", Offset = "0xAE9770", VA = "0x180AEA570")]
		public void ApplyOwnedColor()
		{
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F58")]
		[Address(RVA = "0xAEEF10", Offset = "0xAEE110", VA = "0x180AEEF10")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void Park_Networked(NetworkConnection conn, ParkData parkData)
		{
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F59")]
		[Address(RVA = "0xAEF180", Offset = "0xAEE380", VA = "0x180AEF180")]
		public void Park(NetworkConnection conn, ParkData parkData, bool network)
		{
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F5A")]
		[Address(RVA = "0xAEBB60", Offset = "0xAEAD60", VA = "0x180AEBB60")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void ExitPark_Networked(NetworkConnection conn, bool moveToExitPoint = true)
		{
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F5B")]
		[Address(RVA = "0xAEBDC0", Offset = "0xAEAFC0", VA = "0x180AEBDC0")]
		public void ExitPark(bool moveToExitPoint = true)
		{
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F5C")]
		[Address(RVA = "0xAF3DE0", Offset = "0xAF2FE0", VA = "0x180AF3DE0")]
		public void SetVisible(bool vis)
		{
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F5D")]
		[Address(RVA = "0xAEFA30", Offset = "0xAEEC30", VA = "0x180AEFA30")]
		public void RegisterPusher(PlayerPusher pusher)
		{
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F5E")]
		[Address(RVA = "0xAEB3B0", Offset = "0xAEA5B0", VA = "0x180AEB3B0")]
		public void DeregisterPusher(PlayerPusher pusher)
		{
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F5F")]
		[Address(RVA = "0xAECF00", Offset = "0xAEC100", VA = "0x180AECF00")]
		public List<ItemInstance> GetContents()
		{
			return null;
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F60")]
		[Address(RVA = "0xAED530", Offset = "0xAEC730", VA = "0x180AED530", Slot = "67")]
		public virtual VehicleData GetVehicleData()
		{
			return null;
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F61")]
		[Address(RVA = "0xAED1A0", Offset = "0xAEC3A0", VA = "0x180AED1A0")]
		protected List<SpraySurfaceData> GetSpraySurfaceData()
		{
			return null;
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F62")]
		[Address(RVA = "0xAED160", Offset = "0xAEC360", VA = "0x180AED160", Slot = "33")]
		public string GetSaveString()
		{
			return null;
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F63")]
		[Address(RVA = "0xAECE30", Offset = "0xAEC030", VA = "0x180AECE30")]
		private ItemSet GetContentsSet()
		{
			return null;
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F64")]
		[Address(RVA = "0xAEDA90", Offset = "0xAECC90", VA = "0x180AEDA90", Slot = "68")]
		public virtual void Load(VehicleData data, string containerPath)
		{
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F65")]
		[Address(RVA = "0xAEEDD0", Offset = "0xAEDFD0", VA = "0x180AEEDD0", Slot = "48")]
		public void OnWeatherChange(WeatherConditions newConditions)
		{
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F66")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "49")]
		public void OnUpdateWeatherEntity()
		{
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F67")]
		[Address(RVA = "0xAF58C0", Offset = "0xAF4AC0", VA = "0x180AF58C0")]
		public LandVehicle()
		{
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F68")]
		[Address(RVA = "0xAEDF70", Offset = "0xAED170", VA = "0x180AEDF70", Slot = "69")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F69")]
		[Address(RVA = "0xAEDEE0", Offset = "0xAED0E0", VA = "0x180AEDEE0", Slot = "70")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F6A")]
		[Address(RVA = "0xAEDEA0", Offset = "0xAED0A0", VA = "0x180AEDEA0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F6B")]
		[Address(RVA = "0xAF1470", Offset = "0xAF0670", VA = "0x180AF1470")]
		private void RpcWriter___Observers_SetIsPlayerOwned_214505783(NetworkConnection conn, bool playerOwned)
		{
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F6C")]
		[Address(RVA = "0xAEFF90", Offset = "0xAEF190", VA = "0x180AEFF90")]
		public void RpcLogic___SetIsPlayerOwned_214505783(NetworkConnection conn, bool playerOwned)
		{
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F6D")]
		[Address(RVA = "0xAF0860", Offset = "0xAEFA60", VA = "0x180AF0860")]
		private void RpcReader___Observers_SetIsPlayerOwned_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F6E")]
		[Address(RVA = "0xAF2800", Offset = "0xAF1A00", VA = "0x180AF2800")]
		private void RpcWriter___Target_SetIsPlayerOwned_214505783(NetworkConnection conn, bool playerOwned)
		{
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F6F")]
		[Address(RVA = "0xAF1060", Offset = "0xAF0260", VA = "0x180AF1060")]
		private void RpcReader___Target_SetIsPlayerOwned_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F70")]
		[Address(RVA = "0xAF1EC0", Offset = "0xAF10C0", VA = "0x180AF1EC0")]
		private void RpcWriter___Server_SetOwner_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F71")]
		[Address(RVA = "0xAF0270", Offset = "0xAEF470", VA = "0x180AF0270", Slot = "71")]
		protected virtual void RpcLogic___SetOwner_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F72")]
		[Address(RVA = "0xAF0D20", Offset = "0xAEFF20", VA = "0x180AF0D20")]
		private void RpcReader___Server_SetOwner_328543758(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F73")]
		[Address(RVA = "0xAEE9F0", Offset = "0xAEDBF0", VA = "0x180AEE9F0")]
		private void RpcWriter___Observers_OnOwnerChanged_2166136261()
		{
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F74")]
		[Address(RVA = "0xAEFDC0", Offset = "0xAEEFC0", VA = "0x180AEFDC0", Slot = "72")]
		protected virtual void RpcLogic___OnOwnerChanged_2166136261()
		{
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F75")]
		[Address(RVA = "0xAF06F0", Offset = "0xAEF8F0", VA = "0x180AF06F0")]
		private void RpcReader___Observers_OnOwnerChanged_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F76")]
		[Address(RVA = "0xAF22A0", Offset = "0xAF14A0", VA = "0x180AF22A0")]
		private void RpcWriter___Server_SetTransform_Server_3848837105(Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F77")]
		[Address(RVA = "0xAF0630", Offset = "0xAEF830", VA = "0x180AF0630")]
		public void RpcLogic___SetTransform_Server_3848837105(Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F78")]
		[Address(RVA = "0xAF0E90", Offset = "0xAF0090", VA = "0x180AF0E90")]
		private void RpcReader___Server_SetTransform_Server_3848837105(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F79")]
		[Address(RVA = "0xAF1870", Offset = "0xAF0A70", VA = "0x180AF1870")]
		private void RpcWriter___Observers_SetTransform_3848837105(Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F7A")]
		[Address(RVA = "0xAF0550", Offset = "0xAEF750", VA = "0x180AF0550")]
		public void RpcLogic___SetTransform_3848837105(Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F7B")]
		[Address(RVA = "0xAF09F0", Offset = "0xAEFBF0", VA = "0x180AF09F0")]
		private void RpcReader___Observers_SetTransform_3848837105(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F7C")]
		[Address(RVA = "0xAF2160", Offset = "0xAF1360", VA = "0x180AF2160")]
		private void RpcWriter___Server_SetSteeringAngle_431000436(float sa)
		{
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F7D")]
		[Address(RVA = "0xAF0540", Offset = "0xAEF740", VA = "0x180AF0540")]
		private void RpcLogic___SetSteeringAngle_431000436(float sa)
		{
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F7E")]
		[Address(RVA = "0xAF0E30", Offset = "0xAF0030", VA = "0x180AF0E30")]
		private void RpcReader___Server_SetSteeringAngle_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F7F")]
		[Address(RVA = "0xAF1C60", Offset = "0xAF0E60", VA = "0x180AF1C60")]
		private void RpcWriter___Server_SetIsBreaking_Server_1140765316(bool braking)
		{
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F80")]
		[Address(RVA = "0xAEFF00", Offset = "0xAEF100", VA = "0x180AEFF00")]
		private void RpcLogic___SetIsBreaking_Server_1140765316(bool braking)
		{
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F81")]
		[Address(RVA = "0xAF0C00", Offset = "0xAEFE00", VA = "0x180AF0C00")]
		private void RpcReader___Server_SetIsBreaking_Server_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F82")]
		[Address(RVA = "0xAF1D90", Offset = "0xAF0F90", VA = "0x180AF1D90")]
		private void RpcWriter___Server_SetIsReversing_Server_1140765316(bool reversing)
		{
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F83")]
		[Address(RVA = "0xAF0190", Offset = "0xAEF390", VA = "0x180AF0190")]
		private void RpcLogic___SetIsReversing_Server_1140765316(bool reversing)
		{
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F84")]
		[Address(RVA = "0xAF0C90", Offset = "0xAEFE90", VA = "0x180AF0C90")]
		private void RpcReader___Server_SetIsReversing_Server_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F85")]
		[Address(RVA = "0xAF16F0", Offset = "0xAF08F0", VA = "0x180AF16F0")]
		private void RpcWriter___Observers_SetSeatOccupant_3428404692(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F86")]
		[Address(RVA = "0xAF02B0", Offset = "0xAEF4B0", VA = "0x180AF02B0")]
		private void RpcLogic___SetSeatOccupant_3428404692(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F87")]
		[Address(RVA = "0xAF0960", Offset = "0xAEFB60", VA = "0x180AF0960")]
		private void RpcReader___Observers_SetSeatOccupant_3428404692(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F88")]
		[Address(RVA = "0xAF2AC0", Offset = "0xAF1CC0", VA = "0x180AF2AC0")]
		private void RpcWriter___Target_SetSeatOccupant_3428404692(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F89")]
		[Address(RVA = "0xAF1160", Offset = "0xAF0360", VA = "0x180AF1160")]
		private void RpcReader___Target_SetSeatOccupant_3428404692(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F8A")]
		[Address(RVA = "0xAF1FF0", Offset = "0xAF11F0", VA = "0x180AF1FF0")]
		private void RpcWriter___Server_SetSeatOccupant_Server_3266232555(int seatIndex, NetworkConnection conn)
		{
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F8B")]
		[Address(RVA = "0xAF0520", Offset = "0xAEF720", VA = "0x180AF0520")]
		private void RpcLogic___SetSeatOccupant_Server_3266232555(int seatIndex, NetworkConnection conn)
		{
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F8C")]
		[Address(RVA = "0xAF0D90", Offset = "0xAEFF90", VA = "0x180AF0D90")]
		private void RpcReader___Server_SetSeatOccupant_Server_3266232555(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F8D")]
		[Address(RVA = "0xAF1B30", Offset = "0xAF0D30", VA = "0x180AF1B30")]
		private void RpcWriter___Server_SendOwnedColor_911055161(EVehicleColor col)
		{
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F8E")]
		[Address(RVA = "0xAEFEE0", Offset = "0xAEF0E0", VA = "0x180AEFEE0")]
		public void RpcLogic___SendOwnedColor_911055161(EVehicleColor col)
		{
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F8F")]
		[Address(RVA = "0xAF0B80", Offset = "0xAEFD80", VA = "0x180AF0B80")]
		private void RpcReader___Server_SendOwnedColor_911055161(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F90")]
		[Address(RVA = "0xAF2960", Offset = "0xAF1B60", VA = "0x180AF2960")]
		private void RpcWriter___Target_SetOwnedColor_1679996372(NetworkConnection conn, EVehicleColor col)
		{
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F91")]
		[Address(RVA = "0xAF0220", Offset = "0xAEF420", VA = "0x180AF0220", Slot = "73")]
		protected virtual void RpcLogic___SetOwnedColor_1679996372(NetworkConnection conn, EVehicleColor col)
		{
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F92")]
		[Address(RVA = "0xAF10E0", Offset = "0xAF02E0", VA = "0x180AF10E0")]
		private void RpcReader___Target_SetOwnedColor_1679996372(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F93")]
		[Address(RVA = "0xAF15B0", Offset = "0xAF07B0", VA = "0x180AF15B0")]
		private void RpcWriter___Observers_SetOwnedColor_1679996372(NetworkConnection conn, EVehicleColor col)
		{
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F94")]
		[Address(RVA = "0xAF08E0", Offset = "0xAEFAE0", VA = "0x180AF08E0")]
		private void RpcReader___Observers_SetOwnedColor_1679996372(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F95")]
		[Address(RVA = "0xAF1330", Offset = "0xAF0530", VA = "0x180AF1330")]
		private void RpcWriter___Observers_Park_Networked_2633993806(NetworkConnection conn, ParkData parkData)
		{
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F96")]
		[Address(RVA = "0xAEFEC0", Offset = "0xAEF0C0", VA = "0x180AEFEC0")]
		private void RpcLogic___Park_Networked_2633993806(NetworkConnection conn, ParkData parkData)
		{
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F97")]
		[Address(RVA = "0xAF0800", Offset = "0xAEFA00", VA = "0x180AF0800")]
		private void RpcReader___Observers_Park_Networked_2633993806(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F98")]
		[Address(RVA = "0xAF26A0", Offset = "0xAF18A0", VA = "0x180AF26A0")]
		private void RpcWriter___Target_Park_Networked_2633993806(NetworkConnection conn, ParkData parkData)
		{
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F99")]
		[Address(RVA = "0xAF1000", Offset = "0xAF0200", VA = "0x180AF1000")]
		private void RpcReader___Target_Park_Networked_2633993806(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F9A")]
		[Address(RVA = "0xAF11F0", Offset = "0xAF03F0", VA = "0x180AF11F0")]
		private void RpcWriter___Observers_ExitPark_Networked_214505783(NetworkConnection conn, bool moveToExitPoint = true)
		{
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F9B")]
		[Address(RVA = "0xAEFDB0", Offset = "0xAEEFB0", VA = "0x180AEFDB0")]
		public void RpcLogic___ExitPark_Networked_214505783(NetworkConnection conn, bool moveToExitPoint = true)
		{
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F9C")]
		[Address(RVA = "0xAF0670", Offset = "0xAEF870", VA = "0x180AF0670")]
		private void RpcReader___Observers_ExitPark_Networked_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F9D")]
		[Address(RVA = "0xAF2540", Offset = "0xAF1740", VA = "0x180AF2540")]
		private void RpcWriter___Target_ExitPark_Networked_214505783(NetworkConnection conn, bool moveToExitPoint = true)
		{
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F9E")]
		[Address(RVA = "0xAF0F90", Offset = "0xAF0190", VA = "0x180AF0F90")]
		private void RpcReader___Target_ExitPark_Networked_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000F9F RID: 3999 RVA: 0x00007848 File Offset: 0x00005A48
		// (set) Token: 0x06000FA0 RID: 4000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000366")]
		public float SyncAccessor_<CurrentSteerAngle>k__BackingField
		{
			[Token(Token = "0x6000F9F")]
			[Address(RVA = "0x8DD960", Offset = "0x8DCB60", VA = "0x1808DD960")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000FA0")]
			[Address(RVA = "0xAF6C60", Offset = "0xAF5E60", VA = "0x180AF6C60")]
			set
			{
			}
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00007860 File Offset: 0x00005A60
		[Token(Token = "0x6000FA1")]
		[Address(RVA = "0xAEF430", Offset = "0xAEE630", VA = "0x180AEF430", Slot = "74")]
		public virtual bool ReadSyncVar___ScheduleOne.Vehicles.LandVehicle(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x00007878 File Offset: 0x00005A78
		// (set) Token: 0x06000FA3 RID: 4003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000367")]
		public bool SyncAccessor_<BrakesApplied>k__BackingField
		{
			[Token(Token = "0x6000FA2")]
			[Address(RVA = "0xAF62A0", Offset = "0xAF54A0", VA = "0x180AF62A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000FA3")]
			[Address(RVA = "0xAF6BA0", Offset = "0xAF5DA0", VA = "0x180AF6BA0")]
			set
			{
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x00007890 File Offset: 0x00005A90
		// (set) Token: 0x06000FA5 RID: 4005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000368")]
		public bool SyncAccessor_<IsReversing>k__BackingField
		{
			[Token(Token = "0x6000FA4")]
			[Address(RVA = "0xAF6500", Offset = "0xAF5700", VA = "0x180AF6500")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000FA5")]
			[Address(RVA = "0xAF6D20", Offset = "0xAF5F20", VA = "0x180AF6D20")]
			set
			{
			}
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FA6")]
		[Address(RVA = "0xAEAE40", Offset = "0xAEA040", VA = "0x180AEAE40", Slot = "75")]
		protected virtual void Awake_UserLogic_ScheduleOne.Vehicles.LandVehicle_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04000D93 RID: 3475
		[Token(Token = "0x4000D93")]
		public const float KINEMATIC_THRESHOLD_DISTANCE = 30f;

		// Token: 0x04000D94 RID: 3476
		[Token(Token = "0x4000D94")]
		public const float MAX_TURNOVER_SPEED = 5f;

		// Token: 0x04000D95 RID: 3477
		[Token(Token = "0x4000D95")]
		public const float TURNOVER_FORCE = 8f;

		// Token: 0x04000D96 RID: 3478
		[Token(Token = "0x4000D96")]
		public const bool USE_WHEEL = false;

		// Token: 0x04000D97 RID: 3479
		[Token(Token = "0x4000D97")]
		public const float SPEED_DISPLAY_MULTIPLIER = 1.4f;

		// Token: 0x04000D98 RID: 3480
		[Token(Token = "0x4000D98")]
		public const float MaxImpactDamage = 120f;

		// Token: 0x04000D99 RID: 3481
		[Token(Token = "0x4000D99")]
		public const float MaxImpactDamageSpeed = 100f;

		// Token: 0x04000D9A RID: 3482
		[Token(Token = "0x4000D9A")]
		[FieldOffset(Offset = "0x118")]
		public bool DEBUG;

		// Token: 0x04000D9B RID: 3483
		[Token(Token = "0x4000D9B")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Header("Settings")]
		protected string vehicleName;

		// Token: 0x04000D9C RID: 3484
		[Token(Token = "0x4000D9C")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		protected string vehicleCode;

		// Token: 0x04000D9D RID: 3485
		[Token(Token = "0x4000D9D")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		protected float vehiclePrice;

		// Token: 0x04000DA0 RID: 3488
		[Token(Token = "0x4000DA0")]
		[FieldOffset(Offset = "0x136")]
		public bool UseHumanoidCollider;

		// Token: 0x04000DA2 RID: 3490
		[Token(Token = "0x4000DA2")]
		[FieldOffset(Offset = "0x148")]
		public bool SpawnAsPlayerOwned;

		// Token: 0x04000DA3 RID: 3491
		[Token(Token = "0x4000DA3")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		[Header("References")]
		protected GameObject vehicleModel;

		// Token: 0x04000DA4 RID: 3492
		[Token(Token = "0x4000DA4")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		protected WheelCollider[] driveWheels;

		// Token: 0x04000DA5 RID: 3493
		[Token(Token = "0x4000DA5")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		protected WheelCollider[] steerWheels;

		// Token: 0x04000DA6 RID: 3494
		[Token(Token = "0x4000DA6")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		protected WheelCollider[] handbrakeWheels;

		// Token: 0x04000DA7 RID: 3495
		[Token(Token = "0x4000DA7")]
		[FieldOffset(Offset = "0x170")]
		[HideInInspector]
		public List<Wheel> wheels;

		// Token: 0x04000DA8 RID: 3496
		[Token(Token = "0x4000DA8")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		protected InteractableObject intObj;

		// Token: 0x04000DA9 RID: 3497
		[Token(Token = "0x4000DA9")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		protected List<Transform> exitPoints;

		// Token: 0x04000DAA RID: 3498
		[Token(Token = "0x4000DAA")]
		[FieldOffset(Offset = "0x188")]
		public Rigidbody Rb;

		// Token: 0x04000DAB RID: 3499
		[Token(Token = "0x4000DAB")]
		[FieldOffset(Offset = "0x190")]
		public VehicleColor Color;

		// Token: 0x04000DAC RID: 3500
		[Token(Token = "0x4000DAC")]
		[FieldOffset(Offset = "0x198")]
		public VehicleSeat[] Seats;

		// Token: 0x04000DAD RID: 3501
		[Token(Token = "0x4000DAD")]
		[FieldOffset(Offset = "0x1A0")]
		public BoxCollider boundingBox;

		// Token: 0x04000DAE RID: 3502
		[Token(Token = "0x4000DAE")]
		[FieldOffset(Offset = "0x1A8")]
		public VehicleAgent Agent;

		// Token: 0x04000DAF RID: 3503
		[Token(Token = "0x4000DAF")]
		[FieldOffset(Offset = "0x1B0")]
		public SmoothedVelocityCalculator VelocityCalculator;

		// Token: 0x04000DB0 RID: 3504
		[Token(Token = "0x4000DB0")]
		[FieldOffset(Offset = "0x1B8")]
		public StorageDoorAnimation Trunk;

		// Token: 0x04000DB1 RID: 3505
		[Token(Token = "0x4000DB1")]
		[FieldOffset(Offset = "0x1C0")]
		public NavMeshObstacle NavMeshObstacle;

		// Token: 0x04000DB2 RID: 3506
		[Token(Token = "0x4000DB2")]
		[FieldOffset(Offset = "0x1C8")]
		public NavmeshCut NavmeshCut;

		// Token: 0x04000DB3 RID: 3507
		[Token(Token = "0x4000DB3")]
		[FieldOffset(Offset = "0x1D0")]
		public VehicleHumanoidCollider HumanoidColliderContainer;

		// Token: 0x04000DB4 RID: 3508
		[Token(Token = "0x4000DB4")]
		[FieldOffset(Offset = "0x1D8")]
		public POI POI;

		// Token: 0x04000DB5 RID: 3509
		[Token(Token = "0x4000DB5")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		private SpraySurface[] _spraySurfaces;

		// Token: 0x04000DB6 RID: 3510
		[Token(Token = "0x4000DB6")]
		[FieldOffset(Offset = "0x1E8")]
		private List<PlayerPusher> pushers;

		// Token: 0x04000DB7 RID: 3511
		[Token(Token = "0x4000DB7")]
		[FieldOffset(Offset = "0x1F0")]
		[SerializeField]
		protected Transform centerOfMass;

		// Token: 0x04000DB8 RID: 3512
		[Token(Token = "0x4000DB8")]
		[FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		protected Transform cameraOrigin;

		// Token: 0x04000DB9 RID: 3513
		[Token(Token = "0x4000DB9")]
		[FieldOffset(Offset = "0x200")]
		[SerializeField]
		protected VehicleLights lights;

		// Token: 0x04000DBA RID: 3514
		[Token(Token = "0x4000DBA")]
		[FieldOffset(Offset = "0x208")]
		[SerializeField]
		[Header("Steer settings")]
		protected float maxSteeringAngle;

		// Token: 0x04000DBB RID: 3515
		[Token(Token = "0x4000DBB")]
		[FieldOffset(Offset = "0x20C")]
		[SerializeField]
		protected float steerRate;

		// Token: 0x04000DBC RID: 3516
		[Token(Token = "0x4000DBC")]
		[FieldOffset(Offset = "0x210")]
		[SerializeField]
		protected bool flipSteer;

		// Token: 0x04000DBF RID: 3519
		[Token(Token = "0x4000DBF")]
		[FieldOffset(Offset = "0x218")]
		[Header("Drive settings")]
		[SerializeField]
		protected AnimationCurve motorTorque;

		// Token: 0x04000DC0 RID: 3520
		[Token(Token = "0x4000DC0")]
		[FieldOffset(Offset = "0x220")]
		public float TopSpeed;

		// Token: 0x04000DC1 RID: 3521
		[Token(Token = "0x4000DC1")]
		[FieldOffset(Offset = "0x224")]
		[Range(2f, 16f)]
		[SerializeField]
		protected float diffGearing;

		// Token: 0x04000DC2 RID: 3522
		[Token(Token = "0x4000DC2")]
		[FieldOffset(Offset = "0x228")]
		[SerializeField]
		protected float handBrakeForce;

		// Token: 0x04000DC3 RID: 3523
		[Token(Token = "0x4000DC3")]
		[FieldOffset(Offset = "0x230")]
		[SerializeField]
		protected AnimationCurve brakeForce;

		// Token: 0x04000DC4 RID: 3524
		[Token(Token = "0x4000DC4")]
		[FieldOffset(Offset = "0x238")]
		[SerializeField]
		[Range(0.1f, 3f)]
		protected float BrakeForceMultiplier;

		// Token: 0x04000DC5 RID: 3525
		[Token(Token = "0x4000DC5")]
		[FieldOffset(Offset = "0x23C")]
		[Range(0.5f, 10f)]
		[SerializeField]
		protected float downforce;

		// Token: 0x04000DC6 RID: 3526
		[Token(Token = "0x4000DC6")]
		[FieldOffset(Offset = "0x240")]
		[Range(0f, 1f)]
		[SerializeField]
		protected float reverseMultiplier;

		// Token: 0x04000DC7 RID: 3527
		[Token(Token = "0x4000DC7")]
		[FieldOffset(Offset = "0x244")]
		[HideInInspector]
		public bool overrideControls;

		// Token: 0x04000DC8 RID: 3528
		[Token(Token = "0x4000DC8")]
		[FieldOffset(Offset = "0x248")]
		[HideInInspector]
		public float throttleOverride;

		// Token: 0x04000DC9 RID: 3529
		[Token(Token = "0x4000DC9")]
		[FieldOffset(Offset = "0x24C")]
		[HideInInspector]
		public float steerOverride;

		// Token: 0x04000DCA RID: 3530
		[Token(Token = "0x4000DCA")]
		[FieldOffset(Offset = "0x250")]
		[HideInInspector]
		public bool handbrakeOverride;

		// Token: 0x04000DCB RID: 3531
		[Token(Token = "0x4000DCB")]
		[FieldOffset(Offset = "0x258")]
		[Header("Storage settings")]
		public StorageEntity Storage;

		// Token: 0x04000DCC RID: 3532
		[Token(Token = "0x4000DCC")]
		[FieldOffset(Offset = "0x260")]
		private VehicleSeat localPlayerSeat;

		// Token: 0x04000DCF RID: 3535
		[Token(Token = "0x4000DCF")]
		[FieldOffset(Offset = "0x26A")]
		private bool _isOccupied;

		// Token: 0x04000DD3 RID: 3539
		[Token(Token = "0x4000DD3")]
		[FieldOffset(Offset = "0x280")]
		private RollingAverage<float> previousSpeeds;

		// Token: 0x04000DD4 RID: 3540
		[Token(Token = "0x4000DD4")]
		private const int previousSpeedsSampleSize = 20;

		// Token: 0x04000DD7 RID: 3543
		[Token(Token = "0x4000DD7")]
		[FieldOffset(Offset = "0x290")]
		private float lastFrameSteerAngle;

		// Token: 0x04000DD8 RID: 3544
		[Token(Token = "0x4000DD8")]
		[FieldOffset(Offset = "0x294")]
		private float lastReplicatedSteerAngle;

		// Token: 0x04000DD9 RID: 3545
		[Token(Token = "0x4000DD9")]
		[FieldOffset(Offset = "0x298")]
		private bool justExitedVehicle;

		// Token: 0x04000DDD RID: 3549
		[Token(Token = "0x4000DDD")]
		[FieldOffset(Offset = "0x29C")]
		private Vector3 lastFramePosition;

		// Token: 0x04000DDE RID: 3550
		[Token(Token = "0x4000DDE")]
		[FieldOffset(Offset = "0x2A8")]
		private Transform closestExitPoint;

		// Token: 0x04000DDF RID: 3551
		[Token(Token = "0x4000DDF")]
		[FieldOffset(Offset = "0x2B0")]
		private float timeOnSpawn;

		// Token: 0x04000DE0 RID: 3552
		[Token(Token = "0x4000DE0")]
		[FieldOffset(Offset = "0x2B4")]
		private float timeOnLastOccupied;

		// Token: 0x04000DE2 RID: 3554
		[Token(Token = "0x4000DE2")]
		[FieldOffset(Offset = "0x2C0")]
		[HideInInspector]
		public ParkData CurrentParkData;

		// Token: 0x04000DE5 RID: 3557
		[Token(Token = "0x4000DE5")]
		[FieldOffset(Offset = "0x2D8")]
		private VehicleLoader loader;

		// Token: 0x04000DE9 RID: 3561
		[Token(Token = "0x4000DE9")]
		[FieldOffset(Offset = "0x2F8")]
		public Action onVehicleStart;

		// Token: 0x04000DEA RID: 3562
		[Token(Token = "0x4000DEA")]
		[FieldOffset(Offset = "0x300")]
		public Action onVehicleStop;

		// Token: 0x04000DEB RID: 3563
		[Token(Token = "0x4000DEB")]
		[FieldOffset(Offset = "0x308")]
		public Action onHandbrakeApplied;

		// Token: 0x04000DEC RID: 3564
		[Token(Token = "0x4000DEC")]
		[FieldOffset(Offset = "0x310")]
		public Action<Collision> onCollision;

		// Token: 0x04000DEF RID: 3567
		[Token(Token = "0x4000DEF")]
		[FieldOffset(Offset = "0x328")]
		public SyncVar<float> syncVar___<CurrentSteerAngle>k__BackingField;

		// Token: 0x04000DF0 RID: 3568
		[Token(Token = "0x4000DF0")]
		[FieldOffset(Offset = "0x330")]
		public SyncVar<bool> syncVar___<BrakesApplied>k__BackingField;

		// Token: 0x04000DF1 RID: 3569
		[Token(Token = "0x4000DF1")]
		[FieldOffset(Offset = "0x338")]
		public SyncVar<bool> syncVar___<IsReversing>k__BackingField;

		// Token: 0x04000DF2 RID: 3570
		[Token(Token = "0x4000DF2")]
		[FieldOffset(Offset = "0x340")]
		private bool NetworkInitialize___EarlyScheduleOne.Vehicles.LandVehicleAssembly-CSharp.dll_Excuted;

		// Token: 0x04000DF3 RID: 3571
		[Token(Token = "0x4000DF3")]
		[FieldOffset(Offset = "0x341")]
		private bool NetworkInitialize__LateScheduleOne.Vehicles.LandVehicleAssembly-CSharp.dll_Excuted;
	}
}
