using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs
{
	// Token: 0x02000A4E RID: 2638
	[Token(Token = "0x2000A4E")]
	public class NPCInventory : NetworkBehaviour, IItemSlotOwner
	{
		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x06004BCF RID: 19407 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004BD0 RID: 19408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BCB")]
		public List<ItemSlot> ItemSlots
		{
			[Token(Token = "0x6004BCF")]
			[Address(RVA = "0x5887E0", Offset = "0x5879E0", VA = "0x1805887E0", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004BD0")]
			[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880", Slot = "20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004BD1 RID: 19409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BD1")]
		[Address(RVA = "0x91B5E0", Offset = "0x91A7E0", VA = "0x18091B5E0", Slot = "30")]
		public virtual void Awake()
		{
		}

		// Token: 0x06004BD2 RID: 19410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BD2")]
		[Address(RVA = "0x920930", Offset = "0x91FB30", VA = "0x180920930", Slot = "31")]
		protected virtual void Start()
		{
		}

		// Token: 0x06004BD3 RID: 19411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BD3")]
		[Address(RVA = "0x91D530", Offset = "0x91C730", VA = "0x18091D530", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06004BD4 RID: 19412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BD4")]
		[Address(RVA = "0x91D0A0", Offset = "0x91C2A0", VA = "0x18091D0A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004BD5 RID: 19413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BD5")]
		[Address(RVA = "0x91D210", Offset = "0x91C410", VA = "0x18091D210", Slot = "32")]
		protected virtual void OnSleepStart()
		{
		}

		// Token: 0x06004BD6 RID: 19414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BD6")]
		[Address(RVA = "0x91B0F0", Offset = "0x91A2F0", VA = "0x18091B0F0")]
		public void AddRandomItemsToInventory()
		{
		}

		// Token: 0x06004BD7 RID: 19415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BD7")]
		[Address(RVA = "0x91B030", Offset = "0x91A230", VA = "0x18091B030")]
		private void AddRandomCashInstance()
		{
		}

		// Token: 0x06004BD8 RID: 19416 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004BD8")]
		[Address(RVA = "0x91C2A0", Offset = "0x91B4A0", VA = "0x18091C2A0")]
		private StorableItemDefinition GetRandomInventoryItem(List<string> excludeIDs)
		{
			return null;
		}

		// Token: 0x06004BD9 RID: 19417 RVA: 0x000146B8 File Offset: 0x000128B8
		[Token(Token = "0x6004BD9")]
		[Address(RVA = "0x91C6A0", Offset = "0x91B8A0", VA = "0x18091C6A0")]
		[Button]
		public float GetTotalRandomInventoryItemWeight()
		{
			return 0f;
		}

		// Token: 0x06004BDA RID: 19418 RVA: 0x000146D0 File Offset: 0x000128D0
		[Token(Token = "0x6004BDA")]
		[Address(RVA = "0x91BFC0", Offset = "0x91B1C0", VA = "0x18091BFC0")]
		public int GetIdenticalItemAmount(ItemInstance item)
		{
			return 0;
		}

		// Token: 0x06004BDB RID: 19419 RVA: 0x000146E8 File Offset: 0x000128E8
		[Token(Token = "0x6004BDB")]
		[Address(RVA = "0x91C110", Offset = "0x91B310", VA = "0x18091C110")]
		public int GetMaxItemCount(string[] ids)
		{
			return 0;
		}

		// Token: 0x06004BDC RID: 19420 RVA: 0x00014700 File Offset: 0x00012900
		[Token(Token = "0x6004BDC")]
		[Address(RVA = "0x91B630", Offset = "0x91A830", VA = "0x18091B630")]
		public bool CanItemFit(ItemInstance item)
		{
			return default(bool);
		}

		// Token: 0x06004BDD RID: 19421 RVA: 0x00014718 File Offset: 0x00012918
		[Token(Token = "0x6004BDD")]
		[Address(RVA = "0x91B9A0", Offset = "0x91ABA0", VA = "0x18091B9A0")]
		public int GetCapacityForItem(ItemInstance item)
		{
			return 0;
		}

		// Token: 0x06004BDE RID: 19422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BDE")]
		[Address(RVA = "0x91C880", Offset = "0x91BA80", VA = "0x18091C880")]
		public void InsertItem(ItemInstance item, bool network = true)
		{
		}

		// Token: 0x06004BDF RID: 19423 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004BDF")]
		[Address(RVA = "0x91BE40", Offset = "0x91B040", VA = "0x18091BE40")]
		public ItemInstance GetFirstItem(string id, [Optional] NPCInventory.ItemFilter filter)
		{
			return null;
		}

		// Token: 0x06004BE0 RID: 19424 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004BE0")]
		[Address(RVA = "0x91BCC0", Offset = "0x91AEC0", VA = "0x18091BCC0")]
		public ItemInstance GetFirstIdenticalItem(ItemInstance item, [Optional] NPCInventory.ItemFilter filter)
		{
			return null;
		}

		// Token: 0x06004BE1 RID: 19425 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004BE1")]
		[Address(RVA = "0x91C4E0", Offset = "0x91B6E0", VA = "0x18091C4E0")]
		public List<ItemSlot> GetSlots(Func<ItemSlot, bool> predicate)
		{
			return null;
		}

		// Token: 0x06004BE2 RID: 19426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BE2")]
		[Address(RVA = "0x91CD20", Offset = "0x91BF20", VA = "0x18091CD20", Slot = "33")]
		protected virtual void InventoryContentsChanged()
		{
		}

		// Token: 0x06004BE3 RID: 19427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BE3")]
		[Address(RVA = "0x91C7C0", Offset = "0x91B9C0", VA = "0x18091C7C0")]
		public void Hovered()
		{
		}

		// Token: 0x06004BE4 RID: 19428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BE4")]
		[Address(RVA = "0x91CC80", Offset = "0x91BE80", VA = "0x18091CC80")]
		public void Interacted()
		{
		}

		// Token: 0x06004BE5 RID: 19429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BE5")]
		[Address(RVA = "0x9208A0", Offset = "0x91FAA0", VA = "0x1809208A0")]
		private void StartPickpocket()
		{
		}

		// Token: 0x06004BE6 RID: 19430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BE6")]
		[Address(RVA = "0x91B980", Offset = "0x91AB80", VA = "0x18091B980")]
		public void ExpirePickpocket()
		{
		}

		// Token: 0x06004BE7 RID: 19431 RVA: 0x00014730 File Offset: 0x00012930
		[Token(Token = "0x6004BE7")]
		[Address(RVA = "0x91B660", Offset = "0x91A860", VA = "0x18091B660")]
		private bool CanPickpocket()
		{
			return default(bool);
		}

		// Token: 0x06004BE8 RID: 19432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BE8")]
		[Address(RVA = "0x91D6B0", Offset = "0x91C8B0", VA = "0x18091D6B0")]
		[Button]
		public void PrintInventoryContents()
		{
		}

		// Token: 0x06004BE9 RID: 19433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BE9")]
		[Address(RVA = "0x91B8D0", Offset = "0x91AAD0", VA = "0x18091B8D0")]
		public void Clear()
		{
		}

		// Token: 0x06004BEA RID: 19434 RVA: 0x00014748 File Offset: 0x00012948
		[Token(Token = "0x6004BEA")]
		[Address(RVA = "0x91BBD0", Offset = "0x91ADD0", VA = "0x18091BBD0")]
		public float GetCashInInventory()
		{
			return 0f;
		}

		// Token: 0x06004BEB RID: 19435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BEB")]
		[Address(RVA = "0x91D940", Offset = "0x91CB40", VA = "0x18091D940")]
		public void RemoveCash(float amountToRemove)
		{
		}

		// Token: 0x06004BEC RID: 19436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BEC")]
		[Address(RVA = "0x91AF20", Offset = "0x91A120", VA = "0x18091AF20")]
		public void AddCash(float amountToAdd)
		{
		}

		// Token: 0x06004BED RID: 19437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BED")]
		[Address(RVA = "0x920700", Offset = "0x91F900", VA = "0x180920700", Slot = "21")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004BEE RID: 19438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BEE")]
		[Address(RVA = "0x920440", Offset = "0x91F640", VA = "0x180920440")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004BEF RID: 19439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BEF")]
		[Address(RVA = "0x91F960", Offset = "0x91EB60", VA = "0x18091F960", Slot = "22")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06004BF0 RID: 19440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BF0")]
		[Address(RVA = "0x91F7B0", Offset = "0x91E9B0", VA = "0x18091F7B0")]
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06004BF1 RID: 19441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BF1")]
		[Address(RVA = "0x920250", Offset = "0x91F450", VA = "0x180920250", Slot = "23")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004BF2 RID: 19442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BF2")]
		[Address(RVA = "0x91FF30", Offset = "0x91F130", VA = "0x18091FF30")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004BF3 RID: 19443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BF3")]
		[Address(RVA = "0x91FD90", Offset = "0x91EF90", VA = "0x18091FD90", Slot = "24")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004BF4 RID: 19444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BF4")]
		[Address(RVA = "0x91FAD0", Offset = "0x91ECD0", VA = "0x18091FAD0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004BF5 RID: 19445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BF5")]
		[Address(RVA = "0x920B80", Offset = "0x91FD80", VA = "0x180920B80")]
		public NPCInventory()
		{
		}

		// Token: 0x06004BF6 RID: 19446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BF6")]
		[Address(RVA = "0x91CD60", Offset = "0x91BF60", VA = "0x18091CD60", Slot = "34")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004BF7 RID: 19447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BF7")]
		[Address(RVA = "0x91CD40", Offset = "0x91BF40", VA = "0x18091CD40", Slot = "35")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004BF8 RID: 19448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BF8")]
		[Address(RVA = "0x85A600", Offset = "0x859800", VA = "0x18085A600", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004BF9 RID: 19449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BF9")]
		[Address(RVA = "0x91F1D0", Offset = "0x91E3D0", VA = "0x18091F1D0")]
		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004BFA RID: 19450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BFA")]
		[Address(RVA = "0x91DD50", Offset = "0x91CF50", VA = "0x18091DD50", Slot = "36")]
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004BFB RID: 19451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BFB")]
		[Address(RVA = "0x91E430", Offset = "0x91D630", VA = "0x18091E430")]
		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004BFC RID: 19452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BFC")]
		[Address(RVA = "0x91EBD0", Offset = "0x91DDD0", VA = "0x18091EBD0")]
		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004BFD RID: 19453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BFD")]
		[Address(RVA = "0x91DDD0", Offset = "0x91CFD0", VA = "0x18091DDD0")]
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004BFE RID: 19454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BFE")]
		[Address(RVA = "0x91E0B0", Offset = "0x91D2B0", VA = "0x18091E0B0")]
		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004BFF RID: 19455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BFF")]
		[Address(RVA = "0x91F640", Offset = "0x91E840", VA = "0x18091F640")]
		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004C00 RID: 19456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C00")]
		[Address(RVA = "0x91E6A0", Offset = "0x91D8A0", VA = "0x18091E6A0")]
		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004C01 RID: 19457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C01")]
		[Address(RVA = "0x91ED50", Offset = "0x91DF50", VA = "0x18091ED50")]
		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06004C02 RID: 19458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C02")]
		[Address(RVA = "0x91DA90", Offset = "0x91CC90", VA = "0x18091DA90", Slot = "37")]
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06004C03 RID: 19459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C03")]
		[Address(RVA = "0x91E140", Offset = "0x91D340", VA = "0x18091E140")]
		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004C04 RID: 19460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C04")]
		[Address(RVA = "0x91E730", Offset = "0x91D930", VA = "0x18091E730")]
		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06004C05 RID: 19461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C05")]
		[Address(RVA = "0x91DAA0", Offset = "0x91CCA0", VA = "0x18091DAA0")]
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06004C06 RID: 19462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C06")]
		[Address(RVA = "0x91DE90", Offset = "0x91D090", VA = "0x18091DE90")]
		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004C07 RID: 19463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C07")]
		[Address(RVA = "0x91F040", Offset = "0x91E240", VA = "0x18091F040")]
		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004C08 RID: 19464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C08")]
		[Address(RVA = "0x91DC20", Offset = "0x91CE20", VA = "0x18091DC20", Slot = "38")]
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004C09 RID: 19465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C09")]
		[Address(RVA = "0x91E2E0", Offset = "0x91D4E0", VA = "0x18091E2E0")]
		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004C0A RID: 19466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C0A")]
		[Address(RVA = "0x91F4B0", Offset = "0x91E6B0", VA = "0x18091F4B0")]
		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004C0B RID: 19467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C0B")]
		[Address(RVA = "0x91DCA0", Offset = "0x91CEA0", VA = "0x18091DCA0")]
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004C0C RID: 19468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C0C")]
		[Address(RVA = "0x91E5B0", Offset = "0x91D7B0", VA = "0x18091E5B0")]
		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004C0D RID: 19469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C0D")]
		[Address(RVA = "0x91EA30", Offset = "0x91DC30", VA = "0x18091EA30")]
		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004C0E RID: 19470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C0E")]
		[Address(RVA = "0x91DFC0", Offset = "0x91D1C0", VA = "0x18091DFC0")]
		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004C0F RID: 19471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C0F")]
		[Address(RVA = "0x91EED0", Offset = "0x91E0D0", VA = "0x18091EED0")]
		private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004C10 RID: 19472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C10")]
		[Address(RVA = "0x91DB20", Offset = "0x91CD20", VA = "0x18091DB20", Slot = "39")]
		public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004C11 RID: 19473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C11")]
		[Address(RVA = "0x91E1F0", Offset = "0x91D3F0", VA = "0x18091E1F0")]
		private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004C12 RID: 19474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C12")]
		[Address(RVA = "0x91E8B0", Offset = "0x91DAB0", VA = "0x18091E8B0")]
		private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004C13 RID: 19475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C13")]
		[Address(RVA = "0x91DBA0", Offset = "0x91CDA0", VA = "0x18091DBA0")]
		private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004C14 RID: 19476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C14")]
		[Address(RVA = "0x91DF30", Offset = "0x91D130", VA = "0x18091DF30")]
		private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004C15 RID: 19477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C15")]
		[Address(RVA = "0x91F340", Offset = "0x91E540", VA = "0x18091F340")]
		private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004C16 RID: 19478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C16")]
		[Address(RVA = "0x91E520", Offset = "0x91D720", VA = "0x18091E520")]
		private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004C17 RID: 19479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C17")]
		[Address(RVA = "0x91B2A0", Offset = "0x91A4A0", VA = "0x18091B2A0", Slot = "40")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.NPCInventory_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003537 RID: 13623
		[Token(Token = "0x4003537")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public InteractableObject PickpocketIntObj;

		// Token: 0x04003538 RID: 13624
		[Token(Token = "0x4003538")]
		public const float COOLDOWN = 30f;

		// Token: 0x04003539 RID: 13625
		[Token(Token = "0x4003539")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[Header("Settings")]
		public int SlotCount;

		// Token: 0x0400353A RID: 13626
		[Token(Token = "0x400353A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public bool CanBePickpocketed;

		// Token: 0x0400353B RID: 13627
		[Token(Token = "0x400353B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public float PickpocketDifficultyMultiplier;

		// Token: 0x0400353C RID: 13628
		[Token(Token = "0x400353C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public bool ClearInventoryEachNight;

		// Token: 0x0400353D RID: 13629
		[Token(Token = "0x400353D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public ItemDefinition[] TestItems;

		// Token: 0x0400353E RID: 13630
		[Token(Token = "0x400353E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public ItemDefinition[] StartupItems;

		// Token: 0x0400353F RID: 13631
		[Token(Token = "0x400353F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[Header("Random cash")]
		public bool RandomCash;

		// Token: 0x04003540 RID: 13632
		[Token(Token = "0x4003540")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public int RandomCashMin;

		// Token: 0x04003541 RID: 13633
		[Token(Token = "0x4003541")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public int RandomCashMax;

		// Token: 0x04003542 RID: 13634
		[Token(Token = "0x4003542")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		[Header("Random items")]
		public bool RandomItems;

		// Token: 0x04003543 RID: 13635
		[Token(Token = "0x4003543")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14D")]
		public bool AllowDuplicateRandomItems;

		// Token: 0x04003544 RID: 13636
		[Token(Token = "0x4003544")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public NPCInventory.RandomInventoryItem[] RandomInventoryItems;

		// Token: 0x04003545 RID: 13637
		[Token(Token = "0x4003545")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public int RandomItemMin;

		// Token: 0x04003546 RID: 13638
		[Token(Token = "0x4003546")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		public int RandomItemMax;

		// Token: 0x04003547 RID: 13639
		[Token(Token = "0x4003547")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private NPC npc;

		// Token: 0x04003549 RID: 13641
		[Token(Token = "0x4003549")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public UnityEvent onContentsChanged;

		// Token: 0x0400354A RID: 13642
		[Token(Token = "0x400354A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float timeOnLastExpire;

		// Token: 0x0400354B RID: 13643
		[Token(Token = "0x400354B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.NPCInventoryAssembly-CSharp.dll_Excuted;

		// Token: 0x0400354C RID: 13644
		[Token(Token = "0x400354C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x17D")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.NPCInventoryAssembly-CSharp.dll_Excuted;

		// Token: 0x02000A4F RID: 2639
		[Token(Token = "0x2000A4F")]
		[Serializable]
		public class RandomInventoryItem
		{
			// Token: 0x06004C18 RID: 19480 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004C18")]
			[Address(RVA = "0x5D89D0", Offset = "0x5D7BD0", VA = "0x1805D89D0")]
			public RandomInventoryItem()
			{
			}

			// Token: 0x0400354D RID: 13645
			[Token(Token = "0x400354D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public StorableItemDefinition ItemDefinition;

			// Token: 0x0400354E RID: 13646
			[Token(Token = "0x400354E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0f, 10f)]
			public float Weight;
		}

		// Token: 0x02000A50 RID: 2640
		// (Invoke) Token: 0x06004C1A RID: 19482
		[Token(Token = "0x2000A50")]
		public delegate bool ItemFilter(ItemInstance item);
	}
}
