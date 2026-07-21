using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Temperature;

namespace ScheduleOne.Building
{
	// Token: 0x020007B2 RID: 1970
	[Token(Token = "0x20007B2")]
	public class BuildStart_AirConditioner : BuildStart_Grid
	{
		// Token: 0x060034B5 RID: 13493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034B5")]
		[Address(RVA = "0x786F70", Offset = "0x786170", VA = "0x180786F70", Slot = "4")]
		public override void StartBuilding(ItemInstance itemInstance)
		{
		}

		// Token: 0x060034B6 RID: 13494 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60034B6")]
		[Address(RVA = "0x786F40", Offset = "0x786140", VA = "0x180786F40", Slot = "5")]
		protected override string GetInputPromptsModuleName()
		{
			return null;
		}

		// Token: 0x060034B7 RID: 13495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034B7")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public BuildStart_AirConditioner()
		{
		}

		// Token: 0x0400266C RID: 9836
		[Token(Token = "0x400266C")]
		[FieldOffset(Offset = "0x28")]
		private AirConditioner ac;
	}
}
