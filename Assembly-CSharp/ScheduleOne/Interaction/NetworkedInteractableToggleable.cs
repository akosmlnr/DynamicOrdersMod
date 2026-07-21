using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Interaction
{
	// Token: 0x0200060D RID: 1549
	[Token(Token = "0x200060D")]
	public class NetworkedInteractableToggleable : NetworkBehaviour
	{
		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x0600264D RID: 9805 RVA: 0x0000C738 File Offset: 0x0000A938
		// (set) Token: 0x0600264E RID: 9806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006B5")]
		public bool IsActivated
		{
			[Token(Token = "0x600264D")]
			[Address(RVA = "0x51C070", Offset = "0x51B270", VA = "0x18051C070")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600264E")]
			[Address(RVA = "0x61FCB0", Offset = "0x61EEB0", VA = "0x18061FCB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600264F")]
		[Address(RVA = "0x6C8890", Offset = "0x6C7A90", VA = "0x1806C8890")]
		public void Start()
		{
		}

		// Token: 0x06002650 RID: 9808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002650")]
		[Address(RVA = "0x6C7EE0", Offset = "0x6C70E0", VA = "0x1806C7EE0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002651")]
		[Address(RVA = "0x6C7D00", Offset = "0x6C6F00", VA = "0x1806C7D00")]
		public void Hovered()
		{
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002652")]
		[Address(RVA = "0x6C7D90", Offset = "0x6C6F90", VA = "0x1806C7D90")]
		public void Interacted()
		{
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002653")]
		[Address(RVA = "0x6C8510", Offset = "0x6C7710", VA = "0x1806C8510")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendToggle()
		{
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002654")]
		[Address(RVA = "0x6C8630", Offset = "0x6C7830", VA = "0x1806C8630")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void SetState(NetworkConnection conn, bool activated)
		{
		}

		// Token: 0x06002655 RID: 9813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002655")]
		[Address(RVA = "0x6C7F20", Offset = "0x6C7120", VA = "0x1806C7F20")]
		public void PoliceDetected()
		{
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002656")]
		[Address(RVA = "0x6C8980", Offset = "0x6C7B80", VA = "0x1806C8980")]
		public NetworkedInteractableToggleable()
		{
		}

		// Token: 0x06002657 RID: 9815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002657")]
		[Address(RVA = "0x6C7DC0", Offset = "0x6C6FC0", VA = "0x1806C7DC0", Slot = "19")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002658 RID: 9816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002658")]
		[Address(RVA = "0x6C7DA0", Offset = "0x6C6FA0", VA = "0x1806C7DA0", Slot = "20")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002659")]
		[Address(RVA = "0x621F90", Offset = "0x621190", VA = "0x180621F90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600265A")]
		[Address(RVA = "0x6C82A0", Offset = "0x6C74A0", VA = "0x1806C82A0")]
		private void RpcWriter___Server_SendToggle_2166136261()
		{
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600265B")]
		[Address(RVA = "0x6C7F60", Offset = "0x6C7160", VA = "0x1806C7F60")]
		public void RpcLogic___SendToggle_2166136261()
		{
		}

		// Token: 0x0600265C RID: 9820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600265C")]
		[Address(RVA = "0x6C8080", Offset = "0x6C7280", VA = "0x1806C8080")]
		private void RpcReader___Server_SendToggle_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600265D RID: 9821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600265D")]
		[Address(RVA = "0x6C8160", Offset = "0x6C7360", VA = "0x1806C8160")]
		private void RpcWriter___Observers_SetState_214505783(NetworkConnection conn, bool activated)
		{
		}

		// Token: 0x0600265E RID: 9822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600265E")]
		[Address(RVA = "0x6C7F80", Offset = "0x6C7180", VA = "0x1806C7F80")]
		public void RpcLogic___SetState_214505783(NetworkConnection conn, bool activated)
		{
		}

		// Token: 0x0600265F RID: 9823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600265F")]
		[Address(RVA = "0x6C8000", Offset = "0x6C7200", VA = "0x1806C8000")]
		private void RpcReader___Observers_SetState_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002660 RID: 9824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002660")]
		[Address(RVA = "0x6C83B0", Offset = "0x6C75B0", VA = "0x1806C83B0")]
		private void RpcWriter___Target_SetState_214505783(NetworkConnection conn, bool activated)
		{
		}

		// Token: 0x06002661 RID: 9825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002661")]
		[Address(RVA = "0x6C80E0", Offset = "0x6C72E0", VA = "0x1806C80E0")]
		private void RpcReader___Target_SetState_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002662 RID: 9826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002662")]
		[Address(RVA = "0x621F90", Offset = "0x621190", VA = "0x180621F90", Slot = "21")]
		public virtual void Awake()
		{
		}

		// Token: 0x04001DFF RID: 7679
		[Token(Token = "0x4001DFF")]
		[FieldOffset(Offset = "0x120")]
		public string ActivateMessage;

		// Token: 0x04001E00 RID: 7680
		[Token(Token = "0x4001E00")]
		[FieldOffset(Offset = "0x128")]
		public string DeactivateMessage;

		// Token: 0x04001E01 RID: 7681
		[Token(Token = "0x4001E01")]
		[FieldOffset(Offset = "0x130")]
		public float CoolDown;

		// Token: 0x04001E02 RID: 7682
		[Token(Token = "0x4001E02")]
		[FieldOffset(Offset = "0x138")]
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x04001E03 RID: 7683
		[Token(Token = "0x4001E03")]
		[FieldOffset(Offset = "0x140")]
		public UnityEvent onToggle;

		// Token: 0x04001E04 RID: 7684
		[Token(Token = "0x4001E04")]
		[FieldOffset(Offset = "0x148")]
		public UnityEvent onActivate;

		// Token: 0x04001E05 RID: 7685
		[Token(Token = "0x4001E05")]
		[FieldOffset(Offset = "0x150")]
		public UnityEvent onDeactivate;

		// Token: 0x04001E06 RID: 7686
		[Token(Token = "0x4001E06")]
		[FieldOffset(Offset = "0x158")]
		private float lastActivated;

		// Token: 0x04001E07 RID: 7687
		[Token(Token = "0x4001E07")]
		[FieldOffset(Offset = "0x15C")]
		private bool NetworkInitialize___EarlyScheduleOne.Interaction.NetworkedInteractableToggleableAssembly-CSharp.dll_Excuted;

		// Token: 0x04001E08 RID: 7688
		[Token(Token = "0x4001E08")]
		[FieldOffset(Offset = "0x15D")]
		private bool NetworkInitialize__LateScheduleOne.Interaction.NetworkedInteractableToggleableAssembly-CSharp.dll_Excuted;
	}
}
