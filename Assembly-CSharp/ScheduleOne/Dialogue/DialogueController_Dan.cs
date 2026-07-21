using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006E7 RID: 1767
	[Token(Token = "0x20006E7")]
	public class DialogueController_Dan : DialogueController
	{
		// Token: 0x06002ED5 RID: 11989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED5")]
		[Address(RVA = "0x7398A0", Offset = "0x738AA0", VA = "0x1807398A0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06002ED6 RID: 11990 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002ED6")]
		[Address(RVA = "0x739790", Offset = "0x738990", VA = "0x180739790", Slot = "9")]
		public override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		// Token: 0x06002ED7 RID: 11991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED7")]
		[Address(RVA = "0x738E10", Offset = "0x738010", VA = "0x180738E10")]
		public DialogueController_Dan()
		{
		}

		// Token: 0x040022B3 RID: 8883
		[Token(Token = "0x40022B3")]
		[FieldOffset(Offset = "0x80")]
		public ItemDefinition ItemToGive;
	}
}
