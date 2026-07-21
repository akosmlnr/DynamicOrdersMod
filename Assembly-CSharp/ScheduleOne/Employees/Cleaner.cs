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
using ScheduleOne.ObjectScripts.WateringCan;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Property;
using ScheduleOne.UI.Management;
using UnityEngine;

namespace ScheduleOne.Employees
{
	// Token: 0x02000672 RID: 1650
	[Token(Token = "0x2000672")]
	public class Cleaner : Employee, IConfigurable
	{
		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06002A31 RID: 10801 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002A32 RID: 10802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000748")]
		public TrashGrabberInstance trashGrabberInstance
		{
			[Token(Token = "0x6002A31")]
			[Address(RVA = "0x6F63C0", Offset = "0x6F55C0", VA = "0x1806F63C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A32")]
			[Address(RVA = "0x6F63E0", Offset = "0x6F55E0", VA = "0x1806F63E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06002A33 RID: 10803 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000749")]
		public EntityConfiguration Configuration
		{
			[Token(Token = "0x6002A33")]
			[Address(RVA = "0x6F2CE0", Offset = "0x6F1EE0", VA = "0x1806F2CE0", Slot = "150")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06002A34 RID: 10804 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002A35 RID: 10805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700074A")]
		protected CleanerConfiguration configuration
		{
			[Token(Token = "0x6002A34")]
			[Address(RVA = "0x6F2CE0", Offset = "0x6F1EE0", VA = "0x1806F2CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A35")]
			[Address(RVA = "0x6F2D60", Offset = "0x6F1F60", VA = "0x1806F2D60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06002A36 RID: 10806 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700074B")]
		public ConfigurationReplicator ConfigReplicator
		{
			[Token(Token = "0x6002A36")]
			[Address(RVA = "0x6F84E0", Offset = "0x6F76E0", VA = "0x1806F84E0", Slot = "151")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06002A37 RID: 10807 RVA: 0x0000D6E0 File Offset: 0x0000B8E0
		[Token(Token = "0x1700074C")]
		public EConfigurableType ConfigurableType
		{
			[Token(Token = "0x6002A37")]
			[Address(RVA = "0x6F84F0", Offset = "0x6F76F0", VA = "0x1806F84F0", Slot = "152")]
			get
			{
				return EConfigurableType.Pot;
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06002A38 RID: 10808 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002A39 RID: 10809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700074D")]
		public WorldspaceUIElement WorldspaceUI
		{
			[Token(Token = "0x6002A38")]
			[Address(RVA = "0x6F2D30", Offset = "0x6F1F30", VA = "0x1806F2D30", Slot = "153")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A39")]
			[Address(RVA = "0x6F2D40", Offset = "0x6F1F40", VA = "0x1806F2D40", Slot = "154")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06002A3A RID: 10810 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002A3B RID: 10811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700074E")]
		public NetworkObject CurrentPlayerConfigurer
		{
			[Token(Token = "0x6002A3A")]
			[Address(RVA = "0x6F2CF0", Offset = "0x6F1EF0", VA = "0x1806F2CF0", Slot = "155")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A3B")]
			[Address(RVA = "0x6F7520", Offset = "0x6F6720", VA = "0x1806F7520", Slot = "156")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A3C")]
		[Address(RVA = "0x6F78D0", Offset = "0x6F6AD0", VA = "0x1806F78D0", Slot = "170")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06002A3D RID: 10813 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700074F")]
		public Sprite TypeIcon
		{
			[Token(Token = "0x6002A3D")]
			[Address(RVA = "0x6F8500", Offset = "0x6F7700", VA = "0x1806F8500", Slot = "158")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06002A3E RID: 10814 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000750")]
		public Transform Transform
		{
			[Token(Token = "0x6002A3E")]
			[Address(RVA = "0x4E0C70", Offset = "0x4DFE70", VA = "0x1804E0C70", Slot = "159")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06002A3F RID: 10815 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000751")]
		public Transform UIPoint
		{
			[Token(Token = "0x6002A3F")]
			[Address(RVA = "0x6F63D0", Offset = "0x6F55D0", VA = "0x1806F63D0", Slot = "160")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06002A40 RID: 10816 RVA: 0x0000D6F8 File Offset: 0x0000B8F8
		[Token(Token = "0x17000752")]
		public bool CanBeSelected
		{
			[Token(Token = "0x6002A40")]
			[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "162")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06002A41 RID: 10817 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000753")]
		public Property ParentProperty
		{
			[Token(Token = "0x6002A41")]
			[Address(RVA = "0x6F2D00", Offset = "0x6F1F00", VA = "0x1806F2D00", Slot = "163")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002A42 RID: 10818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A42")]
		[Address(RVA = "0x6F64C0", Offset = "0x6F56C0", VA = "0x1806F64C0", Slot = "131")]
		protected override void AssignProperty(Property prop, bool warp)
		{
		}

		// Token: 0x06002A43 RID: 10819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A43")]
		[Address(RVA = "0x6F0E40", Offset = "0x6F0040", VA = "0x1806F0E40", Slot = "132")]
		protected override void UnassignProperty()
		{
		}

		// Token: 0x06002A44 RID: 10820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A44")]
		[Address(RVA = "0x6F0850", Offset = "0x6EFA50", VA = "0x1806F0850", Slot = "137")]
		protected override void ResetConfiguration()
		{
		}

		// Token: 0x06002A45 RID: 10821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A45")]
		[Address(RVA = "0x6F6A30", Offset = "0x6F5C30", VA = "0x1806F6A30", Slot = "138")]
		protected override void Fire()
		{
		}

		// Token: 0x06002A46 RID: 10822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A46")]
		[Address(RVA = "0x6F7300", Offset = "0x6F6500", VA = "0x1806F7300", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A47")]
		[Address(RVA = "0x6F7770", Offset = "0x6F6970", VA = "0x1806F7770", Slot = "171")]
		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x06002A48 RID: 10824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A48")]
		[Address(RVA = "0x6F82F0", Offset = "0x6F74F0", VA = "0x1806F82F0", Slot = "140")]
		protected override void UpdateBehaviour()
		{
		}

		// Token: 0x06002A49 RID: 10825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A49")]
		[Address(RVA = "0x6F7AC0", Offset = "0x6F6CC0", VA = "0x1806F7AC0")]
		private void TryStartNewTask()
		{
		}

		// Token: 0x06002A4A RID: 10826 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002A4A")]
		[Address(RVA = "0x6F6B50", Offset = "0x6F5D50", VA = "0x1806F6B50")]
		private TrashContainerItem GetFirstNonFullBin(TrashContainerItem[] bins)
		{
			return null;
		}

		// Token: 0x06002A4B RID: 10827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A4B")]
		[Address(RVA = "0x6F7A00", Offset = "0x6F6C00", VA = "0x1806F7A00", Slot = "145")]
		public override void SetIdle(bool idle)
		{
		}

		// Token: 0x06002A4C RID: 10828 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002A4C")]
		[Address(RVA = "0x6F6F40", Offset = "0x6F6140", VA = "0x1806F6F40")]
		private TrashContainerItem[] GetTrashContainersOrderedByDistance()
		{
			return null;
		}

		// Token: 0x06002A4D RID: 10829 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002A4D")]
		[Address(RVA = "0x6F6C60", Offset = "0x6F5E60", VA = "0x1806F6C60", Slot = "143")]
		public override EmployeeHome GetHome()
		{
			return null;
		}

		// Token: 0x06002A4E RID: 10830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A4E")]
		[Address(RVA = "0x6F6840", Offset = "0x6F5A40", VA = "0x1806F6840")]
		private void EnsureTrashGrabberInInventory()
		{
		}

		// Token: 0x06002A4F RID: 10831 RVA: 0x0000D710 File Offset: 0x0000B910
		[Token(Token = "0x6002A4F")]
		[Address(RVA = "0x6F7040", Offset = "0x6F6240", VA = "0x1806F7040", Slot = "141")]
		protected override bool IsAnyWorkInProgress()
		{
			return default(bool);
		}

		// Token: 0x06002A50 RID: 10832 RVA: 0x0000D728 File Offset: 0x0000B928
		[Token(Token = "0x6002A50")]
		[Address(RVA = "0x6F7010", Offset = "0x6F6210", VA = "0x1806F7010")]
		private int GetTrashGrabberAmount()
		{
			return 0;
		}

		// Token: 0x06002A51 RID: 10833 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002A51")]
		[Address(RVA = "0x6F6580", Offset = "0x6F5780", VA = "0x1806F6580", Slot = "164")]
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		// Token: 0x06002A52 RID: 10834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A52")]
		[Address(RVA = "0x6F67B0", Offset = "0x6F59B0", VA = "0x1806F67B0", Slot = "165")]
		public void DestroyWorldspaceUI()
		{
		}

		// Token: 0x06002A53 RID: 10835 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002A53")]
		[Address(RVA = "0x6F6C80", Offset = "0x6F5E80", VA = "0x1806F6C80", Slot = "116")]
		public override NPCData GetNPCData()
		{
			return null;
		}

		// Token: 0x06002A54 RID: 10836 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002A54")]
		[Address(RVA = "0x6F6EB0", Offset = "0x6F60B0", VA = "0x1806F6EB0", Slot = "117")]
		public override DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002A55")]
		[Address(RVA = "0x6F8480", Offset = "0x6F7680", VA = "0x1806F8480", Slot = "118")]
		public override List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x06002A56 RID: 10838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A56")]
		[Address(RVA = "0x6F63A0", Offset = "0x6F55A0", VA = "0x1806F63A0")]
		public Cleaner()
		{
		}

		// Token: 0x06002A58 RID: 10840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A58")]
		[Address(RVA = "0x6F7150", Offset = "0x6F6350", VA = "0x1806F7150", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002A59 RID: 10841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A59")]
		[Address(RVA = "0x6F70D0", Offset = "0x6F62D0", VA = "0x1806F70D0", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002A5A RID: 10842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A5A")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06002A5B RID: 10843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A5B")]
		[Address(RVA = "0x6F7640", Offset = "0x6F6840", VA = "0x1806F7640")]
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06002A5C RID: 10844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A5C")]
		[Address(RVA = "0x6F7520", Offset = "0x6F6720", VA = "0x1806F7520", Slot = "172")]
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06002A5D RID: 10845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A5D")]
		[Address(RVA = "0x6F75C0", Offset = "0x6F67C0", VA = "0x1806F75C0")]
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06002A5E RID: 10846 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002A5F RID: 10847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000754")]
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[Token(Token = "0x6002A5E")]
			[Address(RVA = "0x6F2CF0", Offset = "0x6F1EF0", VA = "0x1806F2CF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A5F")]
			[Address(RVA = "0x6F8510", Offset = "0x6F7710", VA = "0x1806F8510")]
			set
			{
			}
		}

		// Token: 0x06002A60 RID: 10848 RVA: 0x0000D758 File Offset: 0x0000B958
		[Token(Token = "0x6002A60")]
		[Address(RVA = "0x6F7460", Offset = "0x6F6660", VA = "0x1806F7460", Slot = "173")]
		public virtual bool ReadSyncVar___ScheduleOne.Employees.Cleaner(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x06002A61 RID: 10849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A61")]
		[Address(RVA = "0x6F2F00", Offset = "0x6F2100", VA = "0x1806F2F00", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x04001FDD RID: 8157
		[Token(Token = "0x4001FDD")]
		public const int MAX_ASSIGNED_BINS = 6;

		// Token: 0x04001FDE RID: 8158
		[Token(Token = "0x4001FDE")]
		[FieldOffset(Offset = "0x3C0")]
		public TrashGrabberDefinition TrashGrabberDef;

		// Token: 0x04001FDF RID: 8159
		[Token(Token = "0x4001FDF")]
		[FieldOffset(Offset = "0x3C8")]
		[Header("References")]
		public PickUpTrashBehaviour PickUpTrashBehaviour;

		// Token: 0x04001FE0 RID: 8160
		[Token(Token = "0x4001FE0")]
		[FieldOffset(Offset = "0x3D0")]
		public EmptyTrashGrabberBehaviour EmptyTrashGrabberBehaviour;

		// Token: 0x04001FE1 RID: 8161
		[Token(Token = "0x4001FE1")]
		[FieldOffset(Offset = "0x3D8")]
		public BagTrashCanBehaviour BagTrashCanBehaviour;

		// Token: 0x04001FE2 RID: 8162
		[Token(Token = "0x4001FE2")]
		[FieldOffset(Offset = "0x3E0")]
		public DisposeTrashBagBehaviour DisposeTrashBagBehaviour;

		// Token: 0x04001FE3 RID: 8163
		[Token(Token = "0x4001FE3")]
		[FieldOffset(Offset = "0x3E8")]
		public Sprite typeIcon;

		// Token: 0x04001FE4 RID: 8164
		[Token(Token = "0x4001FE4")]
		[FieldOffset(Offset = "0x3F0")]
		[SerializeField]
		protected ConfigurationReplicator configReplicator;

		// Token: 0x04001FE5 RID: 8165
		[Token(Token = "0x4001FE5")]
		[FieldOffset(Offset = "0x3F8")]
		[Header("UI")]
		public CleanerUIElement WorldspaceUIPrefab;

		// Token: 0x04001FE6 RID: 8166
		[Token(Token = "0x4001FE6")]
		[FieldOffset(Offset = "0x400")]
		public Transform uiPoint;

		// Token: 0x04001FEB RID: 8171
		[Token(Token = "0x4001FEB")]
		[FieldOffset(Offset = "0x428")]
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x04001FEC RID: 8172
		[Token(Token = "0x4001FEC")]
		[FieldOffset(Offset = "0x430")]
		private bool NetworkInitialize___EarlyScheduleOne.Employees.CleanerAssembly-CSharp.dll_Excuted;

		// Token: 0x04001FED RID: 8173
		[Token(Token = "0x4001FED")]
		[FieldOffset(Offset = "0x431")]
		private bool NetworkInitialize__LateScheduleOne.Employees.CleanerAssembly-CSharp.dll_Excuted;
	}
}
