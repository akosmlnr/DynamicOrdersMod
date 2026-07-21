using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Map;
using ScheduleOne.NPCs;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.ContactsApp
{
	// Token: 0x02000D69 RID: 3433
	[Token(Token = "0x2000D69")]
	public class ContactsDetailPanel : MonoBehaviour
	{
		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x0600636A RID: 25450 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600636B RID: 25451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E41")]
		public NPC SelectedNPC
		{
			[Token(Token = "0x600636A")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600636B")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600636C RID: 25452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600636C")]
		[Address(RVA = "0xA5A470", Offset = "0xA59670", VA = "0x180A5A470")]
		public void Open(NPC npc)
		{
		}

		// Token: 0x0600636D RID: 25453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600636D")]
		[Address(RVA = "0xA5BD30", Offset = "0xA5AF30", VA = "0x180A5BD30")]
		public void ShowOnMap()
		{
		}

		// Token: 0x0600636E RID: 25454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600636E")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ContactsDetailPanel()
		{
		}

		// Token: 0x0400458C RID: 17804
		[Token(Token = "0x400458C")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		public Color DependenceColor_Min;

		// Token: 0x0400458D RID: 17805
		[Token(Token = "0x400458D")]
		[FieldOffset(Offset = "0x38")]
		public Color DependenceColor_Max;

		// Token: 0x0400458E RID: 17806
		[Token(Token = "0x400458E")]
		[FieldOffset(Offset = "0x48")]
		[Header("References")]
		public Text NameLabel;

		// Token: 0x0400458F RID: 17807
		[Token(Token = "0x400458F")]
		[FieldOffset(Offset = "0x50")]
		public Text TypeLabel;

		// Token: 0x04004590 RID: 17808
		[Token(Token = "0x4004590")]
		[FieldOffset(Offset = "0x58")]
		public Text UnlockHintLabel;

		// Token: 0x04004591 RID: 17809
		[Token(Token = "0x4004591")]
		[FieldOffset(Offset = "0x60")]
		public RectTransform RelationshipContainer;

		// Token: 0x04004592 RID: 17810
		[Token(Token = "0x4004592")]
		[FieldOffset(Offset = "0x68")]
		public Scrollbar RelationshipScrollbar;

		// Token: 0x04004593 RID: 17811
		[Token(Token = "0x4004593")]
		[FieldOffset(Offset = "0x70")]
		public Text RelationshipLabel;

		// Token: 0x04004594 RID: 17812
		[Token(Token = "0x4004594")]
		[FieldOffset(Offset = "0x78")]
		public RectTransform AddictionContainer;

		// Token: 0x04004595 RID: 17813
		[Token(Token = "0x4004595")]
		[FieldOffset(Offset = "0x80")]
		public Scrollbar AddictionScrollbar;

		// Token: 0x04004596 RID: 17814
		[Token(Token = "0x4004596")]
		[FieldOffset(Offset = "0x88")]
		public Text AddictionLabel;

		// Token: 0x04004597 RID: 17815
		[Token(Token = "0x4004597")]
		[FieldOffset(Offset = "0x90")]
		public RectTransform DebtContainer;

		// Token: 0x04004598 RID: 17816
		[Token(Token = "0x4004598")]
		[FieldOffset(Offset = "0x98")]
		public Text DebtLabel;

		// Token: 0x04004599 RID: 17817
		[Token(Token = "0x4004599")]
		[FieldOffset(Offset = "0xA0")]
		public RectTransform PropertiesContainer;

		// Token: 0x0400459A RID: 17818
		[Token(Token = "0x400459A")]
		[FieldOffset(Offset = "0xA8")]
		public Text PropertiesLabel;

		// Token: 0x0400459B RID: 17819
		[Token(Token = "0x400459B")]
		[FieldOffset(Offset = "0xB0")]
		public RectTransform MostPurchasedProductsContainer;

		// Token: 0x0400459C RID: 17820
		[Token(Token = "0x400459C")]
		[FieldOffset(Offset = "0xB8")]
		public Text MostPurchasedProductsLabel;

		// Token: 0x0400459D RID: 17821
		[Token(Token = "0x400459D")]
		[FieldOffset(Offset = "0xC0")]
		public RectTransform TotalSpentContainer;

		// Token: 0x0400459E RID: 17822
		[Token(Token = "0x400459E")]
		[FieldOffset(Offset = "0xC8")]
		public Text TotalSpentLabel;

		// Token: 0x0400459F RID: 17823
		[Token(Token = "0x400459F")]
		[FieldOffset(Offset = "0xD0")]
		public Button ShowOnMapButton;

		// Token: 0x040045A0 RID: 17824
		[Token(Token = "0x40045A0")]
		[FieldOffset(Offset = "0xD8")]
		public RectTransform StandardsContainer;

		// Token: 0x040045A1 RID: 17825
		[Token(Token = "0x40045A1")]
		[FieldOffset(Offset = "0xE0")]
		public Image StandardsStar;

		// Token: 0x040045A2 RID: 17826
		[Token(Token = "0x40045A2")]
		[FieldOffset(Offset = "0xE8")]
		public Text StandardsLabel;

		// Token: 0x040045A3 RID: 17827
		[Token(Token = "0x40045A3")]
		[FieldOffset(Offset = "0xF0")]
		[Header("Fonts")]
		[SerializeField]
		private ColorFont _generalColorFont;

		// Token: 0x040045A4 RID: 17828
		[Token(Token = "0x40045A4")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private ColorFont _proudctColorFont;

		// Token: 0x040045A5 RID: 17829
		[Token(Token = "0x40045A5")]
		[FieldOffset(Offset = "0x100")]
		private POI poi;

		// Token: 0x040045A6 RID: 17830
		[Token(Token = "0x40045A6")]
		private const int MAX_PURCHASED_PRODUCTS_DISPLAYED = 3;
	}
}
