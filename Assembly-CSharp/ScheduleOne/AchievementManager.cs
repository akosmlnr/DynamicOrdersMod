using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne
{
	// Token: 0x0200028A RID: 650
	[Token(Token = "0x200028A")]
	public static class AchievementManager
	{
		// Token: 0x06000EAD RID: 3757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EAD")]
		[Address(RVA = "0xAE25D0", Offset = "0xAE17D0", VA = "0x180AE25D0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void Init()
		{
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EAE")]
		[Address(RVA = "0xAE2900", Offset = "0xAE1B00", VA = "0x180AE2900")]
		private static void PullAchievements()
		{
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EAF")]
		[Address(RVA = "0xAE2C20", Offset = "0xAE1E20", VA = "0x180AE2C20")]
		public static void UnlockAchievement(AchievementManager.EAchievement achievement)
		{
		}

		// Token: 0x04000D50 RID: 3408
		[Token(Token = "0x4000D50")]
		[FieldOffset(Offset = "0x0")]
		private static AchievementManager.EAchievement[] achievements;

		// Token: 0x04000D51 RID: 3409
		[Token(Token = "0x4000D51")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<AchievementManager.EAchievement, bool> achievementUnlocked;

		// Token: 0x0200028B RID: 651
		[Token(Token = "0x200028B")]
		public enum EAchievement
		{
			// Token: 0x04000D53 RID: 3411
			[Token(Token = "0x4000D53")]
			COMPLETE_PROLOGUE,
			// Token: 0x04000D54 RID: 3412
			[Token(Token = "0x4000D54")]
			RV_DESTROYED,
			// Token: 0x04000D55 RID: 3413
			[Token(Token = "0x4000D55")]
			DEALER_RECRUITED,
			// Token: 0x04000D56 RID: 3414
			[Token(Token = "0x4000D56")]
			MASTER_CHEF,
			// Token: 0x04000D57 RID: 3415
			[Token(Token = "0x4000D57")]
			BUSINESSMAN,
			// Token: 0x04000D58 RID: 3416
			[Token(Token = "0x4000D58")]
			BIGWIG,
			// Token: 0x04000D59 RID: 3417
			[Token(Token = "0x4000D59")]
			MAGNATE,
			// Token: 0x04000D5A RID: 3418
			[Token(Token = "0x4000D5A")]
			UPSTANDING_CITIZEN,
			// Token: 0x04000D5B RID: 3419
			[Token(Token = "0x4000D5B")]
			ROLLING_IN_STYLE,
			// Token: 0x04000D5C RID: 3420
			[Token(Token = "0x4000D5C")]
			LONG_ARM_OF_THE_LAW,
			// Token: 0x04000D5D RID: 3421
			[Token(Token = "0x4000D5D")]
			INDIAN_DEALER,
			// Token: 0x04000D5E RID: 3422
			[Token(Token = "0x4000D5E")]
			URBAN_ARTIST,
			// Token: 0x04000D5F RID: 3423
			[Token(Token = "0x4000D5F")]
			FINISHING_THE_JOB
		}
	}
}
