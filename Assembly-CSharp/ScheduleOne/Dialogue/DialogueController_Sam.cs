using System;
using Il2CppDummyDll;
using ScheduleOne.Quests;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006EC RID: 1772
	[Token(Token = "0x20006EC")]
	public class DialogueController_Sam : DialogueController
	{
		// Token: 0x06002EF1 RID: 12017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EF1")]
		[Address(RVA = "0x73E4D0", Offset = "0x73D6D0", VA = "0x18073E4D0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06002EF2 RID: 12018 RVA: 0x0000E928 File Offset: 0x0000CB28
		[Token(Token = "0x6002EF2")]
		[Address(RVA = "0x73E1E0", Offset = "0x73D3E0", VA = "0x18073E1E0", Slot = "13")]
		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06002EF3 RID: 12019 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002EF3")]
		[Address(RVA = "0x73E400", Offset = "0x73D600", VA = "0x18073E400", Slot = "9")]
		public override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		// Token: 0x06002EF4 RID: 12020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EF4")]
		[Address(RVA = "0x73E300", Offset = "0x73D500", VA = "0x18073E300", Slot = "12")]
		public override void ChoiceCallback(string choiceLabel)
		{
		}

		// Token: 0x06002EF5 RID: 12021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EF5")]
		[Address(RVA = "0x738E10", Offset = "0x738010", VA = "0x180738E10")]
		public DialogueController_Sam()
		{
		}

		// Token: 0x040022C5 RID: 8901
		[Token(Token = "0x40022C5")]
		[FieldOffset(Offset = "0x80")]
		private Quest_DefeatCartel questDefeatCartel;
	}
}
