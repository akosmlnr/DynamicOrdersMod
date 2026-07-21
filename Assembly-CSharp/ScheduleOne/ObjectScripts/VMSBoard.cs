using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x020009DB RID: 2523
	[Token(Token = "0x20009DB")]
	public class VMSBoard : MonoBehaviour
	{
		// Token: 0x06004854 RID: 18516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004854")]
		[Address(RVA = "0x916E50", Offset = "0x916050", VA = "0x180916E50")]
		public void SetText(string text, Color col)
		{
		}

		// Token: 0x06004855 RID: 18517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004855")]
		[Address(RVA = "0x916EC0", Offset = "0x9160C0", VA = "0x180916EC0")]
		public void SetText(string text)
		{
		}

		// Token: 0x06004856 RID: 18518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004856")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public VMSBoard()
		{
		}

		// Token: 0x04003324 RID: 13092
		[Token(Token = "0x4003324")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public TextMeshProUGUI Label;
	}
}
