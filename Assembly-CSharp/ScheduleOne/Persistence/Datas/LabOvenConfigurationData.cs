using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000488 RID: 1160
	[Token(Token = "0x2000488")]
	[Serializable]
	public class LabOvenConfigurationData : RenamableConfigurationData
	{
		// Token: 0x06001AD8 RID: 6872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD8")]
		[Address(RVA = "0x602350", Offset = "0x601550", VA = "0x180602350")]
		public LabOvenConfigurationData(StringFieldData name, ObjectFieldData destination)
		{
		}

		// Token: 0x04001698 RID: 5784
		[Token(Token = "0x4001698")]
		[FieldOffset(Offset = "0x30")]
		public ObjectFieldData Destination;
	}
}
