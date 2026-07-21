using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x02000443 RID: 1091
	[Token(Token = "0x2000443")]
	public class MushroomBedLoader : GridItemLoader
	{
		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001A41 RID: 6721 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004F2")]
		public override string ItemType
		{
			[Token(Token = "0x6001A41")]
			[Address(RVA = "0x613BD0", Offset = "0x612DD0", VA = "0x180613BD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A42")]
		[Address(RVA = "0x5EED30", Offset = "0x5EDF30", VA = "0x1805EED30")]
		public MushroomBedLoader()
		{
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A43")]
		[Address(RVA = "0x6138A0", Offset = "0x612AA0", VA = "0x1806138A0", Slot = "7")]
		public override void Load(DynamicSaveData data)
		{
		}
	}
}
