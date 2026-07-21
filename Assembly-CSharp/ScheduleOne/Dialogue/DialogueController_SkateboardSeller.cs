using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine.Events;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006EE RID: 1774
	[Token(Token = "0x20006EE")]
	public class DialogueController_SkateboardSeller : DialogueController
	{
		// Token: 0x06002EF9 RID: 12025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EF9")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void Awake()
		{
		}

		// Token: 0x06002EFA RID: 12026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EFA")]
		[Address(RVA = "0x73E9B0", Offset = "0x73DBB0", VA = "0x18073E9B0", Slot = "12")]
		public override void ChoiceCallback(string choiceLabel)
		{
		}

		// Token: 0x06002EFB RID: 12027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EFB")]
		[Address(RVA = "0x73EFB0", Offset = "0x73E1B0", VA = "0x18073EFB0", Slot = "11")]
		public override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
		}

		// Token: 0x06002EFC RID: 12028 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002EFC")]
		[Address(RVA = "0x73ED00", Offset = "0x73DF00", VA = "0x18073ED00")]
		private List<DialogueChoiceData> GetChoices(List<DialogueController_SkateboardSeller.Option> options)
		{
			return null;
		}

		// Token: 0x06002EFD RID: 12029 RVA: 0x0000E958 File Offset: 0x0000CB58
		[Token(Token = "0x6002EFD")]
		[Address(RVA = "0x73E780", Offset = "0x73D980", VA = "0x18073E780", Slot = "13")]
		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06002EFE RID: 12030 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002EFE")]
		[Address(RVA = "0x73F0B0", Offset = "0x73E2B0", VA = "0x18073F0B0", Slot = "9")]
		public override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		// Token: 0x06002EFF RID: 12031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EFF")]
		[Address(RVA = "0x73F1E0", Offset = "0x73E3E0", VA = "0x18073F1E0")]
		public DialogueController_SkateboardSeller()
		{
		}

		// Token: 0x040022C8 RID: 8904
		[Token(Token = "0x40022C8")]
		[FieldOffset(Offset = "0x80")]
		public List<DialogueController_SkateboardSeller.Option> Options;

		// Token: 0x040022C9 RID: 8905
		[Token(Token = "0x40022C9")]
		[FieldOffset(Offset = "0x88")]
		private DialogueController_SkateboardSeller.Option chosenWeapon;

		// Token: 0x040022CA RID: 8906
		[Token(Token = "0x40022CA")]
		[FieldOffset(Offset = "0x90")]
		public UnityEvent onPurchase;

		// Token: 0x020006EF RID: 1775
		[Token(Token = "0x20006EF")]
		[Serializable]
		public class Option
		{
			// Token: 0x06002F00 RID: 12032 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002F00")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public Option()
			{
			}

			// Token: 0x040022CB RID: 8907
			[Token(Token = "0x40022CB")]
			[FieldOffset(Offset = "0x10")]
			public string Name;

			// Token: 0x040022CC RID: 8908
			[Token(Token = "0x40022CC")]
			[FieldOffset(Offset = "0x18")]
			public float Price;

			// Token: 0x040022CD RID: 8909
			[Token(Token = "0x40022CD")]
			[FieldOffset(Offset = "0x1C")]
			public bool IsAvailable;

			// Token: 0x040022CE RID: 8910
			[Token(Token = "0x40022CE")]
			[FieldOffset(Offset = "0x20")]
			public string NotAvailableReason;

			// Token: 0x040022CF RID: 8911
			[Token(Token = "0x40022CF")]
			[FieldOffset(Offset = "0x28")]
			public ItemDefinition Item;
		}
	}
}
