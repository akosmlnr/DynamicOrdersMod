using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.Management;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D81 RID: 3457
	[Token(Token = "0x2000D81")]
	public class ObjectFieldUI : MonoBehaviour
	{
		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x060063C7 RID: 25543 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060063C8 RID: 25544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E48")]
		public List<ObjectField> Fields
		{
			[Token(Token = "0x60063C7")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60063C8")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060063C9 RID: 25545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063C9")]
		[Address(RVA = "0xA67AB0", Offset = "0xA66CB0", VA = "0x180A67AB0")]
		public void Bind(List<ObjectField> field)
		{
		}

		// Token: 0x060063CA RID: 25546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063CA")]
		[Address(RVA = "0xA684F0", Offset = "0xA676F0", VA = "0x180A684F0")]
		private void Refresh(BuildableItem newVal)
		{
		}

		// Token: 0x060063CB RID: 25547 RVA: 0x000189C0 File Offset: 0x00016BC0
		[Token(Token = "0x60063CB")]
		[Address(RVA = "0xA679A0", Offset = "0xA66BA0", VA = "0x180A679A0")]
		private bool AreFieldsUniform()
		{
			return default(bool);
		}

		// Token: 0x060063CC RID: 25548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063CC")]
		[Address(RVA = "0xA67C40", Offset = "0xA66E40", VA = "0x180A67C40")]
		public void Clicked()
		{
		}

		// Token: 0x060063CD RID: 25549 RVA: 0x000189D8 File Offset: 0x00016BD8
		[Token(Token = "0x60063CD")]
		[Address(RVA = "0xA68320", Offset = "0xA67520", VA = "0x180A68320")]
		private bool ObjectValid(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x060063CE RID: 25550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063CE")]
		[Address(RVA = "0xA68470", Offset = "0xA67670", VA = "0x180A68470")]
		public void ObjectsSelected(List<BuildableItem> objs)
		{
		}

		// Token: 0x060063CF RID: 25551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063CF")]
		[Address(RVA = "0xA680B0", Offset = "0xA672B0", VA = "0x180A680B0")]
		private void ObjectSelected(BuildableItem obj)
		{
		}

		// Token: 0x060063D0 RID: 25552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063D0")]
		[Address(RVA = "0xA67C30", Offset = "0xA66E30", VA = "0x180A67C30")]
		public void ClearClicked()
		{
		}

		// Token: 0x060063D1 RID: 25553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063D1")]
		[Address(RVA = "0xA68850", Offset = "0xA67A50", VA = "0x180A68850")]
		public ObjectFieldUI()
		{
		}

		// Token: 0x040045F7 RID: 17911
		[Token(Token = "0x40045F7")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public string InstructionText;

		// Token: 0x040045F8 RID: 17912
		[Token(Token = "0x40045F8")]
		[FieldOffset(Offset = "0x30")]
		public string ExtendedInstructionText;

		// Token: 0x040045F9 RID: 17913
		[Token(Token = "0x40045F9")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI FieldLabel;

		// Token: 0x040045FA RID: 17914
		[Token(Token = "0x40045FA")]
		[FieldOffset(Offset = "0x40")]
		public Image IconImg;

		// Token: 0x040045FB RID: 17915
		[Token(Token = "0x40045FB")]
		[FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI SelectionLabel;

		// Token: 0x040045FC RID: 17916
		[Token(Token = "0x40045FC")]
		[FieldOffset(Offset = "0x50")]
		public GameObject NoneSelected;

		// Token: 0x040045FD RID: 17917
		[Token(Token = "0x40045FD")]
		[FieldOffset(Offset = "0x58")]
		public GameObject MultipleSelected;

		// Token: 0x040045FE RID: 17918
		[Token(Token = "0x40045FE")]
		[FieldOffset(Offset = "0x60")]
		public RectTransform ClearButton;
	}
}
