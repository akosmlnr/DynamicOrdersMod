using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.StationFramework;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Stations
{
	// Token: 0x02000CDB RID: 3291
	[Token(Token = "0x2000CDB")]
	public class ChemistryStationCanvas : Singleton<ChemistryStationCanvas>
	{
		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x06005FE4 RID: 24548 RVA: 0x00017F58 File Offset: 0x00016158
		// (set) Token: 0x06005FE5 RID: 24549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DE2")]
		public bool isOpen
		{
			[Token(Token = "0x6005FE4")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005FE5")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x06005FE6 RID: 24550 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06005FE7 RID: 24551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DE3")]
		public ChemistryStation ChemistryStation
		{
			[Token(Token = "0x6005FE6")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005FE7")]
			[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005FE8 RID: 24552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FE8")]
		[Address(RVA = "0xA22800", Offset = "0xA21A00", VA = "0x180A22800", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005FE9 RID: 24553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FE9")]
		[Address(RVA = "0xA23DC0", Offset = "0xA22FC0", VA = "0x180A23DC0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06005FEA RID: 24554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FEA")]
		[Address(RVA = "0xA245D0", Offset = "0xA237D0", VA = "0x180A245D0", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x06005FEB RID: 24555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FEB")]
		[Address(RVA = "0xA22FC0", Offset = "0xA221C0", VA = "0x180A22FC0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06005FEC RID: 24556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FEC")]
		[Address(RVA = "0xA242C0", Offset = "0xA234C0", VA = "0x180A242C0")]
		private void UpdateUI()
		{
		}

		// Token: 0x06005FED RID: 24557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FED")]
		[Address(RVA = "0xA24040", Offset = "0xA23240", VA = "0x180A24040")]
		private void UpdateInput()
		{
		}

		// Token: 0x06005FEE RID: 24558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FEE")]
		[Address(RVA = "0xA23090", Offset = "0xA22290", VA = "0x180A23090")]
		public void Open(ChemistryStation station)
		{
		}

		// Token: 0x06005FEF RID: 24559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FEF")]
		[Address(RVA = "0xA22B10", Offset = "0xA21D10", VA = "0x180A22B10")]
		public void Close(bool removeUI)
		{
		}

		// Token: 0x06005FF0 RID: 24560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FF0")]
		[Address(RVA = "0xA22A30", Offset = "0xA21C30", VA = "0x180A22A30")]
		public void BeginButtonPressed()
		{
		}

		// Token: 0x06005FF1 RID: 24561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FF1")]
		[Address(RVA = "0xA23EA0", Offset = "0xA230A0", VA = "0x180A23EA0")]
		private void StationSlotsChanged()
		{
		}

		// Token: 0x06005FF2 RID: 24562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FF2")]
		[Address(RVA = "0xA23A50", Offset = "0xA22C50", VA = "0x180A23A50")]
		private void SortRecipes(List<ItemInstance> ingredients)
		{
		}

		// Token: 0x06005FF3 RID: 24563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FF3")]
		[Address(RVA = "0xA23930", Offset = "0xA22B30", VA = "0x180A23930")]
		private void SetSelectedRecipe(StationRecipeEntry entry)
		{
		}

		// Token: 0x06005FF4 RID: 24564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FF4")]
		[Address(RVA = "0xA248A0", Offset = "0xA23AA0", VA = "0x180A248A0")]
		public ChemistryStationCanvas()
		{
		}

		// Token: 0x04004238 RID: 16952
		[Token(Token = "0x4004238")]
		[FieldOffset(Offset = "0x38")]
		public List<StationRecipe> Recipes;

		// Token: 0x04004239 RID: 16953
		[Token(Token = "0x4004239")]
		[FieldOffset(Offset = "0x40")]
		[Header("Prefabs")]
		public StationRecipeEntry RecipeEntryPrefab;

		// Token: 0x0400423A RID: 16954
		[Token(Token = "0x400423A")]
		[FieldOffset(Offset = "0x48")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x0400423B RID: 16955
		[Token(Token = "0x400423B")]
		[FieldOffset(Offset = "0x50")]
		public UIScreen UIScreen;

		// Token: 0x0400423C RID: 16956
		[Token(Token = "0x400423C")]
		[FieldOffset(Offset = "0x58")]
		public RectTransform Container;

		// Token: 0x0400423D RID: 16957
		[Token(Token = "0x400423D")]
		[FieldOffset(Offset = "0x60")]
		public RectTransform InputSlotsContainer;

		// Token: 0x0400423E RID: 16958
		[Token(Token = "0x400423E")]
		[FieldOffset(Offset = "0x68")]
		public ItemSlotUI[] InputSlotUIs;

		// Token: 0x0400423F RID: 16959
		[Token(Token = "0x400423F")]
		[FieldOffset(Offset = "0x70")]
		public ItemSlotUI OutputSlotUI;

		// Token: 0x04004240 RID: 16960
		[Token(Token = "0x4004240")]
		[FieldOffset(Offset = "0x78")]
		public RectTransform RecipeSelectionContainer;

		// Token: 0x04004241 RID: 16961
		[Token(Token = "0x4004241")]
		[FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI InstructionLabel;

		// Token: 0x04004242 RID: 16962
		[Token(Token = "0x4004242")]
		[FieldOffset(Offset = "0x88")]
		public Button BeginButton;

		// Token: 0x04004243 RID: 16963
		[Token(Token = "0x4004243")]
		[FieldOffset(Offset = "0x90")]
		public RectTransform SelectionIndicator;

		// Token: 0x04004244 RID: 16964
		[Token(Token = "0x4004244")]
		[FieldOffset(Offset = "0x98")]
		public RectTransform RecipeContainer;

		// Token: 0x04004245 RID: 16965
		[Token(Token = "0x4004245")]
		[FieldOffset(Offset = "0xA0")]
		public RectTransform CookingInProgressContainer;

		// Token: 0x04004246 RID: 16966
		[Token(Token = "0x4004246")]
		[FieldOffset(Offset = "0xA8")]
		public StationRecipeEntry InProgressRecipeEntry;

		// Token: 0x04004247 RID: 16967
		[Token(Token = "0x4004247")]
		[FieldOffset(Offset = "0xB0")]
		public TextMeshProUGUI InProgressLabel;

		// Token: 0x04004248 RID: 16968
		[Token(Token = "0x4004248")]
		[FieldOffset(Offset = "0xB8")]
		public TextMeshProUGUI ErrorLabel;

		// Token: 0x04004249 RID: 16969
		[Token(Token = "0x4004249")]
		[FieldOffset(Offset = "0xC0")]
		private List<StationRecipeEntry> recipeEntries;

		// Token: 0x0400424A RID: 16970
		[Token(Token = "0x400424A")]
		[FieldOffset(Offset = "0xC8")]
		private StationRecipeEntry selectedRecipe;
	}
}
