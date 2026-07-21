using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Map;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Loaders;

namespace ScheduleOne.Levelling
{
	// Token: 0x020005AB RID: 1451
	[Token(Token = "0x20005AB")]
	public class LevelManager : NetworkSingleton<LevelManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x0600212A RID: 8490 RVA: 0x0000B658 File Offset: 0x00009858
		// (set) Token: 0x0600212B RID: 8491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005D9")]
		public ERank Rank
		{
			[Token(Token = "0x600212A")]
			[Address(RVA = "0x5219D0", Offset = "0x520BD0", VA = "0x1805219D0")]
			[CompilerGenerated]
			get
			{
				return ERank.Street_Rat;
			}
			[Token(Token = "0x600212B")]
			[Address(RVA = "0x6783F0", Offset = "0x6775F0", VA = "0x1806783F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x0600212C RID: 8492 RVA: 0x0000B670 File Offset: 0x00009870
		// (set) Token: 0x0600212D RID: 8493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005DA")]
		public int Tier
		{
			[Token(Token = "0x600212C")]
			[Address(RVA = "0x51C040", Offset = "0x51B240", VA = "0x18051C040")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600212D")]
			[Address(RVA = "0x678400", Offset = "0x677600", VA = "0x180678400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x0600212E RID: 8494 RVA: 0x0000B688 File Offset: 0x00009888
		// (set) Token: 0x0600212F RID: 8495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005DB")]
		public int XP
		{
			[Token(Token = "0x600212E")]
			[Address(RVA = "0x630330", Offset = "0x62F530", VA = "0x180630330")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600212F")]
			[Address(RVA = "0x630400", Offset = "0x62F600", VA = "0x180630400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06002130 RID: 8496 RVA: 0x0000B6A0 File Offset: 0x000098A0
		// (set) Token: 0x06002131 RID: 8497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005DC")]
		public int TotalXP
		{
			[Token(Token = "0x6002130")]
			[Address(RVA = "0x521B10", Offset = "0x520D10", VA = "0x180521B10")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002131")]
			[Address(RVA = "0x521F60", Offset = "0x521160", VA = "0x180521F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06002132 RID: 8498 RVA: 0x0000B6B8 File Offset: 0x000098B8
		[Token(Token = "0x170005DD")]
		public float XPToNextTier
		{
			[Token(Token = "0x6002132")]
			[Address(RVA = "0x678350", Offset = "0x677550", VA = "0x180678350")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06002133 RID: 8499 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170005DE")]
		public string SaveFolderName
		{
			[Token(Token = "0x6002133")]
			[Address(RVA = "0x678320", Offset = "0x677520", VA = "0x180678320", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06002134 RID: 8500 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170005DF")]
		public string SaveFileName
		{
			[Token(Token = "0x6002134")]
			[Address(RVA = "0x6782F0", Offset = "0x6774F0", VA = "0x1806782F0", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06002135 RID: 8501 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170005E0")]
		public Loader Loader
		{
			[Token(Token = "0x6002135")]
			[Address(RVA = "0x5A44D0", Offset = "0x5A36D0", VA = "0x1805A44D0", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06002136 RID: 8502 RVA: 0x0000B6D0 File Offset: 0x000098D0
		[Token(Token = "0x170005E1")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6002136")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06002137 RID: 8503 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002138 RID: 8504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005E2")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6002137")]
			[Address(RVA = "0x5887C0", Offset = "0x5879C0", VA = "0x1805887C0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002138")]
			[Address(RVA = "0x6783D0", Offset = "0x6775D0", VA = "0x1806783D0", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06002139 RID: 8505 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600213A RID: 8506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005E3")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6002139")]
			[Address(RVA = "0x5887D0", Offset = "0x5879D0", VA = "0x1805887D0", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600213A")]
			[Address(RVA = "0x588860", Offset = "0x587A60", VA = "0x180588860", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x0600213B RID: 8507 RVA: 0x0000B6E8 File Offset: 0x000098E8
		// (set) Token: 0x0600213C RID: 8508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005E4")]
		public bool HasChanged
		{
			[Token(Token = "0x600213B")]
			[Address(RVA = "0x6782D0", Offset = "0x6774D0", VA = "0x1806782D0", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600213C")]
			[Address(RVA = "0x6783C0", Offset = "0x6775C0", VA = "0x1806783C0", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x0600213D RID: 8509 RVA: 0x0000B700 File Offset: 0x00009900
		[Token(Token = "0x170005E5")]
		public int LoadOrder
		{
			[Token(Token = "0x600213D")]
			[Address(RVA = "0x6782E0", Offset = "0x6774E0", VA = "0x1806782E0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600213E")]
		[Address(RVA = "0x6755C0", Offset = "0x6747C0", VA = "0x1806755C0", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600213F")]
		[Address(RVA = "0x678120", Offset = "0x677320", VA = "0x180678120", Slot = "19")]
		protected override void Start()
		{
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002140")]
		[Address(RVA = "0x676510", Offset = "0x675710", VA = "0x180676510", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002141")]
		[Address(RVA = "0x6761E0", Offset = "0x6753E0", VA = "0x1806761E0", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06002142 RID: 8514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002142")]
		[Address(RVA = "0x6753B0", Offset = "0x6745B0", VA = "0x1806753B0")]
		[ServerRpc(RequireOwnership = false)]
		public void AddXP(int xp)
		{
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002143")]
		[Address(RVA = "0x675260", Offset = "0x674460", VA = "0x180675260")]
		[ObserversRpc]
		private void AddXPLocal(int xp)
		{
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002144")]
		[Address(RVA = "0x677B30", Offset = "0x676D30", VA = "0x180677B30")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetData(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002145")]
		[Address(RVA = "0x677EC0", Offset = "0x6770C0", VA = "0x180677EC0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void SetUnlockedRegions(NetworkConnection conn, List<EMapRegion> unlockedRegions)
		{
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002146")]
		[Address(RVA = "0x675FB0", Offset = "0x6751B0", VA = "0x180675FB0")]
		[ObserversRpc]
		private void IncreaseTierNetworked(FullRank before, FullRank after)
		{
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002147")]
		[Address(RVA = "0x676120", Offset = "0x675320", VA = "0x180676120")]
		private void IncreaseTier()
		{
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002148")]
		[Address(RVA = "0x675B10", Offset = "0x674D10", VA = "0x180675B10", Slot = "50")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x0000B718 File Offset: 0x00009918
		[Token(Token = "0x6002149")]
		[Address(RVA = "0x6756C0", Offset = "0x6748C0", VA = "0x1806756C0")]
		public FullRank GetFullRank()
		{
			return default(FullRank);
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600214A")]
		[Address(RVA = "0x674FD0", Offset = "0x6741D0", VA = "0x180674FD0")]
		public void AddUnlockable(Unlockable unlockable)
		{
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x0000B730 File Offset: 0x00009930
		[Token(Token = "0x600214B")]
		[Address(RVA = "0x675CA0", Offset = "0x674EA0", VA = "0x180675CA0")]
		public int GetTotalXPForRank(FullRank fullrank)
		{
			return 0;
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x0000B748 File Offset: 0x00009948
		[Token(Token = "0x600214C")]
		[Address(RVA = "0x6756E0", Offset = "0x6748E0", VA = "0x1806756E0")]
		public FullRank GetFullRank(int totalXp)
		{
			return default(FullRank);
		}

		// Token: 0x0600214D RID: 8525 RVA: 0x0000B760 File Offset: 0x00009960
		[Token(Token = "0x600214D")]
		[Address(RVA = "0x675F40", Offset = "0x675140", VA = "0x180675F40")]
		public int GetXPForTier(ERank rank)
		{
			return 0;
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x0000B778 File Offset: 0x00009978
		[Token(Token = "0x600214E")]
		[Address(RVA = "0x6759A0", Offset = "0x674BA0", VA = "0x1806759A0")]
		public static float GetOrderLimitMultiplier(FullRank rank)
		{
			return 0f;
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x0000B790 File Offset: 0x00009990
		[Token(Token = "0x600214F")]
		[Address(RVA = "0x675A60", Offset = "0x674C60", VA = "0x180675A60")]
		private static float GetRankOrderLimitMultiplier(ERank rank)
		{
			return 0f;
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002150")]
		[Address(RVA = "0x678170", Offset = "0x677370", VA = "0x180678170")]
		public LevelManager()
		{
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002151")]
		[Address(RVA = "0x6762C0", Offset = "0x6754C0", VA = "0x1806762C0", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002152")]
		[Address(RVA = "0x676270", Offset = "0x675470", VA = "0x180676270", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002153")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002154")]
		[Address(RVA = "0x6753B0", Offset = "0x6745B0", VA = "0x1806753B0")]
		private void RpcWriter___Server_AddXP_3316948804(int xp)
		{
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002155")]
		[Address(RVA = "0x675260", Offset = "0x674460", VA = "0x180675260")]
		public void RpcLogic___AddXP_3316948804(int xp)
		{
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002156")]
		[Address(RVA = "0x677220", Offset = "0x676420", VA = "0x180677220")]
		private void RpcReader___Server_AddXP_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002157 RID: 8535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002157")]
		[Address(RVA = "0x675260", Offset = "0x674460", VA = "0x180675260")]
		private void RpcWriter___Observers_AddXPLocal_3316948804(int xp)
		{
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002158")]
		[Address(RVA = "0x676610", Offset = "0x675810", VA = "0x180676610")]
		private void RpcLogic___AddXPLocal_3316948804(int xp)
		{
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002159")]
		[Address(RVA = "0x676F00", Offset = "0x676100", VA = "0x180676F00")]
		private void RpcReader___Observers_AddXPLocal_3316948804(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600215A")]
		[Address(RVA = "0x677520", Offset = "0x676720", VA = "0x180677520")]
		private void RpcWriter___Observers_SetData_20965027(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600215B")]
		[Address(RVA = "0x676D00", Offset = "0x675F00", VA = "0x180676D00")]
		public void RpcLogic___SetData_20965027(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600215C")]
		[Address(RVA = "0x6770B0", Offset = "0x6762B0", VA = "0x1806770B0")]
		private void RpcReader___Observers_SetData_20965027(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600215D")]
		[Address(RVA = "0x677820", Offset = "0x676A20", VA = "0x180677820")]
		private void RpcWriter___Target_SetData_20965027(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
		}

		// Token: 0x0600215E RID: 8542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600215E")]
		[Address(RVA = "0x6773B0", Offset = "0x6765B0", VA = "0x1806773B0")]
		private void RpcReader___Target_SetData_20965027(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600215F RID: 8543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600215F")]
		[Address(RVA = "0x6776E0", Offset = "0x6768E0", VA = "0x1806776E0")]
		private void RpcWriter___Observers_SetUnlockedRegions_563230222(NetworkConnection conn, List<EMapRegion> unlockedRegions)
		{
		}

		// Token: 0x06002160 RID: 8544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002160")]
		[Address(RVA = "0x676D80", Offset = "0x675F80", VA = "0x180676D80")]
		public void RpcLogic___SetUnlockedRegions_563230222(NetworkConnection conn, List<EMapRegion> unlockedRegions)
		{
		}

		// Token: 0x06002161 RID: 8545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002161")]
		[Address(RVA = "0x6771C0", Offset = "0x6763C0", VA = "0x1806771C0")]
		private void RpcReader___Observers_SetUnlockedRegions_563230222(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002162 RID: 8546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002162")]
		[Address(RVA = "0x6779D0", Offset = "0x676BD0", VA = "0x1806779D0")]
		private void RpcWriter___Target_SetUnlockedRegions_563230222(NetworkConnection conn, List<EMapRegion> unlockedRegions)
		{
		}

		// Token: 0x06002163 RID: 8547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002163")]
		[Address(RVA = "0x6774C0", Offset = "0x6766C0", VA = "0x1806774C0")]
		private void RpcReader___Target_SetUnlockedRegions_563230222(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002164 RID: 8548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002164")]
		[Address(RVA = "0x675FB0", Offset = "0x6751B0", VA = "0x180675FB0")]
		private void RpcWriter___Observers_IncreaseTierNetworked_3953286437(FullRank before, FullRank after)
		{
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002165")]
		[Address(RVA = "0x676BD0", Offset = "0x675DD0", VA = "0x180676BD0")]
		private void RpcLogic___IncreaseTierNetworked_3953286437(FullRank before, FullRank after)
		{
		}

		// Token: 0x06002166 RID: 8550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002166")]
		[Address(RVA = "0x676F60", Offset = "0x676160", VA = "0x180676F60")]
		private void RpcReader___Observers_IncreaseTierNetworked_3953286437(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002167 RID: 8551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002167")]
		[Address(RVA = "0x6754F0", Offset = "0x6746F0", VA = "0x1806754F0", Slot = "51")]
		protected virtual void Awake_UserLogic_ScheduleOne.Levelling.LevelManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001B02 RID: 6914
		[Token(Token = "0x4001B02")]
		public const int TIERS_PER_RANK = 5;

		// Token: 0x04001B03 RID: 6915
		[Token(Token = "0x4001B03")]
		public const int XP_PER_TIER_MIN = 200;

		// Token: 0x04001B04 RID: 6916
		[Token(Token = "0x4001B04")]
		public const int XP_PER_TIER_MAX = 2500;

		// Token: 0x04001B06 RID: 6918
		[Token(Token = "0x4001B06")]
		[FieldOffset(Offset = "0x124")]
		private int rankCount;

		// Token: 0x04001B0A RID: 6922
		[Token(Token = "0x4001B0A")]
		[FieldOffset(Offset = "0x138")]
		public Action<FullRank, FullRank> onRankUp;

		// Token: 0x04001B0B RID: 6923
		[Token(Token = "0x4001B0B")]
		[FieldOffset(Offset = "0x140")]
		public Action<FullRank, FullRank> onRankChanged;

		// Token: 0x04001B0C RID: 6924
		[Token(Token = "0x4001B0C")]
		[FieldOffset(Offset = "0x148")]
		public Dictionary<FullRank, List<Unlockable>> Unlockables;

		// Token: 0x04001B0D RID: 6925
		[Token(Token = "0x4001B0D")]
		[FieldOffset(Offset = "0x150")]
		private RankLoader loader;

		// Token: 0x04001B12 RID: 6930
		[Token(Token = "0x4001B12")]
		[FieldOffset(Offset = "0x170")]
		private bool NetworkInitialize___EarlyScheduleOne.Levelling.LevelManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04001B13 RID: 6931
		[Token(Token = "0x4001B13")]
		[FieldOffset(Offset = "0x171")]
		private bool NetworkInitialize__LateScheduleOne.Levelling.LevelManagerAssembly-CSharp.dll_Excuted;
	}
}
