using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;

namespace ScheduleOne.Property
{
	// Token: 0x0200035B RID: 859
	[Token(Token = "0x200035B")]
	public class BusinessManager : Singleton<BusinessManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x0600150D RID: 5389 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000421")]
		public string SaveFolderName
		{
			[Token(Token = "0x600150D")]
			[Address(RVA = "0x596FA0", Offset = "0x5961A0", VA = "0x180596FA0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x0600150E RID: 5390 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000422")]
		public string SaveFileName
		{
			[Token(Token = "0x600150E")]
			[Address(RVA = "0x596F70", Offset = "0x596170", VA = "0x180596F70", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x0600150F RID: 5391 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000423")]
		public Loader Loader
		{
			[Token(Token = "0x600150F")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001510 RID: 5392 RVA: 0x000090A8 File Offset: 0x000072A8
		[Token(Token = "0x17000424")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6001510")]
			[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001511 RID: 5393 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001512 RID: 5394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000425")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6001511")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001512")]
			[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06001513 RID: 5395 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001514 RID: 5396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000426")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6001513")]
			[Address(RVA = "0x452440", Offset = "0x451640", VA = "0x180452440", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001514")]
			[Address(RVA = "0x452470", Offset = "0x451670", VA = "0x180452470", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06001515 RID: 5397 RVA: 0x000090C0 File Offset: 0x000072C0
		// (set) Token: 0x06001516 RID: 5398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000427")]
		public bool HasChanged
		{
			[Token(Token = "0x6001515")]
			[Address(RVA = "0x496DF0", Offset = "0x495FF0", VA = "0x180496DF0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001516")]
			[Address(RVA = "0x496E70", Offset = "0x496070", VA = "0x180496E70", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06001517 RID: 5399 RVA: 0x000090D8 File Offset: 0x000072D8
		[Token(Token = "0x17000428")]
		public int LoadOrder
		{
			[Token(Token = "0x6001517")]
			[Address(RVA = "0x596F60", Offset = "0x596160", VA = "0x180596F60", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001518")]
		[Address(RVA = "0x5966E0", Offset = "0x5958E0", VA = "0x1805966E0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001519")]
		[Address(RVA = "0x596850", Offset = "0x595A50", VA = "0x180596850", Slot = "31")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600151A")]
		[Address(RVA = "0x596810", Offset = "0x595A10", VA = "0x180596810", Slot = "32")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600151B")]
		[Address(RVA = "0x596AF0", Offset = "0x595CF0", VA = "0x180596AF0", Slot = "33")]
		public virtual List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600151C")]
		[Address(RVA = "0x596730", Offset = "0x595930", VA = "0x180596730", Slot = "34")]
		public virtual void DeleteUnapprovedFiles(string parentFolderPath)
		{
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600151D")]
		[Address(RVA = "0x5968E0", Offset = "0x595AE0", VA = "0x1805968E0")]
		public void LoadBusiness(BusinessData businessData, string dataString)
		{
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600151E")]
		[Address(RVA = "0x596E70", Offset = "0x596070", VA = "0x180596E70")]
		public BusinessManager()
		{
		}

		// Token: 0x040012E8 RID: 4840
		[Token(Token = "0x40012E8")]
		[FieldOffset(Offset = "0x28")]
		private BusinessesLoader loader;
	}
}
