using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x0200041D RID: 1053
	[Token(Token = "0x200041D")]
	public class LegacyCleanerLoader : LegacyEmployeeLoader
	{
		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060019D5 RID: 6613 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004E0")]
		public override string NPCType
		{
			[Token(Token = "0x60019D5")]
			[Address(RVA = "0x5F0130", Offset = "0x5EF330", VA = "0x1805F0130", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019D6")]
		[Address(RVA = "0x5EF500", Offset = "0x5EE700", VA = "0x1805EF500")]
		public LegacyCleanerLoader()
		{
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019D7")]
		[Address(RVA = "0x5EFBA0", Offset = "0x5EEDA0", VA = "0x1805EFBA0", Slot = "4")]
		public override void Load(string mainPath)
		{
		}
	}
}
