using System;
using Il2CppDummyDll;
using ScheduleOne.Economy;
using ScheduleOne.Map;

namespace ScheduleOne.Cartel
{
	// Token: 0x0200078D RID: 1933
	[Token(Token = "0x200078D")]
	public class RobDealer : CartelActivity
	{
		// Token: 0x06003372 RID: 13170 RVA: 0x0000FA38 File Offset: 0x0000DC38
		[Token(Token = "0x6003372")]
		[Address(RVA = "0x79D910", Offset = "0x79CB10", VA = "0x18079D910", Slot = "8")]
		public override bool IsRegionValidForActivity(EMapRegion region)
		{
			return default(bool);
		}

		// Token: 0x06003373 RID: 13171 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003373")]
		[Address(RVA = "0x79D6C0", Offset = "0x79C8C0", VA = "0x18079D6C0")]
		private Dealer GetDealerToRob(EMapRegion region)
		{
			return null;
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003374")]
		[Address(RVA = "0x79D610", Offset = "0x79C810", VA = "0x18079D610", Slot = "4")]
		public override void Activate(EMapRegion region)
		{
		}

		// Token: 0x06003375 RID: 13173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003375")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public RobDealer()
		{
		}
	}
}
