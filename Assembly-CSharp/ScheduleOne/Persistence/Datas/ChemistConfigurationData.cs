using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000483 RID: 1155
	[Token(Token = "0x2000483")]
	[Serializable]
	public class ChemistConfigurationData : SaveData
	{
		// Token: 0x06001AD3 RID: 6867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD3")]
		[Address(RVA = "0x602350", Offset = "0x601550", VA = "0x180602350")]
		public ChemistConfigurationData(ObjectFieldData bed, ObjectListFieldData stations)
		{
		}

		// Token: 0x0400168E RID: 5774
		[Token(Token = "0x400168E")]
		[FieldOffset(Offset = "0x28")]
		public ObjectFieldData Bed;

		// Token: 0x0400168F RID: 5775
		[Token(Token = "0x400168F")]
		[FieldOffset(Offset = "0x30")]
		public ObjectListFieldData Stations;
	}
}
