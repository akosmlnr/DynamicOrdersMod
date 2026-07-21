using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Core;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using ScheduleOne.GameTime;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.Quests
{
	// Token: 0x02000331 RID: 817
	[Token(Token = "0x2000331")]
	public class QuestManager : NetworkSingleton<QuestManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x060013FF RID: 5119 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700040F")]
		public string SaveFolderName
		{
			[Token(Token = "0x60013FF")]
			[Address(RVA = "0x588820", Offset = "0x587A20", VA = "0x180588820", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06001400 RID: 5120 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000410")]
		public string SaveFileName
		{
			[Token(Token = "0x6001400")]
			[Address(RVA = "0x5887F0", Offset = "0x5879F0", VA = "0x1805887F0", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06001401 RID: 5121 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000411")]
		public Loader Loader
		{
			[Token(Token = "0x6001401")]
			[Address(RVA = "0x5887C0", Offset = "0x5879C0", VA = "0x1805887C0", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06001402 RID: 5122 RVA: 0x00008EC8 File Offset: 0x000070C8
		[Token(Token = "0x17000412")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6001402")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001403 RID: 5123 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001404 RID: 5124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000413")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6001403")]
			[Address(RVA = "0x5887D0", Offset = "0x5879D0", VA = "0x1805887D0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001404")]
			[Address(RVA = "0x588860", Offset = "0x587A60", VA = "0x180588860", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06001405 RID: 5125 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001406 RID: 5126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000414")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6001405")]
			[Address(RVA = "0x5887E0", Offset = "0x5879E0", VA = "0x1805887E0", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001406")]
			[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001407 RID: 5127 RVA: 0x00008EE0 File Offset: 0x000070E0
		// (set) Token: 0x06001408 RID: 5128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000415")]
		public bool HasChanged
		{
			[Token(Token = "0x6001407")]
			[Address(RVA = "0x5887A0", Offset = "0x5879A0", VA = "0x1805887A0", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001408")]
			[Address(RVA = "0x588850", Offset = "0x587A50", VA = "0x180588850", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001409 RID: 5129 RVA: 0x00008EF8 File Offset: 0x000070F8
		[Token(Token = "0x17000416")]
		public int LoadOrder
		{
			[Token(Token = "0x6001409")]
			[Address(RVA = "0x5887B0", Offset = "0x5879B0", VA = "0x1805887B0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600140A")]
		[Address(RVA = "0x582690", Offset = "0x581890", VA = "0x180582690", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600140B")]
		[Address(RVA = "0x5845C0", Offset = "0x5837C0", VA = "0x1805845C0", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600140C")]
		[Address(RVA = "0x588500", Offset = "0x587700", VA = "0x180588500", Slot = "19")]
		protected override void Start()
		{
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600140D")]
		[Address(RVA = "0x584B00", Offset = "0x583D00", VA = "0x180584B00", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600140E")]
		[Address(RVA = "0x588570", Offset = "0x587770", VA = "0x180588570")]
		private void UpdateVariables()
		{
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600140F")]
		[Address(RVA = "0x582850", Offset = "0x581A50", VA = "0x180582850")]
		public Contract ContractAccepted(Customer customer, ContractInfo contractData, bool track, string guid, Dealer dealer)
		{
			return null;
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001410")]
		[Address(RVA = "0x583370", Offset = "0x582570", VA = "0x180583370")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void CreateContract_Networked(NetworkConnection conn, string title, string description, string guid, bool tracked, NetworkObject customer, ContractInfo contractData, GameDateTime expiry, GameDateTime acceptTime, [Optional] NetworkObject dealerObj)
		{
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001411")]
		[Address(RVA = "0x583010", Offset = "0x582210", VA = "0x180583010")]
		public Contract CreateContract_Local(string title, string description, QuestEntryData[] entries, string guid, bool tracked, Customer customer, float payment, ProductList products, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, bool expires, GameDateTime expiry, int pickupScheduleIndex, GameDateTime acceptTime, [Optional] Dealer dealer)
		{
			return null;
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001412")]
		[Address(RVA = "0x5880B0", Offset = "0x5872B0", VA = "0x1805880B0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendQuestAction(string guid, QuestManager.EQuestAction action)
		{
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001413")]
		[Address(RVA = "0x584E60", Offset = "0x584060", VA = "0x180584E60")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void ReceiveQuestAction(NetworkConnection conn, string guid, QuestManager.EQuestAction action)
		{
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001414")]
		[Address(RVA = "0x5883A0", Offset = "0x5875A0", VA = "0x1805883A0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendQuestState(string guid, EQuestState state)
		{
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001415")]
		[Address(RVA = "0x5853E0", Offset = "0x5845E0", VA = "0x1805853E0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void ReceiveQuestState(NetworkConnection conn, string guid, EQuestState state)
		{
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001416")]
		[Address(RVA = "0x587F50", Offset = "0x587150", VA = "0x180587F50")]
		[TargetRpc]
		private void SetQuestTracked(NetworkConnection conn, string guid, bool tracked)
		{
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001417")]
		[Address(RVA = "0x588210", Offset = "0x587410", VA = "0x180588210")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendQuestEntryState(string guid, int entryIndex, EQuestState state)
		{
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001418")]
		[Address(RVA = "0x585100", Offset = "0x584300", VA = "0x180585100")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void ReceiveQuestEntryState(NetworkConnection conn, string guid, int entryIndex, EQuestState state)
		{
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001419")]
		[Address(RVA = "0x584CA0", Offset = "0x583EA0", VA = "0x180584CA0")]
		[Button]
		public void PrintQuestStates()
		{
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600141A")]
		[Address(RVA = "0x583CA0", Offset = "0x582EA0", VA = "0x180583CA0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void CreateDeaddropCollectionQuest(NetworkConnection conn, string dropGUID, string guidString = "")
		{
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600141B")]
		[Address(RVA = "0x583770", Offset = "0x582970", VA = "0x180583770")]
		public DeaddropQuest CreateDeaddropCollectionQuest(string dropGUID, string guidString = "")
		{
			return null;
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600141C")]
		[Address(RVA = "0x584C40", Offset = "0x583E40", VA = "0x180584C40")]
		public void PlayCompleteQuestSound()
		{
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600141D")]
		[Address(RVA = "0x584C10", Offset = "0x583E10", VA = "0x180584C10")]
		public void PlayCompleteQuestEntrySound()
		{
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600141E")]
		[Address(RVA = "0x583F30", Offset = "0x583130", VA = "0x180583F30", Slot = "50")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600141F")]
		[Address(RVA = "0x588690", Offset = "0x587890", VA = "0x180588690")]
		public QuestManager()
		{
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001420")]
		[Address(RVA = "0x5846E0", Offset = "0x5838E0", VA = "0x1805846E0", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001421")]
		[Address(RVA = "0x584690", Offset = "0x583890", VA = "0x180584690", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001422")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001423")]
		[Address(RVA = "0x586BD0", Offset = "0x585DD0", VA = "0x180586BD0")]
		private void RpcWriter___Observers_CreateContract_Networked_2526053753(NetworkConnection conn, string title, string description, string guid, bool tracked, NetworkObject customer, ContractInfo contractData, GameDateTime expiry, GameDateTime acceptTime, [Optional] NetworkObject dealerObj)
		{
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001424")]
		[Address(RVA = "0x585680", Offset = "0x584880", VA = "0x180585680")]
		public void RpcLogic___CreateContract_Networked_2526053753(NetworkConnection conn, string title, string description, string guid, bool tracked, NetworkObject customer, ContractInfo contractData, GameDateTime expiry, GameDateTime acceptTime, [Optional] NetworkObject dealerObj)
		{
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001425")]
		[Address(RVA = "0x5860C0", Offset = "0x5852C0", VA = "0x1805860C0")]
		private void RpcReader___Observers_CreateContract_Networked_2526053753(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001426")]
		[Address(RVA = "0x5877D0", Offset = "0x5869D0", VA = "0x1805877D0")]
		private void RpcWriter___Target_CreateContract_Networked_2526053753(NetworkConnection conn, string title, string description, string guid, bool tracked, NetworkObject customer, ContractInfo contractData, GameDateTime expiry, GameDateTime acceptTime, [Optional] NetworkObject dealerObj)
		{
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001427")]
		[Address(RVA = "0x586660", Offset = "0x585860", VA = "0x180586660")]
		private void RpcReader___Target_CreateContract_Networked_2526053753(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001428")]
		[Address(RVA = "0x5873A0", Offset = "0x5865A0", VA = "0x1805873A0")]
		private void RpcWriter___Server_SendQuestAction_2848227116(string guid, QuestManager.EQuestAction action)
		{
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001429")]
		[Address(RVA = "0x585F00", Offset = "0x585100", VA = "0x180585F00")]
		public void RpcLogic___SendQuestAction_2848227116(string guid, QuestManager.EQuestAction action)
		{
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600142A")]
		[Address(RVA = "0x586480", Offset = "0x585680", VA = "0x180586480")]
		private void RpcReader___Server_SendQuestAction_2848227116(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600142B")]
		[Address(RVA = "0x586F30", Offset = "0x586130", VA = "0x180586F30")]
		private void RpcWriter___Observers_ReceiveQuestAction_920727549(NetworkConnection conn, string guid, QuestManager.EQuestAction action)
		{
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600142C")]
		[Address(RVA = "0x585A10", Offset = "0x584C10", VA = "0x180585A10")]
		private void RpcLogic___ReceiveQuestAction_920727549(NetworkConnection conn, string guid, QuestManager.EQuestAction action)
		{
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600142D")]
		[Address(RVA = "0x5862D0", Offset = "0x5854D0", VA = "0x1805862D0")]
		private void RpcReader___Observers_ReceiveQuestAction_920727549(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600142E")]
		[Address(RVA = "0x587B10", Offset = "0x586D10", VA = "0x180587B10")]
		private void RpcWriter___Target_ReceiveQuestAction_920727549(NetworkConnection conn, string guid, QuestManager.EQuestAction action)
		{
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600142F")]
		[Address(RVA = "0x586870", Offset = "0x585A70", VA = "0x180586870")]
		private void RpcReader___Target_ReceiveQuestAction_920727549(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001430")]
		[Address(RVA = "0x587670", Offset = "0x586870", VA = "0x180587670")]
		private void RpcWriter___Server_SendQuestState_4117703421(string guid, EQuestState state)
		{
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001431")]
		[Address(RVA = "0x585F50", Offset = "0x585150", VA = "0x180585F50")]
		public void RpcLogic___SendQuestState_4117703421(string guid, EQuestState state)
		{
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001432")]
		[Address(RVA = "0x5865D0", Offset = "0x5857D0", VA = "0x1805865D0")]
		private void RpcReader___Server_SendQuestState_4117703421(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001433")]
		[Address(RVA = "0x587230", Offset = "0x586430", VA = "0x180587230")]
		private void RpcWriter___Observers_ReceiveQuestState_3887376304(NetworkConnection conn, string guid, EQuestState state)
		{
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001434")]
		[Address(RVA = "0x585DB0", Offset = "0x584FB0", VA = "0x180585DB0")]
		private void RpcLogic___ReceiveQuestState_3887376304(NetworkConnection conn, string guid, EQuestState state)
		{
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001435")]
		[Address(RVA = "0x586400", Offset = "0x585600", VA = "0x180586400")]
		private void RpcReader___Observers_ReceiveQuestState_3887376304(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001436")]
		[Address(RVA = "0x587DF0", Offset = "0x586FF0", VA = "0x180587DF0")]
		private void RpcWriter___Target_ReceiveQuestState_3887376304(NetworkConnection conn, string guid, EQuestState state)
		{
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001437")]
		[Address(RVA = "0x5869A0", Offset = "0x585BA0", VA = "0x1805869A0")]
		private void RpcReader___Target_ReceiveQuestState_3887376304(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001438")]
		[Address(RVA = "0x587F50", Offset = "0x587150", VA = "0x180587F50")]
		private void RpcWriter___Target_SetQuestTracked_619441887(NetworkConnection conn, string guid, bool tracked)
		{
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001439")]
		[Address(RVA = "0x585F70", Offset = "0x585170", VA = "0x180585F70")]
		private void RpcLogic___SetQuestTracked_619441887(NetworkConnection conn, string guid, bool tracked)
		{
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600143A")]
		[Address(RVA = "0x586A20", Offset = "0x585C20", VA = "0x180586A20")]
		private void RpcReader___Target_SetQuestTracked_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600143B")]
		[Address(RVA = "0x587500", Offset = "0x586700", VA = "0x180587500")]
		private void RpcWriter___Server_SendQuestEntryState_375159588(string guid, int entryIndex, EQuestState state)
		{
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600143C")]
		[Address(RVA = "0x585F20", Offset = "0x585120", VA = "0x180585F20")]
		public void RpcLogic___SendQuestEntryState_375159588(string guid, int entryIndex, EQuestState state)
		{
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600143D")]
		[Address(RVA = "0x586510", Offset = "0x585710", VA = "0x180586510")]
		private void RpcReader___Server_SendQuestEntryState_375159588(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600143E")]
		[Address(RVA = "0x5870A0", Offset = "0x5862A0", VA = "0x1805870A0")]
		private void RpcWriter___Observers_ReceiveQuestEntryState_311789429(NetworkConnection conn, string guid, int entryIndex, EQuestState state)
		{
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600143F")]
		[Address(RVA = "0x585C50", Offset = "0x584E50", VA = "0x180585C50")]
		private void RpcLogic___ReceiveQuestEntryState_311789429(NetworkConnection conn, string guid, int entryIndex, EQuestState state)
		{
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001440")]
		[Address(RVA = "0x586350", Offset = "0x585550", VA = "0x180586350")]
		private void RpcReader___Observers_ReceiveQuestEntryState_311789429(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001441")]
		[Address(RVA = "0x587C70", Offset = "0x586E70", VA = "0x180587C70")]
		private void RpcWriter___Target_ReceiveQuestEntryState_311789429(NetworkConnection conn, string guid, int entryIndex, EQuestState state)
		{
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001442")]
		[Address(RVA = "0x5868F0", Offset = "0x585AF0", VA = "0x1805868F0")]
		private void RpcReader___Target_ReceiveQuestEntryState_311789429(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001443")]
		[Address(RVA = "0x586DC0", Offset = "0x585FC0", VA = "0x180586DC0")]
		private void RpcWriter___Observers_CreateDeaddropCollectionQuest_3895153758(NetworkConnection conn, string dropGUID, string guidString = "")
		{
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001444")]
		[Address(RVA = "0x5859F0", Offset = "0x584BF0", VA = "0x1805859F0")]
		public void RpcLogic___CreateDeaddropCollectionQuest_3895153758(NetworkConnection conn, string dropGUID, string guidString = "")
		{
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001445")]
		[Address(RVA = "0x586250", Offset = "0x585450", VA = "0x180586250")]
		private void RpcReader___Observers_CreateDeaddropCollectionQuest_3895153758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001446")]
		[Address(RVA = "0x5879B0", Offset = "0x586BB0", VA = "0x1805879B0")]
		private void RpcWriter___Target_CreateDeaddropCollectionQuest_3895153758(NetworkConnection conn, string dropGUID, string guidString = "")
		{
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001447")]
		[Address(RVA = "0x5867F0", Offset = "0x5859F0", VA = "0x1805867F0")]
		private void RpcReader___Target_CreateDeaddropCollectionQuest_3895153758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001448")]
		[Address(RVA = "0x582500", Offset = "0x581700", VA = "0x180582500", Slot = "51")]
		protected virtual void Awake_UserLogic_ScheduleOne.Quests.QuestManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001253 RID: 4691
		[Token(Token = "0x4001253")]
		public const EQuestState DEFAULT_QUEST_STATE = EQuestState.Inactive;

		// Token: 0x04001254 RID: 4692
		[Token(Token = "0x4001254")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public Quest[] DefaultQuests;

		// Token: 0x04001255 RID: 4693
		[Token(Token = "0x4001255")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[Header("References")]
		public Transform QuestContainer;

		// Token: 0x04001256 RID: 4694
		[Token(Token = "0x4001256")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public Transform ContractContainer;

		// Token: 0x04001257 RID: 4695
		[Token(Token = "0x4001257")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public AudioSourceController QuestCompleteSound;

		// Token: 0x04001258 RID: 4696
		[Token(Token = "0x4001258")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public AudioSourceController QuestEntryCompleteSound;

		// Token: 0x04001259 RID: 4697
		[Token(Token = "0x4001259")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[Header("Prefabs")]
		public Contract ContractPrefab;

		// Token: 0x0400125A RID: 4698
		[Token(Token = "0x400125A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public DeaddropQuest DeaddropCollectionPrefab;

		// Token: 0x0400125B RID: 4699
		[Token(Token = "0x400125B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private QuestsLoader loader;

		// Token: 0x04001260 RID: 4704
		[Token(Token = "0x4001260")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private bool NetworkInitialize___EarlyScheduleOne.Quests.QuestManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04001261 RID: 4705
		[Token(Token = "0x4001261")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x179")]
		private bool NetworkInitialize__LateScheduleOne.Quests.QuestManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x02000332 RID: 818
		[Token(Token = "0x2000332")]
		public enum EQuestAction
		{
			// Token: 0x04001263 RID: 4707
			[Token(Token = "0x4001263")]
			Begin,
			// Token: 0x04001264 RID: 4708
			[Token(Token = "0x4001264")]
			Success,
			// Token: 0x04001265 RID: 4709
			[Token(Token = "0x4001265")]
			Fail,
			// Token: 0x04001266 RID: 4710
			[Token(Token = "0x4001266")]
			Expire,
			// Token: 0x04001267 RID: 4711
			[Token(Token = "0x4001267")]
			Cancel
		}
	}
}
