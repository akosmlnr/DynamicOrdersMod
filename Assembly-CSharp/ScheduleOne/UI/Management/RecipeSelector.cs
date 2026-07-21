using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using ScheduleOne.StationFramework;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D97 RID: 3479
	[Token(Token = "0x2000D97")]
	public class RecipeSelector : ClipboardScreen
	{
		// Token: 0x06006467 RID: 25703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006467")]
		[Address(RVA = "0xA7FCC0", Offset = "0xA7EEC0", VA = "0x180A7FCC0")]
		public void Initialize(string selectionTitle, List<StationRecipe> _options, [Optional] StationRecipe _selectedOption, [Optional] Action<StationRecipe> _optionCallback)
		{
		}

		// Token: 0x06006468 RID: 25704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006468")]
		[Address(RVA = "0xA7FF80", Offset = "0xA7F180", VA = "0x180A7FF80", Slot = "5")]
		public override void Open()
		{
		}

		// Token: 0x06006469 RID: 25705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006469")]
		[Address(RVA = "0xA7F4E0", Offset = "0xA7E6E0", VA = "0x180A7F4E0", Slot = "6")]
		public override void Close()
		{
		}

		// Token: 0x0600646A RID: 25706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600646A")]
		[Address(RVA = "0xA7F490", Offset = "0xA7E690", VA = "0x180A7F490")]
		private void ButtonClicked(StationRecipe option)
		{
		}

		// Token: 0x0600646B RID: 25707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600646B")]
		[Address(RVA = "0xA7F620", Offset = "0xA7E820", VA = "0x180A7F620")]
		private void CreateOptions(List<StationRecipe> options)
		{
		}

		// Token: 0x0600646C RID: 25708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600646C")]
		[Address(RVA = "0xA7FB90", Offset = "0xA7ED90", VA = "0x180A7FB90")]
		private void DeleteOptions()
		{
		}

		// Token: 0x0600646D RID: 25709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600646D")]
		[Address(RVA = "0xA801E0", Offset = "0xA7F3E0", VA = "0x180A801E0")]
		public RecipeSelector()
		{
		}

		// Token: 0x0400466B RID: 18027
		[Token(Token = "0x400466B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("References")]
		public RectTransform OptionContainer;

		// Token: 0x0400466C RID: 18028
		[Token(Token = "0x400466C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI TitleLabel;

		// Token: 0x0400466D RID: 18029
		[Token(Token = "0x400466D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject OptionPrefab;

		// Token: 0x0400466E RID: 18030
		[Token(Token = "0x400466E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("Settings")]
		public Sprite EmptyOptionSprite;

		// Token: 0x0400466F RID: 18031
		[Token(Token = "0x400466F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Coroutine lerpRoutine;

		// Token: 0x04004670 RID: 18032
		[Token(Token = "0x4004670")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<StationRecipe> options;

		// Token: 0x04004671 RID: 18033
		[Token(Token = "0x4004671")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private StationRecipe selectedOption;

		// Token: 0x04004672 RID: 18034
		[Token(Token = "0x4004672")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<RectTransform> optionButtons;

		// Token: 0x04004673 RID: 18035
		[Token(Token = "0x4004673")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Action<StationRecipe> optionCallback;

		// Token: 0x04004674 RID: 18036
		[Token(Token = "0x4004674")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private UIContentPanel panel;
	}
}
