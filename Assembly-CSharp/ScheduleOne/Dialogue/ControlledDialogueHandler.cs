using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006F4 RID: 1780
	[Token(Token = "0x20006F4")]
	public class ControlledDialogueHandler : DialogueHandler
	{
		// Token: 0x06002F10 RID: 12048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F10")]
		[Address(RVA = "0x736EE0", Offset = "0x7360E0", VA = "0x180736EE0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06002F11 RID: 12049 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002F11")]
		[Address(RVA = "0x7372A0", Offset = "0x7364A0", VA = "0x1807372A0", Slot = "11")]
		protected override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		// Token: 0x06002F12 RID: 12050 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002F12")]
		[Address(RVA = "0x737270", Offset = "0x736470", VA = "0x180737270", Slot = "12")]
		protected override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			return null;
		}

		// Token: 0x06002F13 RID: 12051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F13")]
		[Address(RVA = "0x737240", Offset = "0x736440", VA = "0x180737240", Slot = "15")]
		protected override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
		}

		// Token: 0x06002F14 RID: 12052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F14")]
		[Address(RVA = "0x7371C0", Offset = "0x7363C0", VA = "0x1807371C0", Slot = "13")]
		protected override void ChoiceCallback(string choiceLabel)
		{
		}

		// Token: 0x06002F15 RID: 12053 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
		[Token(Token = "0x6002F15")]
		[Address(RVA = "0x736F40", Offset = "0x736140", VA = "0x180736F40", Slot = "10")]
		protected override int CheckBranch(string branchLabel)
		{
			return 0;
		}

		// Token: 0x06002F16 RID: 12054 RVA: 0x0000E9E8 File Offset: 0x0000CBE8
		[Token(Token = "0x6002F16")]
		[Address(RVA = "0x7370E0", Offset = "0x7362E0", VA = "0x1807370E0", Slot = "8")]
		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06002F17 RID: 12055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F17")]
		[Address(RVA = "0x7372D0", Offset = "0x7364D0", VA = "0x1807372D0")]
		public ControlledDialogueHandler()
		{
		}

		// Token: 0x040022D5 RID: 8917
		[Token(Token = "0x40022D5")]
		[FieldOffset(Offset = "0xB0")]
		private DialogueController controller;
	}
}
