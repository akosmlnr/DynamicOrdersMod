using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI
{
	// Token: 0x02000C2E RID: 3118
	[Token(Token = "0x2000C2E")]
	public class DailySummary : NetworkSingleton<DailySummary>
	{
		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x06005B5A RID: 23386 RVA: 0x000172B0 File Offset: 0x000154B0
		// (set) Token: 0x06005B5B RID: 23387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D3A")]
		public bool IsOpen
		{
			[Token(Token = "0x6005B5A")]
			[Address(RVA = "0x511850", Offset = "0x510A50", VA = "0x180511850")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005B5B")]
			[Address(RVA = "0x5A4550", Offset = "0x5A3750", VA = "0x1805A4550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x06005B5C RID: 23388 RVA: 0x000172C8 File Offset: 0x000154C8
		// (set) Token: 0x06005B5D RID: 23389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D3B")]
		public int xpGained
		{
			[Token(Token = "0x6005B5C")]
			[Address(RVA = "0x6ECFF0", Offset = "0x6EC1F0", VA = "0x1806ECFF0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005B5D")]
			[Address(RVA = "0x6ED050", Offset = "0x6EC250", VA = "0x1806ED050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005B5E RID: 23390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B5E")]
		[Address(RVA = "0x9C95A0", Offset = "0x9C87A0", VA = "0x1809C95A0", Slot = "19")]
		protected override void Start()
		{
		}

		// Token: 0x06005B5F RID: 23391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B5F")]
		[Address(RVA = "0x9C8830", Offset = "0x9C7A30", VA = "0x1809C8830")]
		public void Open()
		{
		}

		// Token: 0x06005B60 RID: 23392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B60")]
		[Address(RVA = "0x9C8510", Offset = "0x9C7710", VA = "0x1809C8510")]
		public void Close()
		{
		}

		// Token: 0x06005B61 RID: 23393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B61")]
		[Address(RVA = "0x9C84B0", Offset = "0x9C76B0", VA = "0x1809C84B0")]
		private void SleepEnd()
		{
		}

		// Token: 0x06005B62 RID: 23394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B62")]
		[Address(RVA = "0x9C82E0", Offset = "0x9C74E0", VA = "0x1809C82E0")]
		[ObserversRpc]
		public void AddSoldItem(string id, int amount)
		{
		}

		// Token: 0x06005B63 RID: 23395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B63")]
		[Address(RVA = "0x9C8190", Offset = "0x9C7390", VA = "0x1809C8190")]
		[ObserversRpc]
		public void AddPlayerMoney(float amount)
		{
		}

		// Token: 0x06005B64 RID: 23396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B64")]
		[Address(RVA = "0x9C8040", Offset = "0x9C7240", VA = "0x1809C8040")]
		[ObserversRpc]
		public void AddDealerMoney(float amount)
		{
		}

		// Token: 0x06005B65 RID: 23397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B65")]
		[Address(RVA = "0x9C82F0", Offset = "0x9C74F0", VA = "0x1809C82F0")]
		[ObserversRpc]
		public void AddXP(int xp)
		{
		}

		// Token: 0x06005B66 RID: 23398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B66")]
		[Address(RVA = "0x9C84B0", Offset = "0x9C76B0", VA = "0x1809C84B0")]
		private void ClearStats()
		{
		}

		// Token: 0x06005B67 RID: 23399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B67")]
		[Address(RVA = "0x9C9760", Offset = "0x9C8960", VA = "0x1809C9760")]
		public DailySummary()
		{
		}

		// Token: 0x06005B68 RID: 23400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B68")]
		[Address(RVA = "0x9C86C0", Offset = "0x9C78C0", VA = "0x1809C86C0", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005B69 RID: 23401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B69")]
		[Address(RVA = "0x9C8670", Offset = "0x9C7870", VA = "0x1809C8670", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005B6A RID: 23402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B6A")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005B6B RID: 23403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B6B")]
		[Address(RVA = "0x9C9370", Offset = "0x9C8570", VA = "0x1809C9370")]
		private void RpcWriter___Observers_AddSoldItem_3643459082(string id, int amount)
		{
		}

		// Token: 0x06005B6C RID: 23404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B6C")]
		[Address(RVA = "0x9C9020", Offset = "0x9C8220", VA = "0x1809C9020")]
		public void RpcLogic___AddSoldItem_3643459082(string id, int amount)
		{
		}

		// Token: 0x06005B6D RID: 23405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B6D")]
		[Address(RVA = "0x9C91E0", Offset = "0x9C83E0", VA = "0x1809C91E0")]
		private void RpcReader___Observers_AddSoldItem_3643459082(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005B6E RID: 23406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B6E")]
		[Address(RVA = "0x9C8190", Offset = "0x9C7390", VA = "0x1809C8190")]
		private void RpcWriter___Observers_AddPlayerMoney_431000436(float amount)
		{
		}

		// Token: 0x06005B6F RID: 23407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B6F")]
		[Address(RVA = "0x9C9000", Offset = "0x9C8200", VA = "0x1809C9000")]
		public void RpcLogic___AddPlayerMoney_431000436(float amount)
		{
		}

		// Token: 0x06005B70 RID: 23408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B70")]
		[Address(RVA = "0x9C9180", Offset = "0x9C8380", VA = "0x1809C9180")]
		private void RpcReader___Observers_AddPlayerMoney_431000436(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005B71 RID: 23409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B71")]
		[Address(RVA = "0x9C8040", Offset = "0x9C7240", VA = "0x1809C8040")]
		private void RpcWriter___Observers_AddDealerMoney_431000436(float amount)
		{
		}

		// Token: 0x06005B72 RID: 23410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B72")]
		[Address(RVA = "0x9C8FE0", Offset = "0x9C81E0", VA = "0x1809C8FE0")]
		public void RpcLogic___AddDealerMoney_431000436(float amount)
		{
		}

		// Token: 0x06005B73 RID: 23411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B73")]
		[Address(RVA = "0x9C9120", Offset = "0x9C8320", VA = "0x1809C9120")]
		private void RpcReader___Observers_AddDealerMoney_431000436(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005B74 RID: 23412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B74")]
		[Address(RVA = "0x9C82F0", Offset = "0x9C74F0", VA = "0x1809C82F0")]
		private void RpcWriter___Observers_AddXP_3316948804(int xp)
		{
		}

		// Token: 0x06005B75 RID: 23413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B75")]
		[Address(RVA = "0x9C9110", Offset = "0x9C8310", VA = "0x1809C9110")]
		public void RpcLogic___AddXP_3316948804(int xp)
		{
		}

		// Token: 0x06005B76 RID: 23414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B76")]
		[Address(RVA = "0x9C9310", Offset = "0x9C8510", VA = "0x1809C9310")]
		private void RpcReader___Observers_AddXP_3316948804(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005B77 RID: 23415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B77")]
		[Address(RVA = "0x9C8440", Offset = "0x9C7640", VA = "0x1809C8440", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x04003DBD RID: 15805
		[Token(Token = "0x4003DBD")]
		[FieldOffset(Offset = "0x128")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003DBE RID: 15806
		[Token(Token = "0x4003DBE")]
		[FieldOffset(Offset = "0x130")]
		public RectTransform Container;

		// Token: 0x04003DBF RID: 15807
		[Token(Token = "0x4003DBF")]
		[FieldOffset(Offset = "0x138")]
		public UIScreen UIScreen;

		// Token: 0x04003DC0 RID: 15808
		[Token(Token = "0x4003DC0")]
		[FieldOffset(Offset = "0x140")]
		public Animation Anim;

		// Token: 0x04003DC1 RID: 15809
		[Token(Token = "0x4003DC1")]
		[FieldOffset(Offset = "0x148")]
		public TextMeshProUGUI TitleLabel;

		// Token: 0x04003DC2 RID: 15810
		[Token(Token = "0x4003DC2")]
		[FieldOffset(Offset = "0x150")]
		public RectTransform[] ProductEntries;

		// Token: 0x04003DC3 RID: 15811
		[Token(Token = "0x4003DC3")]
		[FieldOffset(Offset = "0x158")]
		public TextMeshProUGUI PlayerEarningsLabel;

		// Token: 0x04003DC4 RID: 15812
		[Token(Token = "0x4003DC4")]
		[FieldOffset(Offset = "0x160")]
		public TextMeshProUGUI DealerEarningsLabel;

		// Token: 0x04003DC5 RID: 15813
		[Token(Token = "0x4003DC5")]
		[FieldOffset(Offset = "0x168")]
		public TextMeshProUGUI XPGainedLabel;

		// Token: 0x04003DC6 RID: 15814
		[Token(Token = "0x4003DC6")]
		[FieldOffset(Offset = "0x170")]
		public UnityEvent onClosed;

		// Token: 0x04003DC7 RID: 15815
		[Token(Token = "0x4003DC7")]
		[FieldOffset(Offset = "0x178")]
		private Dictionary<string, int> itemsSoldByPlayer;

		// Token: 0x04003DC8 RID: 15816
		[Token(Token = "0x4003DC8")]
		[FieldOffset(Offset = "0x180")]
		private float moneyEarnedByPlayer;

		// Token: 0x04003DC9 RID: 15817
		[Token(Token = "0x4003DC9")]
		[FieldOffset(Offset = "0x184")]
		private float moneyEarnedByDealers;

		// Token: 0x04003DCB RID: 15819
		[Token(Token = "0x4003DCB")]
		[FieldOffset(Offset = "0x18C")]
		private bool NetworkInitialize___EarlyScheduleOne.UI.DailySummaryAssembly-CSharp.dll_Excuted;

		// Token: 0x04003DCC RID: 15820
		[Token(Token = "0x4003DCC")]
		[FieldOffset(Offset = "0x18D")]
		private bool NetworkInitialize__LateScheduleOne.UI.DailySummaryAssembly-CSharp.dll_Excuted;
	}
}
