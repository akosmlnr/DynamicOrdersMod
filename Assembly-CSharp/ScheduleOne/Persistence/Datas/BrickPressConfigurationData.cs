using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000481 RID: 1153
	[Token(Token = "0x2000481")]
	[Serializable]
	public class BrickPressConfigurationData : RenamableConfigurationData
	{
		// Token: 0x06001AD1 RID: 6865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD1")]
		[Address(RVA = "0x602350", Offset = "0x601550", VA = "0x180602350")]
		public BrickPressConfigurationData(StringFieldData name, ObjectFieldData destination)
		{
		}

		// Token: 0x0400168C RID: 5772
		[Token(Token = "0x400168C")]
		[FieldOffset(Offset = "0x30")]
		public ObjectFieldData Destination;
	}
}
