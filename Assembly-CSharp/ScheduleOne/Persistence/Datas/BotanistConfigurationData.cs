using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000480 RID: 1152
	[Token(Token = "0x2000480")]
	[Serializable]
	public class BotanistConfigurationData : SaveData
	{
		// Token: 0x06001AD0 RID: 6864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD0")]
		[Address(RVA = "0x6021D0", Offset = "0x6013D0", VA = "0x1806021D0")]
		public BotanistConfigurationData(ObjectFieldData bed, ObjectFieldData supplies, ObjectListFieldData pots)
		{
		}

		// Token: 0x04001689 RID: 5769
		[Token(Token = "0x4001689")]
		[FieldOffset(Offset = "0x28")]
		public ObjectFieldData Bed;

		// Token: 0x0400168A RID: 5770
		[Token(Token = "0x400168A")]
		[FieldOffset(Offset = "0x30")]
		public ObjectFieldData Supplies;

		// Token: 0x0400168B RID: 5771
		[Token(Token = "0x400168B")]
		[FieldOffset(Offset = "0x38")]
		public ObjectListFieldData Pots;
	}
}
