using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.StationFramework;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Stations
{
	// Token: 0x02000CDD RID: 3293
	[Token(Token = "0x2000CDD")]
	public class StationRecipeEntry : MonoBehaviour
	{
		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x06005FF7 RID: 24567 RVA: 0x00017F88 File Offset: 0x00016188
		// (set) Token: 0x06005FF8 RID: 24568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DE4")]
		public bool IsValid
		{
			[Token(Token = "0x6005FF7")]
			[Address(RVA = "0x49B030", Offset = "0x49A230", VA = "0x18049B030")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005FF8")]
			[Address(RVA = "0x49B240", Offset = "0x49A440", VA = "0x18049B240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x06005FF9 RID: 24569 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06005FFA RID: 24570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DE5")]
		public StationRecipe Recipe
		{
			[Token(Token = "0x6005FF9")]
			[Address(RVA = "0x497910", Offset = "0x496B10", VA = "0x180497910")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005FFA")]
			[Address(RVA = "0x497930", Offset = "0x496B30", VA = "0x180497930")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005FFB RID: 24571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FFB")]
		[Address(RVA = "0xA35570", Offset = "0xA34770", VA = "0x180A35570")]
		public void AssignRecipe(StationRecipe recipe)
		{
		}

		// Token: 0x06005FFC RID: 24572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FFC")]
		[Address(RVA = "0xA36050", Offset = "0xA35250", VA = "0x180A36050")]
		public void RefreshValidity(List<ItemInstance> ingredients)
		{
		}

		// Token: 0x06005FFD RID: 24573 RVA: 0x00017FA0 File Offset: 0x000161A0
		[Token(Token = "0x6005FFD")]
		[Address(RVA = "0xA35BD0", Offset = "0xA34DD0", VA = "0x180A35BD0")]
		public float GetIngredientsMatchDelta(List<ItemInstance> ingredients)
		{
			return 0f;
		}

		// Token: 0x06005FFE RID: 24574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FFE")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public StationRecipeEntry()
		{
		}

		// Token: 0x0400424C RID: 16972
		[Token(Token = "0x400424C")]
		[FieldOffset(Offset = "0x0")]
		public static Color ValidColor;

		// Token: 0x0400424D RID: 16973
		[Token(Token = "0x400424D")]
		[FieldOffset(Offset = "0x10")]
		public static Color InvalidColor;

		// Token: 0x0400424E RID: 16974
		[Token(Token = "0x400424E")]
		[FieldOffset(Offset = "0x20")]
		public Button Button;

		// Token: 0x0400424F RID: 16975
		[Token(Token = "0x400424F")]
		[FieldOffset(Offset = "0x28")]
		public Image Icon;

		// Token: 0x04004250 RID: 16976
		[Token(Token = "0x4004250")]
		[FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI TitleLabel;

		// Token: 0x04004251 RID: 16977
		[Token(Token = "0x4004251")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI CookingTimeLabel;

		// Token: 0x04004252 RID: 16978
		[Token(Token = "0x4004252")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform[] IngredientRects;

		// Token: 0x04004253 RID: 16979
		[Token(Token = "0x4004253")]
		[FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI[] IngredientQuantities;
	}
}
