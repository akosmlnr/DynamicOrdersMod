using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Management;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Property;
using ScheduleOne.UI.Management;
using UnityEngine;

namespace ScheduleOne.Employees
{
	// Token: 0x0200066F RID: 1647
	[Token(Token = "0x200066F")]
	public class Chemist : Employee, IConfigurable
	{
		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x060029F0 RID: 10736 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700073A")]
		public EntityConfiguration Configuration
		{
			[Token(Token = "0x60029F0")]
			[Address(RVA = "0x6F63C0", Offset = "0x6F55C0", VA = "0x1806F63C0", Slot = "150")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060029F1 RID: 10737 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060029F2 RID: 10738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700073B")]
		protected ChemistConfiguration configuration
		{
			[Token(Token = "0x60029F1")]
			[Address(RVA = "0x6F63C0", Offset = "0x6F55C0", VA = "0x1806F63C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60029F2")]
			[Address(RVA = "0x6F63E0", Offset = "0x6F55E0", VA = "0x1806F63E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060029F3 RID: 10739 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700073C")]
		public ConfigurationReplicator ConfigReplicator
		{
			[Token(Token = "0x60029F3")]
			[Address(RVA = "0x6F2CD0", Offset = "0x6F1ED0", VA = "0x1806F2CD0", Slot = "151")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060029F4 RID: 10740 RVA: 0x0000D638 File Offset: 0x0000B838
		[Token(Token = "0x1700073D")]
		public EConfigurableType ConfigurableType
		{
			[Token(Token = "0x60029F4")]
			[Address(RVA = "0x6F63B0", Offset = "0x6F55B0", VA = "0x1806F63B0", Slot = "152")]
			get
			{
				return EConfigurableType.Pot;
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060029F5 RID: 10741 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060029F6 RID: 10742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700073E")]
		public WorldspaceUIElement WorldspaceUI
		{
			[Token(Token = "0x60029F5")]
			[Address(RVA = "0x6F2CE0", Offset = "0x6F1EE0", VA = "0x1806F2CE0", Slot = "153")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60029F6")]
			[Address(RVA = "0x6F2D60", Offset = "0x6F1F60", VA = "0x1806F2D60", Slot = "154")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060029F7 RID: 10743 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060029F8 RID: 10744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700073F")]
		public NetworkObject CurrentPlayerConfigurer
		{
			[Token(Token = "0x60029F7")]
			[Address(RVA = "0x6F2D30", Offset = "0x6F1F30", VA = "0x1806F2D30", Slot = "155")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60029F8")]
			[Address(RVA = "0x6F55A0", Offset = "0x6F47A0", VA = "0x1806F55A0", Slot = "156")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029F9")]
		[Address(RVA = "0x6F5950", Offset = "0x6F4B50", VA = "0x1806F5950", Slot = "170")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x060029FA RID: 10746 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000740")]
		public Sprite TypeIcon
		{
			[Token(Token = "0x60029FA")]
			[Address(RVA = "0x6F2D10", Offset = "0x6F1F10", VA = "0x1806F2D10", Slot = "158")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x060029FB RID: 10747 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000741")]
		public Transform Transform
		{
			[Token(Token = "0x60029FB")]
			[Address(RVA = "0x4E0C70", Offset = "0x4DFE70", VA = "0x1804E0C70", Slot = "159")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x060029FC RID: 10748 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000742")]
		public Transform UIPoint
		{
			[Token(Token = "0x60029FC")]
			[Address(RVA = "0x6F63D0", Offset = "0x6F55D0", VA = "0x1806F63D0", Slot = "160")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x060029FD RID: 10749 RVA: 0x0000D650 File Offset: 0x0000B850
		[Token(Token = "0x17000743")]
		public bool CanBeSelected
		{
			[Token(Token = "0x60029FD")]
			[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "162")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x060029FE RID: 10750 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000744")]
		public Property ParentProperty
		{
			[Token(Token = "0x60029FE")]
			[Address(RVA = "0x6F2D00", Offset = "0x6F1F00", VA = "0x1806F2D00", Slot = "163")]
			get
			{
				return null;
			}
		}

		// Token: 0x060029FF RID: 10751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029FF")]
		[Address(RVA = "0x6F2E40", Offset = "0x6F2040", VA = "0x1806F2E40", Slot = "131")]
		protected override void AssignProperty(Property prop, bool warp)
		{
		}

		// Token: 0x06002A00 RID: 10752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A00")]
		[Address(RVA = "0x6F0E40", Offset = "0x6F0040", VA = "0x1806F0E40", Slot = "132")]
		protected override void UnassignProperty()
		{
		}

		// Token: 0x06002A01 RID: 10753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A01")]
		[Address(RVA = "0x6F5570", Offset = "0x6F4770", VA = "0x1806F5570", Slot = "137")]
		protected override void ResetConfiguration()
		{
		}

		// Token: 0x06002A02 RID: 10754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A02")]
		[Address(RVA = "0x6F3250", Offset = "0x6F2450", VA = "0x1806F3250", Slot = "138")]
		protected override void Fire()
		{
		}

		// Token: 0x06002A03 RID: 10755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A03")]
		[Address(RVA = "0x6F5350", Offset = "0x6F4550", VA = "0x1806F5350", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06002A04 RID: 10756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A04")]
		[Address(RVA = "0x6F57F0", Offset = "0x6F49F0", VA = "0x1806F57F0", Slot = "171")]
		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x06002A05 RID: 10757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A05")]
		[Address(RVA = "0x6F6220", Offset = "0x6F5420", VA = "0x1806F6220", Slot = "140")]
		protected override void UpdateBehaviour()
		{
		}

		// Token: 0x06002A06 RID: 10758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A06")]
		[Address(RVA = "0x6F5BE0", Offset = "0x6F4DE0", VA = "0x1806F5BE0")]
		private void TryStartNewTask()
		{
		}

		// Token: 0x06002A07 RID: 10759 RVA: 0x0000D668 File Offset: 0x0000B868
		[Token(Token = "0x6002A07")]
		[Address(RVA = "0x6F5090", Offset = "0x6F4290", VA = "0x1806F5090", Slot = "141")]
		protected override bool IsAnyWorkInProgress()
		{
			return default(bool);
		}

		// Token: 0x06002A08 RID: 10760 RVA: 0x0000D680 File Offset: 0x0000B880
		[Token(Token = "0x6002A08")]
		[Address(RVA = "0x6F5A80", Offset = "0x6F4C80", VA = "0x1806F5A80", Slot = "142")]
		protected override bool ShouldIdle()
		{
			return default(bool);
		}

		// Token: 0x06002A09 RID: 10761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A09")]
		[Address(RVA = "0x6F5B20", Offset = "0x6F4D20", VA = "0x1806F5B20")]
		private void StartChemistryStation(ChemistryStation station)
		{
		}

		// Token: 0x06002A0A RID: 10762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A0A")]
		[Address(RVA = "0x6F5AE0", Offset = "0x6F4CE0", VA = "0x1806F5AE0")]
		private void StartCauldron(Cauldron cauldron)
		{
		}

		// Token: 0x06002A0B RID: 10763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A0B")]
		[Address(RVA = "0x6F5B60", Offset = "0x6F4D60", VA = "0x1806F5B60")]
		private void StartLabOven(LabOven oven)
		{
		}

		// Token: 0x06002A0C RID: 10764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A0C")]
		[Address(RVA = "0x6F3210", Offset = "0x6F2410", VA = "0x1806F3210")]
		private void FinishLabOven(LabOven oven)
		{
		}

		// Token: 0x06002A0D RID: 10765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A0D")]
		[Address(RVA = "0x6F5BA0", Offset = "0x6F4DA0", VA = "0x1806F5BA0")]
		private void StartMixingStation(MixingStation station)
		{
		}

		// Token: 0x06002A0E RID: 10766 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002A0E")]
		[Address(RVA = "0x6F3E90", Offset = "0x6F3090", VA = "0x1806F3E90", Slot = "143")]
		public override EmployeeHome GetHome()
		{
			return null;
		}

		// Token: 0x06002A0F RID: 10767 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002A0F")]
		[Address(RVA = "0x6F3EB0", Offset = "0x6F30B0", VA = "0x1806F3EB0")]
		public List<LabOven> GetLabOvensReadyToFinish()
		{
			return null;
		}

		// Token: 0x06002A10 RID: 10768 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002A10")]
		[Address(RVA = "0x6F43E0", Offset = "0x6F35E0", VA = "0x1806F43E0")]
		public List<LabOven> GetLabOvensReadyToStart()
		{
			return null;
		}

		// Token: 0x06002A11 RID: 10769 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002A11")]
		[Address(RVA = "0x6F3B40", Offset = "0x6F2D40", VA = "0x1806F3B40")]
		public List<ChemistryStation> GetChemistryStationsReadyToStart()
		{
			return null;
		}

		// Token: 0x06002A12 RID: 10770 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002A12")]
		[Address(RVA = "0x6F3620", Offset = "0x6F2820", VA = "0x1806F3620")]
		public List<Cauldron> GetCauldronsReadyToStart()
		{
			return null;
		}

		// Token: 0x06002A13 RID: 10771 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002A13")]
		[Address(RVA = "0x6F4AA0", Offset = "0x6F3CA0", VA = "0x1806F4AA0")]
		public List<MixingStation> GetMixingStationsReadyToStart()
		{
			return null;
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002A14")]
		[Address(RVA = "0x6F4130", Offset = "0x6F3330", VA = "0x1806F4130")]
		protected List<LabOven> GetLabOvensReadyToMove()
		{
			return null;
		}

		// Token: 0x06002A15 RID: 10773 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002A15")]
		[Address(RVA = "0x6F3890", Offset = "0x6F2A90", VA = "0x1806F3890")]
		protected List<ChemistryStation> GetChemStationsReadyToMove()
		{
			return null;
		}

		// Token: 0x06002A16 RID: 10774 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002A16")]
		[Address(RVA = "0x6F3370", Offset = "0x6F2570", VA = "0x1806F3370")]
		protected List<Cauldron> GetCauldronsReadyToMove()
		{
			return null;
		}

		// Token: 0x06002A17 RID: 10775 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002A17")]
		[Address(RVA = "0x6F4650", Offset = "0x6F3850", VA = "0x1806F4650")]
		protected List<MixingStation> GetMixStationsReadyToMove()
		{
			return null;
		}

		// Token: 0x06002A18 RID: 10776 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002A18")]
		[Address(RVA = "0x6F2F50", Offset = "0x6F2150", VA = "0x1806F2F50", Slot = "164")]
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A19")]
		[Address(RVA = "0x6F3180", Offset = "0x6F2380", VA = "0x1806F3180", Slot = "165")]
		public void DestroyWorldspaceUI()
		{
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002A1A")]
		[Address(RVA = "0x6F4DD0", Offset = "0x6F3FD0", VA = "0x1806F4DD0", Slot = "116")]
		public override NPCData GetNPCData()
		{
			return null;
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002A1B")]
		[Address(RVA = "0x6F5000", Offset = "0x6F4200", VA = "0x1806F5000", Slot = "117")]
		public override DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002A1C")]
		[Address(RVA = "0x6F6340", Offset = "0x6F5540", VA = "0x1806F6340", Slot = "118")]
		public override List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A1D")]
		[Address(RVA = "0x6F63A0", Offset = "0x6F55A0", VA = "0x1806F63A0")]
		public Chemist()
		{
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A1E")]
		[Address(RVA = "0x6F51A0", Offset = "0x6F43A0", VA = "0x1806F51A0", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002A1F RID: 10783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A1F")]
		[Address(RVA = "0x6F5120", Offset = "0x6F4320", VA = "0x1806F5120", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002A20 RID: 10784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A20")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06002A21 RID: 10785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A21")]
		[Address(RVA = "0x6F56C0", Offset = "0x6F48C0", VA = "0x1806F56C0")]
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06002A22 RID: 10786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A22")]
		[Address(RVA = "0x6F55A0", Offset = "0x6F47A0", VA = "0x1806F55A0", Slot = "172")]
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06002A23 RID: 10787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A23")]
		[Address(RVA = "0x6F5640", Offset = "0x6F4840", VA = "0x1806F5640")]
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06002A24 RID: 10788 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002A25 RID: 10789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000745")]
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[Token(Token = "0x6002A24")]
			[Address(RVA = "0x6F2D30", Offset = "0x6F1F30", VA = "0x1806F2D30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A25")]
			[Address(RVA = "0x6F6400", Offset = "0x6F5600", VA = "0x1806F6400")]
			set
			{
			}
		}

		// Token: 0x06002A26 RID: 10790 RVA: 0x0000D698 File Offset: 0x0000B898
		[Token(Token = "0x6002A26")]
		[Address(RVA = "0x6F54B0", Offset = "0x6F46B0", VA = "0x1806F54B0", Slot = "173")]
		public virtual bool ReadSyncVar___ScheduleOne.Employees.Chemist(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x06002A27 RID: 10791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A27")]
		[Address(RVA = "0x6F2F00", Offset = "0x6F2100", VA = "0x1806F2F00", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x04001FC8 RID: 8136
		[Token(Token = "0x4001FC8")]
		public const int MAX_ASSIGNED_STATIONS = 4;

		// Token: 0x04001FC9 RID: 8137
		[Token(Token = "0x4001FC9")]
		[FieldOffset(Offset = "0x3C0")]
		[Header("References")]
		public Sprite typeIcon;

		// Token: 0x04001FCA RID: 8138
		[Token(Token = "0x4001FCA")]
		[FieldOffset(Offset = "0x3C8")]
		[SerializeField]
		protected ConfigurationReplicator configReplicator;

		// Token: 0x04001FCB RID: 8139
		[Token(Token = "0x4001FCB")]
		[FieldOffset(Offset = "0x3D0")]
		[Header("Behaviours")]
		public StartChemistryStationBehaviour StartChemistryStationBehaviour;

		// Token: 0x04001FCC RID: 8140
		[Token(Token = "0x4001FCC")]
		[FieldOffset(Offset = "0x3D8")]
		public StartLabOvenBehaviour StartLabOvenBehaviour;

		// Token: 0x04001FCD RID: 8141
		[Token(Token = "0x4001FCD")]
		[FieldOffset(Offset = "0x3E0")]
		public FinishLabOvenBehaviour FinishLabOvenBehaviour;

		// Token: 0x04001FCE RID: 8142
		[Token(Token = "0x4001FCE")]
		[FieldOffset(Offset = "0x3E8")]
		public StartCauldronBehaviour StartCauldronBehaviour;

		// Token: 0x04001FCF RID: 8143
		[Token(Token = "0x4001FCF")]
		[FieldOffset(Offset = "0x3F0")]
		public StartMixingStationBehaviour StartMixingStationBehaviour;

		// Token: 0x04001FD0 RID: 8144
		[Token(Token = "0x4001FD0")]
		[FieldOffset(Offset = "0x3F8")]
		[Header("UI")]
		public ChemistUIElement WorldspaceUIPrefab;

		// Token: 0x04001FD1 RID: 8145
		[Token(Token = "0x4001FD1")]
		[FieldOffset(Offset = "0x400")]
		public Transform uiPoint;

		// Token: 0x04001FD5 RID: 8149
		[Token(Token = "0x4001FD5")]
		[FieldOffset(Offset = "0x420")]
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x04001FD6 RID: 8150
		[Token(Token = "0x4001FD6")]
		[FieldOffset(Offset = "0x428")]
		private bool NetworkInitialize___EarlyScheduleOne.Employees.ChemistAssembly-CSharp.dll_Excuted;

		// Token: 0x04001FD7 RID: 8151
		[Token(Token = "0x4001FD7")]
		[FieldOffset(Offset = "0x429")]
		private bool NetworkInitialize__LateScheduleOne.Employees.ChemistAssembly-CSharp.dll_Excuted;
	}
}
