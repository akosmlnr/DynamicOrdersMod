using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI.Tooltips
{
	// Token: 0x02000CD7 RID: 3287
	[Token(Token = "0x2000CD7")]
	public class TooltipManager : Singleton<TooltipManager>
	{
		// Token: 0x06005FC1 RID: 24513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FC1")]
		[Address(RVA = "0xA36E50", Offset = "0xA36050", VA = "0x180A36E50", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005FC2 RID: 24514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FC2")]
		[Address(RVA = "0xA37C20", Offset = "0xA36E20", VA = "0x180A37C20", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x06005FC3 RID: 24515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FC3")]
		[Address(RVA = "0xA37620", Offset = "0xA36820", VA = "0x180A37620", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06005FC4 RID: 24516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FC4")]
		[Address(RVA = "0xA368F0", Offset = "0xA35AF0", VA = "0x180A368F0")]
		public void AddCanvas(Canvas canvas)
		{
		}

		// Token: 0x06005FC5 RID: 24517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FC5")]
		[Address(RVA = "0xA372E0", Offset = "0xA364E0", VA = "0x180A372E0")]
		private void CheckForTooltipHover()
		{
		}

		// Token: 0x06005FC6 RID: 24518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FC6")]
		[Address(RVA = "0xA37670", Offset = "0xA36870", VA = "0x180A37670")]
		public void ShowTooltip(string text, Vector2 position, bool worldspace)
		{
		}

		// Token: 0x06005FC7 RID: 24519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FC7")]
		[Address(RVA = "0xA37C30", Offset = "0xA36E30", VA = "0x180A37C30")]
		public TooltipManager()
		{
		}

		// Token: 0x04004212 RID: 16914
		[Token(Token = "0x4004212")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04004213 RID: 16915
		[Token(Token = "0x4004213")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform anchor;

		// Token: 0x04004214 RID: 16916
		[Token(Token = "0x4004214")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI tooltipLabel;

		// Token: 0x04004215 RID: 16917
		[Token(Token = "0x4004215")]
		[FieldOffset(Offset = "0x40")]
		private List<Canvas> canvases;

		// Token: 0x04004216 RID: 16918
		[Token(Token = "0x4004216")]
		[FieldOffset(Offset = "0x48")]
		private List<Canvas> sortedCanvases;

		// Token: 0x04004217 RID: 16919
		[Token(Token = "0x4004217")]
		[FieldOffset(Offset = "0x50")]
		private List<GraphicRaycaster> raycasters;

		// Token: 0x04004218 RID: 16920
		[Token(Token = "0x4004218")]
		[FieldOffset(Offset = "0x58")]
		private EventSystem eventSystem;

		// Token: 0x04004219 RID: 16921
		[Token(Token = "0x4004219")]
		[FieldOffset(Offset = "0x60")]
		private bool tooltipShownThisFrame;

		// Token: 0x0400421A RID: 16922
		[Token(Token = "0x400421A")]
		[FieldOffset(Offset = "0x68")]
		private PointerEventData pointerEventData;

		// Token: 0x0400421B RID: 16923
		[Token(Token = "0x400421B")]
		[FieldOffset(Offset = "0x70")]
		private List<RaycastResult> rayResults;
	}
}
