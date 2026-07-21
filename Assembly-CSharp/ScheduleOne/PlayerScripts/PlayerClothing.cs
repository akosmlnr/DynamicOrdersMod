using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework;
using ScheduleOne.Clothing;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x020005EE RID: 1518
	[Token(Token = "0x20005EE")]
	public class PlayerClothing : NetworkBehaviour, IItemSlotOwner
	{
		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x060024A4 RID: 9380 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060024A5 RID: 9381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700066F")]
		public List<ItemSlot> ItemSlots
		{
			[Token(Token = "0x60024A4")]
			[Address(RVA = "0x58D0A0", Offset = "0x58C2A0", VA = "0x18058D0A0", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60024A5")]
			[Address(RVA = "0x58D280", Offset = "0x58C480", VA = "0x18058D280", Slot = "20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x060024A6 RID: 9382 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000670")]
		private AvatarSettings appearanceSettings
		{
			[Token(Token = "0x60024A6")]
			[Address(RVA = "0x6A7440", Offset = "0x6A6640", VA = "0x1806A7440")]
			get
			{
				return null;
			}
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024A7")]
		[Address(RVA = "0x6A3320", Offset = "0x6A2520", VA = "0x1806A3320", Slot = "30")]
		public virtual void Awake()
		{
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024A8")]
		[Address(RVA = "0x6A3C50", Offset = "0x6A2E50", VA = "0x1806A3C50", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024A9")]
		[Address(RVA = "0x6A3390", Offset = "0x6A2590", VA = "0x1806A3390")]
		public void InsertClothing(ClothingInstance clothing)
		{
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024AA")]
		[Address(RVA = "0x6A3370", Offset = "0x6A2570", VA = "0x1806A3370", Slot = "31")]
		protected virtual void ClothingChanged()
		{
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024AB")]
		[Address(RVA = "0x6A3D30", Offset = "0x6A2F30", VA = "0x1806A3D30", Slot = "32")]
		public virtual void RefreshAppearance()
		{
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
		[Token(Token = "0x60024AC")]
		[Address(RVA = "0x6A7060", Offset = "0x6A6260", VA = "0x1806A7060")]
		private bool TryGetInventoryClothing(string assetPath, Color color, out ClothingInstance clothing)
		{
			return default(bool);
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
		[Token(Token = "0x60024AD")]
		[Address(RVA = "0x6A3560", Offset = "0x6A2760", VA = "0x1806A3560")]
		private bool IsClothingApplied(AvatarSettings settings, ClothingInstance clothing)
		{
			return default(bool);
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024AE")]
		[Address(RVA = "0x6A2BC0", Offset = "0x6A1DC0", VA = "0x1806A2BC0")]
		private void ApplyClothing(AvatarSettings settings, ClothingInstance clothing)
		{
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024AF")]
		[Address(RVA = "0x6A6EC0", Offset = "0x6A60C0", VA = "0x1806A6EC0", Slot = "21")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024B0")]
		[Address(RVA = "0x6A6C00", Offset = "0x6A5E00", VA = "0x1806A6C00")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024B1")]
		[Address(RVA = "0x6A6120", Offset = "0x6A5320", VA = "0x1806A6120", Slot = "22")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024B2")]
		[Address(RVA = "0x6A5F70", Offset = "0x6A5170", VA = "0x1806A5F70")]
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024B3")]
		[Address(RVA = "0x6A6A10", Offset = "0x6A5C10", VA = "0x1806A6A10", Slot = "23")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024B4")]
		[Address(RVA = "0x6A66F0", Offset = "0x6A58F0", VA = "0x1806A66F0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024B5")]
		[Address(RVA = "0x6A6550", Offset = "0x6A5750", VA = "0x1806A6550", Slot = "24")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024B6")]
		[Address(RVA = "0x6A6290", Offset = "0x6A5490", VA = "0x1806A6290")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024B7")]
		[Address(RVA = "0x6A7320", Offset = "0x6A6520", VA = "0x1806A7320")]
		public PlayerClothing()
		{
		}

		// Token: 0x060024B8 RID: 9400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024B8")]
		[Address(RVA = "0x6A3910", Offset = "0x6A2B10", VA = "0x1806A3910", Slot = "33")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024B9")]
		[Address(RVA = "0x6A38F0", Offset = "0x6A2AF0", VA = "0x1806A38F0", Slot = "34")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x060024BA RID: 9402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024BA")]
		[Address(RVA = "0x6A38B0", Offset = "0x6A2AB0", VA = "0x1806A38B0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060024BB RID: 9403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024BB")]
		[Address(RVA = "0x6A5990", Offset = "0x6A4B90", VA = "0x1806A5990")]
		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060024BC RID: 9404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024BC")]
		[Address(RVA = "0x6A4510", Offset = "0x6A3710", VA = "0x1806A4510", Slot = "35")]
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060024BD RID: 9405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024BD")]
		[Address(RVA = "0x6A4BF0", Offset = "0x6A3DF0", VA = "0x1806A4BF0")]
		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060024BE RID: 9406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024BE")]
		[Address(RVA = "0x6A5390", Offset = "0x6A4590", VA = "0x1806A5390")]
		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060024BF RID: 9407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024BF")]
		[Address(RVA = "0x6A4590", Offset = "0x6A3790", VA = "0x1806A4590")]
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060024C0 RID: 9408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024C0")]
		[Address(RVA = "0x6A4870", Offset = "0x6A3A70", VA = "0x1806A4870")]
		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024C1")]
		[Address(RVA = "0x6A5E00", Offset = "0x6A5000", VA = "0x1806A5E00")]
		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060024C2 RID: 9410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024C2")]
		[Address(RVA = "0x6A4E60", Offset = "0x6A4060", VA = "0x1806A4E60")]
		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060024C3 RID: 9411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024C3")]
		[Address(RVA = "0x6A5510", Offset = "0x6A4710", VA = "0x1806A5510")]
		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060024C4 RID: 9412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024C4")]
		[Address(RVA = "0x6A4250", Offset = "0x6A3450", VA = "0x1806A4250", Slot = "36")]
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024C5")]
		[Address(RVA = "0x6A4900", Offset = "0x6A3B00", VA = "0x1806A4900")]
		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024C6")]
		[Address(RVA = "0x6A4EF0", Offset = "0x6A40F0", VA = "0x1806A4EF0")]
		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024C7")]
		[Address(RVA = "0x6A4260", Offset = "0x6A3460", VA = "0x1806A4260")]
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024C8")]
		[Address(RVA = "0x6A4650", Offset = "0x6A3850", VA = "0x1806A4650")]
		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024C9")]
		[Address(RVA = "0x6A5800", Offset = "0x6A4A00", VA = "0x1806A5800")]
		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024CA")]
		[Address(RVA = "0x6A43E0", Offset = "0x6A35E0", VA = "0x1806A43E0", Slot = "37")]
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024CB")]
		[Address(RVA = "0x6A4AA0", Offset = "0x6A3CA0", VA = "0x1806A4AA0")]
		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024CC")]
		[Address(RVA = "0x6A5C70", Offset = "0x6A4E70", VA = "0x1806A5C70")]
		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024CD")]
		[Address(RVA = "0x6A4460", Offset = "0x6A3660", VA = "0x1806A4460")]
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024CE")]
		[Address(RVA = "0x6A4D70", Offset = "0x6A3F70", VA = "0x1806A4D70")]
		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024CF")]
		[Address(RVA = "0x6A51F0", Offset = "0x6A43F0", VA = "0x1806A51F0")]
		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D0")]
		[Address(RVA = "0x6A4780", Offset = "0x6A3980", VA = "0x1806A4780")]
		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D1")]
		[Address(RVA = "0x6A5690", Offset = "0x6A4890", VA = "0x1806A5690")]
		private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D2")]
		[Address(RVA = "0x6A42E0", Offset = "0x6A34E0", VA = "0x1806A42E0", Slot = "38")]
		public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D3")]
		[Address(RVA = "0x6A49B0", Offset = "0x6A3BB0", VA = "0x1806A49B0")]
		private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D4")]
		[Address(RVA = "0x6A5070", Offset = "0x6A4270", VA = "0x1806A5070")]
		private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D5")]
		[Address(RVA = "0x6A4360", Offset = "0x6A3560", VA = "0x1806A4360")]
		private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D6")]
		[Address(RVA = "0x6A46F0", Offset = "0x6A38F0", VA = "0x1806A46F0")]
		private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D7")]
		[Address(RVA = "0x6A5B00", Offset = "0x6A4D00", VA = "0x1806A5B00")]
		private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060024D8 RID: 9432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D8")]
		[Address(RVA = "0x6A4CE0", Offset = "0x6A3EE0", VA = "0x1806A4CE0")]
		private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D9")]
		[Address(RVA = "0x6A2F00", Offset = "0x6A2100", VA = "0x1806A2F00", Slot = "39")]
		protected virtual void Awake_UserLogic_ScheduleOne.PlayerScripts.PlayerClothing_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001CB5 RID: 7349
		[Token(Token = "0x4001CB5")]
		[FieldOffset(Offset = "0x118")]
		public Player Player;

		// Token: 0x04001CB7 RID: 7351
		[Token(Token = "0x4001CB7")]
		[FieldOffset(Offset = "0x128")]
		public Dictionary<EClothingSlot, ItemSlot> ClothingSlots;

		// Token: 0x04001CB8 RID: 7352
		[Token(Token = "0x4001CB8")]
		[FieldOffset(Offset = "0x130")]
		private List<ClothingInstance> appliedClothing;

		// Token: 0x04001CB9 RID: 7353
		[Token(Token = "0x4001CB9")]
		[FieldOffset(Offset = "0x138")]
		private bool NetworkInitialize___EarlyScheduleOne.PlayerScripts.PlayerClothingAssembly-CSharp.dll_Excuted;

		// Token: 0x04001CBA RID: 7354
		[Token(Token = "0x4001CBA")]
		[FieldOffset(Offset = "0x139")]
		private bool NetworkInitialize__LateScheduleOne.PlayerScripts.PlayerClothingAssembly-CSharp.dll_Excuted;
	}
}
