using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.GameTime;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.UI;
using ScheduleOne.UI.Compass;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.Quests
{
	// Token: 0x0200032D RID: 813
	[Token(Token = "0x200032D")]
	[Serializable]
	public class Quest : MonoBehaviour, IGUIDRegisterable, ISaveable
	{
		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06001391 RID: 5009 RVA: 0x00008D18 File Offset: 0x00006F18
		// (set) Token: 0x06001392 RID: 5010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003FB")]
		public EQuestState State
		{
			[Token(Token = "0x6001391")]
			[Address(RVA = "0x492970", Offset = "0x491B70", VA = "0x180492970")]
			[CompilerGenerated]
			get
			{
				return EQuestState.Inactive;
			}
			[Token(Token = "0x6001392")]
			[Address(RVA = "0x4929C0", Offset = "0x491BC0", VA = "0x1804929C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06001393 RID: 5011 RVA: 0x00008D30 File Offset: 0x00006F30
		// (set) Token: 0x06001394 RID: 5012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003FC")]
		public Guid GUID
		{
			[Token(Token = "0x6001393")]
			[Address(RVA = "0x58D070", Offset = "0x58C270", VA = "0x18058D070", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6001394")]
			[Address(RVA = "0x58D230", Offset = "0x58C430", VA = "0x18058D230")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06001395 RID: 5013 RVA: 0x00008D48 File Offset: 0x00006F48
		// (set) Token: 0x06001396 RID: 5014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003FD")]
		public bool IsTracked
		{
			[Token(Token = "0x6001395")]
			[Address(RVA = "0x58D090", Offset = "0x58C290", VA = "0x18058D090")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001396")]
			[Address(RVA = "0x58D250", Offset = "0x58C450", VA = "0x18058D250")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06001397 RID: 5015 RVA: 0x00008D60 File Offset: 0x00006F60
		[Token(Token = "0x170003FE")]
		public int ActiveEntryCount
		{
			[Token(Token = "0x6001397")]
			[Address(RVA = "0x58CF30", Offset = "0x58C130", VA = "0x18058CF30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06001398 RID: 5016 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170003FF")]
		public string Title
		{
			[Token(Token = "0x6001398")]
			[Address(RVA = "0x58D190", Offset = "0x58C390", VA = "0x18058D190")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06001399 RID: 5017 RVA: 0x00008D78 File Offset: 0x00006F78
		// (set) Token: 0x0600139A RID: 5018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000400")]
		public bool Expires
		{
			[Token(Token = "0x6001399")]
			[Address(RVA = "0x58D050", Offset = "0x58C250", VA = "0x18058D050")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600139A")]
			[Address(RVA = "0x58D210", Offset = "0x58C410", VA = "0x18058D210")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x0600139B RID: 5019 RVA: 0x00008D90 File Offset: 0x00006F90
		// (set) Token: 0x0600139C RID: 5020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000401")]
		public GameDateTime Expiry
		{
			[Token(Token = "0x600139B")]
			[Address(RVA = "0x58D060", Offset = "0x58C260", VA = "0x18058D060")]
			[CompilerGenerated]
			get
			{
				return default(GameDateTime);
			}
			[Token(Token = "0x600139C")]
			[Address(RVA = "0x58D220", Offset = "0x58C420", VA = "0x18058D220")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x0600139D RID: 5021 RVA: 0x00008DA8 File Offset: 0x00006FA8
		[Token(Token = "0x17000402")]
		public bool hudUIExists
		{
			[Token(Token = "0x600139D")]
			[Address(RVA = "0x58D1B0", Offset = "0x58C3B0", VA = "0x18058D1B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x0600139E RID: 5022 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600139F RID: 5023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000403")]
		public QuestHUDUI hudUI
		{
			[Token(Token = "0x600139E")]
			[Address(RVA = "0x514940", Offset = "0x513B40", VA = "0x180514940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600139F")]
			[Address(RVA = "0x51C410", Offset = "0x51B610", VA = "0x18051C410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000404")]
		public string SaveFolderName
		{
			[Token(Token = "0x60013A0")]
			[Address(RVA = "0x58D120", Offset = "0x58C320", VA = "0x18058D120", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x060013A1 RID: 5025 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000405")]
		public string SaveFileName
		{
			[Token(Token = "0x60013A1")]
			[Address(RVA = "0x58D0B0", Offset = "0x58C2B0", VA = "0x18058D0B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000406")]
		public Loader Loader
		{
			[Token(Token = "0x60013A2")]
			[Address(RVA = "0x490CA0", Offset = "0x48FEA0", VA = "0x180490CA0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x060013A3 RID: 5027 RVA: 0x00008DC0 File Offset: 0x00006FC0
		[Token(Token = "0x17000407")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x60013A3")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x060013A4 RID: 5028 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060013A5 RID: 5029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000408")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x60013A4")]
			[Address(RVA = "0x58D0A0", Offset = "0x58C2A0", VA = "0x18058D0A0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60013A5")]
			[Address(RVA = "0x58D280", Offset = "0x58C480", VA = "0x18058D280", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x060013A6 RID: 5030 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060013A7 RID: 5031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000409")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x60013A6")]
			[Address(RVA = "0x521AC0", Offset = "0x520CC0", VA = "0x180521AC0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60013A7")]
			[Address(RVA = "0x58D260", Offset = "0x58C460", VA = "0x18058D260", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x060013A8 RID: 5032 RVA: 0x00008DD8 File Offset: 0x00006FD8
		// (set) Token: 0x060013A9 RID: 5033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700040A")]
		public bool HasChanged
		{
			[Token(Token = "0x60013A8")]
			[Address(RVA = "0x58D080", Offset = "0x58C280", VA = "0x18058D080", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60013A9")]
			[Address(RVA = "0x58D240", Offset = "0x58C440", VA = "0x18058D240", Slot = "16")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AA")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "30")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AB")]
		[Address(RVA = "0x58C520", Offset = "0x58B720", VA = "0x18058C520", Slot = "31")]
		protected virtual void Start()
		{
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AC")]
		[Address(RVA = "0x58A6E0", Offset = "0x5898E0", VA = "0x18058A6E0", Slot = "32")]
		public virtual void InitializeQuest(string title, string description, QuestEntryData[] entries, string guid)
		{
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AD")]
		[Address(RVA = "0x58ACA0", Offset = "0x589EA0", VA = "0x18058ACA0", Slot = "33")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AE")]
		[Address(RVA = "0x588F10", Offset = "0x588110", VA = "0x180588F10")]
		public void ConfigureExpiry(bool expires, GameDateTime expiry)
		{
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AF")]
		[Address(RVA = "0x5888A0", Offset = "0x587AA0", VA = "0x1805888A0", Slot = "34")]
		public virtual void Begin(bool network = true)
		{
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B0")]
		[Address(RVA = "0x588CA0", Offset = "0x587EA0", VA = "0x180588CA0", Slot = "35")]
		public virtual void Complete(bool network = true)
		{
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B1")]
		[Address(RVA = "0x589EC0", Offset = "0x5890C0", VA = "0x180589EC0", Slot = "36")]
		public virtual void Fail(bool network = true)
		{
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B2")]
		[Address(RVA = "0x589DD0", Offset = "0x588FD0", VA = "0x180589DD0", Slot = "37")]
		public virtual void Expire(bool network = true)
		{
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B3")]
		[Address(RVA = "0x588A90", Offset = "0x587C90", VA = "0x180588A90", Slot = "38")]
		public virtual void Cancel(bool network = true)
		{
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B4")]
		[Address(RVA = "0x589A60", Offset = "0x588C60", VA = "0x180589A60", Slot = "39")]
		public virtual void End()
		{
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B5")]
		[Address(RVA = "0x58B880", Offset = "0x58AA80", VA = "0x18058B880", Slot = "40")]
		public virtual void SetQuestState(EQuestState state, bool network = true)
		{
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x00008DF0 File Offset: 0x00006FF0
		[Token(Token = "0x60013B6")]
		[Address(RVA = "0x580300", Offset = "0x57F500", VA = "0x180580300", Slot = "41")]
		protected virtual bool ShouldShowJournalEntry()
		{
			return default(bool);
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B7")]
		[Address(RVA = "0x58B6E0", Offset = "0x58A8E0", VA = "0x18058B6E0", Slot = "42")]
		public virtual void SetQuestEntryState(int entryIndex, EQuestState state, bool network = true)
		{
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B8")]
		[Address(RVA = "0x58B030", Offset = "0x58A230", VA = "0x18058B030", Slot = "43")]
		protected virtual void OnMinPass()
		{
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B9")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "44")]
		protected virtual void OnUncappedMinPass()
		{
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013BA")]
		[Address(RVA = "0x588C30", Offset = "0x587E30", VA = "0x180588C30", Slot = "45")]
		protected virtual void CheckExpiry()
		{
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013BB")]
		[Address(RVA = "0x588B80", Offset = "0x587D80", VA = "0x180588B80")]
		private void CheckAutoComplete()
		{
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x00008E08 File Offset: 0x00007008
		[Token(Token = "0x60013BC")]
		[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "46")]
		protected virtual bool CanExpire()
		{
			return default(bool);
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013BD")]
		[Address(RVA = "0x58B2C0", Offset = "0x58A4C0", VA = "0x18058B2C0", Slot = "47")]
		protected virtual void SendExpiryReminder()
		{
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013BE")]
		[Address(RVA = "0x58B1A0", Offset = "0x58A3A0", VA = "0x18058B1A0", Slot = "48")]
		protected virtual void SendExpiredNotification()
		{
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013BF")]
		[Address(RVA = "0x58B3E0", Offset = "0x58A5E0", VA = "0x18058B3E0", Slot = "6")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013C0")]
		[Address(RVA = "0x58BC10", Offset = "0x58AE10", VA = "0x18058BC10")]
		public void SetSubtitle(string subtitle)
		{
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013C1")]
		[Address(RVA = "0x58B440", Offset = "0x58A640", VA = "0x18058B440", Slot = "49")]
		public virtual void SetIsTracked(bool tracked)
		{
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013C2")]
		[Address(RVA = "0x58BE80", Offset = "0x58B080", VA = "0x18058BE80", Slot = "50")]
		public virtual void SetupJournalEntry()
		{
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013C3")]
		[Address(RVA = "0x5899A0", Offset = "0x588BA0", VA = "0x1805899A0")]
		private void DestroyJournalEntry()
		{
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013C4")]
		[Address(RVA = "0x58AD30", Offset = "0x589F30", VA = "0x18058AD30")]
		private void JournalEntryClicked()
		{
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013C5")]
		[Address(RVA = "0x58AD50", Offset = "0x589F50", VA = "0x18058AD50")]
		private void JournalEntryHoverStart()
		{
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x00008E20 File Offset: 0x00007020
		[Token(Token = "0x60013C6")]
		[Address(RVA = "0x58A1F0", Offset = "0x5893F0", VA = "0x18058A1F0")]
		public int GetMinsUntilExpiry()
		{
			return 0;
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60013C7")]
		[Address(RVA = "0x589FB0", Offset = "0x5891B0", VA = "0x180589FB0")]
		public string GetExpiryText()
		{
			return null;
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60013C8")]
		[Address(RVA = "0x58BC50", Offset = "0x58AE50", VA = "0x18058BC50", Slot = "51")]
		public virtual QuestHUDUI SetupHUDUI()
		{
			return null;
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013C9")]
		[Address(RVA = "0x58CC70", Offset = "0x58BE70", VA = "0x18058CC70")]
		public void UpdateHUDUI()
		{
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013CA")]
		[Address(RVA = "0x589980", Offset = "0x588B80", VA = "0x180589980")]
		public void DestroyHUDUI()
		{
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013CB")]
		[Address(RVA = "0x588A10", Offset = "0x587C10", VA = "0x180588A10")]
		public void BopHUDUI()
		{
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60013CC")]
		[Address(RVA = "0x452440", Offset = "0x451640", VA = "0x180452440", Slot = "52")]
		public virtual string GetQuestTitle()
		{
			return null;
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60013CD")]
		[Address(RVA = "0x58A130", Offset = "0x589330", VA = "0x18058A130")]
		public QuestEntry GetFirstActiveEntry()
		{
			return null;
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60013CE")]
		[Address(RVA = "0x588F20", Offset = "0x588120", VA = "0x180588F20", Slot = "53")]
		public virtual RectTransform CreateDetailDisplay(RectTransform parent)
		{
			return null;
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013CF")]
		[Address(RVA = "0x5898C0", Offset = "0x588AC0", VA = "0x1805898C0")]
		public void DestroyDetailDisplay()
		{
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x00008E38 File Offset: 0x00007038
		[Token(Token = "0x60013D0")]
		[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "54")]
		public virtual bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60013D1")]
		[Address(RVA = "0x58A3C0", Offset = "0x5895C0", VA = "0x18058A3C0", Slot = "55")]
		public virtual SaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60013D2")]
		[Address(RVA = "0x58A6A0", Offset = "0x5898A0", VA = "0x18058A6A0", Slot = "18")]
		public string GetSaveString()
		{
			return null;
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013D3")]
		[Address(RVA = "0x58ADC0", Offset = "0x589FC0", VA = "0x18058ADC0", Slot = "56")]
		public virtual void Load(QuestData data)
		{
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60013D4")]
		[Address(RVA = "0x58A2B0", Offset = "0x5894B0", VA = "0x18058A2B0")]
		public static Quest GetQuest(string questName)
		{
			return null;
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013D5")]
		[Address(RVA = "0x58CD90", Offset = "0x58BF90", VA = "0x18058CD90")]
		public Quest()
		{
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013D7")]
		[Address(RVA = "0x58CA00", Offset = "0x58BC00", VA = "0x18058CA00")]
		[CompilerGenerated]
		private void <Start>g__Initialize|88_0()
		{
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013D9")]
		[Address(RVA = "0x58C7B0", Offset = "0x58B9B0", VA = "0x18058C7B0")]
		[CompilerGenerated]
		private void <CreateDetailDisplay>g__ShowOnMap|123_0()
		{
		}

		// Token: 0x04001210 RID: 4624
		[Token(Token = "0x4001210")]
		public const int MAX_HUD_ENTRY_LABELS = 10;

		// Token: 0x04001211 RID: 4625
		[Token(Token = "0x4001211")]
		public const int CriticalExpiryThreshold = 120;

		// Token: 0x04001212 RID: 4626
		[Token(Token = "0x4001212")]
		[FieldOffset(Offset = "0x0")]
		public static List<Quest> Quests;

		// Token: 0x04001213 RID: 4627
		[Token(Token = "0x4001213")]
		[FieldOffset(Offset = "0x8")]
		public static Quest HoveredQuest;

		// Token: 0x04001214 RID: 4628
		[Token(Token = "0x4001214")]
		[FieldOffset(Offset = "0x10")]
		public static List<Quest> ActiveQuests;

		// Token: 0x04001218 RID: 4632
		[Token(Token = "0x4001218")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Header("Basic Settings")]
		protected string title;

		// Token: 0x04001219 RID: 4633
		[Token(Token = "0x4001219")]
		[FieldOffset(Offset = "0x40")]
		public string Subtitle;

		// Token: 0x0400121A RID: 4634
		[Token(Token = "0x400121A")]
		[FieldOffset(Offset = "0x48")]
		public Action onSubtitleChanged;

		// Token: 0x0400121B RID: 4635
		[Token(Token = "0x400121B")]
		[FieldOffset(Offset = "0x50")]
		[TextArea(3, 10)]
		public string Description;

		// Token: 0x0400121C RID: 4636
		[Token(Token = "0x400121C")]
		[FieldOffset(Offset = "0x58")]
		public string StaticGUID;

		// Token: 0x0400121D RID: 4637
		[Token(Token = "0x400121D")]
		[FieldOffset(Offset = "0x60")]
		public bool TrackOnBegin;

		// Token: 0x0400121E RID: 4638
		[Token(Token = "0x400121E")]
		[FieldOffset(Offset = "0x64")]
		public EExpiryVisibility ExpiryVisibility;

		// Token: 0x0400121F RID: 4639
		[Token(Token = "0x400121F")]
		[FieldOffset(Offset = "0x68")]
		public bool AutoCompleteOnAllEntriesComplete;

		// Token: 0x04001220 RID: 4640
		[Token(Token = "0x4001220")]
		[FieldOffset(Offset = "0x69")]
		public bool PlayQuestCompleteSound;

		// Token: 0x04001221 RID: 4641
		[Token(Token = "0x4001221")]
		[FieldOffset(Offset = "0x6C")]
		public int CompletionXP;

		// Token: 0x04001224 RID: 4644
		[Token(Token = "0x4001224")]
		[FieldOffset(Offset = "0x7C")]
		[Header("Entries")]
		public bool AutoStartFirstEntry;

		// Token: 0x04001225 RID: 4645
		[Token(Token = "0x4001225")]
		[FieldOffset(Offset = "0x80")]
		public List<QuestEntry> Entries;

		// Token: 0x04001226 RID: 4646
		[Token(Token = "0x4001226")]
		[FieldOffset(Offset = "0x88")]
		[Header("UI")]
		public RectTransform IconPrefab;

		// Token: 0x04001227 RID: 4647
		[Token(Token = "0x4001227")]
		[FieldOffset(Offset = "0x90")]
		[Header("PoI Settings")]
		public GameObject PoIPrefab;

		// Token: 0x04001228 RID: 4648
		[Token(Token = "0x4001228")]
		[FieldOffset(Offset = "0x98")]
		[Header("Events")]
		public UnityEvent onQuestBegin;

		// Token: 0x04001229 RID: 4649
		[Token(Token = "0x4001229")]
		[FieldOffset(Offset = "0xA0")]
		public UnityEvent<EQuestState> onQuestEnd;

		// Token: 0x0400122A RID: 4650
		[Token(Token = "0x400122A")]
		[FieldOffset(Offset = "0xA8")]
		public UnityEvent onActiveState;

		// Token: 0x0400122B RID: 4651
		[Token(Token = "0x400122B")]
		[FieldOffset(Offset = "0xB0")]
		public UnityEvent<bool> onTrackChange;

		// Token: 0x0400122C RID: 4652
		[Token(Token = "0x400122C")]
		[FieldOffset(Offset = "0xB8")]
		public UnityEvent onComplete;

		// Token: 0x0400122D RID: 4653
		[Token(Token = "0x400122D")]
		[FieldOffset(Offset = "0xC0")]
		public UnityEvent onInitialComplete;

		// Token: 0x0400122E RID: 4654
		[Token(Token = "0x400122E")]
		[FieldOffset(Offset = "0xC8")]
		[Header("Reminders")]
		public bool ShouldSendExpiryReminder;

		// Token: 0x0400122F RID: 4655
		[Token(Token = "0x400122F")]
		[FieldOffset(Offset = "0xC9")]
		public bool ShouldSendExpiredNotification;

		// Token: 0x04001230 RID: 4656
		[Token(Token = "0x4001230")]
		[FieldOffset(Offset = "0xD0")]
		protected RectTransform journalEntry;

		// Token: 0x04001231 RID: 4657
		[Token(Token = "0x4001231")]
		[FieldOffset(Offset = "0xD8")]
		protected RectTransform entryTitleRect;

		// Token: 0x04001232 RID: 4658
		[Token(Token = "0x4001232")]
		[FieldOffset(Offset = "0xE0")]
		protected RectTransform trackedRect;

		// Token: 0x04001233 RID: 4659
		[Token(Token = "0x4001233")]
		[FieldOffset(Offset = "0xE8")]
		protected Text entryTimeLabel;

		// Token: 0x04001234 RID: 4660
		[Token(Token = "0x4001234")]
		[FieldOffset(Offset = "0xF0")]
		protected Image criticalTimeBackground;

		// Token: 0x04001235 RID: 4661
		[Token(Token = "0x4001235")]
		[FieldOffset(Offset = "0xF8")]
		protected RectTransform detailPanel;

		// Token: 0x04001237 RID: 4663
		[Token(Token = "0x4001237")]
		[FieldOffset(Offset = "0x108")]
		public Action onHudUICreated;

		// Token: 0x04001238 RID: 4664
		[Token(Token = "0x4001238")]
		[FieldOffset(Offset = "0x110")]
		private bool expiryReminderSent;

		// Token: 0x04001239 RID: 4665
		[Token(Token = "0x4001239")]
		[FieldOffset(Offset = "0x118")]
		private CompassManager.Element compassElement;

		// Token: 0x0400123D RID: 4669
		[Token(Token = "0x400123D")]
		[FieldOffset(Offset = "0x131")]
		protected bool autoInitialize;
	}
}
