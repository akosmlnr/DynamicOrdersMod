using System;
using Il2CppDummyDll;
using ScheduleOne.Quests;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006E5 RID: 1765
	[Token(Token = "0x20006E5")]
	public class DialogueController_Billy : DialogueController
	{
		// Token: 0x06002ECF RID: 11983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ECF")]
		[Address(RVA = "0x738EB0", Offset = "0x7380B0", VA = "0x180738EB0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06002ED0 RID: 11984 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002ED0")]
		[Address(RVA = "0x738E20", Offset = "0x738020", VA = "0x180738E20", Slot = "9")]
		public override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		// Token: 0x06002ED1 RID: 11985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED1")]
		[Address(RVA = "0x738E10", Offset = "0x738010", VA = "0x180738E10")]
		public DialogueController_Billy()
		{
		}

		// Token: 0x040022B0 RID: 8880
		[Token(Token = "0x40022B0")]
		[FieldOffset(Offset = "0x80")]
		private Quest_DefeatCartel questDefeatCartel;
	}
}
