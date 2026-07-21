using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x02000415 RID: 1045
	[Token(Token = "0x2000415")]
	public class LegacyBotanistLoader : LegacyEmployeeLoader
	{
		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x060019C5 RID: 6597 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004DE")]
		public override string NPCType
		{
			[Token(Token = "0x60019C5")]
			[Address(RVA = "0x5EF510", Offset = "0x5EE710", VA = "0x1805EF510", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019C6")]
		[Address(RVA = "0x5EF500", Offset = "0x5EE700", VA = "0x1805EF500")]
		public LegacyBotanistLoader()
		{
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019C7")]
		[Address(RVA = "0x5EEF70", Offset = "0x5EE170", VA = "0x1805EEF70", Slot = "4")]
		public override void Load(string mainPath)
		{
		}
	}
}
