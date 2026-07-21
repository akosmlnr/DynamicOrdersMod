using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000CB6 RID: 3254
	[Token(Token = "0x2000CB6")]
	public class ButtonRequireInputFields : MonoBehaviour
	{
		// Token: 0x06005F25 RID: 24357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F25")]
		[Address(RVA = "0xA08000", Offset = "0xA07200", VA = "0x180A08000")]
		public void Update()
		{
		}

		// Token: 0x06005F26 RID: 24358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F26")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ButtonRequireInputFields()
		{
		}

		// Token: 0x04004172 RID: 16754
		[Token(Token = "0x4004172")]
		[FieldOffset(Offset = "0x20")]
		public List<ButtonRequireInputFields.Input> Inputs;

		// Token: 0x04004173 RID: 16755
		[Token(Token = "0x4004173")]
		[FieldOffset(Offset = "0x28")]
		public TMP_Dropdown Dropdown;

		// Token: 0x04004174 RID: 16756
		[Token(Token = "0x4004174")]
		[FieldOffset(Offset = "0x30")]
		public Button Button;

		// Token: 0x02000CB7 RID: 3255
		[Token(Token = "0x2000CB7")]
		[Serializable]
		public class Input
		{
			// Token: 0x06005F27 RID: 24359 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005F27")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public Input()
			{
			}

			// Token: 0x04004175 RID: 16757
			[Token(Token = "0x4004175")]
			[FieldOffset(Offset = "0x10")]
			public TMP_InputField InputField;

			// Token: 0x04004176 RID: 16758
			[Token(Token = "0x4004176")]
			[FieldOffset(Offset = "0x18")]
			public RectTransform ErrorMessage;
		}
	}
}
