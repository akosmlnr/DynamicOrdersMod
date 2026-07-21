using System;
using Il2CppDummyDll;
using ScheduleOne.Growing;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Equipping
{
	// Token: 0x0200094D RID: 2381
	[Token(Token = "0x200094D")]
	public class Equippable_Seed : Equippable_Viewmodel
	{
		// Token: 0x06003FC1 RID: 16321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FC1")]
		[Address(RVA = "0x857DA0", Offset = "0x856FA0", VA = "0x180857DA0", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x06003FC2 RID: 16322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FC2")]
		[Address(RVA = "0x857D40", Offset = "0x856F40", VA = "0x180857D40", Slot = "9")]
		protected virtual void StartSowSeedTask(Pot pot)
		{
		}

		// Token: 0x06003FC3 RID: 16323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FC3")]
		[Address(RVA = "0x858100", Offset = "0x857300", VA = "0x180858100")]
		public Equippable_Seed()
		{
		}

		// Token: 0x04002E6D RID: 11885
		[Token(Token = "0x4002E6D")]
		[FieldOffset(Offset = "0x60")]
		public SeedDefinition Seed;
	}
}
