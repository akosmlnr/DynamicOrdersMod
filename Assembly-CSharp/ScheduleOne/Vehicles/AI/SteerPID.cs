using System;
using Il2CppDummyDll;

namespace ScheduleOne.Vehicles.AI
{
	// Token: 0x020002C9 RID: 713
	[Token(Token = "0x20002C9")]
	public class SteerPID
	{
		// Token: 0x060010A7 RID: 4263 RVA: 0x00007DB8 File Offset: 0x00005FB8
		[Token(Token = "0x60010A7")]
		[Address(RVA = "0xB04C30", Offset = "0xB03E30", VA = "0x180B04C30")]
		public float GetNewValue(float error, PID_Parameters pid_parameters)
		{
			return 0f;
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x00007DD0 File Offset: 0x00005FD0
		[Token(Token = "0x60010A8")]
		[Address(RVA = "0xB04C10", Offset = "0xB03E10", VA = "0x180B04C10")]
		public static float AddValueToAverage(float oldAverage, float valueToAdd, float count)
		{
			return 0f;
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010A9")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public SteerPID()
		{
		}

		// Token: 0x04000F0E RID: 3854
		[Token(Token = "0x4000F0E")]
		[FieldOffset(Offset = "0x10")]
		private float error_old;

		// Token: 0x04000F0F RID: 3855
		[Token(Token = "0x4000F0F")]
		[FieldOffset(Offset = "0x14")]
		private float error_sum;
	}
}
