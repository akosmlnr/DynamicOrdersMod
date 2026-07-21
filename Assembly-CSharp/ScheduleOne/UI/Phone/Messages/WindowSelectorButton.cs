using System;
using Il2CppDummyDll;
using ScheduleOne.Economy;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Messages
{
	// Token: 0x02000D5C RID: 3420
	[Token(Token = "0x2000D5C")]
	public class WindowSelectorButton : MonoBehaviour
	{
		// Token: 0x06006335 RID: 25397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006335")]
		[Address(RVA = "0xA6F9D0", Offset = "0xA6EBD0", VA = "0x180A6F9D0")]
		private void Awake()
		{
		}

		// Token: 0x06006336 RID: 25398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006336")]
		[Address(RVA = "0xA6FF40", Offset = "0xA6F140", VA = "0x180A6FF40")]
		public void SetInteractable(bool interactable)
		{
		}

		// Token: 0x06006337 RID: 25399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006337")]
		[Address(RVA = "0xA6FD60", Offset = "0xA6EF60", VA = "0x180A6FD60")]
		public void HoverStart()
		{
		}

		// Token: 0x06006338 RID: 25400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006338")]
		[Address(RVA = "0xA6FD30", Offset = "0xA6EF30", VA = "0x180A6FD30")]
		public void HoverEnd()
		{
		}

		// Token: 0x06006339 RID: 25401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006339")]
		[Address(RVA = "0x5D1E30", Offset = "0x5D1030", VA = "0x1805D1E30")]
		public void Clicked()
		{
		}

		// Token: 0x0600633A RID: 25402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600633A")]
		[Address(RVA = "0xA6FD90", Offset = "0xA6EF90", VA = "0x180A6FD90")]
		public void SetHoverIndicator(bool shown)
		{
		}

		// Token: 0x0600633B RID: 25403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600633B")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public WindowSelectorButton()
		{
		}

		// Token: 0x0400453F RID: 17727
		[Token(Token = "0x400453F")]
		public const float SELECTION_INDICATOR_SCALE = 1.1f;

		// Token: 0x04004540 RID: 17728
		[Token(Token = "0x4004540")]
		public const float INDICATOR_LERP_TIME = 0.075f;

		// Token: 0x04004541 RID: 17729
		[Token(Token = "0x4004541")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent OnSelected;

		// Token: 0x04004542 RID: 17730
		[Token(Token = "0x4004542")]
		[FieldOffset(Offset = "0x28")]
		public EDealWindow WindowType;

		// Token: 0x04004543 RID: 17731
		[Token(Token = "0x4004543")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Button Button;

		// Token: 0x04004544 RID: 17732
		[Token(Token = "0x4004544")]
		[FieldOffset(Offset = "0x38")]
		public GameObject InactiveOverlay;

		// Token: 0x04004545 RID: 17733
		[Token(Token = "0x4004545")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform HoverIndicator;

		// Token: 0x04004546 RID: 17734
		[Token(Token = "0x4004546")]
		[FieldOffset(Offset = "0x48")]
		[Header("Custom UI")]
		public UISelectable uiSelectable;

		// Token: 0x04004547 RID: 17735
		[Token(Token = "0x4004547")]
		[FieldOffset(Offset = "0x50")]
		public EventTrigger trigger;

		// Token: 0x04004548 RID: 17736
		[Token(Token = "0x4004548")]
		[FieldOffset(Offset = "0x58")]
		private Coroutine hoverRoutine;
	}
}
