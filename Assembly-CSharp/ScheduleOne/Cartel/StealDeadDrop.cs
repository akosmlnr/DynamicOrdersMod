using System;
using Il2CppDummyDll;
using ScheduleOne.Economy;
using ScheduleOne.ItemFramework;
using ScheduleOne.Map;

namespace ScheduleOne.Cartel
{
	// Token: 0x02000791 RID: 1937
	[Token(Token = "0x2000791")]
	public class StealDeadDrop : CartelActivity
	{
		// Token: 0x0600337E RID: 13182 RVA: 0x0000FA98 File Offset: 0x0000DC98
		[Token(Token = "0x600337E")]
		[Address(RVA = "0x79E810", Offset = "0x79DA10", VA = "0x18079E810", Slot = "8")]
		public override bool IsRegionValidForActivity(EMapRegion region)
		{
			return default(bool);
		}

		// Token: 0x0600337F RID: 13183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600337F")]
		[Address(RVA = "0x79E270", Offset = "0x79D470", VA = "0x18079E270", Slot = "4")]
		public override void Activate(EMapRegion region)
		{
		}

		// Token: 0x06003380 RID: 13184 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003380")]
		[Address(RVA = "0x79E3F0", Offset = "0x79D5F0", VA = "0x18079E3F0")]
		private static DeadDrop GetRandomDropToStealFrom(EMapRegion region)
		{
			return null;
		}

		// Token: 0x06003381 RID: 13185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003381")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public StealDeadDrop()
		{
		}

		// Token: 0x040025C7 RID: 9671
		[Token(Token = "0x40025C7")]
		public const int MIN_TIME_SINCE_CONTENTS_CHANGED = 360;

		// Token: 0x040025C8 RID: 9672
		[Token(Token = "0x40025C8")]
		[FieldOffset(Offset = "0x40")]
		public ItemDefinition[] ItemsToLeave;
	}
}
