using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence
{
	// Token: 0x020003DF RID: 991
	[Token(Token = "0x20003DF")]
	public class SaveInfo
	{
		// Token: 0x06001900 RID: 6400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001900")]
		[Address(RVA = "0x5F8360", Offset = "0x5F7560", VA = "0x1805F8360")]
		public SaveInfo(string savePath, int saveSlotNumber, string organisationName, DateTime dateCreated, DateTime dateLastPlayed, float networth, string saveVersion, MetaData metaData)
		{
		}

		// Token: 0x040015B2 RID: 5554
		[Token(Token = "0x40015B2")]
		[FieldOffset(Offset = "0x10")]
		public string SavePath;

		// Token: 0x040015B3 RID: 5555
		[Token(Token = "0x40015B3")]
		[FieldOffset(Offset = "0x18")]
		public int SaveSlotNumber;

		// Token: 0x040015B4 RID: 5556
		[Token(Token = "0x40015B4")]
		[FieldOffset(Offset = "0x20")]
		public string OrganisationName;

		// Token: 0x040015B5 RID: 5557
		[Token(Token = "0x40015B5")]
		[FieldOffset(Offset = "0x28")]
		public DateTime DateCreated;

		// Token: 0x040015B6 RID: 5558
		[Token(Token = "0x40015B6")]
		[FieldOffset(Offset = "0x30")]
		public DateTime DateLastPlayed;

		// Token: 0x040015B7 RID: 5559
		[Token(Token = "0x40015B7")]
		[FieldOffset(Offset = "0x38")]
		public float Networth;

		// Token: 0x040015B8 RID: 5560
		[Token(Token = "0x40015B8")]
		[FieldOffset(Offset = "0x40")]
		public string SaveVersion;

		// Token: 0x040015B9 RID: 5561
		[Token(Token = "0x40015B9")]
		[FieldOffset(Offset = "0x48")]
		public MetaData MetaData;
	}
}
