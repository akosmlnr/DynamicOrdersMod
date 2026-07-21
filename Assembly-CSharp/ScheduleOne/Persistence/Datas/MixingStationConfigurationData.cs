using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000489 RID: 1161
	[Token(Token = "0x2000489")]
	[Serializable]
	public class MixingStationConfigurationData : RenamableConfigurationData
	{
		// Token: 0x06001AD9 RID: 6873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD9")]
		[Address(RVA = "0x6021D0", Offset = "0x6013D0", VA = "0x1806021D0")]
		public MixingStationConfigurationData(StringFieldData name, ObjectFieldData destination, NumberFieldData threshold)
		{
		}

		// Token: 0x04001699 RID: 5785
		[Token(Token = "0x4001699")]
		[FieldOffset(Offset = "0x30")]
		public ObjectFieldData Destination;

		// Token: 0x0400169A RID: 5786
		[Token(Token = "0x400169A")]
		[FieldOffset(Offset = "0x38")]
		public NumberFieldData Threshold;
	}
}
