using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Core.Items.Framework;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Items
{
	// Token: 0x02000DEF RID: 3567
	[Token(Token = "0x2000DEF")]
	public class FilterConfigPanel : MonoBehaviour
	{
		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x06006642 RID: 26178 RVA: 0x00018EE8 File Offset: 0x000170E8
		// (set) Token: 0x06006643 RID: 26179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E87")]
		public bool IsOpen
		{
			[Token(Token = "0x6006642")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006643")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x06006644 RID: 26180 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06006645 RID: 26181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E88")]
		public ItemSlot OpenSlot
		{
			[Token(Token = "0x6006644")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006645")]
			[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006646 RID: 26182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006646")]
		[Address(RVA = "0xA91810", Offset = "0xA90A10", VA = "0x180A91810")]
		private void Awake()
		{
		}

		// Token: 0x06006647 RID: 26183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006647")]
		[Address(RVA = "0xA93B70", Offset = "0xA92D70", VA = "0x180A93B70")]
		private void Start()
		{
		}

		// Token: 0x06006648 RID: 26184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006648")]
		[Address(RVA = "0xA91DD0", Offset = "0xA90FD0", VA = "0x180A91DD0")]
		private void Exit(ExitAction exit)
		{
		}

		// Token: 0x06006649 RID: 26185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006649")]
		[Address(RVA = "0xA942F0", Offset = "0xA934F0", VA = "0x180A942F0")]
		private void Update()
		{
		}

		// Token: 0x0600664A RID: 26186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600664A")]
		[Address(RVA = "0xA929A0", Offset = "0xA91BA0", VA = "0x180A929A0")]
		public void Open(ItemSlotUI ui)
		{
		}

		// Token: 0x0600664B RID: 26187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600664B")]
		[Address(RVA = "0xA91A60", Offset = "0xA90C60", VA = "0x180A91A60")]
		public void Close()
		{
		}

		// Token: 0x0600664C RID: 26188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600664C")]
		[Address(RVA = "0xA93C60", Offset = "0xA92E60", VA = "0x180A93C60")]
		private void UpdateSearch()
		{
		}

		// Token: 0x0600664D RID: 26189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600664D")]
		[Address(RVA = "0xA91E70", Offset = "0xA91070", VA = "0x180A91E70")]
		public void FilterModeSelected(int filterType)
		{
		}

		// Token: 0x0600664E RID: 26190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600664E")]
		[Address(RVA = "0xA91E70", Offset = "0xA91070", VA = "0x180A91E70")]
		public void FilterModeSelected(SlotFilter.EType filterType)
		{
		}

		// Token: 0x0600664F RID: 26191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600664F")]
		[Address(RVA = "0xA92F60", Offset = "0xA92160", VA = "0x180A92F60")]
		public void QualitySelected(int quality)
		{
		}

		// Token: 0x06006650 RID: 26192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006650")]
		[Address(RVA = "0xA92F60", Offset = "0xA92160", VA = "0x180A92F60")]
		public void QualitySelected(EQuality quality)
		{
		}

		// Token: 0x06006651 RID: 26193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006651")]
		[Address(RVA = "0xA914D0", Offset = "0xA906D0", VA = "0x180A914D0")]
		public void AddClicked()
		{
		}

		// Token: 0x06006652 RID: 26194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006652")]
		[Address(RVA = "0xA91CD0", Offset = "0xA90ED0", VA = "0x180A91CD0")]
		public void CopyClicked()
		{
		}

		// Token: 0x06006653 RID: 26195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006653")]
		[Address(RVA = "0xA92ED0", Offset = "0xA920D0", VA = "0x180A92ED0")]
		public void PasteClicked()
		{
		}

		// Token: 0x06006654 RID: 26196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006654")]
		[Address(RVA = "0xA91650", Offset = "0xA90850", VA = "0x180A91650")]
		public void ApplyToSiblingsClicked()
		{
		}

		// Token: 0x06006655 RID: 26197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006655")]
		[Address(RVA = "0xA91930", Offset = "0xA90B30", VA = "0x180A91930")]
		public void ClearClicked()
		{
		}

		// Token: 0x06006656 RID: 26198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006656")]
		[Address(RVA = "0xA93B80", Offset = "0xA92D80", VA = "0x180A93B80")]
		public void ToggleDropdown()
		{
		}

		// Token: 0x06006657 RID: 26199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006657")]
		[Address(RVA = "0xA92750", Offset = "0xA91950", VA = "0x180A92750")]
		public void OpenDropdown()
		{
		}

		// Token: 0x06006658 RID: 26200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006658")]
		[Address(RVA = "0xA919E0", Offset = "0xA90BE0", VA = "0x180A919E0")]
		public void CloseDropdown()
		{
		}

		// Token: 0x06006659 RID: 26201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006659")]
		[Address(RVA = "0xA92650", Offset = "0xA91850", VA = "0x180A92650")]
		private void ItemClicked(string itemID)
		{
		}

		// Token: 0x0600665A RID: 26202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600665A")]
		[Address(RVA = "0xA915A0", Offset = "0xA907A0", VA = "0x180A915A0")]
		private void AddItem(string itemID)
		{
		}

		// Token: 0x0600665B RID: 26203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600665B")]
		[Address(RVA = "0xA93AD0", Offset = "0xA92CD0", VA = "0x180A93AD0")]
		private void RemoveItem(string itemID)
		{
		}

		// Token: 0x0600665C RID: 26204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600665C")]
		[Address(RVA = "0xA93080", Offset = "0xA92280", VA = "0x180A93080")]
		private void RefreshDisplay()
		{
		}

		// Token: 0x0600665D RID: 26205 RVA: 0x00018F00 File Offset: 0x00017100
		[Token(Token = "0x600665D")]
		[Address(RVA = "0xA92410", Offset = "0xA91610", VA = "0x180A92410")]
		private bool IsMouseOverPanel()
		{
			return default(bool);
		}

		// Token: 0x0600665E RID: 26206 RVA: 0x00018F18 File Offset: 0x00017118
		[Token(Token = "0x600665E")]
		[Address(RVA = "0xA92550", Offset = "0xA91750", VA = "0x180A92550")]
		private bool IsMouseOverSearch()
		{
			return default(bool);
		}

		// Token: 0x0600665F RID: 26207 RVA: 0x00018F30 File Offset: 0x00017130
		[Token(Token = "0x600665F")]
		[Address(RVA = "0xA92310", Offset = "0xA91510", VA = "0x180A92310")]
		private bool IsMouseOverDropdown()
		{
			return default(bool);
		}

		// Token: 0x06006660 RID: 26208 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006660")]
		[Address(RVA = "0xA91EB0", Offset = "0xA910B0", VA = "0x180A91EB0")]
		private FilterConfigPanel.SearchCategory GetSearchCategory(EItemCategory category)
		{
			return null;
		}

		// Token: 0x06006661 RID: 26209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006661")]
		[Address(RVA = "0xA928D0", Offset = "0xA91AD0", VA = "0x180A928D0")]
		private void OpenSearch()
		{
		}

		// Token: 0x06006662 RID: 26210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006662")]
		[Address(RVA = "0xA91A20", Offset = "0xA90C20", VA = "0x180A91A20")]
		private void CloseSearch()
		{
		}

		// Token: 0x06006663 RID: 26211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006663")]
		[Address(RVA = "0xA93B60", Offset = "0xA92D60", VA = "0x180A93B60")]
		private void SearchChanged(string search)
		{
		}

		// Token: 0x06006664 RID: 26212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006664")]
		[Address(RVA = "0xA93990", Offset = "0xA92B90", VA = "0x180A93990")]
		private void RefreshSearchResults()
		{
		}

		// Token: 0x06006665 RID: 26213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006665")]
		[Address(RVA = "0xA94760", Offset = "0xA93960", VA = "0x180A94760")]
		public FilterConfigPanel()
		{
		}

		// Token: 0x06006666 RID: 26214 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006666")]
		[Address(RVA = "0xA93BF0", Offset = "0xA92DF0", VA = "0x180A93BF0")]
		[CompilerGenerated]
		private IEnumerator <Open>g__Open|39_0()
		{
			return null;
		}

		// Token: 0x04004820 RID: 18464
		[Token(Token = "0x4004820")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ItemEntryPrefab;

		// Token: 0x04004821 RID: 18465
		[Token(Token = "0x4004821")]
		[FieldOffset(Offset = "0x38")]
		public GameObject CategoryPrefab;

		// Token: 0x04004822 RID: 18466
		[Token(Token = "0x4004822")]
		[FieldOffset(Offset = "0x40")]
		public GameObject SearchItemPrefab;

		// Token: 0x04004823 RID: 18467
		[Token(Token = "0x4004823")]
		[FieldOffset(Offset = "0x48")]
		[Header("References")]
		public RectTransform Rect;

		// Token: 0x04004824 RID: 18468
		[Token(Token = "0x4004824")]
		[FieldOffset(Offset = "0x50")]
		public GameObject Container;

		// Token: 0x04004825 RID: 18469
		[Token(Token = "0x4004825")]
		[FieldOffset(Offset = "0x58")]
		public Button TypeButton_None;

		// Token: 0x04004826 RID: 18470
		[Token(Token = "0x4004826")]
		[FieldOffset(Offset = "0x60")]
		public Button TypeButton_Whitelist;

		// Token: 0x04004827 RID: 18471
		[Token(Token = "0x4004827")]
		[FieldOffset(Offset = "0x68")]
		public Button TypeButton_Blacklist;

		// Token: 0x04004828 RID: 18472
		[Token(Token = "0x4004828")]
		[FieldOffset(Offset = "0x70")]
		public TextMeshProUGUI TypeLabel;

		// Token: 0x04004829 RID: 18473
		[Token(Token = "0x4004829")]
		[FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI ListLabel;

		// Token: 0x0400482A RID: 18474
		[Token(Token = "0x400482A")]
		[FieldOffset(Offset = "0x80")]
		public RectTransform ListContainer;

		// Token: 0x0400482B RID: 18475
		[Token(Token = "0x400482B")]
		[FieldOffset(Offset = "0x88")]
		public GameObject ListBlocker;

		// Token: 0x0400482C RID: 18476
		[Token(Token = "0x400482C")]
		[FieldOffset(Offset = "0x90")]
		public Button[] QualityButtons;

		// Token: 0x0400482D RID: 18477
		[Token(Token = "0x400482D")]
		[FieldOffset(Offset = "0x98")]
		public ScrollRect ListScrollRect;

		// Token: 0x0400482E RID: 18478
		[Token(Token = "0x400482E")]
		[FieldOffset(Offset = "0xA0")]
		public RectTransform Dropdown;

		// Token: 0x0400482F RID: 18479
		[Token(Token = "0x400482F")]
		[FieldOffset(Offset = "0xA8")]
		public Button CopyButton;

		// Token: 0x04004830 RID: 18480
		[Token(Token = "0x4004830")]
		[FieldOffset(Offset = "0xB0")]
		public Button PasteButton;

		// Token: 0x04004831 RID: 18481
		[Token(Token = "0x4004831")]
		[FieldOffset(Offset = "0xB8")]
		public Button ApplyToSiblingsButton;

		// Token: 0x04004832 RID: 18482
		[Token(Token = "0x4004832")]
		[FieldOffset(Offset = "0xC0")]
		public Button ClearButton;

		// Token: 0x04004833 RID: 18483
		[Token(Token = "0x4004833")]
		[FieldOffset(Offset = "0xC8")]
		[Header("Search")]
		public RectTransform SearchContainer;

		// Token: 0x04004834 RID: 18484
		[Token(Token = "0x4004834")]
		[FieldOffset(Offset = "0xD0")]
		public TMP_InputField SearchInput;

		// Token: 0x04004835 RID: 18485
		[Token(Token = "0x4004835")]
		[FieldOffset(Offset = "0xD8")]
		public RectTransform CategoryContainer;

		// Token: 0x04004836 RID: 18486
		[Token(Token = "0x4004836")]
		[FieldOffset(Offset = "0xE0")]
		private bool mouseUp;

		// Token: 0x04004837 RID: 18487
		[Token(Token = "0x4004837")]
		[FieldOffset(Offset = "0xE8")]
		private List<FilterConfigPanel.SearchCategory> searchCategories;

		// Token: 0x04004838 RID: 18488
		[Token(Token = "0x4004838")]
		[FieldOffset(Offset = "0xF0")]
		private List<RectTransform> itemEntries;

		// Token: 0x04004839 RID: 18489
		[Token(Token = "0x4004839")]
		[FieldOffset(Offset = "0x0")]
		private static SlotFilter copiedFilter;

		// Token: 0x02000DF0 RID: 3568
		[Token(Token = "0x2000DF0")]
		public class SearchCategory
		{
			// Token: 0x06006667 RID: 26215 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006667")]
			[Address(RVA = "0xA9C1C0", Offset = "0xA9B3C0", VA = "0x180A9C1C0")]
			public void AddItem(ItemDefinition item, RectTransform entry)
			{
			}

			// Token: 0x06006668 RID: 26216 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006668")]
			[Address(RVA = "0xA9C3B0", Offset = "0xA9B5B0", VA = "0x180A9C3B0")]
			public void SetSearch(string search)
			{
			}

			// Token: 0x06006669 RID: 26217 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x6006669")]
			[Address(RVA = "0xA9C2D0", Offset = "0xA9B4D0", VA = "0x180A9C2D0")]
			public FilterConfigPanel.SearchCategory.Item GetItem(string itemID)
			{
				return null;
			}

			// Token: 0x0600666A RID: 26218 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600666A")]
			[Address(RVA = "0xA9C5F0", Offset = "0xA9B7F0", VA = "0x180A9C5F0")]
			public SearchCategory()
			{
			}

			// Token: 0x0400483A RID: 18490
			[Token(Token = "0x400483A")]
			[FieldOffset(Offset = "0x10")]
			public EItemCategory Category;

			// Token: 0x0400483B RID: 18491
			[Token(Token = "0x400483B")]
			[FieldOffset(Offset = "0x18")]
			public RectTransform Container;

			// Token: 0x0400483C RID: 18492
			[Token(Token = "0x400483C")]
			[FieldOffset(Offset = "0x20")]
			public List<FilterConfigPanel.SearchCategory.Item> Items;

			// Token: 0x02000DF1 RID: 3569
			[Token(Token = "0x2000DF1")]
			public class Item
			{
				// Token: 0x0600666B RID: 26219 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600666B")]
				[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
				public Item()
				{
				}

				// Token: 0x0400483D RID: 18493
				[Token(Token = "0x400483D")]
				[FieldOffset(Offset = "0x10")]
				public ItemDefinition ItemDefinition;

				// Token: 0x0400483E RID: 18494
				[Token(Token = "0x400483E")]
				[FieldOffset(Offset = "0x18")]
				public RectTransform Entry;
			}
		}
	}
}
