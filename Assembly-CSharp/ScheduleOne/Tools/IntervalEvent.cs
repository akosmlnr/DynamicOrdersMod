using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x02000878 RID: 2168
	[Token(Token = "0x2000878")]
	public class IntervalEvent : MonoBehaviour
	{
		// Token: 0x06003975 RID: 14709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003975")]
		[Address(RVA = "0x804940", Offset = "0x803B40", VA = "0x180804940")]
		public void Start()
		{
		}

		// Token: 0x06003976 RID: 14710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003976")]
		[Address(RVA = "0x5FAF90", Offset = "0x5FA190", VA = "0x1805FAF90")]
		private void Execute()
		{
		}

		// Token: 0x06003977 RID: 14711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003977")]
		[Address(RVA = "0x557960", Offset = "0x556B60", VA = "0x180557960")]
		public IntervalEvent()
		{
		}

		// Token: 0x04002A59 RID: 10841
		[Token(Token = "0x4002A59")]
		[FieldOffset(Offset = "0x20")]
		public float Interval;

		// Token: 0x04002A5A RID: 10842
		[Token(Token = "0x4002A5A")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent Event;
	}
}
