using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Experimental
{
	// Token: 0x02000C02 RID: 3074
	[Token(Token = "0x2000C02")]
	[CreateAssetMenu(fileName = "WheelData", menuName = "ScriptableObjects/Vehicle/Wheel Data")]
	public class WheelData : ScriptableObject
	{
		// Token: 0x06005A85 RID: 23173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A85")]
		[Address(RVA = "0x7507D0", Offset = "0x74F9D0", VA = "0x1807507D0")]
		public WheelData()
		{
		}

		// Token: 0x04003CE9 RID: 15593
		[Token(Token = "0x4003CE9")]
		[FieldOffset(Offset = "0x18")]
		public VehicleSettings Settings;
	}
}
