using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.Core.Equipping.Framework;
using ScheduleOne.Core.Items.Framework;

namespace ScheduleOne.Equipping.Framework
{
	// Token: 0x02000974 RID: 2420
	[Token(Token = "0x2000974")]
	public abstract class NetworkedEquipper : NetworkBehaviour
	{
		// Token: 0x06004097 RID: 16535
		[Token(Token = "0x6004097")]
		protected abstract IEquippableUser GetUser();

		// Token: 0x06004098 RID: 16536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004098")]
		[Address(RVA = "0x85FEB0", Offset = "0x85F0B0", VA = "0x18085FEB0", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x06004099 RID: 16537 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004099")]
		[Address(RVA = "0x85F200", Offset = "0x85E400", VA = "0x18085F200")]
		public IEquippedItemHandler Equip(EquippableData equippable, bool networked = true)
		{
			return null;
		}

		// Token: 0x0600409A RID: 16538 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600409A")]
		[Address(RVA = "0x85F440", Offset = "0x85E640", VA = "0x18085F440")]
		public IEquippedItemHandler Equip(BaseItemInstance item, bool networked = true)
		{
			return null;
		}

		// Token: 0x0600409B RID: 16539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600409B")]
		[Address(RVA = "0x860FD0", Offset = "0x8601D0", VA = "0x180860FD0")]
		public void Unequip(IEquippedItemHandler equippedItem)
		{
		}

		// Token: 0x0600409C RID: 16540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600409C")]
		[Address(RVA = "0x85ECE0", Offset = "0x85DEE0", VA = "0x18085ECE0")]
		private void AddEquippedItem(EquippedItemHandler handler)
		{
		}

		// Token: 0x0600409D RID: 16541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600409D")]
		[Address(RVA = "0x860140", Offset = "0x85F340", VA = "0x180860140")]
		private void RemoveEquippedItem(EquippedItemHandler handler)
		{
		}

		// Token: 0x0600409E RID: 16542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600409E")]
		[Address(RVA = "0x860EA0", Offset = "0x8600A0", VA = "0x180860EA0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void Unequip_Server(EquippedItemHandler handler)
		{
		}

		// Token: 0x0600409F RID: 16543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600409F")]
		[Address(RVA = "0x8605B0", Offset = "0x85F7B0", VA = "0x1808605B0")]
		[ObserversRpc(RunLocally = true)]
		private void Unequip_Client(EquippedItemHandler handler)
		{
		}

		// Token: 0x060040A0 RID: 16544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040A0")]
		[Address(RVA = "0x85EEC0", Offset = "0x85E0C0", VA = "0x18085EEC0")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		private void AddNetworkedEquippedItem_Server(EquippedItemHandler handler)
		{
		}

		// Token: 0x060040A1 RID: 16545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040A1")]
		[Address(RVA = "0x860320", Offset = "0x85F520", VA = "0x180860320")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		private void RemoveNetworkedEquippedItem_Server(EquippedItemHandler handler)
		{
		}

		// Token: 0x060040A2 RID: 16546 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60040A2")]
		[Address(RVA = "0x85F0A0", Offset = "0x85E2A0", VA = "0x18085F0A0")]
		private IEquippedItemHandler CreateHandlerForEquippable(EquippableData equippable)
		{
			return null;
		}

		// Token: 0x060040A3 RID: 16547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040A3")]
		[Address(RVA = "0x85FBE0", Offset = "0x85EDE0", VA = "0x18085FBE0")]
		private void NetworkEquippedItems_OnChange(SyncListOperation op, int index, EquippedItemHandler oldItem, EquippedItemHandler newItem, bool asServer)
		{
		}

		// Token: 0x060040A4 RID: 16548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040A4")]
		[Address(RVA = "0x860D90", Offset = "0x85FF90", VA = "0x180860D90")]
		public void UnequipAll()
		{
		}

		// Token: 0x060040A5 RID: 16549 RVA: 0x00012588 File Offset: 0x00010788
		[Token(Token = "0x60040A5")]
		[Address(RVA = "0x85EFF0", Offset = "0x85E1F0", VA = "0x18085EFF0")]
		private bool CanEquip(EquippableData equippable)
		{
			return default(bool);
		}

		// Token: 0x060040A6 RID: 16550 RVA: 0x000125A0 File Offset: 0x000107A0
		[Token(Token = "0x60040A6")]
		[Address(RVA = "0x85FAA0", Offset = "0x85ECA0", VA = "0x18085FAA0")]
		private bool IsRightHandOccupied()
		{
			return default(bool);
		}

		// Token: 0x060040A7 RID: 16551 RVA: 0x000125B8 File Offset: 0x000107B8
		[Token(Token = "0x60040A7")]
		[Address(RVA = "0x85F960", Offset = "0x85EB60", VA = "0x18085F960")]
		private bool IsLeftHandOccupied()
		{
			return default(bool);
		}

		// Token: 0x060040A8 RID: 16552 RVA: 0x000125D0 File Offset: 0x000107D0
		[Token(Token = "0x60040A8")]
		[Address(RVA = "0x85F7F0", Offset = "0x85E9F0", VA = "0x18085F7F0")]
		private bool IsItemEquipped(EquippedItemHandler handler)
		{
			return default(bool);
		}

		// Token: 0x060040A9 RID: 16553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040A9")]
		[Address(RVA = "0x85FF60", Offset = "0x85F160", VA = "0x18085FF60")]
		[Button]
		public void PrintLists()
		{
		}

		// Token: 0x060040AA RID: 16554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040AA")]
		[Address(RVA = "0x8614D0", Offset = "0x8606D0", VA = "0x1808614D0")]
		protected NetworkedEquipper()
		{
		}

		// Token: 0x060040AB RID: 16555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040AB")]
		[Address(RVA = "0x85FD00", Offset = "0x85EF00", VA = "0x18085FD00", Slot = "20")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x060040AC RID: 16556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040AC")]
		[Address(RVA = "0x85FCB0", Offset = "0x85EEB0", VA = "0x18085FCB0", Slot = "21")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x060040AD RID: 16557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040AD")]
		[Address(RVA = "0x5914A0", Offset = "0x5906A0", VA = "0x1805914A0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060040AE RID: 16558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040AE")]
		[Address(RVA = "0x860C60", Offset = "0x85FE60", VA = "0x180860C60")]
		private void RpcWriter___Server_Unequip_Server_897730888(EquippedItemHandler handler)
		{
		}

		// Token: 0x060040AF RID: 16559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040AF")]
		[Address(RVA = "0x8605B0", Offset = "0x85F7B0", VA = "0x1808605B0")]
		private void RpcLogic___Unequip_Server_897730888(EquippedItemHandler handler)
		{
		}

		// Token: 0x060040B0 RID: 16560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B0")]
		[Address(RVA = "0x860850", Offset = "0x85FA50", VA = "0x180860850")]
		private void RpcReader___Server_Unequip_Server_897730888(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060040B1 RID: 16561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B1")]
		[Address(RVA = "0x8608C0", Offset = "0x85FAC0", VA = "0x1808608C0")]
		private void RpcWriter___Observers_Unequip_Client_897730888(EquippedItemHandler handler)
		{
		}

		// Token: 0x060040B2 RID: 16562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B2")]
		[Address(RVA = "0x860570", Offset = "0x85F770", VA = "0x180860570")]
		private void RpcLogic___Unequip_Client_897730888(EquippedItemHandler handler)
		{
		}

		// Token: 0x060040B3 RID: 16563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B3")]
		[Address(RVA = "0x860700", Offset = "0x85F900", VA = "0x180860700")]
		private void RpcReader___Observers_Unequip_Client_897730888(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060040B4 RID: 16564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B4")]
		[Address(RVA = "0x860A00", Offset = "0x85FC00", VA = "0x180860A00")]
		private void RpcWriter___Server_AddNetworkedEquippedItem_Server_897730888(EquippedItemHandler handler)
		{
		}

		// Token: 0x060040B5 RID: 16565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B5")]
		[Address(RVA = "0x860450", Offset = "0x85F650", VA = "0x180860450")]
		private void RpcLogic___AddNetworkedEquippedItem_Server_897730888(EquippedItemHandler handler)
		{
		}

		// Token: 0x060040B6 RID: 16566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B6")]
		[Address(RVA = "0x860770", Offset = "0x85F970", VA = "0x180860770")]
		private void RpcReader___Server_AddNetworkedEquippedItem_Server_897730888(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060040B7 RID: 16567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B7")]
		[Address(RVA = "0x860B30", Offset = "0x85FD30", VA = "0x180860B30")]
		private void RpcWriter___Server_RemoveNetworkedEquippedItem_Server_897730888(EquippedItemHandler handler)
		{
		}

		// Token: 0x060040B8 RID: 16568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B8")]
		[Address(RVA = "0x8604E0", Offset = "0x85F6E0", VA = "0x1808604E0")]
		private void RpcLogic___RemoveNetworkedEquippedItem_Server_897730888(EquippedItemHandler handler)
		{
		}

		// Token: 0x060040B9 RID: 16569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B9")]
		[Address(RVA = "0x8607E0", Offset = "0x85F9E0", VA = "0x1808607E0")]
		private void RpcReader___Server_RemoveNetworkedEquippedItem_Server_897730888(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060040BA RID: 16570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040BA")]
		[Address(RVA = "0x5914A0", Offset = "0x5906A0", VA = "0x1805914A0", Slot = "22")]
		public virtual void Awake()
		{
		}

		// Token: 0x04002F1B RID: 12059
		[Token(Token = "0x4002F1B")]
		[FieldOffset(Offset = "0x118")]
		[SyncObject]
		private readonly SyncList<EquippedItemHandler> _networkEquippedItems;

		// Token: 0x04002F1C RID: 12060
		[Token(Token = "0x4002F1C")]
		[FieldOffset(Offset = "0x120")]
		private List<EquippedItemHandler> _allEquippedItems;

		// Token: 0x04002F1D RID: 12061
		[Token(Token = "0x4002F1D")]
		[FieldOffset(Offset = "0x128")]
		private bool NetworkInitialize___EarlyScheduleOne.Equipping.Framework.NetworkedEquipperAssembly-CSharp.dll_Excuted;

		// Token: 0x04002F1E RID: 12062
		[Token(Token = "0x4002F1E")]
		[FieldOffset(Offset = "0x129")]
		private bool NetworkInitialize__LateScheduleOne.Equipping.Framework.NetworkedEquipperAssembly-CSharp.dll_Excuted;
	}
}
