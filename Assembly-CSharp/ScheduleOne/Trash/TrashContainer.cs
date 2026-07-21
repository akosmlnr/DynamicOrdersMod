using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Persistence;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Trash
{
	// Token: 0x020007CA RID: 1994
	[Token(Token = "0x20007CA")]
	public class TrashContainer : NetworkBehaviour
	{
		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06003542 RID: 13634 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003543 RID: 13635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000867")]
		public TrashContent Content
		{
			[Token(Token = "0x6003542")]
			[Address(RVA = "0x5AF080", Offset = "0x5AE280", VA = "0x1805AF080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003543")]
			[Address(RVA = "0x5AF0A0", Offset = "0x5AE2A0", VA = "0x1805AF0A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06003544 RID: 13636 RVA: 0x0000FF90 File Offset: 0x0000E190
		[Token(Token = "0x17000868")]
		public int TrashLevel
		{
			[Token(Token = "0x6003544")]
			[Address(RVA = "0x7D50F0", Offset = "0x7D42F0", VA = "0x1807D50F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06003545 RID: 13637 RVA: 0x0000FFA8 File Offset: 0x0000E1A8
		[Token(Token = "0x17000869")]
		public float NormalizedTrashLevel
		{
			[Token(Token = "0x6003545")]
			[Address(RVA = "0x7D50B0", Offset = "0x7D42B0", VA = "0x1807D50B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06003546 RID: 13638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003546")]
		[Address(RVA = "0x7D3120", Offset = "0x7D2320", VA = "0x1807D3120", Slot = "19")]
		public virtual void AddTrash(TrashItem item)
		{
		}

		// Token: 0x06003547 RID: 13639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003547")]
		[Address(RVA = "0x7D3F70", Offset = "0x7D3170", VA = "0x1807D3F70", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06003548 RID: 13640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003548")]
		[Address(RVA = "0x7D4CA0", Offset = "0x7D3EA0", VA = "0x1807D4CA0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendTrash(string trashID, int quantity)
		{
		}

		// Token: 0x06003549 RID: 13641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003549")]
		[Address(RVA = "0x7D33C0", Offset = "0x7D25C0", VA = "0x1807D33C0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void AddTrash(NetworkConnection conn, string trashID, int quantity)
		{
		}

		// Token: 0x0600354A RID: 13642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600354A")]
		[Address(RVA = "0x7D4B90", Offset = "0x7D3D90", VA = "0x1807D4B90")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendClear()
		{
		}

		// Token: 0x0600354B RID: 13643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600354B")]
		[Address(RVA = "0x7D3B00", Offset = "0x7D2D00", VA = "0x1807D3B00")]
		[ObserversRpc(RunLocally = true)]
		private void Clear()
		{
		}

		// Token: 0x0600354C RID: 13644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600354C")]
		[Address(RVA = "0x7D3C20", Offset = "0x7D2E20", VA = "0x1807D3C20")]
		[TargetRpc]
		private void LoadContent(NetworkConnection conn, TrashContentData data)
		{
		}

		// Token: 0x0600354D RID: 13645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600354D")]
		[Address(RVA = "0x7D4E10", Offset = "0x7D4010", VA = "0x1807D4E10")]
		public void TriggerEnter(Collider other)
		{
		}

		// Token: 0x0600354E RID: 13646 RVA: 0x0000FFC0 File Offset: 0x0000E1C0
		[Token(Token = "0x600354E")]
		[Address(RVA = "0x7D3AD0", Offset = "0x7D2CD0", VA = "0x1807D3AD0")]
		public bool CanBeBagged()
		{
			return default(bool);
		}

		// Token: 0x0600354F RID: 13647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600354F")]
		[Address(RVA = "0x7D3680", Offset = "0x7D2880", VA = "0x1807D3680")]
		public void BagTrash()
		{
		}

		// Token: 0x06003550 RID: 13648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003550")]
		[Address(RVA = "0x7D5030", Offset = "0x7D4230", VA = "0x1807D5030")]
		public TrashContainer()
		{
		}

		// Token: 0x06003551 RID: 13649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003551")]
		[Address(RVA = "0x7D4EE0", Offset = "0x7D40E0", VA = "0x1807D4EE0")]
		[CompilerGenerated]
		private void <OnSpawnServer>g__Replicate|13_0(NetworkConnection conn)
		{
		}

		// Token: 0x06003552 RID: 13650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003552")]
		[Address(RVA = "0x7D3D80", Offset = "0x7D2F80", VA = "0x1807D3D80", Slot = "20")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003553 RID: 13651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003553")]
		[Address(RVA = "0x758220", Offset = "0x757420", VA = "0x180758220", Slot = "21")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003554 RID: 13652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003554")]
		[Address(RVA = "0x5914A0", Offset = "0x5906A0", VA = "0x1805914A0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003555 RID: 13653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003555")]
		[Address(RVA = "0x7D48B0", Offset = "0x7D3AB0", VA = "0x1807D48B0")]
		private void RpcWriter___Server_SendTrash_3643459082(string trashID, int quantity)
		{
		}

		// Token: 0x06003556 RID: 13654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003556")]
		[Address(RVA = "0x7D4210", Offset = "0x7D3410", VA = "0x1807D4210")]
		private void RpcLogic___SendTrash_3643459082(string trashID, int quantity)
		{
		}

		// Token: 0x06003557 RID: 13655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003557")]
		[Address(RVA = "0x7D4350", Offset = "0x7D3550", VA = "0x1807D4350")]
		private void RpcReader___Server_SendTrash_3643459082(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003558 RID: 13656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003558")]
		[Address(RVA = "0x7D4500", Offset = "0x7D3700", VA = "0x1807D4500")]
		private void RpcWriter___Observers_AddTrash_3905681115(NetworkConnection conn, string trashID, int quantity)
		{
		}

		// Token: 0x06003559 RID: 13657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003559")]
		[Address(RVA = "0x7D4090", Offset = "0x7D3290", VA = "0x1807D4090")]
		private void RpcLogic___AddTrash_3905681115(NetworkConnection conn, string trashID, int quantity)
		{
		}

		// Token: 0x0600355A RID: 13658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600355A")]
		[Address(RVA = "0x7D4230", Offset = "0x7D3430", VA = "0x1807D4230")]
		private void RpcReader___Observers_AddTrash_3905681115(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600355B RID: 13659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600355B")]
		[Address(RVA = "0x7D4A20", Offset = "0x7D3C20", VA = "0x1807D4A20")]
		private void RpcWriter___Target_AddTrash_3905681115(NetworkConnection conn, string trashID, int quantity)
		{
		}

		// Token: 0x0600355C RID: 13660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600355C")]
		[Address(RVA = "0x7D43F0", Offset = "0x7D35F0", VA = "0x1807D43F0")]
		private void RpcReader___Target_AddTrash_3905681115(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600355D RID: 13661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600355D")]
		[Address(RVA = "0x7D47A0", Offset = "0x7D39A0", VA = "0x1807D47A0")]
		private void RpcWriter___Server_SendClear_2166136261()
		{
		}

		// Token: 0x0600355E RID: 13662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600355E")]
		[Address(RVA = "0x7D3B00", Offset = "0x7D2D00", VA = "0x1807D3B00")]
		private void RpcLogic___SendClear_2166136261()
		{
		}

		// Token: 0x0600355F RID: 13663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600355F")]
		[Address(RVA = "0x7D4300", Offset = "0x7D3500", VA = "0x1807D4300")]
		private void RpcReader___Server_SendClear_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003560 RID: 13664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003560")]
		[Address(RVA = "0x7D4680", Offset = "0x7D3880", VA = "0x1807D4680")]
		private void RpcWriter___Observers_Clear_2166136261()
		{
		}

		// Token: 0x06003561 RID: 13665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003561")]
		[Address(RVA = "0x7D4130", Offset = "0x7D3330", VA = "0x1807D4130")]
		private void RpcLogic___Clear_2166136261()
		{
		}

		// Token: 0x06003562 RID: 13666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003562")]
		[Address(RVA = "0x7D42C0", Offset = "0x7D34C0", VA = "0x1807D42C0")]
		private void RpcReader___Observers_Clear_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003563 RID: 13667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003563")]
		[Address(RVA = "0x7D3C20", Offset = "0x7D2E20", VA = "0x1807D3C20")]
		private void RpcWriter___Target_LoadContent_189522235(NetworkConnection conn, TrashContentData data)
		{
		}

		// Token: 0x06003564 RID: 13668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003564")]
		[Address(RVA = "0x7D41C0", Offset = "0x7D33C0", VA = "0x1807D41C0")]
		private void RpcLogic___LoadContent_189522235(NetworkConnection conn, TrashContentData data)
		{
		}

		// Token: 0x06003565 RID: 13669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003565")]
		[Address(RVA = "0x7D4480", Offset = "0x7D3680", VA = "0x1807D4480")]
		private void RpcReader___Target_LoadContent_189522235(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003566 RID: 13670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003566")]
		[Address(RVA = "0x5914A0", Offset = "0x5906A0", VA = "0x1805914A0", Slot = "22")]
		public virtual void Awake()
		{
		}

		// Token: 0x040026C1 RID: 9921
		[Token(Token = "0x40026C1")]
		[FieldOffset(Offset = "0x120")]
		[Header("Settings")]
		[Range(1f, 50f)]
		public int TrashCapacity;

		// Token: 0x040026C2 RID: 9922
		[Token(Token = "0x40026C2")]
		[FieldOffset(Offset = "0x128")]
		[Header("Settings")]
		public Transform TrashBagDropLocation;

		// Token: 0x040026C3 RID: 9923
		[Token(Token = "0x40026C3")]
		[FieldOffset(Offset = "0x130")]
		public UnityEvent<string> onTrashAdded;

		// Token: 0x040026C4 RID: 9924
		[Token(Token = "0x40026C4")]
		[FieldOffset(Offset = "0x138")]
		public UnityEvent onTrashLevelChanged;

		// Token: 0x040026C5 RID: 9925
		[Token(Token = "0x40026C5")]
		[FieldOffset(Offset = "0x140")]
		private bool NetworkInitialize___EarlyScheduleOne.Trash.TrashContainerAssembly-CSharp.dll_Excuted;

		// Token: 0x040026C6 RID: 9926
		[Token(Token = "0x40026C6")]
		[FieldOffset(Offset = "0x141")]
		private bool NetworkInitialize__LateScheduleOne.Trash.TrashContainerAssembly-CSharp.dll_Excuted;
	}
}
