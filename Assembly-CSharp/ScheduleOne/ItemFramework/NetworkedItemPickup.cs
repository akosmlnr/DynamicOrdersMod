using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Interaction;
using ScheduleOne.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000636 RID: 1590
	[Token(Token = "0x2000636")]
	[RequireComponent(typeof(InteractableObject))]
	public class NetworkedItemPickup : NetworkBehaviour
	{
		// Token: 0x0600272B RID: 10027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600272B")]
		[Address(RVA = "0x6C8C20", Offset = "0x6C7E20", VA = "0x1806C8C20", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600272C")]
		[Address(RVA = "0x6C97A0", Offset = "0x6C89A0", VA = "0x1806C97A0")]
		private void Start()
		{
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600272D")]
		[Address(RVA = "0x6C90C0", Offset = "0x6C82C0", VA = "0x1806C90C0")]
		private void Init()
		{
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600272E")]
		[Address(RVA = "0x6C8FD0", Offset = "0x6C81D0", VA = "0x1806C8FD0", Slot = "20")]
		protected virtual void Hovered()
		{
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600272F")]
		[Address(RVA = "0x6C92B0", Offset = "0x6C84B0", VA = "0x1806C92B0")]
		private void Interacted()
		{
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x0000CB70 File Offset: 0x0000AD70
		[Token(Token = "0x6002730")]
		[Address(RVA = "0x6C8DC0", Offset = "0x6C7FC0", VA = "0x1806C8DC0", Slot = "21")]
		protected virtual bool CanPickup()
		{
			return default(bool);
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002731")]
		[Address(RVA = "0x6C93B0", Offset = "0x6C85B0", VA = "0x1806C93B0", Slot = "22")]
		protected virtual void Pickup()
		{
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002732")]
		[Address(RVA = "0x6C8EC0", Offset = "0x6C80C0", VA = "0x1806C8EC0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void Destroy()
		{
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002733")]
		[Address(RVA = "0x6C99C0", Offset = "0x6C8BC0", VA = "0x1806C99C0")]
		public NetworkedItemPickup()
		{
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002734")]
		[Address(RVA = "0x6C9950", Offset = "0x6C8B50", VA = "0x1806C9950")]
		[CompilerGenerated]
		private IEnumerator <Init>g__Wait|9_0()
		{
			return null;
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002735")]
		[Address(RVA = "0x6C9320", Offset = "0x6C8520", VA = "0x1806C9320", Slot = "23")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002736 RID: 10038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002736")]
		[Address(RVA = "0x6C9300", Offset = "0x6C8500", VA = "0x1806C9300", Slot = "24")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002737")]
		[Address(RVA = "0x6B9F40", Offset = "0x6B9140", VA = "0x1806B9F40", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002738")]
		[Address(RVA = "0x6C9690", Offset = "0x6C8890", VA = "0x1806C9690")]
		private void RpcWriter___Server_Destroy_2166136261()
		{
		}

		// Token: 0x06002739 RID: 10041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002739")]
		[Address(RVA = "0x6C95C0", Offset = "0x6C87C0", VA = "0x1806C95C0")]
		public void RpcLogic___Destroy_2166136261()
		{
		}

		// Token: 0x0600273A RID: 10042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600273A")]
		[Address(RVA = "0x6C9640", Offset = "0x6C8840", VA = "0x1806C9640")]
		private void RpcReader___Server_Destroy_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600273B")]
		[Address(RVA = "0x6C8AB0", Offset = "0x6C7CB0", VA = "0x1806C8AB0", Slot = "25")]
		protected virtual void Awake_UserLogic_ScheduleOne.ItemFramework.NetworkedItemPickup_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001E81 RID: 7809
		[Token(Token = "0x4001E81")]
		[FieldOffset(Offset = "0x118")]
		public ItemDefinition ItemToGive;

		// Token: 0x04001E82 RID: 7810
		[Token(Token = "0x4001E82")]
		[FieldOffset(Offset = "0x120")]
		public bool DestroyOnPickup;

		// Token: 0x04001E83 RID: 7811
		[Token(Token = "0x4001E83")]
		[FieldOffset(Offset = "0x121")]
		public bool ConditionallyActive;

		// Token: 0x04001E84 RID: 7812
		[Token(Token = "0x4001E84")]
		[FieldOffset(Offset = "0x128")]
		public Condition ActiveCondition;

		// Token: 0x04001E85 RID: 7813
		[Token(Token = "0x4001E85")]
		[FieldOffset(Offset = "0x130")]
		public bool Networked;

		// Token: 0x04001E86 RID: 7814
		[Token(Token = "0x4001E86")]
		[FieldOffset(Offset = "0x138")]
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x04001E87 RID: 7815
		[Token(Token = "0x4001E87")]
		[FieldOffset(Offset = "0x140")]
		public UnityEvent onPickup;

		// Token: 0x04001E88 RID: 7816
		[Token(Token = "0x4001E88")]
		[FieldOffset(Offset = "0x148")]
		private bool NetworkInitialize___EarlyScheduleOne.ItemFramework.NetworkedItemPickupAssembly-CSharp.dll_Excuted;

		// Token: 0x04001E89 RID: 7817
		[Token(Token = "0x4001E89")]
		[FieldOffset(Offset = "0x149")]
		private bool NetworkInitialize__LateScheduleOne.ItemFramework.NetworkedItemPickupAssembly-CSharp.dll_Excuted;
	}
}
