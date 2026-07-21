using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C36 RID: 3126
	[Token(Token = "0x2000C36")]
	[Serializable]
	public class DialogueChoiceEntry
	{
		// Token: 0x06005BA9 RID: 23465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BA9")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public DialogueChoiceEntry()
		{
		}

		// Token: 0x04003E06 RID: 15878
		[Token(Token = "0x4003E06")]
		[FieldOffset(Offset = "0x10")]
		public GameObject gameObject;

		// Token: 0x04003E07 RID: 15879
		[Token(Token = "0x4003E07")]
		[FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI text;

		// Token: 0x04003E08 RID: 15880
		[Token(Token = "0x4003E08")]
		[FieldOffset(Offset = "0x20")]
		public Button button;

		// Token: 0x04003E09 RID: 15881
		[Token(Token = "0x4003E09")]
		[FieldOffset(Offset = "0x28")]
		public GameObject notPossibleGameObject;

		// Token: 0x04003E0A RID: 15882
		[Token(Token = "0x4003E0A")]
		[FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI notPossibleText;

		// Token: 0x04003E0B RID: 15883
		[Token(Token = "0x4003E0B")]
		[FieldOffset(Offset = "0x38")]
		public CanvasGroup canvasGroup;
	}
}
