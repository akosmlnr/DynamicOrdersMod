using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Loaders;

namespace ScheduleOne.Persistence
{
	// Token: 0x020003C7 RID: 967
	[Token(Token = "0x20003C7")]
	public interface ISaveable
	{
		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x0600186B RID: 6251
		[Token(Token = "0x170004AC")]
		string SaveFolderName
		{
			[Token(Token = "0x600186B")]
			get;
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x0600186C RID: 6252
		[Token(Token = "0x170004AD")]
		string SaveFileName
		{
			[Token(Token = "0x600186C")]
			get;
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x0600186D RID: 6253
		[Token(Token = "0x170004AE")]
		Loader Loader
		{
			[Token(Token = "0x600186D")]
			get;
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x0600186E RID: 6254
		[Token(Token = "0x170004AF")]
		bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x600186E")]
			get;
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x0600186F RID: 6255
		// (set) Token: 0x06001870 RID: 6256
		[Token(Token = "0x170004B0")]
		List<string> LocalExtraFiles
		{
			[Token(Token = "0x600186F")]
			get;
			[Token(Token = "0x6001870")]
			set;
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06001871 RID: 6257
		// (set) Token: 0x06001872 RID: 6258
		[Token(Token = "0x170004B1")]
		List<string> LocalExtraFolders
		{
			[Token(Token = "0x6001871")]
			get;
			[Token(Token = "0x6001872")]
			set;
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001873 RID: 6259
		// (set) Token: 0x06001874 RID: 6260
		[Token(Token = "0x170004B2")]
		bool HasChanged
		{
			[Token(Token = "0x6001873")]
			get;
			[Token(Token = "0x6001874")]
			set;
		}

		// Token: 0x06001875 RID: 6261
		[Token(Token = "0x6001875")]
		void InitializeSaveable();

		// Token: 0x06001876 RID: 6262
		[Token(Token = "0x6001876")]
		string GetSaveString();

		// Token: 0x06001877 RID: 6263 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001877")]
		[Address(RVA = "0x5CFC30", Offset = "0x5CEE30", VA = "0x1805CFC30", Slot = "12")]
		string Save(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001878")]
		[Address(RVA = "0x5D0080", Offset = "0x5CF280", VA = "0x1805D0080", Slot = "13")]
		void WriteBaseData(string parentFolderPath, string saveString)
		{
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001879")]
		[Address(RVA = "0x5CFB70", Offset = "0x5CED70", VA = "0x1805CFB70", Slot = "14")]
		string GetLocalPath(out bool isFolder)
		{
			return null;
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600187A")]
		[Address(RVA = "0x5CF0C0", Offset = "0x5CE2C0", VA = "0x1805CF0C0", Slot = "15")]
		void CompleteSave(string parentFolderPath, bool writeDataFile)
		{
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600187B")]
		[Address(RVA = "0x5D0420", Offset = "0x5CF620", VA = "0x1805D0420", Slot = "16")]
		List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600187C")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "17")]
		void DeleteUnapprovedFiles(string parentFolderPath)
		{
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600187D")]
		[Address(RVA = "0x5CFA20", Offset = "0x5CEC20", VA = "0x1805CFA20", Slot = "18")]
		string GetContainerFolder(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600187E")]
		[Address(RVA = "0x5D08C0", Offset = "0x5CFAC0", VA = "0x1805D08C0", Slot = "19")]
		string WriteSubfile(string parentPath, string localPath_NoExtensions, string contents)
		{
			return null;
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600187F")]
		[Address(RVA = "0x5D0480", Offset = "0x5CF680", VA = "0x1805D0480", Slot = "20")]
		string WriteFolder(string parentPath, string localPath_NoExtensions)
		{
			return null;
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x00009C30 File Offset: 0x00007E30
		[Token(Token = "0x6001880")]
		[Address(RVA = "0x5CFF70", Offset = "0x5CF170", VA = "0x1805CFF70", Slot = "21")]
		bool TryLoadFile(string parentPath, string fileName, out string contents)
		{
			return default(bool);
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x00009C48 File Offset: 0x00007E48
		[Token(Token = "0x6001881")]
		[Address(RVA = "0x5CFD90", Offset = "0x5CEF90", VA = "0x1805CFD90", Slot = "22")]
		bool TryLoadFile(string path, out string contents, bool autoAddExtension = true)
		{
			return default(bool);
		}
	}
}
