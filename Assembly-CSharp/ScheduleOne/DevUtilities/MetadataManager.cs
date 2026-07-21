using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A04 RID: 2564
	[Token(Token = "0x2000A04")]
	public class MetadataManager : Singleton<MetadataManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06004932 RID: 18738 RVA: 0x00013E18 File Offset: 0x00012018
		// (set) Token: 0x06004933 RID: 18739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B6D")]
		public DateTime CreationDate
		{
			[Token(Token = "0x6004932")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6004933")]
			[Address(RVA = "0x6085D0", Offset = "0x6077D0", VA = "0x1806085D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06004934 RID: 18740 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004935 RID: 18741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B6E")]
		public string CreationVersion
		{
			[Token(Token = "0x6004934")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004935")]
			[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06004936 RID: 18742 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B6F")]
		public string SaveFolderName
		{
			[Token(Token = "0x6004936")]
			[Address(RVA = "0x8F9070", Offset = "0x8F8270", VA = "0x1808F9070", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06004937 RID: 18743 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B70")]
		public string SaveFileName
		{
			[Token(Token = "0x6004937")]
			[Address(RVA = "0x8F9040", Offset = "0x8F8240", VA = "0x1808F9040", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06004938 RID: 18744 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B71")]
		public Loader Loader
		{
			[Token(Token = "0x6004938")]
			[Address(RVA = "0x452440", Offset = "0x451640", VA = "0x180452440", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06004939 RID: 18745 RVA: 0x00013E30 File Offset: 0x00012030
		[Token(Token = "0x17000B72")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6004939")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x0600493A RID: 18746 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600493B RID: 18747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B73")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x600493A")]
			[Address(RVA = "0x492B20", Offset = "0x491D20", VA = "0x180492B20", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600493B")]
			[Address(RVA = "0x4D1C60", Offset = "0x4D0E60", VA = "0x1804D1C60", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x0600493C RID: 18748 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600493D RID: 18749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B74")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x600493C")]
			[Address(RVA = "0x4C0310", Offset = "0x4BF510", VA = "0x1804C0310", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600493D")]
			[Address(RVA = "0x5D63B0", Offset = "0x5D55B0", VA = "0x1805D63B0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x0600493E RID: 18750 RVA: 0x00013E48 File Offset: 0x00012048
		// (set) Token: 0x0600493F RID: 18751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B75")]
		public bool HasChanged
		{
			[Token(Token = "0x600493E")]
			[Address(RVA = "0x49B030", Offset = "0x49A230", VA = "0x18049B030", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600493F")]
			[Address(RVA = "0x49B240", Offset = "0x49A440", VA = "0x18049B240", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06004940 RID: 18752 RVA: 0x00013E60 File Offset: 0x00012060
		[Token(Token = "0x17000B76")]
		public int LoadOrder
		{
			[Token(Token = "0x6004940")]
			[Address(RVA = "0x4C20E0", Offset = "0x4C12E0", VA = "0x1804C20E0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x06004941 RID: 18753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004941")]
		[Address(RVA = "0x8F8C30", Offset = "0x8F7E30", VA = "0x1808F8C30", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06004942 RID: 18754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004942")]
		[Address(RVA = "0x8F8E40", Offset = "0x8F8040", VA = "0x1808F8E40", Slot = "31")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06004943 RID: 18755 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004943")]
		[Address(RVA = "0x8F8CF0", Offset = "0x8F7EF0", VA = "0x1808F8CF0", Slot = "32")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06004944 RID: 18756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004944")]
		[Address(RVA = "0x8F8ED0", Offset = "0x8F80D0", VA = "0x1808F8ED0")]
		public void Load(MetaData data)
		{
		}

		// Token: 0x06004945 RID: 18757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004945")]
		[Address(RVA = "0x8F8F20", Offset = "0x8F8120", VA = "0x1808F8F20")]
		public MetadataManager()
		{
		}

		// Token: 0x040033C6 RID: 13254
		[Token(Token = "0x40033C6")]
		[FieldOffset(Offset = "0x38")]
		private MetadataLoader loader;
	}
}
