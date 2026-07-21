using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x0200042A RID: 1066
	[Token(Token = "0x200042A")]
	public class PackagerLoader : EmployeeLoader
	{
		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x060019F3 RID: 6643 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004E5")]
		public override string NPCType
		{
			[Token(Token = "0x60019F3")]
			[Address(RVA = "0x5F3DE0", Offset = "0x5F2FE0", VA = "0x1805F3DE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019F4")]
		[Address(RVA = "0x5E6B60", Offset = "0x5E5D60", VA = "0x1805E6B60")]
		public PackagerLoader()
		{
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019F5")]
		[Address(RVA = "0x5F3AE0", Offset = "0x5F2CE0", VA = "0x1805F3AE0", Slot = "4")]
		public override void Load(DynamicSaveData saveData)
		{
		}
	}
}
