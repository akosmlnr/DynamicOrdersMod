using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000DA2 RID: 3490
	[Token(Token = "0x2000DA2")]
	public class ChemistUIElement : WorldspaceUIElement
	{
		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x060064A6 RID: 25766 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060064A7 RID: 25767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E5A")]
		public Chemist AssignedChemist
		{
			[Token(Token = "0x60064A6")]
			[Address(RVA = "0x497910", Offset = "0x496B10", VA = "0x180497910")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064A7")]
			[Address(RVA = "0x497930", Offset = "0x496B30", VA = "0x180497930")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060064A8 RID: 25768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064A8")]
		[Address(RVA = "0xA70860", Offset = "0xA6FA60", VA = "0x180A70860")]
		public void Initialize(Chemist chemist)
		{
		}

		// Token: 0x060064A9 RID: 25769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064A9")]
		[Address(RVA = "0xA70990", Offset = "0xA6FB90", VA = "0x180A70990", Slot = "10")]
		protected virtual void RefreshUI()
		{
		}

		// Token: 0x060064AA RID: 25770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064AA")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ChemistUIElement()
		{
		}

		// Token: 0x0400469F RID: 18079
		[Token(Token = "0x400469F")]
		[FieldOffset(Offset = "0x50")]
		[Header("References")]
		public Image[] StationsIcons;
	}
}
