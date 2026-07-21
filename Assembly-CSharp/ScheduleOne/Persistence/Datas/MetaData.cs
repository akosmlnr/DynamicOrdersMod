using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000499 RID: 1177
	[Token(Token = "0x2000499")]
	[Serializable]
	public class MetaData : SaveData
	{
		// Token: 0x06001AE9 RID: 6889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE9")]
		[Address(RVA = "0x613000", Offset = "0x612200", VA = "0x180613000")]
		public MetaData(DateTimeData creationDate, DateTimeData lastPlayedDate, string creationVersion, string lastSaveVersion, bool playTutorial)
		{
		}

		// Token: 0x040016B6 RID: 5814
		[Token(Token = "0x40016B6")]
		[FieldOffset(Offset = "0x28")]
		public DateTimeData CreationDate;

		// Token: 0x040016B7 RID: 5815
		[Token(Token = "0x40016B7")]
		[FieldOffset(Offset = "0x30")]
		public DateTimeData LastPlayedDate;

		// Token: 0x040016B8 RID: 5816
		[Token(Token = "0x40016B8")]
		[FieldOffset(Offset = "0x38")]
		public string CreationVersion;

		// Token: 0x040016B9 RID: 5817
		[Token(Token = "0x40016B9")]
		[FieldOffset(Offset = "0x40")]
		public string LastSaveVersion;

		// Token: 0x040016BA RID: 5818
		[Token(Token = "0x40016BA")]
		[FieldOffset(Offset = "0x48")]
		public bool PlayTutorial;
	}
}
