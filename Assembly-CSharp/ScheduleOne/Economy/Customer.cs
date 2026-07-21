using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.DevUtilities;
using ScheduleOne.Dialogue;
using ScheduleOne.GameTime;
using ScheduleOne.ItemFramework;
using ScheduleOne.Map;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Relation;
using ScheduleOne.NPCs.Schedules;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product;
using ScheduleOne.Quests;
using ScheduleOne.UI.Handover;
using ScheduleOne.UI.Phone.Messages;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Economy
{
	// Token: 0x02000695 RID: 1685
	[Token(Token = "0x2000695")]
	[RequireComponent(typeof(NPC))]
	[DisallowMultipleComponent]
	public class Customer : NetworkBehaviour, ISaveable
	{
		// Token: 0x06002B95 RID: 11157 RVA: 0x0000DB78 File Offset: 0x0000BD78
		[Token(Token = "0x6002B95")]
		[Address(RVA = "0x70DD60", Offset = "0x70CF60", VA = "0x18070DD60")]
		public static int MinsSinceLastDealOfferedAllCustomers()
		{
			return 0;
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06002B96 RID: 11158 RVA: 0x0000DB90 File Offset: 0x0000BD90
		// (set) Token: 0x06002B97 RID: 11159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000779")]
		public float CurrentAddiction
		{
			[Token(Token = "0x6002B96")]
			[Address(RVA = "0x5C0F90", Offset = "0x5C0190", VA = "0x1805C0F90")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002B97")]
			[Address(RVA = "0x71D5E0", Offset = "0x71C7E0", VA = "0x18071D5E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06002B98 RID: 11160 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002B99 RID: 11161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700077A")]
		public ContractInfo OfferedContractInfo
		{
			[Token(Token = "0x6002B98")]
			[Address(RVA = "0x58D0A0", Offset = "0x58C2A0", VA = "0x18058D0A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B99")]
			[Address(RVA = "0x58D280", Offset = "0x58C480", VA = "0x18058D280")]
			protected set
			{
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06002B9A RID: 11162 RVA: 0x0000DBA8 File Offset: 0x0000BDA8
		// (set) Token: 0x06002B9B RID: 11163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700077B")]
		public GameDateTime OfferedContractTime
		{
			[Token(Token = "0x6002B9A")]
			[Address(RVA = "0x521AC0", Offset = "0x520CC0", VA = "0x180521AC0")]
			[CompilerGenerated]
			get
			{
				return default(GameDateTime);
			}
			[Token(Token = "0x6002B9B")]
			[Address(RVA = "0x71D740", Offset = "0x71C940", VA = "0x18071D740")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06002B9C RID: 11164 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002B9D RID: 11165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700077C")]
		public Contract CurrentContract
		{
			[Token(Token = "0x6002B9C")]
			[Address(RVA = "0x5A44F0", Offset = "0x5A36F0", VA = "0x1805A44F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B9D")]
			[Address(RVA = "0x5A45A0", Offset = "0x5A37A0", VA = "0x1805A45A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06002B9E RID: 11166 RVA: 0x0000DBC0 File Offset: 0x0000BDC0
		// (set) Token: 0x06002B9F RID: 11167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700077D")]
		public bool IsAwaitingDelivery
		{
			[Token(Token = "0x6002B9E")]
			[Address(RVA = "0x511360", Offset = "0x510560", VA = "0x180511360")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002B9F")]
			[Address(RVA = "0x5A4540", Offset = "0x5A3740", VA = "0x1805A4540")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06002BA0 RID: 11168 RVA: 0x0000DBD8 File Offset: 0x0000BDD8
		// (set) Token: 0x06002BA1 RID: 11169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700077E")]
		public int TimeSinceLastDealCompleted
		{
			[Token(Token = "0x6002BA0")]
			[Address(RVA = "0x71D590", Offset = "0x71C790", VA = "0x18071D590")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002BA1")]
			[Address(RVA = "0x71D770", Offset = "0x71C970", VA = "0x18071D770")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06002BA2 RID: 11170 RVA: 0x0000DBF0 File Offset: 0x0000BDF0
		// (set) Token: 0x06002BA3 RID: 11171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700077F")]
		public int TimeSinceLastDealOffered
		{
			[Token(Token = "0x6002BA2")]
			[Address(RVA = "0x71D5A0", Offset = "0x71C7A0", VA = "0x18071D5A0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002BA3")]
			[Address(RVA = "0x71D780", Offset = "0x71C980", VA = "0x18071D780")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06002BA4 RID: 11172 RVA: 0x0000DC08 File Offset: 0x0000BE08
		// (set) Token: 0x06002BA5 RID: 11173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000780")]
		public int TimeSincePlayerApproached
		{
			[Token(Token = "0x6002BA4")]
			[Address(RVA = "0x511740", Offset = "0x510940", VA = "0x180511740")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002BA5")]
			[Address(RVA = "0x71D790", Offset = "0x71C990", VA = "0x18071D790")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06002BA6 RID: 11174 RVA: 0x0000DC20 File Offset: 0x0000BE20
		// (set) Token: 0x06002BA7 RID: 11175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000781")]
		public int TimeSinceInstantDealOffered
		{
			[Token(Token = "0x6002BA6")]
			[Address(RVA = "0x71D580", Offset = "0x71C780", VA = "0x18071D580")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002BA7")]
			[Address(RVA = "0x71D760", Offset = "0x71C960", VA = "0x18071D760")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06002BA8 RID: 11176 RVA: 0x0000DC38 File Offset: 0x0000BE38
		// (set) Token: 0x06002BA9 RID: 11177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000782")]
		public int OfferedDeals
		{
			[Token(Token = "0x6002BA8")]
			[Address(RVA = "0x71D510", Offset = "0x71C710", VA = "0x18071D510")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002BA9")]
			[Address(RVA = "0x71D750", Offset = "0x71C950", VA = "0x18071D750")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06002BAA RID: 11178 RVA: 0x0000DC50 File Offset: 0x0000BE50
		// (set) Token: 0x06002BAB RID: 11179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000783")]
		public int CompletedDeliveries
		{
			[Token(Token = "0x6002BAA")]
			[Address(RVA = "0x6AAEE0", Offset = "0x6AA0E0", VA = "0x1806AAEE0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002BAB")]
			[Address(RVA = "0x6AB070", Offset = "0x6AA270", VA = "0x1806AB070")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06002BAC RID: 11180 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002BAD RID: 11181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000784")]
		public List<Customer.ProductPurchaseRecord> WeeklyPurchaseRecord
		{
			[Token(Token = "0x6002BAC")]
			[Address(RVA = "0x5887C0", Offset = "0x5879C0", VA = "0x1805887C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002BAD")]
			[Address(RVA = "0x6783D0", Offset = "0x6775D0", VA = "0x1806783D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06002BAE RID: 11182 RVA: 0x0000DC68 File Offset: 0x0000BE68
		// (set) Token: 0x06002BAF RID: 11183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000785")]
		public bool HasBeenRecommended
		{
			[Token(Token = "0x6002BAE")]
			[Address(RVA = "0x71D4F0", Offset = "0x71C6F0", VA = "0x18071D4F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002BAF")]
			[Address(RVA = "0x71D670", Offset = "0x71C870", VA = "0x18071D670")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06002BB0 RID: 11184 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002BB1 RID: 11185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000786")]
		public NPC NPC
		{
			[Token(Token = "0x6002BB0")]
			[Address(RVA = "0x5887E0", Offset = "0x5879E0", VA = "0x1805887E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002BB1")]
			[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06002BB2 RID: 11186 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002BB3 RID: 11187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000787")]
		public Dealer AssignedDealer
		{
			[Token(Token = "0x6002BB2")]
			[Address(RVA = "0x628900", Offset = "0x627B00", VA = "0x180628900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002BB3")]
			[Address(RVA = "0x628A30", Offset = "0x627C30", VA = "0x180628A30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06002BB4 RID: 11188 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000788")]
		public CustomerData CustomerData
		{
			[Token(Token = "0x6002BB4")]
			[Address(RVA = "0x71D4E0", Offset = "0x71C6E0", VA = "0x18071D4E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06002BB5 RID: 11189 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000789")]
		private DialogueDatabase dialogueDatabase
		{
			[Token(Token = "0x6002BB5")]
			[Address(RVA = "0x71D5B0", Offset = "0x71C7B0", VA = "0x18071D5B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06002BB6 RID: 11190 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002BB7 RID: 11191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700078A")]
		public NPCPoI potentialCustomerPoI
		{
			[Token(Token = "0x6002BB6")]
			[Address(RVA = "0x6DDB10", Offset = "0x6DCD10", VA = "0x1806DDB10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002BB7")]
			[Address(RVA = "0x71D7A0", Offset = "0x71C9A0", VA = "0x18071D7A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06002BB8 RID: 11192 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700078B")]
		public string SaveFolderName
		{
			[Token(Token = "0x6002BB8")]
			[Address(RVA = "0x71D550", Offset = "0x71C750", VA = "0x18071D550", Slot = "19")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06002BB9 RID: 11193 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700078C")]
		public string SaveFileName
		{
			[Token(Token = "0x6002BB9")]
			[Address(RVA = "0x71D520", Offset = "0x71C720", VA = "0x18071D520", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06002BBA RID: 11194 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700078D")]
		public Loader Loader
		{
			[Token(Token = "0x6002BBA")]
			[Address(RVA = "0x490CA0", Offset = "0x48FEA0", VA = "0x180490CA0", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06002BBB RID: 11195 RVA: 0x0000DC80 File Offset: 0x0000BE80
		[Token(Token = "0x1700078E")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6002BBB")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06002BBC RID: 11196 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002BBD RID: 11197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700078F")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6002BBC")]
			[Address(RVA = "0x71D500", Offset = "0x71C700", VA = "0x18071D500", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002BBD")]
			[Address(RVA = "0x71D700", Offset = "0x71C900", VA = "0x18071D700", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06002BBE RID: 11198 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002BBF RID: 11199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000790")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6002BBE")]
			[Address(RVA = "0x66BA60", Offset = "0x66AC60", VA = "0x18066BA60", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002BBF")]
			[Address(RVA = "0x71D720", Offset = "0x71C920", VA = "0x18071D720", Slot = "26")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06002BC0 RID: 11200 RVA: 0x0000DC98 File Offset: 0x0000BE98
		// (set) Token: 0x06002BC1 RID: 11201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000791")]
		public bool HasChanged
		{
			[Token(Token = "0x6002BC0")]
			[Address(RVA = "0x6EA340", Offset = "0x6E9540", VA = "0x1806EA340", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002BC1")]
			[Address(RVA = "0x6EA350", Offset = "0x6E9550", VA = "0x1806EA350", Slot = "28")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002BC2 RID: 11202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BC2")]
		[Address(RVA = "0x707DE0", Offset = "0x706FE0", VA = "0x180707DE0", Slot = "42")]
		public virtual void Awake()
		{
		}

		// Token: 0x06002BC3 RID: 11203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BC3")]
		[Address(RVA = "0x71B130", Offset = "0x71A330", VA = "0x18071B130")]
		private void Start()
		{
		}

		// Token: 0x06002BC4 RID: 11204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BC4")]
		[Address(RVA = "0x7102B0", Offset = "0x70F4B0", VA = "0x1807102B0", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x06002BC5 RID: 11205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BC5")]
		[Address(RVA = "0x710100", Offset = "0x70F300", VA = "0x180710100", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06002BC6 RID: 11206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BC6")]
		[Address(RVA = "0x70F5F0", Offset = "0x70E7F0", VA = "0x18070F5F0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002BC7 RID: 11207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BC7")]
		[Address(RVA = "0x7199B0", Offset = "0x718BB0", VA = "0x1807199B0")]
		private void SetUpDialogue()
		{
		}

		// Token: 0x06002BC8 RID: 11208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BC8")]
		[Address(RVA = "0x71A2D0", Offset = "0x7194D0", VA = "0x18071A2D0")]
		private void SetupPoI()
		{
		}

		// Token: 0x06002BC9 RID: 11209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BC9")]
		[Address(RVA = "0x70CFF0", Offset = "0x70C1F0", VA = "0x18070CFF0", Slot = "43")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BCA")]
		[Address(RVA = "0x70F920", Offset = "0x70EB20", VA = "0x18070F920", Slot = "44")]
		protected virtual void OnMinPass()
		{
		}

		// Token: 0x06002BCB RID: 11211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BCB")]
		[Address(RVA = "0x7102D0", Offset = "0x70F4D0", VA = "0x1807102D0", Slot = "45")]
		protected virtual void OnTick()
		{
		}

		// Token: 0x06002BCC RID: 11212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BCC")]
		[Address(RVA = "0x70EAA0", Offset = "0x70DCA0", VA = "0x18070EAA0")]
		private void OfferContractToDealer(ContractInfo info, Dealer dealer)
		{
		}

		// Token: 0x06002BCD RID: 11213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BCD")]
		[Address(RVA = "0x7100A0", Offset = "0x70F2A0", VA = "0x1807100A0", Slot = "46")]
		protected virtual void OnSleepStart()
		{
		}

		// Token: 0x06002BCE RID: 11214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BCE")]
		[Address(RVA = "0x70AA60", Offset = "0x709C60", VA = "0x18070AA60")]
		public static void GetContractTimings(QuestWindowConfig dealWindow, out int softStartTime, out int hardStartTime, out int endTime)
		{
		}

		// Token: 0x06002BCF RID: 11215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BCF")]
		[Address(RVA = "0x71C780", Offset = "0x71B980", VA = "0x18071C780")]
		private void UpdateDealAttendance()
		{
		}

		// Token: 0x06002BD0 RID: 11216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BD0")]
		[Address(RVA = "0x708570", Offset = "0x707770", VA = "0x180708570")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void ConfigureDealSignal(NetworkConnection conn, int startTime, bool active)
		{
		}

		// Token: 0x06002BD1 RID: 11217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BD1")]
		[Address(RVA = "0x71CD50", Offset = "0x71BF50", VA = "0x18071CD50")]
		private void UpdateOfferExpiry()
		{
		}

		// Token: 0x06002BD2 RID: 11218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BD2")]
		[Address(RVA = "0x70A900", Offset = "0x709B00", VA = "0x18070A900")]
		[Button]
		public void ForceDealOffer()
		{
		}

		// Token: 0x06002BD3 RID: 11219 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002BD3")]
		[Address(RVA = "0x70BAE0", Offset = "0x70ACE0", VA = "0x18070BAE0")]
		private List<ProductDefinition> GetOrderableProducts([Optional] Dealer dealer)
		{
			return null;
		}

		// Token: 0x06002BD4 RID: 11220 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002BD4")]
		[Address(RVA = "0x70B630", Offset = "0x70A830", VA = "0x18070B630")]
		private List<Tuple<ProductDefinition, int>> GetOrderableProductsWithQuantities([Optional] Dealer dealer)
		{
			return null;
		}

		// Token: 0x06002BD5 RID: 11221 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002BD5")]
		[Address(RVA = "0x71B7E0", Offset = "0x71A9E0", VA = "0x18071B7E0")]
		private ContractInfo TryGenerateContract(Dealer dealer)
		{
			return null;
		}

		// Token: 0x06002BD6 RID: 11222 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002BD6")]
		[Address(RVA = "0x70CA50", Offset = "0x70BC50", VA = "0x18070CA50")]
		private ProductDefinition GetWeightedRandomProduct(Dealer dealer, out float appeal, out int orderableQuantity)
		{
			return null;
		}

		// Token: 0x06002BD7 RID: 11223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BD7")]
		[Address(RVA = "0x70F360", Offset = "0x70E560", VA = "0x18070F360", Slot = "47")]
		protected virtual void OnCustomerUnlocked(NPCRelationData.EUnlockType unlockType, bool notify)
		{
		}

		// Token: 0x06002BD8 RID: 11224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BD8")]
		[Address(RVA = "0x719680", Offset = "0x718880", VA = "0x180719680")]
		public void SetHasBeenRecommended()
		{
		}

		// Token: 0x06002BD9 RID: 11225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BD9")]
		[Address(RVA = "0x70EBC0", Offset = "0x70DDC0", VA = "0x18070EBC0", Slot = "48")]
		public virtual void OfferContract(ContractInfo info)
		{
		}

		// Token: 0x06002BDA RID: 11226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BDA")]
		[Address(RVA = "0x717E90", Offset = "0x717090", VA = "0x180717E90")]
		[ObserversRpc]
		private void SetOfferedContract(ContractInfo info, GameDateTime offerTime)
		{
		}

		// Token: 0x06002BDB RID: 11227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BDB")]
		[Address(RVA = "0x70A7F0", Offset = "0x7099F0", VA = "0x18070A7F0", Slot = "49")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public virtual void ExpireOffer()
		{
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BDC")]
		[Address(RVA = "0x7078D0", Offset = "0x706AD0", VA = "0x1807078D0", Slot = "50")]
		public virtual void AssignContract(Contract contract)
		{
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BDD")]
		[Address(RVA = "0x70E740", Offset = "0x70D940", VA = "0x18070E740", Slot = "51")]
		protected virtual void NotifyPlayerOfContract(ContractInfo contract, MessageChain offerMessage, bool canAccept, bool canReject, bool canCounterOffer = true)
		{
		}

		// Token: 0x06002BDE RID: 11230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BDE")]
		[Address(RVA = "0x71A1B0", Offset = "0x7193B0", VA = "0x18071A1B0")]
		[ObserversRpc(RunLocally = true)]
		private void SetUpResponseCallbacks()
		{
		}

		// Token: 0x06002BDF RID: 11231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BDF")]
		[Address(RVA = "0x707610", Offset = "0x706810", VA = "0x180707610", Slot = "52")]
		protected virtual void AcceptContractClicked()
		{
		}

		// Token: 0x06002BE0 RID: 11232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE0")]
		[Address(RVA = "0x709150", Offset = "0x708350", VA = "0x180709150", Slot = "53")]
		protected virtual void CounterOfferClicked()
		{
		}

		// Token: 0x06002BE1 RID: 11233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE1")]
		[Address(RVA = "0x719120", Offset = "0x718320", VA = "0x180719120", Slot = "54")]
		protected virtual void SendCounteroffer(ProductDefinition product, int quantity, float price)
		{
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE2")]
		[Address(RVA = "0x710CD0", Offset = "0x70FED0", VA = "0x180710CD0")]
		[ServerRpc(RequireOwnership = false)]
		private void ProcessCounterOfferServerSide(string productID, int quantity, float price)
		{
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE3")]
		[Address(RVA = "0x719550", Offset = "0x718750", VA = "0x180719550")]
		[ObserversRpc(RunLocally = true)]
		private void SetContractIsCounterOffer()
		{
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE4")]
		[Address(RVA = "0x7104E0", Offset = "0x70F6E0", VA = "0x1807104E0", Slot = "55")]
		protected virtual void PlayerAcceptedContract(EDealWindow window)
		{
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE5")]
		[Address(RVA = "0x718360", Offset = "0x717560", VA = "0x180718360")]
		[ServerRpc(RequireOwnership = false)]
		private void SendContractAccepted(EDealWindow window, bool trackContract)
		{
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002BE6")]
		[Address(RVA = "0x708950", Offset = "0x707B50", VA = "0x180708950")]
		public Contract ContractAccepted(EDealWindow window, bool trackContract, Dealer dealer)
		{
			return null;
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE7")]
		[Address(RVA = "0x712610", Offset = "0x711810", VA = "0x180712610")]
		[ObserversRpc(RunLocally = true)]
		private void ReceiveContractAccepted()
		{
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE8")]
		[Address(RVA = "0x710340", Offset = "0x70F540", VA = "0x180710340", Slot = "56")]
		protected virtual void PlayContractAcceptedReaction()
		{
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x0000DCB0 File Offset: 0x0000BEB0
		[Token(Token = "0x6002BE9")]
		[Address(RVA = "0x709BD0", Offset = "0x708DD0", VA = "0x180709BD0", Slot = "57")]
		protected virtual bool EvaluateCounteroffer(ProductDefinition product, int quantity, float price)
		{
			return default(bool);
		}

		// Token: 0x06002BEA RID: 11242 RVA: 0x0000DCC8 File Offset: 0x0000BEC8
		[Token(Token = "0x6002BEA")]
		[Address(RVA = "0x70C9F0", Offset = "0x70BBF0", VA = "0x18070C9F0")]
		public static float GetValueProposition(ProductDefinition product, float price)
		{
			return 0f;
		}

		// Token: 0x06002BEB RID: 11243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BEB")]
		[Address(RVA = "0x708C90", Offset = "0x707E90", VA = "0x180708C90", Slot = "58")]
		protected virtual void ContractRejected()
		{
		}

		// Token: 0x06002BEC RID: 11244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BEC")]
		[Address(RVA = "0x712750", Offset = "0x711950", VA = "0x180712750")]
		[ObserversRpc(RunLocally = true)]
		private void ReceiveContractRejected()
		{
		}

		// Token: 0x06002BED RID: 11245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BED")]
		[Address(RVA = "0x710410", Offset = "0x70F610", VA = "0x180710410", Slot = "59")]
		protected virtual void PlayContractRejectedReaction()
		{
		}

		// Token: 0x06002BEE RID: 11246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BEE")]
		[Address(RVA = "0x7196A0", Offset = "0x7188A0", VA = "0x1807196A0", Slot = "60")]
		public virtual void SetIsAwaitingDelivery(bool awaiting)
		{
		}

		// Token: 0x06002BEF RID: 11247 RVA: 0x0000DCE0 File Offset: 0x0000BEE0
		[Token(Token = "0x6002BEF")]
		[Address(RVA = "0x70D370", Offset = "0x70C570", VA = "0x18070D370")]
		public bool IsAtDealLocation()
		{
			return default(bool);
		}

		// Token: 0x06002BF0 RID: 11248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BF0")]
		[Address(RVA = "0x71CFB0", Offset = "0x71C1B0", VA = "0x18071CFB0")]
		private void UpdatePotentialCustomerPoI()
		{
		}

		// Token: 0x06002BF1 RID: 11249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BF1")]
		[Address(RVA = "0x719920", Offset = "0x718B20", VA = "0x180719920")]
		public void SetPotentialCustomerPoIEnabled(bool enabled)
		{
		}

		// Token: 0x06002BF2 RID: 11250 RVA: 0x0000DCF8 File Offset: 0x0000BEF8
		[Token(Token = "0x6002BF2")]
		[Address(RVA = "0x71AAF0", Offset = "0x719CF0", VA = "0x18071AAF0", Slot = "61")]
		protected virtual bool ShouldTryGenerateDeal()
		{
			return default(bool);
		}

		// Token: 0x06002BF3 RID: 11251 RVA: 0x0000DD10 File Offset: 0x0000BF10
		[Token(Token = "0x6002BF3")]
		[Address(RVA = "0x70D4F0", Offset = "0x70C6F0", VA = "0x18070D4F0")]
		private bool IsDealTime()
		{
			return default(bool);
		}

		// Token: 0x06002BF4 RID: 11252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BF4")]
		[Address(RVA = "0x70F020", Offset = "0x70E220", VA = "0x18070F020", Slot = "62")]
		public virtual void OfferDealItems(List<ItemInstance> items, bool offeredByPlayer, out bool accepted)
		{
		}

		// Token: 0x06002BF5 RID: 11253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BF5")]
		[Address(RVA = "0x7094A0", Offset = "0x7086A0", VA = "0x1807094A0", Slot = "63")]
		public virtual void CustomerRejectedDeal(bool offeredByPlayer)
		{
		}

		// Token: 0x06002BF6 RID: 11254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BF6")]
		[Address(RVA = "0x711160", Offset = "0x710360", VA = "0x180711160", Slot = "64")]
		public virtual void ProcessHandover(HandoverScreen.EHandoverOutcome outcome, Contract contract, List<ItemInstance> items, bool handoverByPlayer, bool giveBonuses = true)
		{
		}

		// Token: 0x06002BF7 RID: 11255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BF7")]
		[Address(RVA = "0x710FC0", Offset = "0x7101C0", VA = "0x180710FC0")]
		[ServerRpc(RequireOwnership = false)]
		private void ProcessHandoverServerSide(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, bool handoverByPlayer, float totalPayment, ProductList productList, float satisfaction, NetworkObject dealerObject)
		{
		}

		// Token: 0x06002BF8 RID: 11256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BF8")]
		[Address(RVA = "0x710E40", Offset = "0x710040", VA = "0x180710E40")]
		[ObserversRpc]
		private void ProcessHandoverClient(float satisfaction, bool handoverByPlayer, string npcToRecommend, HandoverScreen.EHandoverOutcome outcome)
		{
		}

		// Token: 0x06002BF9 RID: 11257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BF9")]
		[Address(RVA = "0x708E60", Offset = "0x708060", VA = "0x180708E60")]
		public void ContractWellReceived(string npcToRecommend)
		{
		}

		// Token: 0x06002BFA RID: 11258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BFA")]
		[Address(RVA = "0x712F80", Offset = "0x712180", VA = "0x180712F80")]
		private void RecommendDealer(Dealer dealer)
		{
		}

		// Token: 0x06002BFB RID: 11259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BFB")]
		[Address(RVA = "0x713500", Offset = "0x712700", VA = "0x180713500")]
		private void RecommendSupplier(Supplier supplier)
		{
		}

		// Token: 0x06002BFC RID: 11260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BFC")]
		[Address(RVA = "0x7129F0", Offset = "0x711BF0", VA = "0x1807129F0")]
		private void RecommendCustomer(Customer friend)
		{
		}

		// Token: 0x06002BFD RID: 11261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BFD")]
		[Address(RVA = "0x7093C0", Offset = "0x7085C0", VA = "0x1807093C0", Slot = "65")]
		public virtual void CurrentContractEnded(EQuestState outcome)
		{
		}

		// Token: 0x06002BFE RID: 11262 RVA: 0x0000DD28 File Offset: 0x0000BF28
		[Token(Token = "0x6002BFE")]
		[Address(RVA = "0x70A0C0", Offset = "0x7092C0", VA = "0x18070A0C0", Slot = "66")]
		public virtual float EvaluateDelivery(Contract contract, List<ItemInstance> providedItems, out float highestAddiction, out EDrugType mainTypeType, out int matchedProductCount, out float qualityDifference)
		{
			return 0f;
		}

		// Token: 0x06002BFF RID: 11263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BFF")]
		[Address(RVA = "0x707E30", Offset = "0x707030", VA = "0x180707E30")]
		public void CalculateTopWeeklyPurchases(out List<StringIntPair> mostPurchasedProducts, out float totalSpent)
		{
		}

		// Token: 0x06002C00 RID: 11264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C00")]
		[Address(RVA = "0x708430", Offset = "0x707630", VA = "0x180708430")]
		[ServerRpc(RequireOwnership = false)]
		public void ChangeAddiction(float change)
		{
		}

		// Token: 0x06002C01 RID: 11265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C01")]
		[Address(RVA = "0x708850", Offset = "0x707A50", VA = "0x180708850")]
		private void ConsumeProduct(ItemInstance item)
		{
		}

		// Token: 0x06002C02 RID: 11266 RVA: 0x0000DD40 File Offset: 0x0000BF40
		[Token(Token = "0x6002C02")]
		[Address(RVA = "0x71AFB0", Offset = "0x71A1B0", VA = "0x18071AFB0", Slot = "67")]
		protected virtual bool ShowOfferDealOption(bool enabled)
		{
			return default(bool);
		}

		// Token: 0x06002C03 RID: 11267 RVA: 0x0000DD58 File Offset: 0x0000BF58
		[Token(Token = "0x6002C03")]
		[Address(RVA = "0x70F270", Offset = "0x70E470", VA = "0x18070F270", Slot = "68")]
		protected virtual bool OfferDealValid(out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06002C04 RID: 11268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C04")]
		[Address(RVA = "0x70D080", Offset = "0x70C280", VA = "0x18070D080", Slot = "69")]
		protected virtual void InstantDealOffered()
		{
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x0000DD70 File Offset: 0x0000BF70
		[Token(Token = "0x6002C05")]
		[Address(RVA = "0x70ADB0", Offset = "0x709FB0", VA = "0x18070ADB0")]
		public float GetOfferSuccessChance(List<ItemInstance> items, float askingPrice)
		{
			return 0f;
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x0000DD88 File Offset: 0x0000BF88
		[Token(Token = "0x6002C06")]
		[Address(RVA = "0x71A630", Offset = "0x719830", VA = "0x18071A630", Slot = "70")]
		protected virtual bool ShouldTryApproachPlayer()
		{
			return default(bool);
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C07")]
		[Address(RVA = "0x713BF0", Offset = "0x712DF0", VA = "0x180713BF0")]
		[Button]
		public void RequestProduct()
		{
		}

		// Token: 0x06002C08 RID: 11272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C08")]
		[Address(RVA = "0x713C50", Offset = "0x712E50", VA = "0x180713C50")]
		public void RequestProduct(Player target)
		{
		}

		// Token: 0x06002C09 RID: 11273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C09")]
		[Address(RVA = "0x7109C0", Offset = "0x70FBC0", VA = "0x1807109C0")]
		public void PlayerRejectedProductRequest()
		{
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C0A")]
		[Address(RVA = "0x713AE0", Offset = "0x712CE0", VA = "0x180713AE0")]
		[ServerRpc(RequireOwnership = false)]
		public void RejectProductRequestOffer()
		{
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C0B")]
		[Address(RVA = "0x7139C0", Offset = "0x712BC0", VA = "0x1807139C0")]
		[ObserversRpc(RunLocally = true)]
		private void RejectProductRequestOffer_Local()
		{
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C0C")]
		[Address(RVA = "0x628A30", Offset = "0x627C30", VA = "0x180628A30")]
		public void AssignDealer(Dealer dealer)
		{
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002C0D")]
		[Address(RVA = "0x70C9B0", Offset = "0x70BBB0", VA = "0x18070C9B0", Slot = "71")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06002C0E RID: 11278 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002C0E")]
		[Address(RVA = "0x70AB40", Offset = "0x709D40", VA = "0x18070AB40")]
		public CustomerData GetCustomerData()
		{
			return null;
		}

		// Token: 0x06002C0F RID: 11279 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002C0F")]
		[Address(RVA = "0x71D070", Offset = "0x71C270", VA = "0x18071D070", Slot = "72")]
		public virtual List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x06002C10 RID: 11280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C10")]
		[Address(RVA = "0x712890", Offset = "0x711A90", VA = "0x180712890")]
		[TargetRpc]
		private void ReceiveCustomerData(NetworkConnection conn, CustomerData data)
		{
		}

		// Token: 0x06002C11 RID: 11281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C11")]
		[Address(RVA = "0x70DB00", Offset = "0x70CD00", VA = "0x18070DB00", Slot = "73")]
		public virtual void Load(CustomerData data)
		{
		}

		// Token: 0x06002C12 RID: 11282 RVA: 0x0000DDA0 File Offset: 0x0000BFA0
		[Token(Token = "0x6002C12")]
		[Address(RVA = "0x70D8E0", Offset = "0x70CAE0", VA = "0x18070D8E0", Slot = "74")]
		protected virtual bool IsReadyForHandover(bool enabled)
		{
			return default(bool);
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x0000DDB8 File Offset: 0x0000BFB8
		[Token(Token = "0x6002C13")]
		[Address(RVA = "0x70D770", Offset = "0x70C970", VA = "0x18070D770", Slot = "75")]
		protected virtual bool IsHandoverChoiceValid(out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06002C14 RID: 11284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C14")]
		[Address(RVA = "0x70CEB0", Offset = "0x70C0B0", VA = "0x18070CEB0")]
		public void HandoverChosen()
		{
		}

		// Token: 0x06002C15 RID: 11285 RVA: 0x0000DDD0 File Offset: 0x0000BFD0
		[Token(Token = "0x6002C15")]
		[Address(RVA = "0x71AE80", Offset = "0x71A080", VA = "0x18071AE80", Slot = "76")]
		protected virtual bool ShowDirectApproachOption(bool enabled)
		{
			return default(bool);
		}

		// Token: 0x06002C16 RID: 11286 RVA: 0x0000DDE8 File Offset: 0x0000BFE8
		[Token(Token = "0x6002C16")]
		[Address(RVA = "0x70D9D0", Offset = "0x70CBD0", VA = "0x18070D9D0", Slot = "77")]
		public virtual bool IsUnlockable()
		{
			return default(bool);
		}

		// Token: 0x06002C17 RID: 11287 RVA: 0x0000DE00 File Offset: 0x0000C000
		[Token(Token = "0x6002C17")]
		[Address(RVA = "0x718F10", Offset = "0x718110", VA = "0x180718F10", Slot = "78")]
		protected virtual bool SampleOptionValid(out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06002C18 RID: 11288 RVA: 0x0000DE18 File Offset: 0x0000C018
		[Token(Token = "0x6002C18")]
		[Address(RVA = "0x70DA20", Offset = "0x70CC20", VA = "0x18070DA20")]
		public bool KnownAndRecommended()
		{
			return default(bool);
		}

		// Token: 0x06002C19 RID: 11289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C19")]
		[Address(RVA = "0x718E80", Offset = "0x718080", VA = "0x180718E80")]
		public void SampleOffered()
		{
		}

		// Token: 0x06002C1A RID: 11290 RVA: 0x0000DE30 File Offset: 0x0000C030
		[Token(Token = "0x6002C1A")]
		[Address(RVA = "0x70C440", Offset = "0x70B640", VA = "0x18070C440", Slot = "79")]
		protected virtual float GetSampleRequestSuccessChance()
		{
			return 0f;
		}

		// Token: 0x06002C1B RID: 11291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C1B")]
		[Address(RVA = "0x718630", Offset = "0x717830", VA = "0x180718630", Slot = "80")]
		protected virtual void SampleAccepted()
		{
		}

		// Token: 0x06002C1C RID: 11292 RVA: 0x0000DE48 File Offset: 0x0000C048
		[Token(Token = "0x6002C1C")]
		[Address(RVA = "0x70C590", Offset = "0x70B790", VA = "0x18070C590")]
		private float GetSampleSuccess(List<ItemInstance> items, float price)
		{
			return 0f;
		}

		// Token: 0x06002C1D RID: 11293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C1D")]
		[Address(RVA = "0x712250", Offset = "0x711450", VA = "0x180712250")]
		private void ProcessSample(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float price)
		{
		}

		// Token: 0x06002C1E RID: 11294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C1E")]
		[Address(RVA = "0x712120", Offset = "0x711320", VA = "0x180712120")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void ProcessSampleServerSide(List<ItemInstance> items)
		{
		}

		// Token: 0x06002C1F RID: 11295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C1F")]
		[Address(RVA = "0x712000", Offset = "0x711200", VA = "0x180712000")]
		[ObserversRpc(RunLocally = true)]
		private void ProcessSampleClient()
		{
		}

		// Token: 0x06002C20 RID: 11296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C20")]
		[Address(RVA = "0x7187D0", Offset = "0x7179D0", VA = "0x1807187D0")]
		private void SampleConsumed()
		{
		}

		// Token: 0x06002C21 RID: 11297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C21")]
		[Address(RVA = "0x709AB0", Offset = "0x708CB0", VA = "0x180709AB0")]
		private void EndWait()
		{
		}

		// Token: 0x06002C22 RID: 11298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C22")]
		[Address(RVA = "0x709880", Offset = "0x708A80", VA = "0x180709880", Slot = "81")]
		protected virtual void DirectApproachRejected()
		{
		}

		// Token: 0x06002C23 RID: 11299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C23")]
		[Address(RVA = "0x717C50", Offset = "0x716E50", VA = "0x180717C50")]
		[ObserversRpc]
		private void SampleWasSufficient()
		{
		}

		// Token: 0x06002C24 RID: 11300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C24")]
		[Address(RVA = "0x717B30", Offset = "0x716D30", VA = "0x180717B30")]
		[ObserversRpc]
		private void SampleWasInsufficient()
		{
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x0000DE60 File Offset: 0x0000C060
		[Token(Token = "0x6002C25")]
		[Address(RVA = "0x70BE10", Offset = "0x70B010", VA = "0x18070BE10")]
		public float GetProductEnjoyment(ProductDefinition product, EQuality quality)
		{
			return 0f;
		}

		// Token: 0x06002C26 RID: 11302 RVA: 0x0000DE78 File Offset: 0x0000C078
		[Token(Token = "0x6002C26")]
		[Address(RVA = "0x70C170", Offset = "0x70B370", VA = "0x18070C170")]
		public float GetProductEnjoyment(ProductDefinition product)
		{
			return 0f;
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002C27")]
		[Address(RVA = "0x70BC30", Offset = "0x70AE30", VA = "0x18070BC30")]
		public List<EDrugType> GetOrderedDrugTypes()
		{
			return null;
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C28")]
		[Address(RVA = "0x707770", Offset = "0x706970", VA = "0x180707770")]
		[ServerRpc(RequireOwnership = false)]
		public void AdjustAffinity(EDrugType drugType, float change)
		{
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C29")]
		[Address(RVA = "0x7079F0", Offset = "0x706BF0", VA = "0x1807079F0")]
		[Button]
		public void AutocreateCustomerSettings()
		{
		}

		// Token: 0x06002C2A RID: 11306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C2A")]
		[Address(RVA = "0x71D3A0", Offset = "0x71C5A0", VA = "0x18071D3A0")]
		public Customer()
		{
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C2E")]
		[Address(RVA = "0x71C590", Offset = "0x71B790", VA = "0x18071C590")]
		[CompilerGenerated]
		private void <Start>g__RegisterLoadEvent|141_0()
		{
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C2F")]
		[Address(RVA = "0x71C010", Offset = "0x71B210", VA = "0x18071C010")]
		[CompilerGenerated]
		private void <InstantDealOffered>g__HandoverClosed|206_0(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float askingPrice)
		{
		}

		// Token: 0x06002C32 RID: 11314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C32")]
		[Address(RVA = "0x70DF80", Offset = "0x70D180", VA = "0x18070DF80", Slot = "82")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C33")]
		[Address(RVA = "0x70DF10", Offset = "0x70D110", VA = "0x18070DF10", Slot = "83")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002C34 RID: 11316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C34")]
		[Address(RVA = "0x70DED0", Offset = "0x70D0D0", VA = "0x18070DED0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06002C35 RID: 11317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C35")]
		[Address(RVA = "0x717540", Offset = "0x716740", VA = "0x180717540")]
		private void RpcWriter___Observers_ConfigureDealSignal_338960014(NetworkConnection conn, int startTime, bool active)
		{
		}

		// Token: 0x06002C36 RID: 11318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C36")]
		[Address(RVA = "0x713F00", Offset = "0x713100", VA = "0x180713F00")]
		private void RpcLogic___ConfigureDealSignal_338960014(NetworkConnection conn, int startTime, bool active)
		{
		}

		// Token: 0x06002C37 RID: 11319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C37")]
		[Address(RVA = "0x7168B0", Offset = "0x715AB0", VA = "0x1807168B0")]
		private void RpcReader___Observers_ConfigureDealSignal_338960014(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002C38 RID: 11320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C38")]
		[Address(RVA = "0x7184C0", Offset = "0x7176C0", VA = "0x1807184C0")]
		private void RpcWriter___Target_ConfigureDealSignal_338960014(NetworkConnection conn, int startTime, bool active)
		{
		}

		// Token: 0x06002C39 RID: 11321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C39")]
		[Address(RVA = "0x7173F0", Offset = "0x7165F0", VA = "0x1807173F0")]
		private void RpcReader___Target_ConfigureDealSignal_338960014(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002C3A RID: 11322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C3A")]
		[Address(RVA = "0x717E90", Offset = "0x717090", VA = "0x180717E90")]
		private void RpcWriter___Observers_SetOfferedContract_4277245194(ContractInfo info, GameDateTime offerTime)
		{
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C3B")]
		[Address(RVA = "0x716480", Offset = "0x715680", VA = "0x180716480")]
		private void RpcLogic___SetOfferedContract_4277245194(ContractInfo info, GameDateTime offerTime)
		{
		}

		// Token: 0x06002C3C RID: 11324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C3C")]
		[Address(RVA = "0x716DC0", Offset = "0x715FC0", VA = "0x180716DC0")]
		private void RpcReader___Observers_SetOfferedContract_4277245194(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C3D")]
		[Address(RVA = "0x718120", Offset = "0x717320", VA = "0x180718120")]
		private void RpcWriter___Server_ExpireOffer_2166136261()
		{
		}

		// Token: 0x06002C3E RID: 11326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C3E")]
		[Address(RVA = "0x713F70", Offset = "0x713170", VA = "0x180713F70", Slot = "84")]
		public virtual void RpcLogic___ExpireOffer_2166136261()
		{
		}

		// Token: 0x06002C3F RID: 11327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C3F")]
		[Address(RVA = "0x717080", Offset = "0x716280", VA = "0x180717080")]
		private void RpcReader___Server_ExpireOffer_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002C40 RID: 11328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C40")]
		[Address(RVA = "0x718000", Offset = "0x717200", VA = "0x180718000")]
		private void RpcWriter___Observers_SetUpResponseCallbacks_2166136261()
		{
		}

		// Token: 0x06002C41 RID: 11329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C41")]
		[Address(RVA = "0x7164C0", Offset = "0x7156C0", VA = "0x1807164C0")]
		private void RpcLogic___SetUpResponseCallbacks_2166136261()
		{
		}

		// Token: 0x06002C42 RID: 11330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C42")]
		[Address(RVA = "0x716E40", Offset = "0x716040", VA = "0x180716E40")]
		private void RpcReader___Observers_SetUpResponseCallbacks_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002C43 RID: 11331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C43")]
		[Address(RVA = "0x710CD0", Offset = "0x70FED0", VA = "0x180710CD0")]
		private void RpcWriter___Server_ProcessCounterOfferServerSide_900355577(string productID, int quantity, float price)
		{
		}

		// Token: 0x06002C44 RID: 11332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C44")]
		[Address(RVA = "0x714070", Offset = "0x713270", VA = "0x180714070")]
		private void RpcLogic___ProcessCounterOfferServerSide_900355577(string productID, int quantity, float price)
		{
		}

		// Token: 0x06002C45 RID: 11333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C45")]
		[Address(RVA = "0x7170D0", Offset = "0x7162D0", VA = "0x1807170D0")]
		private void RpcReader___Server_ProcessCounterOfferServerSide_900355577(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002C46 RID: 11334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C46")]
		[Address(RVA = "0x717D70", Offset = "0x716F70", VA = "0x180717D70")]
		private void RpcWriter___Observers_SetContractIsCounterOffer_2166136261()
		{
		}

		// Token: 0x06002C47 RID: 11335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C47")]
		[Address(RVA = "0x716460", Offset = "0x715660", VA = "0x180716460")]
		private void RpcLogic___SetContractIsCounterOffer_2166136261()
		{
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C48")]
		[Address(RVA = "0x716D80", Offset = "0x715F80", VA = "0x180716D80")]
		private void RpcReader___Observers_SetContractIsCounterOffer_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002C49 RID: 11337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C49")]
		[Address(RVA = "0x718360", Offset = "0x717560", VA = "0x180718360")]
		private void RpcWriter___Server_SendContractAccepted_507093020(EDealWindow window, bool trackContract)
		{
		}

		// Token: 0x06002C4A RID: 11338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C4A")]
		[Address(RVA = "0x716440", Offset = "0x715640", VA = "0x180716440")]
		private void RpcLogic___SendContractAccepted_507093020(EDealWindow window, bool trackContract)
		{
		}

		// Token: 0x06002C4B RID: 11339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C4B")]
		[Address(RVA = "0x717350", Offset = "0x716550", VA = "0x180717350")]
		private void RpcReader___Server_SendContractAccepted_507093020(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002C4C RID: 11340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C4C")]
		[Address(RVA = "0x7177D0", Offset = "0x7169D0", VA = "0x1807177D0")]
		private void RpcWriter___Observers_ReceiveContractAccepted_2166136261()
		{
		}

		// Token: 0x06002C4D RID: 11341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C4D")]
		[Address(RVA = "0x715BE0", Offset = "0x714DE0", VA = "0x180715BE0")]
		private void RpcLogic___ReceiveContractAccepted_2166136261()
		{
		}

		// Token: 0x06002C4E RID: 11342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C4E")]
		[Address(RVA = "0x716B20", Offset = "0x715D20", VA = "0x180716B20")]
		private void RpcReader___Observers_ReceiveContractAccepted_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002C4F RID: 11343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C4F")]
		[Address(RVA = "0x7178F0", Offset = "0x716AF0", VA = "0x1807178F0")]
		private void RpcWriter___Observers_ReceiveContractRejected_2166136261()
		{
		}

		// Token: 0x06002C50 RID: 11344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C50")]
		[Address(RVA = "0x715BE0", Offset = "0x714DE0", VA = "0x180715BE0")]
		private void RpcLogic___ReceiveContractRejected_2166136261()
		{
		}

		// Token: 0x06002C51 RID: 11345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C51")]
		[Address(RVA = "0x716B20", Offset = "0x715D20", VA = "0x180716B20")]
		private void RpcReader___Observers_ReceiveContractRejected_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002C52 RID: 11346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C52")]
		[Address(RVA = "0x710FC0", Offset = "0x7101C0", VA = "0x180710FC0")]
		private void RpcWriter___Server_ProcessHandoverServerSide_3760244802(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, bool handoverByPlayer, float totalPayment, ProductList productList, float satisfaction, NetworkObject dealerObject)
		{
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C53")]
		[Address(RVA = "0x7147A0", Offset = "0x7139A0", VA = "0x1807147A0")]
		private void RpcLogic___ProcessHandoverServerSide_3760244802(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, bool handoverByPlayer, float totalPayment, ProductList productList, float satisfaction, NetworkObject dealerObject)
		{
		}

		// Token: 0x06002C54 RID: 11348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C54")]
		[Address(RVA = "0x717170", Offset = "0x716370", VA = "0x180717170")]
		private void RpcReader___Server_ProcessHandoverServerSide_3760244802(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002C55 RID: 11349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C55")]
		[Address(RVA = "0x710E40", Offset = "0x710040", VA = "0x180710E40")]
		private void RpcWriter___Observers_ProcessHandoverClient_2441224929(float satisfaction, bool handoverByPlayer, string npcToRecommend, HandoverScreen.EHandoverOutcome outcome)
		{
		}

		// Token: 0x06002C56 RID: 11350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C56")]
		[Address(RVA = "0x7146C0", Offset = "0x7138C0", VA = "0x1807146C0")]
		private void RpcLogic___ProcessHandoverClient_2441224929(float satisfaction, bool handoverByPlayer, string npcToRecommend, HandoverScreen.EHandoverOutcome outcome)
		{
		}

		// Token: 0x06002C57 RID: 11351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C57")]
		[Address(RVA = "0x716970", Offset = "0x715B70", VA = "0x180716970")]
		private void RpcReader___Observers_ProcessHandoverClient_2441224929(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C58")]
		[Address(RVA = "0x708430", Offset = "0x707630", VA = "0x180708430")]
		private void RpcWriter___Server_ChangeAddiction_431000436(float change)
		{
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C59")]
		[Address(RVA = "0x713EA0", Offset = "0x7130A0", VA = "0x180713EA0")]
		public void RpcLogic___ChangeAddiction_431000436(float change)
		{
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C5A")]
		[Address(RVA = "0x716FF0", Offset = "0x7161F0", VA = "0x180716FF0")]
		private void RpcReader___Server_ChangeAddiction_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002C5B RID: 11355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C5B")]
		[Address(RVA = "0x713AE0", Offset = "0x712CE0", VA = "0x180713AE0")]
		private void RpcWriter___Server_RejectProductRequestOffer_2166136261()
		{
		}

		// Token: 0x06002C5C RID: 11356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C5C")]
		[Address(RVA = "0x715C20", Offset = "0x714E20", VA = "0x180715C20")]
		public void RpcLogic___RejectProductRequestOffer_2166136261()
		{
		}

		// Token: 0x06002C5D RID: 11357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C5D")]
		[Address(RVA = "0x717320", Offset = "0x716520", VA = "0x180717320")]
		private void RpcReader___Server_RejectProductRequestOffer_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C5E")]
		[Address(RVA = "0x717A10", Offset = "0x716C10", VA = "0x180717A10")]
		private void RpcWriter___Observers_RejectProductRequestOffer_Local_2166136261()
		{
		}

		// Token: 0x06002C5F RID: 11359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C5F")]
		[Address(RVA = "0x715F30", Offset = "0x715130", VA = "0x180715F30")]
		private void RpcLogic___RejectProductRequestOffer_Local_2166136261()
		{
		}

		// Token: 0x06002C60 RID: 11360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C60")]
		[Address(RVA = "0x716B70", Offset = "0x715D70", VA = "0x180716B70")]
		private void RpcReader___Observers_RejectProductRequestOffer_Local_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C61")]
		[Address(RVA = "0x712890", Offset = "0x711A90", VA = "0x180712890")]
		private void RpcWriter___Target_ReceiveCustomerData_2280244125(NetworkConnection conn, CustomerData data)
		{
		}

		// Token: 0x06002C62 RID: 11362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C62")]
		[Address(RVA = "0x715C00", Offset = "0x714E00", VA = "0x180715C00")]
		private void RpcLogic___ReceiveCustomerData_2280244125(NetworkConnection conn, CustomerData data)
		{
		}

		// Token: 0x06002C63 RID: 11363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C63")]
		[Address(RVA = "0x7174E0", Offset = "0x7166E0", VA = "0x1807174E0")]
		private void RpcReader___Target_ReceiveCustomerData_2280244125(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C64")]
		[Address(RVA = "0x718230", Offset = "0x717430", VA = "0x180718230")]
		private void RpcWriter___Server_ProcessSampleServerSide_3704012609(List<ItemInstance> items)
		{
		}

		// Token: 0x06002C65 RID: 11365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C65")]
		[Address(RVA = "0x715900", Offset = "0x714B00", VA = "0x180715900")]
		private void RpcLogic___ProcessSampleServerSide_3704012609(List<ItemInstance> items)
		{
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C66")]
		[Address(RVA = "0x7172B0", Offset = "0x7164B0", VA = "0x1807172B0")]
		private void RpcReader___Server_ProcessSampleServerSide_3704012609(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002C67 RID: 11367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C67")]
		[Address(RVA = "0x7176B0", Offset = "0x7168B0", VA = "0x1807176B0")]
		private void RpcWriter___Observers_ProcessSampleClient_2166136261()
		{
		}

		// Token: 0x06002C68 RID: 11368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C68")]
		[Address(RVA = "0x7157D0", Offset = "0x7149D0", VA = "0x1807157D0")]
		private void RpcLogic___ProcessSampleClient_2166136261()
		{
		}

		// Token: 0x06002C69 RID: 11369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C69")]
		[Address(RVA = "0x716AE0", Offset = "0x715CE0", VA = "0x180716AE0")]
		private void RpcReader___Observers_ProcessSampleClient_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002C6A RID: 11370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C6A")]
		[Address(RVA = "0x717C50", Offset = "0x716E50", VA = "0x180717C50")]
		private void RpcWriter___Observers_SampleWasSufficient_2166136261()
		{
		}

		// Token: 0x06002C6B RID: 11371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C6B")]
		[Address(RVA = "0x7162B0", Offset = "0x7154B0", VA = "0x1807162B0")]
		private void RpcLogic___SampleWasSufficient_2166136261()
		{
		}

		// Token: 0x06002C6C RID: 11372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C6C")]
		[Address(RVA = "0x716BE0", Offset = "0x715DE0", VA = "0x180716BE0")]
		private void RpcReader___Observers_SampleWasSufficient_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002C6D RID: 11373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C6D")]
		[Address(RVA = "0x717B30", Offset = "0x716D30", VA = "0x180717B30")]
		private void RpcWriter___Observers_SampleWasInsufficient_2166136261()
		{
		}

		// Token: 0x06002C6E RID: 11374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C6E")]
		[Address(RVA = "0x716060", Offset = "0x715260", VA = "0x180716060")]
		private void RpcLogic___SampleWasInsufficient_2166136261()
		{
		}

		// Token: 0x06002C6F RID: 11375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C6F")]
		[Address(RVA = "0x716BB0", Offset = "0x715DB0", VA = "0x180716BB0")]
		private void RpcReader___Observers_SampleWasInsufficient_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002C70 RID: 11376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C70")]
		[Address(RVA = "0x707770", Offset = "0x706970", VA = "0x180707770")]
		private void RpcWriter___Server_AdjustAffinity_3036964899(EDrugType drugType, float change)
		{
		}

		// Token: 0x06002C71 RID: 11377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C71")]
		[Address(RVA = "0x713D70", Offset = "0x712F70", VA = "0x180713D70")]
		public void RpcLogic___AdjustAffinity_3036964899(EDrugType drugType, float change)
		{
		}

		// Token: 0x06002C72 RID: 11378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C72")]
		[Address(RVA = "0x716E80", Offset = "0x716080", VA = "0x180716E80")]
		private void RpcReader___Server_AdjustAffinity_3036964899(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06002C73 RID: 11379 RVA: 0x0000DEA8 File Offset: 0x0000C0A8
		// (set) Token: 0x06002C74 RID: 11380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000792")]
		public float SyncAccessor_<CurrentAddiction>k__BackingField
		{
			[Token(Token = "0x6002C73")]
			[Address(RVA = "0x5C0F90", Offset = "0x5C0190", VA = "0x1805C0F90")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002C74")]
			[Address(RVA = "0x71D7C0", Offset = "0x71C9C0", VA = "0x18071D7C0")]
			set
			{
			}
		}

		// Token: 0x06002C75 RID: 11381 RVA: 0x0000DEC0 File Offset: 0x0000C0C0
		[Token(Token = "0x6002C75")]
		[Address(RVA = "0x712470", Offset = "0x711670", VA = "0x180712470", Slot = "85")]
		public virtual bool ReadSyncVar___ScheduleOne.Economy.Customer(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06002C76 RID: 11382 RVA: 0x0000DED8 File Offset: 0x0000C0D8
		// (set) Token: 0x06002C77 RID: 11383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000793")]
		public bool SyncAccessor_<HasBeenRecommended>k__BackingField
		{
			[Token(Token = "0x6002C76")]
			[Address(RVA = "0x71D4F0", Offset = "0x71C6F0", VA = "0x18071D4F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002C77")]
			[Address(RVA = "0x71D880", Offset = "0x71CA80", VA = "0x18071D880")]
			set
			{
			}
		}

		// Token: 0x06002C78 RID: 11384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C78")]
		[Address(RVA = "0x707A90", Offset = "0x706C90", VA = "0x180707A90", Slot = "86")]
		protected virtual void Awake_UserLogic_ScheduleOne.Economy.Customer_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040020D8 RID: 8408
		[Token(Token = "0x40020D8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<Customer> onCustomerUnlocked;

		// Token: 0x040020D9 RID: 8409
		[Token(Token = "0x40020D9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static List<Customer> LockedCustomers;

		// Token: 0x040020DA RID: 8410
		[Token(Token = "0x40020DA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static List<Customer> UnlockedCustomers;

		// Token: 0x040020DB RID: 8411
		[Token(Token = "0x40020DB")]
		public const int QualityTierTolerance = 2;

		// Token: 0x040020DC RID: 8412
		[Token(Token = "0x40020DC")]
		public const int MaxOrderQuantityPerProduct = 1000;

		// Token: 0x040020DD RID: 8413
		[Token(Token = "0x40020DD")]
		public const float AFFINITY_MAX_EFFECT = 0.3f;

		// Token: 0x040020DE RID: 8414
		[Token(Token = "0x40020DE")]
		public const float PROPERTY_MAX_EFFECT = 0.4f;

		// Token: 0x040020DF RID: 8415
		[Token(Token = "0x40020DF")]
		public const float QUALITY_MAX_EFFECT = 0.3f;

		// Token: 0x040020E0 RID: 8416
		[Token(Token = "0x40020E0")]
		public const float DEAL_REJECTED_RELATIONSHIP_CHANGE = -0.5f;

		// Token: 0x040020E1 RID: 8417
		[Token(Token = "0x40020E1")]
		public const int ATTACK_DEAL_COOLDOWN = 48;

		// Token: 0x040020E2 RID: 8418
		[Token(Token = "0x40020E2")]
		public const float RELATIONSHIP_THRESHOLD_TO_GIVE_DEAL_TO_CARTEL = 0.25f;

		// Token: 0x040020E3 RID: 8419
		[Token(Token = "0x40020E3")]
		public const float CUSTOMER_UNLOCKED_CARTEL_INFLUENCE_CHANGE = -0.075f;

		// Token: 0x040020E4 RID: 8420
		[Token(Token = "0x40020E4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public bool DEBUG;

		// Token: 0x040020E5 RID: 8421
		[Token(Token = "0x40020E5")]
		public const float APPROACH_MIN_ADDICTION = 0.33f;

		// Token: 0x040020E6 RID: 8422
		[Token(Token = "0x40020E6")]
		public const float APPROACH_CHANCE_PER_DAY_MAX = 0.5f;

		// Token: 0x040020E7 RID: 8423
		[Token(Token = "0x40020E7")]
		public const float APPROACH_MIN_COOLDOWN = 2160f;

		// Token: 0x040020E8 RID: 8424
		[Token(Token = "0x40020E8")]
		public const float APPROACH_MAX_COOLDOWN = 4320f;

		// Token: 0x040020E9 RID: 8425
		[Token(Token = "0x40020E9")]
		public const int DEAL_COOLDOWN = 600;

		// Token: 0x040020EA RID: 8426
		[Token(Token = "0x40020EA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] PlayerAcceptMessages;

		// Token: 0x040020EB RID: 8427
		[Token(Token = "0x40020EB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] PlayerRejectMessages;

		// Token: 0x040020EC RID: 8428
		[Token(Token = "0x40020EC")]
		public const int DEAL_ATTENDANCE_TOLERANCE = 10;

		// Token: 0x040020ED RID: 8429
		[Token(Token = "0x40020ED")]
		public const int MIN_TRAVEL_TIME = 15;

		// Token: 0x040020EE RID: 8430
		[Token(Token = "0x40020EE")]
		public const int MAX_TRAVEL_TIME = 360;

		// Token: 0x040020EF RID: 8431
		[Token(Token = "0x40020EF")]
		public const int OFFER_EXPIRY_TIME_MINS = 600;

		// Token: 0x040020F0 RID: 8432
		[Token(Token = "0x40020F0")]
		public const float MIN_ORDER_APPEAL = 0.05f;

		// Token: 0x040020F1 RID: 8433
		[Token(Token = "0x40020F1")]
		public const float ADDICTION_DRAIN_PER_DAY = 0.0625f;

		// Token: 0x040020F2 RID: 8434
		[Token(Token = "0x40020F2")]
		public const bool SAMPLE_REQUIRES_RECOMMENDATION = false;

		// Token: 0x040020F3 RID: 8435
		[Token(Token = "0x40020F3")]
		public const float MIN_NORMALIZED_RELATIONSHIP_FOR_RECOMMENDATION = 0.5f;

		// Token: 0x040020F4 RID: 8436
		[Token(Token = "0x40020F4")]
		public const float RELATIONSHIP_FOR_GUARANTEED_DEALER_RECOMMENDATION = 0.6f;

		// Token: 0x040020F5 RID: 8437
		[Token(Token = "0x40020F5")]
		public const float RELATIONSHIP_FOR_GUARANTEED_SUPPLIER_RECOMMENDATION = 0.6f;

		// Token: 0x040020F7 RID: 8439
		[Token(Token = "0x40020F7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private ContractInfo offeredContractInfo;

		// Token: 0x04002105 RID: 8453
		[Token(Token = "0x4002105")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public NPCSignal_WaitForDelivery DealSignal;

		// Token: 0x04002106 RID: 8454
		[Token(Token = "0x4002106")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[Header("Settings")]
		public bool AvailableInDemo;

		// Token: 0x04002107 RID: 8455
		[Token(Token = "0x4002107")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[SerializeField]
		protected CustomerData customerData;

		// Token: 0x04002108 RID: 8456
		[Token(Token = "0x4002108")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public DeliveryLocation DefaultDeliveryLocation;

		// Token: 0x04002109 RID: 8457
		[Token(Token = "0x4002109")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		[Header("Events")]
		public UnityEvent onUnlocked;

		// Token: 0x0400210A RID: 8458
		[Token(Token = "0x400210A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public UnityEvent onDealCompleted;

		// Token: 0x0400210B RID: 8459
		[Token(Token = "0x400210B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public UnityEvent<Contract> onContractAssigned;

		// Token: 0x0400210C RID: 8460
		[Token(Token = "0x400210C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private bool awaitingSample;

		// Token: 0x0400210D RID: 8461
		[Token(Token = "0x400210D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private DialogueController.DialogueChoice sampleChoice;

		// Token: 0x0400210E RID: 8462
		[Token(Token = "0x400210E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private DialogueController.DialogueChoice completeContractChoice;

		// Token: 0x0400210F RID: 8463
		[Token(Token = "0x400210F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private DialogueController.DialogueChoice offerDealChoice;

		// Token: 0x04002110 RID: 8464
		[Token(Token = "0x4002110")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private DialogueController.GreetingOverride awaitingDealGreeting;

		// Token: 0x04002111 RID: 8465
		[Token(Token = "0x4002111")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private int minsSinceUnlocked;

		// Token: 0x04002112 RID: 8466
		[Token(Token = "0x4002112")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		private bool sampleOfferedToday;

		// Token: 0x04002114 RID: 8468
		[Token(Token = "0x4002114")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private CustomerAffinityData currentAffinityData;

		// Token: 0x04002115 RID: 8469
		[Token(Token = "0x4002115")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private bool pendingInstantDeal;

		// Token: 0x04002119 RID: 8473
		[Token(Token = "0x4002119")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private ProductItemInstance consumedSample;

		// Token: 0x0400211A RID: 8474
		[Token(Token = "0x400211A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		public SyncVar<float> syncVar___<CurrentAddiction>k__BackingField;

		// Token: 0x0400211B RID: 8475
		[Token(Token = "0x400211B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		public SyncVar<bool> syncVar___<HasBeenRecommended>k__BackingField;

		// Token: 0x0400211C RID: 8476
		[Token(Token = "0x400211C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private bool NetworkInitialize___EarlyScheduleOne.Economy.CustomerAssembly-CSharp.dll_Excuted;

		// Token: 0x0400211D RID: 8477
		[Token(Token = "0x400211D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x229")]
		private bool NetworkInitialize__LateScheduleOne.Economy.CustomerAssembly-CSharp.dll_Excuted;

		// Token: 0x02000696 RID: 1686
		[Token(Token = "0x2000696")]
		[Serializable]
		public class ScheduleGroupPair
		{
			// Token: 0x06002C79 RID: 11385 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C79")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public ScheduleGroupPair()
			{
			}

			// Token: 0x0400211E RID: 8478
			[Token(Token = "0x400211E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject NormalScheduleGroup;

			// Token: 0x0400211F RID: 8479
			[Token(Token = "0x400211F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject CurfewScheduleGroup;
		}

		// Token: 0x02000697 RID: 1687
		[Token(Token = "0x2000697")]
		[Serializable]
		public class CustomerPreference
		{
			// Token: 0x06002C7A RID: 11386 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C7A")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public CustomerPreference()
			{
			}

			// Token: 0x04002120 RID: 8480
			[Token(Token = "0x4002120")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EDrugType DrugType;

			// Token: 0x04002121 RID: 8481
			[Token(Token = "0x4002121")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Header("Optionally, a specific product")]
			public ProductDefinition Definition;

			// Token: 0x04002122 RID: 8482
			[Token(Token = "0x4002122")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EQuality MinimumQuality;
		}

		// Token: 0x02000698 RID: 1688
		[Token(Token = "0x2000698")]
		[Serializable]
		public class ProductPurchaseRecord
		{
			// Token: 0x06002C7B RID: 11387 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C7B")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public ProductPurchaseRecord()
			{
			}

			// Token: 0x04002123 RID: 8483
			[Token(Token = "0x4002123")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string ProductID;

			// Token: 0x04002124 RID: 8484
			[Token(Token = "0x4002124")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int Quantity;

			// Token: 0x04002125 RID: 8485
			[Token(Token = "0x4002125")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float TotalSpent;
		}

		// Token: 0x02000699 RID: 1689
		[Token(Token = "0x2000699")]
		public enum ESampleFeedback
		{
			// Token: 0x04002127 RID: 8487
			[Token(Token = "0x4002127")]
			WrongProduct,
			// Token: 0x04002128 RID: 8488
			[Token(Token = "0x4002128")]
			WrongQuality,
			// Token: 0x04002129 RID: 8489
			[Token(Token = "0x4002129")]
			Correct
		}
	}
}
