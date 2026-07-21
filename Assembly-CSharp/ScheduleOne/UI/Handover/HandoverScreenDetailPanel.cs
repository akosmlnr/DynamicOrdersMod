using System;
using Il2CppDummyDll;
using ScheduleOne.Economy;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Handover
{
	// Token: 0x02000DCF RID: 3535
	[Token(Token = "0x2000DCF")]
	public class HandoverScreenDetailPanel : MonoBehaviour
	{
		// Token: 0x0600657F RID: 25983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600657F")]
		[Address(RVA = "0xA71D80", Offset = "0xA70F80", VA = "0x180A71D80")]
		public void Open(Customer customer)
		{
		}

		// Token: 0x06006580 RID: 25984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006580")]
		[Address(RVA = "0x74D910", Offset = "0x74CB10", VA = "0x18074D910")]
		public void Close()
		{
		}

		// Token: 0x06006581 RID: 25985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006581")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public HandoverScreenDetailPanel()
		{
		}

		// Token: 0x04004762 RID: 18274
		[Token(Token = "0x4004762")]
		[FieldOffset(Offset = "0x20")]
		public LayoutGroup LayoutGroup;

		// Token: 0x04004763 RID: 18275
		[Token(Token = "0x4004763")]
		[FieldOffset(Offset = "0x28")]
		public RectTransform Container;

		// Token: 0x04004764 RID: 18276
		[Token(Token = "0x4004764")]
		[FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI NameLabel;

		// Token: 0x04004765 RID: 18277
		[Token(Token = "0x4004765")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform RelationshipContainer;

		// Token: 0x04004766 RID: 18278
		[Token(Token = "0x4004766")]
		[FieldOffset(Offset = "0x40")]
		public Scrollbar RelationshipScrollbar;

		// Token: 0x04004767 RID: 18279
		[Token(Token = "0x4004767")]
		[FieldOffset(Offset = "0x48")]
		public RectTransform AddictionContainer;

		// Token: 0x04004768 RID: 18280
		[Token(Token = "0x4004768")]
		[FieldOffset(Offset = "0x50")]
		public Scrollbar AdditionScrollbar;

		// Token: 0x04004769 RID: 18281
		[Token(Token = "0x4004769")]
		[FieldOffset(Offset = "0x58")]
		public Image StandardsStar;

		// Token: 0x0400476A RID: 18282
		[Token(Token = "0x400476A")]
		[FieldOffset(Offset = "0x60")]
		public TextMeshProUGUI StandardsLabel;

		// Token: 0x0400476B RID: 18283
		[Token(Token = "0x400476B")]
		[FieldOffset(Offset = "0x68")]
		public TextMeshProUGUI EffectsLabel;
	}
}
