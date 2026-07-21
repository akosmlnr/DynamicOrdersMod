using System;
using Il2CppDummyDll;
using ScheduleOne.Equipping;
using ScheduleOne.Growing;

namespace ScheduleOne.ObjectScripts.Soil
{
	// Token: 0x020009E0 RID: 2528
	[Token(Token = "0x20009E0")]
	public class Equippable_Soil : Equippable_Pourable
	{
		// Token: 0x06004881 RID: 18561 RVA: 0x00013A10 File Offset: 0x00011C10
		[Token(Token = "0x6004881")]
		[Address(RVA = "0x8F4D50", Offset = "0x8F3F50", VA = "0x1808F4D50", Slot = "11")]
		protected override bool CanPour(GrowContainer growContainer, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06004882 RID: 18562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004882")]
		[Address(RVA = "0x8F4F20", Offset = "0x8F4120", VA = "0x1808F4F20", Slot = "10")]
		protected override void StartPourTask(GrowContainer growContainer)
		{
		}

		// Token: 0x06004883 RID: 18563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004883")]
		[Address(RVA = "0x851620", Offset = "0x850820", VA = "0x180851620")]
		public Equippable_Soil()
		{
		}
	}
}
