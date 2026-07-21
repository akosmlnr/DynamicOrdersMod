using System;
using Il2CppDummyDll;
using ScheduleOne.Property;
using ScheduleOne.Quests;
using UnityEngine.Events;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006EA RID: 1770
	[Token(Token = "0x20006EA")]
	public class DialogueController_Ming : DialogueController
	{
		// Token: 0x06002EE6 RID: 12006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EE6")]
		[Address(RVA = "0x73D6E0", Offset = "0x73C8E0", VA = "0x18073D6E0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06002EE7 RID: 12007 RVA: 0x0000E8C8 File Offset: 0x0000CAC8
		[Token(Token = "0x6002EE7")]
		[Address(RVA = "0x73D0D0", Offset = "0x73C2D0", VA = "0x18073D0D0")]
		private bool CanBuyRoom(bool enabled)
		{
			return default(bool);
		}

		// Token: 0x06002EE8 RID: 12008 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002EE8")]
		[Address(RVA = "0x73D520", Offset = "0x73C720", VA = "0x18073D520", Slot = "10")]
		public override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			return null;
		}

		// Token: 0x06002EE9 RID: 12009 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002EE9")]
		[Address(RVA = "0x73D600", Offset = "0x73C800", VA = "0x18073D600", Slot = "9")]
		public override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		// Token: 0x06002EEA RID: 12010 RVA: 0x0000E8E0 File Offset: 0x0000CAE0
		[Token(Token = "0x6002EEA")]
		[Address(RVA = "0x73D260", Offset = "0x73C460", VA = "0x18073D260", Slot = "13")]
		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06002EEB RID: 12011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EEB")]
		[Address(RVA = "0x73D380", Offset = "0x73C580", VA = "0x18073D380", Slot = "12")]
		public override void ChoiceCallback(string choiceLabel)
		{
		}

		// Token: 0x06002EEC RID: 12012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EEC")]
		[Address(RVA = "0x73D9F0", Offset = "0x73CBF0", VA = "0x18073D9F0")]
		public DialogueController_Ming()
		{
		}

		// Token: 0x040022BB RID: 8891
		[Token(Token = "0x40022BB")]
		[FieldOffset(Offset = "0x80")]
		public Property Property;

		// Token: 0x040022BC RID: 8892
		[Token(Token = "0x40022BC")]
		[FieldOffset(Offset = "0x88")]
		public float Price;

		// Token: 0x040022BD RID: 8893
		[Token(Token = "0x40022BD")]
		[FieldOffset(Offset = "0x90")]
		public DialogueContainer BuyDialogue;

		// Token: 0x040022BE RID: 8894
		[Token(Token = "0x40022BE")]
		[FieldOffset(Offset = "0x98")]
		public string BuyText;

		// Token: 0x040022BF RID: 8895
		[Token(Token = "0x40022BF")]
		[FieldOffset(Offset = "0xA0")]
		public string RemindText;

		// Token: 0x040022C0 RID: 8896
		[Token(Token = "0x40022C0")]
		[FieldOffset(Offset = "0xA8")]
		public DialogueContainer RemindLocationDialogue;

		// Token: 0x040022C1 RID: 8897
		[Token(Token = "0x40022C1")]
		[FieldOffset(Offset = "0xB0")]
		public QuestEntry[] PurchaseRoomQuests;

		// Token: 0x040022C2 RID: 8898
		[Token(Token = "0x40022C2")]
		[FieldOffset(Offset = "0xB8")]
		public UnityEvent onPurchase;
	}
}
