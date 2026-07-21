using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Economy;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006FC RID: 1788
	[Token(Token = "0x20006FC")]
	public class DialogueController_Dealer : DialogueController
	{
		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06002F41 RID: 12097 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002F42 RID: 12098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007CE")]
		public Dealer Dealer
		{
			[Token(Token = "0x6002F41")]
			[Address(RVA = "0x4E09D0", Offset = "0x4DFBD0", VA = "0x1804E09D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F42")]
			[Address(RVA = "0x73A010", Offset = "0x739210", VA = "0x18073A010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002F43 RID: 12099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F43")]
		[Address(RVA = "0x739F80", Offset = "0x739180", VA = "0x180739F80", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06002F44 RID: 12100 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002F44")]
		[Address(RVA = "0x739CE0", Offset = "0x738EE0", VA = "0x180739CE0", Slot = "9")]
		public override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		// Token: 0x06002F45 RID: 12101 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002F45")]
		[Address(RVA = "0x739BB0", Offset = "0x738DB0", VA = "0x180739BB0", Slot = "10")]
		public override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			return null;
		}

		// Token: 0x06002F46 RID: 12102 RVA: 0x0000EAD8 File Offset: 0x0000CCD8
		[Token(Token = "0x6002F46")]
		[Address(RVA = "0x739950", Offset = "0x738B50", VA = "0x180739950", Slot = "13")]
		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F47")]
		[Address(RVA = "0x739A90", Offset = "0x738C90", VA = "0x180739A90", Slot = "12")]
		public override void ChoiceCallback(string choiceLabel)
		{
		}

		// Token: 0x06002F48 RID: 12104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F48")]
		[Address(RVA = "0x738E10", Offset = "0x738010", VA = "0x180738E10")]
		public DialogueController_Dealer()
		{
		}
	}
}
