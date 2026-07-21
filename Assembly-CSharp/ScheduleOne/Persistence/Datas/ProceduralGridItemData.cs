using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004B7 RID: 1207
	[Token(Token = "0x20004B7")]
	[Serializable]
	public class ProceduralGridItemData : BuildableItemData
	{
		// Token: 0x06001B09 RID: 6921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B09")]
		[Address(RVA = "0x615B40", Offset = "0x614D40", VA = "0x180615B40")]
		public ProceduralGridItemData(Guid guid, ItemInstance item, int loadOrder, int rotation, FootprintMatchData[] footprintMatches)
		{
		}

		// Token: 0x04001715 RID: 5909
		[Token(Token = "0x4001715")]
		[FieldOffset(Offset = "0x40")]
		public int Rotation;

		// Token: 0x04001716 RID: 5910
		[Token(Token = "0x4001716")]
		[FieldOffset(Offset = "0x48")]
		public FootprintMatchData[] FootprintMatches;
	}
}
