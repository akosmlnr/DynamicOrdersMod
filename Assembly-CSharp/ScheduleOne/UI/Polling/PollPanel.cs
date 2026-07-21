using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Polling;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Polling
{
	// Token: 0x02000D04 RID: 3332
	[Token(Token = "0x2000D04")]
	public class PollPanel : MonoBehaviour
	{
		// Token: 0x060060F8 RID: 24824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060F8")]
		[Address(RVA = "0xA30350", Offset = "0xA2F550", VA = "0x180A30350")]
		private void Awake()
		{
		}

		// Token: 0x060060F9 RID: 24825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060F9")]
		[Address(RVA = "0xA31BF0", Offset = "0xA30DF0", VA = "0x180A31BF0")]
		private void Update()
		{
		}

		// Token: 0x060060FA RID: 24826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060FA")]
		[Address(RVA = "0xA30B30", Offset = "0xA2FD30", VA = "0x180A30B30")]
		public void DisplayActivePoll(PollData poll)
		{
		}

		// Token: 0x060060FB RID: 24827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060FB")]
		[Address(RVA = "0xA30EE0", Offset = "0xA300E0", VA = "0x180A30EE0")]
		public void DisplayConfirmedPoll(PollData poll)
		{
		}

		// Token: 0x060060FC RID: 24828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060FC")]
		[Address(RVA = "0xA313C0", Offset = "0xA305C0", VA = "0x180A313C0")]
		private void DisplaySubmittedAnswer(int buttonIndex)
		{
		}

		// Token: 0x060060FD RID: 24829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060FD")]
		[Address(RVA = "0xA31A40", Offset = "0xA30C40", VA = "0x180A31A40")]
		private void Rebuild()
		{
		}

		// Token: 0x060060FE RID: 24830 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60060FE")]
		[Address(RVA = "0xA306D0", Offset = "0xA2F8D0", VA = "0x180A306D0")]
		private List<Button> CreateButtons(PollData data)
		{
			return null;
		}

		// Token: 0x060060FF RID: 24831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060FF")]
		[Address(RVA = "0xA30540", Offset = "0xA2F740", VA = "0x180A30540")]
		private void ButtonPressed(int buttonIndex)
		{
		}

		// Token: 0x06006100 RID: 24832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006100")]
		[Address(RVA = "0xA317A0", Offset = "0xA309A0", VA = "0x180A317A0")]
		private void FinalizeButtonPress(int buttonIndex)
		{
		}

		// Token: 0x06006101 RID: 24833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006101")]
		[Address(RVA = "0xA31DF0", Offset = "0xA30FF0", VA = "0x180A31DF0")]
		public PollPanel()
		{
		}

		// Token: 0x040042E8 RID: 17128
		[Token(Token = "0x40042E8")]
		public const float BUTTON_PRESS_TIME = 0.8f;

		// Token: 0x040042E9 RID: 17129
		[Token(Token = "0x40042E9")]
		public const string ResponseSubmittedMessage = "Your vote has been recorded.\n Thank you!";

		// Token: 0x040042EA RID: 17130
		[Token(Token = "0x40042EA")]
		[FieldOffset(Offset = "0x20")]
		public GameObject ButtonPrefab;

		// Token: 0x040042EB RID: 17131
		[Token(Token = "0x40042EB")]
		[FieldOffset(Offset = "0x28")]
		public Color TextColor_Green;

		// Token: 0x040042EC RID: 17132
		[Token(Token = "0x40042EC")]
		[FieldOffset(Offset = "0x38")]
		public Color TextColor_Red;

		// Token: 0x040042ED RID: 17133
		[Token(Token = "0x40042ED")]
		[FieldOffset(Offset = "0x48")]
		[Header("References")]
		public PollManager PollManager;

		// Token: 0x040042EE RID: 17134
		[Token(Token = "0x40042EE")]
		[FieldOffset(Offset = "0x50")]
		public GameObject Container;

		// Token: 0x040042EF RID: 17135
		[Token(Token = "0x40042EF")]
		[FieldOffset(Offset = "0x58")]
		public GameObject ActivePill;

		// Token: 0x040042F0 RID: 17136
		[Token(Token = "0x40042F0")]
		[FieldOffset(Offset = "0x60")]
		public GameObject ClosedPill;

		// Token: 0x040042F1 RID: 17137
		[Token(Token = "0x40042F1")]
		[FieldOffset(Offset = "0x68")]
		public TextMeshProUGUI QuestionLabel;

		// Token: 0x040042F2 RID: 17138
		[Token(Token = "0x40042F2")]
		[FieldOffset(Offset = "0x70")]
		public RectTransform ButtonContainer;

		// Token: 0x040042F3 RID: 17139
		[Token(Token = "0x40042F3")]
		[FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI InstructionLabel;

		// Token: 0x040042F4 RID: 17140
		[Token(Token = "0x40042F4")]
		[FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI ConfirmationMessageLabel;

		// Token: 0x040042F5 RID: 17141
		[Token(Token = "0x40042F5")]
		[FieldOffset(Offset = "0x88")]
		public AudioSourceController SubmissionStartSound;

		// Token: 0x040042F6 RID: 17142
		[Token(Token = "0x40042F6")]
		[FieldOffset(Offset = "0x90")]
		public AudioSourceController SubmissionSuccessSound;

		// Token: 0x040042F7 RID: 17143
		[Token(Token = "0x40042F7")]
		[FieldOffset(Offset = "0x98")]
		public AudioSourceController SubmissionFailSound;

		// Token: 0x040042F8 RID: 17144
		[Token(Token = "0x40042F8")]
		[FieldOffset(Offset = "0xA0")]
		private List<Button> buttons;

		// Token: 0x040042F9 RID: 17145
		[Token(Token = "0x40042F9")]
		[FieldOffset(Offset = "0xA8")]
		private List<Image> buttonFills;

		// Token: 0x040042FA RID: 17146
		[Token(Token = "0x40042FA")]
		[FieldOffset(Offset = "0xB0")]
		private int heldButton;

		// Token: 0x040042FB RID: 17147
		[Token(Token = "0x40042FB")]
		[FieldOffset(Offset = "0xB4")]
		private int selectedButton;

		// Token: 0x040042FC RID: 17148
		[Token(Token = "0x40042FC")]
		[FieldOffset(Offset = "0xB8")]
		private int lastHeldButton;

		// Token: 0x040042FD RID: 17149
		[Token(Token = "0x40042FD")]
		[FieldOffset(Offset = "0xBC")]
		private float buttonPressTime;
	}
}
