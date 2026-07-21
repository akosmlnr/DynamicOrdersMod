using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C19 RID: 3097
	[Token(Token = "0x2000C19")]
	public class ButtonUI : MonoBehaviour
	{
		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x06005AE2 RID: 23266 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000D28")]
		public Button Button
		{
			[Token(Token = "0x6005AE2")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005AE3 RID: 23267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AE3")]
		[Address(RVA = "0x9C1D20", Offset = "0x9C0F20", VA = "0x1809C1D20")]
		public void Initialize(int id)
		{
		}

		// Token: 0x06005AE4 RID: 23268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AE4")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ButtonUI()
		{
		}

		// Token: 0x04003D5B RID: 15707
		[Token(Token = "0x4003D5B")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		[SerializeField]
		private Button _button;

		// Token: 0x04003D5C RID: 15708
		[Token(Token = "0x4003D5C")]
		[FieldOffset(Offset = "0x28")]
		private int _id;

		// Token: 0x04003D5D RID: 15709
		[Token(Token = "0x4003D5D")]
		[FieldOffset(Offset = "0x30")]
		public Action<int> OnSelect;
	}
}
