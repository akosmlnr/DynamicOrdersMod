using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004CE RID: 1230
	[Token(Token = "0x20004CE")]
	[Serializable]
	public class SaveData
	{
		// Token: 0x06001B22 RID: 6946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B22")]
		[Address(RVA = "0x617EC0", Offset = "0x6170C0", VA = "0x180617EC0")]
		public SaveData()
		{
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x0000A338 File Offset: 0x00008538
		[Token(Token = "0x6001B23")]
		[Address(RVA = "0x490CA0", Offset = "0x48FEA0", VA = "0x180490CA0", Slot = "4")]
		protected virtual int GetDataVersion()
		{
			return 0;
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001B24")]
		[Address(RVA = "0x617DD0", Offset = "0x616FD0", VA = "0x180617DD0", Slot = "5")]
		public virtual string GetJson(bool prettyPrint = true)
		{
			return null;
		}

		// Token: 0x04001758 RID: 5976
		[Token(Token = "0x4001758")]
		[FieldOffset(Offset = "0x10")]
		public string DataType;

		// Token: 0x04001759 RID: 5977
		[Token(Token = "0x4001759")]
		[FieldOffset(Offset = "0x18")]
		public int DataVersion;

		// Token: 0x0400175A RID: 5978
		[Token(Token = "0x400175A")]
		[FieldOffset(Offset = "0x20")]
		public string GameVersion;
	}
}
