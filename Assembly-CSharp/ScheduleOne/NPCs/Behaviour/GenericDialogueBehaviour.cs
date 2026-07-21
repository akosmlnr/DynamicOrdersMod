using System;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000B15 RID: 2837
	[Token(Token = "0x2000B15")]
	public class GenericDialogueBehaviour : Behaviour
	{
		// Token: 0x0600537F RID: 21375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600537F")]
		[Address(RVA = "0x964C20", Offset = "0x963E20", VA = "0x180964C20")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendTargetPlayer(NetworkObject player)
		{
		}

		// Token: 0x06005380 RID: 21376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005380")]
		[Address(RVA = "0x964540", Offset = "0x963740", VA = "0x180964540")]
		[ObserversRpc(RunLocally = true)]
		private void SetTargetPlayer(NetworkObject player)
		{
		}

		// Token: 0x06005381 RID: 21377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005381")]
		[Address(RVA = "0x964030", Offset = "0x963230", VA = "0x180964030", Slot = "20")]
		public override void Enable()
		{
		}

		// Token: 0x06005382 RID: 21378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005382")]
		[Address(RVA = "0x94AF80", Offset = "0x94A180", VA = "0x18094AF80", Slot = "21")]
		public override void Disable()
		{
		}

		// Token: 0x06005383 RID: 21379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005383")]
		[Address(RVA = "0x963F80", Offset = "0x963180", VA = "0x180963F80", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x06005384 RID: 21380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005384")]
		[Address(RVA = "0x9644D0", Offset = "0x9636D0", VA = "0x1809644D0", Slot = "25")]
		public override void Resume()
		{
		}

		// Token: 0x06005385 RID: 21381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005385")]
		[Address(RVA = "0x963FF0", Offset = "0x9631F0", VA = "0x180963FF0", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x06005386 RID: 21382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005386")]
		[Address(RVA = "0x964180", Offset = "0x963380", VA = "0x180964180", Slot = "28")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x06005387 RID: 21383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005387")]
		[Address(RVA = "0x964D50", Offset = "0x963F50", VA = "0x180964D50")]
		public GenericDialogueBehaviour()
		{
		}

		// Token: 0x06005388 RID: 21384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005388")]
		[Address(RVA = "0x964090", Offset = "0x963290", VA = "0x180964090", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005389 RID: 21385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005389")]
		[Address(RVA = "0x964070", Offset = "0x963270", VA = "0x180964070", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600538A RID: 21386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600538A")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600538B RID: 21387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600538B")]
		[Address(RVA = "0x964AF0", Offset = "0x963CF0", VA = "0x180964AF0")]
		private void RpcWriter___Server_SendTargetPlayer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600538C RID: 21388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600538C")]
		[Address(RVA = "0x964540", Offset = "0x963740", VA = "0x180964540")]
		public void RpcLogic___SendTargetPlayer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600538D RID: 21389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600538D")]
		[Address(RVA = "0x964930", Offset = "0x963B30", VA = "0x180964930")]
		private void RpcReader___Server_SendTargetPlayer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600538E RID: 21390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600538E")]
		[Address(RVA = "0x9649B0", Offset = "0x963BB0", VA = "0x1809649B0")]
		private void RpcWriter___Observers_SetTargetPlayer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600538F RID: 21391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600538F")]
		[Address(RVA = "0x964680", Offset = "0x963880", VA = "0x180964680")]
		private void RpcLogic___SetTargetPlayer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06005390 RID: 21392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005390")]
		[Address(RVA = "0x9648C0", Offset = "0x963AC0", VA = "0x1809648C0")]
		private void RpcReader___Observers_SetTargetPlayer_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005391 RID: 21393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005391")]
		[Address(RVA = "0x935FD0", Offset = "0x9351D0", VA = "0x180935FD0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x0400389D RID: 14493
		[Token(Token = "0x400389D")]
		[FieldOffset(Offset = "0x168")]
		private Player targetPlayer;

		// Token: 0x0400389E RID: 14494
		[Token(Token = "0x400389E")]
		[FieldOffset(Offset = "0x170")]
		[Header("Settings")]
		public bool FaceConversationTarget;

		// Token: 0x0400389F RID: 14495
		[Token(Token = "0x400389F")]
		[FieldOffset(Offset = "0x171")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.GenericDialogueBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x040038A0 RID: 14496
		[Token(Token = "0x40038A0")]
		[FieldOffset(Offset = "0x172")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.GenericDialogueBehaviourAssembly-CSharp.dll_Excuted;
	}
}
