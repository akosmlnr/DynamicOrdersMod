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
	// Token: 0x02000D83 RID: 3459
	[Token(Token = "0x2000D83")]
	public class ObjectListFieldUI : MonoBehaviour
	{
		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x060063D5 RID: 25557 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060063D6 RID: 25558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E49")]
		public List<ObjectListField> Fields
		{
			[Token(Token = "0x60063D5")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60063D6")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060063D7 RID: 25559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063D7")]
		[Address(RVA = "0xA68A10", Offset = "0xA67C10", VA = "0x180A68A10")]
		public void Bind(List<ObjectListField> field)
		{
		}

		// Token: 0x060063D8 RID: 25560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063D8")]
		[Address(RVA = "0xA695A0", Offset = "0xA687A0", VA = "0x180A695A0")]
		private void Refresh(List<BuildableItem> newVal)
		{
		}

		// Token: 0x060063D9 RID: 25561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063D9")]
		[Address(RVA = "0xA69CF0", Offset = "0xA68EF0", VA = "0x180A69CF0")]
		private void RemoveEntryClicked(int index)
		{
		}

		// Token: 0x060063DA RID: 25562 RVA: 0x00018A08 File Offset: 0x00016C08
		[Token(Token = "0x60063DA")]
		[Address(RVA = "0xA68920", Offset = "0xA67B20", VA = "0x180A68920")]
		private bool AreFieldsUniform()
		{
			return default(bool);
		}

		// Token: 0x060063DB RID: 25563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063DB")]
		[Address(RVA = "0xA68F90", Offset = "0xA68190", VA = "0x180A68F90")]
		public void Clicked()
		{
		}

		// Token: 0x060063DC RID: 25564 RVA: 0x00018A20 File Offset: 0x00016C20
		[Token(Token = "0x60063DC")]
		[Address(RVA = "0xA692A0", Offset = "0xA684A0", VA = "0x180A692A0")]
		private bool ObjectValid(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x060063DD RID: 25565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063DD")]
		[Address(RVA = "0xA693F0", Offset = "0xA685F0", VA = "0x180A693F0")]
		public void ObjectsSelected(List<BuildableItem> objs)
		{
		}

		// Token: 0x060063DE RID: 25566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063DE")]
		[Address(RVA = "0xA68E30", Offset = "0xA68030", VA = "0x180A68E30")]
		public void Clear()
		{
		}

		// Token: 0x060063DF RID: 25567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063DF")]
		[Address(RVA = "0xA69DF0", Offset = "0xA68FF0", VA = "0x180A69DF0")]
		public ObjectListFieldUI()
		{
		}

		// Token: 0x04004602 RID: 17922
		[Token(Token = "0x4004602")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public string FieldText;

		// Token: 0x04004603 RID: 17923
		[Token(Token = "0x4004603")]
		[FieldOffset(Offset = "0x30")]
		public string InstructionText;

		// Token: 0x04004604 RID: 17924
		[Token(Token = "0x4004604")]
		[FieldOffset(Offset = "0x38")]
		public string ExtendedInstructionText;

		// Token: 0x04004605 RID: 17925
		[Token(Token = "0x4004605")]
		[FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI FieldLabel;

		// Token: 0x04004606 RID: 17926
		[Token(Token = "0x4004606")]
		[FieldOffset(Offset = "0x48")]
		public GameObject NoneSelected;

		// Token: 0x04004607 RID: 17927
		[Token(Token = "0x4004607")]
		[FieldOffset(Offset = "0x50")]
		public GameObject MultipleSelected;

		// Token: 0x04004608 RID: 17928
		[Token(Token = "0x4004608")]
		[FieldOffset(Offset = "0x58")]
		public RectTransform[] Entries;

		// Token: 0x04004609 RID: 17929
		[Token(Token = "0x4004609")]
		[FieldOffset(Offset = "0x60")]
		public Button Button;

		// Token: 0x0400460A RID: 17930
		[Token(Token = "0x400460A")]
		[FieldOffset(Offset = "0x68")]
		public GameObject EditIcon;

		// Token: 0x0400460B RID: 17931
		[Token(Token = "0x400460B")]
		[FieldOffset(Offset = "0x70")]
		public GameObject NoMultiEdit;
	}
}
