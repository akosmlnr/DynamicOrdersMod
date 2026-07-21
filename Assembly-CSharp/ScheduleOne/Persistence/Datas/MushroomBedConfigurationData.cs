using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200048A RID: 1162
	[Token(Token = "0x200048A")]
	[Serializable]
	public class MushroomBedConfigurationData : RenamableConfigurationData
	{
		// Token: 0x06001ADA RID: 6874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ADA")]
		[Address(RVA = "0x613680", Offset = "0x612880", VA = "0x180613680")]
		public MushroomBedConfigurationData(StringFieldData name, ItemFieldData spawn, ItemFieldData additive1, ItemFieldData additive2, ItemFieldData additive3, ObjectFieldData destination)
		{
		}

		// Token: 0x0400169B RID: 5787
		[Token(Token = "0x400169B")]
		[FieldOffset(Offset = "0x30")]
		public ItemFieldData Spawn;

		// Token: 0x0400169C RID: 5788
		[Token(Token = "0x400169C")]
		[FieldOffset(Offset = "0x38")]
		public ItemFieldData Additive1;

		// Token: 0x0400169D RID: 5789
		[Token(Token = "0x400169D")]
		[FieldOffset(Offset = "0x40")]
		public ItemFieldData Additive2;

		// Token: 0x0400169E RID: 5790
		[Token(Token = "0x400169E")]
		[FieldOffset(Offset = "0x48")]
		public ItemFieldData Additive3;

		// Token: 0x0400169F RID: 5791
		[Token(Token = "0x400169F")]
		[FieldOffset(Offset = "0x50")]
		public ObjectFieldData Destination;
	}
}
