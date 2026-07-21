using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000C0B RID: 3083
	[Token(Token = "0x2000C0B")]
	public class OpenSteamOverlay : MonoBehaviour
	{
		// Token: 0x06005A99 RID: 23193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A99")]
		[Address(RVA = "0x9D0650", Offset = "0x9CF850", VA = "0x1809D0650")]
		public void OpenOverlay()
		{
		}

		// Token: 0x06005A9A RID: 23194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A9A")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public OpenSteamOverlay()
		{
		}

		// Token: 0x04003D12 RID: 15634
		[Token(Token = "0x4003D12")]
		public const uint APP_ID = 3164500U;

		// Token: 0x04003D13 RID: 15635
		[Token(Token = "0x4003D13")]
		[FieldOffset(Offset = "0x20")]
		public OpenSteamOverlay.EType Type;

		// Token: 0x04003D14 RID: 15636
		[Token(Token = "0x4003D14")]
		[FieldOffset(Offset = "0x28")]
		public string CustomLink;

		// Token: 0x02000C0C RID: 3084
		[Token(Token = "0x2000C0C")]
		public enum EType
		{
			// Token: 0x04003D16 RID: 15638
			[Token(Token = "0x4003D16")]
			Store,
			// Token: 0x04003D17 RID: 15639
			[Token(Token = "0x4003D17")]
			CustomLink
		}
	}
}
