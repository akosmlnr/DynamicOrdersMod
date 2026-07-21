using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C6A RID: 3178
	[Token(Token = "0x2000C6A")]
	public class MouseTooltip : Singleton<MouseTooltip>
	{
		// Token: 0x06005D0C RID: 23820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D0C")]
		[Address(RVA = "0x9E32F0", Offset = "0x9E24F0", VA = "0x1809E32F0")]
		public void ShowTooltip(string text, Color col)
		{
		}

		// Token: 0x06005D0D RID: 23821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D0D")]
		[Address(RVA = "0x9E3280", Offset = "0x9E2480", VA = "0x1809E3280")]
		public void ShowIcon(Sprite sprite, Color col)
		{
		}

		// Token: 0x06005D0E RID: 23822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D0E")]
		[Address(RVA = "0x9E3080", Offset = "0x9E2280", VA = "0x1809E3080")]
		private void LateUpdate()
		{
		}

		// Token: 0x06005D0F RID: 23823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D0F")]
		[Address(RVA = "0x9E3360", Offset = "0x9E2560", VA = "0x1809E3360")]
		public MouseTooltip()
		{
		}

		// Token: 0x04003F75 RID: 16245
		[Token(Token = "0x4003F75")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public RectTransform IconRect;

		// Token: 0x04003F76 RID: 16246
		[Token(Token = "0x4003F76")]
		[FieldOffset(Offset = "0x30")]
		public Image IconImg;

		// Token: 0x04003F77 RID: 16247
		[Token(Token = "0x4003F77")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform TooltipRect;

		// Token: 0x04003F78 RID: 16248
		[Token(Token = "0x4003F78")]
		[FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI TooltipLabel;

		// Token: 0x04003F79 RID: 16249
		[Token(Token = "0x4003F79")]
		[FieldOffset(Offset = "0x48")]
		[Header("Settings")]
		public Vector3 TooltipOffset_NoIcon;

		// Token: 0x04003F7A RID: 16250
		[Token(Token = "0x4003F7A")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 TooltipOffset_WithIcon;

		// Token: 0x04003F7B RID: 16251
		[Token(Token = "0x4003F7B")]
		[FieldOffset(Offset = "0x60")]
		public Vector3 IconOffset;

		// Token: 0x04003F7C RID: 16252
		[Token(Token = "0x4003F7C")]
		[FieldOffset(Offset = "0x6C")]
		[Header("Colors")]
		public Color Color_Invalid;

		// Token: 0x04003F7D RID: 16253
		[Token(Token = "0x4003F7D")]
		[FieldOffset(Offset = "0x80")]
		[Header("Sprites")]
		public Sprite Sprite_Cross;

		// Token: 0x04003F7E RID: 16254
		[Token(Token = "0x4003F7E")]
		[FieldOffset(Offset = "0x88")]
		private bool tooltipShownThisFrame;

		// Token: 0x04003F7F RID: 16255
		[Token(Token = "0x4003F7F")]
		[FieldOffset(Offset = "0x89")]
		private bool iconShownThisFrame;
	}
}
