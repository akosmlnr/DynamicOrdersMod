using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Product;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone
{
	// Token: 0x02000D0F RID: 3343
	[Token(Token = "0x2000D0F")]
	public class CounterOfferProductSelector : MonoBehaviour
	{
		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06006142 RID: 24898 RVA: 0x000181E0 File Offset: 0x000163E0
		// (set) Token: 0x06006143 RID: 24899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DFC")]
		public bool IsOpen
		{
			[Token(Token = "0x6006142")]
			[Address(RVA = "0x4D4690", Offset = "0x4D3890", VA = "0x1804D4690")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006143")]
			[Address(RVA = "0x4D4A40", Offset = "0x4D3C40", VA = "0x1804D4A40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006144 RID: 24900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006144")]
		[Address(RVA = "0xA3CD50", Offset = "0xA3BF50", VA = "0x180A3CD50")]
		public void Awake()
		{
		}

		// Token: 0x06006145 RID: 24901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006145")]
		[Address(RVA = "0xA3DEC0", Offset = "0xA3D0C0", VA = "0x180A3DEC0")]
		public void Open()
		{
		}

		// Token: 0x06006146 RID: 24902 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006146")]
		[Address(RVA = "0xA3D2F0", Offset = "0xA3C4F0", VA = "0x180A3D2F0")]
		private IEnumerator DelaySelectSearchPanel()
		{
			return null;
		}

		// Token: 0x06006147 RID: 24903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006147")]
		[Address(RVA = "0xA3CE10", Offset = "0xA3C010", VA = "0x180A3CE10")]
		public void Close()
		{
		}

		// Token: 0x06006148 RID: 24904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006148")]
		[Address(RVA = "0xA3EAD0", Offset = "0xA3DCD0", VA = "0x180A3EAD0")]
		private void Update()
		{
		}

		// Token: 0x06006149 RID: 24905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006149")]
		[Address(RVA = "0xA3E9B0", Offset = "0xA3DBB0", VA = "0x180A3E9B0")]
		public void SetSearchTerm(string search)
		{
		}

		// Token: 0x0600614A RID: 24906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600614A")]
		[Address(RVA = "0xA3E1B0", Offset = "0xA3D3B0", VA = "0x180A3E1B0")]
		private void RebuildResultsList()
		{
		}

		// Token: 0x0600614B RID: 24907 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600614B")]
		[Address(RVA = "0xA3D4F0", Offset = "0xA3C6F0", VA = "0x180A3D4F0")]
		private List<ProductDefinition> GetMatchingProducts(string searchTerm)
		{
			return null;
		}

		// Token: 0x0600614C RID: 24908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600614C")]
		[Address(RVA = "0xA3D360", Offset = "0xA3C560", VA = "0x180A3D360")]
		private void EnsureAllEntriesExist()
		{
		}

		// Token: 0x0600614D RID: 24909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600614D")]
		[Address(RVA = "0xA3CEC0", Offset = "0xA3C0C0", VA = "0x180A3CEC0")]
		private void CreateProductEntry(ProductDefinition product)
		{
		}

		// Token: 0x0600614E RID: 24910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600614E")]
		[Address(RVA = "0xA3CE00", Offset = "0xA3C000", VA = "0x180A3CE00")]
		public void ChangePage(int change)
		{
		}

		// Token: 0x0600614F RID: 24911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600614F")]
		[Address(RVA = "0xA3E420", Offset = "0xA3D620", VA = "0x180A3E420")]
		private void SetPage(int page)
		{
		}

		// Token: 0x06006150 RID: 24912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006150")]
		[Address(RVA = "0xA3E120", Offset = "0xA3D320", VA = "0x180A3E120")]
		private void ProductHovered(ProductDefinition def)
		{
		}

		// Token: 0x06006151 RID: 24913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006151")]
		[Address(RVA = "0xA3E170", Offset = "0xA3D370", VA = "0x180A3E170")]
		private void ProductSelected(ProductDefinition def)
		{
		}

		// Token: 0x06006152 RID: 24914 RVA: 0x000181F8 File Offset: 0x000163F8
		[Token(Token = "0x6006152")]
		[Address(RVA = "0xA3DD30", Offset = "0xA3CF30", VA = "0x180A3DD30")]
		public bool IsMouseOverSelector()
		{
			return default(bool);
		}

		// Token: 0x06006153 RID: 24915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006153")]
		[Address(RVA = "0xA3EBA0", Offset = "0xA3DDA0", VA = "0x180A3EBA0")]
		public CounterOfferProductSelector()
		{
		}

		// Token: 0x04004338 RID: 17208
		[Token(Token = "0x4004338")]
		public const int ENTRIES_PER_PAGE = 25;

		// Token: 0x04004339 RID: 17209
		[Token(Token = "0x4004339")]
		[FieldOffset(Offset = "0x20")]
		public RectTransform Container;

		// Token: 0x0400433A RID: 17210
		[Token(Token = "0x400433A")]
		[FieldOffset(Offset = "0x28")]
		public InputField SearchBar;

		// Token: 0x0400433B RID: 17211
		[Token(Token = "0x400433B")]
		[FieldOffset(Offset = "0x30")]
		public RectTransform ProductContainer;

		// Token: 0x0400433C RID: 17212
		[Token(Token = "0x400433C")]
		[FieldOffset(Offset = "0x38")]
		public Text PageLabel;

		// Token: 0x0400433D RID: 17213
		[Token(Token = "0x400433D")]
		[FieldOffset(Offset = "0x40")]
		public GameObject ProductEntryPrefab;

		// Token: 0x0400433F RID: 17215
		[Token(Token = "0x400433F")]
		[FieldOffset(Offset = "0x50")]
		public Action<ProductDefinition> onProductPreviewed;

		// Token: 0x04004340 RID: 17216
		[Token(Token = "0x4004340")]
		[FieldOffset(Offset = "0x58")]
		public Action<ProductDefinition> onProductSelected;

		// Token: 0x04004341 RID: 17217
		[Token(Token = "0x4004341")]
		[FieldOffset(Offset = "0x60")]
		[Header("Custom UI")]
		public UIScreen uiSelectionScreen;

		// Token: 0x04004342 RID: 17218
		[Token(Token = "0x4004342")]
		[FieldOffset(Offset = "0x68")]
		public UIPanel uiSearchPanel;

		// Token: 0x04004343 RID: 17219
		[Token(Token = "0x4004343")]
		[FieldOffset(Offset = "0x70")]
		public UIPanel uiWindowPanel;

		// Token: 0x04004344 RID: 17220
		[Token(Token = "0x4004344")]
		[FieldOffset(Offset = "0x78")]
		private List<RectTransform> productEntries;

		// Token: 0x04004345 RID: 17221
		[Token(Token = "0x4004345")]
		[FieldOffset(Offset = "0x80")]
		private Dictionary<ProductDefinition, RectTransform> productEntriesDict;

		// Token: 0x04004346 RID: 17222
		[Token(Token = "0x4004346")]
		[FieldOffset(Offset = "0x88")]
		private string searchTerm;

		// Token: 0x04004347 RID: 17223
		[Token(Token = "0x4004347")]
		[FieldOffset(Offset = "0x90")]
		private int pageIndex;

		// Token: 0x04004348 RID: 17224
		[Token(Token = "0x4004348")]
		[FieldOffset(Offset = "0x94")]
		private int pageCount;

		// Token: 0x04004349 RID: 17225
		[Token(Token = "0x4004349")]
		[FieldOffset(Offset = "0x98")]
		private List<ProductDefinition> results;

		// Token: 0x0400434A RID: 17226
		[Token(Token = "0x400434A")]
		[FieldOffset(Offset = "0xA0")]
		private ProductDefinition lastPreviewedResult;
	}
}
