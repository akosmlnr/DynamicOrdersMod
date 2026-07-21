using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.GameTime
{
	// Token: 0x02000302 RID: 770
	[Token(Token = "0x2000302")]
	public class TimeUnityEvents : MonoBehaviour
	{
		// Token: 0x06001246 RID: 4678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001246")]
		[Address(RVA = "0xB2FE30", Offset = "0xB2F030", VA = "0x180B2FE30")]
		private void Start()
		{
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001247")]
		[Address(RVA = "0x5D1E30", Offset = "0x5D1030", VA = "0x1805D1E30")]
		private void HourPass()
		{
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001248")]
		[Address(RVA = "0x5FAF90", Offset = "0x5FA190", VA = "0x1805FAF90")]
		private void DayPass()
		{
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001249")]
		[Address(RVA = "0x5FAF70", Offset = "0x5FA170", VA = "0x1805FAF70")]
		private void SleepStart()
		{
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124A")]
		[Address(RVA = "0xB2FE10", Offset = "0xB2F010", VA = "0x180B2FE10")]
		private void SleepEnd()
		{
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124B")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public TimeUnityEvents()
		{
		}

		// Token: 0x040010B1 RID: 4273
		[Token(Token = "0x40010B1")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent onHourPass;

		// Token: 0x040010B2 RID: 4274
		[Token(Token = "0x40010B2")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent onDayPass;

		// Token: 0x040010B3 RID: 4275
		[Token(Token = "0x40010B3")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent onSleepStart;

		// Token: 0x040010B4 RID: 4276
		[Token(Token = "0x40010B4")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent onSleepEnd;
	}
}
