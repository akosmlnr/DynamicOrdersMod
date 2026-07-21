using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000CFC RID: 3324
	[Token(Token = "0x2000CFC")]
	public class SettingsSlider : MonoBehaviour
	{
		// Token: 0x060060C7 RID: 24775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060C7")]
		[Address(RVA = "0xA34CB0", Offset = "0xA33EB0", VA = "0x180A34CB0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060060C8 RID: 24776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060C8")]
		[Address(RVA = "0xA34FE0", Offset = "0xA341E0", VA = "0x180A34FE0", Slot = "5")]
		protected virtual void Update()
		{
		}

		// Token: 0x060060C9 RID: 24777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060C9")]
		[Address(RVA = "0xA34E40", Offset = "0xA34040", VA = "0x180A34E40", Slot = "6")]
		protected virtual void OnValueChanged(float value)
		{
		}

		// Token: 0x060060CA RID: 24778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060CA")]
		[Address(RVA = "0xA34ED0", Offset = "0xA340D0", VA = "0x180A34ED0")]
		protected void SetDisplayValue(float value)
		{
		}

		// Token: 0x060060CB RID: 24779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060CB")]
		[Address(RVA = "0xA34F40", Offset = "0xA34140", VA = "0x180A34F40")]
		protected void SetValueWithoutNotify(float value)
		{
		}

		// Token: 0x060060CC RID: 24780 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60060CC")]
		[Address(RVA = "0xA34E20", Offset = "0xA34020", VA = "0x180A34E20", Slot = "7")]
		protected virtual string GetDisplayValue(float value)
		{
			return null;
		}

		// Token: 0x060060CD RID: 24781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060CD")]
		[Address(RVA = "0xA21850", Offset = "0xA20A50", VA = "0x180A21850")]
		public SettingsSlider()
		{
		}

		// Token: 0x040042CF RID: 17103
		[Token(Token = "0x40042CF")]
		[FieldOffset(Offset = "0x20")]
		public float ValueDisplayTime;

		// Token: 0x040042D0 RID: 17104
		[Token(Token = "0x40042D0")]
		[FieldOffset(Offset = "0x24")]
		public bool DisplayValue;

		// Token: 0x040042D1 RID: 17105
		[Token(Token = "0x40042D1")]
		[FieldOffset(Offset = "0x28")]
		protected Slider slider;

		// Token: 0x040042D2 RID: 17106
		[Token(Token = "0x40042D2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected TextMeshProUGUI valueLabel;

		// Token: 0x040042D3 RID: 17107
		[Token(Token = "0x40042D3")]
		[FieldOffset(Offset = "0x38")]
		protected float timeOnValueChange;
	}
}
