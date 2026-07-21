using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x02000424 RID: 1060
	[Token(Token = "0x2000424")]
	public class LegacyPackagerLoader : LegacyEmployeeLoader
	{
		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060019E6 RID: 6630 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004E3")]
		public override string NPCType
		{
			[Token(Token = "0x60019E6")]
			[Address(RVA = "0x5F19F0", Offset = "0x5F0BF0", VA = "0x1805F19F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019E7")]
		[Address(RVA = "0x5EF500", Offset = "0x5EE700", VA = "0x1805EF500")]
		public LegacyPackagerLoader()
		{
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019E8")]
		[Address(RVA = "0x5F1460", Offset = "0x5F0660", VA = "0x1805F1460", Slot = "4")]
		public override void Load(string mainPath)
		{
		}
	}
}
