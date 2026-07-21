using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Interaction;
using ScheduleOne.Management;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.Property
{
	// Token: 0x02000373 RID: 883
	[Token(Token = "0x2000373")]
	public class Tap : NetworkBehaviour, IUsable
	{
		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06001612 RID: 5650 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001613 RID: 5651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700044A")]
		public Transform CameraPos
		{
			[Token(Token = "0x6001612")]
			[Address(RVA = "0x5AF080", Offset = "0x5AE280", VA = "0x1805AF080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001613")]
			[Address(RVA = "0x5AF0A0", Offset = "0x5AE2A0", VA = "0x1805AF0A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06001614 RID: 5652 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001615 RID: 5653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700044B")]
		public Transform FillableModelContainer
		{
			[Token(Token = "0x6001614")]
			[Address(RVA = "0x58D0A0", Offset = "0x58C2A0", VA = "0x18058D0A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001615")]
			[Address(RVA = "0x58D280", Offset = "0x58C480", VA = "0x18058D280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06001616 RID: 5654 RVA: 0x00009558 File Offset: 0x00007758
		// (set) Token: 0x06001617 RID: 5655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700044C")]
		public bool IsHeldOpen
		{
			[Token(Token = "0x6001616")]
			[Address(RVA = "0x5AF090", Offset = "0x5AE290", VA = "0x1805AF090")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001617")]
			[Address(RVA = "0x5AF0C0", Offset = "0x5AE2C0", VA = "0x1805AF0C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06001618 RID: 5656 RVA: 0x00009570 File Offset: 0x00007770
		[Token(Token = "0x1700044D")]
		public float ActualFlowRate
		{
			[Token(Token = "0x6001618")]
			[Address(RVA = "0x5AF060", Offset = "0x5AE260", VA = "0x1805AF060")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06001619 RID: 5657 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600161A RID: 5658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700044E")]
		public NetworkObject NPCUserObject
		{
			[Token(Token = "0x6001619")]
			[Address(RVA = "0x5887D0", Offset = "0x5879D0", VA = "0x1805887D0", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600161A")]
			[Address(RVA = "0x5AF150", Offset = "0x5AE350", VA = "0x1805AF150", Slot = "22")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x0600161B RID: 5659 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600161C RID: 5660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700044F")]
		public NetworkObject PlayerUserObject
		{
			[Token(Token = "0x600161B")]
			[Address(RVA = "0x5887E0", Offset = "0x5879E0", VA = "0x1805887E0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600161C")]
			[Address(RVA = "0x5AF1F0", Offset = "0x5AE3F0", VA = "0x1805AF1F0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600161D")]
		[Address(RVA = "0x5AD450", Offset = "0x5AC650", VA = "0x1805AD450", Slot = "29")]
		public virtual void Awake()
		{
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600161E")]
		[Address(RVA = "0x5AD920", Offset = "0x5ACB20", VA = "0x1805AD920", Slot = "30")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600161F")]
		[Address(RVA = "0x5AEE10", Offset = "0x5AE010", VA = "0x1805AEE10")]
		private void UpdateTapVisuals()
		{
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001620")]
		[Address(RVA = "0x5AEFA0", Offset = "0x5AE1A0", VA = "0x1805AEFA0")]
		private void UpdateWaterSound()
		{
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001621")]
		[Address(RVA = "0x5AD710", Offset = "0x5AC910", VA = "0x1805AD710")]
		private void Hovered()
		{
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001622")]
		[Address(RVA = "0x5AD7F0", Offset = "0x5AC9F0", VA = "0x1805AD7F0")]
		private void Interacted()
		{
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001623")]
		[Address(RVA = "0x5AEA00", Offset = "0x5ADC00", VA = "0x1805AEA00")]
		public void SetHandleEnabled(bool enabled)
		{
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001624")]
		[Address(RVA = "0x5AEA20", Offset = "0x5ADC20", VA = "0x1805AEA20")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		private void SetHeldOpen(bool open)
		{
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001625")]
		[Address(RVA = "0x5AE000", Offset = "0x5AD200", VA = "0x1805AE000")]
		private void OnHandleClickStart(RaycastHit hit)
		{
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001626")]
		[Address(RVA = "0x5ADFF0", Offset = "0x5AD1F0", VA = "0x1805ADFF0")]
		private void OnHandleClickEnd()
		{
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x00009588 File Offset: 0x00007788
		[Token(Token = "0x6001627")]
		[Address(RVA = "0x5AD4A0", Offset = "0x5AC6A0", VA = "0x1805AD4A0")]
		private bool CanInteract(out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001628")]
		[Address(RVA = "0x5AEB80", Offset = "0x5ADD80", VA = "0x1805AEB80")]
		public void SetMaxTapOpen(float max)
		{
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001629")]
		[Address(RVA = "0x5AECE0", Offset = "0x5ADEE0", VA = "0x1805AECE0", Slot = "27")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600162A")]
		[Address(RVA = "0x5AEBB0", Offset = "0x5ADDB0", VA = "0x1805AEBB0", Slot = "28")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600162B")]
		[Address(RVA = "0x5AF040", Offset = "0x5AE240", VA = "0x1805AF040")]
		public Tap()
		{
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600162C")]
		[Address(RVA = "0x5ADC80", Offset = "0x5ACE80", VA = "0x1805ADC80", Slot = "31")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600162D")]
		[Address(RVA = "0x5ADBF0", Offset = "0x5ACDF0", VA = "0x1805ADBF0", Slot = "32")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600162E")]
		[Address(RVA = "0x5ADBB0", Offset = "0x5ACDB0", VA = "0x1805ADBB0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600162F")]
		[Address(RVA = "0x5AE670", Offset = "0x5AD870", VA = "0x1805AE670")]
		private void RpcWriter___Server_SetHeldOpen_1140765316(bool open)
		{
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001630")]
		[Address(RVA = "0x5AE1B0", Offset = "0x5AD3B0", VA = "0x1805AE1B0")]
		private void RpcLogic___SetHeldOpen_1140765316(bool open)
		{
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001631")]
		[Address(RVA = "0x5AE4E0", Offset = "0x5AD6E0", VA = "0x1805AE4E0")]
		private void RpcReader___Server_SetHeldOpen_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001632")]
		[Address(RVA = "0x5AE8D0", Offset = "0x5ADAD0", VA = "0x1805AE8D0")]
		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001633")]
		[Address(RVA = "0x5AE300", Offset = "0x5AD500", VA = "0x1805AE300", Slot = "33")]
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001634")]
		[Address(RVA = "0x5AE5F0", Offset = "0x5AD7F0", VA = "0x1805AE5F0")]
		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001635")]
		[Address(RVA = "0x5AE7A0", Offset = "0x5AD9A0", VA = "0x1805AE7A0")]
		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001636")]
		[Address(RVA = "0x5AE210", Offset = "0x5AD410", VA = "0x1805AE210", Slot = "34")]
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001637")]
		[Address(RVA = "0x5AE570", Offset = "0x5AD770", VA = "0x1805AE570")]
		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06001638 RID: 5688 RVA: 0x000095A0 File Offset: 0x000077A0
		// (set) Token: 0x06001639 RID: 5689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000450")]
		public bool SyncAccessor_<IsHeldOpen>k__BackingField
		{
			[Token(Token = "0x6001638")]
			[Address(RVA = "0x5AF090", Offset = "0x5AE290", VA = "0x1805AF090")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001639")]
			[Address(RVA = "0x5AF290", Offset = "0x5AE490", VA = "0x1805AF290")]
			set
			{
			}
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x000095B8 File Offset: 0x000077B8
		[Token(Token = "0x600163A")]
		[Address(RVA = "0x5AE010", Offset = "0x5AD210", VA = "0x1805AE010", Slot = "35")]
		public virtual bool ReadSyncVar___ScheduleOne.Property.Tap(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x0600163B RID: 5691 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600163C RID: 5692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000451")]
		public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[Token(Token = "0x600163B")]
			[Address(RVA = "0x5887D0", Offset = "0x5879D0", VA = "0x1805887D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600163C")]
			[Address(RVA = "0x5AF350", Offset = "0x5AE550", VA = "0x1805AF350")]
			set
			{
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x0600163D RID: 5693 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600163E RID: 5694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000452")]
		public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[Token(Token = "0x600163D")]
			[Address(RVA = "0x5887E0", Offset = "0x5879E0", VA = "0x1805887E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600163E")]
			[Address(RVA = "0x5AF410", Offset = "0x5AE610", VA = "0x1805AF410")]
			set
			{
			}
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600163F")]
		[Address(RVA = "0x5AD1A0", Offset = "0x5AC3A0", VA = "0x1805AD1A0")]
		private void Awake_UserLogic_ScheduleOne.Property.Tap_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001369 RID: 4969
		[Token(Token = "0x4001369")]
		private const float FlowRateMultiplier = 6f;

		// Token: 0x0400136A RID: 4970
		[Token(Token = "0x400136A")]
		private const float HandleMoveSpeed = 2f;

		// Token: 0x0400136D RID: 4973
		[Token(Token = "0x400136D")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private InteractableObject _interactable;

		// Token: 0x0400136E RID: 4974
		[Token(Token = "0x400136E")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private Transform _handleTransform;

		// Token: 0x0400136F RID: 4975
		[Token(Token = "0x400136F")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private Clickable _handleClickable;

		// Token: 0x04001370 RID: 4976
		[Token(Token = "0x4001370")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private ParticleSystem _waterParticles;

		// Token: 0x04001371 RID: 4977
		[Token(Token = "0x4001371")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private AudioSourceController _squeakSound;

		// Token: 0x04001372 RID: 4978
		[Token(Token = "0x4001372")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private AudioSourceController _waterRunningSound;

		// Token: 0x04001376 RID: 4982
		[Token(Token = "0x4001376")]
		[FieldOffset(Offset = "0x170")]
		private float _normalizedTapFlow;

		// Token: 0x04001377 RID: 4983
		[Token(Token = "0x4001377")]
		[FieldOffset(Offset = "0x174")]
		private Vector2 _defaultParticleStartSize;

		// Token: 0x04001378 RID: 4984
		[Token(Token = "0x4001378")]
		[FieldOffset(Offset = "0x17C")]
		private float _maxTapOpenValue;

		// Token: 0x04001379 RID: 4985
		[Token(Token = "0x4001379")]
		[FieldOffset(Offset = "0x180")]
		public SyncVar<bool> syncVar___<IsHeldOpen>k__BackingField;

		// Token: 0x0400137A RID: 4986
		[Token(Token = "0x400137A")]
		[FieldOffset(Offset = "0x188")]
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x0400137B RID: 4987
		[Token(Token = "0x400137B")]
		[FieldOffset(Offset = "0x190")]
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x0400137C RID: 4988
		[Token(Token = "0x400137C")]
		[FieldOffset(Offset = "0x198")]
		private bool NetworkInitialize___EarlyScheduleOne.Property.TapAssembly-CSharp.dll_Excuted;

		// Token: 0x0400137D RID: 4989
		[Token(Token = "0x400137D")]
		[FieldOffset(Offset = "0x199")]
		private bool NetworkInitialize__LateScheduleOne.Property.TapAssembly-CSharp.dll_Excuted;
	}
}
