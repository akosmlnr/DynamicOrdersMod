using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000484 RID: 1156
	[Token(Token = "0x2000484")]
	[Serializable]
	public class ChemistryStationConfigurationData : RenamableConfigurationData
	{
		// Token: 0x06001AD4 RID: 6868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD4")]
		[Address(RVA = "0x6021D0", Offset = "0x6013D0", VA = "0x1806021D0")]
		public ChemistryStationConfigurationData(StringFieldData name, StationRecipeFieldData recipe, ObjectFieldData destination)
		{
		}

		// Token: 0x04001690 RID: 5776
		[Token(Token = "0x4001690")]
		[FieldOffset(Offset = "0x30")]
		public StationRecipeFieldData Recipe;

		// Token: 0x04001691 RID: 5777
		[Token(Token = "0x4001691")]
		[FieldOffset(Offset = "0x38")]
		public ObjectFieldData Destination;
	}
}
