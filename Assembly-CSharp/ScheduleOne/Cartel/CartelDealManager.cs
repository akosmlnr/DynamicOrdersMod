using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.Economy;
using ScheduleOne.ItemFramework;
using ScheduleOne.NPCs;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Product;
using ScheduleOne.Quests;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Cartel
{
	// Token: 0x0200079C RID: 1948
	[Token(Token = "0x200079C")]
	public class CartelDealManager : NetworkBehaviour
	{
		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x060033E7 RID: 13287 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060033E8 RID: 13288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700084C")]
		public CartelDealInfo ActiveDeal
		{
			[Token(Token = "0x60033E7")]
			[Address(RVA = "0x5AF080", Offset = "0x5AE280", VA = "0x1805AF080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60033E8")]
			[Address(RVA = "0x5AF0A0", Offset = "0x5AE2A0", VA = "0x1805AF0A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x060033E9 RID: 13289 RVA: 0x0000FC48 File Offset: 0x0000DE48
		// (set) Token: 0x060033EA RID: 13290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700084D")]
		public int HoursUntilNextDealRequest
		{
			[Token(Token = "0x60033E9")]
			[Address(RVA = "0x5219D0", Offset = "0x520BD0", VA = "0x1805219D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60033EA")]
			[Address(RVA = "0x6783F0", Offset = "0x6775F0", VA = "0x1806783F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060033EB RID: 13291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033EB")]
		[Address(RVA = "0x791130", Offset = "0x790330", VA = "0x180791130", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x060033EC RID: 13292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033EC")]
		[Address(RVA = "0x793110", Offset = "0x792310", VA = "0x180793110")]
		private void Start()
		{
		}

		// Token: 0x060033ED RID: 13293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033ED")]
		[Address(RVA = "0x792130", Offset = "0x791330", VA = "0x180792130", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060033EE RID: 13294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033EE")]
		[Address(RVA = "0x791F70", Offset = "0x791170", VA = "0x180791F70")]
		private void MinPass()
		{
		}

		// Token: 0x060033EF RID: 13295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033EF")]
		[Address(RVA = "0x792190", Offset = "0x791390", VA = "0x180792190")]
		private void OnTimeSkip(int mins)
		{
		}

		// Token: 0x060033F0 RID: 13296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033F0")]
		[Address(RVA = "0x791AA0", Offset = "0x790CA0", VA = "0x180791AA0")]
		private void HourPass()
		{
		}

		// Token: 0x060033F1 RID: 13297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033F1")]
		[Address(RVA = "0x6783F0", Offset = "0x6775F0", VA = "0x1806783F0")]
		public void SetHoursUntilDealRequest(int hours)
		{
		}

		// Token: 0x060033F2 RID: 13298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033F2")]
		[Address(RVA = "0x792A00", Offset = "0x791C00", VA = "0x180792A00")]
		private void SleepEnd()
		{
		}

		// Token: 0x060033F3 RID: 13299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033F3")]
		[Address(RVA = "0x791EA0", Offset = "0x7910A0", VA = "0x180791EA0")]
		private void MarkDealOverdue()
		{
		}

		// Token: 0x060033F4 RID: 13300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033F4")]
		[Address(RVA = "0x791920", Offset = "0x790B20", VA = "0x180791920")]
		private void ExpireDeal()
		{
		}

		// Token: 0x060033F5 RID: 13301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033F5")]
		[Address(RVA = "0x7911E0", Offset = "0x7903E0", VA = "0x1807911E0")]
		private void CheckDealCompletion()
		{
		}

		// Token: 0x060033F6 RID: 13302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033F6")]
		[Address(RVA = "0x791420", Offset = "0x790620", VA = "0x180791420")]
		private void CompleteDeal()
		{
		}

		// Token: 0x060033F7 RID: 13303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033F7")]
		[Address(RVA = "0x791830", Offset = "0x790A30", VA = "0x180791830")]
		private void DepositCash(float amount)
		{
		}

		// Token: 0x060033F8 RID: 13304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033F8")]
		[Address(RVA = "0x792BD0", Offset = "0x791DD0", VA = "0x180792BD0")]
		[Button]
		private void StartDeal()
		{
		}

		// Token: 0x060033F9 RID: 13305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033F9")]
		[Address(RVA = "0x791DD0", Offset = "0x790FD0", VA = "0x180791DD0")]
		public void LoadDeal(CartelDealInfo dealInfo)
		{
		}

		// Token: 0x060033FA RID: 13306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033FA")]
		[Address(RVA = "0x791B50", Offset = "0x790D50", VA = "0x180791B50")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void InitializeDealQuest(NetworkConnection conn, CartelDealInfo dealInfo)
		{
		}

		// Token: 0x060033FB RID: 13307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033FB")]
		[Address(RVA = "0x792790", Offset = "0x791990", VA = "0x180792790")]
		private void SendRequestMessage(CartelDealInfo dealInfo)
		{
		}

		// Token: 0x060033FC RID: 13308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033FC")]
		[Address(RVA = "0x7926E0", Offset = "0x7918E0", VA = "0x1807926E0")]
		private void SendOverdueMessage()
		{
		}

		// Token: 0x060033FD RID: 13309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033FD")]
		[Address(RVA = "0x792630", Offset = "0x791830", VA = "0x180792630")]
		private void SendExpiryMessage()
		{
		}

		// Token: 0x060033FE RID: 13310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033FE")]
		[Address(RVA = "0x791DE0", Offset = "0x790FE0", VA = "0x180791DE0")]
		public void Load(CartelData data)
		{
		}

		// Token: 0x060033FF RID: 13311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033FF")]
		[Address(RVA = "0x791180", Offset = "0x790380", VA = "0x180791180")]
		private void CartelStatusChange(ECartelStatus oldStatus, ECartelStatus newStatus)
		{
		}

		// Token: 0x06003400 RID: 13312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003400")]
		[Address(RVA = "0x793640", Offset = "0x792840", VA = "0x180793640")]
		public CartelDealManager()
		{
		}

		// Token: 0x06003401 RID: 13313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003401")]
		[Address(RVA = "0x792060", Offset = "0x791260", VA = "0x180792060", Slot = "20")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003402 RID: 13314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003402")]
		[Address(RVA = "0x792040", Offset = "0x791240", VA = "0x180792040", Slot = "21")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003403 RID: 13315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003403")]
		[Address(RVA = "0x5914A0", Offset = "0x5906A0", VA = "0x1805914A0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003404 RID: 13316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003404")]
		[Address(RVA = "0x792390", Offset = "0x791590", VA = "0x180792390")]
		private void RpcWriter___Observers_InitializeDealQuest_2137933519(NetworkConnection conn, CartelDealInfo dealInfo)
		{
		}

		// Token: 0x06003405 RID: 13317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003405")]
		[Address(RVA = "0x792230", Offset = "0x791430", VA = "0x180792230")]
		private void RpcLogic___InitializeDealQuest_2137933519(NetworkConnection conn, CartelDealInfo dealInfo)
		{
		}

		// Token: 0x06003406 RID: 13318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003406")]
		[Address(RVA = "0x792290", Offset = "0x791490", VA = "0x180792290")]
		private void RpcReader___Observers_InitializeDealQuest_2137933519(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003407 RID: 13319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003407")]
		[Address(RVA = "0x7924D0", Offset = "0x7916D0", VA = "0x1807924D0")]
		private void RpcWriter___Target_InitializeDealQuest_2137933519(NetworkConnection conn, CartelDealInfo dealInfo)
		{
		}

		// Token: 0x06003408 RID: 13320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003408")]
		[Address(RVA = "0x792310", Offset = "0x791510", VA = "0x180792310")]
		private void RpcReader___Target_InitializeDealQuest_2137933519(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003409 RID: 13321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003409")]
		[Address(RVA = "0x791120", Offset = "0x790320", VA = "0x180791120")]
		private void Awake_UserLogic_ScheduleOne.Cartel.CartelDealManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040025FE RID: 9726
		[Token(Token = "0x40025FE")]
		public const int DEAL_DUE_TIME_DAYS = 3;

		// Token: 0x040025FF RID: 9727
		[Token(Token = "0x40025FF")]
		public const float PAYMENT_MULTIPLIER = 0.65f;

		// Token: 0x04002600 RID: 9728
		[Token(Token = "0x4002600")]
		public const int DEAL_COOLDOWN_HOURS = 24;

		// Token: 0x04002603 RID: 9731
		[Token(Token = "0x4002603")]
		[FieldOffset(Offset = "0x128")]
		[Header("References")]
		public NPC RequestingNPC;

		// Token: 0x04002604 RID: 9732
		[Token(Token = "0x4002604")]
		[FieldOffset(Offset = "0x130")]
		public Quest_DealForCartel DealQuest;

		// Token: 0x04002605 RID: 9733
		[Token(Token = "0x4002605")]
		[FieldOffset(Offset = "0x138")]
		public WorldStorageEntity DeliveryEntity;

		// Token: 0x04002606 RID: 9734
		[Token(Token = "0x4002606")]
		[FieldOffset(Offset = "0x140")]
		public Transform CashSpawnPoint;

		// Token: 0x04002607 RID: 9735
		[Token(Token = "0x4002607")]
		[FieldOffset(Offset = "0x148")]
		public Quest MethRequestPrereqQuest;

		// Token: 0x04002608 RID: 9736
		[Token(Token = "0x4002608")]
		[FieldOffset(Offset = "0x150")]
		public Supplier CokeRequestPrereqSupplier;

		// Token: 0x04002609 RID: 9737
		[Token(Token = "0x4002609")]
		[FieldOffset(Offset = "0x158")]
		[Header("Settings")]
		public CashPickup CashPrefab;

		// Token: 0x0400260A RID: 9738
		[Token(Token = "0x400260A")]
		[FieldOffset(Offset = "0x160")]
		public ProductDefinition[] RequestableWeed;

		// Token: 0x0400260B RID: 9739
		[Token(Token = "0x400260B")]
		[FieldOffset(Offset = "0x168")]
		public ProductDefinition MethDefinition;

		// Token: 0x0400260C RID: 9740
		[Token(Token = "0x400260C")]
		[FieldOffset(Offset = "0x170")]
		public ProductDefinition CocaineDefinition;

		// Token: 0x0400260D RID: 9741
		[Token(Token = "0x400260D")]
		[FieldOffset(Offset = "0x178")]
		public int ProductQuantityMin;

		// Token: 0x0400260E RID: 9742
		[Token(Token = "0x400260E")]
		[FieldOffset(Offset = "0x17C")]
		public int ProductQuantityMax;

		// Token: 0x0400260F RID: 9743
		[Token(Token = "0x400260F")]
		[FieldOffset(Offset = "0x180")]
		private bool NetworkInitialize___EarlyScheduleOne.Cartel.CartelDealManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04002610 RID: 9744
		[Token(Token = "0x4002610")]
		[FieldOffset(Offset = "0x181")]
		private bool NetworkInitialize__LateScheduleOne.Cartel.CartelDealManagerAssembly-CSharp.dll_Excuted;
	}
}
