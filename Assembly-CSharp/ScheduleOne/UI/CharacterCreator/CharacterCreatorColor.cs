using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Clothing;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.CharacterCreator
{
	// Token: 0x02000DDF RID: 3551
	[Token(Token = "0x2000DDF")]
	public class CharacterCreatorColor : CharacterCreatorField<Color>
	{
		// Token: 0x060065F1 RID: 26097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065F1")]
		[Address(RVA = "0xA8BE60", Offset = "0xA8B060", VA = "0x180A8BE60", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x060065F2 RID: 26098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065F2")]
		[Address(RVA = "0xA8BC70", Offset = "0xA8AE70", VA = "0x180A8BC70", Slot = "6")]
		public override void ApplyValue()
		{
		}

		// Token: 0x060065F3 RID: 26099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065F3")]
		[Address(RVA = "0xA8C2C0", Offset = "0xA8B4C0", VA = "0x180A8C2C0")]
		public void OptionClicked(Color color)
		{
		}

		// Token: 0x060065F4 RID: 26100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065F4")]
		[Address(RVA = "0xA8C3B0", Offset = "0xA8B5B0", VA = "0x180A8C3B0")]
		public CharacterCreatorColor()
		{
		}

		// Token: 0x040047D0 RID: 18384
		[Token(Token = "0x40047D0")]
		[FieldOffset(Offset = "0x0")]
		public static EClothingColor[] ClothingColorsToUse;

		// Token: 0x040047D1 RID: 18385
		[Token(Token = "0x40047D1")]
		[FieldOffset(Offset = "0x50")]
		[Header("References")]
		public RectTransform OptionContainer;

		// Token: 0x040047D2 RID: 18386
		[Token(Token = "0x40047D2")]
		[FieldOffset(Offset = "0x58")]
		[Header("Settings")]
		public bool UseClothingColors;

		// Token: 0x040047D3 RID: 18387
		[Token(Token = "0x40047D3")]
		[FieldOffset(Offset = "0x60")]
		public List<Color> Colors;

		// Token: 0x040047D4 RID: 18388
		[Token(Token = "0x40047D4")]
		[FieldOffset(Offset = "0x68")]
		public GameObject OptionPrefab;

		// Token: 0x040047D5 RID: 18389
		[Token(Token = "0x40047D5")]
		[FieldOffset(Offset = "0x70")]
		private List<Button> optionButtons;

		// Token: 0x040047D6 RID: 18390
		[Token(Token = "0x40047D6")]
		[FieldOffset(Offset = "0x78")]
		private Button selectedButton;
	}
}
