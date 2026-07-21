using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne
{
	// Token: 0x02000238 RID: 568
	[Token(Token = "0x2000238")]
	public class UISlider : UIOption
	{
		// Token: 0x06000CCD RID: 3277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CCD")]
		[Address(RVA = "0xADFF00", Offset = "0xADF100", VA = "0x180ADFF00", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CCE")]
		[Address(RVA = "0x4BA5E0", Offset = "0x4B97E0", VA = "0x1804BA5E0", Slot = "6")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CCF")]
		[Address(RVA = "0xADFFE0", Offset = "0xADF1E0", VA = "0x180ADFFE0", Slot = "7")]
		protected override void MoveLeft()
		{
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CD0")]
		[Address(RVA = "0xAE0060", Offset = "0xADF260", VA = "0x180AE0060", Slot = "8")]
		protected override void MoveRight()
		{
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CD1")]
		[Address(RVA = "0xAE00F0", Offset = "0xADF2F0", VA = "0x180AE00F0")]
		private void UpdateSliderChanged()
		{
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CD2")]
		[Address(RVA = "0xAE0170", Offset = "0xADF370", VA = "0x180AE0170")]
		private void UpdateText()
		{
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CD3")]
		[Address(RVA = "0xAE0220", Offset = "0xADF420", VA = "0x180AE0220")]
		public UISlider()
		{
		}

		// Token: 0x04000CC5 RID: 3269
		[Token(Token = "0x4000CC5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool canUpdateValueText;

		// Token: 0x04000CC6 RID: 3270
		[Token(Token = "0x4000CC6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Slider slider;

		// Token: 0x04000CC7 RID: 3271
		[Token(Token = "0x4000CC7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float stepSize;

		// Token: 0x04000CC8 RID: 3272
		[Token(Token = "0x4000CC8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextMeshProUGUI valueText;

		// Token: 0x04000CC9 RID: 3273
		[Token(Token = "0x4000CC9")]
		[FieldOffset(Offset = "0x60")]
		public UnityEvent<float> OnChanged;
	}
}
