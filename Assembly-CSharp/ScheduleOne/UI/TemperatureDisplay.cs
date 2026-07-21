using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000CB5 RID: 3253
	[Token(Token = "0x2000CB5")]
	public class TemperatureDisplay : MonoBehaviour
	{
		// Token: 0x06005F1E RID: 24350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F1E")]
		[Address(RVA = "0xA15960", Offset = "0xA14B60", VA = "0x180A15960")]
		private void Awake()
		{
		}

		// Token: 0x06005F1F RID: 24351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F1F")]
		[Address(RVA = "0xA15990", Offset = "0xA14B90", VA = "0x180A15990")]
		private void LateUpdate()
		{
		}

		// Token: 0x06005F20 RID: 24352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F20")]
		[Address(RVA = "0xA159A0", Offset = "0xA14BA0", VA = "0x180A159A0")]
		private void UpdateCanvas()
		{
		}

		// Token: 0x06005F21 RID: 24353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F21")]
		[Address(RVA = "0x452470", Offset = "0x451670", VA = "0x180452470")]
		public void SetTemperatureGetter(Func<float> getCelsiusTemperature)
		{
		}

		// Token: 0x06005F22 RID: 24354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F22")]
		[Address(RVA = "0x4D1C60", Offset = "0x4D0E60", VA = "0x1804D1C60")]
		public void SetVisibilityGetter(Func<bool> getIsVisible)
		{
		}

		// Token: 0x06005F23 RID: 24355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F23")]
		[Address(RVA = "0x81D290", Offset = "0x81C490", VA = "0x18081D290")]
		public void SetEnabled(bool enabled)
		{
		}

		// Token: 0x06005F24 RID: 24356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F24")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public TemperatureDisplay()
		{
		}

		// Token: 0x04004169 RID: 16745
		[Token(Token = "0x4004169")]
		public const float MaxCameraDistance = 8f;

		// Token: 0x0400416A RID: 16746
		[Token(Token = "0x400416A")]
		public const float MinCameraDistance = 0.5f;

		// Token: 0x0400416B RID: 16747
		[Token(Token = "0x400416B")]
		public const float FadeInDistance = 2f;

		// Token: 0x0400416C RID: 16748
		[Token(Token = "0x400416C")]
		public const float FadeOutDistance = 0.25f;

		// Token: 0x0400416D RID: 16749
		[Token(Token = "0x400416D")]
		[FieldOffset(Offset = "0x20")]
		public bool UseColor;

		// Token: 0x0400416E RID: 16750
		[Token(Token = "0x400416E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Gradient _temperatureColorGradient;

		// Token: 0x0400416F RID: 16751
		[Token(Token = "0x400416F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshPro _label;

		// Token: 0x04004170 RID: 16752
		[Token(Token = "0x4004170")]
		[FieldOffset(Offset = "0x38")]
		private Func<float> _getCelsiusTemperature;

		// Token: 0x04004171 RID: 16753
		[Token(Token = "0x4004171")]
		[FieldOffset(Offset = "0x40")]
		private Func<bool> _getIsVisible;
	}
}
