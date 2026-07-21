using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C16 RID: 3094
	[Token(Token = "0x2000C16")]
	[RequireComponent(typeof(Button))]
	[RequireComponent(typeof(EventTrigger))]
	public class ButtonScaler : MonoBehaviour
	{
		// Token: 0x06005AD3 RID: 23251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AD3")]
		[Address(RVA = "0x9C18C0", Offset = "0x9C0AC0", VA = "0x1809C18C0")]
		private void Awake()
		{
		}

		// Token: 0x06005AD4 RID: 23252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AD4")]
		[Address(RVA = "0x9C1BB0", Offset = "0x9C0DB0", VA = "0x1809C1BB0")]
		private void Hovered()
		{
		}

		// Token: 0x06005AD5 RID: 23253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AD5")]
		[Address(RVA = "0x9C1B70", Offset = "0x9C0D70", VA = "0x1809C1B70")]
		private void HoverEnd()
		{
		}

		// Token: 0x06005AD6 RID: 23254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AD6")]
		[Address(RVA = "0x9C1BF0", Offset = "0x9C0DF0", VA = "0x1809C1BF0")]
		private void SetScale(float endScale)
		{
		}

		// Token: 0x06005AD7 RID: 23255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AD7")]
		[Address(RVA = "0x9C1D00", Offset = "0x9C0F00", VA = "0x1809C1D00")]
		public ButtonScaler()
		{
		}

		// Token: 0x04003D4E RID: 15694
		[Token(Token = "0x4003D4E")]
		[FieldOffset(Offset = "0x20")]
		public RectTransform ScaleTarget;

		// Token: 0x04003D4F RID: 15695
		[Token(Token = "0x4003D4F")]
		[FieldOffset(Offset = "0x28")]
		public float HoverScale;

		// Token: 0x04003D50 RID: 15696
		[Token(Token = "0x4003D50")]
		[FieldOffset(Offset = "0x2C")]
		public float ScaleTime;

		// Token: 0x04003D51 RID: 15697
		[Token(Token = "0x4003D51")]
		[FieldOffset(Offset = "0x30")]
		private Coroutine scaleCoroutine;

		// Token: 0x04003D52 RID: 15698
		[Token(Token = "0x4003D52")]
		[FieldOffset(Offset = "0x38")]
		private Button button;
	}
}
