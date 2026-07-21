using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Persistence
{
	// Token: 0x020003E0 RID: 992
	[Token(Token = "0x20003E0")]
	public class SaveManager : PersistentSingleton<SaveManager>
	{
		// Token: 0x06001901 RID: 6401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001901")]
		[Address(RVA = "0x5F9C50", Offset = "0x5F8E50", VA = "0x1805F9C50")]
		public static void ReportSaveError()
		{
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x00009F48 File Offset: 0x00008148
		// (set) Token: 0x06001903 RID: 6403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C8")]
		public bool AccessPermissionIssueDetected
		{
			[Token(Token = "0x6001902")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001903")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001904 RID: 6404 RVA: 0x00009F60 File Offset: 0x00008160
		// (set) Token: 0x06001905 RID: 6405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C9")]
		public bool IsSaving
		{
			[Token(Token = "0x6001904")]
			[Address(RVA = "0x5D6290", Offset = "0x5D5490", VA = "0x1805D6290")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001905")]
			[Address(RVA = "0x5D63A0", Offset = "0x5D55A0", VA = "0x1805D63A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06001906 RID: 6406 RVA: 0x00009F78 File Offset: 0x00008178
		// (set) Token: 0x06001907 RID: 6407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004CA")]
		public float SecondsSinceLastSave
		{
			[Token(Token = "0x6001906")]
			[Address(RVA = "0x4956F0", Offset = "0x4948F0", VA = "0x1804956F0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001907")]
			[Address(RVA = "0x5D63C0", Offset = "0x5D55C0", VA = "0x1805D63C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001909 RID: 6409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004CB")]
		public string PlayersSavePath
		{
			[Token(Token = "0x6001908")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001909")]
			[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x0600190A RID: 6410 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600190B RID: 6411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004CC")]
		public string IndividualSavesContainerPath
		{
			[Token(Token = "0x600190A")]
			[Address(RVA = "0x452440", Offset = "0x451640", VA = "0x180452440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600190B")]
			[Address(RVA = "0x452470", Offset = "0x451670", VA = "0x180452470")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x0600190C RID: 6412 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004CD")]
		public string BackupFolderPath
		{
			[Token(Token = "0x600190C")]
			[Address(RVA = "0x5FA770", Offset = "0x5F9970", VA = "0x1805FA770")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x0600190D RID: 6413 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600190E RID: 6414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004CE")]
		public string SaveName
		{
			[Token(Token = "0x600190D")]
			[Address(RVA = "0x492B20", Offset = "0x491D20", VA = "0x180492B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600190E")]
			[Address(RVA = "0x4D1C60", Offset = "0x4D0E60", VA = "0x1804D1C60")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600190F")]
		[Address(RVA = "0x5F8400", Offset = "0x5F7600", VA = "0x1805F8400", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001910")]
		[Address(RVA = "0x5FA200", Offset = "0x5F9400", VA = "0x1805FA200", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001911")]
		[Address(RVA = "0x5F86D0", Offset = "0x5F78D0", VA = "0x1805F86D0")]
		public void CheckSaveFolderInitialized()
		{
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x00009F90 File Offset: 0x00008190
		[Token(Token = "0x6001912")]
		[Address(RVA = "0x5F98D0", Offset = "0x5F8AD0", VA = "0x1805F98D0")]
		public static bool HasWritePermissionOnDir(string path)
		{
			return default(bool);
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001913")]
		[Address(RVA = "0x5FA380", Offset = "0x5F9580", VA = "0x1805FA380")]
		private void Update()
		{
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001914")]
		[Address(RVA = "0x5F9D50", Offset = "0x5F8F50", VA = "0x1805F9D50")]
		public void Save()
		{
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001915")]
		[Address(RVA = "0x5F9DE0", Offset = "0x5F8FE0", VA = "0x1805F9DE0")]
		public void Save(string saveFolderPath)
		{
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001916")]
		[Address(RVA = "0x5F8A60", Offset = "0x5F7C60", VA = "0x1805F8A60")]
		private void ClearBaseLevelOutdatedSaves(string saveFolderPath)
		{
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001917")]
		[Address(RVA = "0x5F8FA0", Offset = "0x5F81A0", VA = "0x1805F8FA0")]
		public void CompleteSaveable(ISaveable saveable)
		{
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001918")]
		[Address(RVA = "0x5F8F40", Offset = "0x5F8140", VA = "0x1805F8F40")]
		public void ClearCompletedSaveable(ISaveable saveable)
		{
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001919")]
		[Address(RVA = "0x5F9070", Offset = "0x5F8270", VA = "0x1805F9070")]
		public void CreateSaveBackup(SaveInfo saveInfo)
		{
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600191A")]
		[Address(RVA = "0x5F9B00", Offset = "0x5F8D00", VA = "0x1805F9B00")]
		public void RegisterSaveable(ISaveable saveable)
		{
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600191B")]
		[Address(RVA = "0x5F9A50", Offset = "0x5F8C50", VA = "0x1805F9A50")]
		public void QueueSaveRequest(SaveRequest request)
		{
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600191C")]
		[Address(RVA = "0x5F94C0", Offset = "0x5F86C0", VA = "0x1805F94C0")]
		public void DequeueSaveRequest(SaveRequest request)
		{
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600191D")]
		[Address(RVA = "0x5FA310", Offset = "0x5F9510", VA = "0x1805FA310")]
		public static string StripExtensions(string filePath)
		{
			return null;
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600191E")]
		[Address(RVA = "0x5F9990", Offset = "0x5F8B90", VA = "0x1805F9990")]
		public static string MakeFileSafe(string fileName)
		{
			return null;
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x00009FA8 File Offset: 0x000081A8
		[Token(Token = "0x600191F")]
		[Address(RVA = "0x5F9710", Offset = "0x5F8910", VA = "0x1805F9710")]
		public static float GetVersionNumber(string version)
		{
			return 0f;
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001920")]
		[Address(RVA = "0x5F89C0", Offset = "0x5F7BC0", VA = "0x1805F89C0")]
		private void Clean()
		{
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001921")]
		[Address(RVA = "0x5F9520", Offset = "0x5F8720", VA = "0x1805F9520")]
		public void DisablePlayTutorial(SaveInfo info)
		{
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001922")]
		[Address(RVA = "0x5F9C90", Offset = "0x5F8E90", VA = "0x1805F9C90")]
		public static string SanitizeFileName(string fileName)
		{
			return null;
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001923")]
		[Address(RVA = "0x5FA570", Offset = "0x5F9770", VA = "0x1805FA570")]
		public SaveManager()
		{
		}

		// Token: 0x040015BA RID: 5562
		[Token(Token = "0x40015BA")]
		public const string MAIN_SCENE_NAME = "Main";

		// Token: 0x040015BB RID: 5563
		[Token(Token = "0x40015BB")]
		public const string MENU_SCENE_NAME = "Menu";

		// Token: 0x040015BC RID: 5564
		[Token(Token = "0x40015BC")]
		public const string TUTORIAL_SCENE_NAME = "Tutorial";

		// Token: 0x040015BD RID: 5565
		[Token(Token = "0x40015BD")]
		public const int SAVES_PER_FRAME = 15;

		// Token: 0x040015BE RID: 5566
		[Token(Token = "0x40015BE")]
		public const string SAVE_FILE_EXTENSION = ".json";

		// Token: 0x040015BF RID: 5567
		[Token(Token = "0x40015BF")]
		public const int SAVE_SLOT_COUNT = 5;

		// Token: 0x040015C0 RID: 5568
		[Token(Token = "0x40015C0")]
		public const string SAVE_GAME_PREFIX = "SaveGame_";

		// Token: 0x040015C1 RID: 5569
		[Token(Token = "0x40015C1")]
		public const bool DEBUG = false;

		// Token: 0x040015C2 RID: 5570
		[Token(Token = "0x40015C2")]
		public const bool PRETTY_PRINT = true;

		// Token: 0x040015C3 RID: 5571
		[Token(Token = "0x40015C3")]
		[FieldOffset(Offset = "0x0")]
		public static bool SaveError;

		// Token: 0x040015CA RID: 5578
		[Token(Token = "0x40015CA")]
		[FieldOffset(Offset = "0x48")]
		public List<ISaveable> Saveables;

		// Token: 0x040015CB RID: 5579
		[Token(Token = "0x40015CB")]
		[FieldOffset(Offset = "0x50")]
		public List<IBaseSaveable> BaseSaveables;

		// Token: 0x040015CC RID: 5580
		[Token(Token = "0x40015CC")]
		[FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public List<string> ApprovedBaseLevelPaths;

		// Token: 0x040015CD RID: 5581
		[Token(Token = "0x40015CD")]
		[FieldOffset(Offset = "0x60")]
		protected List<ISaveable> CompletedSaveables;

		// Token: 0x040015CE RID: 5582
		[Token(Token = "0x40015CE")]
		[FieldOffset(Offset = "0x68")]
		protected List<SaveRequest> QueuedSaveRequests;

		// Token: 0x040015CF RID: 5583
		[Token(Token = "0x40015CF")]
		[FieldOffset(Offset = "0x70")]
		[Header("References")]
		public RectTransform WriteIssueDisplay;

		// Token: 0x040015D0 RID: 5584
		[Token(Token = "0x40015D0")]
		[FieldOffset(Offset = "0x78")]
		[Header("Events")]
		public UnityEvent onSaveStart;

		// Token: 0x040015D1 RID: 5585
		[Token(Token = "0x40015D1")]
		[FieldOffset(Offset = "0x80")]
		public UnityEvent onSaveComplete;

		// Token: 0x040015D2 RID: 5586
		[Token(Token = "0x40015D2")]
		[FieldOffset(Offset = "0x88")]
		private bool saveFolderInitialized;
	}
}
