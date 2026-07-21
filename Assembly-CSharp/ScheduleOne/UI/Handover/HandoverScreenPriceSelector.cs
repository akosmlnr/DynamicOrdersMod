using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Handover
{
	// Token: 0x02000DD0 RID: 3536
	[Token(Token = "0x2000DD0")]
	public class HandoverScreenPriceSelector : MonoBehaviour
	{
		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x06006582 RID: 25986 RVA: 0x00018D68 File Offset: 0x00016F68
		// (set) Token: 0x06006583 RID: 25987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E75")]
		public float Price
		{
			[Token(Token = "0x6006582")]
			[Address(RVA = "0x524800", Offset = "0x523A00", VA = "0x180524800")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6006583")]
			[Address(RVA = "0x548D10", Offset = "0x547F10", VA = "0x180548D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006584 RID: 25988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006584")]
		[Address(RVA = "0xA948D0", Offset = "0xA93AD0", VA = "0x180A948D0")]
		public void SetPrice(float price)
		{
		}

		// Token: 0x06006585 RID: 25989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006585")]
		[Address(RVA = "0xA94880", Offset = "0xA93A80", VA = "0x180A94880")]
		public void RefreshPrice()
		{
		}

		// Token: 0x06006586 RID: 25990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006586")]
		[Address(RVA = "0xA94840", Offset = "0xA93A40", VA = "0x180A94840")]
		public void OnPriceInputChanged(string value)
		{
		}

		// Token: 0x06006587 RID: 25991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006587")]
		[Address(RVA = "0xA94830", Offset = "0xA93A30", VA = "0x180A94830")]
		public void ChangeAmount(float change)
		{
		}

		// Token: 0x06006588 RID: 25992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006588")]
		[Address(RVA = "0xA94950", Offset = "0xA93B50", VA = "0x180A94950")]
		public void ShowOSK()
		{
		}

		// Token: 0x06006589 RID: 25993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006589")]
		[Address(RVA = "0xA94840", Offset = "0xA93A40", VA = "0x180A94840")]
		private void KBSubmit(string newPrice)
		{
		}

		// Token: 0x0600658A RID: 25994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600658A")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void KBCancel()
		{
		}

		// Token: 0x0600658B RID: 25995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600658B")]
		[Address(RVA = "0x7DF120", Offset = "0x7DE320", VA = "0x1807DF120")]
		public HandoverScreenPriceSelector()
		{
		}

		// Token: 0x0400476C RID: 18284
		[Token(Token = "0x400476C")]
		public const float MinPrice = 1f;

		// Token: 0x0400476D RID: 18285
		[Token(Token = "0x400476D")]
		public const float MaxPrice = 9999f;

		// Token: 0x0400476E RID: 18286
		[Token(Token = "0x400476E")]
		[FieldOffset(Offset = "0x20")]
		public InputField InputField;

		// Token: 0x04004770 RID: 18288
		[Token(Token = "0x4004770")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent onPriceChanged;
	}
}
