using System;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x02000414 RID: 1044
	[Token(Token = "0x2000414")]
	public class EmployeeLoader : NPCLoader
	{
		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x060019C1 RID: 6593 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004DD")]
		public override string NPCType
		{
			[Token(Token = "0x60019C1")]
			[Address(RVA = "0x5EC600", Offset = "0x5EB800", VA = "0x1805EC600", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019C2")]
		[Address(RVA = "0x5E6B60", Offset = "0x5E5D60", VA = "0x1805E6B60")]
		public EmployeeLoader()
		{
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019C3")]
		[Address(RVA = "0x5EC5C0", Offset = "0x5EB7C0", VA = "0x1805EC5C0", Slot = "4")]
		public override void Load(DynamicSaveData saveData)
		{
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60019C4")]
		[Address(RVA = "0x5EC0D0", Offset = "0x5EB2D0", VA = "0x1805EC0D0", Slot = "6")]
		protected virtual Employee CreateAndLoadEmployee(DynamicSaveData saveData)
		{
			return null;
		}
	}
}
