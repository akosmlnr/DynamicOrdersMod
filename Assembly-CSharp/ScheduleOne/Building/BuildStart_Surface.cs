using System;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Building
{
	// Token: 0x020007B6 RID: 1974
	[Token(Token = "0x20007B6")]
	public class BuildStart_Surface : BuildStart_Base
	{
		// Token: 0x060034C2 RID: 13506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C2")]
		[Address(RVA = "0x788510", Offset = "0x787710", VA = "0x180788510", Slot = "4")]
		public override void StartBuilding(ItemInstance itemInstance)
		{
		}

		// Token: 0x060034C3 RID: 13507 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60034C3")]
		[Address(RVA = "0x7881B0", Offset = "0x7873B0", VA = "0x1807881B0", Slot = "5")]
		protected virtual SurfaceItem CreateGhostModel(BuildableItemDefinition itemDefinition)
		{
			return null;
		}

		// Token: 0x060034C4 RID: 13508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C4")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public BuildStart_Surface()
		{
		}
	}
}
