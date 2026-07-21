using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Messages
{
	// Token: 0x02000D4F RID: 3407
	[Token(Token = "0x2000D4F")]
	public class MessageBubble : MonoBehaviour
	{
		// Token: 0x060062EF RID: 25327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062EF")]
		[Address(RVA = "0xA630E0", Offset = "0xA622E0", VA = "0x180A630E0")]
		public void SetupBubble(string _text, MessageBubble.Alignment _alignment, bool alignCenter = false)
		{
		}

		// Token: 0x060062F0 RID: 25328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062F0")]
		[Address(RVA = "0xA63660", Offset = "0xA62860", VA = "0x180A63660", Slot = "4")]
		protected virtual void Update()
		{
		}

		// Token: 0x060062F1 RID: 25329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062F1")]
		[Address(RVA = "0xA62D50", Offset = "0xA61F50", VA = "0x180A62D50", Slot = "5")]
		public virtual void RefreshDisplayedText()
		{
		}

		// Token: 0x060062F2 RID: 25330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062F2")]
		[Address(RVA = "0xA62F60", Offset = "0xA62160", VA = "0x180A62F60", Slot = "6")]
		protected virtual void RefreshTriangle()
		{
		}

		// Token: 0x060062F3 RID: 25331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062F3")]
		[Address(RVA = "0xA63770", Offset = "0xA62970", VA = "0x180A63770")]
		public MessageBubble()
		{
		}

		// Token: 0x040044DD RID: 17629
		[Token(Token = "0x40044DD")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		public string text;

		// Token: 0x040044DE RID: 17630
		[Token(Token = "0x40044DE")]
		[FieldOffset(Offset = "0x28")]
		public MessageBubble.Alignment alignment;

		// Token: 0x040044DF RID: 17631
		[Token(Token = "0x40044DF")]
		[FieldOffset(Offset = "0x2C")]
		public bool showTriangle;

		// Token: 0x040044E0 RID: 17632
		[Token(Token = "0x40044E0")]
		[FieldOffset(Offset = "0x30")]
		public float bubble_MinWidth;

		// Token: 0x040044E1 RID: 17633
		[Token(Token = "0x40044E1")]
		[FieldOffset(Offset = "0x34")]
		public float bubble_MaxWidth;

		// Token: 0x040044E2 RID: 17634
		[Token(Token = "0x40044E2")]
		[FieldOffset(Offset = "0x38")]
		public bool alignTextCenter;

		// Token: 0x040044E3 RID: 17635
		[Token(Token = "0x40044E3")]
		[FieldOffset(Offset = "0x39")]
		public bool autosetPosition;

		// Token: 0x040044E4 RID: 17636
		[Token(Token = "0x40044E4")]
		[FieldOffset(Offset = "0x40")]
		private string displayedText;

		// Token: 0x040044E5 RID: 17637
		[Token(Token = "0x40044E5")]
		[FieldOffset(Offset = "0x48")]
		private bool triangleShown;

		// Token: 0x040044E6 RID: 17638
		[Token(Token = "0x40044E6")]
		[FieldOffset(Offset = "0x50")]
		[Header("References")]
		public RectTransform container;

		// Token: 0x040044E7 RID: 17639
		[Token(Token = "0x40044E7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected Image bubble;

		// Token: 0x040044E8 RID: 17640
		[Token(Token = "0x40044E8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected Text content;

		// Token: 0x040044E9 RID: 17641
		[Token(Token = "0x40044E9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected Image triangle_Left;

		// Token: 0x040044EA RID: 17642
		[Token(Token = "0x40044EA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected Image triangle_Right;

		// Token: 0x040044EB RID: 17643
		[Token(Token = "0x40044EB")]
		[FieldOffset(Offset = "0x78")]
		public Button button;

		// Token: 0x040044EC RID: 17644
		[Token(Token = "0x40044EC")]
		[FieldOffset(Offset = "0x80")]
		public float height;

		// Token: 0x040044ED RID: 17645
		[Token(Token = "0x40044ED")]
		[FieldOffset(Offset = "0x84")]
		public float spacingAbove;

		// Token: 0x040044EE RID: 17646
		[Token(Token = "0x40044EE")]
		[FieldOffset(Offset = "0x0")]
		public static Color32 backgroundColor_Left;

		// Token: 0x040044EF RID: 17647
		[Token(Token = "0x40044EF")]
		[FieldOffset(Offset = "0x4")]
		public static Color32 textColor_Left;

		// Token: 0x040044F0 RID: 17648
		[Token(Token = "0x40044F0")]
		[FieldOffset(Offset = "0x8")]
		public static Color32 backgroundColor_Right;

		// Token: 0x040044F1 RID: 17649
		[Token(Token = "0x40044F1")]
		[FieldOffset(Offset = "0xC")]
		public static Color32 textColor_Right;

		// Token: 0x040044F2 RID: 17650
		[Token(Token = "0x40044F2")]
		[FieldOffset(Offset = "0x10")]
		public static float baseBubbleSpacing;

		// Token: 0x02000D50 RID: 3408
		[Token(Token = "0x2000D50")]
		public enum Alignment
		{
			// Token: 0x040044F4 RID: 17652
			[Token(Token = "0x40044F4")]
			Center,
			// Token: 0x040044F5 RID: 17653
			[Token(Token = "0x40044F5")]
			Left,
			// Token: 0x040044F6 RID: 17654
			[Token(Token = "0x40044F6")]
			Right
		}
	}
}
