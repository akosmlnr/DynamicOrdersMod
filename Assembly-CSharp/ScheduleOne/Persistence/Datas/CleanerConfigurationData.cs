using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000485 RID: 1157
	[Token(Token = "0x2000485")]
	[Serializable]
	public class CleanerConfigurationData : SaveData
	{
		// Token: 0x06001AD5 RID: 6869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD5")]
		[Address(RVA = "0x602350", Offset = "0x601550", VA = "0x180602350")]
		public CleanerConfigurationData(ObjectFieldData bed, ObjectListFieldData bins)
		{
		}

		// Token: 0x04001692 RID: 5778
		[Token(Token = "0x4001692")]
		[FieldOffset(Offset = "0x28")]
		public ObjectFieldData Bed;

		// Token: 0x04001693 RID: 5779
		[Token(Token = "0x4001693")]
		[FieldOffset(Offset = "0x30")]
		public ObjectListFieldData Bins;
	}
}
