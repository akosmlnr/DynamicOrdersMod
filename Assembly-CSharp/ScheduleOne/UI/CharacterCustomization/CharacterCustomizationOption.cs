using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Levelling;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.CharacterCustomization
{
	// Token: 0x02000DD8 RID: 3544
	[Token(Token = "0x2000DD8")]
	public class CharacterCustomizationOption : MonoBehaviour
	{
		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x060065B6 RID: 26038 RVA: 0x00018DB0 File Offset: 0x00016FB0
		// (set) Token: 0x060065B7 RID: 26039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E79")]
		public bool purchased
		{
			[Token(Token = "0x60065B6")]
			[Address(RVA = "0xA8E740", Offset = "0xA8D940", VA = "0x180A8E740")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60065B7")]
			[Address(RVA = "0xA8E750", Offset = "0xA8D950", VA = "0x180A8E750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x060065B8 RID: 26040 RVA: 0x00018DC8 File Offset: 0x00016FC8
		[Token(Token = "0x17000E7A")]
		private bool purchaseable
		{
			[Token(Token = "0x60065B8")]
			[Address(RVA = "0xA8E6A0", Offset = "0xA8D8A0", VA = "0x180A8E6A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060065B9 RID: 26041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065B9")]
		[Address(RVA = "0xA8DC00", Offset = "0xA8CE00", VA = "0x180A8DC00")]
		private void Awake()
		{
		}

		// Token: 0x060065BA RID: 26042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065BA")]
		[Address(RVA = "0x7200C0", Offset = "0x71F2C0", VA = "0x1807200C0")]
		private void OnValidate()
		{
		}

		// Token: 0x060065BB RID: 26043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065BB")]
		[Address(RVA = "0xA8DDD0", Offset = "0xA8CFD0", VA = "0x180A8DDD0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060065BC RID: 26044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065BC")]
		[Address(RVA = "0xA8E330", Offset = "0xA8D530", VA = "0x180A8E330")]
		private void Start()
		{
		}

		// Token: 0x060065BD RID: 26045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065BD")]
		[Address(RVA = "0xA8E010", Offset = "0xA8D210", VA = "0x180A8E010")]
		private void Selected()
		{
		}

		// Token: 0x060065BE RID: 26046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065BE")]
		[Address(RVA = "0xA8DEC0", Offset = "0xA8D0C0", VA = "0x180A8DEC0")]
		private void Purchased()
		{
		}

		// Token: 0x060065BF RID: 26047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065BF")]
		[Address(RVA = "0xA8E340", Offset = "0xA8D540", VA = "0x180A8E340")]
		private void UpdatePriceColor()
		{
		}

		// Token: 0x060065C0 RID: 26048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065C0")]
		[Address(RVA = "0xA8E0C0", Offset = "0xA8D2C0", VA = "0x180A8E0C0")]
		public void SetSelected(bool _selected)
		{
		}

		// Token: 0x060065C1 RID: 26049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065C1")]
		[Address(RVA = "0xA8E020", Offset = "0xA8D220", VA = "0x180A8E020")]
		public void SetPurchased(bool _purchased)
		{
		}

		// Token: 0x060065C2 RID: 26050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065C2")]
		[Address(RVA = "0xA8E510", Offset = "0xA8D710", VA = "0x180A8E510")]
		private void UpdateUI()
		{
		}

		// Token: 0x060065C3 RID: 26051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065C3")]
		[Address(RVA = "0xA8DE80", Offset = "0xA8D080", VA = "0x180A8DE80")]
		public void ParentCategoryClosed()
		{
		}

		// Token: 0x060065C4 RID: 26052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065C4")]
		[Address(RVA = "0xA8E2B0", Offset = "0xA8D4B0", VA = "0x180A8E2B0")]
		public void SiblingOptionSelected(CharacterCustomizationOption option)
		{
		}

		// Token: 0x060065C5 RID: 26053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065C5")]
		[Address(RVA = "0xA8E1D0", Offset = "0xA8D3D0", VA = "0x180A8E1D0")]
		public void SiblingOptionPurchased(CharacterCustomizationOption option)
		{
		}

		// Token: 0x060065C6 RID: 26054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065C6")]
		[Address(RVA = "0xA8E600", Offset = "0xA8D800", VA = "0x180A8E600")]
		public CharacterCustomizationOption()
		{
		}

		// Token: 0x040047A2 RID: 18338
		[Token(Token = "0x40047A2")]
		[FieldOffset(Offset = "0x20")]
		public string Name;

		// Token: 0x040047A3 RID: 18339
		[Token(Token = "0x40047A3")]
		[FieldOffset(Offset = "0x28")]
		public string Label;

		// Token: 0x040047A4 RID: 18340
		[Token(Token = "0x40047A4")]
		[FieldOffset(Offset = "0x30")]
		public float Price;

		// Token: 0x040047A5 RID: 18341
		[Token(Token = "0x40047A5")]
		[FieldOffset(Offset = "0x34")]
		public bool RequireLevel;

		// Token: 0x040047A6 RID: 18342
		[Token(Token = "0x40047A6")]
		[FieldOffset(Offset = "0x38")]
		public FullRank RequiredLevel;

		// Token: 0x040047A7 RID: 18343
		[Token(Token = "0x40047A7")]
		[FieldOffset(Offset = "0x40")]
		[Header("References")]
		public TextMeshProUGUI NameLabel;

		// Token: 0x040047A8 RID: 18344
		[Token(Token = "0x40047A8")]
		[FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI PriceLabel;

		// Token: 0x040047A9 RID: 18345
		[Token(Token = "0x40047A9")]
		[FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI LevelLabel;

		// Token: 0x040047AA RID: 18346
		[Token(Token = "0x40047AA")]
		[FieldOffset(Offset = "0x58")]
		public RectTransform LockDisplay;

		// Token: 0x040047AB RID: 18347
		[Token(Token = "0x40047AB")]
		[FieldOffset(Offset = "0x60")]
		public Button MainButton;

		// Token: 0x040047AC RID: 18348
		[Token(Token = "0x40047AC")]
		[FieldOffset(Offset = "0x68")]
		public Button BuyButton;

		// Token: 0x040047AD RID: 18349
		[Token(Token = "0x40047AD")]
		[FieldOffset(Offset = "0x70")]
		public RectTransform SelectionIndicator;

		// Token: 0x040047AE RID: 18350
		[Token(Token = "0x40047AE")]
		[FieldOffset(Offset = "0x78")]
		[Header("Events")]
		public UnityEvent onSelect;

		// Token: 0x040047AF RID: 18351
		[Token(Token = "0x40047AF")]
		[FieldOffset(Offset = "0x80")]
		public UnityEvent onDeselect;

		// Token: 0x040047B0 RID: 18352
		[Token(Token = "0x40047B0")]
		[FieldOffset(Offset = "0x88")]
		public UnityEvent onPurchase;

		// Token: 0x040047B2 RID: 18354
		[Token(Token = "0x40047B2")]
		[FieldOffset(Offset = "0x91")]
		private bool selected;
	}
}
