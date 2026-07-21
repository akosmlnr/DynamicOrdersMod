using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Quests;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006E0 RID: 1760
	[Token(Token = "0x20006E0")]
	public class DialogueController_ArmsDealer : DialogueController
	{
		// Token: 0x06002EBC RID: 11964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EBC")]
		[Address(RVA = "0x737C30", Offset = "0x736E30", VA = "0x180737C30")]
		private void Awake()
		{
		}

		// Token: 0x06002EBD RID: 11965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EBD")]
		[Address(RVA = "0x738A40", Offset = "0x737C40", VA = "0x180738A40", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06002EBE RID: 11966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EBE")]
		[Address(RVA = "0x7380D0", Offset = "0x7372D0", VA = "0x1807380D0", Slot = "12")]
		public override void ChoiceCallback(string choiceLabel)
		{
		}

		// Token: 0x06002EBF RID: 11967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EBF")]
		[Address(RVA = "0x738610", Offset = "0x737810", VA = "0x180738610", Slot = "11")]
		public override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
		}

		// Token: 0x06002EC0 RID: 11968 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002EC0")]
		[Address(RVA = "0x738340", Offset = "0x737540", VA = "0x180738340")]
		private List<DialogueChoiceData> GetWeaponChoices(List<DialogueController_ArmsDealer.WeaponOption> options)
		{
			return null;
		}

		// Token: 0x06002EC1 RID: 11969 RVA: 0x0000E7D8 File Offset: 0x0000C9D8
		[Token(Token = "0x6002EC1")]
		[Address(RVA = "0x737D20", Offset = "0x736F20", VA = "0x180737D20", Slot = "13")]
		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06002EC2 RID: 11970 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002EC2")]
		[Address(RVA = "0x738770", Offset = "0x737970", VA = "0x180738770", Slot = "9")]
		public override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		// Token: 0x06002EC3 RID: 11971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC3")]
		[Address(RVA = "0x738CF0", Offset = "0x737EF0", VA = "0x180738CF0")]
		private void TradeRDXForBomb()
		{
		}

		// Token: 0x06002EC4 RID: 11972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC4")]
		[Address(RVA = "0x738E10", Offset = "0x738010", VA = "0x180738E10")]
		public DialogueController_ArmsDealer()
		{
		}

		// Token: 0x040022A1 RID: 8865
		[Token(Token = "0x40022A1")]
		[FieldOffset(Offset = "0x80")]
		public List<DialogueController_ArmsDealer.WeaponOption> MeleeWeapons;

		// Token: 0x040022A2 RID: 8866
		[Token(Token = "0x40022A2")]
		[FieldOffset(Offset = "0x88")]
		public List<DialogueController_ArmsDealer.WeaponOption> RangedWeapons;

		// Token: 0x040022A3 RID: 8867
		[Token(Token = "0x40022A3")]
		[FieldOffset(Offset = "0x90")]
		public List<DialogueController_ArmsDealer.WeaponOption> Ammo;

		// Token: 0x040022A4 RID: 8868
		[Token(Token = "0x40022A4")]
		[FieldOffset(Offset = "0x98")]
		public ItemDefinition RDX;

		// Token: 0x040022A5 RID: 8869
		[Token(Token = "0x40022A5")]
		[FieldOffset(Offset = "0xA0")]
		public ItemDefinition Bomb;

		// Token: 0x040022A6 RID: 8870
		[Token(Token = "0x40022A6")]
		[FieldOffset(Offset = "0xA8")]
		private List<DialogueController_ArmsDealer.WeaponOption> allWeapons;

		// Token: 0x040022A7 RID: 8871
		[Token(Token = "0x40022A7")]
		[FieldOffset(Offset = "0xB0")]
		private DialogueController_ArmsDealer.WeaponOption chosenWeapon;

		// Token: 0x040022A8 RID: 8872
		[Token(Token = "0x40022A8")]
		[FieldOffset(Offset = "0xB8")]
		private Quest_DefeatCartel questDefeatCartel;

		// Token: 0x020006E1 RID: 1761
		[Token(Token = "0x20006E1")]
		[Serializable]
		public class WeaponOption
		{
			// Token: 0x170007CA RID: 1994
			// (get) Token: 0x06002EC5 RID: 11973 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170007CA")]
			public string Name
			{
				[Token(Token = "0x6002EC5")]
				[Address(RVA = "0x750490", Offset = "0x74F690", VA = "0x180750490")]
				get
				{
					return null;
				}
			}

			// Token: 0x170007CB RID: 1995
			// (get) Token: 0x06002EC6 RID: 11974 RVA: 0x0000E7F0 File Offset: 0x0000C9F0
			[Token(Token = "0x170007CB")]
			public float Price
			{
				[Token(Token = "0x6002EC6")]
				[Address(RVA = "0x750530", Offset = "0x74F730", VA = "0x180750530")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06002EC7 RID: 11975 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002EC7")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public WeaponOption()
			{
			}

			// Token: 0x040022A9 RID: 8873
			[Token(Token = "0x40022A9")]
			[FieldOffset(Offset = "0x10")]
			public bool IsAvailable;

			// Token: 0x040022AA RID: 8874
			[Token(Token = "0x40022AA")]
			[FieldOffset(Offset = "0x18")]
			public string NotAvailableReason;

			// Token: 0x040022AB RID: 8875
			[Token(Token = "0x40022AB")]
			[FieldOffset(Offset = "0x20")]
			public StorableItemDefinition Item;
		}
	}
}
