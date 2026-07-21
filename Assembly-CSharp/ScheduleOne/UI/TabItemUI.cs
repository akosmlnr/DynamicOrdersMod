using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000CB3 RID: 3251
	[Token(Token = "0x2000CB3")]
	public class TabItemUI : MonoBehaviour
	{
		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x06005F13 RID: 24339 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000DC9")]
		public ButtonUI Button
		{
			[Token(Token = "0x6005F13")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x06005F14 RID: 24340 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000DCA")]
		public Text Label
		{
			[Token(Token = "0x6005F14")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x06005F15 RID: 24341 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000DCB")]
		public GameObject Content
		{
			[Token(Token = "0x6005F15")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005F16 RID: 24342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F16")]
		[Address(RVA = "0xA15180", Offset = "0xA14380", VA = "0x180A15180")]
		public void SetIndicator(string text)
		{
		}

		// Token: 0x06005F17 RID: 24343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F17")]
		[Address(RVA = "0xA15100", Offset = "0xA14300", VA = "0x180A15100")]
		public void HideIndicator()
		{
		}

		// Token: 0x06005F18 RID: 24344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F18")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public TabItemUI()
		{
		}

		// Token: 0x0400415F RID: 16735
		[Token(Token = "0x400415F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("Components")]
		private ButtonUI _button;

		// Token: 0x04004160 RID: 16736
		[Token(Token = "0x4004160")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _label;

		// Token: 0x04004161 RID: 16737
		[Token(Token = "0x4004161")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _content;

		// Token: 0x04004162 RID: 16738
		[Token(Token = "0x4004162")]
		[FieldOffset(Offset = "0x38")]
		[Header("Additionals")]
		[SerializeField]
		private GameObject _indicator;

		// Token: 0x04004163 RID: 16739
		[Token(Token = "0x4004163")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _indicatorLabel;
	}
}
