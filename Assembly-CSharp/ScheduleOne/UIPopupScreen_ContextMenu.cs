using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne
{
	// Token: 0x02000224 RID: 548
	[Token(Token = "0x2000224")]
	public class UIPopupScreen_ContextMenu : UIPopupScreen
	{
		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x00006F60 File Offset: 0x00005160
		// (set) Token: 0x06000C2D RID: 3117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700026D")]
		public UIPopupScreen_ContextMenu.AnchorType Anchor
		{
			[Token(Token = "0x6000C2C")]
			[Address(RVA = "0x4D4840", Offset = "0x4D3A40", VA = "0x1804D4840")]
			get
			{
				return UIPopupScreen_ContextMenu.AnchorType.TopLeft;
			}
			[Token(Token = "0x6000C2D")]
			[Address(RVA = "0xAD8E60", Offset = "0xAD8060", VA = "0x180AD8E60")]
			set
			{
			}
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C2E")]
		[Address(RVA = "0xAD80B0", Offset = "0xAD72B0", VA = "0x180AD80B0", Slot = "4")]
		protected override void OnAwake()
		{
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C2F")]
		[Address(RVA = "0xAD8250", Offset = "0xAD7450", VA = "0x180AD8250", Slot = "5")]
		protected override void OnStarted()
		{
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C30")]
		[Address(RVA = "0xAD8100", Offset = "0xAD7300", VA = "0x180AD8100", Slot = "6")]
		protected override void OnDestroyed()
		{
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C31")]
		[Address(RVA = "0xAD8060", Offset = "0xAD7260", VA = "0x180AD8060")]
		private void HandleInputDeviceChanged(GameInput.InputDeviceType type)
		{
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C32")]
		[Address(RVA = "0xAD7820", Offset = "0xAD6A20", VA = "0x180AD7820")]
		public void AddOption(int id, string name, Action action)
		{
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C33")]
		[Address(RVA = "0xAD7E60", Offset = "0xAD7060", VA = "0x180AD7E60", Slot = "9")]
		public override void Close()
		{
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C34")]
		[Address(RVA = "0xAD88D0", Offset = "0xAD7AD0", VA = "0x180AD88D0")]
		private void Open()
		{
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C35")]
		[Address(RVA = "0xAD83A0", Offset = "0xAD75A0", VA = "0x180AD83A0", Slot = "8")]
		public override void Open(params object[] args)
		{
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C36")]
		[Address(RVA = "0xAD7C20", Offset = "0xAD6E20", VA = "0x180AD7C20")]
		private void Clear()
		{
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C37")]
		[Address(RVA = "0xAD89C0", Offset = "0xAD7BC0", VA = "0x180AD89C0")]
		private void SelectPanel(int selectedIndex)
		{
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000C38")]
		[Address(RVA = "0xAD7F00", Offset = "0xAD7100", VA = "0x180AD7F00")]
		private UISelectable GetSelectableFromPool()
		{
			return null;
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C39")]
		[Address(RVA = "0xAD8BC0", Offset = "0xAD7DC0", VA = "0x180AD8BC0")]
		private void SetPosition(Vector2 pos)
		{
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C3A")]
		[Address(RVA = "0xAD8D10", Offset = "0xAD7F10", VA = "0x180AD8D10")]
		public UIPopupScreen_ContextMenu()
		{
		}

		// Token: 0x04000C57 RID: 3159
		[Token(Token = "0x4000C57")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Tooltip("Prefab for the Option Selectable")]
		private UISelectable selectablePrefab;

		// Token: 0x04000C58 RID: 3160
		[Token(Token = "0x4000C58")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Tooltip("Transform where the Option Selectables will be parented to")]
		private Transform contentParent;

		// Token: 0x04000C59 RID: 3161
		[Token(Token = "0x4000C59")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Tooltip("RectTransform where the anchoring point of the context menu will be")]
		private RectTransform anchorRectTransform;

		// Token: 0x04000C5A RID: 3162
		[Token(Token = "0x4000C5A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Tooltip("Canvas to control the visibility")]
		private Canvas canvas;

		// Token: 0x04000C5B RID: 3163
		[Token(Token = "0x4000C5B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Tooltip("Screen blocker to block mouse interaction with ui elements behind the context menu and darken the background")]
		private GameObject screenBlocker;

		// Token: 0x04000C5C RID: 3164
		[Token(Token = "0x4000C5C")]
		[FieldOffset(Offset = "0x80")]
		private UIPopupScreen_ContextMenu.AnchorType anchor;

		// Token: 0x04000C5D RID: 3165
		[Token(Token = "0x4000C5D")]
		[FieldOffset(Offset = "0x88")]
		private List<UIPopupScreen_ContextMenu.ContextMenuOption> options;

		// Token: 0x04000C5E RID: 3166
		[Token(Token = "0x4000C5E")]
		[FieldOffset(Offset = "0x90")]
		private Queue<UISelectable> selectablePool;

		// Token: 0x04000C5F RID: 3167
		[Token(Token = "0x4000C5F")]
		[FieldOffset(Offset = "0x98")]
		private Dictionary<int, UISelectable> activeSelectables;

		// Token: 0x02000225 RID: 549
		[Token(Token = "0x2000225")]
		public class ContextMenuOption
		{
			// Token: 0x06000C3B RID: 3131 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C3B")]
			[Address(RVA = "0xAC9A70", Offset = "0xAC8C70", VA = "0x180AC9A70")]
			public ContextMenuOption(int id, string name, Action action)
			{
			}

			// Token: 0x04000C60 RID: 3168
			[Token(Token = "0x4000C60")]
			[FieldOffset(Offset = "0x10")]
			public int optionID;

			// Token: 0x04000C61 RID: 3169
			[Token(Token = "0x4000C61")]
			[FieldOffset(Offset = "0x18")]
			public string optionName;

			// Token: 0x04000C62 RID: 3170
			[Token(Token = "0x4000C62")]
			[FieldOffset(Offset = "0x20")]
			public Action optionAction;
		}

		// Token: 0x02000226 RID: 550
		[Token(Token = "0x2000226")]
		public enum AnchorType
		{
			// Token: 0x04000C64 RID: 3172
			[Token(Token = "0x4000C64")]
			TopLeft,
			// Token: 0x04000C65 RID: 3173
			[Token(Token = "0x4000C65")]
			BottomLeft,
			// Token: 0x04000C66 RID: 3174
			[Token(Token = "0x4000C66")]
			Center
		}
	}
}
