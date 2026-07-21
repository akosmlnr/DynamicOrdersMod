using System;
using Il2CppDummyDll;

namespace ScheduleOne.Experimental
{
	// Token: 0x02000C03 RID: 3075
	[Token(Token = "0x2000C03")]
	[Serializable]
	public class VehicleSettings
	{
		// Token: 0x06005A86 RID: 23174 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005A86")]
		[Address(RVA = "0x9D7110", Offset = "0x9D6310", VA = "0x1809D7110")]
		public VehicleSettings Clone()
		{
			return null;
		}

		// Token: 0x06005A87 RID: 23175 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005A87")]
		[Address(RVA = "0x9D7040", Offset = "0x9D6240", VA = "0x1809D7040")]
		public VehicleSettings Blend(VehicleSettings other, float t)
		{
			return null;
		}

		// Token: 0x06005A88 RID: 23176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A88")]
		[Address(RVA = "0x9D7290", Offset = "0x9D6490", VA = "0x1809D7290")]
		public VehicleSettings()
		{
		}

		// Token: 0x04003CEA RID: 15594
		[Token(Token = "0x4003CEA")]
		[FieldOffset(Offset = "0x10")]
		public WheelFrictionSettings ForwardFriction;

		// Token: 0x04003CEB RID: 15595
		[Token(Token = "0x4003CEB")]
		[FieldOffset(Offset = "0x18")]
		public WheelFrictionSettings SidewaysFriction;
	}
}
