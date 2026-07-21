using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x0200044F RID: 1103
	[Token(Token = "0x200044F")]
	public class SpawnStationLoader : GridItemLoader
	{
		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001A67 RID: 6759 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004F9")]
		public override string ItemType
		{
			[Token(Token = "0x6001A67")]
			[Address(RVA = "0x618C80", Offset = "0x617E80", VA = "0x180618C80", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A68")]
		[Address(RVA = "0x5EED30", Offset = "0x5EDF30", VA = "0x1805EED30")]
		public SpawnStationLoader()
		{
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A69")]
		[Address(RVA = "0x618940", Offset = "0x617B40", VA = "0x180618940", Slot = "7")]
		public override void Load(DynamicSaveData data)
		{
		}
	}
}
