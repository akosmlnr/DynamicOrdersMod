using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C9A RID: 3226
	[Token(Token = "0x2000C9A")]
	public class ProgressSlider : Singleton<ProgressSlider>
	{
		// Token: 0x06005E65 RID: 24165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E65")]
		[Address(RVA = "0xA0B700", Offset = "0xA0A900", VA = "0x180A0B700")]
		private void LateUpdate()
		{
		}

		// Token: 0x06005E66 RID: 24166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E66")]
		[Address(RVA = "0xA0B740", Offset = "0xA0A940", VA = "0x180A0B740")]
		public void ShowProgress(float progress)
		{
		}

		// Token: 0x06005E67 RID: 24167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E67")]
		[Address(RVA = "0xA0B670", Offset = "0xA0A870", VA = "0x180A0B670")]
		public void Configure(string label, Color sliderFillColor)
		{
		}

		// Token: 0x06005E68 RID: 24168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E68")]
		[Address(RVA = "0xA0B770", Offset = "0xA0A970", VA = "0x180A0B770")]
		public ProgressSlider()
		{
		}

		// Token: 0x040040DF RID: 16607
		[Token(Token = "0x40040DF")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public GameObject Container;

		// Token: 0x040040E0 RID: 16608
		[Token(Token = "0x40040E0")]
		[FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI Label;

		// Token: 0x040040E1 RID: 16609
		[Token(Token = "0x40040E1")]
		[FieldOffset(Offset = "0x38")]
		public Slider Slider;

		// Token: 0x040040E2 RID: 16610
		[Token(Token = "0x40040E2")]
		[FieldOffset(Offset = "0x40")]
		public Image SliderFill;

		// Token: 0x040040E3 RID: 16611
		[Token(Token = "0x40040E3")]
		[FieldOffset(Offset = "0x48")]
		private bool progressSetThisFrame;
	}
}
