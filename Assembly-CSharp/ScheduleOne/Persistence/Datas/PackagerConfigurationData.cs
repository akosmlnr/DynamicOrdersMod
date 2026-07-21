using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200048F RID: 1167
	[Token(Token = "0x200048F")]
	[Serializable]
	public class PackagerConfigurationData : SaveData
	{
		// Token: 0x06001ADF RID: 6879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ADF")]
		[Address(RVA = "0x6021D0", Offset = "0x6013D0", VA = "0x1806021D0")]
		public PackagerConfigurationData(ObjectFieldData bed, ObjectListFieldData stations, RouteListData routes)
		{
		}

		// Token: 0x040016A4 RID: 5796
		[Token(Token = "0x40016A4")]
		[FieldOffset(Offset = "0x28")]
		public ObjectFieldData Bed;

		// Token: 0x040016A5 RID: 5797
		[Token(Token = "0x40016A5")]
		[FieldOffset(Offset = "0x30")]
		public ObjectListFieldData Stations;

		// Token: 0x040016A6 RID: 5798
		[Token(Token = "0x40016A6")]
		[FieldOffset(Offset = "0x38")]
		public RouteListData Routes;
	}
}
