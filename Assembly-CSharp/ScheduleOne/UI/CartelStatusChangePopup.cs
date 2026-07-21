using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000C23 RID: 3107
	[Token(Token = "0x2000C23")]
	public class CartelStatusChangePopup : MonoBehaviour
	{
		// Token: 0x06005B0C RID: 23308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B0C")]
		[Address(RVA = "0x9C3010", Offset = "0x9C2210", VA = "0x1809C3010")]
		private void Start()
		{
		}

		// Token: 0x06005B0D RID: 23309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B0D")]
		[Address(RVA = "0x9C2D70", Offset = "0x9C1F70", VA = "0x1809C2D70")]
		public void Show(ECartelStatus oldStatus, ECartelStatus newStatus)
		{
		}

		// Token: 0x06005B0E RID: 23310 RVA: 0x00017160 File Offset: 0x00015360
		[Token(Token = "0x6005B0E")]
		[Address(RVA = "0x9C2D20", Offset = "0x9C1F20", VA = "0x1809C2D20")]
		private Color GetColor(ECartelStatus status)
		{
			return default(Color);
		}

		// Token: 0x06005B0F RID: 23311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B0F")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public CartelStatusChangePopup()
		{
		}

		// Token: 0x06005B10 RID: 23312 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005B10")]
		[Address(RVA = "0x9C3170", Offset = "0x9C2370", VA = "0x1809C3170")]
		[CompilerGenerated]
		private IEnumerator <Show>g__Routine|8_0()
		{
			return null;
		}

		// Token: 0x04003D83 RID: 15747
		[Token(Token = "0x4003D83")]
		[FieldOffset(Offset = "0x20")]
		public Animation Anim;

		// Token: 0x04003D84 RID: 15748
		[Token(Token = "0x4003D84")]
		[FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI OldStatusLabel;

		// Token: 0x04003D85 RID: 15749
		[Token(Token = "0x4003D85")]
		[FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI NewStatusLabel;

		// Token: 0x04003D86 RID: 15750
		[Token(Token = "0x4003D86")]
		[FieldOffset(Offset = "0x38")]
		public Color UnknownColor;

		// Token: 0x04003D87 RID: 15751
		[Token(Token = "0x4003D87")]
		[FieldOffset(Offset = "0x48")]
		public Color TrucedColor;

		// Token: 0x04003D88 RID: 15752
		[Token(Token = "0x4003D88")]
		[FieldOffset(Offset = "0x58")]
		public Color HostileColor;

		// Token: 0x04003D89 RID: 15753
		[Token(Token = "0x4003D89")]
		[FieldOffset(Offset = "0x68")]
		public Color DefeatedColor;
	}
}
