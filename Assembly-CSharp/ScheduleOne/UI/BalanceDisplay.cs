using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000C0F RID: 3087
	[Token(Token = "0x2000C0F")]
	public class BalanceDisplay : MonoBehaviour
	{
		// Token: 0x06005AA7 RID: 23207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AA7")]
		[Address(RVA = "0x9BFC50", Offset = "0x9BEE50", VA = "0x1809BFC50")]
		public void SetBalance(float balance)
		{
		}

		// Token: 0x06005AA8 RID: 23208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AA8")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public BalanceDisplay()
		{
		}

		// Token: 0x04003D1A RID: 15642
		[Token(Token = "0x4003D1A")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public TextMeshProUGUI BalanceLabel;
	}
}
