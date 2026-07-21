using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x020003F0 RID: 1008
	[Token(Token = "0x20003F0")]
	public class Loader
	{
		// Token: 0x06001966 RID: 6502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001966")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public Loader()
		{
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001967")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "4")]
		public virtual void Load(string mainPath)
		{
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x0000A0B0 File Offset: 0x000082B0
		[Token(Token = "0x6001968")]
		[Address(RVA = "0x5F1FB0", Offset = "0x5F11B0", VA = "0x1805F1FB0")]
		public bool TryLoadFile(string parentPath, string fileName, out string contents)
		{
			return default(bool);
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x0000A0C8 File Offset: 0x000082C8
		[Token(Token = "0x6001969")]
		[Address(RVA = "0x5F2040", Offset = "0x5F1240", VA = "0x1805F2040")]
		public bool TryLoadFile(string path, out string contents, bool autoAddExtension = true)
		{
			return default(bool);
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600196A")]
		[Address(RVA = "0x5F1C50", Offset = "0x5F0E50", VA = "0x1805F1C50")]
		protected List<DirectoryInfo> GetDirectories(string parentPath)
		{
			return null;
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600196B")]
		[Address(RVA = "0x5F1E00", Offset = "0x5F1000", VA = "0x1805F1E00")]
		protected List<FileInfo> GetFiles(string parenPath)
		{
			return null;
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x0000A0E0 File Offset: 0x000082E0
		[Token(Token = "0x600196C")]
		public static bool TryDeserialize<T>(string json, out T data)
		{
			return default(bool);
		}
	}
}
