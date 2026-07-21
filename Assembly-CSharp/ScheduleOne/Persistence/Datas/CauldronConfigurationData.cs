using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000482 RID: 1154
	[Token(Token = "0x2000482")]
	[Serializable]
	public class CauldronConfigurationData : RenamableConfigurationData
	{
		// Token: 0x06001AD2 RID: 6866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD2")]
		[Address(RVA = "0x602350", Offset = "0x601550", VA = "0x180602350")]
		public CauldronConfigurationData(StringFieldData name, ObjectFieldData destination)
		{
		}

		// Token: 0x0400168D RID: 5773
		[Token(Token = "0x400168D")]
		[FieldOffset(Offset = "0x30")]
		public ObjectFieldData Destination;
	}
}
