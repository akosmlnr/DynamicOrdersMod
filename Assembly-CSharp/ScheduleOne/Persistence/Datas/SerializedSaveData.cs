using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004CF RID: 1231
	[Token(Token = "0x20004CF")]
	[Serializable]
	public class SerializedSaveData
	{
		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001B25 RID: 6949 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004FF")]
		public string Version
		{
			[Token(Token = "0x6001B25")]
			[Address(RVA = "0x618030", Offset = "0x617230", VA = "0x180618030")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B26")]
		[Address(RVA = "0x617FC0", Offset = "0x6171C0", VA = "0x180617FC0")]
		public SerializedSaveData()
		{
		}

		// Token: 0x0400175B RID: 5979
		[Token(Token = "0x400175B")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public static string _DataType;

		// Token: 0x0400175C RID: 5980
		[Token(Token = "0x400175C")]
		[FieldOffset(Offset = "0x10")]
		public string DataType;

		// Token: 0x0400175D RID: 5981
		[Token(Token = "0x400175D")]
		[FieldOffset(Offset = "0x8")]
		[NonSerialized]
		public static int _DataVersion;

		// Token: 0x0400175E RID: 5982
		[Token(Token = "0x400175E")]
		[FieldOffset(Offset = "0x18")]
		public int DataVersion;
	}
}
