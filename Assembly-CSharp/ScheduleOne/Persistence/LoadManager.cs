using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Networking;
using ScheduleOne.Persistence.ItemLoaders;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.UI.MainMenu;
using UnityEngine.Events;

namespace ScheduleOne.Persistence
{
	// Token: 0x020003CA RID: 970
	[Token(Token = "0x20003CA")]
	public class LoadManager : PersistentSingleton<LoadManager>
	{
		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001886 RID: 6278 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004B3")]
		public string DefaultTutorialSaveFolder
		{
			[Token(Token = "0x6001886")]
			[Address(RVA = "0x5D6130", Offset = "0x5D5330", VA = "0x1805D6130")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001887 RID: 6279 RVA: 0x00009C60 File Offset: 0x00007E60
		[Token(Token = "0x170004B4")]
		public bool IsInGameScene
		{
			[Token(Token = "0x6001887")]
			[Address(RVA = "0x5D61C0", Offset = "0x5D53C0", VA = "0x1805D61C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06001888 RID: 6280 RVA: 0x00009C78 File Offset: 0x00007E78
		// (set) Token: 0x06001889 RID: 6281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B5")]
		public bool IsGameLoaded
		{
			[Token(Token = "0x6001888")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001889")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x0600188A RID: 6282 RVA: 0x00009C90 File Offset: 0x00007E90
		// (set) Token: 0x0600188B RID: 6283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B6")]
		public bool IsLoading
		{
			[Token(Token = "0x600188A")]
			[Address(RVA = "0x5D6290", Offset = "0x5D5490", VA = "0x1805D6290")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600188B")]
			[Address(RVA = "0x5D63A0", Offset = "0x5D55A0", VA = "0x1805D63A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x0600188C RID: 6284 RVA: 0x00009CA8 File Offset: 0x00007EA8
		// (set) Token: 0x0600188D RID: 6285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B7")]
		public float TimeSinceGameLoaded
		{
			[Token(Token = "0x600188C")]
			[Address(RVA = "0x4956F0", Offset = "0x4948F0", VA = "0x1804956F0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600188D")]
			[Address(RVA = "0x5D63C0", Offset = "0x5D55C0", VA = "0x1805D63C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x0600188E RID: 6286 RVA: 0x00009CC0 File Offset: 0x00007EC0
		// (set) Token: 0x0600188F RID: 6287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B8")]
		public bool DebugMode
		{
			[Token(Token = "0x600188E")]
			[Address(RVA = "0x496D60", Offset = "0x495F60", VA = "0x180496D60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600188F")]
			[Address(RVA = "0x4CD110", Offset = "0x4CC310", VA = "0x1804CD110")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06001890 RID: 6288 RVA: 0x00009CD8 File Offset: 0x00007ED8
		// (set) Token: 0x06001891 RID: 6289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B9")]
		public LoadManager.ELoadStatus LoadStatus
		{
			[Token(Token = "0x6001890")]
			[Address(RVA = "0x4CBFB0", Offset = "0x4CB1B0", VA = "0x1804CBFB0")]
			[CompilerGenerated]
			get
			{
				return LoadManager.ELoadStatus.None;
			}
			[Token(Token = "0x6001891")]
			[Address(RVA = "0x4E1110", Offset = "0x4E0310", VA = "0x1804E1110")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06001892 RID: 6290 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001893 RID: 6291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004BA")]
		public string LoadedGameFolderPath
		{
			[Token(Token = "0x6001892")]
			[Address(RVA = "0x452440", Offset = "0x451640", VA = "0x180452440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001893")]
			[Address(RVA = "0x452470", Offset = "0x451670", VA = "0x180452470")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06001894 RID: 6292 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001895 RID: 6293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004BB")]
		public SaveInfo ActiveSaveInfo
		{
			[Token(Token = "0x6001894")]
			[Address(RVA = "0x492B20", Offset = "0x491D20", VA = "0x180492B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001895")]
			[Address(RVA = "0x4D1C60", Offset = "0x4D0E60", VA = "0x1804D1C60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06001896 RID: 6294 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001897 RID: 6295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004BC")]
		public SaveInfo StoredSaveInfo
		{
			[Token(Token = "0x6001896")]
			[Address(RVA = "0x4C0310", Offset = "0x4BF510", VA = "0x1804C0310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001897")]
			[Address(RVA = "0x5D63B0", Offset = "0x5D55B0", VA = "0x1805D63B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06001898 RID: 6296 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001899 RID: 6297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000C")]
		public static event Action onLoadConfigurations
		{
			[Token(Token = "0x6001898")]
			[Address(RVA = "0x5D6030", Offset = "0x5D5230", VA = "0x1805D6030")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001899")]
			[Address(RVA = "0x5D62A0", Offset = "0x5D54A0", VA = "0x1805D62A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189A")]
		[Address(RVA = "0x5D2020", Offset = "0x5D1220", VA = "0x1805D2020", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189B")]
		[Address(RVA = "0x5D4880", Offset = "0x5D3A80", VA = "0x1805D4880", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189C")]
		[Address(RVA = "0x5D2060", Offset = "0x5D1260", VA = "0x1805D2060")]
		private void Bananas()
		{
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189D")]
		[Address(RVA = "0x5D3570", Offset = "0x5D2770", VA = "0x1805D3570")]
		private void InitializeItemLoaders()
		{
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189E")]
		[Address(RVA = "0x5D38F0", Offset = "0x5D2AF0", VA = "0x1805D38F0")]
		private void InitializeObjectLoaders()
		{
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189F")]
		[Address(RVA = "0x5D3730", Offset = "0x5D2930", VA = "0x1805D3730")]
		private void InitializeNPCLoaders()
		{
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A0")]
		[Address(RVA = "0x5D5A20", Offset = "0x5D4C20", VA = "0x1805D5A20")]
		public void Update()
		{
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A1")]
		[Address(RVA = "0x5D3F40", Offset = "0x5D3140", VA = "0x1805D3F40")]
		public void QueueLoadRequest(LoadRequest request)
		{
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A2")]
		[Address(RVA = "0x5D2AB0", Offset = "0x5D1CB0", VA = "0x1805D2AB0")]
		public void DequeueLoadRequest(LoadRequest request)
		{
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60018A3")]
		[Address(RVA = "0x5D2EF0", Offset = "0x5D20F0", VA = "0x1805D2EF0")]
		public ItemLoader GetItemLoader(string itemType)
		{
			return null;
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60018A4")]
		[Address(RVA = "0x5D3430", Offset = "0x5D2630", VA = "0x1805D3430")]
		public BuildableItemLoader GetObjectLoader(string objectType)
		{
			return null;
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60018A5")]
		[Address(RVA = "0x5D3030", Offset = "0x5D2230", VA = "0x1805D3030")]
		public LegacyNPCLoader GetLegacyNPCLoader(string npcType)
		{
			return null;
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60018A6")]
		[Address(RVA = "0x5D32F0", Offset = "0x5D24F0", VA = "0x1805D32F0")]
		public NPCLoader GetNPCLoader(string npcType)
		{
			return null;
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60018A7")]
		[Address(RVA = "0x5D3170", Offset = "0x5D2370", VA = "0x1805D3170")]
		public string GetLoadStatusText()
		{
			return null;
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A8")]
		[Address(RVA = "0x5D4490", Offset = "0x5D3690", VA = "0x1805D4490")]
		public void StartGame(SaveInfo info, bool allowLoadStacking = false, bool allowSaveBackup = true)
		{
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A9")]
		[Address(RVA = "0x5D3E00", Offset = "0x5D3000", VA = "0x1805D3E00")]
		public void LoadTutorialAsClient()
		{
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018AA")]
		[Address(RVA = "0x5D3C20", Offset = "0x5D2E20", VA = "0x1805D3C20")]
		public void LoadAsClient(string steamId64)
		{
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018AB")]
		[Address(RVA = "0x5D4800", Offset = "0x5D3A00", VA = "0x1805D4800")]
		private void StartLoadErrorAutosubmit()
		{
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018AC")]
		[Address(RVA = "0x5D4480", Offset = "0x5D3680", VA = "0x1805D4480")]
		public void SetWaitingForHostLoad()
		{
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018AD")]
		[Address(RVA = "0x5D3D70", Offset = "0x5D2F70", VA = "0x1805D3D70")]
		public void LoadLastSave()
		{
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018AE")]
		[Address(RVA = "0x5D2470", Offset = "0x5D1670", VA = "0x1805D2470")]
		private void CleanUp()
		{
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018AF")]
		[Address(RVA = "0x5D2B10", Offset = "0x5D1D10", VA = "0x1805D2B10")]
		public void ExitToMenu([Optional] SaveInfo autoLoadSave, [Optional] MainMenuPopup.Data mainMenuPopup, bool preventLeaveLobby = false)
		{
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x00009CF0 File Offset: 0x00007EF0
		[Token(Token = "0x60018B0")]
		[Address(RVA = "0x5D4EA0", Offset = "0x5D40A0", VA = "0x1805D4EA0")]
		public static bool TryLoadSaveInfo(string saveFolderPath, int saveSlotIndex, out SaveInfo saveInfo, bool requireGameFile = false)
		{
			return default(bool);
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B1")]
		[Address(RVA = "0x5D3FF0", Offset = "0x5D31F0", VA = "0x1805D3FF0")]
		public void RefreshSaveInfo()
		{
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B2")]
		[Address(RVA = "0x5D1F40", Offset = "0x5D1140", VA = "0x1805D1F40")]
		public void AddStaggeredReplicator(IStaggeredReplicator replicator)
		{
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B3")]
		[Address(RVA = "0x5D5E10", Offset = "0x5D5010", VA = "0x1805D5E10")]
		public LoadManager()
		{
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B5")]
		[Address(RVA = "0x5D5840", Offset = "0x5D4A40", VA = "0x1805D5840")]
		[CompilerGenerated]
		internal static void <LoadAsClient>g__PlayerSpawned|74_6()
		{
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60018B6")]
		[Address(RVA = "0x5D59B0", Offset = "0x5D4BB0", VA = "0x1805D59B0")]
		[CompilerGenerated]
		private IEnumerator <StartLoadErrorAutosubmit>g__Wait|75_0()
		{
			return null;
		}

		// Token: 0x04001554 RID: 5460
		[Token(Token = "0x4001554")]
		public const int LOADS_PER_FRAME = 50;

		// Token: 0x04001555 RID: 5461
		[Token(Token = "0x4001555")]
		public const bool DEBUG = false;

		// Token: 0x04001556 RID: 5462
		[Token(Token = "0x4001556")]
		public const float LOAD_ERROR_TIMEOUT = 90f;

		// Token: 0x04001557 RID: 5463
		[Token(Token = "0x4001557")]
		public const float NETWORK_TIMEOUT = 30f;

		// Token: 0x04001558 RID: 5464
		[Token(Token = "0x4001558")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<string> LoadHistory;

		// Token: 0x04001559 RID: 5465
		[Token(Token = "0x4001559")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static SaveInfo[] SaveGames;

		// Token: 0x0400155A RID: 5466
		[Token(Token = "0x400155A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static SaveInfo LastPlayedGame;

		// Token: 0x04001563 RID: 5475
		[Token(Token = "0x4001563")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<LoadRequest> loadRequests;

		// Token: 0x04001564 RID: 5476
		[Token(Token = "0x4001564")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<ItemLoader> ItemLoaders;

		// Token: 0x04001565 RID: 5477
		[Token(Token = "0x4001565")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<BuildableItemLoader> ObjectLoaders;

		// Token: 0x04001566 RID: 5478
		[Token(Token = "0x4001566")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<LegacyNPCLoader> LegacyNPCLoaders;

		// Token: 0x04001567 RID: 5479
		[Token(Token = "0x4001567")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<NPCLoader> NPCLoaders;

		// Token: 0x04001568 RID: 5480
		[Token(Token = "0x4001568")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public UnityEvent onPreSceneChange;

		// Token: 0x04001569 RID: 5481
		[Token(Token = "0x4001569")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Action<string> OnLocalSaveLoadStart;

		// Token: 0x0400156B RID: 5483
		[Token(Token = "0x400156B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public UnityEvent onPreLoad;

		// Token: 0x0400156C RID: 5484
		[Token(Token = "0x400156C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UnityEvent onLoadComplete;

		// Token: 0x0400156D RID: 5485
		[Token(Token = "0x400156D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UnityEvent onSaveInfoLoaded;

		// Token: 0x0400156E RID: 5486
		[Token(Token = "0x400156E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<IStaggeredReplicator> staggeredReplicators;

		// Token: 0x020003CB RID: 971
		[Token(Token = "0x20003CB")]
		public enum ELoadStatus
		{
			// Token: 0x04001570 RID: 5488
			[Token(Token = "0x4001570")]
			None,
			// Token: 0x04001571 RID: 5489
			[Token(Token = "0x4001571")]
			LoadingScene,
			// Token: 0x04001572 RID: 5490
			[Token(Token = "0x4001572")]
			Initializing,
			// Token: 0x04001573 RID: 5491
			[Token(Token = "0x4001573")]
			LoadingData,
			// Token: 0x04001574 RID: 5492
			[Token(Token = "0x4001574")]
			SpawningPlayer,
			// Token: 0x04001575 RID: 5493
			[Token(Token = "0x4001575")]
			WaitingForHost
		}
	}
}
