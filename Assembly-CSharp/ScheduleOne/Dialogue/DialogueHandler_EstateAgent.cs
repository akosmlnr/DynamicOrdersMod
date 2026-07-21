using System;
using Il2CppDummyDll;
using ScheduleOne.Property;

namespace ScheduleOne.Dialogue
{
	// Token: 0x0200070E RID: 1806
	[Token(Token = "0x200070E")]
	public class DialogueHandler_EstateAgent : ControlledDialogueHandler
	{
		// Token: 0x06002FA3 RID: 12195 RVA: 0x0000EC28 File Offset: 0x0000CE28
		[Token(Token = "0x6002FA3")]
		[Address(RVA = "0x740BD0", Offset = "0x73FDD0", VA = "0x180740BD0", Slot = "8")]
		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06002FA4 RID: 12196 RVA: 0x0000EC40 File Offset: 0x0000CE40
		[Token(Token = "0x6002FA4")]
		[Address(RVA = "0x741AD0", Offset = "0x740CD0", VA = "0x180741AD0", Slot = "9")]
		public override bool ShouldChoiceBeShown(string choiceLabel)
		{
			return default(bool);
		}

		// Token: 0x06002FA5 RID: 12197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FA5")]
		[Address(RVA = "0x740FB0", Offset = "0x7401B0", VA = "0x180740FB0", Slot = "13")]
		protected override void ChoiceCallback(string choiceLabel)
		{
		}

		// Token: 0x06002FA6 RID: 12198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FA6")]
		[Address(RVA = "0x741260", Offset = "0x740460", VA = "0x180741260", Slot = "14")]
		protected override void DialogueCallback(string choiceLabel)
		{
		}

		// Token: 0x06002FA7 RID: 12199 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002FA7")]
		[Address(RVA = "0x741980", Offset = "0x740B80", VA = "0x180741980", Slot = "11")]
		protected override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		// Token: 0x06002FA8 RID: 12200 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002FA8")]
		[Address(RVA = "0x741610", Offset = "0x740810", VA = "0x180741610", Slot = "12")]
		protected override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			return null;
		}

		// Token: 0x06002FA9 RID: 12201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FA9")]
		[Address(RVA = "0x7372D0", Offset = "0x7364D0", VA = "0x1807372D0")]
		public DialogueHandler_EstateAgent()
		{
		}

		// Token: 0x04002328 RID: 9000
		[Token(Token = "0x4002328")]
		[FieldOffset(Offset = "0xB8")]
		private Property selectedProperty;

		// Token: 0x04002329 RID: 9001
		[Token(Token = "0x4002329")]
		[FieldOffset(Offset = "0xC0")]
		private Business selectedBusiness;
	}
}
