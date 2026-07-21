using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004DD RID: 1245
	[Token(Token = "0x20004DD")]
	[Serializable]
	public class VariableData : SaveData
	{
		// Token: 0x06001B36 RID: 6966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B36")]
		[Address(RVA = "0x602350", Offset = "0x601550", VA = "0x180602350")]
		public VariableData(string name, string value)
		{
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B37")]
		[Address(RVA = "0x61CE50", Offset = "0x61C050", VA = "0x18061CE50")]
		public VariableData()
		{
		}

		// Token: 0x04001784 RID: 6020
		[Token(Token = "0x4001784")]
		[FieldOffset(Offset = "0x28")]
		public string Name;

		// Token: 0x04001785 RID: 6021
		[Token(Token = "0x4001785")]
		[FieldOffset(Offset = "0x30")]
		public string Value;
	}
}
