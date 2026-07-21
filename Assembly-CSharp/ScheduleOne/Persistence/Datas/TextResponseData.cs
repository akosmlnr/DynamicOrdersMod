using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004D6 RID: 1238
	[Token(Token = "0x20004D6")]
	[Serializable]
	public class TextResponseData
	{
		// Token: 0x06001B2E RID: 6958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B2E")]
		[Address(RVA = "0x5FCA60", Offset = "0x5FBC60", VA = "0x1805FCA60")]
		public TextResponseData(string text, string label)
		{
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B2F")]
		[Address(RVA = "0x619DA0", Offset = "0x618FA0", VA = "0x180619DA0")]
		public TextResponseData()
		{
		}

		// Token: 0x04001774 RID: 6004
		[Token(Token = "0x4001774")]
		[FieldOffset(Offset = "0x10")]
		public string Text;

		// Token: 0x04001775 RID: 6005
		[Token(Token = "0x4001775")]
		[FieldOffset(Offset = "0x18")]
		public string Label;
	}
}
