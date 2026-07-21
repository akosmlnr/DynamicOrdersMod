using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000493 RID: 1171
	[Token(Token = "0x2000493")]
	[Serializable]
	public class RenamableConfigurationData : SaveData
	{
		// Token: 0x06001AE3 RID: 6883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE3")]
		[Address(RVA = "0x602190", Offset = "0x601390", VA = "0x180602190")]
		public RenamableConfigurationData(StringFieldData name)
		{
		}

		// Token: 0x040016AE RID: 5806
		[Token(Token = "0x40016AE")]
		[FieldOffset(Offset = "0x28")]
		public StringFieldData Name;
	}
}
