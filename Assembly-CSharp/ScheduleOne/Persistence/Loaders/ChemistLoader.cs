using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x02000410 RID: 1040
	[Token(Token = "0x2000410")]
	public class ChemistLoader : EmployeeLoader
	{
		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x060019B5 RID: 6581 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004DB")]
		public override string NPCType
		{
			[Token(Token = "0x60019B5")]
			[Address(RVA = "0x5E9A30", Offset = "0x5E8C30", VA = "0x1805E9A30", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019B6")]
		[Address(RVA = "0x5E6B60", Offset = "0x5E5D60", VA = "0x1805E6B60")]
		public ChemistLoader()
		{
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019B7")]
		[Address(RVA = "0x5E9720", Offset = "0x5E8920", VA = "0x1805E9720", Slot = "4")]
		public override void Load(DynamicSaveData saveData)
		{
		}
	}
}
