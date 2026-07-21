using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using ScheduleOne.Property;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006E8 RID: 1768
	[Token(Token = "0x20006E8")]
	public class DialogueController_Fixer : DialogueController
	{
		// Token: 0x06002ED8 RID: 11992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED8")]
		[Address(RVA = "0x73B140", Offset = "0x73A340", VA = "0x18073B140", Slot = "12")]
		public override void ChoiceCallback(string choiceLabel)
		{
		}

		// Token: 0x06002ED9 RID: 11993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED9")]
		[Address(RVA = "0x73B800", Offset = "0x73AA00", VA = "0x18073B800", Slot = "11")]
		public override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
		}

		// Token: 0x06002EDA RID: 11994 RVA: 0x0000E868 File Offset: 0x0000CA68
		[Token(Token = "0x6002EDA")]
		[Address(RVA = "0x73ACB0", Offset = "0x739EB0", VA = "0x18073ACB0", Slot = "13")]
		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06002EDB RID: 11995 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002EDB")]
		[Address(RVA = "0x73BB00", Offset = "0x73AD00", VA = "0x18073BB00", Slot = "9")]
		public override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		// Token: 0x06002EDC RID: 11996 RVA: 0x0000E880 File Offset: 0x0000CA80
		[Token(Token = "0x6002EDC")]
		[Address(RVA = "0x73B780", Offset = "0x73A980", VA = "0x18073B780", Slot = "14")]
		public override bool DecideBranch(string branchLabel, out int index)
		{
			return default(bool);
		}

		// Token: 0x06002EDD RID: 11997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EDD")]
		[Address(RVA = "0x73B4A0", Offset = "0x73A6A0", VA = "0x18073B4A0")]
		private void Confirm()
		{
		}

		// Token: 0x06002EDE RID: 11998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EDE")]
		[Address(RVA = "0x738E10", Offset = "0x738010", VA = "0x180738E10")]
		public DialogueController_Fixer()
		{
		}

		// Token: 0x040022B4 RID: 8884
		[Token(Token = "0x40022B4")]
		[FieldOffset(Offset = "0x80")]
		private EEmployeeType selectedEmployeeType;

		// Token: 0x040022B5 RID: 8885
		[Token(Token = "0x40022B5")]
		[FieldOffset(Offset = "0x88")]
		private Property selectedProperty;

		// Token: 0x040022B6 RID: 8886
		[Token(Token = "0x40022B6")]
		[FieldOffset(Offset = "0x90")]
		private bool lastConfirmationWasInitial;
	}
}
