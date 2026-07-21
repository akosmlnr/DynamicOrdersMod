using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006E9 RID: 1769
	[Token(Token = "0x20006E9")]
	public class DialogueController_Jen : DialogueController
	{
		// Token: 0x06002EDF RID: 11999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EDF")]
		[Address(RVA = "0x73CEB0", Offset = "0x73C0B0", VA = "0x18073CEB0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06002EE0 RID: 12000 RVA: 0x0000E898 File Offset: 0x0000CA98
		[Token(Token = "0x6002EE0")]
		[Address(RVA = "0x73C860", Offset = "0x73BA60", VA = "0x18073C860")]
		private bool CanBuyKey(out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06002EE1 RID: 12001 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002EE1")]
		[Address(RVA = "0x73CCE0", Offset = "0x73BEE0", VA = "0x18073CCE0", Slot = "10")]
		public override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			return null;
		}

		// Token: 0x06002EE2 RID: 12002 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002EE2")]
		[Address(RVA = "0x73CDC0", Offset = "0x73BFC0", VA = "0x18073CDC0", Slot = "9")]
		public override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		// Token: 0x06002EE3 RID: 12003 RVA: 0x0000E8B0 File Offset: 0x0000CAB0
		[Token(Token = "0x6002EE3")]
		[Address(RVA = "0x73C9A0", Offset = "0x73BBA0", VA = "0x18073C9A0", Slot = "13")]
		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06002EE4 RID: 12004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EE4")]
		[Address(RVA = "0x73CAC0", Offset = "0x73BCC0", VA = "0x18073CAC0", Slot = "12")]
		public override void ChoiceCallback(string choiceLabel)
		{
		}

		// Token: 0x06002EE5 RID: 12005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EE5")]
		[Address(RVA = "0x73D070", Offset = "0x73C270", VA = "0x18073D070")]
		public DialogueController_Jen()
		{
		}

		// Token: 0x040022B7 RID: 8887
		[Token(Token = "0x40022B7")]
		[FieldOffset(Offset = "0x80")]
		public string BuyKeyText;

		// Token: 0x040022B8 RID: 8888
		[Token(Token = "0x40022B8")]
		[FieldOffset(Offset = "0x88")]
		public StorableItemDefinition KeyItem;

		// Token: 0x040022B9 RID: 8889
		[Token(Token = "0x40022B9")]
		[FieldOffset(Offset = "0x90")]
		public DialogueContainer BuyKeyDialogue;

		// Token: 0x040022BA RID: 8890
		[Token(Token = "0x40022BA")]
		[FieldOffset(Offset = "0x98")]
		public float MinRelationToBuyKey;
	}
}
