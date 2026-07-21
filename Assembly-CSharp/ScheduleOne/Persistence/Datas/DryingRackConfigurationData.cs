using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000486 RID: 1158
	[Token(Token = "0x2000486")]
	[Serializable]
	public class DryingRackConfigurationData : RenamableConfigurationData
	{
		// Token: 0x06001AD6 RID: 6870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD6")]
		[Address(RVA = "0x6036F0", Offset = "0x6028F0", VA = "0x1806036F0")]
		public DryingRackConfigurationData(StringFieldData name, QualityFieldData targetquality, ObjectFieldData destination, NumberFieldData startThreshold)
		{
		}

		// Token: 0x04001694 RID: 5780
		[Token(Token = "0x4001694")]
		[FieldOffset(Offset = "0x30")]
		public QualityFieldData TargetQuality;

		// Token: 0x04001695 RID: 5781
		[Token(Token = "0x4001695")]
		[FieldOffset(Offset = "0x38")]
		public ObjectFieldData Destination;

		// Token: 0x04001696 RID: 5782
		[Token(Token = "0x4001696")]
		[FieldOffset(Offset = "0x40")]
		public NumberFieldData StartThreshold;
	}
}
