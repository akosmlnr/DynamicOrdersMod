using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C4C RID: 3148
	[Token(Token = "0x2000C4C")]
	public class GenericSelectionModule : Singleton<GenericSelectionModule>
	{
		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x06005C30 RID: 23600 RVA: 0x00017508 File Offset: 0x00015708
		// (set) Token: 0x06005C31 RID: 23601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D5C")]
		public bool isOpen
		{
			[Token(Token = "0x6005C30")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005C31")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x06005C32 RID: 23602 RVA: 0x00017520 File Offset: 0x00015720
		// (set) Token: 0x06005C33 RID: 23603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D5D")]
		[HideInInspector]
		public int ChosenOptionIndex
		{
			[Token(Token = "0x6005C32")]
			[Address(RVA = "0x54A500", Offset = "0x549700", VA = "0x18054A500")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005C33")]
			[Address(RVA = "0x9D0640", Offset = "0x9CF840", VA = "0x1809D0640")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005C34 RID: 23604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C34")]
		[Address(RVA = "0x9D0010", Offset = "0x9CF210", VA = "0x1809D0010", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005C35 RID: 23605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C35")]
		[Address(RVA = "0x9D0550", Offset = "0x9CF750", VA = "0x1809D0550", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06005C36 RID: 23606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C36")]
		[Address(RVA = "0x9D01B0", Offset = "0x9CF3B0", VA = "0x1809D01B0")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06005C37 RID: 23607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C37")]
		[Address(RVA = "0x9D0260", Offset = "0x9CF460", VA = "0x1809D0260")]
		public void Open(string title, List<string> options)
		{
		}

		// Token: 0x06005C38 RID: 23608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C38")]
		[Address(RVA = "0x9D0170", Offset = "0x9CF370", VA = "0x1809D0170")]
		public void Close()
		{
		}

		// Token: 0x06005C39 RID: 23609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C39")]
		[Address(RVA = "0x9D0070", Offset = "0x9CF270", VA = "0x1809D0070")]
		public void Cancel()
		{
		}

		// Token: 0x06005C3A RID: 23610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C3A")]
		[Address(RVA = "0x9D00B0", Offset = "0x9CF2B0", VA = "0x1809D00B0")]
		private void ClearOptions()
		{
		}

		// Token: 0x06005C3B RID: 23611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C3B")]
		[Address(RVA = "0x9D0220", Offset = "0x9CF420", VA = "0x1809D0220")]
		private void ListOptionClicked(int index)
		{
		}

		// Token: 0x06005C3C RID: 23612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C3C")]
		[Address(RVA = "0x9D0600", Offset = "0x9CF800", VA = "0x1809D0600")]
		public GenericSelectionModule()
		{
		}

		// Token: 0x04003E7B RID: 15995
		[Token(Token = "0x4003E7B")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas canvas;

		// Token: 0x04003E7C RID: 15996
		[Token(Token = "0x4003E7C")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI TitleText;

		// Token: 0x04003E7D RID: 15997
		[Token(Token = "0x4003E7D")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform OptionContainer;

		// Token: 0x04003E7E RID: 15998
		[Token(Token = "0x4003E7E")]
		[FieldOffset(Offset = "0x48")]
		public Button CloseButton;

		// Token: 0x04003E7F RID: 15999
		[Token(Token = "0x4003E7F")]
		[FieldOffset(Offset = "0x50")]
		[Header("Prefabs")]
		public GameObject ListOptionPrefab;

		// Token: 0x04003E80 RID: 16000
		[Token(Token = "0x4003E80")]
		[FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public bool OptionChosen;
	}
}
