using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;

namespace ScheduleOne.Persistence
{
	// Token: 0x020003C3 RID: 963
	[Token(Token = "0x20003C3")]
	public class GenericSaveablesManager : Singleton<GenericSaveablesManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06001853 RID: 6227 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004A2")]
		public string SaveFolderName
		{
			[Token(Token = "0x6001853")]
			[Address(RVA = "0x5CEEE0", Offset = "0x5CE0E0", VA = "0x1805CEEE0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001854 RID: 6228 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004A3")]
		public string SaveFileName
		{
			[Token(Token = "0x6001854")]
			[Address(RVA = "0x5CEEB0", Offset = "0x5CE0B0", VA = "0x1805CEEB0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001855 RID: 6229 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004A4")]
		public Loader Loader
		{
			[Token(Token = "0x6001855")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06001856 RID: 6230 RVA: 0x00009BD0 File Offset: 0x00007DD0
		[Token(Token = "0x170004A5")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6001856")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06001857 RID: 6231 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001858 RID: 6232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A6")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6001857")]
			[Address(RVA = "0x452440", Offset = "0x451640", VA = "0x180452440", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001858")]
			[Address(RVA = "0x452470", Offset = "0x451670", VA = "0x180452470", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001859 RID: 6233 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600185A RID: 6234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A7")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6001859")]
			[Address(RVA = "0x492B20", Offset = "0x491D20", VA = "0x180492B20", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600185A")]
			[Address(RVA = "0x4D1C60", Offset = "0x4D0E60", VA = "0x1804D1C60", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x0600185B RID: 6235 RVA: 0x00009BE8 File Offset: 0x00007DE8
		// (set) Token: 0x0600185C RID: 6236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A8")]
		public bool HasChanged
		{
			[Token(Token = "0x600185B")]
			[Address(RVA = "0x4D4690", Offset = "0x4D3890", VA = "0x1804D4690", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600185C")]
			[Address(RVA = "0x4D4A40", Offset = "0x4D3C40", VA = "0x1804D4A40", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x0600185D RID: 6237 RVA: 0x00009C00 File Offset: 0x00007E00
		[Token(Token = "0x170004A9")]
		public int LoadOrder
		{
			[Token(Token = "0x600185D")]
			[Address(RVA = "0x4D4680", Offset = "0x4D3880", VA = "0x1804D4680", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600185E")]
		[Address(RVA = "0x5CE7A0", Offset = "0x5CD9A0", VA = "0x1805CE7A0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600185F")]
		[Address(RVA = "0x5CE9A0", Offset = "0x5CDBA0", VA = "0x1805CE9A0", Slot = "31")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001860")]
		[Address(RVA = "0x5CEC90", Offset = "0x5CDE90", VA = "0x1805CEC90")]
		public void RegisterSaveable(IGenericSaveable saveable)
		{
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001861")]
		[Address(RVA = "0x5CE7F0", Offset = "0x5CD9F0", VA = "0x1805CE7F0", Slot = "32")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001862")]
		[Address(RVA = "0x5CEA30", Offset = "0x5CDC30", VA = "0x1805CEA30")]
		public void LoadSaveable(GenericSaveData data)
		{
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001863")]
		[Address(RVA = "0x5CED70", Offset = "0x5CDF70", VA = "0x1805CED70")]
		public GenericSaveablesManager()
		{
		}

		// Token: 0x0400154C RID: 5452
		[Token(Token = "0x400154C")]
		[FieldOffset(Offset = "0x28")]
		protected List<IGenericSaveable> Saveables;

		// Token: 0x0400154D RID: 5453
		[Token(Token = "0x400154D")]
		[FieldOffset(Offset = "0x30")]
		private GenericSaveablesLoader loader;
	}
}
