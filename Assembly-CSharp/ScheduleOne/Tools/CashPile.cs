using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000850 RID: 2128
	[Token(Token = "0x2000850")]
	public class CashPile : MonoBehaviour
	{
		// Token: 0x060038E0 RID: 14560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038E0")]
		[Address(RVA = "0x7F8620", Offset = "0x7F7820", VA = "0x1807F8620")]
		private void Awake()
		{
		}

		// Token: 0x060038E1 RID: 14561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038E1")]
		[Address(RVA = "0x7F8790", Offset = "0x7F7990", VA = "0x1807F8790")]
		public void SetDisplayedAmount(float amount)
		{
		}

		// Token: 0x060038E2 RID: 14562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038E2")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public CashPile()
		{
		}

		// Token: 0x040029ED RID: 10733
		[Token(Token = "0x40029ED")]
		public const float MAX_AMOUNT = 100000f;

		// Token: 0x040029EE RID: 10734
		[Token(Token = "0x40029EE")]
		[FieldOffset(Offset = "0x20")]
		public Transform Container;

		// Token: 0x040029EF RID: 10735
		[Token(Token = "0x40029EF")]
		[FieldOffset(Offset = "0x28")]
		private Transform[] CashInstances;
	}
}
