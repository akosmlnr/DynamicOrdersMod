using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Money;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x020008C8 RID: 2248
	[Token(Token = "0x20008C8")]
	public class StorageEntity : NetworkBehaviour, IItemSlotOwner
	{
		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06003BAE RID: 15278 RVA: 0x000114A8 File Offset: 0x0000F6A8
		[Token(Token = "0x17000954")]
		public bool IsOpened
		{
			[Token(Token = "0x6003BAE")]
			[Address(RVA = "0x8244F0", Offset = "0x8236F0", VA = "0x1808244F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06003BAF RID: 15279 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003BB0 RID: 15280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000955")]
		public Player CurrentPlayerAccessor
		{
			[Token(Token = "0x6003BAF")]
			[Address(RVA = "0x5AF080", Offset = "0x5AE280", VA = "0x1805AF080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003BB0")]
			[Address(RVA = "0x5AF0A0", Offset = "0x5AE2A0", VA = "0x1805AF0A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06003BB1 RID: 15281 RVA: 0x000114C0 File Offset: 0x0000F6C0
		[Token(Token = "0x17000956")]
		public int ItemCount
		{
			[Token(Token = "0x6003BB1")]
			[Address(RVA = "0x824550", Offset = "0x823750", VA = "0x180824550")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06003BB2 RID: 15282 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003BB3 RID: 15283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000957")]
		public List<ItemSlot> ItemSlots
		{
			[Token(Token = "0x6003BB2")]
			[Address(RVA = "0x6BCCA0", Offset = "0x6BBEA0", VA = "0x1806BCCA0", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003BB3")]
			[Address(RVA = "0x6BCD20", Offset = "0x6BBF20", VA = "0x1806BCD20", Slot = "20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003BB4 RID: 15284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BB4")]
		[Address(RVA = "0x81F0B0", Offset = "0x81E2B0", VA = "0x18081F0B0", Slot = "30")]
		public virtual void Awake()
		{
		}

		// Token: 0x06003BB5 RID: 15285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BB5")]
		[Address(RVA = "0x824040", Offset = "0x823240", VA = "0x180824040", Slot = "31")]
		protected virtual void Start()
		{
		}

		// Token: 0x06003BB6 RID: 15286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BB6")]
		[Address(RVA = "0x8204B0", Offset = "0x81F6B0", VA = "0x1808204B0", Slot = "32")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06003BB7 RID: 15287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BB7")]
		[Address(RVA = "0x81F9C0", Offset = "0x81EBC0", VA = "0x18081F9C0")]
		private void GetNetworth(MoneyManager.FloatContainer container)
		{
		}

		// Token: 0x06003BB8 RID: 15288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BB8")]
		[Address(RVA = "0x8207A0", Offset = "0x81F9A0", VA = "0x1808207A0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06003BB9 RID: 15289 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003BB9")]
		[Address(RVA = "0x824370", Offset = "0x823570", VA = "0x180824370")]
		private IEnumerator UpdateWhileOpen()
		{
			return null;
		}

		// Token: 0x06003BBA RID: 15290 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003BBA")]
		[Address(RVA = "0x81F6B0", Offset = "0x81E8B0", VA = "0x18081F6B0")]
		public Dictionary<StorableItemInstance, int> GetContentsDictionary()
		{
			return null;
		}

		// Token: 0x06003BBB RID: 15291 RVA: 0x000114D8 File Offset: 0x0000F6D8
		[Token(Token = "0x6003BBB")]
		[Address(RVA = "0x81F350", Offset = "0x81E550", VA = "0x18081F350")]
		public bool CanItemFit(ItemInstance item, int quantity = 1)
		{
			return default(bool);
		}

		// Token: 0x06003BBC RID: 15292 RVA: 0x000114F0 File Offset: 0x0000F6F0
		[Token(Token = "0x6003BBC")]
		[Address(RVA = "0x81FAC0", Offset = "0x81ECC0", VA = "0x18081FAC0")]
		public int HowManyCanFit(ItemInstance item)
		{
			return 0;
		}

		// Token: 0x06003BBD RID: 15293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BBD")]
		[Address(RVA = "0x81FCC0", Offset = "0x81EEC0", VA = "0x18081FCC0")]
		public void InsertItem(ItemInstance item, bool network = true)
		{
		}

		// Token: 0x06003BBE RID: 15294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BBE")]
		[Address(RVA = "0x6E2E30", Offset = "0x6E2030", VA = "0x1806E2E30", Slot = "33")]
		protected virtual void ContentsChanged()
		{
		}

		// Token: 0x06003BBF RID: 15295 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003BBF")]
		[Address(RVA = "0x81F590", Offset = "0x81E790", VA = "0x18081F590")]
		public List<ItemInstance> GetAllItems()
		{
			return null;
		}

		// Token: 0x06003BC0 RID: 15296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BC0")]
		[Address(RVA = "0x81FFB0", Offset = "0x81F1B0", VA = "0x18081FFB0")]
		public void LoadFromItemSet(ItemInstance[] items)
		{
		}

		// Token: 0x06003BC1 RID: 15297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BC1")]
		[Address(RVA = "0x81F370", Offset = "0x81E570", VA = "0x18081F370")]
		public void ClearContents()
		{
		}

		// Token: 0x06003BC2 RID: 15298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BC2")]
		[Address(RVA = "0x8208C0", Offset = "0x81FAC0", VA = "0x1808208C0")]
		public void Open()
		{
		}

		// Token: 0x06003BC3 RID: 15299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BC3")]
		[Address(RVA = "0x81F420", Offset = "0x81E620", VA = "0x18081F420")]
		public void Close()
		{
		}

		// Token: 0x06003BC4 RID: 15300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BC4")]
		[Address(RVA = "0x820770", Offset = "0x81F970", VA = "0x180820770", Slot = "34")]
		protected virtual void OnOpened()
		{
		}

		// Token: 0x06003BC5 RID: 15301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BC5")]
		[Address(RVA = "0x820480", Offset = "0x81F680", VA = "0x180820480", Slot = "35")]
		protected virtual void OnClosed()
		{
		}

		// Token: 0x06003BC6 RID: 15302 RVA: 0x00011508 File Offset: 0x0000F708
		[Token(Token = "0x6003BC6")]
		[Address(RVA = "0x81F270", Offset = "0x81E470", VA = "0x18081F270", Slot = "36")]
		public virtual bool CanBeOpened()
		{
			return default(bool);
		}

		// Token: 0x06003BC7 RID: 15303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BC7")]
		[Address(RVA = "0x822E20", Offset = "0x822020", VA = "0x180822E20")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		private void SendAccessor(NetworkObject accessor)
		{
		}

		// Token: 0x06003BC8 RID: 15304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BC8")]
		[Address(RVA = "0x820A00", Offset = "0x81FC00", VA = "0x180820A00")]
		[ObserversRpc(RunLocally = true)]
		private void SetAccessor(NetworkObject accessor)
		{
		}

		// Token: 0x06003BC9 RID: 15305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BC9")]
		[Address(RVA = "0x823EA0", Offset = "0x8230A0", VA = "0x180823EA0", Slot = "21")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06003BCA RID: 15306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BCA")]
		[Address(RVA = "0x823BE0", Offset = "0x822DE0", VA = "0x180823BE0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06003BCB RID: 15307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BCB")]
		[Address(RVA = "0x823100", Offset = "0x822300", VA = "0x180823100", Slot = "22")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06003BCC RID: 15308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BCC")]
		[Address(RVA = "0x822F50", Offset = "0x822150", VA = "0x180822F50")]
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06003BCD RID: 15309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BCD")]
		[Address(RVA = "0x8239F0", Offset = "0x822BF0", VA = "0x1808239F0", Slot = "23")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06003BCE RID: 15310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BCE")]
		[Address(RVA = "0x8236D0", Offset = "0x8228D0", VA = "0x1808236D0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06003BCF RID: 15311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BCF")]
		[Address(RVA = "0x823530", Offset = "0x822730", VA = "0x180823530", Slot = "24")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06003BD0 RID: 15312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BD0")]
		[Address(RVA = "0x823270", Offset = "0x822470", VA = "0x180823270")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06003BD1 RID: 15313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BD1")]
		[Address(RVA = "0x8243E0", Offset = "0x8235E0", VA = "0x1808243E0")]
		public StorageEntity()
		{
		}

		// Token: 0x06003BD2 RID: 15314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BD2")]
		[Address(RVA = "0x8242C0", Offset = "0x8234C0", VA = "0x1808242C0")]
		[CompilerGenerated]
		private void <OnSpawnServer>g__ReplicateInventory|29_0(NetworkConnection conn)
		{
		}

		// Token: 0x06003BD3 RID: 15315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BD3")]
		[Address(RVA = "0x8200C0", Offset = "0x81F2C0", VA = "0x1808200C0", Slot = "37")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003BD4 RID: 15316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BD4")]
		[Address(RVA = "0x67A9A0", Offset = "0x679BA0", VA = "0x18067A9A0", Slot = "38")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003BD5 RID: 15317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BD5")]
		[Address(RVA = "0x820080", Offset = "0x81F280", VA = "0x180820080", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003BD6 RID: 15318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BD6")]
		[Address(RVA = "0x822290", Offset = "0x821490", VA = "0x180822290")]
		private void RpcWriter___Server_SendAccessor_3323014238(NetworkObject accessor)
		{
		}

		// Token: 0x06003BD7 RID: 15319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BD7")]
		[Address(RVA = "0x820A00", Offset = "0x81FC00", VA = "0x180820A00")]
		private void RpcLogic___SendAccessor_3323014238(NetworkObject accessor)
		{
		}

		// Token: 0x06003BD8 RID: 15320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BD8")]
		[Address(RVA = "0x8214C0", Offset = "0x8206C0", VA = "0x1808214C0")]
		private void RpcReader___Server_SendAccessor_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003BD9 RID: 15321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BD9")]
		[Address(RVA = "0x821B30", Offset = "0x820D30", VA = "0x180821B30")]
		private void RpcWriter___Observers_SetAccessor_3323014238(NetworkObject accessor)
		{
		}

		// Token: 0x06003BDA RID: 15322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BDA")]
		[Address(RVA = "0x820B40", Offset = "0x81FD40", VA = "0x180820B40")]
		private void RpcLogic___SetAccessor_3323014238(NetworkObject accessor)
		{
		}

		// Token: 0x06003BDB RID: 15323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BDB")]
		[Address(RVA = "0x8211A0", Offset = "0x8203A0", VA = "0x1808211A0")]
		private void RpcReader___Observers_SetAccessor_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003BDC RID: 15324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BDC")]
		[Address(RVA = "0x822840", Offset = "0x821A40", VA = "0x180822840")]
		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06003BDD RID: 15325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BDD")]
		[Address(RVA = "0x821060", Offset = "0x820260", VA = "0x180821060", Slot = "39")]
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06003BDE RID: 15326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BDE")]
		[Address(RVA = "0x821830", Offset = "0x820A30", VA = "0x180821830")]
		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003BDF RID: 15327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BDF")]
		[Address(RVA = "0x822110", Offset = "0x821310", VA = "0x180822110")]
		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06003BE0 RID: 15328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE0")]
		[Address(RVA = "0x8210E0", Offset = "0x8202E0", VA = "0x1808210E0")]
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06003BE1 RID: 15329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE1")]
		[Address(RVA = "0x821430", Offset = "0x820630", VA = "0x180821430")]
		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003BE2 RID: 15330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE2")]
		[Address(RVA = "0x822CB0", Offset = "0x821EB0", VA = "0x180822CB0")]
		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06003BE3 RID: 15331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE3")]
		[Address(RVA = "0x821AA0", Offset = "0x820CA0", VA = "0x180821AA0")]
		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003BE4 RID: 15332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE4")]
		[Address(RVA = "0x8223C0", Offset = "0x8215C0", VA = "0x1808223C0")]
		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06003BE5 RID: 15333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE5")]
		[Address(RVA = "0x820DA0", Offset = "0x81FFA0", VA = "0x180820DA0", Slot = "40")]
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06003BE6 RID: 15334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE6")]
		[Address(RVA = "0x821540", Offset = "0x820740", VA = "0x180821540")]
		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003BE7 RID: 15335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE7")]
		[Address(RVA = "0x821C70", Offset = "0x820E70", VA = "0x180821C70")]
		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06003BE8 RID: 15336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE8")]
		[Address(RVA = "0x820DB0", Offset = "0x81FFB0", VA = "0x180820DB0")]
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06003BE9 RID: 15337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE9")]
		[Address(RVA = "0x821210", Offset = "0x820410", VA = "0x180821210")]
		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003BEA RID: 15338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BEA")]
		[Address(RVA = "0x8226B0", Offset = "0x8218B0", VA = "0x1808226B0")]
		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06003BEB RID: 15339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BEB")]
		[Address(RVA = "0x820F30", Offset = "0x820130", VA = "0x180820F30", Slot = "41")]
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06003BEC RID: 15340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BEC")]
		[Address(RVA = "0x8216E0", Offset = "0x8208E0", VA = "0x1808216E0")]
		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003BED RID: 15341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BED")]
		[Address(RVA = "0x822B20", Offset = "0x821D20", VA = "0x180822B20")]
		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06003BEE RID: 15342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BEE")]
		[Address(RVA = "0x820FB0", Offset = "0x8201B0", VA = "0x180820FB0")]
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06003BEF RID: 15343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BEF")]
		[Address(RVA = "0x8219B0", Offset = "0x820BB0", VA = "0x1808219B0")]
		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003BF0 RID: 15344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF0")]
		[Address(RVA = "0x821F70", Offset = "0x821170", VA = "0x180821F70")]
		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06003BF1 RID: 15345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF1")]
		[Address(RVA = "0x821340", Offset = "0x820540", VA = "0x180821340")]
		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003BF2 RID: 15346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF2")]
		[Address(RVA = "0x822540", Offset = "0x821740", VA = "0x180822540")]
		private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06003BF3 RID: 15347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF3")]
		[Address(RVA = "0x820E30", Offset = "0x820030", VA = "0x180820E30", Slot = "42")]
		public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06003BF4 RID: 15348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF4")]
		[Address(RVA = "0x8215F0", Offset = "0x8207F0", VA = "0x1808215F0")]
		private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003BF5 RID: 15349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF5")]
		[Address(RVA = "0x821DF0", Offset = "0x820FF0", VA = "0x180821DF0")]
		private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06003BF6 RID: 15350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF6")]
		[Address(RVA = "0x820EB0", Offset = "0x8200B0", VA = "0x180820EB0")]
		private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06003BF7 RID: 15351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF7")]
		[Address(RVA = "0x8212B0", Offset = "0x8204B0", VA = "0x1808212B0")]
		private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003BF8 RID: 15352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF8")]
		[Address(RVA = "0x8229B0", Offset = "0x821BB0", VA = "0x1808229B0")]
		private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06003BF9 RID: 15353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF9")]
		[Address(RVA = "0x821920", Offset = "0x820B20", VA = "0x180821920")]
		private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003BFA RID: 15354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BFA")]
		[Address(RVA = "0x81EF10", Offset = "0x81E110", VA = "0x18081EF10", Slot = "43")]
		protected virtual void Awake_UserLogic_ScheduleOne.Storage.StorageEntity_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002C02 RID: 11266
		[Token(Token = "0x4002C02")]
		public const int MAX_SLOTS = 20;

		// Token: 0x04002C04 RID: 11268
		[Token(Token = "0x4002C04")]
		[FieldOffset(Offset = "0x120")]
		[Header("Settings")]
		public string StorageEntityName;

		// Token: 0x04002C05 RID: 11269
		[Token(Token = "0x4002C05")]
		[FieldOffset(Offset = "0x128")]
		public string StorageEntitySubtitle;

		// Token: 0x04002C06 RID: 11270
		[Token(Token = "0x4002C06")]
		[FieldOffset(Offset = "0x130")]
		[Range(1f, 20f)]
		public int SlotCount;

		// Token: 0x04002C07 RID: 11271
		[Token(Token = "0x4002C07")]
		[FieldOffset(Offset = "0x134")]
		public bool EmptyOnSleep;

		// Token: 0x04002C08 RID: 11272
		[Token(Token = "0x4002C08")]
		[FieldOffset(Offset = "0x135")]
		public bool SlotsAreFilterable;

		// Token: 0x04002C09 RID: 11273
		[Token(Token = "0x4002C09")]
		[FieldOffset(Offset = "0x138")]
		[Header("Display Settings")]
		[Range(1f, 5f)]
		[Tooltip("How many rows to enforce when display contents in StorageMenu")]
		public int DisplayRowCount;

		// Token: 0x04002C0A RID: 11274
		[Token(Token = "0x4002C0A")]
		[FieldOffset(Offset = "0x13C")]
		[Header("Access Settings")]
		public StorageEntity.EAccessSettings AccessSettings;

		// Token: 0x04002C0B RID: 11275
		[Token(Token = "0x4002C0B")]
		[FieldOffset(Offset = "0x140")]
		[Tooltip("If the distance between this StorageEntity and the player is greater than this, the StorageMenu will be closed.")]
		[Range(0f, 10f)]
		public float MaxAccessDistance;

		// Token: 0x04002C0D RID: 11277
		[Token(Token = "0x4002C0D")]
		[FieldOffset(Offset = "0x150")]
		public Action onOpened;

		// Token: 0x04002C0E RID: 11278
		[Token(Token = "0x4002C0E")]
		[FieldOffset(Offset = "0x158")]
		public Action onClosed;

		// Token: 0x04002C0F RID: 11279
		[Token(Token = "0x4002C0F")]
		[FieldOffset(Offset = "0x160")]
		public Action onContentsChanged;

		// Token: 0x04002C10 RID: 11280
		[Token(Token = "0x4002C10")]
		[FieldOffset(Offset = "0x168")]
		private bool NetworkInitialize___EarlyScheduleOne.Storage.StorageEntityAssembly-CSharp.dll_Excuted;

		// Token: 0x04002C11 RID: 11281
		[Token(Token = "0x4002C11")]
		[FieldOffset(Offset = "0x169")]
		private bool NetworkInitialize__LateScheduleOne.Storage.StorageEntityAssembly-CSharp.dll_Excuted;

		// Token: 0x020008C9 RID: 2249
		[Token(Token = "0x20008C9")]
		public enum EAccessSettings
		{
			// Token: 0x04002C13 RID: 11283
			[Token(Token = "0x4002C13")]
			Closed,
			// Token: 0x04002C14 RID: 11284
			[Token(Token = "0x4002C14")]
			SinglePlayerOnly,
			// Token: 0x04002C15 RID: 11285
			[Token(Token = "0x4002C15")]
			Full
		}
	}
}
