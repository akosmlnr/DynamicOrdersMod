using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000491 RID: 1169
	[Token(Token = "0x2000491")]
	[Serializable]
	public class PotConfigurationData : RenamableConfigurationData
	{
		// Token: 0x06001AE1 RID: 6881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE1")]
		[Address(RVA = "0x613680", Offset = "0x612880", VA = "0x180613680")]
		public PotConfigurationData(StringFieldData name, ItemFieldData seed, ItemFieldData additive1, ItemFieldData additive2, ItemFieldData additive3, ObjectFieldData destination)
		{
		}

		// Token: 0x040016A8 RID: 5800
		[Token(Token = "0x40016A8")]
		[FieldOffset(Offset = "0x30")]
		public ItemFieldData Seed;

		// Token: 0x040016A9 RID: 5801
		[Token(Token = "0x40016A9")]
		[FieldOffset(Offset = "0x38")]
		public ItemFieldData Additive1;

		// Token: 0x040016AA RID: 5802
		[Token(Token = "0x40016AA")]
		[FieldOffset(Offset = "0x40")]
		public ItemFieldData Additive2;

		// Token: 0x040016AB RID: 5803
		[Token(Token = "0x40016AB")]
		[FieldOffset(Offset = "0x48")]
		public ItemFieldData Additive3;

		// Token: 0x040016AC RID: 5804
		[Token(Token = "0x40016AC")]
		[FieldOffset(Offset = "0x50")]
		public ObjectFieldData Destination;
	}
}
