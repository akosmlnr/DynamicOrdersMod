using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C5D RID: 3165
	[Token(Token = "0x2000C5D")]
	public class InteractionCanvas : Singleton<InteractionCanvas>
	{
		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x06005C9D RID: 23709 RVA: 0x000175E0 File Offset: 0x000157E0
		// (set) Token: 0x06005C9E RID: 23710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D68")]
		public float displayScale
		{
			[Token(Token = "0x6005C9D")]
			[Address(RVA = "0x524800", Offset = "0x523A00", VA = "0x180524800")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005C9E")]
			[Address(RVA = "0x548D10", Offset = "0x547F10", VA = "0x180548D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005C9F RID: 23711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C9F")]
		[Address(RVA = "0x9DCD70", Offset = "0x9DBF70", VA = "0x1809DCD70", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06005CA0 RID: 23712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CA0")]
		[Address(RVA = "0x9DC870", Offset = "0x9DBA70", VA = "0x1809DC870")]
		public void EnableInteractionDisplay(Vector3 pos, Sprite icon, string spriteText, string message, Color messageColor, Color iconColor)
		{
		}

		// Token: 0x06005CA1 RID: 23713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CA1")]
		[Address(RVA = "0x9DCF20", Offset = "0x9DC120", VA = "0x1809DCF20")]
		public void LerpDisplayScale(float endScale)
		{
		}

		// Token: 0x06005CA2 RID: 23714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CA2")]
		[Address(RVA = "0x9DD080", Offset = "0x9DC280", VA = "0x1809DD080")]
		public InteractionCanvas()
		{
		}

		// Token: 0x06005CA3 RID: 23715 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005CA3")]
		[Address(RVA = "0x9DCFF0", Offset = "0x9DC1F0", VA = "0x1809DCFF0")]
		[CompilerGenerated]
		private IEnumerator <LerpDisplayScale>g__ILerpDisplayScale|26_0(float startScale, float endScale)
		{
			return null;
		}

		// Token: 0x04003EF9 RID: 16121
		[Token(Token = "0x4003EF9")]
		public const float DISPLAY_SIZE_MULTIPLIER = 0.75f;

		// Token: 0x04003EFB RID: 16123
		[Token(Token = "0x4003EFB")]
		[FieldOffset(Offset = "0x2C")]
		[Header("Settings")]
		public Color DefaultMessageColor;

		// Token: 0x04003EFC RID: 16124
		[Token(Token = "0x4003EFC")]
		[FieldOffset(Offset = "0x3C")]
		public Color DefaultIconColor;

		// Token: 0x04003EFD RID: 16125
		[Token(Token = "0x4003EFD")]
		[FieldOffset(Offset = "0x4C")]
		public Color DefaultKeyColor;

		// Token: 0x04003EFE RID: 16126
		[Token(Token = "0x4003EFE")]
		[FieldOffset(Offset = "0x5C")]
		public Color InvalidMessageColor;

		// Token: 0x04003EFF RID: 16127
		[Token(Token = "0x4003EFF")]
		[FieldOffset(Offset = "0x6C")]
		public Color InvalidIconColor;

		// Token: 0x04003F00 RID: 16128
		[Token(Token = "0x4003F00")]
		[FieldOffset(Offset = "0x80")]
		public Sprite KeyIcon;

		// Token: 0x04003F01 RID: 16129
		[Token(Token = "0x4003F01")]
		[FieldOffset(Offset = "0x88")]
		public Sprite LeftMouseIcon;

		// Token: 0x04003F02 RID: 16130
		[Token(Token = "0x4003F02")]
		[FieldOffset(Offset = "0x90")]
		public Sprite CrossIcon;

		// Token: 0x04003F03 RID: 16131
		[Token(Token = "0x4003F03")]
		[FieldOffset(Offset = "0x98")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003F04 RID: 16132
		[Token(Token = "0x4003F04")]
		[FieldOffset(Offset = "0xA0")]
		public RectTransform Container;

		// Token: 0x04003F05 RID: 16133
		[Token(Token = "0x4003F05")]
		[FieldOffset(Offset = "0xA8")]
		public Image Icon;

		// Token: 0x04003F06 RID: 16134
		[Token(Token = "0x4003F06")]
		[FieldOffset(Offset = "0xB0")]
		public Text IconText;

		// Token: 0x04003F07 RID: 16135
		[Token(Token = "0x4003F07")]
		[FieldOffset(Offset = "0xB8")]
		public Text MessageText;

		// Token: 0x04003F08 RID: 16136
		[Token(Token = "0x4003F08")]
		[FieldOffset(Offset = "0xC0")]
		public RectTransform WSLabelContainer;

		// Token: 0x04003F09 RID: 16137
		[Token(Token = "0x4003F09")]
		[FieldOffset(Offset = "0xC8")]
		public RectTransform BackgroundImage;

		// Token: 0x04003F0A RID: 16138
		[Token(Token = "0x4003F0A")]
		[FieldOffset(Offset = "0xD0")]
		[Header("Prefabs")]
		public GameObject WSLabelPrefab;

		// Token: 0x04003F0B RID: 16139
		[Token(Token = "0x4003F0B")]
		[FieldOffset(Offset = "0xD8")]
		private bool _interactionDisplayEnabledThisFrame;

		// Token: 0x04003F0C RID: 16140
		[Token(Token = "0x4003F0C")]
		[FieldOffset(Offset = "0xE0")]
		private Coroutine _displayScaleLerpRoutine;

		// Token: 0x04003F0D RID: 16141
		[Token(Token = "0x4003F0D")]
		[FieldOffset(Offset = "0xE8")]
		[HideInInspector]
		public List<WorldSpaceLabel> ActiveWSlabels;
	}
}
