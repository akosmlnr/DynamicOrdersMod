using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x02000422 RID: 1058
	[Token(Token = "0x2000422")]
	public class LegacyNPCLoader : Loader
	{
		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060019E0 RID: 6624 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004E2")]
		public virtual string NPCType
		{
			[Token(Token = "0x60019E0")]
			[Address(RVA = "0x5F13E0", Offset = "0x5F05E0", VA = "0x1805F13E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019E1")]
		[Address(RVA = "0x5F12E0", Offset = "0x5F04E0", VA = "0x1805F12E0")]
		public LegacyNPCLoader()
		{
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019E2")]
		[Address(RVA = "0x5F07A0", Offset = "0x5EF9A0", VA = "0x1805F07A0", Slot = "4")]
		public override void Load(string mainPath)
		{
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019E3")]
		[Address(RVA = "0x5F11D0", Offset = "0x5F03D0", VA = "0x1805F11D0")]
		protected void TryLoadInventory(string mainPath, NPC npc)
		{
		}
	}
}
