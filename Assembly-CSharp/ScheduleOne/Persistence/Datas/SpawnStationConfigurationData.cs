using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000495 RID: 1173
	[Token(Token = "0x2000495")]
	[Serializable]
	public class SpawnStationConfigurationData : RenamableConfigurationData
	{
		// Token: 0x06001AE5 RID: 6885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE5")]
		[Address(RVA = "0x602350", Offset = "0x601550", VA = "0x180602350")]
		public SpawnStationConfigurationData(StringFieldData name, ObjectFieldData destination)
		{
		}

		// Token: 0x040016B0 RID: 5808
		[Token(Token = "0x40016B0")]
		[FieldOffset(Offset = "0x30")]
		public ObjectFieldData Destination;
	}
}
