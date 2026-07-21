using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Delivery;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI.Items;
using ScheduleOne.UI.Tooltips;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Delivery
{
	// Token: 0x02000D43 RID: 3395
	[Token(Token = "0x2000D43")]
	public class DeliveryStatusDisplay : MonoBehaviour
	{
		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x060062A0 RID: 25248 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060062A1 RID: 25249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E2C")]
		public DeliveryInstance DeliveryInstance
		{
			[Token(Token = "0x60062A0")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60062A1")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060062A2 RID: 25250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062A2")]
		[Address(RVA = "0xA4A0F0", Offset = "0xA492F0", VA = "0x180A4A0F0")]
		public void AssignDelivery(DeliveryInstance instance)
		{
		}

		// Token: 0x060062A3 RID: 25251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062A3")]
		[Address(RVA = "0xA4A540", Offset = "0xA49740", VA = "0x180A4A540")]
		public void RefreshStatus()
		{
		}

		// Token: 0x060062A4 RID: 25252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062A4")]
		[Address(RVA = "0xA4A4E0", Offset = "0xA496E0", VA = "0x180A4A4E0")]
		public void Flash()
		{
		}

		// Token: 0x060062A5 RID: 25253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062A5")]
		[Address(RVA = "0xA4A500", Offset = "0xA49700", VA = "0x180A4A500")]
		private void OnDisable()
		{
		}

		// Token: 0x060062A6 RID: 25254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062A6")]
		[Address(RVA = "0xA4A840", Offset = "0xA49A40", VA = "0x180A4A840")]
		public DeliveryStatusDisplay()
		{
		}

		// Token: 0x0400447E RID: 17534
		[Token(Token = "0x400447E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Header("Prefabs")]
		private ItemEntryUI ItemEntryPrefab;

		// Token: 0x0400447F RID: 17535
		[Token(Token = "0x400447F")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Text DestinationLabel;

		// Token: 0x04004480 RID: 17536
		[Token(Token = "0x4004480")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _loadingDockLabel;

		// Token: 0x04004481 RID: 17537
		[Token(Token = "0x4004481")]
		[FieldOffset(Offset = "0x40")]
		public Text ShopLabel;

		// Token: 0x04004482 RID: 17538
		[Token(Token = "0x4004482")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _shopDescriptionLabel;

		// Token: 0x04004483 RID: 17539
		[Token(Token = "0x4004483")]
		[FieldOffset(Offset = "0x50")]
		public Image StatusImage;

		// Token: 0x04004484 RID: 17540
		[Token(Token = "0x4004484")]
		[FieldOffset(Offset = "0x58")]
		public Text StatusLabel;

		// Token: 0x04004485 RID: 17541
		[Token(Token = "0x4004485")]
		[FieldOffset(Offset = "0x60")]
		public Tooltip StatusTooltip;

		// Token: 0x04004486 RID: 17542
		[Token(Token = "0x4004486")]
		[FieldOffset(Offset = "0x68")]
		public RectTransform ItemEntryContainer;

		// Token: 0x04004487 RID: 17543
		[Token(Token = "0x4004487")]
		[FieldOffset(Offset = "0x70")]
		public Animation FlashAnimation;

		// Token: 0x04004488 RID: 17544
		[Token(Token = "0x4004488")]
		[FieldOffset(Offset = "0x78")]
		public GameObject FlashObject;

		// Token: 0x04004489 RID: 17545
		[Token(Token = "0x4004489")]
		[FieldOffset(Offset = "0x80")]
		[Header("Settings")]
		[SerializeField]
		private int _maxItemsShown;

		// Token: 0x0400448A RID: 17546
		[Token(Token = "0x400448A")]
		[FieldOffset(Offset = "0x84")]
		public Color StatusColor_Transit;

		// Token: 0x0400448B RID: 17547
		[Token(Token = "0x400448B")]
		[FieldOffset(Offset = "0x94")]
		public Color StatusColor_Waiting;

		// Token: 0x0400448C RID: 17548
		[Token(Token = "0x400448C")]
		[FieldOffset(Offset = "0xA4")]
		public Color StatusColor_Arrived;

		// Token: 0x0400448D RID: 17549
		[Token(Token = "0x400448D")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Header("Fonts")]
		private ColorFont _shopTextColorFont;
	}
}
