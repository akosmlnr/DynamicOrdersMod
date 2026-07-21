using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.ObjectScripts.Cash
{
	// Token: 0x020009DD RID: 2525
	[Token(Token = "0x20009DD")]
	public class CashStackVisuals : MonoBehaviour
	{
		// Token: 0x06004876 RID: 18550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004876")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void Awake()
		{
		}

		// Token: 0x06004877 RID: 18551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004877")]
		[Address(RVA = "0x8F3C00", Offset = "0x8F2E00", VA = "0x1808F3C00")]
		public void ShowAmount(float amount)
		{
		}

		// Token: 0x06004878 RID: 18552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004878")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public CashStackVisuals()
		{
		}

		// Token: 0x04003336 RID: 13110
		[Token(Token = "0x4003336")]
		public const float MAX_AMOUNT = 1000f;

		// Token: 0x04003337 RID: 13111
		[Token(Token = "0x4003337")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public GameObject Visuals_Under100;

		// Token: 0x04003338 RID: 13112
		[Token(Token = "0x4003338")]
		[FieldOffset(Offset = "0x28")]
		public GameObject[] Notes;

		// Token: 0x04003339 RID: 13113
		[Token(Token = "0x4003339")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Visuals_Over100;

		// Token: 0x0400333A RID: 13114
		[Token(Token = "0x400333A")]
		[FieldOffset(Offset = "0x38")]
		public GameObject[] Bills;
	}
}
