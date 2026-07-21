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
	// Token: 0x02000667 RID: 1639
	[Token(Token = "0x2000667")]
	public class ToggleableItem : GridItem
	{
		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06002977 RID: 10615 RVA: 0x0000D500 File Offset: 0x0000B700
		// (set) Token: 0x06002978 RID: 10616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700072A")]
		public bool IsOn
		{
			[Token(Token = "0x6002977")]
			[Address(RVA = "0x6E9280", Offset = "0x6E8480", VA = "0x1806E9280")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002978")]
			[Address(RVA = "0x6E9290", Offset = "0x6E8490", VA = "0x1806E9290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002979")]
		[Address(RVA = "0x6E8150", Offset = "0x6E7350", VA = "0x1806E8150", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600297A")]
		[Address(RVA = "0x6E8640", Offset = "0x6E7840", VA = "0x1806E8640", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600297B")]
		[Address(RVA = "0x6E9140", Offset = "0x6E8340", VA = "0x1806E9140")]
		public void Toggle()
		{
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600297C")]
		[Address(RVA = "0x6E9210", Offset = "0x6E8410", VA = "0x1806E9210")]
		public void TurnOn(bool network = true)
		{
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600297D")]
		[Address(RVA = "0x6E9190", Offset = "0x6E8390", VA = "0x1806E9190")]
		public void TurnOff(bool network = true)
		{
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600297E")]
		[Address(RVA = "0x6E8D50", Offset = "0x6E7F50", VA = "0x1806E8D50")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		private void SendIsOn(bool on)
		{
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600297F")]
		[Address(RVA = "0x6E8E90", Offset = "0x6E8090", VA = "0x1806E8E90")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetIsOn(NetworkConnection conn, bool on)
		{
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002980")]
		[Address(RVA = "0x6E82D0", Offset = "0x6E74D0", VA = "0x1806E82D0", Slot = "61")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x06002981 RID: 10625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002981")]
		[Address(RVA = "0x6D9EB0", Offset = "0x6D90B0", VA = "0x1806D9EB0")]
		public ToggleableItem()
		{
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002982")]
		[Address(RVA = "0x6E8410", Offset = "0x6E7610", VA = "0x1806E8410", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002983")]
		[Address(RVA = "0x6E83D0", Offset = "0x6E75D0", VA = "0x1806E83D0", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002984")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002985")]
		[Address(RVA = "0x6E8AC0", Offset = "0x6E7CC0", VA = "0x1806E8AC0")]
		private void RpcWriter___Server_SendIsOn_1140765316(bool on)
		{
		}

		// Token: 0x06002986 RID: 10630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002986")]
		[Address(RVA = "0x6E86C0", Offset = "0x6E78C0", VA = "0x1806E86C0")]
		private void RpcLogic___SendIsOn_1140765316(bool on)
		{
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002987")]
		[Address(RVA = "0x6E8820", Offset = "0x6E7A20", VA = "0x1806E8820")]
		private void RpcReader___Server_SendIsOn_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002988")]
		[Address(RVA = "0x6E8980", Offset = "0x6E7B80", VA = "0x1806E8980")]
		private void RpcWriter___Observers_SetIsOn_214505783(NetworkConnection conn, bool on)
		{
		}

		// Token: 0x06002989 RID: 10633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002989")]
		[Address(RVA = "0x6E86E0", Offset = "0x6E78E0", VA = "0x1806E86E0")]
		private void RpcLogic___SetIsOn_214505783(NetworkConnection conn, bool on)
		{
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600298A")]
		[Address(RVA = "0x6E8750", Offset = "0x6E7950", VA = "0x1806E8750")]
		private void RpcReader___Observers_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600298B RID: 10635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600298B")]
		[Address(RVA = "0x6E8BF0", Offset = "0x6E7DF0", VA = "0x1806E8BF0")]
		private void RpcWriter___Target_SetIsOn_214505783(NetworkConnection conn, bool on)
		{
		}

		// Token: 0x0600298C RID: 10636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600298C")]
		[Address(RVA = "0x6E88B0", Offset = "0x6E7AB0", VA = "0x1806E88B0")]
		private void RpcReader___Target_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600298D")]
		[Address(RVA = "0x6E7FE0", Offset = "0x6E71E0", VA = "0x1806E7FE0", Slot = "71")]
		protected virtual void Awake_UserLogic_ScheduleOne.EntityFramework.ToggleableItem_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001F83 RID: 8067
		[Token(Token = "0x4001F83")]
		[FieldOffset(Offset = "0x214")]
		[Header("Settings")]
		public ToggleableItem.EStartupAction StartupAction;

		// Token: 0x04001F84 RID: 8068
		[Token(Token = "0x4001F84")]
		[FieldOffset(Offset = "0x218")]
		public UnityEvent onTurnedOn;

		// Token: 0x04001F85 RID: 8069
		[Token(Token = "0x4001F85")]
		[FieldOffset(Offset = "0x220")]
		public UnityEvent onTurnedOff;

		// Token: 0x04001F86 RID: 8070
		[Token(Token = "0x4001F86")]
		[FieldOffset(Offset = "0x228")]
		public UnityEvent onTurnOnOrOff;

		// Token: 0x04001F87 RID: 8071
		[Token(Token = "0x4001F87")]
		[FieldOffset(Offset = "0x230")]
		private bool NetworkInitialize___EarlyScheduleOne.EntityFramework.ToggleableItemAssembly-CSharp.dll_Excuted;

		// Token: 0x04001F88 RID: 8072
		[Token(Token = "0x4001F88")]
		[FieldOffset(Offset = "0x231")]
		private bool NetworkInitialize__LateScheduleOne.EntityFramework.ToggleableItemAssembly-CSharp.dll_Excuted;

		// Token: 0x02000668 RID: 1640
		[Token(Token = "0x2000668")]
		public enum EStartupAction
		{
			// Token: 0x04001F8A RID: 8074
			[Token(Token = "0x4001F8A")]
			None,
			// Token: 0x04001F8B RID: 8075
			[Token(Token = "0x4001F8B")]
			TurnOn,
			// Token: 0x04001F8C RID: 8076
			[Token(Token = "0x4001F8C")]
			TurnOff,
			// Token: 0x04001F8D RID: 8077
			[Token(Token = "0x4001F8D")]
			Toggle
		}
	}
}
