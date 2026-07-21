using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne
{
	// Token: 0x02000218 RID: 536
	[Token(Token = "0x2000218")]
	public class UIMapPanel : UIPanel, INonNavigablePanel
	{
		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x00006DE0 File Offset: 0x00004FE0
		// (set) Token: 0x06000BC5 RID: 3013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025E")]
		public bool LockMapInput
		{
			[Token(Token = "0x6000BC4")]
			[Address(RVA = "0x50EF90", Offset = "0x50E190", VA = "0x18050EF90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BC5")]
			[Address(RVA = "0xAD38F0", Offset = "0xAD2AF0", VA = "0x180AD38F0")]
			set
			{
			}
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0xAD3460", Offset = "0xAD2660", VA = "0x180AD3460", Slot = "5")]
		protected override void Start()
		{
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0xAD34E0", Offset = "0xAD26E0", VA = "0x180AD34E0", Slot = "9")]
		protected override void Update()
		{
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0xAD2890", Offset = "0xAD1A90", VA = "0x180AD2890")]
		private void Navigate()
		{
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0xAD36D0", Offset = "0xAD28D0", VA = "0x180AD36D0")]
		private void Zoom()
		{
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0xAD2C80", Offset = "0xAD1E80", VA = "0x180AD2C80")]
		public void RegisterMapItem(UIMapItem item)
		{
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0xAD27C0", Offset = "0xAD19C0", VA = "0x180AD27C0")]
		public void DeregisterMapItem(UIMapItem item)
		{
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BCC")]
		[Address(RVA = "0xAD2E00", Offset = "0xAD2000", VA = "0x180AD2E00")]
		public void SetSnappedItem(UIMapItem newItem)
		{
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BCD")]
		[Address(RVA = "0xAD2D60", Offset = "0xAD1F60", VA = "0x180AD2D60")]
		public void ResetSnappedItem()
		{
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BCE")]
		[Address(RVA = "0xAD2EA0", Offset = "0xAD20A0", VA = "0x180AD2EA0")]
		private void SnapToNearestMapItem()
		{
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void SnapMapToItem(UIMapItem item)
		{
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0xAD2850", Offset = "0xAD1A50", VA = "0x180AD2850", Slot = "11")]
		protected override void HandleInputDeviceChanged(GameInput.InputDeviceType type)
		{
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0xAD3840", Offset = "0xAD2A40", VA = "0x180AD3840")]
		public UIMapPanel()
		{
		}

		// Token: 0x04000C0C RID: 3084
		[Token(Token = "0x4000C0C")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private PinchableScrollRect mapScrollRect;

		// Token: 0x04000C0D RID: 3085
		[Token(Token = "0x4000C0D")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private float scrollSensitivity;

		// Token: 0x04000C0E RID: 3086
		[Token(Token = "0x4000C0E")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private float minZoomScrollSpeedMult;

		// Token: 0x04000C0F RID: 3087
		[Token(Token = "0x4000C0F")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float maxZoomScrollSpeedMult;

		// Token: 0x04000C10 RID: 3088
		[Token(Token = "0x4000C10")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private float zoomSensitivity;

		// Token: 0x04000C11 RID: 3089
		[Token(Token = "0x4000C11")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private RectTransform centerPoint;

		// Token: 0x04000C12 RID: 3090
		[Token(Token = "0x4000C12")]
		private const float initialHoldThreshold = 0.5f;

		// Token: 0x04000C13 RID: 3091
		[Token(Token = "0x4000C13")]
		private const float repeatInterval = 0.25f;

		// Token: 0x04000C14 RID: 3092
		[Token(Token = "0x4000C14")]
		[FieldOffset(Offset = "0xC8")]
		private float zoomTimer;

		// Token: 0x04000C15 RID: 3093
		[Token(Token = "0x4000C15")]
		[FieldOffset(Offset = "0xCC")]
		private bool wasZoomPressedLastFrame;

		// Token: 0x04000C16 RID: 3094
		[Token(Token = "0x4000C16")]
		[FieldOffset(Offset = "0xD0")]
		private List<UIMapItem> mapItems;

		// Token: 0x04000C17 RID: 3095
		[Token(Token = "0x4000C17")]
		[FieldOffset(Offset = "0xD8")]
		private UIMapItem snappedItem;

		// Token: 0x04000C18 RID: 3096
		[Token(Token = "0x4000C18")]
		[FieldOffset(Offset = "0xE0")]
		private bool lockMapInput;
	}
}
