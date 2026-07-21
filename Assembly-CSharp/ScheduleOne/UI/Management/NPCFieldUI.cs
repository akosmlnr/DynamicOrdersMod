using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Management;
using ScheduleOne.NPCs;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D7E RID: 3454
	[Token(Token = "0x2000D7E")]
	public class NPCFieldUI : MonoBehaviour
	{
		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x060063B3 RID: 25523 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060063B4 RID: 25524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E46")]
		public List<NPCField> Fields
		{
			[Token(Token = "0x60063B3")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60063B4")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060063B5 RID: 25525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063B5")]
		[Address(RVA = "0xA667B0", Offset = "0xA659B0", VA = "0x180A667B0")]
		public void Bind(List<NPCField> field)
		{
		}

		// Token: 0x060063B6 RID: 25526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063B6")]
		[Address(RVA = "0xA66D10", Offset = "0xA65F10", VA = "0x180A66D10")]
		private void Refresh(NPC newVal)
		{
		}

		// Token: 0x060063B7 RID: 25527 RVA: 0x00018978 File Offset: 0x00016B78
		[Token(Token = "0x60063B7")]
		[Address(RVA = "0xA666A0", Offset = "0xA658A0", VA = "0x180A666A0")]
		private bool AreFieldsUniform()
		{
			return default(bool);
		}

		// Token: 0x060063B8 RID: 25528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063B8")]
		[Address(RVA = "0xA66940", Offset = "0xA65B40", VA = "0x180A66940")]
		public void Clicked()
		{
		}

		// Token: 0x060063B9 RID: 25529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063B9")]
		[Address(RVA = "0xA66AD0", Offset = "0xA65CD0", VA = "0x180A66AD0")]
		public void NPCSelected(NPC npc)
		{
		}

		// Token: 0x060063BA RID: 25530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063BA")]
		[Address(RVA = "0xA66930", Offset = "0xA65B30", VA = "0x180A66930")]
		public void ClearClicked()
		{
		}

		// Token: 0x060063BB RID: 25531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063BB")]
		[Address(RVA = "0xA67060", Offset = "0xA66260", VA = "0x180A67060")]
		public NPCFieldUI()
		{
		}

		// Token: 0x040045E8 RID: 17896
		[Token(Token = "0x40045E8")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public TextMeshProUGUI FieldLabel;

		// Token: 0x040045E9 RID: 17897
		[Token(Token = "0x40045E9")]
		[FieldOffset(Offset = "0x30")]
		public Image IconImg;

		// Token: 0x040045EA RID: 17898
		[Token(Token = "0x40045EA")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI SelectionLabel;

		// Token: 0x040045EB RID: 17899
		[Token(Token = "0x40045EB")]
		[FieldOffset(Offset = "0x40")]
		public GameObject NoneSelected;

		// Token: 0x040045EC RID: 17900
		[Token(Token = "0x40045EC")]
		[FieldOffset(Offset = "0x48")]
		public GameObject MultipleSelected;

		// Token: 0x040045ED RID: 17901
		[Token(Token = "0x40045ED")]
		[FieldOffset(Offset = "0x50")]
		public RectTransform ClearButton;
	}
}
