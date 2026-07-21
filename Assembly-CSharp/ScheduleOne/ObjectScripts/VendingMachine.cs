using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Combat;
using ScheduleOne.Core;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x020009D1 RID: 2513
	[Token(Token = "0x20009D1")]
	public class VendingMachine : NetworkBehaviour, IGUIDRegisterable, IGenericSaveable
	{
		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x060047B2 RID: 18354 RVA: 0x00013830 File Offset: 0x00011A30
		// (set) Token: 0x060047B3 RID: 18355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B2F")]
		public bool IsBroken
		{
			[Token(Token = "0x60047B2")]
			[Address(RVA = "0x51C070", Offset = "0x51B270", VA = "0x18051C070")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60047B3")]
			[Address(RVA = "0x61FCB0", Offset = "0x61EEB0", VA = "0x18061FCB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x060047B4 RID: 18356 RVA: 0x00013848 File Offset: 0x00011A48
		// (set) Token: 0x060047B5 RID: 18357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B30")]
		public int DaysUntilRepair
		{
			[Token(Token = "0x60047B4")]
			[Address(RVA = "0x511A30", Offset = "0x510C30", VA = "0x180511A30")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60047B5")]
			[Address(RVA = "0x61FC90", Offset = "0x61EE90", VA = "0x18061FC90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x060047B6 RID: 18358 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060047B7 RID: 18359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B31")]
		public NetworkedItemPickup lastDroppedItem
		{
			[Token(Token = "0x60047B6")]
			[Address(RVA = "0x6D6C80", Offset = "0x6D5E80", VA = "0x1806D6C80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60047B7")]
			[Address(RVA = "0x6D6DD0", Offset = "0x6D5FD0", VA = "0x1806D6DD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x060047B8 RID: 18360 RVA: 0x00013860 File Offset: 0x00011A60
		// (set) Token: 0x060047B9 RID: 18361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B32")]
		public Guid GUID
		{
			[Token(Token = "0x60047B8")]
			[Address(RVA = "0x8D0660", Offset = "0x8CF860", VA = "0x1808D0660", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x60047B9")]
			[Address(RVA = "0x8D0670", Offset = "0x8CF870", VA = "0x1808D0670")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060047BA RID: 18362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047BA")]
		[Address(RVA = "0x8CEAF0", Offset = "0x8CDCF0", VA = "0x1808CEAF0")]
		[Button]
		public void RegenerateGUID()
		{
		}

		// Token: 0x060047BB RID: 18363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047BB")]
		[Address(RVA = "0x8CD5B0", Offset = "0x8CC7B0", VA = "0x1808CD5B0", Slot = "26")]
		public virtual void Awake()
		{
		}

		// Token: 0x060047BC RID: 18364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047BC")]
		[Address(RVA = "0x8D0180", Offset = "0x8CF380", VA = "0x1808D0180")]
		private void Start()
		{
		}

		// Token: 0x060047BD RID: 18365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047BD")]
		[Address(RVA = "0x8CE990", Offset = "0x8CDB90", VA = "0x1808CE990", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060047BE RID: 18366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047BE")]
		[Address(RVA = "0x8CFE70", Offset = "0x8CF070", VA = "0x1808CFE70", Slot = "21")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x060047BF RID: 18367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047BF")]
		[Address(RVA = "0x8CE770", Offset = "0x8CD970", VA = "0x1808CE770")]
		private void OnDestroy()
		{
		}

		// Token: 0x060047C0 RID: 18368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047C0")]
		[Address(RVA = "0x8CE3F0", Offset = "0x8CD5F0", VA = "0x1808CE3F0")]
		private void MinPass()
		{
		}

		// Token: 0x060047C1 RID: 18369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047C1")]
		[Address(RVA = "0x8CD880", Offset = "0x8CCA80", VA = "0x1808CD880")]
		public void DayPass()
		{
		}

		// Token: 0x060047C2 RID: 18370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047C2")]
		[Address(RVA = "0x8CDCB0", Offset = "0x8CCEB0", VA = "0x1808CDCB0")]
		public void Hovered()
		{
		}

		// Token: 0x060047C3 RID: 18371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047C3")]
		[Address(RVA = "0x8CE130", Offset = "0x8CD330", VA = "0x1808CE130")]
		public void Interacted()
		{
		}

		// Token: 0x060047C4 RID: 18372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047C4")]
		[Address(RVA = "0x8CE260", Offset = "0x8CD460", VA = "0x1808CE260")]
		private void LocalPurchase()
		{
		}

		// Token: 0x060047C5 RID: 18373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047C5")]
		[Address(RVA = "0x8CFD60", Offset = "0x8CEF60", VA = "0x1808CFD60")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendPurchase()
		{
		}

		// Token: 0x060047C6 RID: 18374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047C6")]
		[Address(RVA = "0x8CE9D0", Offset = "0x8CDBD0", VA = "0x1808CE9D0")]
		[ObserversRpc(RunLocally = true)]
		public void PurchaseRoutine()
		{
		}

		// Token: 0x060047C7 RID: 18375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047C7")]
		[Address(RVA = "0x8CDAD0", Offset = "0x8CCCD0", VA = "0x1808CDAD0")]
		[ServerRpc(RequireOwnership = false)]
		public void DropItem()
		{
		}

		// Token: 0x060047C8 RID: 18376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047C8")]
		[Address(RVA = "0x8CEB40", Offset = "0x8CDD40", VA = "0x1808CEB40")]
		public void RemoveLastDropped()
		{
		}

		// Token: 0x060047C9 RID: 18377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047C9")]
		[Address(RVA = "0x8CDDC0", Offset = "0x8CCFC0", VA = "0x1808CDDC0")]
		private void Impacted(Impact impact)
		{
		}

		// Token: 0x060047CA RID: 18378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047CA")]
		[Address(RVA = "0x8CFEE0", Offset = "0x8CF0E0", VA = "0x1808CFEE0")]
		private void SetLit(bool lit)
		{
		}

		// Token: 0x060047CB RID: 18379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047CB")]
		[Address(RVA = "0x8CFC40", Offset = "0x8CEE40", VA = "0x1808CFC40")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendBreak()
		{
		}

		// Token: 0x060047CC RID: 18380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047CC")]
		[Address(RVA = "0x8CD600", Offset = "0x8CC800", VA = "0x1808CD600")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void Break(NetworkConnection conn)
		{
		}

		// Token: 0x060047CD RID: 18381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047CD")]
		[Address(RVA = "0x8CEC10", Offset = "0x8CDE10", VA = "0x1808CEC10")]
		[ObserversRpc]
		private void Repair()
		{
		}

		// Token: 0x060047CE RID: 18382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047CE")]
		[Address(RVA = "0x8CD9C0", Offset = "0x8CCBC0", VA = "0x1808CD9C0")]
		[ServerRpc(RequireOwnership = false)]
		private void DropCash()
		{
		}

		// Token: 0x060047CF RID: 18383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047CF")]
		[Address(RVA = "0x8CE1B0", Offset = "0x8CD3B0", VA = "0x1808CE1B0", Slot = "24")]
		public void Load(GenericSaveData data)
		{
		}

		// Token: 0x060047D0 RID: 18384 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60047D0")]
		[Address(RVA = "0x8CDBE0", Offset = "0x8CCDE0", VA = "0x1808CDBE0", Slot = "25")]
		public GenericSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x060047D1 RID: 18385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047D1")]
		[Address(RVA = "0x8D05F0", Offset = "0x8CF7F0", VA = "0x1808D05F0")]
		public VendingMachine()
		{
		}

		// Token: 0x060047D3 RID: 18387 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60047D3")]
		[Address(RVA = "0x8D04F0", Offset = "0x8CF6F0", VA = "0x1808D04F0")]
		[CompilerGenerated]
		private IEnumerator <PurchaseRoutine>g__Routine|61_0()
		{
			return null;
		}

		// Token: 0x060047D4 RID: 18388 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60047D4")]
		[Address(RVA = "0x8D0410", Offset = "0x8CF610", VA = "0x1808D0410")]
		[CompilerGenerated]
		private IEnumerator <Impacted>g__BreakRoutine|64_0()
		{
			return null;
		}

		// Token: 0x060047D5 RID: 18389 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60047D5")]
		[Address(RVA = "0x8D0480", Offset = "0x8CF680", VA = "0x1808D0480")]
		[CompilerGenerated]
		private IEnumerator <Impacted>g__Drop|64_1()
		{
			return null;
		}

		// Token: 0x060047D6 RID: 18390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047D6")]
		[Address(RVA = "0x8CE500", Offset = "0x8CD700", VA = "0x1808CE500", Slot = "27")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x060047D7 RID: 18391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047D7")]
		[Address(RVA = "0x8C4AA0", Offset = "0x8C3CA0", VA = "0x1808C4AA0", Slot = "28")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x060047D8 RID: 18392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047D8")]
		[Address(RVA = "0x8CE4C0", Offset = "0x8CD6C0", VA = "0x1808CE4C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060047D9 RID: 18393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047D9")]
		[Address(RVA = "0x8CFA00", Offset = "0x8CEC00", VA = "0x1808CFA00")]
		private void RpcWriter___Server_SendPurchase_2166136261()
		{
		}

		// Token: 0x060047DA RID: 18394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047DA")]
		[Address(RVA = "0x8CE9D0", Offset = "0x8CDBD0", VA = "0x1808CE9D0")]
		public void RpcLogic___SendPurchase_2166136261()
		{
		}

		// Token: 0x060047DB RID: 18395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047DB")]
		[Address(RVA = "0x8CF600", Offset = "0x8CE800", VA = "0x1808CF600")]
		private void RpcReader___Server_SendPurchase_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060047DC RID: 18396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047DC")]
		[Address(RVA = "0x8CF7D0", Offset = "0x8CE9D0", VA = "0x1808CF7D0")]
		private void RpcWriter___Observers_PurchaseRoutine_2166136261()
		{
		}

		// Token: 0x060047DD RID: 18397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047DD")]
		[Address(RVA = "0x8CF140", Offset = "0x8CE340", VA = "0x1808CF140")]
		public void RpcLogic___PurchaseRoutine_2166136261()
		{
		}

		// Token: 0x060047DE RID: 18398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047DE")]
		[Address(RVA = "0x8CF350", Offset = "0x8CE550", VA = "0x1808CF350")]
		private void RpcReader___Observers_PurchaseRoutine_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060047DF RID: 18399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047DF")]
		[Address(RVA = "0x8CDAD0", Offset = "0x8CCCD0", VA = "0x1808CDAD0")]
		private void RpcWriter___Server_DropItem_2166136261()
		{
		}

		// Token: 0x060047E0 RID: 18400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047E0")]
		[Address(RVA = "0x8CF000", Offset = "0x8CE200", VA = "0x1808CF000")]
		public void RpcLogic___DropItem_2166136261()
		{
		}

		// Token: 0x060047E1 RID: 18401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047E1")]
		[Address(RVA = "0x8CF450", Offset = "0x8CE650", VA = "0x1808CF450")]
		private void RpcReader___Server_DropItem_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060047E2 RID: 18402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047E2")]
		[Address(RVA = "0x8CF8F0", Offset = "0x8CEAF0", VA = "0x1808CF8F0")]
		private void RpcWriter___Server_SendBreak_2166136261()
		{
		}

		// Token: 0x060047E3 RID: 18403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047E3")]
		[Address(RVA = "0x8CF2D0", Offset = "0x8CE4D0", VA = "0x1808CF2D0")]
		private void RpcLogic___SendBreak_2166136261()
		{
		}

		// Token: 0x060047E4 RID: 18404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047E4")]
		[Address(RVA = "0x8CF5A0", Offset = "0x8CE7A0", VA = "0x1808CF5A0")]
		private void RpcReader___Server_SendBreak_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060047E5 RID: 18405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047E5")]
		[Address(RVA = "0x8CF6B0", Offset = "0x8CE8B0", VA = "0x1808CF6B0")]
		private void RpcWriter___Observers_Break_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x060047E6 RID: 18406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047E6")]
		[Address(RVA = "0x8CED30", Offset = "0x8CDF30", VA = "0x1808CED30")]
		private void RpcLogic___Break_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x060047E7 RID: 18407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047E7")]
		[Address(RVA = "0x8CF2F0", Offset = "0x8CE4F0", VA = "0x1808CF2F0")]
		private void RpcReader___Observers_Break_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060047E8 RID: 18408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047E8")]
		[Address(RVA = "0x8CFB10", Offset = "0x8CED10", VA = "0x1808CFB10")]
		private void RpcWriter___Target_Break_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x060047E9 RID: 18409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047E9")]
		[Address(RVA = "0x8CF650", Offset = "0x8CE850", VA = "0x1808CF650")]
		private void RpcReader___Target_Break_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060047EA RID: 18410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047EA")]
		[Address(RVA = "0x8CEC10", Offset = "0x8CDE10", VA = "0x1808CEC10")]
		private void RpcWriter___Observers_Repair_2166136261()
		{
		}

		// Token: 0x060047EB RID: 18411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047EB")]
		[Address(RVA = "0x8CF240", Offset = "0x8CE440", VA = "0x1808CF240")]
		private void RpcLogic___Repair_2166136261()
		{
		}

		// Token: 0x060047EC RID: 18412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047EC")]
		[Address(RVA = "0x8CF390", Offset = "0x8CE590", VA = "0x1808CF390")]
		private void RpcReader___Observers_Repair_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060047ED RID: 18413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047ED")]
		[Address(RVA = "0x8CD9C0", Offset = "0x8CCBC0", VA = "0x1808CD9C0")]
		private void RpcWriter___Server_DropCash_2166136261()
		{
		}

		// Token: 0x060047EE RID: 18414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047EE")]
		[Address(RVA = "0x8CED80", Offset = "0x8CDF80", VA = "0x1808CED80")]
		private void RpcLogic___DropCash_2166136261()
		{
		}

		// Token: 0x060047EF RID: 18415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047EF")]
		[Address(RVA = "0x8CF420", Offset = "0x8CE620", VA = "0x1808CF420")]
		private void RpcReader___Server_DropCash_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060047F0 RID: 18416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047F0")]
		[Address(RVA = "0x8CD340", Offset = "0x8CC540", VA = "0x1808CD340")]
		private void Awake_UserLogic_ScheduleOne.ObjectScripts.VendingMachine_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040032C6 RID: 12998
		[Token(Token = "0x40032C6")]
		[FieldOffset(Offset = "0x0")]
		public static List<VendingMachine> AllMachines;

		// Token: 0x040032C7 RID: 12999
		[Token(Token = "0x40032C7")]
		public const float COST = 2f;

		// Token: 0x040032C8 RID: 13000
		[Token(Token = "0x40032C8")]
		public const int REPAIR_TIME_DAYS = 0;

		// Token: 0x040032C9 RID: 13001
		[Token(Token = "0x40032C9")]
		public const float IMPACT_THRESHOLD_FREE_ITEM = 50f;

		// Token: 0x040032CA RID: 13002
		[Token(Token = "0x40032CA")]
		public const float IMPACT_THRESHOLD_FREE_ITEM_CHANCE = 0.33f;

		// Token: 0x040032CB RID: 13003
		[Token(Token = "0x40032CB")]
		public const float IMPACT_THRESHOLD_BREAK = 150f;

		// Token: 0x040032CC RID: 13004
		[Token(Token = "0x40032CC")]
		public const int MIN_CASH_DROP = 1;

		// Token: 0x040032CD RID: 13005
		[Token(Token = "0x40032CD")]
		public const int MAX_CASH_DROP = 4;

		// Token: 0x040032D0 RID: 13008
		[Token(Token = "0x40032D0")]
		[FieldOffset(Offset = "0x120")]
		[Header("Settings")]
		public int LitStartTime;

		// Token: 0x040032D1 RID: 13009
		[Token(Token = "0x40032D1")]
		[FieldOffset(Offset = "0x124")]
		public int LitOnEndTime;

		// Token: 0x040032D2 RID: 13010
		[Token(Token = "0x40032D2")]
		[FieldOffset(Offset = "0x128")]
		public NetworkedItemPickup CukePrefab;

		// Token: 0x040032D3 RID: 13011
		[Token(Token = "0x40032D3")]
		[FieldOffset(Offset = "0x130")]
		public CashPickup CashPrefab;

		// Token: 0x040032D4 RID: 13012
		[Token(Token = "0x40032D4")]
		[FieldOffset(Offset = "0x138")]
		[Header("References")]
		public MeshRenderer DoorMesh;

		// Token: 0x040032D5 RID: 13013
		[Token(Token = "0x40032D5")]
		[FieldOffset(Offset = "0x140")]
		public MeshRenderer BodyMesh;

		// Token: 0x040032D6 RID: 13014
		[Token(Token = "0x40032D6")]
		[FieldOffset(Offset = "0x148")]
		public Material DoorOffMat;

		// Token: 0x040032D7 RID: 13015
		[Token(Token = "0x40032D7")]
		[FieldOffset(Offset = "0x150")]
		public Material DoorOnMat;

		// Token: 0x040032D8 RID: 13016
		[Token(Token = "0x40032D8")]
		[FieldOffset(Offset = "0x158")]
		public Material BodyOffMat;

		// Token: 0x040032D9 RID: 13017
		[Token(Token = "0x40032D9")]
		[FieldOffset(Offset = "0x160")]
		public Material BodyOnMat;

		// Token: 0x040032DA RID: 13018
		[Token(Token = "0x40032DA")]
		[FieldOffset(Offset = "0x168")]
		public OptimizedLight[] Lights;

		// Token: 0x040032DB RID: 13019
		[Token(Token = "0x40032DB")]
		[FieldOffset(Offset = "0x170")]
		public AudioSourceController PaySound;

		// Token: 0x040032DC RID: 13020
		[Token(Token = "0x40032DC")]
		[FieldOffset(Offset = "0x178")]
		public AudioSourceController DispenseSound;

		// Token: 0x040032DD RID: 13021
		[Token(Token = "0x40032DD")]
		[FieldOffset(Offset = "0x180")]
		public Animation Anim;

		// Token: 0x040032DE RID: 13022
		[Token(Token = "0x40032DE")]
		[FieldOffset(Offset = "0x188")]
		public Transform ItemSpawnPoint;

		// Token: 0x040032DF RID: 13023
		[Token(Token = "0x40032DF")]
		[FieldOffset(Offset = "0x190")]
		public InteractableObject IntObj;

		// Token: 0x040032E0 RID: 13024
		[Token(Token = "0x40032E0")]
		[FieldOffset(Offset = "0x198")]
		public Transform AccessPoint;

		// Token: 0x040032E1 RID: 13025
		[Token(Token = "0x40032E1")]
		[FieldOffset(Offset = "0x1A0")]
		public PhysicsDamageable Damageable;

		// Token: 0x040032E2 RID: 13026
		[Token(Token = "0x40032E2")]
		[FieldOffset(Offset = "0x1A8")]
		public Transform CashSpawnPoint;

		// Token: 0x040032E3 RID: 13027
		[Token(Token = "0x40032E3")]
		[FieldOffset(Offset = "0x1B0")]
		public UnityEvent onBreak;

		// Token: 0x040032E4 RID: 13028
		[Token(Token = "0x40032E4")]
		[FieldOffset(Offset = "0x1B8")]
		public UnityEvent onRepair;

		// Token: 0x040032E6 RID: 13030
		[Token(Token = "0x40032E6")]
		[FieldOffset(Offset = "0x1C8")]
		private bool isLit;

		// Token: 0x040032E7 RID: 13031
		[Token(Token = "0x40032E7")]
		[FieldOffset(Offset = "0x1C9")]
		private bool purchaseInProgress;

		// Token: 0x040032E8 RID: 13032
		[Token(Token = "0x40032E8")]
		[FieldOffset(Offset = "0x1CC")]
		private float timeOnLastFreeItem;

		// Token: 0x040032EA RID: 13034
		[Token(Token = "0x40032EA")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		protected string BakedGUID;

		// Token: 0x040032EB RID: 13035
		[Token(Token = "0x40032EB")]
		[FieldOffset(Offset = "0x1E8")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.VendingMachineAssembly-CSharp.dll_Excuted;

		// Token: 0x040032EC RID: 13036
		[Token(Token = "0x40032EC")]
		[FieldOffset(Offset = "0x1E9")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.VendingMachineAssembly-CSharp.dll_Excuted;
	}
}
