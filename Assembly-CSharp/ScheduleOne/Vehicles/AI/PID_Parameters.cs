using System;
using Il2CppDummyDll;

namespace ScheduleOne.Vehicles.AI
{
	// Token: 0x020002CA RID: 714
	[Token(Token = "0x20002CA")]
	[Serializable]
	public struct PID_Parameters
	{
		// Token: 0x060010AA RID: 4266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010AA")]
		[Address(RVA = "0xB02710", Offset = "0xB01910", VA = "0x180B02710")]
		public PID_Parameters(float P, float I, float D)
		{
		}

		// Token: 0x04000F10 RID: 3856
		[Token(Token = "0x4000F10")]
		[FieldOffset(Offset = "0x0")]
		public float P;

		// Token: 0x04000F11 RID: 3857
		[Token(Token = "0x4000F11")]
		[FieldOffset(Offset = "0x4")]
		public float I;

		// Token: 0x04000F12 RID: 3858
		[Token(Token = "0x4000F12")]
		[FieldOffset(Offset = "0x8")]
		public float D;
	}
}
