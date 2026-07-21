using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne
{
	// Token: 0x0200023D RID: 573
	[Token(Token = "0x200023D")]
	public class UIToggle : UIOption
	{
		// Token: 0x06000CE0 RID: 3296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CE0")]
		[Address(RVA = "0xAE1690", Offset = "0xAE0890", VA = "0x180AE1690", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CE1")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "6")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CE2")]
		[Address(RVA = "0xAE18E0", Offset = "0xAE0AE0", VA = "0x180AE18E0")]
		public void SetState(bool state)
		{
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CE3")]
		[Address(RVA = "0xAE18D0", Offset = "0xAE0AD0", VA = "0x180AE18D0")]
		public void SetStateWithoutNotify(bool state)
		{
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CE4")]
		[Address(RVA = "0xAE1840", Offset = "0xAE0A40", VA = "0x180AE1840")]
		private void SetStateInternal(bool state)
		{
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CE5")]
		[Address(RVA = "0xAE17B0", Offset = "0xAE09B0", VA = "0x180AE17B0")]
		private void SetButtonState(bool state)
		{
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CE6")]
		[Address(RVA = "0xAD3CF0", Offset = "0xAD2EF0", VA = "0x180AD3CF0")]
		public UIToggle()
		{
		}

		// Token: 0x04000CDA RID: 3290
		[Token(Token = "0x4000CDA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI buttonText;

		// Token: 0x04000CDB RID: 3291
		[Token(Token = "0x4000CDB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image toggleImage;

		// Token: 0x04000CDC RID: 3292
		[Token(Token = "0x4000CDC")]
		private const string ONTEXT = "On";

		// Token: 0x04000CDD RID: 3293
		[Token(Token = "0x4000CDD")]
		private const string OFFTEXT = "Off";

		// Token: 0x04000CDE RID: 3294
		[Token(Token = "0x4000CDE")]
		[FieldOffset(Offset = "0x50")]
		public UnityEvent<bool> OnChanged;

		// Token: 0x04000CDF RID: 3295
		[Token(Token = "0x4000CDF")]
		[FieldOffset(Offset = "0x58")]
		private bool state;
	}
}
