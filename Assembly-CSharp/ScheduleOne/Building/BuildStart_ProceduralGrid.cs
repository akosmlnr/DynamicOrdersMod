using System;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Building
{
	// Token: 0x020007B5 RID: 1973
	[Token(Token = "0x20007B5")]
	public class BuildStart_ProceduralGrid : BuildStart_Base
	{
		// Token: 0x060034BF RID: 13503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034BF")]
		[Address(RVA = "0x787E70", Offset = "0x787070", VA = "0x180787E70", Slot = "4")]
		public override void StartBuilding(ItemInstance itemInstance)
		{
		}

		// Token: 0x060034C0 RID: 13504 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60034C0")]
		[Address(RVA = "0x787BD0", Offset = "0x786DD0", VA = "0x180787BD0", Slot = "5")]
		protected virtual ProceduralGridItem CreateGhostModel(BuildableItemDefinition itemDefinition)
		{
			return null;
		}

		// Token: 0x060034C1 RID: 13505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C1")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public BuildStart_ProceduralGrid()
		{
		}
	}
}
