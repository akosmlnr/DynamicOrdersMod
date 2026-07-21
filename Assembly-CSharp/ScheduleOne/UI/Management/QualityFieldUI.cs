using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D85 RID: 3461
	[Token(Token = "0x2000D85")]
	public class QualityFieldUI : MonoBehaviour
	{
		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x060063E2 RID: 25570 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060063E3 RID: 25571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E4A")]
		public List<QualityField> Fields
		{
			[Token(Token = "0x60063E2")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60063E3")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060063E4 RID: 25572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063E4")]
		[Address(RVA = "0xA6AA00", Offset = "0xA69C00", VA = "0x180A6AA00")]
		public void Bind(List<QualityField> field)
		{
		}

		// Token: 0x060063E5 RID: 25573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063E5")]
		[Address(RVA = "0xA6AD40", Offset = "0xA69F40", VA = "0x180A6AD40")]
		private void Refresh(EQuality value)
		{
		}

		// Token: 0x060063E6 RID: 25574 RVA: 0x00018A38 File Offset: 0x00016C38
		[Token(Token = "0x60063E6")]
		[Address(RVA = "0xA6A930", Offset = "0xA69B30", VA = "0x180A6A930")]
		private bool AreFieldsUniform()
		{
			return default(bool);
		}

		// Token: 0x060063E7 RID: 25575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063E7")]
		[Address(RVA = "0xA6AEF0", Offset = "0xA6A0F0", VA = "0x180A6AEF0")]
		public void ValueChanged(EQuality value)
		{
		}

		// Token: 0x060063E8 RID: 25576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063E8")]
		[Address(RVA = "0xA6AC90", Offset = "0xA69E90", VA = "0x180A6AC90")]
		public void ChangeTargetQuality(int amt)
		{
		}

		// Token: 0x060063E9 RID: 25577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063E9")]
		[Address(RVA = "0xA6AFA0", Offset = "0xA6A1A0", VA = "0x180A6AFA0")]
		public QualityFieldUI()
		{
		}

		// Token: 0x0400460F RID: 17935
		[Token(Token = "0x400460F")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public TextMeshProUGUI FieldLabel;

		// Token: 0x04004610 RID: 17936
		[Token(Token = "0x4004610")]
		[FieldOffset(Offset = "0x30")]
		public Button[] QualityButtons;
	}
}
