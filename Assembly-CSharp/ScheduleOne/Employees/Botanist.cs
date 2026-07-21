using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Dialogue;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Property;
using ScheduleOne.StationFramework;
using ScheduleOne.UI.Management;
using UnityEngine;

namespace ScheduleOne.Employees
{
	// Token: 0x0200066B RID: 1643
	[Token(Token = "0x200066B")]
	public class Botanist : Employee, IConfigurable
	{
		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x060029A5 RID: 10661 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700072C")]
		public EntityConfiguration Configuration
		{
			[Token(Token = "0x60029A5")]
			[Address(RVA = "0x6F2CE0", Offset = "0x6F1EE0", VA = "0x1806F2CE0", Slot = "150")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x060029A6 RID: 10662 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060029A7 RID: 10663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700072D")]
		protected BotanistConfiguration configuration
		{
			[Token(Token = "0x60029A6")]
			[Address(RVA = "0x6F2CE0", Offset = "0x6F1EE0", VA = "0x1806F2CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60029A7")]
			[Address(RVA = "0x6F2D60", Offset = "0x6F1F60", VA = "0x1806F2D60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x060029A8 RID: 10664 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700072E")]
		public ConfigurationReplicator ConfigReplicator
		{
			[Token(Token = "0x60029A8")]
			[Address(RVA = "0x6F2CD0", Offset = "0x6F1ED0", VA = "0x1806F2CD0", Slot = "151")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x060029A9 RID: 10665 RVA: 0x0000D530 File Offset: 0x0000B730
		[Token(Token = "0x1700072F")]
		public EConfigurableType ConfigurableType
		{
			[Token(Token = "0x60029A9")]
			[Address(RVA = "0x5B1DD0", Offset = "0x5B0FD0", VA = "0x1805B1DD0", Slot = "152")]
			get
			{
				return EConfigurableType.Pot;
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x060029AA RID: 10666 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060029AB RID: 10667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000730")]
		public WorldspaceUIElement WorldspaceUI
		{
			[Token(Token = "0x60029AA")]
			[Address(RVA = "0x6F2D30", Offset = "0x6F1F30", VA = "0x1806F2D30", Slot = "153")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60029AB")]
			[Address(RVA = "0x6F2D40", Offset = "0x6F1F40", VA = "0x1806F2D40", Slot = "154")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x060029AC RID: 10668 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060029AD RID: 10669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000731")]
		public NetworkObject CurrentPlayerConfigurer
		{
			[Token(Token = "0x60029AC")]
			[Address(RVA = "0x6F2CF0", Offset = "0x6F1EF0", VA = "0x1806F2CF0", Slot = "155")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60029AD")]
			[Address(RVA = "0x6F0880", Offset = "0x6EFA80", VA = "0x1806F0880", Slot = "156")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029AE")]
		[Address(RVA = "0x6F0C30", Offset = "0x6EFE30", VA = "0x1806F0C30", Slot = "170")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x060029AF RID: 10671 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000732")]
		public Sprite TypeIcon
		{
			[Token(Token = "0x60029AF")]
			[Address(RVA = "0x6F2D10", Offset = "0x6F1F10", VA = "0x1806F2D10", Slot = "158")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060029B0 RID: 10672 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000733")]
		public Transform Transform
		{
			[Token(Token = "0x60029B0")]
			[Address(RVA = "0x4E0C70", Offset = "0x4DFE70", VA = "0x1804E0C70", Slot = "159")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x060029B1 RID: 10673 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000734")]
		public Transform UIPoint
		{
			[Token(Token = "0x60029B1")]
			[Address(RVA = "0x6F2D20", Offset = "0x6F1F20", VA = "0x1806F2D20", Slot = "160")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x060029B2 RID: 10674 RVA: 0x0000D548 File Offset: 0x0000B748
		[Token(Token = "0x17000735")]
		public bool CanBeSelected
		{
			[Token(Token = "0x60029B2")]
			[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "162")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x060029B3 RID: 10675 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000736")]
		public Property ParentProperty
		{
			[Token(Token = "0x60029B3")]
			[Address(RVA = "0x6F2D00", Offset = "0x6F1F00", VA = "0x1806F2D00", Slot = "163")]
			get
			{
				return null;
			}
		}

		// Token: 0x060029B4 RID: 10676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B4")]
		[Address(RVA = "0x6ED980", Offset = "0x6ECB80", VA = "0x1806ED980", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x060029B5 RID: 10677 RVA: 0x0000D560 File Offset: 0x0000B760
		[Token(Token = "0x60029B5")]
		[Address(RVA = "0x6F0210", Offset = "0x6EF410", VA = "0x1806F0210", Slot = "141")]
		protected override bool IsAnyWorkInProgress()
		{
			return default(bool);
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B6")]
		[Address(RVA = "0x6F0E80", Offset = "0x6F0080", VA = "0x1806F0E80", Slot = "140")]
		protected override void UpdateBehaviour()
		{
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x0000D578 File Offset: 0x0000B778
		[Token(Token = "0x60029B7")]
		[Address(RVA = "0x6F0330", Offset = "0x6EF530", VA = "0x1806F0330")]
		private bool IsEntityAccessible(ITransitEntity entity)
		{
			return default(bool);
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B8")]
		[Address(RVA = "0x6F0DC0", Offset = "0x6EFFC0", VA = "0x1806F0DC0")]
		private void StartDryingRack(DryingRack rack)
		{
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B9")]
		[Address(RVA = "0x6F0E00", Offset = "0x6F0000", VA = "0x1806F0E00")]
		private void StopDryingRack(DryingRack rack)
		{
		}

		// Token: 0x060029BA RID: 10682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029BA")]
		[Address(RVA = "0x6F0630", Offset = "0x6EF830", VA = "0x1806F0630", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060029BB RID: 10683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029BB")]
		[Address(RVA = "0x6F0AD0", Offset = "0x6EFCD0", VA = "0x1806F0AD0", Slot = "171")]
		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029BC")]
		[Address(RVA = "0x6ED060", Offset = "0x6EC260", VA = "0x1806ED060", Slot = "131")]
		protected override void AssignProperty(Property prop, bool warp)
		{
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029BD")]
		[Address(RVA = "0x6F0E40", Offset = "0x6F0040", VA = "0x1806F0E40", Slot = "132")]
		protected override void UnassignProperty()
		{
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029BE")]
		[Address(RVA = "0x6F0850", Offset = "0x6EFA50", VA = "0x1806F0850", Slot = "137")]
		protected override void ResetConfiguration()
		{
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029BF")]
		[Address(RVA = "0x6EDE50", Offset = "0x6ED050", VA = "0x1806EDE50", Slot = "138")]
		protected override void Fire()
		{
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x0000D590 File Offset: 0x0000B790
		[Token(Token = "0x60029C0")]
		[Address(RVA = "0x6ED9D0", Offset = "0x6ECBD0", VA = "0x1806ED9D0")]
		private bool CanMoveDryableToRack(out QualityItemInstance dryable, out DryingRack destinationRack, out int moveQuantity)
		{
			return default(bool);
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60029C1")]
		[Address(RVA = "0x6EE2E0", Offset = "0x6ED4E0", VA = "0x1806EE2E0")]
		public QualityItemInstance GetDryableInSupplies()
		{
			return null;
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60029C2")]
		[Address(RVA = "0x6EDF10", Offset = "0x6ED110", VA = "0x1806EDF10")]
		private DryingRack GetAssignedDryingRackFor(QualityItemInstance dryable, out int rackInputCapacity)
		{
			return null;
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x0000D5A8 File Offset: 0x0000B7A8
		[Token(Token = "0x60029C3")]
		[Address(RVA = "0x6F0D60", Offset = "0x6EFF60", VA = "0x1806F0D60", Slot = "142")]
		protected override bool ShouldIdle()
		{
			return default(bool);
		}

		// Token: 0x060029C4 RID: 10692 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60029C4")]
		[Address(RVA = "0x6EEC60", Offset = "0x6EDE60", VA = "0x1806EEC60", Slot = "143")]
		public override EmployeeHome GetHome()
		{
			return null;
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60029C5")]
		[Address(RVA = "0x6F0150", Offset = "0x6EF350", VA = "0x1806F0150")]
		public ITransitEntity GetSuppliesAsTransitEntity()
		{
			return null;
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60029C6")]
		[Address(RVA = "0x6EF270", Offset = "0x6EE470", VA = "0x1806EF270")]
		private Pot GetPotForWatering(float threshold)
		{
			return null;
		}

		// Token: 0x060029C7 RID: 10695 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60029C7")]
		[Address(RVA = "0x6EE930", Offset = "0x6EDB30", VA = "0x1806EE930")]
		private List<GrowContainer> GetGrowContainersForSoilPour()
		{
			return null;
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60029C8")]
		[Address(RVA = "0x6EF630", Offset = "0x6EE830", VA = "0x1806EF630")]
		private List<Pot> GetPotsReadyForSeed()
		{
			return null;
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60029C9")]
		[Address(RVA = "0x6EE5E0", Offset = "0x6ED7E0", VA = "0x1806EE5E0")]
		private List<GrowContainer> GetGrowContainersForAdditives()
		{
			return null;
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60029CA")]
		[Address(RVA = "0x6EF3D0", Offset = "0x6EE5D0", VA = "0x1806EF3D0")]
		private List<Pot> GetPotsForHarvest()
		{
			return null;
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60029CB")]
		[Address(RVA = "0x6EEC80", Offset = "0x6EDE80", VA = "0x1806EEC80")]
		private MushroomBed GetMushroomBedForMisting(float threshold)
		{
			return null;
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60029CC")]
		[Address(RVA = "0x6EEDE0", Offset = "0x6EDFE0", VA = "0x1806EEDE0")]
		private List<MushroomBed> GetMushroomBedsForHarvest()
		{
			return null;
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60029CD")]
		[Address(RVA = "0x6EE160", Offset = "0x6ED360", VA = "0x1806EE160")]
		private List<MushroomBed> GetBedsReadyForSpawn()
		{
			return null;
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60029CE")]
		[Address(RVA = "0x6EFA10", Offset = "0x6EEC10", VA = "0x1806EFA10")]
		private List<DryingRack> GetRacksToStart()
		{
			return null;
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60029CF")]
		[Address(RVA = "0x6EFB80", Offset = "0x6EED80", VA = "0x1806EFB80")]
		private List<DryingRack> GetRacksToStop()
		{
			return null;
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60029D0")]
		[Address(RVA = "0x6EF7B0", Offset = "0x6EE9B0", VA = "0x1806EF7B0")]
		private List<DryingRack> GetRacksReadyToMove()
		{
			return null;
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60029D1")]
		[Address(RVA = "0x6EFFE0", Offset = "0x6EF1E0", VA = "0x1806EFFE0")]
		private List<MushroomSpawnStation> GetSpawnStationsReadyToUse()
		{
			return null;
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60029D2")]
		[Address(RVA = "0x6EFD80", Offset = "0x6EEF80", VA = "0x1806EFD80")]
		private List<MushroomSpawnStation> GetSpawnStationsReadyToMove()
		{
			return null;
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60029D3")]
		[Address(RVA = "0x6EDB90", Offset = "0x6ECD90", VA = "0x1806EDB90", Slot = "164")]
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029D4")]
		[Address(RVA = "0x6EDDC0", Offset = "0x6ECFC0", VA = "0x1806EDDC0", Slot = "165")]
		public void DestroyWorldspaceUI()
		{
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60029D5")]
		[Address(RVA = "0x6EF040", Offset = "0x6EE240", VA = "0x1806EF040", Slot = "116")]
		public override NPCData GetNPCData()
		{
			return null;
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60029D6")]
		[Address(RVA = "0x6EFCF0", Offset = "0x6EEEF0", VA = "0x1806EFCF0", Slot = "117")]
		public override DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x060029D7 RID: 10711 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60029D7")]
		[Address(RVA = "0x6F2BE0", Offset = "0x6F1DE0", VA = "0x1806F2BE0", Slot = "118")]
		public override List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029D8")]
		[Address(RVA = "0x6F2C40", Offset = "0x6F1E40", VA = "0x1806F2C40")]
		public Botanist()
		{
		}

		// Token: 0x060029D9 RID: 10713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029D9")]
		[Address(RVA = "0x6F0480", Offset = "0x6EF680", VA = "0x1806F0480", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060029DA RID: 10714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029DA")]
		[Address(RVA = "0x6F0400", Offset = "0x6EF600", VA = "0x1806F0400", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060029DB RID: 10715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029DB")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029DC")]
		[Address(RVA = "0x6F09A0", Offset = "0x6EFBA0", VA = "0x1806F09A0")]
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029DD")]
		[Address(RVA = "0x6F0880", Offset = "0x6EFA80", VA = "0x1806F0880", Slot = "172")]
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029DE")]
		[Address(RVA = "0x6F0920", Offset = "0x6EFB20", VA = "0x1806F0920")]
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x060029DF RID: 10719 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060029E0 RID: 10720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000737")]
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[Token(Token = "0x60029DF")]
			[Address(RVA = "0x6F2CF0", Offset = "0x6F1EF0", VA = "0x1806F2CF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60029E0")]
			[Address(RVA = "0x6F2D80", Offset = "0x6F1F80", VA = "0x1806F2D80")]
			set
			{
			}
		}

		// Token: 0x060029E1 RID: 10721 RVA: 0x0000D5C0 File Offset: 0x0000B7C0
		[Token(Token = "0x60029E1")]
		[Address(RVA = "0x6F0790", Offset = "0x6EF990", VA = "0x1806F0790", Slot = "173")]
		public virtual bool ReadSyncVar___ScheduleOne.Employees.Botanist(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x060029E2 RID: 10722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029E2")]
		[Address(RVA = "0x6ED120", Offset = "0x6EC320", VA = "0x1806ED120", Slot = "174")]
		protected virtual void Awake_UserLogic_ScheduleOne.Employees.Botanist_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001F9A RID: 8090
		[Token(Token = "0x4001F9A")]
		public const float CriticalWateringThreshold = 0.2f;

		// Token: 0x04001F9B RID: 8091
		[Token(Token = "0x4001F9B")]
		public const float WateringThreshold = 0.3f;

		// Token: 0x04001F9C RID: 8092
		[Token(Token = "0x4001F9C")]
		public const float MoistureLevelRandomMin = 0.9f;

		// Token: 0x04001F9D RID: 8093
		[Token(Token = "0x4001F9D")]
		public const float MoistureLevelRandomMax = 1f;

		// Token: 0x04001F9E RID: 8094
		[Token(Token = "0x4001F9E")]
		public const float SoilPourTime = 10f;

		// Token: 0x04001F9F RID: 8095
		[Token(Token = "0x4001F9F")]
		public const float WaterPourTime = 10f;

		// Token: 0x04001FA0 RID: 8096
		[Token(Token = "0x4001FA0")]
		public const float AdditivePourTime = 10f;

		// Token: 0x04001FA1 RID: 8097
		[Token(Token = "0x4001FA1")]
		public const float SeedSowTime = 15f;

		// Token: 0x04001FA2 RID: 8098
		[Token(Token = "0x4001FA2")]
		public const float IndividualHarvestTime = 1f;

		// Token: 0x04001FA3 RID: 8099
		[Token(Token = "0x4001FA3")]
		public const float ApplySpawnTime = 15f;

		// Token: 0x04001FA4 RID: 8100
		[Token(Token = "0x4001FA4")]
		[FieldOffset(Offset = "0x3C0")]
		[Header("References")]
		public Sprite typeIcon;

		// Token: 0x04001FA5 RID: 8101
		[Token(Token = "0x4001FA5")]
		[FieldOffset(Offset = "0x3C8")]
		[SerializeField]
		protected ConfigurationReplicator configReplicator;

		// Token: 0x04001FA6 RID: 8102
		[Token(Token = "0x4001FA6")]
		[FieldOffset(Offset = "0x3D0")]
		[Header("UI")]
		public BotanistUIElement WorldspaceUIPrefab;

		// Token: 0x04001FA7 RID: 8103
		[Token(Token = "0x4001FA7")]
		[FieldOffset(Offset = "0x3D8")]
		public Transform uiPoint;

		// Token: 0x04001FA8 RID: 8104
		[Token(Token = "0x4001FA8")]
		[FieldOffset(Offset = "0x3E0")]
		[Header("Settings")]
		public int MaxAssignedPots;

		// Token: 0x04001FA9 RID: 8105
		[Token(Token = "0x4001FA9")]
		[FieldOffset(Offset = "0x3E8")]
		public DialogueContainer NoAssignedStationsDialogue;

		// Token: 0x04001FAA RID: 8106
		[Token(Token = "0x4001FAA")]
		[FieldOffset(Offset = "0x3F0")]
		public DialogueContainer UnspecifiedPotsDialogue;

		// Token: 0x04001FAB RID: 8107
		[Token(Token = "0x4001FAB")]
		[FieldOffset(Offset = "0x3F8")]
		public DialogueContainer NullDestinationPotsDialogue;

		// Token: 0x04001FAC RID: 8108
		[Token(Token = "0x4001FAC")]
		[FieldOffset(Offset = "0x400")]
		public DialogueContainer MissingMaterialsDialogue;

		// Token: 0x04001FAD RID: 8109
		[Token(Token = "0x4001FAD")]
		[FieldOffset(Offset = "0x408")]
		public DialogueContainer NoPotsRequireWorkDialogue;

		// Token: 0x04001FB1 RID: 8113
		[Token(Token = "0x4001FB1")]
		[FieldOffset(Offset = "0x428")]
		private StartDryingRackBehaviour _startDryingRackBehaviour;

		// Token: 0x04001FB2 RID: 8114
		[Token(Token = "0x4001FB2")]
		[FieldOffset(Offset = "0x430")]
		private StopDryingRackBehaviour _stopDryingRackBehaviour;

		// Token: 0x04001FB3 RID: 8115
		[Token(Token = "0x4001FB3")]
		[FieldOffset(Offset = "0x438")]
		private UseSpawnStationBehaviour _useSpawnStationBehaviour;

		// Token: 0x04001FB4 RID: 8116
		[Token(Token = "0x4001FB4")]
		[FieldOffset(Offset = "0x440")]
		private AddSoilToGrowContainerBehaviour _addSoilToGrowContainerBehaviour;

		// Token: 0x04001FB5 RID: 8117
		[Token(Token = "0x4001FB5")]
		[FieldOffset(Offset = "0x448")]
		private ApplyAdditiveToGrowContainerBehaviour _applyAdditiveToGrowContainerBehaviour;

		// Token: 0x04001FB6 RID: 8118
		[Token(Token = "0x4001FB6")]
		[FieldOffset(Offset = "0x450")]
		private SowSeedInPotBehaviour _sowSeedInPotBehaviour;

		// Token: 0x04001FB7 RID: 8119
		[Token(Token = "0x4001FB7")]
		[FieldOffset(Offset = "0x458")]
		private WaterPotBehaviour _waterPotBehaviour;

		// Token: 0x04001FB8 RID: 8120
		[Token(Token = "0x4001FB8")]
		[FieldOffset(Offset = "0x460")]
		private HarvestPotBehaviour _harvestPotBehaviour;

		// Token: 0x04001FB9 RID: 8121
		[Token(Token = "0x4001FB9")]
		[FieldOffset(Offset = "0x468")]
		private MistMushroomBedBehaviour _mistMushroomBedBehaviour;

		// Token: 0x04001FBA RID: 8122
		[Token(Token = "0x4001FBA")]
		[FieldOffset(Offset = "0x470")]
		private HarvestMushroomBedBehaviour _harvestMushroomBedBehaviour;

		// Token: 0x04001FBB RID: 8123
		[Token(Token = "0x4001FBB")]
		[FieldOffset(Offset = "0x478")]
		private ApplySpawnToMushroomBedBehaviour _applySpawnToMushroomBedBehaviour;

		// Token: 0x04001FBC RID: 8124
		[Token(Token = "0x4001FBC")]
		[FieldOffset(Offset = "0x480")]
		private List<ScheduleOne.NPCs.Behaviour.Behaviour> _workBehaviours;

		// Token: 0x04001FBD RID: 8125
		[Token(Token = "0x4001FBD")]
		[FieldOffset(Offset = "0x488")]
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x04001FBE RID: 8126
		[Token(Token = "0x4001FBE")]
		[FieldOffset(Offset = "0x490")]
		private bool NetworkInitialize___EarlyScheduleOne.Employees.BotanistAssembly-CSharp.dll_Excuted;

		// Token: 0x04001FBF RID: 8127
		[Token(Token = "0x4001FBF")]
		[FieldOffset(Offset = "0x491")]
		private bool NetworkInitialize__LateScheduleOne.Employees.BotanistAssembly-CSharp.dll_Excuted;
	}
}
