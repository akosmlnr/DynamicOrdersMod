using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using ScheduleOne.UI.Management;
using TMPro;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x020009D5 RID: 2517
	[Token(Token = "0x20009D5")]
	[RequireComponent(typeof(ConfigurationReplicator))]
	public class PlaceableStorageEntity : GridItem, ITransitEntity, IUsable, IConfigurable
	{
		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x06004803 RID: 18435 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B39")]
		public string Name
		{
			[Token(Token = "0x6004803")]
			[Address(RVA = "0x834FB0", Offset = "0x8341B0", VA = "0x180834FB0", Slot = "71")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x06004804 RID: 18436 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004805 RID: 18437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B3A")]
		public List<ItemSlot> InputSlots
		{
			[Token(Token = "0x6004804")]
			[Address(RVA = "0x84CCE0", Offset = "0x84BEE0", VA = "0x18084CCE0", Slot = "72")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004805")]
			[Address(RVA = "0x84D080", Offset = "0x84C280", VA = "0x18084D080", Slot = "73")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06004806 RID: 18438 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004807 RID: 18439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B3B")]
		public List<ItemSlot> OutputSlots
		{
			[Token(Token = "0x6004806")]
			[Address(RVA = "0x803790", Offset = "0x802990", VA = "0x180803790", Slot = "74")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004807")]
			[Address(RVA = "0x803930", Offset = "0x802B30", VA = "0x180803930", Slot = "75")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06004808 RID: 18440 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B3C")]
		public Transform LinkOrigin
		{
			[Token(Token = "0x6004808")]
			[Address(RVA = "0x5A44B0", Offset = "0x5A36B0", VA = "0x1805A44B0", Slot = "76")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06004809 RID: 18441 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600480A RID: 18442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B3D")]
		public NetworkObject NPCUserObject
		{
			[Token(Token = "0x6004809")]
			[Address(RVA = "0x66B880", Offset = "0x66AA80", VA = "0x18066B880", Slot = "95")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600480A")]
			[Address(RVA = "0x8BE360", Offset = "0x8BD560", VA = "0x1808BE360", Slot = "96")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x0600480B RID: 18443 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600480C RID: 18444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B3E")]
		public NetworkObject PlayerUserObject
		{
			[Token(Token = "0x600480B")]
			[Address(RVA = "0x835000", Offset = "0x834200", VA = "0x180835000", Slot = "97")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600480C")]
			[Address(RVA = "0x8BE400", Offset = "0x8BD600", VA = "0x1808BE400", Slot = "98")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x0600480D RID: 18445 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B3F")]
		public Transform[] AccessPoints
		{
			[Token(Token = "0x600480D")]
			[Address(RVA = "0x5A4480", Offset = "0x5A3680", VA = "0x1805A4480", Slot = "77")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x0600480E RID: 18446 RVA: 0x000138C0 File Offset: 0x00011AC0
		[Token(Token = "0x17000B40")]
		public bool Selectable
		{
			[Token(Token = "0x600480E")]
			[Address(RVA = "0x59CED0", Offset = "0x59C0D0", VA = "0x18059CED0", Slot = "78")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x0600480F RID: 18447 RVA: 0x000138D8 File Offset: 0x00011AD8
		// (set) Token: 0x06004810 RID: 18448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B41")]
		public bool IsAcceptingItems
		{
			[Token(Token = "0x600480F")]
			[Address(RVA = "0x8BF330", Offset = "0x8BE530", VA = "0x1808BF330", Slot = "79")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004810")]
			[Address(RVA = "0x8BF3C0", Offset = "0x8BE5C0", VA = "0x1808BF3C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06004811 RID: 18449 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B42")]
		public EntityConfiguration Configuration
		{
			[Token(Token = "0x6004811")]
			[Address(RVA = "0x8035F0", Offset = "0x8027F0", VA = "0x1808035F0", Slot = "103")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06004812 RID: 18450 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B43")]
		public ConfigurationReplicator ConfigReplicator
		{
			[Token(Token = "0x6004812")]
			[Address(RVA = "0x8037A0", Offset = "0x8029A0", VA = "0x1808037A0", Slot = "104")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x06004813 RID: 18451 RVA: 0x000138F0 File Offset: 0x00011AF0
		[Token(Token = "0x17000B44")]
		public EConfigurableType ConfigurableType
		{
			[Token(Token = "0x6004813")]
			[Address(RVA = "0x8BF320", Offset = "0x8BE520", VA = "0x1808BF320", Slot = "105")]
			get
			{
				return EConfigurableType.Pot;
			}
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x06004814 RID: 18452 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004815 RID: 18453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B45")]
		public WorldspaceUIElement WorldspaceUI
		{
			[Token(Token = "0x6004814")]
			[Address(RVA = "0x598F80", Offset = "0x598180", VA = "0x180598F80", Slot = "106")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004815")]
			[Address(RVA = "0x803900", Offset = "0x802B00", VA = "0x180803900", Slot = "107")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06004816 RID: 18454 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004817 RID: 18455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B46")]
		public NetworkObject CurrentPlayerConfigurer
		{
			[Token(Token = "0x6004816")]
			[Address(RVA = "0x66B4D0", Offset = "0x66A6D0", VA = "0x18066B4D0", Slot = "108")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004817")]
			[Address(RVA = "0x8BE2C0", Offset = "0x8BD4C0", VA = "0x1808BE2C0", Slot = "109")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06004818 RID: 18456 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B47")]
		public Sprite TypeIcon
		{
			[Token(Token = "0x6004818")]
			[Address(RVA = "0x8BF340", Offset = "0x8BE540", VA = "0x1808BF340", Slot = "111")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06004819 RID: 18457 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B48")]
		public Transform Transform
		{
			[Token(Token = "0x6004819")]
			[Address(RVA = "0x4E0C70", Offset = "0x4DFE70", VA = "0x1804E0C70", Slot = "112")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x0600481A RID: 18458 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B49")]
		public Transform UIPoint
		{
			[Token(Token = "0x600481A")]
			[Address(RVA = "0x5A44B0", Offset = "0x5A36B0", VA = "0x1805A44B0", Slot = "113")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x0600481B RID: 18459 RVA: 0x00013908 File Offset: 0x00011B08
		[Token(Token = "0x17000B4A")]
		public bool CanBeSelected
		{
			[Token(Token = "0x600481B")]
			[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600481C RID: 18460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600481C")]
		[Address(RVA = "0x8BD210", Offset = "0x8BC410", VA = "0x1808BD210", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x0600481D RID: 18461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600481D")]
		[Address(RVA = "0x8BEEA0", Offset = "0x8BE0A0", VA = "0x1808BEEA0", Slot = "48")]
		protected override void Start()
		{
		}

		// Token: 0x0600481E RID: 18462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600481E")]
		[Address(RVA = "0x8BDFA0", Offset = "0x8BD1A0", VA = "0x1808BDFA0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x0600481F RID: 18463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600481F")]
		[Address(RVA = "0x8BD980", Offset = "0x8BCB80", VA = "0x1808BD980", Slot = "66")]
		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x06004820 RID: 18464 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004820")]
		[Address(RVA = "0x8BD8A0", Offset = "0x8BCAA0", VA = "0x1808BD8A0", Slot = "50")]
		public override string GetManagementName()
		{
			return null;
		}

		// Token: 0x06004821 RID: 18465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004821")]
		[Address(RVA = "0x8BED70", Offset = "0x8BDF70", VA = "0x1808BED70", Slot = "101")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
		}

		// Token: 0x06004822 RID: 18466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004822")]
		[Address(RVA = "0x8BEC40", Offset = "0x8BDE40", VA = "0x1808BEC40", Slot = "102")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
		}

		// Token: 0x06004823 RID: 18467 RVA: 0x00013920 File Offset: 0x00011B20
		[Token(Token = "0x6004823")]
		[Address(RVA = "0x8BD2A0", Offset = "0x8BC4A0", VA = "0x1808BD2A0", Slot = "55")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x06004824 RID: 18468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004824")]
		[Address(RVA = "0x8BD690", Offset = "0x8BC890", VA = "0x1808BD690", Slot = "56")]
		protected override void Destroy()
		{
		}

		// Token: 0x06004825 RID: 18469 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004825")]
		[Address(RVA = "0x8BD760", Offset = "0x8BC960", VA = "0x1808BD760", Slot = "61")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x06004826 RID: 18470 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004826")]
		[Address(RVA = "0x8BD8D0", Offset = "0x8BCAD0", VA = "0x1808BD8D0", Slot = "60")]
		public override DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x06004827 RID: 18471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004827")]
		[Address(RVA = "0x8BDB60", Offset = "0x8BCD60", VA = "0x1808BDB60")]
		private void NameChanged(string newName)
		{
		}

		// Token: 0x06004828 RID: 18472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004828")]
		[Address(RVA = "0x8BF090", Offset = "0x8BE290", VA = "0x1808BF090")]
		private void UpdateNameLabels()
		{
		}

		// Token: 0x06004829 RID: 18473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004829")]
		[Address(RVA = "0x8BEB10", Offset = "0x8BDD10", VA = "0x1808BEB10", Slot = "123")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
		}

		// Token: 0x0600482A RID: 18474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600482A")]
		[Address(RVA = "0x8BE9B0", Offset = "0x8BDBB0", VA = "0x1808BE9B0", Slot = "124")]
		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x0600482B RID: 18475 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600482B")]
		[Address(RVA = "0x8BD3A0", Offset = "0x8BC5A0", VA = "0x1808BD3A0", Slot = "117")]
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		// Token: 0x0600482C RID: 18476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600482C")]
		[Address(RVA = "0x8BD600", Offset = "0x8BC800", VA = "0x1808BD600", Slot = "118")]
		public void DestroyWorldspaceUI()
		{
		}

		// Token: 0x0600482D RID: 18477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600482D")]
		[Address(RVA = "0x8BF250", Offset = "0x8BE450", VA = "0x1808BF250")]
		public PlaceableStorageEntity()
		{
		}

		// Token: 0x0600482E RID: 18478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600482E")]
		[Address(RVA = "0x8BDC30", Offset = "0x8BCE30", VA = "0x1808BDC30", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600482F RID: 18479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600482F")]
		[Address(RVA = "0x8BDBA0", Offset = "0x8BCDA0", VA = "0x1808BDBA0", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004830 RID: 18480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004830")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004831 RID: 18481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004831")]
		[Address(RVA = "0x8BE880", Offset = "0x8BDA80", VA = "0x1808BE880")]
		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x06004832 RID: 18482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004832")]
		[Address(RVA = "0x8BE400", Offset = "0x8BD600", VA = "0x1808BE400", Slot = "125")]
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x06004833 RID: 18483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004833")]
		[Address(RVA = "0x8BE5A0", Offset = "0x8BD7A0", VA = "0x1808BE5A0")]
		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004834 RID: 18484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004834")]
		[Address(RVA = "0x8BE750", Offset = "0x8BD950", VA = "0x1808BE750")]
		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x06004835 RID: 18485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004835")]
		[Address(RVA = "0x8BE360", Offset = "0x8BD560", VA = "0x1808BE360", Slot = "126")]
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x06004836 RID: 18486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004836")]
		[Address(RVA = "0x8BE520", Offset = "0x8BD720", VA = "0x1808BE520")]
		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004837 RID: 18487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004837")]
		[Address(RVA = "0x8BE620", Offset = "0x8BD820", VA = "0x1808BE620")]
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06004838 RID: 18488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004838")]
		[Address(RVA = "0x8BE2C0", Offset = "0x8BD4C0", VA = "0x1808BE2C0", Slot = "127")]
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06004839 RID: 18489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004839")]
		[Address(RVA = "0x8BE4A0", Offset = "0x8BD6A0", VA = "0x1808BE4A0")]
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x0600483A RID: 18490 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600483B RID: 18491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B4B")]
		public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[Token(Token = "0x600483A")]
			[Address(RVA = "0x66B880", Offset = "0x66AA80", VA = "0x18066B880")]
			get
			{
				return null;
			}
			[Token(Token = "0x600483B")]
			[Address(RVA = "0x8BF490", Offset = "0x8BE690", VA = "0x1808BF490")]
			set
			{
			}
		}

		// Token: 0x0600483C RID: 18492 RVA: 0x00013938 File Offset: 0x00011B38
		[Token(Token = "0x600483C")]
		[Address(RVA = "0x8BE120", Offset = "0x8BD320", VA = "0x1808BE120", Slot = "128")]
		public virtual bool ReadSyncVar___ScheduleOne.ObjectScripts.PlaceableStorageEntity(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x0600483D RID: 18493 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600483E RID: 18494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B4C")]
		public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[Token(Token = "0x600483D")]
			[Address(RVA = "0x835000", Offset = "0x834200", VA = "0x180835000")]
			get
			{
				return null;
			}
			[Token(Token = "0x600483E")]
			[Address(RVA = "0x8BF550", Offset = "0x8BE750", VA = "0x1808BF550")]
			set
			{
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x0600483F RID: 18495 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004840 RID: 18496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B4D")]
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[Token(Token = "0x600483F")]
			[Address(RVA = "0x66B4D0", Offset = "0x66A6D0", VA = "0x18066B4D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004840")]
			[Address(RVA = "0x8BF3D0", Offset = "0x8BE5D0", VA = "0x1808BF3D0")]
			set
			{
			}
		}

		// Token: 0x06004841 RID: 18497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004841")]
		[Address(RVA = "0x8BD1B0", Offset = "0x8BC3B0", VA = "0x1808BD1B0", Slot = "129")]
		protected virtual void Awake_UserLogic_ScheduleOne.ObjectScripts.PlaceableStorageEntity_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040032F8 RID: 13048
		[Token(Token = "0x40032F8")]
		[FieldOffset(Offset = "0x210")]
		[Header("References")]
		public StorageEntity StorageEntity;

		// Token: 0x040032F9 RID: 13049
		[Token(Token = "0x40032F9")]
		[FieldOffset(Offset = "0x218")]
		public Transform[] accessPoints;

		// Token: 0x040032FA RID: 13050
		[Token(Token = "0x40032FA")]
		[FieldOffset(Offset = "0x220")]
		[SerializeField]
		private Transform _linkOrigin;

		// Token: 0x040032FB RID: 13051
		[Token(Token = "0x40032FB")]
		[FieldOffset(Offset = "0x228")]
		[SerializeField]
		private TextMeshPro[] _nameLabels;

		// Token: 0x040032FC RID: 13052
		[Token(Token = "0x40032FC")]
		[FieldOffset(Offset = "0x230")]
		[Header("Settings")]
		[SerializeField]
		private bool _showNameLabels;

		// Token: 0x040032FD RID: 13053
		[Token(Token = "0x40032FD")]
		[FieldOffset(Offset = "0x234")]
		[SerializeField]
		private PlaceableStorageEntity.ENameLabelVisibility _nameLabelVisibility;

		// Token: 0x04003306 RID: 13062
		[Token(Token = "0x4003306")]
		[FieldOffset(Offset = "0x270")]
		private EntityConfiguration _configuration;

		// Token: 0x04003307 RID: 13063
		[Token(Token = "0x4003307")]
		[FieldOffset(Offset = "0x278")]
		private ConfigurationReplicator _configReplicator;

		// Token: 0x04003308 RID: 13064
		[Token(Token = "0x4003308")]
		[FieldOffset(Offset = "0x280")]
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x04003309 RID: 13065
		[Token(Token = "0x4003309")]
		[FieldOffset(Offset = "0x288")]
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x0400330A RID: 13066
		[Token(Token = "0x400330A")]
		[FieldOffset(Offset = "0x290")]
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x0400330B RID: 13067
		[Token(Token = "0x400330B")]
		[FieldOffset(Offset = "0x298")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.PlaceableStorageEntityAssembly-CSharp.dll_Excuted;

		// Token: 0x0400330C RID: 13068
		[Token(Token = "0x400330C")]
		[FieldOffset(Offset = "0x299")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.PlaceableStorageEntityAssembly-CSharp.dll_Excuted;

		// Token: 0x020009D6 RID: 2518
		[Token(Token = "0x20009D6")]
		private enum ENameLabelVisibility
		{
			// Token: 0x0400330E RID: 13070
			[Token(Token = "0x400330E")]
			None,
			// Token: 0x0400330F RID: 13071
			[Token(Token = "0x400330F")]
			WhenNotDefault,
			// Token: 0x04003310 RID: 13072
			[Token(Token = "0x4003310")]
			Always
		}
	}
}
