using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;
using TMPro;
using UnityEngine;

namespace ScheduleOne.EntityFramework
{
	// Token: 0x02000660 RID: 1632
	[Token(Token = "0x2000660")]
	public class LabelledSurfaceItem : SurfaceItem
	{
		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06002911 RID: 10513 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002912 RID: 10514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700071F")]
		public string Message
		{
			[Token(Token = "0x6002911")]
			[Address(RVA = "0x6DB190", Offset = "0x6DA390", VA = "0x1806DB190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002912")]
			[Address(RVA = "0x6DB1A0", Offset = "0x6DA3A0", VA = "0x1806DB1A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002913")]
		[Address(RVA = "0x6DA840", Offset = "0x6D9A40", VA = "0x1806DA840", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002914")]
		[Address(RVA = "0x6DA5A0", Offset = "0x6D97A0", VA = "0x1806DA5A0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMessageToServer(string message)
		{
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002915")]
		[Address(RVA = "0x6DAEA0", Offset = "0x6DA0A0", VA = "0x1806DAEA0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void SetMessage(NetworkConnection conn, string message)
		{
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002916")]
		[Address(RVA = "0x6DA490", Offset = "0x6D9690", VA = "0x1806DA490")]
		public void Interacted()
		{
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002917")]
		[Address(RVA = "0x6DA5A0", Offset = "0x6D97A0", VA = "0x1806DA5A0")]
		private void MessageSubmitted(string message)
		{
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002918")]
		[Address(RVA = "0x6DA320", Offset = "0x6D9520", VA = "0x1806DA320", Slot = "61")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002919")]
		[Address(RVA = "0x6DB130", Offset = "0x6DA330", VA = "0x1806DB130")]
		public LabelledSurfaceItem()
		{
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600291A")]
		[Address(RVA = "0x6DA710", Offset = "0x6D9910", VA = "0x1806DA710", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600291B")]
		[Address(RVA = "0x6DA6D0", Offset = "0x6D98D0", VA = "0x1806DA6D0", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600291C")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600291D")]
		[Address(RVA = "0x6DAC10", Offset = "0x6D9E10", VA = "0x1806DAC10")]
		private void RpcWriter___Server_SendMessageToServer_3615296227(string message)
		{
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600291E")]
		[Address(RVA = "0x6DA8C0", Offset = "0x6D9AC0", VA = "0x1806DA8C0")]
		public void RpcLogic___SendMessageToServer_3615296227(string message)
		{
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600291F")]
		[Address(RVA = "0x6DA9C0", Offset = "0x6D9BC0", VA = "0x1806DA9C0")]
		private void RpcReader___Server_SendMessageToServer_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002920")]
		[Address(RVA = "0x6DAAD0", Offset = "0x6D9CD0", VA = "0x1806DAAD0")]
		private void RpcWriter___Observers_SetMessage_2971853958(NetworkConnection conn, string message)
		{
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002921")]
		[Address(RVA = "0x6DA8D0", Offset = "0x6D9AD0", VA = "0x1806DA8D0")]
		public void RpcLogic___SetMessage_2971853958(NetworkConnection conn, string message)
		{
		}

		// Token: 0x06002922 RID: 10530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002922")]
		[Address(RVA = "0x6DA930", Offset = "0x6D9B30", VA = "0x1806DA930")]
		private void RpcReader___Observers_SetMessage_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002923 RID: 10531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002923")]
		[Address(RVA = "0x6DAD40", Offset = "0x6D9F40", VA = "0x1806DAD40")]
		private void RpcWriter___Target_SetMessage_2971853958(NetworkConnection conn, string message)
		{
		}

		// Token: 0x06002924 RID: 10532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002924")]
		[Address(RVA = "0x6DAA40", Offset = "0x6D9C40", VA = "0x1806DAA40")]
		private void RpcReader___Target_SetMessage_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002925 RID: 10533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002925")]
		[Address(RVA = "0x6DA2B0", Offset = "0x6D94B0", VA = "0x1806DA2B0", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x04001F63 RID: 8035
		[Token(Token = "0x4001F63")]
		[FieldOffset(Offset = "0x210")]
		public int MaxCharacters;

		// Token: 0x04001F64 RID: 8036
		[Token(Token = "0x4001F64")]
		[FieldOffset(Offset = "0x218")]
		[Header("References")]
		public TextMeshPro Label;

		// Token: 0x04001F65 RID: 8037
		[Token(Token = "0x4001F65")]
		[FieldOffset(Offset = "0x220")]
		private bool NetworkInitialize___EarlyScheduleOne.EntityFramework.LabelledSurfaceItemAssembly-CSharp.dll_Excuted;

		// Token: 0x04001F66 RID: 8038
		[Token(Token = "0x4001F66")]
		[FieldOffset(Offset = "0x221")]
		private bool NetworkInitialize__LateScheduleOne.EntityFramework.LabelledSurfaceItemAssembly-CSharp.dll_Excuted;
	}
}
