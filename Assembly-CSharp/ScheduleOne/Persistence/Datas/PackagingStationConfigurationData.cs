using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000490 RID: 1168
	[Token(Token = "0x2000490")]
	[Serializable]
	public class PackagingStationConfigurationData : RenamableConfigurationData
	{
		// Token: 0x06001AE0 RID: 6880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE0")]
		[Address(RVA = "0x602350", Offset = "0x601550", VA = "0x180602350")]
		public PackagingStationConfigurationData(StringFieldData name, ObjectFieldData destination)
		{
		}

		// Token: 0x040016A7 RID: 5799
		[Token(Token = "0x40016A7")]
		[FieldOffset(Offset = "0x30")]
		public ObjectFieldData Destination;
	}
}
