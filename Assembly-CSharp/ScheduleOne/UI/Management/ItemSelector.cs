using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D8D RID: 3469
	[Token(Token = "0x2000D8D")]
	public class ItemSelector : ClipboardScreen
	{
		// Token: 0x06006416 RID: 25622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006416")]
		[Address(RVA = "0xA5EBE0", Offset = "0xA5DDE0", VA = "0x180A5EBE0")]
		public void Initialize(string selectionTitle, List<ItemSelector.Option> _options, [Optional] ItemSelector.Option _selectedOption, [Optional] Action<ItemSelector.Option> _optionCallback)
		{
		}

		// Token: 0x06006417 RID: 25623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006417")]
		[Address(RVA = "0xA5EF80", Offset = "0xA5E180", VA = "0x180A5EF80", Slot = "5")]
		public override void Open()
		{
		}

		// Token: 0x06006418 RID: 25624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006418")]
		[Address(RVA = "0xA5DF80", Offset = "0xA5D180", VA = "0x180A5DF80", Slot = "6")]
		public override void Close()
		{
		}

		// Token: 0x06006419 RID: 25625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006419")]
		[Address(RVA = "0xA5DDC0", Offset = "0xA5CFC0", VA = "0x180A5DDC0")]
		private void ButtonClicked(ItemSelector.Option option)
		{
		}

		// Token: 0x0600641A RID: 25626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600641A")]
		[Address(RVA = "0xA5DE40", Offset = "0xA5D040", VA = "0x180A5DE40")]
		private void ButtonHovered(ItemSelector.Option option)
		{
		}

		// Token: 0x0600641B RID: 25627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600641B")]
		[Address(RVA = "0xA5DE10", Offset = "0xA5D010", VA = "0x180A5DE10")]
		private void ButtonHoverEnd(ItemSelector.Option option)
		{
		}

		// Token: 0x0600641C RID: 25628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600641C")]
		[Address(RVA = "0xA5E100", Offset = "0xA5D300", VA = "0x180A5E100")]
		private void CreateOptions(List<ItemSelector.Option> options)
		{
		}

		// Token: 0x0600641D RID: 25629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600641D")]
		[Address(RVA = "0xA5E9C0", Offset = "0xA5DBC0", VA = "0x180A5E9C0")]
		private void DeleteOptions()
		{
		}

		// Token: 0x0600641E RID: 25630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600641E")]
		[Address(RVA = "0xA5EAF0", Offset = "0xA5DCF0", VA = "0x180A5EAF0")]
		private void InitializeAfterUIReady()
		{
		}

		// Token: 0x0600641F RID: 25631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600641F")]
		[Address(RVA = "0xA5F1B0", Offset = "0xA5E3B0", VA = "0x180A5F1B0")]
		public ItemSelector()
		{
		}

		// Token: 0x06006420 RID: 25632 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006420")]
		[Address(RVA = "0xA5F140", Offset = "0xA5E340", VA = "0x180A5F140")]
		[CompilerGenerated]
		private IEnumerator <InitializeAfterUIReady>g__routine|20_0()
		{
			return null;
		}

		// Token: 0x0400462E RID: 17966
		[Token(Token = "0x400462E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("References")]
		public RectTransform OptionContainer;

		// Token: 0x0400462F RID: 17967
		[Token(Token = "0x400462F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI TitleLabel;

		// Token: 0x04004630 RID: 17968
		[Token(Token = "0x4004630")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI HoveredItemLabel;

		// Token: 0x04004631 RID: 17969
		[Token(Token = "0x4004631")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public GameObject OptionPrefab;

		// Token: 0x04004632 RID: 17970
		[Token(Token = "0x4004632")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("Settings")]
		public Sprite EmptyOptionSprite;

		// Token: 0x04004633 RID: 17971
		[Token(Token = "0x4004633")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Coroutine lerpRoutine;

		// Token: 0x04004634 RID: 17972
		[Token(Token = "0x4004634")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<ItemSelector.Option> options;

		// Token: 0x04004635 RID: 17973
		[Token(Token = "0x4004635")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ItemSelector.Option selectedOption;

		// Token: 0x04004636 RID: 17974
		[Token(Token = "0x4004636")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<RectTransform> optionButtons;

		// Token: 0x04004637 RID: 17975
		[Token(Token = "0x4004637")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Action<ItemSelector.Option> optionCallback;

		// Token: 0x04004638 RID: 17976
		[Token(Token = "0x4004638")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private UIContentPanel panel;

		// Token: 0x02000D8E RID: 3470
		[Token(Token = "0x2000D8E")]
		[Serializable]
		public class Option
		{
			// Token: 0x06006421 RID: 25633 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006421")]
			[Address(RVA = "0x5FCA60", Offset = "0x5FBC60", VA = "0x1805FCA60")]
			public Option(string title, ItemDefinition item)
			{
			}

			// Token: 0x04004639 RID: 17977
			[Token(Token = "0x4004639")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Title;

			// Token: 0x0400463A RID: 17978
			[Token(Token = "0x400463A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ItemDefinition Item;
		}
	}
}
