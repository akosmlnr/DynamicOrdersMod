using System;
using Il2CppDummyDll;
using ScheduleOne.Employees;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x02000421 RID: 1057
	[Token(Token = "0x2000421")]
	public class LegacyEmployeeLoader : LegacyNPCLoader
	{
		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060019DD RID: 6621 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004E1")]
		public override string NPCType
		{
			[Token(Token = "0x60019DD")]
			[Address(RVA = "0x5F0720", Offset = "0x5EF920", VA = "0x1805F0720", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019DE")]
		[Address(RVA = "0x5EF500", Offset = "0x5EE700", VA = "0x1805EF500")]
		public LegacyEmployeeLoader()
		{
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60019DF")]
		[Address(RVA = "0x5F01B0", Offset = "0x5EF3B0", VA = "0x1805F01B0")]
		public Employee LoadAndCreateEmployee(string mainPath)
		{
			return null;
		}
	}
}
