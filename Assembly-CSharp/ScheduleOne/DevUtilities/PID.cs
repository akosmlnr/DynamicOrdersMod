using System;
using Il2CppDummyDll;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A0A RID: 2570
	[Token(Token = "0x2000A0A")]
	[Serializable]
	public class PID
	{
		// Token: 0x06004976 RID: 18806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004976")]
		[Address(RVA = "0x90A3B0", Offset = "0x9095B0", VA = "0x18090A3B0")]
		public PID(float pFactor, float iFactor, float dFactor)
		{
		}

		// Token: 0x06004977 RID: 18807 RVA: 0x00013F68 File Offset: 0x00012168
		[Token(Token = "0x6004977")]
		[Address(RVA = "0x90A370", Offset = "0x909570", VA = "0x18090A370")]
		public float Update(float setpoint, float actual, float timeFrame)
		{
			return 0f;
		}

		// Token: 0x040033EA RID: 13290
		[Token(Token = "0x40033EA")]
		[FieldOffset(Offset = "0x10")]
		public float pFactor;

		// Token: 0x040033EB RID: 13291
		[Token(Token = "0x40033EB")]
		[FieldOffset(Offset = "0x14")]
		public float iFactor;

		// Token: 0x040033EC RID: 13292
		[Token(Token = "0x40033EC")]
		[FieldOffset(Offset = "0x18")]
		public float dFactor;

		// Token: 0x040033ED RID: 13293
		[Token(Token = "0x40033ED")]
		[FieldOffset(Offset = "0x1C")]
		private float integral;

		// Token: 0x040033EE RID: 13294
		[Token(Token = "0x40033EE")]
		[FieldOffset(Offset = "0x20")]
		private float lastError;
	}
}
