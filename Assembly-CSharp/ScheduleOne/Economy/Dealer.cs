using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework;
using ScheduleOne.Core;
using ScheduleOne.Dialogue;
using ScheduleOne.ItemFramework;
using ScheduleOne.Map;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.NPCs.Relation;
using ScheduleOne.NPCs.Schedules;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Product;
using ScheduleOne.Quests;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Economy
{
	// Token: 0x020006B3 RID: 1715
	[Token(Token = "0x20006B3")]
	public class Dealer : NPC, IItemSlotOwner
	{
		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06002CD3 RID: 11475 RVA: 0x0000E118 File Offset: 0x0000C318
		// (set) Token: 0x06002CD4 RID: 11476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700079D")]
		public bool IsRecruited
		{
			[Token(Token = "0x6002CD3")]
			[Address(RVA = "0x72EFB0", Offset = "0x72E1B0", VA = "0x18072EFB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002CD4")]
			[Address(RVA = "0x72F0D0", Offset = "0x72E2D0", VA = "0x18072F0D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06002CD5 RID: 11477 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002CD6 RID: 11478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700079E")]
		public List<ItemSlot> ItemSlots
		{
			[Token(Token = "0x6002CD5")]
			[Address(RVA = "0x6F2D00", Offset = "0x6F1F00", VA = "0x1806F2D00", Slot = "130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CD6")]
			[Address(RVA = "0x700530", Offset = "0x6FF730", VA = "0x180700530", Slot = "131")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06002CD7 RID: 11479 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002CD8 RID: 11480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700079F")]
		public NPCPoI PotentialDealerPoI
		{
			[Token(Token = "0x6002CD7")]
			[Address(RVA = "0x72EFC0", Offset = "0x72E1C0", VA = "0x18072EFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CD8")]
			[Address(RVA = "0x72F0E0", Offset = "0x72E2E0", VA = "0x18072F0E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06002CD9 RID: 11481 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002CDA RID: 11482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007A0")]
		public NPCPoI DealerPoI
		{
			[Token(Token = "0x6002CD9")]
			[Address(RVA = "0x72EF90", Offset = "0x72E190", VA = "0x18072EF90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CDA")]
			[Address(RVA = "0x72F0A0", Offset = "0x72E2A0", VA = "0x18072F0A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06002CDB RID: 11483 RVA: 0x0000E130 File Offset: 0x0000C330
		// (set) Token: 0x06002CDC RID: 11484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007A1")]
		public float Cash
		{
			[Token(Token = "0x6002CDB")]
			[Address(RVA = "0x72EF80", Offset = "0x72E180", VA = "0x18072EF80")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002CDC")]
			[Address(RVA = "0x72F010", Offset = "0x72E210", VA = "0x18072F010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06002CDD RID: 11485 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002CDE RID: 11486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007A2")]
		public List<Customer> AssignedCustomers
		{
			[Token(Token = "0x6002CDD")]
			[Address(RVA = "0x72EF70", Offset = "0x72E170", VA = "0x18072EF70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CDE")]
			[Address(RVA = "0x72EFF0", Offset = "0x72E1F0", VA = "0x18072EFF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06002CDF RID: 11487 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002CE0 RID: 11488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007A3")]
		public List<Contract> ActiveContracts
		{
			[Token(Token = "0x6002CDF")]
			[Address(RVA = "0x72EF60", Offset = "0x72E160", VA = "0x18072EF60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CE0")]
			[Address(RVA = "0x72EFD0", Offset = "0x72E1D0", VA = "0x18072EFD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06002CE1 RID: 11489 RVA: 0x0000E148 File Offset: 0x0000C348
		// (set) Token: 0x06002CE2 RID: 11490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007A4")]
		public bool HasBeenRecommended
		{
			[Token(Token = "0x6002CE1")]
			[Address(RVA = "0x72EFA0", Offset = "0x72E1A0", VA = "0x18072EFA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002CE2")]
			[Address(RVA = "0x72F0C0", Offset = "0x72E2C0", VA = "0x18072F0C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002CE3 RID: 11491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CE3")]
		[Address(RVA = "0x721580", Offset = "0x720780", VA = "0x180721580", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x06002CE4 RID: 11492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CE4")]
		[Address(RVA = "0x725B20", Offset = "0x724D20", VA = "0x180725B20", Slot = "16")]
		protected override void OnValidate()
		{
		}

		// Token: 0x06002CE5 RID: 11493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CE5")]
		[Address(RVA = "0x725760", Offset = "0x724960", VA = "0x180725760", Slot = "89")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06002CE6 RID: 11494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CE6")]
		[Address(RVA = "0x72D080", Offset = "0x72C280", VA = "0x18072D080", Slot = "88")]
		protected override void Start()
		{
		}

		// Token: 0x06002CE7 RID: 11495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CE7")]
		[Address(RVA = "0x7257F0", Offset = "0x7249F0", VA = "0x1807257F0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06002CE8 RID: 11496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CE8")]
		[Address(RVA = "0x72BF40", Offset = "0x72B140", VA = "0x18072BF40")]
		private void SetupPoI()
		{
		}

		// Token: 0x06002CE9 RID: 11497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CE9")]
		[Address(RVA = "0x72BD00", Offset = "0x72AF00", VA = "0x18072BD00")]
		private void SetUpDialogue()
		{
		}

		// Token: 0x06002CEA RID: 11498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CEA")]
		[Address(RVA = "0x725990", Offset = "0x724B90", VA = "0x180725990", Slot = "92")]
		protected override void OnTick()
		{
		}

		// Token: 0x06002CEB RID: 11499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CEB")]
		[Address(RVA = "0x724CC0", Offset = "0x723EC0", VA = "0x180724CC0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void MarkAsRecommended()
		{
		}

		// Token: 0x06002CEC RID: 11500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CEC")]
		[Address(RVA = "0x726980", Offset = "0x725B80", VA = "0x180726980")]
		[ObserversRpc(RunLocally = true)]
		private void SetRecommended()
		{
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CED")]
		[Address(RVA = "0x7241A0", Offset = "0x7233A0", VA = "0x1807241A0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void InitialRecruitment()
		{
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CEE")]
		[Address(RVA = "0x72A9C0", Offset = "0x729BC0", VA = "0x18072A9C0", Slot = "141")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public virtual void SetIsRecruited(NetworkConnection conn)
		{
		}

		// Token: 0x06002CEF RID: 11503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CEF")]
		[Address(RVA = "0x725660", Offset = "0x724860", VA = "0x180725660", Slot = "142")]
		protected virtual void OnDealerUnlocked(NPCRelationData.EUnlockType unlockType, bool b)
		{
		}

		// Token: 0x06002CF0 RID: 11504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CF0")]
		[Address(RVA = "0x72EC10", Offset = "0x72DE10", VA = "0x18072EC10", Slot = "143")]
		protected virtual void UpdatePotentialDealerPoI()
		{
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CF1")]
		[Address(RVA = "0x722530", Offset = "0x721730", VA = "0x180722530")]
		private void DealerUnconscious()
		{
		}

		// Token: 0x06002CF2 RID: 11506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CF2")]
		[Address(RVA = "0x72D440", Offset = "0x72C640", VA = "0x18072D440")]
		private void TradeItems()
		{
		}

		// Token: 0x06002CF3 RID: 11507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CF3")]
		[Address(RVA = "0x72D2A0", Offset = "0x72C4A0", VA = "0x18072D2A0")]
		private void TradeItemsDone()
		{
		}

		// Token: 0x06002CF4 RID: 11508 RVA: 0x0000E160 File Offset: 0x0000C360
		[Token(Token = "0x6002CF4")]
		[Address(RVA = "0x7215D0", Offset = "0x7207D0", VA = "0x1807215D0")]
		private bool CanCollectCash(out string reason)
		{
			return default(bool);
		}

		// Token: 0x06002CF5 RID: 11509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CF5")]
		[Address(RVA = "0x72EB80", Offset = "0x72DD80", VA = "0x18072EB80")]
		private void UpdateCollectCashChoice(float oldCash, float newCash, bool asServer)
		{
		}

		// Token: 0x06002CF6 RID: 11510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CF6")]
		[Address(RVA = "0x722160", Offset = "0x721360", VA = "0x180722160")]
		private void CollectCash()
		{
		}

		// Token: 0x06002CF7 RID: 11511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CF7")]
		[Address(RVA = "0x721B70", Offset = "0x720D70", VA = "0x180721B70")]
		private void CheckCurrentDealValidity()
		{
		}

		// Token: 0x06002CF8 RID: 11512 RVA: 0x0000E178 File Offset: 0x0000C378
		[Token(Token = "0x6002CF8")]
		[Address(RVA = "0x721630", Offset = "0x720830", VA = "0x180721630")]
		private bool CanOfferRecruitment(out string reason)
		{
			return default(bool);
		}

		// Token: 0x06002CF9 RID: 11513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CF9")]
		[Address(RVA = "0x721730", Offset = "0x720930", VA = "0x180721730")]
		private void CheckAttendStart()
		{
		}

		// Token: 0x06002CFA RID: 11514 RVA: 0x0000E190 File Offset: 0x0000C390
		[Token(Token = "0x6002CFA")]
		[Address(RVA = "0x72C440", Offset = "0x72B640", VA = "0x18072C440", Slot = "144")]
		public virtual bool ShouldAcceptContract(ContractInfo contractInfo, Customer customer)
		{
			return default(bool);
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CFB")]
		[Address(RVA = "0x722320", Offset = "0x721520", VA = "0x180722320", Slot = "145")]
		public virtual void ContractedOffered(ContractInfo contractInfo, Customer customer)
		{
		}

		// Token: 0x06002CFC RID: 11516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CFC")]
		[Address(RVA = "0x720DE0", Offset = "0x71FFE0", VA = "0x180720DE0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void AddCustomer_Server(string npcID)
		{
		}

		// Token: 0x06002CFD RID: 11517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CFD")]
		[Address(RVA = "0x720B80", Offset = "0x71FD80", VA = "0x180720B80")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void AddCustomer_Client(NetworkConnection conn, string npcID)
		{
		}

		// Token: 0x06002CFE RID: 11518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CFE")]
		[Address(RVA = "0x720F10", Offset = "0x720110", VA = "0x180720F10", Slot = "146")]
		protected virtual void AddCustomer(Customer customer)
		{
		}

		// Token: 0x06002CFF RID: 11519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CFF")]
		[Address(RVA = "0x72A890", Offset = "0x729A90", VA = "0x18072A890")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendRemoveCustomer(string npcID)
		{
		}

		// Token: 0x06002D00 RID: 11520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D00")]
		[Address(RVA = "0x726520", Offset = "0x725720", VA = "0x180726520")]
		[ObserversRpc(RunLocally = true)]
		private void RemoveCustomer(string npcID)
		{
		}

		// Token: 0x06002D01 RID: 11521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D01")]
		[Address(RVA = "0x726480", Offset = "0x725680", VA = "0x180726480", Slot = "147")]
		public virtual void RemoveCustomer(Customer customer)
		{
		}

		// Token: 0x06002D02 RID: 11522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D02")]
		[Address(RVA = "0x721720", Offset = "0x720920", VA = "0x180721720")]
		public void ChangeCash(float change)
		{
		}

		// Token: 0x06002D03 RID: 11523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D03")]
		[Address(RVA = "0x729920", Offset = "0x728B20", VA = "0x180729920")]
		[ServerRpc(RequireOwnership = false)]
		public void SetCash(float cash)
		{
		}

		// Token: 0x06002D04 RID: 11524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D04")]
		[Address(RVA = "0x722210", Offset = "0x721410", VA = "0x180722210", Slot = "148")]
		[ServerRpc(RequireOwnership = false)]
		public virtual void CompletedDeal()
		{
		}

		// Token: 0x06002D05 RID: 11525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D05")]
		[Address(RVA = "0x72A050", Offset = "0x729250", VA = "0x18072A050")]
		[ServerRpc(RequireOwnership = false)]
		public void SubmitPayment(float payment)
		{
		}

		// Token: 0x06002D06 RID: 11526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D06")]
		[Address(RVA = "0x72D740", Offset = "0x72C940", VA = "0x18072D740")]
		public void TryRobDealer()
		{
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002D07")]
		[Address(RVA = "0x723D60", Offset = "0x722F60", VA = "0x180723D60")]
		public List<Tuple<ProductDefinition, EQuality, int>> GetOrderableProducts(EQuality minQuality)
		{
			return null;
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x0000E1A8 File Offset: 0x0000C3A8
		[Token(Token = "0x6002D08")]
		[Address(RVA = "0x723BB0", Offset = "0x722DB0", VA = "0x180723BB0")]
		public int GetOrderableProductQuantity(string productID, EQuality minQuality, EQuality maxQuality)
		{
			return 0;
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002D09")]
		[Address(RVA = "0x722930", Offset = "0x721B30", VA = "0x180722930")]
		[Button]
		private List<Tuple<ProductDefinition, EQuality, int>> GetAvailableProducts()
		{
			return null;
		}

		// Token: 0x06002D0A RID: 11530 RVA: 0x0000E1C0 File Offset: 0x0000C3C0
		[Token(Token = "0x6002D0A")]
		[Address(RVA = "0x723460", Offset = "0x722660", VA = "0x180723460")]
		private EDealWindow GetDealWindow()
		{
			return EDealWindow.Morning;
		}

		// Token: 0x06002D0B RID: 11531 RVA: 0x0000E1D8 File Offset: 0x0000C3D8
		[Token(Token = "0x6002D0B")]
		[Address(RVA = "0x7232A0", Offset = "0x7224A0", VA = "0x1807232A0")]
		private int GetContractCountInWindow(EDealWindow window)
		{
			return 0;
		}

		// Token: 0x06002D0C RID: 11532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D0C")]
		[Address(RVA = "0x720990", Offset = "0x71FB90", VA = "0x180720990")]
		private void AddContract(Contract contract)
		{
		}

		// Token: 0x06002D0D RID: 11533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D0D")]
		[Address(RVA = "0x722470", Offset = "0x721670", VA = "0x180722470")]
		private void CustomerContractEnded(Contract contract)
		{
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D0E")]
		[Address(RVA = "0x72C840", Offset = "0x72BA40", VA = "0x18072C840")]
		private void SortContracts()
		{
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D0F")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "149")]
		protected virtual void RecruitmentRequested()
		{
		}

		// Token: 0x06002D10 RID: 11536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D10")]
		[Address(RVA = "0x7260A0", Offset = "0x7252A0", VA = "0x1807260A0")]
		public void RemoveContractItems(Contract contract, EQuality targetQuality, out List<ItemInstance> items)
		{
		}

		// Token: 0x06002D11 RID: 11537 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002D11")]
		[Address(RVA = "0x725CC0", Offset = "0x724EC0", VA = "0x180725CC0")]
		private List<ProductItemInstance> RemoveAndReturnProductFromInventory(string productID, int requiredQuantity, EQuality targetQuality)
		{
			return null;
		}

		// Token: 0x06002D12 RID: 11538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D12")]
		[Address(RVA = "0x72C990", Offset = "0x72BB90", VA = "0x18072C990")]
		private void SplitItemSlot(ItemSlot slot)
		{
		}

		// Token: 0x06002D13 RID: 11539 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002D13")]
		[Address(RVA = "0x722600", Offset = "0x721800", VA = "0x180722600")]
		private List<ItemSlot> FilterAndSortSlots(List<ItemSlot> slots, string productID, EQuality productQuality, Dealer.EAmountSortOrder amountSortOrder)
		{
			return null;
		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002D14")]
		[Address(RVA = "0x722880", Offset = "0x721A80", VA = "0x180722880")]
		public List<ItemSlot> GetAllSlots()
		{
			return null;
		}

		// Token: 0x06002D15 RID: 11541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D15")]
		[Address(RVA = "0x721000", Offset = "0x720200", VA = "0x180721000")]
		public void AddItemToInventory(ItemInstance item)
		{
		}

		// Token: 0x06002D16 RID: 11542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D16")]
		[Address(RVA = "0x72D620", Offset = "0x72C820", VA = "0x18072D620")]
		public void TryMoveOverflowItems()
		{
		}

		// Token: 0x06002D17 RID: 11543 RVA: 0x0000E1F0 File Offset: 0x0000C3F0
		[Token(Token = "0x6002D17")]
		[Address(RVA = "0x724060", Offset = "0x723260", VA = "0x180724060")]
		public int GetTotalInventoryItemCount()
		{
			return 0;
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x0000E208 File Offset: 0x0000C408
		[Token(Token = "0x6002D18")]
		[Address(RVA = "0x723E50", Offset = "0x723050", VA = "0x180723E50")]
		public int GetPackagedProductAmount()
		{
			return 0;
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D19")]
		[Address(RVA = "0x721BE0", Offset = "0x720DE0", VA = "0x180721BE0", Slot = "150")]
		public virtual void CheckNotifyPlayerOfDeal(Dealer cartelDealer, Contract contract)
		{
		}

		// Token: 0x06002D1A RID: 11546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D1A")]
		[Address(RVA = "0x72BB60", Offset = "0x72AD60", VA = "0x18072BB60", Slot = "132")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D1B")]
		[Address(RVA = "0x72B8A0", Offset = "0x72AAA0", VA = "0x18072B8A0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06002D1C RID: 11548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D1C")]
		[Address(RVA = "0x72ADC0", Offset = "0x729FC0", VA = "0x18072ADC0", Slot = "133")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D1D")]
		[Address(RVA = "0x72AC10", Offset = "0x729E10", VA = "0x18072AC10")]
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D1E")]
		[Address(RVA = "0x72B6B0", Offset = "0x72A8B0", VA = "0x18072B6B0", Slot = "134")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06002D1F RID: 11551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D1F")]
		[Address(RVA = "0x72B390", Offset = "0x72A590", VA = "0x18072B390")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D20")]
		[Address(RVA = "0x72B1F0", Offset = "0x72A3F0", VA = "0x18072B1F0", Slot = "135")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D21")]
		[Address(RVA = "0x72AF30", Offset = "0x72A130", VA = "0x18072AF30")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06002D22 RID: 11554 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002D22")]
		[Address(RVA = "0x7238C0", Offset = "0x722AC0", VA = "0x1807238C0", Slot = "116")]
		public override NPCData GetNPCData()
		{
			return null;
		}

		// Token: 0x06002D23 RID: 11555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D23")]
		[Address(RVA = "0x7242C0", Offset = "0x7234C0", VA = "0x1807242C0", Slot = "120")]
		public override void Load(DynamicSaveData dynamicData, NPCData npcData)
		{
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D24")]
		[Address(RVA = "0x724750", Offset = "0x723950", VA = "0x180724750", Slot = "119")]
		public override void Load(NPCData data, string containerPath)
		{
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D25")]
		[Address(RVA = "0x72ED70", Offset = "0x72DF70", VA = "0x18072ED70")]
		public Dealer()
		{
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D28")]
		[Address(RVA = "0x72E590", Offset = "0x72D790", VA = "0x18072E590")]
		[CompilerGenerated]
		private void <TryRobDealer>g__SummariseLosses|101_0(List<ItemInstance> items, float cash)
		{
		}

		// Token: 0x06002D29 RID: 11561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D29")]
		[Address(RVA = "0x72E120", Offset = "0x72D320", VA = "0x18072E120")]
		[CompilerGenerated]
		private void <RemoveAndReturnProductFromInventory>g__RemoveProduct|112_1(List<ItemSlot> orderedSlots, bool split, bool onlyRemoveIdealQuality, ref Dealer.<>c__DisplayClass112_0 A_4)
		{
		}

		// Token: 0x06002D2A RID: 11562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D2A")]
		[Address(RVA = "0x724E30", Offset = "0x724030", VA = "0x180724E30", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002D2B RID: 11563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D2B")]
		[Address(RVA = "0x724DD0", Offset = "0x723FD0", VA = "0x180724DD0", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D2C")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D2D")]
		[Address(RVA = "0x7296E0", Offset = "0x7288E0", VA = "0x1807296E0")]
		private void RpcWriter___Server_MarkAsRecommended_2166136261()
		{
		}

		// Token: 0x06002D2E RID: 11566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D2E")]
		[Address(RVA = "0x726980", Offset = "0x725B80", VA = "0x180726980")]
		public void RpcLogic___MarkAsRecommended_2166136261()
		{
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D2F")]
		[Address(RVA = "0x727F30", Offset = "0x727130", VA = "0x180727F30")]
		private void RpcReader___Server_MarkAsRecommended_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D30")]
		[Address(RVA = "0x728EE0", Offset = "0x7280E0", VA = "0x180728EE0")]
		private void RpcWriter___Observers_SetRecommended_2166136261()
		{
		}

		// Token: 0x06002D31 RID: 11569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D31")]
		[Address(RVA = "0x727340", Offset = "0x726540", VA = "0x180727340")]
		private void RpcLogic___SetRecommended_2166136261()
		{
		}

		// Token: 0x06002D32 RID: 11570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D32")]
		[Address(RVA = "0x727A80", Offset = "0x726C80", VA = "0x180727A80")]
		private void RpcReader___Observers_SetRecommended_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002D33 RID: 11571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D33")]
		[Address(RVA = "0x7295D0", Offset = "0x7287D0", VA = "0x1807295D0")]
		private void RpcWriter___Server_InitialRecruitment_2166136261()
		{
		}

		// Token: 0x06002D34 RID: 11572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D34")]
		[Address(RVA = "0x726960", Offset = "0x725B60", VA = "0x180726960")]
		public void RpcLogic___InitialRecruitment_2166136261()
		{
		}

		// Token: 0x06002D35 RID: 11573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D35")]
		[Address(RVA = "0x727ED0", Offset = "0x7270D0", VA = "0x180727ED0")]
		private void RpcReader___Server_InitialRecruitment_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002D36 RID: 11574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D36")]
		[Address(RVA = "0x728C40", Offset = "0x727E40", VA = "0x180728C40")]
		private void RpcWriter___Observers_SetIsRecruited_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06002D37 RID: 11575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D37")]
		[Address(RVA = "0x726D40", Offset = "0x725F40", VA = "0x180726D40", Slot = "151")]
		public virtual void RpcLogic___SetIsRecruited_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06002D38 RID: 11576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D38")]
		[Address(RVA = "0x7279A0", Offset = "0x726BA0", VA = "0x1807279A0")]
		private void RpcReader___Observers_SetIsRecruited_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002D39 RID: 11577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D39")]
		[Address(RVA = "0x72A2F0", Offset = "0x7294F0", VA = "0x18072A2F0")]
		private void RpcWriter___Target_SetIsRecruited_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D3A")]
		[Address(RVA = "0x728770", Offset = "0x727970", VA = "0x180728770")]
		private void RpcReader___Target_SetIsRecruited_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002D3B RID: 11579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D3B")]
		[Address(RVA = "0x7294A0", Offset = "0x7286A0", VA = "0x1807294A0")]
		private void RpcWriter___Server_AddCustomer_Server_3615296227(string npcID)
		{
		}

		// Token: 0x06002D3C RID: 11580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D3C")]
		[Address(RVA = "0x726800", Offset = "0x725A00", VA = "0x180726800")]
		public void RpcLogic___AddCustomer_Server_3615296227(string npcID)
		{
		}

		// Token: 0x06002D3D RID: 11581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D3D")]
		[Address(RVA = "0x727CF0", Offset = "0x726EF0", VA = "0x180727CF0")]
		private void RpcReader___Server_AddCustomer_Server_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002D3E RID: 11582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D3E")]
		[Address(RVA = "0x7289C0", Offset = "0x727BC0", VA = "0x1807289C0")]
		private void RpcWriter___Observers_AddCustomer_Client_2971853958(NetworkConnection conn, string npcID)
		{
		}

		// Token: 0x06002D3F RID: 11583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D3F")]
		[Address(RVA = "0x726660", Offset = "0x725860", VA = "0x180726660")]
		private void RpcLogic___AddCustomer_Client_2971853958(NetworkConnection conn, string npcID)
		{
		}

		// Token: 0x06002D40 RID: 11584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D40")]
		[Address(RVA = "0x7278E0", Offset = "0x726AE0", VA = "0x1807278E0")]
		private void RpcReader___Observers_AddCustomer_Client_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002D41 RID: 11585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D41")]
		[Address(RVA = "0x72A190", Offset = "0x729390", VA = "0x18072A190")]
		private void RpcWriter___Target_AddCustomer_Client_2971853958(NetworkConnection conn, string npcID)
		{
		}

		// Token: 0x06002D42 RID: 11586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D42")]
		[Address(RVA = "0x728710", Offset = "0x727910", VA = "0x180728710")]
		private void RpcReader___Target_AddCustomer_Client_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002D43 RID: 11587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D43")]
		[Address(RVA = "0x7297F0", Offset = "0x7289F0", VA = "0x1807297F0")]
		private void RpcWriter___Server_SendRemoveCustomer_3615296227(string npcID)
		{
		}

		// Token: 0x06002D44 RID: 11588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D44")]
		[Address(RVA = "0x726520", Offset = "0x725720", VA = "0x180726520")]
		public void RpcLogic___SendRemoveCustomer_3615296227(string npcID)
		{
		}

		// Token: 0x06002D45 RID: 11589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D45")]
		[Address(RVA = "0x727F80", Offset = "0x727180", VA = "0x180727F80")]
		private void RpcReader___Server_SendRemoveCustomer_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002D46 RID: 11590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D46")]
		[Address(RVA = "0x728B00", Offset = "0x727D00", VA = "0x180728B00")]
		private void RpcWriter___Observers_RemoveCustomer_3615296227(string npcID)
		{
		}

		// Token: 0x06002D47 RID: 11591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D47")]
		[Address(RVA = "0x726AC0", Offset = "0x725CC0", VA = "0x180726AC0")]
		private void RpcLogic___RemoveCustomer_3615296227(string npcID)
		{
		}

		// Token: 0x06002D48 RID: 11592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D48")]
		[Address(RVA = "0x727940", Offset = "0x726B40", VA = "0x180727940")]
		private void RpcReader___Observers_RemoveCustomer_3615296227(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002D49 RID: 11593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D49")]
		[Address(RVA = "0x729920", Offset = "0x728B20", VA = "0x180729920")]
		private void RpcWriter___Server_SetCash_431000436(float cash)
		{
		}

		// Token: 0x06002D4A RID: 11594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D4A")]
		[Address(RVA = "0x726C60", Offset = "0x725E60", VA = "0x180726C60")]
		public void RpcLogic___SetCash_431000436(float cash)
		{
		}

		// Token: 0x06002D4B RID: 11595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D4B")]
		[Address(RVA = "0x727FF0", Offset = "0x7271F0", VA = "0x180727FF0")]
		private void RpcReader___Server_SetCash_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002D4C RID: 11596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D4C")]
		[Address(RVA = "0x722210", Offset = "0x721410", VA = "0x180722210")]
		private void RpcWriter___Server_CompletedDeal_2166136261()
		{
		}

		// Token: 0x06002D4D RID: 11597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D4D")]
		[Address(RVA = "0x726810", Offset = "0x725A10", VA = "0x180726810", Slot = "152")]
		public virtual void RpcLogic___CompletedDeal_2166136261()
		{
		}

		// Token: 0x06002D4E RID: 11598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D4E")]
		[Address(RVA = "0x727D70", Offset = "0x726F70", VA = "0x180727D70")]
		private void RpcReader___Server_CompletedDeal_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002D4F RID: 11599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D4F")]
		[Address(RVA = "0x72A050", Offset = "0x729250", VA = "0x18072A050")]
		private void RpcWriter___Server_SubmitPayment_431000436(float payment)
		{
		}

		// Token: 0x06002D50 RID: 11600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D50")]
		[Address(RVA = "0x7276E0", Offset = "0x7268E0", VA = "0x1807276E0")]
		public void RpcLogic___SubmitPayment_431000436(float payment)
		{
		}

		// Token: 0x06002D51 RID: 11601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D51")]
		[Address(RVA = "0x7284E0", Offset = "0x7276E0", VA = "0x1807284E0")]
		private void RpcReader___Server_SubmitPayment_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002D52 RID: 11602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D52")]
		[Address(RVA = "0x729EE0", Offset = "0x7290E0", VA = "0x180729EE0")]
		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06002D53 RID: 11603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D53")]
		[Address(RVA = "0x7275A0", Offset = "0x7267A0", VA = "0x1807275A0", Slot = "153")]
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06002D54 RID: 11604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D54")]
		[Address(RVA = "0x7283F0", Offset = "0x7275F0", VA = "0x1807283F0")]
		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002D55 RID: 11605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D55")]
		[Address(RVA = "0x729320", Offset = "0x728520", VA = "0x180729320")]
		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06002D56 RID: 11606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D56")]
		[Address(RVA = "0x727620", Offset = "0x726820", VA = "0x180727620")]
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06002D57 RID: 11607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D57")]
		[Address(RVA = "0x727C60", Offset = "0x726E60", VA = "0x180727C60")]
		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002D58 RID: 11608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D58")]
		[Address(RVA = "0x72A720", Offset = "0x729920", VA = "0x18072A720")]
		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06002D59 RID: 11609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D59")]
		[Address(RVA = "0x728930", Offset = "0x727B30", VA = "0x180728930")]
		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002D5A RID: 11610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D5A")]
		[Address(RVA = "0x729A60", Offset = "0x728C60", VA = "0x180729A60")]
		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06002D5B RID: 11611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D5B")]
		[Address(RVA = "0x7272B0", Offset = "0x7264B0", VA = "0x1807272B0", Slot = "154")]
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06002D5C RID: 11612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D5C")]
		[Address(RVA = "0x728100", Offset = "0x727300", VA = "0x180728100")]
		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002D5D RID: 11613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D5D")]
		[Address(RVA = "0x728D60", Offset = "0x727F60", VA = "0x180728D60")]
		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D5E")]
		[Address(RVA = "0x7272C0", Offset = "0x7264C0", VA = "0x1807272C0")]
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06002D5F RID: 11615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D5F")]
		[Address(RVA = "0x7279E0", Offset = "0x726BE0", VA = "0x1807279E0")]
		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002D60 RID: 11616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D60")]
		[Address(RVA = "0x729D50", Offset = "0x728F50", VA = "0x180729D50")]
		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06002D61 RID: 11617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D61")]
		[Address(RVA = "0x727470", Offset = "0x726670", VA = "0x180727470", Slot = "155")]
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06002D62 RID: 11618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D62")]
		[Address(RVA = "0x7282A0", Offset = "0x7274A0", VA = "0x1807282A0")]
		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002D63 RID: 11619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D63")]
		[Address(RVA = "0x72A590", Offset = "0x729790", VA = "0x18072A590")]
		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06002D64 RID: 11620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D64")]
		[Address(RVA = "0x7274F0", Offset = "0x7266F0", VA = "0x1807274F0")]
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06002D65 RID: 11621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D65")]
		[Address(RVA = "0x728840", Offset = "0x727A40", VA = "0x180728840")]
		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002D66 RID: 11622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D66")]
		[Address(RVA = "0x729180", Offset = "0x728380", VA = "0x180729180")]
		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D67")]
		[Address(RVA = "0x727B70", Offset = "0x726D70", VA = "0x180727B70")]
		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002D68 RID: 11624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D68")]
		[Address(RVA = "0x729BE0", Offset = "0x728DE0", VA = "0x180729BE0")]
		private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D69")]
		[Address(RVA = "0x727370", Offset = "0x726570", VA = "0x180727370", Slot = "156")]
		public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06002D6A RID: 11626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D6A")]
		[Address(RVA = "0x7281B0", Offset = "0x7273B0", VA = "0x1807281B0")]
		private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002D6B RID: 11627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D6B")]
		[Address(RVA = "0x729000", Offset = "0x728200", VA = "0x180729000")]
		private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D6C")]
		[Address(RVA = "0x7273F0", Offset = "0x7265F0", VA = "0x1807273F0")]
		private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06002D6D RID: 11629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D6D")]
		[Address(RVA = "0x727AE0", Offset = "0x726CE0", VA = "0x180727AE0")]
		private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002D6E RID: 11630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D6E")]
		[Address(RVA = "0x72A420", Offset = "0x729620", VA = "0x18072A420")]
		private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06002D6F RID: 11631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D6F")]
		[Address(RVA = "0x7287B0", Offset = "0x7279B0", VA = "0x1807287B0")]
		private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06002D70 RID: 11632 RVA: 0x0000E220 File Offset: 0x0000C420
		// (set) Token: 0x06002D71 RID: 11633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007A5")]
		public float SyncAccessor_<Cash>k__BackingField
		{
			[Token(Token = "0x6002D70")]
			[Address(RVA = "0x72EF80", Offset = "0x72E180", VA = "0x18072EF80")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002D71")]
			[Address(RVA = "0x72F100", Offset = "0x72E300", VA = "0x18072F100")]
			set
			{
			}
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x0000E238 File Offset: 0x0000C438
		[Token(Token = "0x6002D72")]
		[Address(RVA = "0x725B70", Offset = "0x724D70", VA = "0x180725B70", Slot = "157")]
		public virtual bool ReadSyncVar___ScheduleOne.Economy.Dealer(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D73")]
		[Address(RVA = "0x7211B0", Offset = "0x7203B0", VA = "0x1807211B0", Slot = "158")]
		protected virtual void Awake_UserLogic_ScheduleOne.Economy.Dealer_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002172 RID: 8562
		[Token(Token = "0x4002172")]
		public const int MAX_CUSTOMERS = 10;

		// Token: 0x04002173 RID: 8563
		[Token(Token = "0x4002173")]
		public const int DEAL_ARRIVAL_DELAY = 30;

		// Token: 0x04002174 RID: 8564
		[Token(Token = "0x4002174")]
		public const int MIN_TRAVEL_TIME = 15;

		// Token: 0x04002175 RID: 8565
		[Token(Token = "0x4002175")]
		public const int MAX_TRAVEL_TIME = 360;

		// Token: 0x04002176 RID: 8566
		[Token(Token = "0x4002176")]
		public const int OVERFLOW_SLOT_COUNT = 10;

		// Token: 0x04002177 RID: 8567
		[Token(Token = "0x4002177")]
		public const float CASH_REMINDER_THRESHOLD = 500f;

		// Token: 0x04002178 RID: 8568
		[Token(Token = "0x4002178")]
		public const float RELATIONSHIP_CHANGE_PER_DEAL = 0.05f;

		// Token: 0x04002179 RID: 8569
		[Token(Token = "0x4002179")]
		[FieldOffset(Offset = "0x0")]
		public static Color32 DealerLabelColor;

		// Token: 0x0400217A RID: 8570
		[Token(Token = "0x400217A")]
		public const int NegativeQualityTolerance = -2;

		// Token: 0x0400217B RID: 8571
		[Token(Token = "0x400217B")]
		public const int PositiveQualityTolerance = 5;

		// Token: 0x0400217C RID: 8572
		[Token(Token = "0x400217C")]
		[FieldOffset(Offset = "0x8")]
		public static Action<Dealer> onDealerRecruited;

		// Token: 0x0400217D RID: 8573
		[Token(Token = "0x400217D")]
		[FieldOffset(Offset = "0x10")]
		public static List<Dealer> AllPlayerDealers;

		// Token: 0x04002186 RID: 8582
		[Token(Token = "0x4002186")]
		[FieldOffset(Offset = "0x368")]
		public Action onContractAccepted;

		// Token: 0x04002187 RID: 8583
		[Token(Token = "0x4002187")]
		[FieldOffset(Offset = "0x370")]
		[Header("Dealer References")]
		public NPCEnterableBuilding Home;

		// Token: 0x04002188 RID: 8584
		[Token(Token = "0x4002188")]
		[FieldOffset(Offset = "0x378")]
		public NPCEvent_StayInBuilding HomeEvent;

		// Token: 0x04002189 RID: 8585
		[Token(Token = "0x4002189")]
		[FieldOffset(Offset = "0x380")]
		public DialogueController_Dealer DialogueController;

		// Token: 0x0400218A RID: 8586
		[Token(Token = "0x400218A")]
		[FieldOffset(Offset = "0x388")]
		[Header("Dialogue stuff")]
		public DialogueContainer RecruitDialogue;

		// Token: 0x0400218B RID: 8587
		[Token(Token = "0x400218B")]
		[FieldOffset(Offset = "0x390")]
		public DialogueContainer CollectCashDialogue;

		// Token: 0x0400218C RID: 8588
		[Token(Token = "0x400218C")]
		[FieldOffset(Offset = "0x398")]
		public DialogueContainer AssignCustomersDialogue;

		// Token: 0x0400218D RID: 8589
		[Token(Token = "0x400218D")]
		[FieldOffset(Offset = "0x3A0")]
		[Header("Dealer Settings")]
		public EDealerType DealerType;

		// Token: 0x0400218E RID: 8590
		[Token(Token = "0x400218E")]
		[FieldOffset(Offset = "0x3A8")]
		public string HomeName;

		// Token: 0x0400218F RID: 8591
		[Token(Token = "0x400218F")]
		[FieldOffset(Offset = "0x3B0")]
		public float SigningFee;

		// Token: 0x04002190 RID: 8592
		[Token(Token = "0x4002190")]
		[FieldOffset(Offset = "0x3B4")]
		public float Cut;

		// Token: 0x04002191 RID: 8593
		[Token(Token = "0x4002191")]
		[FieldOffset(Offset = "0x3B8")]
		[Header("Variables")]
		public string CompletedDealsVariable;

		// Token: 0x04002192 RID: 8594
		[Token(Token = "0x4002192")]
		[FieldOffset(Offset = "0x3C0")]
		[Header("UnityEvents")]
		public UnityEvent onRecommended;

		// Token: 0x04002193 RID: 8595
		[Token(Token = "0x4002193")]
		[FieldOffset(Offset = "0x3C8")]
		public UnityEvent onCompleteDeal;

		// Token: 0x04002194 RID: 8596
		[Token(Token = "0x4002194")]
		[FieldOffset(Offset = "0x3D0")]
		[Header("Seasonal Events")]
		public AvatarSettings ChristmasOutfit;

		// Token: 0x04002195 RID: 8597
		[Token(Token = "0x4002195")]
		[FieldOffset(Offset = "0x3D8")]
		private ItemSlot[] overflowSlots;

		// Token: 0x04002196 RID: 8598
		[Token(Token = "0x4002196")]
		[FieldOffset(Offset = "0x3E0")]
		private Contract currentContract;

		// Token: 0x04002197 RID: 8599
		[Token(Token = "0x4002197")]
		[FieldOffset(Offset = "0x3E8")]
		private DialogueController.DialogueChoice recruitChoice;

		// Token: 0x04002198 RID: 8600
		[Token(Token = "0x4002198")]
		[FieldOffset(Offset = "0x3F0")]
		private DialogueController.DialogueChoice collectCashChoice;

		// Token: 0x04002199 RID: 8601
		[Token(Token = "0x4002199")]
		[FieldOffset(Offset = "0x3F8")]
		private DialogueController.DialogueChoice assignCustomersChoice;

		// Token: 0x0400219A RID: 8602
		[Token(Token = "0x400219A")]
		[FieldOffset(Offset = "0x400")]
		private int itemCountOnTradeStart;

		// Token: 0x0400219B RID: 8603
		[Token(Token = "0x400219B")]
		[FieldOffset(Offset = "0x408")]
		private DealerAttendDealBehaviour _attendDealBehaviour;

		// Token: 0x0400219C RID: 8604
		[Token(Token = "0x400219C")]
		[FieldOffset(Offset = "0x410")]
		public SyncVar<float> syncVar___<Cash>k__BackingField;

		// Token: 0x0400219D RID: 8605
		[Token(Token = "0x400219D")]
		[FieldOffset(Offset = "0x418")]
		private bool NetworkInitialize___EarlyScheduleOne.Economy.DealerAssembly-CSharp.dll_Excuted;

		// Token: 0x0400219E RID: 8606
		[Token(Token = "0x400219E")]
		[FieldOffset(Offset = "0x419")]
		private bool NetworkInitialize__LateScheduleOne.Economy.DealerAssembly-CSharp.dll_Excuted;

		// Token: 0x020006B4 RID: 1716
		[Token(Token = "0x20006B4")]
		private enum EAmountSortOrder
		{
			// Token: 0x040021A0 RID: 8608
			[Token(Token = "0x40021A0")]
			LowToHigh,
			// Token: 0x040021A1 RID: 8609
			[Token(Token = "0x40021A1")]
			HighToLow
		}
	}
}
