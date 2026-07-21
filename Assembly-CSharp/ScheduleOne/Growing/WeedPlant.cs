using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Growing
{
	// Token: 0x020008C5 RID: 2245
	[Token(Token = "0x20008C5")]
	public class WeedPlant : Plant
	{
		// Token: 0x06003BA6 RID: 15270 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003BA6")]
		[Address(RVA = "0x829D40", Offset = "0x828F40", VA = "0x180829D40", Slot = "9")]
		public override ItemInstance GetHarvestedProduct(int quantity = 1)
		{
			return null;
		}

		// Token: 0x06003BA7 RID: 15271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BA7")]
		[Address(RVA = "0x819D90", Offset = "0x818F90", VA = "0x180819D90")]
		public WeedPlant()
		{
		}

		// Token: 0x04002C00 RID: 11264
		[Token(Token = "0x4002C00")]
		[FieldOffset(Offset = "0xA8")]
		public PlantHarvestable BranchPrefab;
	}
}
