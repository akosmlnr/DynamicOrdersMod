using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000CCE RID: 3278
	[Token(Token = "0x2000CCE")]
	public class WorldspaceDialogueRenderer : MonoBehaviour
	{
		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x06005F8E RID: 24462 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06005F8F RID: 24463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DD7")]
		public string ShownText
		{
			[Token(Token = "0x6005F8E")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005F8F")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005F90 RID: 24464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F90")]
		[Address(RVA = "0xA1EFA0", Offset = "0xA1E1A0", VA = "0x180A1EFA0")]
		private void Awake()
		{
		}

		// Token: 0x06005F91 RID: 24465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F91")]
		[Address(RVA = "0xA1F020", Offset = "0xA1E220", VA = "0x180A1F020")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06005F92 RID: 24466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F92")]
		[Address(RVA = "0xA1F450", Offset = "0xA1E650", VA = "0x180A1F450")]
		private void LateUpdate()
		{
		}

		// Token: 0x06005F93 RID: 24467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F93")]
		[Address(RVA = "0xA1F850", Offset = "0xA1EA50", VA = "0x180A1F850")]
		private void UpdatePosition()
		{
		}

		// Token: 0x06005F94 RID: 24468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F94")]
		[Address(RVA = "0xA1F4D0", Offset = "0xA1E6D0", VA = "0x180A1F4D0")]
		public void ShowText(string text, float duration = 0f)
		{
		}

		// Token: 0x06005F95 RID: 24469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F95")]
		[Address(RVA = "0xA1F3D0", Offset = "0xA1E5D0", VA = "0x180A1F3D0")]
		public void HideText()
		{
		}

		// Token: 0x06005F96 RID: 24470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F96")]
		[Address(RVA = "0xA1F470", Offset = "0xA1E670", VA = "0x180A1F470")]
		private void SetOpacity(float op)
		{
		}

		// Token: 0x06005F97 RID: 24471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F97")]
		[Address(RVA = "0xA1FC90", Offset = "0xA1EE90", VA = "0x180A1FC90")]
		public WorldspaceDialogueRenderer()
		{
		}

		// Token: 0x06005F98 RID: 24472 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005F98")]
		[Address(RVA = "0xA1F7D0", Offset = "0xA1E9D0", VA = "0x180A1F7D0")]
		[CompilerGenerated]
		private IEnumerator <ShowText>g__Wait|22_0(float dur)
		{
			return null;
		}

		// Token: 0x040041D8 RID: 16856
		[Token(Token = "0x40041D8")]
		private const float FadeDist = 2f;

		// Token: 0x040041DA RID: 16858
		[Token(Token = "0x40041DA")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		public float MaxRange;

		// Token: 0x040041DB RID: 16859
		[Token(Token = "0x40041DB")]
		[FieldOffset(Offset = "0x2C")]
		public float BaseScale;

		// Token: 0x040041DC RID: 16860
		[Token(Token = "0x40041DC")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve Scale;

		// Token: 0x040041DD RID: 16861
		[Token(Token = "0x40041DD")]
		[FieldOffset(Offset = "0x38")]
		public Vector2 Padding;

		// Token: 0x040041DE RID: 16862
		[Token(Token = "0x40041DE")]
		[FieldOffset(Offset = "0x40")]
		public Vector3 WorldSpaceOffset;

		// Token: 0x040041DF RID: 16863
		[Token(Token = "0x40041DF")]
		[FieldOffset(Offset = "0x50")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x040041E0 RID: 16864
		[Token(Token = "0x40041E0")]
		[FieldOffset(Offset = "0x58")]
		public CanvasGroup CanvasGroup;

		// Token: 0x040041E1 RID: 16865
		[Token(Token = "0x40041E1")]
		[FieldOffset(Offset = "0x60")]
		public RectTransform Background;

		// Token: 0x040041E2 RID: 16866
		[Token(Token = "0x40041E2")]
		[FieldOffset(Offset = "0x68")]
		public TextMeshProUGUI Text;

		// Token: 0x040041E3 RID: 16867
		[Token(Token = "0x40041E3")]
		[FieldOffset(Offset = "0x70")]
		public Animation Anim;

		// Token: 0x040041E4 RID: 16868
		[Token(Token = "0x40041E4")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 localOffset;

		// Token: 0x040041E5 RID: 16869
		[Token(Token = "0x40041E5")]
		[FieldOffset(Offset = "0x84")]
		private float CurrentOpacity;

		// Token: 0x040041E6 RID: 16870
		[Token(Token = "0x40041E6")]
		[FieldOffset(Offset = "0x88")]
		private Coroutine hideCoroutine;
	}
}
