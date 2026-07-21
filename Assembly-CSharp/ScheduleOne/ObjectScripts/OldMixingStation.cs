using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.StationFramework;
using ScheduleOne.Storage;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x020009B3 RID: 2483
	[Token(Token = "0x20009B3")]
	public class OldMixingStation : GridItem, IUsable, IItemSlotOwner
	{
		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x0600457D RID: 17789 RVA: 0x00013308 File Offset: 0x00011508
		// (set) Token: 0x0600457E RID: 17790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ADF")]
		public bool IsOpen
		{
			[Token(Token = "0x600457D")]
			[Address(RVA = "0x803610", Offset = "0x802810", VA = "0x180803610")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600457E")]
			[Address(RVA = "0x803810", Offset = "0x802A10", VA = "0x180803810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x0600457F RID: 17791 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004580 RID: 17792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AE0")]
		public MixOperation CurrentMixOperation
		{
			[Token(Token = "0x600457F")]
			[Address(RVA = "0x5A44B0", Offset = "0x5A36B0", VA = "0x1805A44B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004580")]
			[Address(RVA = "0x5A4560", Offset = "0x5A3760", VA = "0x1805A4560")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06004581 RID: 17793 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004582 RID: 17794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AE1")]
		public List<ItemSlot> ItemSlots
		{
			[Token(Token = "0x6004581")]
			[Address(RVA = "0x803790", Offset = "0x802990", VA = "0x180803790", Slot = "81")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004582")]
			[Address(RVA = "0x803930", Offset = "0x802B30", VA = "0x180803930", Slot = "82")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06004583 RID: 17795 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004584 RID: 17796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AE2")]
		public NetworkObject NPCUserObject
		{
			[Token(Token = "0x6004583")]
			[Address(RVA = "0x66B880", Offset = "0x66AA80", VA = "0x18066B880", Slot = "73")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004584")]
			[Address(RVA = "0x8AD650", Offset = "0x8AC850", VA = "0x1808AD650", Slot = "74")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06004585 RID: 17797 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004586 RID: 17798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AE3")]
		public NetworkObject PlayerUserObject
		{
			[Token(Token = "0x6004585")]
			[Address(RVA = "0x835000", Offset = "0x834200", VA = "0x180835000", Slot = "75")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004586")]
			[Address(RVA = "0x8AD6F0", Offset = "0x8AC8F0", VA = "0x1808AD6F0", Slot = "76")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004587 RID: 17799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004587")]
		[Address(RVA = "0x8ABCC0", Offset = "0x8AAEC0", VA = "0x1808ABCC0", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x06004588 RID: 17800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004588")]
		[Address(RVA = "0x8B0F20", Offset = "0x8B0120", VA = "0x1808B0F20", Slot = "48")]
		protected override void Start()
		{
		}

		// Token: 0x06004589 RID: 17801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004589")]
		[Address(RVA = "0x8ACF30", Offset = "0x8AC130", VA = "0x1808ACF30", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x0600458A RID: 17802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600458A")]
		[Address(RVA = "0x8ABFF0", Offset = "0x8AB1F0", VA = "0x1808ABFF0", Slot = "56")]
		protected override void Destroy()
		{
		}

		// Token: 0x0600458B RID: 17803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600458B")]
		[Address(RVA = "0x8AC8A0", Offset = "0x8ABAA0", VA = "0x1808AC8A0")]
		private void MinPass()
		{
		}

		// Token: 0x0600458C RID: 17804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600458C")]
		[Address(RVA = "0x8AFCB0", Offset = "0x8AEEB0", VA = "0x1808AFCB0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetMixOperation(NetworkConnection conn, MixOperation operation)
		{
		}

		// Token: 0x0600458D RID: 17805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600458D")]
		[Address(RVA = "0x8AC250", Offset = "0x8AB450", VA = "0x1808AC250")]
		private void EnableScreen()
		{
		}

		// Token: 0x0600458E RID: 17806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600458E")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void UpdateScreen()
		{
		}

		// Token: 0x0600458F RID: 17807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600458F")]
		[Address(RVA = "0x8AC100", Offset = "0x8AB300", VA = "0x1808AC100")]
		private void DisableScreen()
		{
		}

		// Token: 0x06004590 RID: 17808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004590")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		public void CompleteMixOperation()
		{
		}

		// Token: 0x06004591 RID: 17809 RVA: 0x00013320 File Offset: 0x00011520
		[Token(Token = "0x6004591")]
		[Address(RVA = "0x8AC130", Offset = "0x8AB330", VA = "0x1808AC130")]
		public bool DoesOutputHaveSpace(StationRecipe recipe)
		{
			return default(bool);
		}

		// Token: 0x06004592 RID: 17810 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004592")]
		[Address(RVA = "0x8AC5E0", Offset = "0x8AB7E0", VA = "0x1808AC5E0")]
		public List<ItemInstance> GetIngredients()
		{
			return null;
		}

		// Token: 0x06004593 RID: 17811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004593")]
		[Address(RVA = "0x8ACF90", Offset = "0x8AC190", VA = "0x1808ACF90")]
		public void Open()
		{
		}

		// Token: 0x06004594 RID: 17812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004594")]
		[Address(RVA = "0x8ABD10", Offset = "0x8AAF10", VA = "0x1808ABD10")]
		public void Close()
		{
		}

		// Token: 0x06004595 RID: 17813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004595")]
		[Address(RVA = "0x8AC6B0", Offset = "0x8AB8B0", VA = "0x1808AC6B0")]
		public void Hovered()
		{
		}

		// Token: 0x06004596 RID: 17814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004596")]
		[Address(RVA = "0x8AC7F0", Offset = "0x8AB9F0", VA = "0x1808AC7F0")]
		public void Interacted()
		{
		}

		// Token: 0x06004597 RID: 17815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004597")]
		[Address(RVA = "0x8B0D90", Offset = "0x8AFF90", VA = "0x1808B0D90", Slot = "83")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004598 RID: 17816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004598")]
		[Address(RVA = "0x8B0AD0", Offset = "0x8AFCD0", VA = "0x1808B0AD0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004599 RID: 17817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004599")]
		[Address(RVA = "0x8AFB40", Offset = "0x8AED40", VA = "0x1808AFB40", Slot = "84")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600459A RID: 17818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600459A")]
		[Address(RVA = "0x8AF990", Offset = "0x8AEB90", VA = "0x1808AF990")]
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600459B RID: 17819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600459B")]
		[Address(RVA = "0x8B08F0", Offset = "0x8AFAF0", VA = "0x1808B08F0", Slot = "85")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x0600459C RID: 17820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600459C")]
		[Address(RVA = "0x8B05D0", Offset = "0x8AF7D0", VA = "0x1808B05D0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x0600459D RID: 17821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600459D")]
		[Address(RVA = "0x8B0430", Offset = "0x8AF630", VA = "0x1808B0430", Slot = "86")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600459E RID: 17822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600459E")]
		[Address(RVA = "0x8B0170", Offset = "0x8AF370", VA = "0x1808B0170")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600459F RID: 17823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600459F")]
		[Address(RVA = "0x8B0040", Offset = "0x8AF240", VA = "0x1808B0040", Slot = "79")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
		}

		// Token: 0x060045A0 RID: 17824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045A0")]
		[Address(RVA = "0x8AFF10", Offset = "0x8AF110", VA = "0x1808AFF10", Slot = "80")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
		}

		// Token: 0x060045A1 RID: 17825 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60045A1")]
		[Address(RVA = "0x8AC280", Offset = "0x8AB480", VA = "0x1808AC280", Slot = "61")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x060045A2 RID: 17826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045A2")]
		[Address(RVA = "0x8B1040", Offset = "0x8B0240", VA = "0x1808B1040")]
		public OldMixingStation()
		{
		}

		// Token: 0x060045A6 RID: 17830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045A6")]
		[Address(RVA = "0x8AC920", Offset = "0x8ABB20", VA = "0x1808AC920", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060045A7 RID: 17831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045A7")]
		[Address(RVA = "0x8AC8B0", Offset = "0x8ABAB0", VA = "0x1808AC8B0", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060045A8 RID: 17832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045A8")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060045A9 RID: 17833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045A9")]
		[Address(RVA = "0x8AE590", Offset = "0x8AD790", VA = "0x1808AE590")]
		private void RpcWriter___Observers_SetMixOperation_719366965(NetworkConnection conn, MixOperation operation)
		{
		}

		// Token: 0x060045AA RID: 17834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045AA")]
		[Address(RVA = "0x8AD4F0", Offset = "0x8AC6F0", VA = "0x1808AD4F0")]
		public void RpcLogic___SetMixOperation_719366965(NetworkConnection conn, MixOperation operation)
		{
		}

		// Token: 0x060045AB RID: 17835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045AB")]
		[Address(RVA = "0x8ADAC0", Offset = "0x8ACCC0", VA = "0x1808ADAC0")]
		private void RpcReader___Observers_SetMixOperation_719366965(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060045AC RID: 17836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045AC")]
		[Address(RVA = "0x8AF3C0", Offset = "0x8AE5C0", VA = "0x1808AF3C0")]
		private void RpcWriter___Target_SetMixOperation_719366965(NetworkConnection conn, MixOperation operation)
		{
		}

		// Token: 0x060045AD RID: 17837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045AD")]
		[Address(RVA = "0x8AE1A0", Offset = "0x8AD3A0", VA = "0x1808AE1A0")]
		private void RpcReader___Target_SetMixOperation_719366965(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060045AE RID: 17838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045AE")]
		[Address(RVA = "0x8AF250", Offset = "0x8AE450", VA = "0x1808AF250")]
		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060045AF RID: 17839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045AF")]
		[Address(RVA = "0x8AD950", Offset = "0x8ACB50", VA = "0x1808AD950", Slot = "92")]
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060045B0 RID: 17840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B0")]
		[Address(RVA = "0x8AE0E0", Offset = "0x8AD2E0", VA = "0x1808AE0E0")]
		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060045B1 RID: 17841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B1")]
		[Address(RVA = "0x8AF820", Offset = "0x8AEA20", VA = "0x1808AF820")]
		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060045B2 RID: 17842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B2")]
		[Address(RVA = "0x8AD960", Offset = "0x8ACB60", VA = "0x1808AD960")]
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060045B3 RID: 17843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B3")]
		[Address(RVA = "0x8AE380", Offset = "0x8AD580", VA = "0x1808AE380")]
		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060045B4 RID: 17844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B4")]
		[Address(RVA = "0x8AE9F0", Offset = "0x8ADBF0", VA = "0x1808AE9F0")]
		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060045B5 RID: 17845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B5")]
		[Address(RVA = "0x8ADCA0", Offset = "0x8ACEA0", VA = "0x1808ADCA0")]
		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060045B6 RID: 17846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B6")]
		[Address(RVA = "0x8AEB70", Offset = "0x8ADD70", VA = "0x1808AEB70")]
		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060045B7 RID: 17847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B7")]
		[Address(RVA = "0x8AD460", Offset = "0x8AC660", VA = "0x1808AD460", Slot = "93")]
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060045B8 RID: 17848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B8")]
		[Address(RVA = "0x8ADD30", Offset = "0x8ACF30", VA = "0x1808ADD30")]
		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060045B9 RID: 17849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B9")]
		[Address(RVA = "0x8AE410", Offset = "0x8AD610", VA = "0x1808AE410")]
		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060045BA RID: 17850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045BA")]
		[Address(RVA = "0x8AD470", Offset = "0x8AC670", VA = "0x1808AD470")]
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060045BB RID: 17851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045BB")]
		[Address(RVA = "0x8ADA20", Offset = "0x8ACC20", VA = "0x1808ADA20")]
		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060045BC RID: 17852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045BC")]
		[Address(RVA = "0x8AF0C0", Offset = "0x8AE2C0", VA = "0x1808AF0C0")]
		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060045BD RID: 17853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045BD")]
		[Address(RVA = "0x8AD890", Offset = "0x8ACA90", VA = "0x1808AD890", Slot = "94")]
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060045BE RID: 17854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045BE")]
		[Address(RVA = "0x8ADFD0", Offset = "0x8AD1D0", VA = "0x1808ADFD0")]
		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060045BF RID: 17855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045BF")]
		[Address(RVA = "0x8AF690", Offset = "0x8AE890", VA = "0x1808AF690")]
		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060045C0 RID: 17856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C0")]
		[Address(RVA = "0x8AD8A0", Offset = "0x8ACAA0", VA = "0x1808AD8A0")]
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060045C1 RID: 17857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C1")]
		[Address(RVA = "0x8AE290", Offset = "0x8AD490", VA = "0x1808AE290")]
		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060045C2 RID: 17858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C2")]
		[Address(RVA = "0x8AE850", Offset = "0x8ADA50", VA = "0x1808AE850")]
		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060045C3 RID: 17859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C3")]
		[Address(RVA = "0x8ADBB0", Offset = "0x8ACDB0", VA = "0x1808ADBB0")]
		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060045C4 RID: 17860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C4")]
		[Address(RVA = "0x8AEF50", Offset = "0x8AE150", VA = "0x1808AEF50")]
		private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060045C5 RID: 17861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C5")]
		[Address(RVA = "0x8AD790", Offset = "0x8AC990", VA = "0x1808AD790", Slot = "95")]
		public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060045C6 RID: 17862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C6")]
		[Address(RVA = "0x8ADEE0", Offset = "0x8AD0E0", VA = "0x1808ADEE0")]
		private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060045C7 RID: 17863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C7")]
		[Address(RVA = "0x8AE6D0", Offset = "0x8AD8D0", VA = "0x1808AE6D0")]
		private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060045C8 RID: 17864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C8")]
		[Address(RVA = "0x8AD810", Offset = "0x8ACA10", VA = "0x1808AD810")]
		private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060045C9 RID: 17865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C9")]
		[Address(RVA = "0x8ADB20", Offset = "0x8ACD20", VA = "0x1808ADB20")]
		private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060045CA RID: 17866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045CA")]
		[Address(RVA = "0x8AF520", Offset = "0x8AE720", VA = "0x1808AF520")]
		private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060045CB RID: 17867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045CB")]
		[Address(RVA = "0x8AE200", Offset = "0x8AD400", VA = "0x1808AE200")]
		private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060045CC RID: 17868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045CC")]
		[Address(RVA = "0x8AEE20", Offset = "0x8AE020", VA = "0x1808AEE20")]
		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x060045CD RID: 17869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045CD")]
		[Address(RVA = "0x8AD6F0", Offset = "0x8AC8F0", VA = "0x1808AD6F0", Slot = "96")]
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x060045CE RID: 17870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045CE")]
		[Address(RVA = "0x8ADE60", Offset = "0x8AD060", VA = "0x1808ADE60")]
		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060045CF RID: 17871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045CF")]
		[Address(RVA = "0x8AECF0", Offset = "0x8ADEF0", VA = "0x1808AECF0")]
		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x060045D0 RID: 17872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045D0")]
		[Address(RVA = "0x8AD650", Offset = "0x8AC850", VA = "0x1808AD650", Slot = "97")]
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x060045D1 RID: 17873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045D1")]
		[Address(RVA = "0x8ADDE0", Offset = "0x8ACFE0", VA = "0x1808ADDE0")]
		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x060045D2 RID: 17874 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060045D3 RID: 17875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AE4")]
		public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[Token(Token = "0x60045D2")]
			[Address(RVA = "0x66B880", Offset = "0x66AA80", VA = "0x18066B880")]
			get
			{
				return null;
			}
			[Token(Token = "0x60045D3")]
			[Address(RVA = "0x8B10E0", Offset = "0x8B02E0", VA = "0x1808B10E0")]
			set
			{
			}
		}

		// Token: 0x060045D4 RID: 17876 RVA: 0x00013338 File Offset: 0x00011538
		[Token(Token = "0x60045D4")]
		[Address(RVA = "0x8AD330", Offset = "0x8AC530", VA = "0x1808AD330", Slot = "98")]
		public virtual bool ReadSyncVar___ScheduleOne.ObjectScripts.OldMixingStation(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x060045D5 RID: 17877 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060045D6 RID: 17878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AE5")]
		public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[Token(Token = "0x60045D5")]
			[Address(RVA = "0x835000", Offset = "0x834200", VA = "0x180835000")]
			get
			{
				return null;
			}
			[Token(Token = "0x60045D6")]
			[Address(RVA = "0x8B11A0", Offset = "0x8B03A0", VA = "0x1808B11A0")]
			set
			{
			}
		}

		// Token: 0x060045D7 RID: 17879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045D7")]
		[Address(RVA = "0x8AB830", Offset = "0x8AAA30", VA = "0x1808AB830", Slot = "99")]
		protected virtual void Awake_UserLogic_ScheduleOne.ObjectScripts.OldMixingStation_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040031B4 RID: 12724
		[Token(Token = "0x40031B4")]
		[FieldOffset(Offset = "0x210")]
		public int MIX_TIME_PER_ITEM;

		// Token: 0x040031B5 RID: 12725
		[Token(Token = "0x40031B5")]
		[FieldOffset(Offset = "0x214")]
		public int MIN_MIX_TIME;

		// Token: 0x040031B8 RID: 12728
		[Token(Token = "0x40031B8")]
		[FieldOffset(Offset = "0x228")]
		public ItemSlot ProductSlot;

		// Token: 0x040031B9 RID: 12729
		[Token(Token = "0x40031B9")]
		[FieldOffset(Offset = "0x230")]
		public ItemSlot MixerSlot;

		// Token: 0x040031BA RID: 12730
		[Token(Token = "0x40031BA")]
		[FieldOffset(Offset = "0x238")]
		public ItemSlot OutputSlot;

		// Token: 0x040031BE RID: 12734
		[Token(Token = "0x40031BE")]
		[FieldOffset(Offset = "0x258")]
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x040031BF RID: 12735
		[Token(Token = "0x40031BF")]
		[FieldOffset(Offset = "0x260")]
		public Transform CameraPosition;

		// Token: 0x040031C0 RID: 12736
		[Token(Token = "0x40031C0")]
		[FieldOffset(Offset = "0x268")]
		public StorageVisualizer InputVisuals;

		// Token: 0x040031C1 RID: 12737
		[Token(Token = "0x40031C1")]
		[FieldOffset(Offset = "0x270")]
		public StorageVisualizer OutputVisuals;

		// Token: 0x040031C2 RID: 12738
		[Token(Token = "0x40031C2")]
		[FieldOffset(Offset = "0x278")]
		public Animation Animation;

		// Token: 0x040031C3 RID: 12739
		[Token(Token = "0x40031C3")]
		[FieldOffset(Offset = "0x280")]
		[Header("Screen")]
		public Canvas ScreenCanvas;

		// Token: 0x040031C4 RID: 12740
		[Token(Token = "0x40031C4")]
		[FieldOffset(Offset = "0x288")]
		public Image OutputIcon;

		// Token: 0x040031C5 RID: 12741
		[Token(Token = "0x40031C5")]
		[FieldOffset(Offset = "0x290")]
		public TextMeshProUGUI QuantityLabel;

		// Token: 0x040031C6 RID: 12742
		[Token(Token = "0x40031C6")]
		[FieldOffset(Offset = "0x298")]
		public TextMeshProUGUI ProgressLabel;

		// Token: 0x040031C7 RID: 12743
		[Token(Token = "0x40031C7")]
		[FieldOffset(Offset = "0x2A0")]
		[Header("Sounds")]
		public StartLoopStopAudio MachineSound;

		// Token: 0x040031C8 RID: 12744
		[Token(Token = "0x40031C8")]
		[FieldOffset(Offset = "0x2A8")]
		public AudioSourceController StartSound;

		// Token: 0x040031C9 RID: 12745
		[Token(Token = "0x40031C9")]
		[FieldOffset(Offset = "0x2B0")]
		public AudioSourceController StopSound;

		// Token: 0x040031CA RID: 12746
		[Token(Token = "0x40031CA")]
		[FieldOffset(Offset = "0x2B8")]
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x040031CB RID: 12747
		[Token(Token = "0x40031CB")]
		[FieldOffset(Offset = "0x2C0")]
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x040031CC RID: 12748
		[Token(Token = "0x40031CC")]
		[FieldOffset(Offset = "0x2C8")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.OldMixingStationAssembly-CSharp.dll_Excuted;

		// Token: 0x040031CD RID: 12749
		[Token(Token = "0x40031CD")]
		[FieldOffset(Offset = "0x2C9")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.OldMixingStationAssembly-CSharp.dll_Excuted;
	}
}
