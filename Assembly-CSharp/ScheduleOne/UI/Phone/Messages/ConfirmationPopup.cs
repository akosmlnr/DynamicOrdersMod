using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Messaging;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Messages
{
	// Token: 0x02000D4A RID: 3402
	[Token(Token = "0x2000D4A")]
	public class ConfirmationPopup : MonoBehaviour
	{
		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x060062D1 RID: 25297 RVA: 0x000187E0 File Offset: 0x000169E0
		// (set) Token: 0x060062D2 RID: 25298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E30")]
		public bool IsOpen
		{
			[Token(Token = "0x60062D1")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60062D2")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060062D3 RID: 25299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062D3")]
		[Address(RVA = "0xA577C0", Offset = "0xA569C0", VA = "0x180A577C0")]
		private void Start()
		{
		}

		// Token: 0x060062D4 RID: 25300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062D4")]
		[Address(RVA = "0xA57580", Offset = "0xA56780", VA = "0x180A57580")]
		public void Exit(ExitAction action)
		{
		}

		// Token: 0x060062D5 RID: 25301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062D5")]
		[Address(RVA = "0xA57610", Offset = "0xA56810", VA = "0x180A57610")]
		public void Open(string title, string message, MSGConversation conv, Action<ConfirmationPopup.EResponse> callback)
		{
		}

		// Token: 0x060062D6 RID: 25302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062D6")]
		[Address(RVA = "0xA57400", Offset = "0xA56600", VA = "0x180A57400")]
		public void Close(ConfirmationPopup.EResponse outcome)
		{
		}

		// Token: 0x060062D7 RID: 25303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062D7")]
		[Address(RVA = "0xA57570", Offset = "0xA56770", VA = "0x180A57570")]
		private void Confirm()
		{
		}

		// Token: 0x060062D8 RID: 25304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062D8")]
		[Address(RVA = "0xA573F0", Offset = "0xA565F0", VA = "0x180A573F0")]
		private void Cancel()
		{
		}

		// Token: 0x060062D9 RID: 25305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062D9")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ConfirmationPopup()
		{
		}

		// Token: 0x040044BD RID: 17597
		[Token(Token = "0x40044BD")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public GameObject Container;

		// Token: 0x040044BE RID: 17598
		[Token(Token = "0x40044BE")]
		[FieldOffset(Offset = "0x30")]
		public Text TitleLabel;

		// Token: 0x040044BF RID: 17599
		[Token(Token = "0x40044BF")]
		[FieldOffset(Offset = "0x38")]
		public Text MessageLabel;

		// Token: 0x040044C0 RID: 17600
		[Token(Token = "0x40044C0")]
		[FieldOffset(Offset = "0x40")]
		public Button ConfirmButton;

		// Token: 0x040044C1 RID: 17601
		[Token(Token = "0x40044C1")]
		[FieldOffset(Offset = "0x48")]
		public Button CancelButton;

		// Token: 0x040044C2 RID: 17602
		[Token(Token = "0x40044C2")]
		[FieldOffset(Offset = "0x50")]
		private MSGConversation conversation;

		// Token: 0x040044C3 RID: 17603
		[Token(Token = "0x40044C3")]
		[FieldOffset(Offset = "0x58")]
		private Action<ConfirmationPopup.EResponse> responseCallback;

		// Token: 0x02000D4B RID: 3403
		[Token(Token = "0x2000D4B")]
		public enum EResponse
		{
			// Token: 0x040044C5 RID: 17605
			[Token(Token = "0x40044C5")]
			Confirm,
			// Token: 0x040044C6 RID: 17606
			[Token(Token = "0x40044C6")]
			Cancel
		}
	}
}
