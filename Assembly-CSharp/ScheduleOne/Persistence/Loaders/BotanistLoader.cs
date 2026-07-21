using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x0200040E RID: 1038
	[Token(Token = "0x200040E")]
	public class BotanistLoader : EmployeeLoader
	{
		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x060019AF RID: 6575 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004DA")]
		public override string NPCType
		{
			[Token(Token = "0x60019AF")]
			[Address(RVA = "0x5E6B70", Offset = "0x5E5D70", VA = "0x1805E6B70", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019B0")]
		[Address(RVA = "0x5E6B60", Offset = "0x5E5D60", VA = "0x1805E6B60")]
		public BotanistLoader()
		{
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019B1")]
		[Address(RVA = "0x5E6850", Offset = "0x5E5A50", VA = "0x1805E6850", Slot = "4")]
		public override void Load(DynamicSaveData saveData)
		{
		}
	}
}
