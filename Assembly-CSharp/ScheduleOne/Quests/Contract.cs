using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Object;
using Il2CppDummyDll;
using ScheduleOne.Economy;
using ScheduleOne.GameTime;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.Quests
{
	// Token: 0x02000326 RID: 806
	[Token(Token = "0x2000326")]
	public class Contract : Quest
	{
		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06001365 RID: 4965 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001366 RID: 4966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F5")]
		public NetworkObject Customer
		{
			[Token(Token = "0x6001365")]
			[Address(RVA = "0x57F810", Offset = "0x57EA10", VA = "0x18057F810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001366")]
			[Address(RVA = "0x57F850", Offset = "0x57EA50", VA = "0x18057F850")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06001367 RID: 4967 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001368 RID: 4968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F6")]
		public Dealer Dealer
		{
			[Token(Token = "0x6001367")]
			[Address(RVA = "0x57F820", Offset = "0x57EA20", VA = "0x18057F820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001368")]
			[Address(RVA = "0x57F870", Offset = "0x57EA70", VA = "0x18057F870")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06001369 RID: 4969 RVA: 0x00008C28 File Offset: 0x00006E28
		// (set) Token: 0x0600136A RID: 4970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F7")]
		public float Payment
		{
			[Token(Token = "0x6001369")]
			[Address(RVA = "0x511750", Offset = "0x510950", VA = "0x180511750")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600136A")]
			[Address(RVA = "0x57F890", Offset = "0x57EA90", VA = "0x18057F890")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x0600136B RID: 4971 RVA: 0x00008C40 File Offset: 0x00006E40
		// (set) Token: 0x0600136C RID: 4972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F8")]
		public int PickupScheduleIndex
		{
			[Token(Token = "0x600136B")]
			[Address(RVA = "0x57F830", Offset = "0x57EA30", VA = "0x18057F830")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600136C")]
			[Address(RVA = "0x57F8A0", Offset = "0x57EAA0", VA = "0x18057F8A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x0600136D RID: 4973 RVA: 0x00008C58 File Offset: 0x00006E58
		// (set) Token: 0x0600136E RID: 4974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F9")]
		public GameDateTime AcceptTime
		{
			[Token(Token = "0x600136D")]
			[Address(RVA = "0x57F800", Offset = "0x57EA00", VA = "0x18057F800")]
			[CompilerGenerated]
			get
			{
				return default(GameDateTime);
			}
			[Token(Token = "0x600136E")]
			[Address(RVA = "0x57F840", Offset = "0x57EA40", VA = "0x18057F840")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600136F")]
		[Address(RVA = "0x57F0D0", Offset = "0x57E2D0", VA = "0x18057F0D0", Slot = "31")]
		protected override void Start()
		{
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001370")]
		[Address(RVA = "0x57E7B0", Offset = "0x57D9B0", VA = "0x18057E7B0", Slot = "57")]
		public virtual void InitializeContract(string title, string description, QuestEntryData[] entries, string guid, Customer customer, float payment, ProductList products, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, int pickupScheduleIndex, GameDateTime acceptTime)
		{
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001371")]
		[Address(RVA = "0x57EF60", Offset = "0x57E160", VA = "0x18057EF60", Slot = "58")]
		public virtual void SilentlyInitializeContract(string title, string description, QuestEntryData[] entries, string guid, Customer customer, float payment, ProductList products, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, int pickupScheduleIndex, GameDateTime acceptTime)
		{
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001372")]
		[Address(RVA = "0x57EB10", Offset = "0x57DD10", VA = "0x18057EB10", Slot = "44")]
		protected override void OnUncappedMinPass()
		{
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001373")]
		[Address(RVA = "0x57EA90", Offset = "0x57DC90", VA = "0x18057EA90")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001374")]
		[Address(RVA = "0x57F320", Offset = "0x57E520", VA = "0x18057F320")]
		private void UpdateTiming()
		{
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001375")]
		[Address(RVA = "0x57F190", Offset = "0x57E390", VA = "0x18057F190")]
		public void UpdatePoI()
		{
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001376")]
		[Address(RVA = "0x57D300", Offset = "0x57C500", VA = "0x18057D300", Slot = "39")]
		public override void End()
		{
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001377")]
		[Address(RVA = "0x57CCA0", Offset = "0x57BEA0", VA = "0x18057CCA0", Slot = "35")]
		public override void Complete(bool network = true)
		{
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001378")]
		[Address(RVA = "0x57D3F0", Offset = "0x57C5F0", VA = "0x18057D3F0", Slot = "37")]
		public override void Expire(bool network = true)
		{
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001379")]
		[Address(RVA = "0x57D590", Offset = "0x57C790", VA = "0x18057D590", Slot = "36")]
		public override void Fail(bool network = true)
		{
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600137A")]
		[Address(RVA = "0x57ED70", Offset = "0x57DF70", VA = "0x18057ED70")]
		public void SetDealer(Dealer dealer)
		{
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600137B")]
		[Address(RVA = "0x57F0E0", Offset = "0x57E2E0", VA = "0x18057F0E0", Slot = "59")]
		public virtual void SubmitPayment(float bonusTotal)
		{
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600137C")]
		[Address(RVA = "0x57EC50", Offset = "0x57DE50", VA = "0x18057EC50", Slot = "47")]
		protected override void SendExpiryReminder()
		{
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600137D")]
		[Address(RVA = "0x57EB30", Offset = "0x57DD30", VA = "0x18057EB30", Slot = "48")]
		protected override void SendExpiredNotification()
		{
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x00008C70 File Offset: 0x00006E70
		[Token(Token = "0x600137E")]
		[Address(RVA = "0x57EEE0", Offset = "0x57E0E0", VA = "0x18057EEE0", Slot = "41")]
		protected override bool ShouldShowJournalEntry()
		{
			return default(bool);
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x00008C88 File Offset: 0x00006E88
		[Token(Token = "0x600137F")]
		[Address(RVA = "0x57CBA0", Offset = "0x57BDA0", VA = "0x18057CBA0", Slot = "46")]
		protected override bool CanExpire()
		{
			return default(bool);
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x00008CA0 File Offset: 0x00006EA0
		[Token(Token = "0x6001380")]
		[Address(RVA = "0x57CDB0", Offset = "0x57BFB0", VA = "0x18057CDB0")]
		public bool DoesProductListMatchSpecified(List<ItemInstance> items, bool enforceQuality)
		{
			return default(bool);
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x00008CB8 File Offset: 0x00006EB8
		[Token(Token = "0x6001381")]
		[Address(RVA = "0x57DB60", Offset = "0x57CD60", VA = "0x18057DB60")]
		public float GetProductListMatch(List<ItemInstance> items, out int matchedProductCount)
		{
			return 0f;
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001382")]
		[Address(RVA = "0x57D740", Offset = "0x57C940", VA = "0x18057D740")]
		private Dictionary<ProductItemInstance, float> GetDescendingMatchRatings(ProductList.Entry requestedItem, List<ItemInstance> providedItems)
		{
			return null;
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001383")]
		[Address(RVA = "0x57E360", Offset = "0x57D560", VA = "0x18057E360", Slot = "55")]
		public override SaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x00008CD0 File Offset: 0x00006ED0
		[Token(Token = "0x6001384")]
		[Address(RVA = "0x57EE60", Offset = "0x57E060", VA = "0x18057EE60")]
		public new bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001385")]
		[Address(RVA = "0x57F7B0", Offset = "0x57E9B0", VA = "0x18057F7B0")]
		public Contract()
		{
		}

		// Token: 0x040011EC RID: 4588
		[Token(Token = "0x40011EC")]
		public const int DefaultExpiryTime = 2880;

		// Token: 0x040011ED RID: 4589
		[Token(Token = "0x40011ED")]
		public const float ExcessProductsMatchSumMultiplier = 0.5f;

		// Token: 0x040011EE RID: 4590
		[Token(Token = "0x40011EE")]
		[FieldOffset(Offset = "0x0")]
		public static List<Contract> Contracts;

		// Token: 0x040011F2 RID: 4594
		[Token(Token = "0x40011F2")]
		[FieldOffset(Offset = "0x150")]
		[Header("Contract Settings")]
		public ProductList ProductList;

		// Token: 0x040011F3 RID: 4595
		[Token(Token = "0x40011F3")]
		[FieldOffset(Offset = "0x158")]
		public DeliveryLocation DeliveryLocation;

		// Token: 0x040011F4 RID: 4596
		[Token(Token = "0x40011F4")]
		[FieldOffset(Offset = "0x160")]
		public QuestWindowConfig DeliveryWindow;

		// Token: 0x040011F7 RID: 4599
		[Token(Token = "0x40011F7")]
		[FieldOffset(Offset = "0x174")]
		private bool completedContractsIncremented;

		// Token: 0x02000327 RID: 807
		[Token(Token = "0x2000327")]
		public class BonusPayment
		{
			// Token: 0x06001387 RID: 4999 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001387")]
			[Address(RVA = "0x57C520", Offset = "0x57B720", VA = "0x18057C520")]
			public BonusPayment(string title, float amount)
			{
			}

			// Token: 0x040011F8 RID: 4600
			[Token(Token = "0x40011F8")]
			[FieldOffset(Offset = "0x10")]
			public string Title;

			// Token: 0x040011F9 RID: 4601
			[Token(Token = "0x40011F9")]
			[FieldOffset(Offset = "0x18")]
			public float Amount;
		}
	}
}
