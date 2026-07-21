using System;
using Il2CppDummyDll;
using ScheduleOne.Delivery;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI.Items;
using ScheduleOne.UI.Tooltips;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Delivery
{
	// Token: 0x02000D3E RID: 3390
	[Token(Token = "0x2000D3E")]
	public class DeliveryReceiptDisplay : MonoBehaviour
	{
		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x0600626B RID: 25195 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000E27")]
		public Button ReorderButton
		{
			[Token(Token = "0x600626B")]
			[Address(RVA = "0x442C10", Offset = "0x441E10", VA = "0x180442C10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x0600626C RID: 25196 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000E28")]
		public DeliveryReceipt Receipt
		{
			[Token(Token = "0x600626C")]
			[Address(RVA = "0x4E09D0", Offset = "0x4DFBD0", VA = "0x1804E09D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600626D RID: 25197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600626D")]
		[Address(RVA = "0xA46630", Offset = "0xA45830", VA = "0x180A46630")]
		public void Initialise()
		{
		}

		// Token: 0x0600626E RID: 25198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600626E")]
		[Address(RVA = "0xA46850", Offset = "0xA45A50", VA = "0x180A46850")]
		public void Set(DeliveryReceipt receipt, float deliveryCost, bool canAfford)
		{
		}

		// Token: 0x0600626F RID: 25199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600626F")]
		[Address(RVA = "0xA46820", Offset = "0xA45A20", VA = "0x180A46820")]
		public void SetTooltip(string tooltip)
		{
		}

		// Token: 0x06006270 RID: 25200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006270")]
		[Address(RVA = "0xA46800", Offset = "0xA45A00", VA = "0x180A46800")]
		public void SetActiveTooltip(bool active)
		{
		}

		// Token: 0x06006271 RID: 25201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006271")]
		[Address(RVA = "0xA46D50", Offset = "0xA45F50", VA = "0x180A46D50")]
		public void SubscribeToOnSelect(Action<DeliveryReceipt> callback)
		{
		}

		// Token: 0x06006272 RID: 25202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006272")]
		[Address(RVA = "0xA46E40", Offset = "0xA46040", VA = "0x180A46E40")]
		public void UnsubscribeFromOnSelect(Action<DeliveryReceipt> callback)
		{
		}

		// Token: 0x06006273 RID: 25203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006273")]
		[Address(RVA = "0xA46F00", Offset = "0xA46100", VA = "0x180A46F00")]
		public DeliveryReceiptDisplay()
		{
		}

		// Token: 0x04004456 RID: 17494
		[Token(Token = "0x4004456")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("Prefabs")]
		private ItemEntryUI ItemEntryPrefab;

		// Token: 0x04004457 RID: 17495
		[Token(Token = "0x4004457")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Header("References")]
		private Text _DestinationLabel;

		// Token: 0x04004458 RID: 17496
		[Token(Token = "0x4004458")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _loadingDockLabel;

		// Token: 0x04004459 RID: 17497
		[Token(Token = "0x4004459")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _shopLabel;

		// Token: 0x0400445A RID: 17498
		[Token(Token = "0x400445A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _shopDescriptionLabel;

		// Token: 0x0400445B RID: 17499
		[Token(Token = "0x400445B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _ItemEntryContainer;

		// Token: 0x0400445C RID: 17500
		[Token(Token = "0x400445C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _ReorderButton;

		// Token: 0x0400445D RID: 17501
		[Token(Token = "0x400445D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Tooltip _ReorderTooltip;

		// Token: 0x0400445E RID: 17502
		[Token(Token = "0x400445E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _reorderPriceLabel;

		// Token: 0x0400445F RID: 17503
		[Token(Token = "0x400445F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Header("Settings")]
		private int _maxItemsShown;

		// Token: 0x04004460 RID: 17504
		[Token(Token = "0x4004460")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Header("Fonts")]
		private ColorFont _generalColorFont;

		// Token: 0x04004461 RID: 17505
		[Token(Token = "0x4004461")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ColorFont _shopTextColorFont;

		// Token: 0x04004462 RID: 17506
		[Token(Token = "0x4004462")]
		[FieldOffset(Offset = "0x80")]
		private DeliveryReceipt _receipt;

		// Token: 0x04004463 RID: 17507
		[Token(Token = "0x4004463")]
		[FieldOffset(Offset = "0x88")]
		private ItemEntryUI[] _itemEntries;

		// Token: 0x04004464 RID: 17508
		[Token(Token = "0x4004464")]
		[FieldOffset(Offset = "0x90")]
		private Action<DeliveryReceipt> _onSelect;
	}
}
