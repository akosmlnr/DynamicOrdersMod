using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B55 RID: 2901
	[Token(Token = "0x2000B55")]
	[Serializable]
	public class EffectSettingsWrapper
	{
		// Token: 0x060056FF RID: 22271 RVA: 0x000163C8 File Offset: 0x000145C8
		[Token(Token = "0x60056FF")]
		[Address(RVA = "0x9953F0", Offset = "0x9945F0", VA = "0x1809953F0")]
		public float GetNumericParameter(string variable)
		{
			return 0f;
		}

		// Token: 0x06005700 RID: 22272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005700")]
		[Address(RVA = "0x995650", Offset = "0x994850", VA = "0x180995650")]
		public void SetNumericParameter(string variable, float value)
		{
		}

		// Token: 0x06005701 RID: 22273 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005701")]
		[Address(RVA = "0x995290", Offset = "0x994490", VA = "0x180995290")]
		public Gradient GetGradientParameter(string variable)
		{
			return null;
		}

		// Token: 0x06005702 RID: 22274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005702")]
		[Address(RVA = "0x995550", Offset = "0x994750", VA = "0x180995550")]
		public void SetGradientParameter(string variable, Gradient value)
		{
		}

		// Token: 0x06005703 RID: 22275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005703")]
		[Address(RVA = "0x9957B0", Offset = "0x9949B0", VA = "0x1809957B0")]
		public EffectSettingsWrapper()
		{
		}

		// Token: 0x04003A1A RID: 14874
		[Token(Token = "0x4003A1A")]
		[FieldOffset(Offset = "0x10")]
		public List<NumericParameter> NumericParameters;

		// Token: 0x04003A1B RID: 14875
		[Token(Token = "0x4003A1B")]
		[FieldOffset(Offset = "0x18")]
		public List<GradientParameter> GradientParameters;
	}
}
