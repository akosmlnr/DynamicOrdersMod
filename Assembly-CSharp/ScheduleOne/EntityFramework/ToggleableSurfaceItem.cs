using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.EntityFramework
{
	// Token: 0x02000669 RID: 1641
	[Token(Token = "0x2000669")]
	public class ToggleableSurfaceItem : SurfaceItem
	{
		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x0600298E RID: 10638 RVA: 0x0000D518 File Offset: 0x0000B718
		// (set) Token: 0x0600298F RID: 10639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700072B")]
		public bool IsOn
		{
			[Token(Token = "0x600298E")]
			[Address(RVA = "0x6EA340", Offset = "0x6E9540", VA = "0x1806EA340")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600298F")]
			[Address(RVA = "0x6EA350", Offset = "0x6E9550", VA = "0x1806EA350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002990")]
		[Address(RVA = "0x6E9350", Offset = "0x6E8550", VA = "0x1806E9350", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002991")]
		[Address(RVA = "0x6E96F0", Offset = "0x6E88F0", VA = "0x1806E96F0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06002992 RID: 10642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002992")]
		[Address(RVA = "0x6EA1F0", Offset = "0x6E93F0", VA = "0x1806EA1F0")]
		public void Toggle()
		{
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002993")]
		[Address(RVA = "0x6EA2C0", Offset = "0x6E94C0", VA = "0x1806EA2C0")]
		public void TurnOn(bool network = true)
		{
		}

		// Token: 0x06002994 RID: 10644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002994")]
		[Address(RVA = "0x6EA240", Offset = "0x6E9440", VA = "0x1806EA240")]
		public void TurnOff(bool network = true)
		{
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002995")]
		[Address(RVA = "0x6E9E00", Offset = "0x6E9000", VA = "0x1806E9E00")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		private void SendIsOn(bool on)
		{
		}

		// Token: 0x06002996 RID: 10646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002996")]
		[Address(RVA = "0x6E9F40", Offset = "0x6E9140", VA = "0x1806E9F40")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetIsOn(NetworkConnection conn, bool on)
		{
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002997")]
		[Address(RVA = "0x6E9410", Offset = "0x6E8610", VA = "0x1806E9410", Slot = "61")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002998")]
		[Address(RVA = "0x6EA330", Offset = "0x6E9530", VA = "0x1806EA330")]
		public ToggleableSurfaceItem()
		{
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002999")]
		[Address(RVA = "0x6E95C0", Offset = "0x6E87C0", VA = "0x1806E95C0", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600299A")]
		[Address(RVA = "0x6E9580", Offset = "0x6E8780", VA = "0x1806E9580", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600299B")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600299C")]
		[Address(RVA = "0x6E9B70", Offset = "0x6E8D70", VA = "0x1806E9B70")]
		private void RpcWriter___Server_SendIsOn_1140765316(bool on)
		{
		}

		// Token: 0x0600299D RID: 10653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600299D")]
		[Address(RVA = "0x6E9770", Offset = "0x6E8970", VA = "0x1806E9770")]
		private void RpcLogic___SendIsOn_1140765316(bool on)
		{
		}

		// Token: 0x0600299E RID: 10654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600299E")]
		[Address(RVA = "0x6E98D0", Offset = "0x6E8AD0", VA = "0x1806E98D0")]
		private void RpcReader___Server_SendIsOn_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600299F")]
		[Address(RVA = "0x6E9A30", Offset = "0x6E8C30", VA = "0x1806E9A30")]
		private void RpcWriter___Observers_SetIsOn_214505783(NetworkConnection conn, bool on)
		{
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029A0")]
		[Address(RVA = "0x6E9790", Offset = "0x6E8990", VA = "0x1806E9790")]
		private void RpcLogic___SetIsOn_214505783(NetworkConnection conn, bool on)
		{
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029A1")]
		[Address(RVA = "0x6E9800", Offset = "0x6E8A00", VA = "0x1806E9800")]
		private void RpcReader___Observers_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029A2")]
		[Address(RVA = "0x6E9CA0", Offset = "0x6E8EA0", VA = "0x1806E9CA0")]
		private void RpcWriter___Target_SetIsOn_214505783(NetworkConnection conn, bool on)
		{
		}

		// Token: 0x060029A3 RID: 10659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029A3")]
		[Address(RVA = "0x6E9960", Offset = "0x6E8B60", VA = "0x1806E9960")]
		private void RpcReader___Target_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060029A4 RID: 10660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029A4")]
		[Address(RVA = "0x6E92A0", Offset = "0x6E84A0", VA = "0x1806E92A0", Slot = "68")]
		protected virtual void Awake_UserLogic_ScheduleOne.EntityFramework.ToggleableSurfaceItem_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001F8F RID: 8079
		[Token(Token = "0x4001F8F")]
		[FieldOffset(Offset = "0x20C")]
		[Header("Settings")]
		public ToggleableSurfaceItem.EStartupAction StartupAction;

		// Token: 0x04001F90 RID: 8080
		[Token(Token = "0x4001F90")]
		[FieldOffset(Offset = "0x210")]
		public UnityEvent onTurnedOn;

		// Token: 0x04001F91 RID: 8081
		[Token(Token = "0x4001F91")]
		[FieldOffset(Offset = "0x218")]
		public UnityEvent onTurnedOff;

		// Token: 0x04001F92 RID: 8082
		[Token(Token = "0x4001F92")]
		[FieldOffset(Offset = "0x220")]
		public UnityEvent onTurnOnOrOff;

		// Token: 0x04001F93 RID: 8083
		[Token(Token = "0x4001F93")]
		[FieldOffset(Offset = "0x228")]
		private bool NetworkInitialize___EarlyScheduleOne.EntityFramework.ToggleableSurfaceItemAssembly-CSharp.dll_Excuted;

		// Token: 0x04001F94 RID: 8084
		[Token(Token = "0x4001F94")]
		[FieldOffset(Offset = "0x229")]
		private bool NetworkInitialize__LateScheduleOne.EntityFramework.ToggleableSurfaceItemAssembly-CSharp.dll_Excuted;

		// Token: 0x0200066A RID: 1642
		[Token(Token = "0x200066A")]
		public enum EStartupAction
		{
			// Token: 0x04001F96 RID: 8086
			[Token(Token = "0x4001F96")]
			None,
			// Token: 0x04001F97 RID: 8087
			[Token(Token = "0x4001F97")]
			TurnOn,
			// Token: 0x04001F98 RID: 8088
			[Token(Token = "0x4001F98")]
			TurnOff,
			// Token: 0x04001F99 RID: 8089
			[Token(Token = "0x4001F99")]
			Toggle
		}
	}
}
