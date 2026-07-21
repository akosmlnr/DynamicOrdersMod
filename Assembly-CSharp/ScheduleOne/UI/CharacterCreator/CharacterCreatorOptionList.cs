using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Clothing;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.CharacterCreator
{
	// Token: 0x02000DE4 RID: 3556
	[Token(Token = "0x2000DE4")]
	public class CharacterCreatorOptionList : CharacterCreatorField<string>
	{
		// Token: 0x06006606 RID: 26118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006606")]
		[Address(RVA = "0xA8C820", Offset = "0xA8BA20", VA = "0x180A8C820", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06006607 RID: 26119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006607")]
		[Address(RVA = "0xA8C620", Offset = "0xA8B820", VA = "0x180A8C620", Slot = "6")]
		public override void ApplyValue()
		{
		}

		// Token: 0x06006608 RID: 26120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006608")]
		[Address(RVA = "0xA8CBF0", Offset = "0xA8BDF0", VA = "0x180A8CBF0")]
		public void OptionClicked(string option)
		{
		}

		// Token: 0x06006609 RID: 26121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006609")]
		[Address(RVA = "0xA8CD30", Offset = "0xA8BF30", VA = "0x180A8CD30")]
		public CharacterCreatorOptionList()
		{
		}

		// Token: 0x040047E3 RID: 18403
		[Token(Token = "0x40047E3")]
		[FieldOffset(Offset = "0x48")]
		[Header("References")]
		public RectTransform OptionContainer;

		// Token: 0x040047E4 RID: 18404
		[Token(Token = "0x40047E4")]
		[FieldOffset(Offset = "0x50")]
		[Header("Settings")]
		public bool CanSelectNone;

		// Token: 0x040047E5 RID: 18405
		[Token(Token = "0x40047E5")]
		[FieldOffset(Offset = "0x58")]
		public List<CharacterCreatorOptionList.Option> Options;

		// Token: 0x040047E6 RID: 18406
		[Token(Token = "0x40047E6")]
		[FieldOffset(Offset = "0x60")]
		public GameObject OptionPrefab;

		// Token: 0x040047E7 RID: 18407
		[Token(Token = "0x40047E7")]
		[FieldOffset(Offset = "0x68")]
		private List<Button> optionButtons;

		// Token: 0x040047E8 RID: 18408
		[Token(Token = "0x40047E8")]
		[FieldOffset(Offset = "0x70")]
		private Button selectedButton;

		// Token: 0x02000DE5 RID: 3557
		[Token(Token = "0x2000DE5")]
		[Serializable]
		public class Option
		{
			// Token: 0x0600660A RID: 26122 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600660A")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public Option()
			{
			}

			// Token: 0x040047E9 RID: 18409
			[Token(Token = "0x40047E9")]
			[FieldOffset(Offset = "0x10")]
			public string Label;

			// Token: 0x040047EA RID: 18410
			[Token(Token = "0x40047EA")]
			[FieldOffset(Offset = "0x18")]
			public string AssetPath;

			// Token: 0x040047EB RID: 18411
			[Token(Token = "0x40047EB")]
			[FieldOffset(Offset = "0x20")]
			public ClothingDefinition ClothingItemEquivalent;
		}
	}
}
