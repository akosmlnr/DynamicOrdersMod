using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Temperature
{
	// Token: 0x02000317 RID: 791
	[Token(Token = "0x2000317")]
	public static class TemperatureAlgorithm
	{
		// Token: 0x060012C7 RID: 4807 RVA: 0x00008928 File Offset: 0x00006B28
		[Token(Token = "0x60012C7")]
		[Address(RVA = "0xB29960", Offset = "0xB28B60", VA = "0x180B29960")]
		public static float GetTemperatureAtPoint(float ambientTemperature, Vector3 originPoint, Vector3 point, TemperatureEmitterInfo[] emitters)
		{
			return 0f;
		}

		// Token: 0x04001119 RID: 4377
		[Token(Token = "0x4001119")]
		public const float NegligibleInfluenceThreshold = 0.1111f;
	}
}
