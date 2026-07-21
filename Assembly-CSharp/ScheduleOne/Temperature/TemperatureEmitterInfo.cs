using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Temperature
{
	// Token: 0x02000319 RID: 793
	[Token(Token = "0x2000319")]
	public struct TemperatureEmitterInfo
	{
		// Token: 0x170003DC RID: 988
		// (get) Token: 0x060012D2 RID: 4818 RVA: 0x00008988 File Offset: 0x00006B88
		[Token(Token = "0x170003DC")]
		public static int SizeOf
		{
			[Token(Token = "0x60012D2")]
			[Address(RVA = "0xB29AA0", Offset = "0xB28CA0", VA = "0x180B29AA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D3")]
		[Address(RVA = "0xB29A80", Offset = "0xB28C80", VA = "0x180B29A80")]
		public TemperatureEmitterInfo(float temperature, float sqrRange, Vector3 position)
		{
		}

		// Token: 0x04001120 RID: 4384
		[Token(Token = "0x4001120")]
		[FieldOffset(Offset = "0x0")]
		public float Temperature;

		// Token: 0x04001121 RID: 4385
		[Token(Token = "0x4001121")]
		[FieldOffset(Offset = "0x4")]
		public float SqrRange;

		// Token: 0x04001122 RID: 4386
		[Token(Token = "0x4001122")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 Position;
	}
}
