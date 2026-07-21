using System;
using Il2CppDummyDll;

namespace ScheduleOne.Experimental
{
	// Token: 0x02000C04 RID: 3076
	[Token(Token = "0x2000C04")]
	[Serializable]
	public class WheelFrictionSettings
	{
		// Token: 0x06005A89 RID: 23177 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005A89")]
		[Address(RVA = "0x9D7380", Offset = "0x9D6580", VA = "0x1809D7380")]
		public WheelFrictionSettings Blend(WheelFrictionSettings other, float t)
		{
			return null;
		}

		// Token: 0x06005A8A RID: 23178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A8A")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public WheelFrictionSettings()
		{
		}

		// Token: 0x04003CEC RID: 15596
		[Token(Token = "0x4003CEC")]
		[FieldOffset(Offset = "0x10")]
		public float ExtremumSlip;

		// Token: 0x04003CED RID: 15597
		[Token(Token = "0x4003CED")]
		[FieldOffset(Offset = "0x14")]
		public float ExtremumValue;

		// Token: 0x04003CEE RID: 15598
		[Token(Token = "0x4003CEE")]
		[FieldOffset(Offset = "0x18")]
		public float AsymptoteSlip;

		// Token: 0x04003CEF RID: 15599
		[Token(Token = "0x4003CEF")]
		[FieldOffset(Offset = "0x1C")]
		public float AsymptoteValue;

		// Token: 0x04003CF0 RID: 15600
		[Token(Token = "0x4003CF0")]
		[FieldOffset(Offset = "0x20")]
		public float Stiffness;
	}
}
