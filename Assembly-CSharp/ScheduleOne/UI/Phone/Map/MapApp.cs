using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Map
{
	// Token: 0x02000D30 RID: 3376
	[Token(Token = "0x2000D30")]
	public class MapApp : App<MapApp>
	{
		// Token: 0x06006226 RID: 25126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006226")]
		[Address(RVA = "0xA4CDE0", Offset = "0xA4BFE0", VA = "0x180A4CDE0", Slot = "5")]
		protected override void Start()
		{
		}

		// Token: 0x06006227 RID: 25127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006227")]
		[Address(RVA = "0xA4C8F0", Offset = "0xA4BAF0", VA = "0x180A4C8F0", Slot = "11")]
		public override void SetOpen(bool open)
		{
		}

		// Token: 0x06006228 RID: 25128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006228")]
		[Address(RVA = "0xA4CF20", Offset = "0xA4C120", VA = "0x180A4CF20", Slot = "8")]
		protected override void Update()
		{
		}

		// Token: 0x06006229 RID: 25129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006229")]
		[Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0")]
		public void FocusPosition(Vector2 anchoredPosition)
		{
		}

		// Token: 0x0600622A RID: 25130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600622A")]
		[Address(RVA = "0xA4CD70", Offset = "0xA4BF70", VA = "0x180A4CD70")]
		public void SetupMapItem(GameObject gameObject)
		{
		}

		// Token: 0x0600622B RID: 25131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600622B")]
		[Address(RVA = "0xA4CEB0", Offset = "0xA4C0B0", VA = "0x180A4CEB0")]
		public void TeardownMapItem(GameObject gameObject)
		{
		}

		// Token: 0x0600622C RID: 25132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600622C")]
		[Address(RVA = "0xA4D060", Offset = "0xA4C260", VA = "0x180A4D060")]
		public MapApp()
		{
		}

		// Token: 0x0400440D RID: 17421
		[Token(Token = "0x400440D")]
		public const float KeyMoveSpeed = 1.25f;

		// Token: 0x0400440E RID: 17422
		[Token(Token = "0x400440E")]
		[FieldOffset(Offset = "0x68")]
		public RectTransform ContentRect;

		// Token: 0x0400440F RID: 17423
		[Token(Token = "0x400440F")]
		[FieldOffset(Offset = "0x70")]
		public RectTransform PoIContainer;

		// Token: 0x04004410 RID: 17424
		[Token(Token = "0x4004410")]
		[FieldOffset(Offset = "0x78")]
		public Scrollbar HorizontalScrollbar;

		// Token: 0x04004411 RID: 17425
		[Token(Token = "0x4004411")]
		[FieldOffset(Offset = "0x80")]
		public Scrollbar VerticalScrollbar;

		// Token: 0x04004412 RID: 17426
		[Token(Token = "0x4004412")]
		[FieldOffset(Offset = "0x88")]
		public Image BackgroundImage;

		// Token: 0x04004413 RID: 17427
		[Token(Token = "0x4004413")]
		[FieldOffset(Offset = "0x90")]
		public CanvasGroup LabelGroup;

		// Token: 0x04004414 RID: 17428
		[Token(Token = "0x4004414")]
		[FieldOffset(Offset = "0x98")]
		[Header("Settings")]
		public Sprite DemoMapSprite;

		// Token: 0x04004415 RID: 17429
		[Token(Token = "0x4004415")]
		[FieldOffset(Offset = "0xA0")]
		public Sprite MainMapSprite;

		// Token: 0x04004416 RID: 17430
		[Token(Token = "0x4004416")]
		[FieldOffset(Offset = "0xA8")]
		public Sprite TutorialMapSprite;

		// Token: 0x04004417 RID: 17431
		[Token(Token = "0x4004417")]
		[FieldOffset(Offset = "0xB0")]
		public float LabelScrollMin;

		// Token: 0x04004418 RID: 17432
		[Token(Token = "0x4004418")]
		[FieldOffset(Offset = "0xB4")]
		public float LabelScrollMax;

		// Token: 0x04004419 RID: 17433
		[Token(Token = "0x4004419")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Header("Custom UI")]
		protected UIScreen uiScreen;

		// Token: 0x0400441A RID: 17434
		[Token(Token = "0x400441A")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		protected UIMapPanel uiPanel;

		// Token: 0x0400441B RID: 17435
		[Token(Token = "0x400441B")]
		[FieldOffset(Offset = "0xC8")]
		[HideInInspector]
		public bool SkipFocusPlayer;

		// Token: 0x0400441C RID: 17436
		[Token(Token = "0x400441C")]
		[FieldOffset(Offset = "0xD0")]
		private Coroutine contentMoveRoutine;

		// Token: 0x0400441D RID: 17437
		[Token(Token = "0x400441D")]
		[FieldOffset(Offset = "0xD8")]
		private bool opened;
	}
}
