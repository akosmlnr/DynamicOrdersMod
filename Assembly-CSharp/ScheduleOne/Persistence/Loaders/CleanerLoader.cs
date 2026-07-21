using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x02000412 RID: 1042
	[Token(Token = "0x2000412")]
	public class CleanerLoader : EmployeeLoader
	{
		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x060019BB RID: 6587 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004DC")]
		public override string NPCType
		{
			[Token(Token = "0x60019BB")]
			[Address(RVA = "0x5EAA30", Offset = "0x5E9C30", VA = "0x1805EAA30", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019BC")]
		[Address(RVA = "0x5E6B60", Offset = "0x5E5D60", VA = "0x1805E6B60")]
		public CleanerLoader()
		{
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019BD")]
		[Address(RVA = "0x5EA720", Offset = "0x5E9920", VA = "0x1805EA720", Slot = "4")]
		public override void Load(DynamicSaveData saveData)
		{
		}
	}
}
