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
	// Token: 0x02000D7D RID: 3453
	[Token(Token = "0x2000D7D")]
	public class ItemFieldUI : MonoBehaviour
	{
		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x060063AB RID: 25515 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060063AC RID: 25516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E45")]
		public List<ItemField> Fields
		{
			[Token(Token = "0x60063AB")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60063AC")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060063AD RID: 25517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063AD")]
		[Address(RVA = "0xA5D2C0", Offset = "0xA5C4C0", VA = "0x180A5D2C0")]
		public void Bind(List<ItemField> field)
		{
		}

		// Token: 0x060063AE RID: 25518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063AE")]
		[Address(RVA = "0xA5DB30", Offset = "0xA5CD30", VA = "0x180A5DB30")]
		private void Refresh(ItemDefinition newVal)
		{
		}

		// Token: 0x060063AF RID: 25519 RVA: 0x00018960 File Offset: 0x00016B60
		[Token(Token = "0x60063AF")]
		[Address(RVA = "0xA5D1B0", Offset = "0xA5C3B0", VA = "0x180A5D1B0")]
		private bool AreFieldsUniform()
		{
			return default(bool);
		}

		// Token: 0x060063B0 RID: 25520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063B0")]
		[Address(RVA = "0xA5D440", Offset = "0xA5C640", VA = "0x180A5D440")]
		public void Clicked()
		{
		}

		// Token: 0x060063B1 RID: 25521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063B1")]
		[Address(RVA = "0xA5D9F0", Offset = "0xA5CBF0", VA = "0x180A5D9F0")]
		private void OptionSelected(ItemSelector.Option option)
		{
		}

		// Token: 0x060063B2 RID: 25522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063B2")]
		[Address(RVA = "0xA5DD40", Offset = "0xA5CF40", VA = "0x180A5DD40")]
		public ItemFieldUI()
		{
		}

		// Token: 0x040045E1 RID: 17889
		[Token(Token = "0x40045E1")]
		[FieldOffset(Offset = "0x28")]
		public bool ShowNoneAsAny;

		// Token: 0x040045E2 RID: 17890
		[Token(Token = "0x40045E2")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public TextMeshProUGUI FieldLabel;

		// Token: 0x040045E3 RID: 17891
		[Token(Token = "0x40045E3")]
		[FieldOffset(Offset = "0x38")]
		public Image IconImg;

		// Token: 0x040045E4 RID: 17892
		[Token(Token = "0x40045E4")]
		[FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI SelectionLabel;

		// Token: 0x040045E5 RID: 17893
		[Token(Token = "0x40045E5")]
		[FieldOffset(Offset = "0x48")]
		public GameObject NoneSelected;

		// Token: 0x040045E6 RID: 17894
		[Token(Token = "0x40045E6")]
		[FieldOffset(Offset = "0x50")]
		public GameObject MultipleSelected;
	}
}
