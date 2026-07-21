using System;
using Il2CppDummyDll;
using ScheduleOne.Map;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C1F RID: 3103
	[Token(Token = "0x2000C1F")]
	public class CartelInfluenceChangePopup : MonoBehaviour
	{
		// Token: 0x06005AFB RID: 23291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AFB")]
		[Address(RVA = "0x9C2BB0", Offset = "0x9C1DB0", VA = "0x1809C2BB0")]
		private void Start()
		{
		}

		// Token: 0x06005AFC RID: 23292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AFC")]
		[Address(RVA = "0x9C29E0", Offset = "0x9C1BE0", VA = "0x1809C29E0")]
		public void Show(EMapRegion region, float oldInfluence, float newInfluence)
		{
		}

		// Token: 0x06005AFD RID: 23293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AFD")]
		[Address(RVA = "0x9C2850", Offset = "0x9C1A50", VA = "0x1809C2850")]
		private void SetDisplayedInfluence(float influence)
		{
		}

		// Token: 0x06005AFE RID: 23294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AFE")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public CartelInfluenceChangePopup()
		{
		}

		// Token: 0x04003D72 RID: 15730
		[Token(Token = "0x4003D72")]
		public const float SLIDER_ANIMATION_DURATION = 1.5f;

		// Token: 0x04003D73 RID: 15731
		[Token(Token = "0x4003D73")]
		[FieldOffset(Offset = "0x20")]
		public Animation Anim;

		// Token: 0x04003D74 RID: 15732
		[Token(Token = "0x4003D74")]
		[FieldOffset(Offset = "0x28")]
		public Slider Slider;

		// Token: 0x04003D75 RID: 15733
		[Token(Token = "0x4003D75")]
		[FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI TitleLabel;

		// Token: 0x04003D76 RID: 15734
		[Token(Token = "0x4003D76")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI InfluenceCountLabel;
	}
}
