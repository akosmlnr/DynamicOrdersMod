using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;
using ScheduleOne.UI.Tooltips;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Stations.Drying_rack
{
	// Token: 0x02000CE7 RID: 3303
	[Token(Token = "0x2000CE7")]
	public class DryingOperationUI : MonoBehaviour
	{
		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x0600605D RID: 24669 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600605E RID: 24670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DF0")]
		public DryingOperation AssignedOperation
		{
			[Token(Token = "0x600605D")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600605E")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x0600605F RID: 24671 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06006060 RID: 24672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DF1")]
		public RectTransform Alignment
		{
			[Token(Token = "0x600605F")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006060")]
			[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006061 RID: 24673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006061")]
		[Address(RVA = "0xA25590", Offset = "0xA24790", VA = "0x180A25590")]
		public void SetOperation(DryingOperation operation)
		{
		}

		// Token: 0x06006062 RID: 24674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006062")]
		[Address(RVA = "0xA25530", Offset = "0xA24730", VA = "0x180A25530")]
		public void SetAlignment(RectTransform alignment)
		{
		}

		// Token: 0x06006063 RID: 24675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006063")]
		[Address(RVA = "0xA254A0", Offset = "0xA246A0", VA = "0x180A254A0")]
		public void RefreshQuantity()
		{
		}

		// Token: 0x06006064 RID: 24676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006064")]
		[Address(RVA = "0xA25610", Offset = "0xA24810", VA = "0x180A25610")]
		public void Start()
		{
		}

		// Token: 0x06006065 RID: 24677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006065")]
		[Address(RVA = "0x7C2F70", Offset = "0x7C2170", VA = "0x1807C2F70")]
		public void SetDryRate(float dryMultiplier)
		{
		}

		// Token: 0x06006066 RID: 24678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006066")]
		[Address(RVA = "0xA256C0", Offset = "0xA248C0", VA = "0x180A256C0")]
		public void UpdatePosition()
		{
		}

		// Token: 0x06006067 RID: 24679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006067")]
		[Address(RVA = "0xA25340", Offset = "0xA24540", VA = "0x180A25340")]
		private void Clicked()
		{
		}

		// Token: 0x06006068 RID: 24680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006068")]
		[Address(RVA = "0xA25890", Offset = "0xA24A90", VA = "0x180A25890")]
		public DryingOperationUI()
		{
		}

		// Token: 0x040042AE RID: 17070
		[Token(Token = "0x40042AE")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public RectTransform Rect;

		// Token: 0x040042AF RID: 17071
		[Token(Token = "0x40042AF")]
		[FieldOffset(Offset = "0x38")]
		public Image Icon;

		// Token: 0x040042B0 RID: 17072
		[Token(Token = "0x40042B0")]
		[FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI QuantityLabel;

		// Token: 0x040042B1 RID: 17073
		[Token(Token = "0x40042B1")]
		[FieldOffset(Offset = "0x48")]
		public Button Button;

		// Token: 0x040042B2 RID: 17074
		[Token(Token = "0x40042B2")]
		[FieldOffset(Offset = "0x50")]
		public Tooltip Tooltip;

		// Token: 0x040042B3 RID: 17075
		[Token(Token = "0x40042B3")]
		[FieldOffset(Offset = "0x58")]
		private float _dryMultiplier;
	}
}
