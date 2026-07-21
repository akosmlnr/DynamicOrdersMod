using System;
using Il2CppDummyDll;
using ScheduleOne.Map;

namespace ScheduleOne.Cartel
{
	// Token: 0x0200078C RID: 1932
	[Token(Token = "0x200078C")]
	public class CartelCustomerDeal : CartelActivity
	{
		// Token: 0x0600336C RID: 13164 RVA: 0x0000FA20 File Offset: 0x0000DC20
		[Token(Token = "0x600336C")]
		[Address(RVA = "0x790DF0", Offset = "0x78FFF0", VA = "0x180790DF0", Slot = "8")]
		public override bool IsRegionValidForActivity(EMapRegion region)
		{
			return default(bool);
		}

		// Token: 0x0600336D RID: 13165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600336D")]
		[Address(RVA = "0x7908D0", Offset = "0x78FAD0", VA = "0x1807908D0", Slot = "4")]
		public override void Activate(EMapRegion region)
		{
		}

		// Token: 0x0600336E RID: 13166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600336E")]
		[Address(RVA = "0x790F90", Offset = "0x790190", VA = "0x180790F90", Slot = "5")]
		protected override void MinPassed()
		{
		}

		// Token: 0x0600336F RID: 13167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600336F")]
		[Address(RVA = "0x790C90", Offset = "0x78FE90", VA = "0x180790C90", Slot = "7")]
		protected override void Deactivate()
		{
		}

		// Token: 0x06003370 RID: 13168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003370")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void DealerUnconscious()
		{
		}

		// Token: 0x06003371 RID: 13169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003371")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public CartelCustomerDeal()
		{
		}

		// Token: 0x040025C1 RID: 9665
		[Token(Token = "0x40025C1")]
		public const int TIMEOUT_MINUTES = 720;

		// Token: 0x040025C2 RID: 9666
		[Token(Token = "0x40025C2")]
		[FieldOffset(Offset = "0x40")]
		private CartelDealer dealer;
	}
}
