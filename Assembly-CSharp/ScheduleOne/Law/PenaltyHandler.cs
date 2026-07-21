using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.Law
{
	// Token: 0x020005CB RID: 1483
	[Token(Token = "0x20005CB")]
	public static class PenaltyHandler
	{
		// Token: 0x06002207 RID: 8711 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002207")]
		[Address(RVA = "0x67BF60", Offset = "0x67B160", VA = "0x18067BF60")]
		public static List<string> ProcessCrimeList(Dictionary<Crime, int> crimes)
		{
			return null;
		}

		// Token: 0x04001B81 RID: 7041
		[Token(Token = "0x4001B81")]
		public const float CONTROLLED_SUBSTANCE_FINE = 5f;

		// Token: 0x04001B82 RID: 7042
		[Token(Token = "0x4001B82")]
		public const float LOW_SEVERITY_DRUG_FINE = 10f;

		// Token: 0x04001B83 RID: 7043
		[Token(Token = "0x4001B83")]
		public const float MED_SEVERITY_DRUG_FINE = 20f;

		// Token: 0x04001B84 RID: 7044
		[Token(Token = "0x4001B84")]
		public const float HIGH_SEVERITY_DRUG_FINE = 30f;

		// Token: 0x04001B85 RID: 7045
		[Token(Token = "0x4001B85")]
		public const float FAILURE_TO_COMPLY_FINE = 50f;

		// Token: 0x04001B86 RID: 7046
		[Token(Token = "0x4001B86")]
		public const float EVADING_ARREST_FINE = 50f;

		// Token: 0x04001B87 RID: 7047
		[Token(Token = "0x4001B87")]
		public const float VIOLATING_CURFEW_TIME = 100f;

		// Token: 0x04001B88 RID: 7048
		[Token(Token = "0x4001B88")]
		public const float ATTEMPT_TO_SELL_FINE = 150f;

		// Token: 0x04001B89 RID: 7049
		[Token(Token = "0x4001B89")]
		public const float ASSAULT_FINE = 75f;

		// Token: 0x04001B8A RID: 7050
		[Token(Token = "0x4001B8A")]
		public const float DEADLY_ASSAULT_FINE = 150f;

		// Token: 0x04001B8B RID: 7051
		[Token(Token = "0x4001B8B")]
		public const float VANDALISM_FINE = 50f;

		// Token: 0x04001B8C RID: 7052
		[Token(Token = "0x4001B8C")]
		public const float THEFT_FINE = 50f;

		// Token: 0x04001B8D RID: 7053
		[Token(Token = "0x4001B8D")]
		public const float BRANDISHING_FINE = 50f;

		// Token: 0x04001B8E RID: 7054
		[Token(Token = "0x4001B8E")]
		public const float DISCHARGE_FIREARM_FINE = 50f;
	}
}
