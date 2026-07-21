using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.Growing
{
	// Token: 0x020008B2 RID: 2226
	[Token(Token = "0x20008B2")]
	public class GrowContainerMoistureDisplay : MonoBehaviour
	{
		// Token: 0x06003AF7 RID: 15095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AF7")]
		[Address(RVA = "0x814FC0", Offset = "0x8141C0", VA = "0x180814FC0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06003AF8 RID: 15096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AF8")]
		[Address(RVA = "0x814FF0", Offset = "0x8141F0", VA = "0x180814FF0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06003AF9 RID: 15097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AF9")]
		[Address(RVA = "0x815090", Offset = "0x814290", VA = "0x180815090")]
		private void UpdateCanvas()
		{
		}

		// Token: 0x06003AFA RID: 15098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AFA")]
		[Address(RVA = "0x815000", Offset = "0x814200", VA = "0x180815000", Slot = "5")]
		protected virtual void UpdateCanvasContents()
		{
		}

		// Token: 0x06003AFB RID: 15099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AFB")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public GrowContainerMoistureDisplay()
		{
		}

		// Token: 0x04002B84 RID: 11140
		[Token(Token = "0x4002B84")]
		public const float MaxCameraDistance = 2.5f;

		// Token: 0x04002B85 RID: 11141
		[Token(Token = "0x4002B85")]
		public const float MinCameraDistance = 0.5f;

		// Token: 0x04002B86 RID: 11142
		[Token(Token = "0x4002B86")]
		public const float FadeInDistance = 0.7f;

		// Token: 0x04002B87 RID: 11143
		[Token(Token = "0x4002B87")]
		public const float FadeOutDistance = 0.25f;

		// Token: 0x04002B88 RID: 11144
		[Token(Token = "0x4002B88")]
		[FieldOffset(Offset = "0x20")]
		public bool SnapToRightAngles;

		// Token: 0x04002B89 RID: 11145
		[Token(Token = "0x4002B89")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public GrowContainer GrowContainer;

		// Token: 0x04002B8A RID: 11146
		[Token(Token = "0x4002B8A")]
		[FieldOffset(Offset = "0x30")]
		public Transform WaterCanvasContainer;

		// Token: 0x04002B8B RID: 11147
		[Token(Token = "0x4002B8B")]
		[FieldOffset(Offset = "0x38")]
		public Canvas WaterLevelCanvas;

		// Token: 0x04002B8C RID: 11148
		[Token(Token = "0x4002B8C")]
		[FieldOffset(Offset = "0x40")]
		public CanvasGroup WaterLevelCanvasGroup;

		// Token: 0x04002B8D RID: 11149
		[Token(Token = "0x4002B8D")]
		[FieldOffset(Offset = "0x48")]
		public Slider WaterLevelSlider;

		// Token: 0x04002B8E RID: 11150
		[Token(Token = "0x4002B8E")]
		[FieldOffset(Offset = "0x50")]
		public GameObject NoWaterIcon;
	}
}
