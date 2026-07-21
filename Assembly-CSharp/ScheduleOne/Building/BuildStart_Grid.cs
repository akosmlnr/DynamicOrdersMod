using System;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Building
{
	// Token: 0x020007B4 RID: 1972
	[Token(Token = "0x20007B4")]
	public class BuildStart_Grid : BuildStart_Base
	{
		// Token: 0x060034BB RID: 13499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034BB")]
		[Address(RVA = "0x787910", Offset = "0x786B10", VA = "0x180787910", Slot = "4")]
		public override void StartBuilding(ItemInstance itemInstance)
		{
		}

		// Token: 0x060034BC RID: 13500 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60034BC")]
		[Address(RVA = "0x787880", Offset = "0x786A80", VA = "0x180787880", Slot = "5")]
		protected virtual string GetInputPromptsModuleName()
		{
			return null;
		}

		// Token: 0x060034BD RID: 13501 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60034BD")]
		[Address(RVA = "0x7873D0", Offset = "0x7865D0", VA = "0x1807873D0", Slot = "6")]
		protected virtual GridItem CreateGhostModel(BuildableItemDefinition itemDefinition)
		{
			return null;
		}

		// Token: 0x060034BE RID: 13502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034BE")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public BuildStart_Grid()
		{
		}

		// Token: 0x0400266D RID: 9837
		[Token(Token = "0x400266D")]
		[FieldOffset(Offset = "0x20")]
		protected GridItem ghostModelClass;
	}
}
