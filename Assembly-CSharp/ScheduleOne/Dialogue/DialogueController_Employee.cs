using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Property;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006FD RID: 1789
	[Token(Token = "0x20006FD")]
	public class DialogueController_Employee : DialogueController
	{
		// Token: 0x06002F49 RID: 12105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F49")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void Awake()
		{
		}

		// Token: 0x06002F4A RID: 12106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F4A")]
		[Address(RVA = "0x73A120", Offset = "0x739320", VA = "0x18073A120", Slot = "12")]
		public override void ChoiceCallback(string choiceLabel)
		{
		}

		// Token: 0x06002F4B RID: 12107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F4B")]
		[Address(RVA = "0x73A980", Offset = "0x739B80", VA = "0x18073A980", Slot = "11")]
		public override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
		}

		// Token: 0x06002F4C RID: 12108 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002F4C")]
		[Address(RVA = "0x73A340", Offset = "0x739540", VA = "0x18073A340")]
		private List<DialogueChoiceData> GetChoices()
		{
			return null;
		}

		// Token: 0x06002F4D RID: 12109 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002F4D")]
		[Address(RVA = "0x73A8F0", Offset = "0x739AF0", VA = "0x18073A8F0")]
		private Property GetPropertyByCode(string code)
		{
			return null;
		}

		// Token: 0x06002F4E RID: 12110 RVA: 0x0000EAF0 File Offset: 0x0000CCF0
		[Token(Token = "0x6002F4E")]
		[Address(RVA = "0x73A030", Offset = "0x739230", VA = "0x18073A030", Slot = "13")]
		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06002F4F RID: 12111 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002F4F")]
		[Address(RVA = "0x73AA80", Offset = "0x739C80", VA = "0x18073AA80", Slot = "9")]
		public override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F50")]
		[Address(RVA = "0x738E10", Offset = "0x738010", VA = "0x180738E10")]
		public DialogueController_Employee()
		{
		}

		// Token: 0x040022F8 RID: 8952
		[Token(Token = "0x40022F8")]
		[FieldOffset(Offset = "0x80")]
		private Property selectedProperty;
	}
}
