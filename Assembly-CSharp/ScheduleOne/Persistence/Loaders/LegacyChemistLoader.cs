using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x02000419 RID: 1049
	[Token(Token = "0x2000419")]
	public class LegacyChemistLoader : LegacyEmployeeLoader
	{
		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x060019CD RID: 6605 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004DF")]
		public override string NPCType
		{
			[Token(Token = "0x60019CD")]
			[Address(RVA = "0x5EFB20", Offset = "0x5EED20", VA = "0x1805EFB20", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019CE")]
		[Address(RVA = "0x5EF500", Offset = "0x5EE700", VA = "0x1805EF500")]
		public LegacyChemistLoader()
		{
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019CF")]
		[Address(RVA = "0x5EF590", Offset = "0x5EE790", VA = "0x1805EF590", Slot = "4")]
		public override void Load(string mainPath)
		{
		}
	}
}
