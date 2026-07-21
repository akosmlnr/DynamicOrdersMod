using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne
{
	// Token: 0x02000215 RID: 533
	[Token(Token = "0x2000215")]
	public class UIHorizontalSelector : UIOption
	{
		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000BAC RID: 2988 RVA: 0x00006DB0 File Offset: 0x00004FB0
		[Token(Token = "0x1700025D")]
		protected override float NavigationRepeatRateMult
		{
			[Token(Token = "0x6000BAC")]
			[Address(RVA = "0xAD2090", Offset = "0xAD1290", VA = "0x180AD2090", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BAD")]
		[Address(RVA = "0xAD1BE0", Offset = "0xAD0DE0", VA = "0x180AD1BE0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BAE")]
		[Address(RVA = "0x4BA5E0", Offset = "0x4B97E0", VA = "0x1804BA5E0", Slot = "6")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0xAD1D00", Offset = "0xAD0F00", VA = "0x180AD1D00", Slot = "7")]
		protected override void MoveLeft()
		{
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BB0")]
		[Address(RVA = "0xAD1D70", Offset = "0xAD0F70", VA = "0x180AD1D70", Slot = "8")]
		protected override void MoveRight()
		{
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BB1")]
		[Address(RVA = "0xAD1DD0", Offset = "0xAD0FD0", VA = "0x180AD1DD0")]
		private void MovePrev()
		{
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0xAD1D70", Offset = "0xAD0F70", VA = "0x180AD1D70")]
		private void MoveNext()
		{
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0xAD1F00", Offset = "0xAD1100", VA = "0x180AD1F00")]
		private void UpdateCurrentOptionText()
		{
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BB4")]
		[Address(RVA = "0xAD1E40", Offset = "0xAD1040", VA = "0x180AD1E40")]
		public void SetOptions(List<UIOption.OptionInfo> newOptions, int defaultIndex = 0)
		{
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0xAD1FE0", Offset = "0xAD11E0", VA = "0x180AD1FE0")]
		public UIHorizontalSelector()
		{
		}

		// Token: 0x04000BFE RID: 3070
		[Token(Token = "0x4000BFE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button prevButton;

		// Token: 0x04000BFF RID: 3071
		[Token(Token = "0x4000BFF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button nextButton;

		// Token: 0x04000C00 RID: 3072
		[Token(Token = "0x4000C00")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TextMeshProUGUI currentOptionNameText;

		// Token: 0x04000C01 RID: 3073
		[Token(Token = "0x4000C01")]
		[FieldOffset(Offset = "0x58")]
		public UnityEvent<UIOption.OptionInfo> OnChanged;

		// Token: 0x04000C02 RID: 3074
		[Token(Token = "0x4000C02")]
		[FieldOffset(Offset = "0x60")]
		private List<UIOption.OptionInfo> options;

		// Token: 0x04000C03 RID: 3075
		[Token(Token = "0x4000C03")]
		[FieldOffset(Offset = "0x68")]
		private int currentIndex;
	}
}
