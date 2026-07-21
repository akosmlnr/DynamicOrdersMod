using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x02000434 RID: 1076
	[Token(Token = "0x2000434")]
	public class ChemistryStationLoader : GridItemLoader
	{
		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06001A13 RID: 6675 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004EB")]
		public override string ItemType
		{
			[Token(Token = "0x6001A13")]
			[Address(RVA = "0x5EA6A0", Offset = "0x5E98A0", VA = "0x1805EA6A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A14")]
		[Address(RVA = "0x5E67C0", Offset = "0x5E59C0", VA = "0x1805E67C0")]
		public ChemistryStationLoader()
		{
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A15")]
		[Address(RVA = "0x5E9AB0", Offset = "0x5E8CB0", VA = "0x1805E9AB0", Slot = "4")]
		public override void Load(string mainPath)
		{
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A16")]
		[Address(RVA = "0x5E9F90", Offset = "0x5E9190", VA = "0x1805E9F90", Slot = "7")]
		public override void Load(DynamicSaveData data)
		{
		}
	}
}
