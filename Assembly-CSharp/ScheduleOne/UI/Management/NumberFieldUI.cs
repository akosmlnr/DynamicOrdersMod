using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Management;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D80 RID: 3456
	[Token(Token = "0x2000D80")]
	public class NumberFieldUI : MonoBehaviour
	{
		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x060063BF RID: 25535 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060063C0 RID: 25536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E47")]
		public List<NumberField> Fields
		{
			[Token(Token = "0x60063BF")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60063C0")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060063C1 RID: 25537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063C1")]
		[Address(RVA = "0xA671C0", Offset = "0xA663C0", VA = "0x180A671C0")]
		public void Bind(List<NumberField> field)
		{
		}

		// Token: 0x060063C2 RID: 25538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063C2")]
		[Address(RVA = "0xA67690", Offset = "0xA66890", VA = "0x180A67690")]
		public void IncrementValue(int amt)
		{
		}

		// Token: 0x060063C3 RID: 25539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063C3")]
		[Address(RVA = "0xA676F0", Offset = "0xA668F0", VA = "0x180A676F0")]
		private void Refresh(float newVal)
		{
		}

		// Token: 0x060063C4 RID: 25540 RVA: 0x000189A8 File Offset: 0x00016BA8
		[Token(Token = "0x60063C4")]
		[Address(RVA = "0xA670E0", Offset = "0xA662E0", VA = "0x180A670E0")]
		private bool AreFieldsUniform()
		{
			return default(bool);
		}

		// Token: 0x060063C5 RID: 25541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063C5")]
		[Address(RVA = "0xA67870", Offset = "0xA66A70", VA = "0x180A67870")]
		public void ValueChanged(float value)
		{
		}

		// Token: 0x060063C6 RID: 25542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063C6")]
		[Address(RVA = "0xA67920", Offset = "0xA66B20", VA = "0x180A67920")]
		public NumberFieldUI()
		{
		}

		// Token: 0x040045F1 RID: 17905
		[Token(Token = "0x40045F1")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public TextMeshProUGUI FieldLabel;

		// Token: 0x040045F2 RID: 17906
		[Token(Token = "0x40045F2")]
		[FieldOffset(Offset = "0x30")]
		public Slider Slider;

		// Token: 0x040045F3 RID: 17907
		[Token(Token = "0x40045F3")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI ValueLabel;

		// Token: 0x040045F4 RID: 17908
		[Token(Token = "0x40045F4")]
		[FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI MinValueLabel;

		// Token: 0x040045F5 RID: 17909
		[Token(Token = "0x40045F5")]
		[FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI MaxValueLabel;
	}
}
