using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000DA3 RID: 3491
	[Token(Token = "0x2000DA3")]
	public class CleanerUIElement : WorldspaceUIElement
	{
		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x060064AB RID: 25771 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060064AC RID: 25772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E5B")]
		public Cleaner AssignedCleaner
		{
			[Token(Token = "0x60064AB")]
			[Address(RVA = "0x497910", Offset = "0x496B10", VA = "0x180497910")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064AC")]
			[Address(RVA = "0x497930", Offset = "0x496B30", VA = "0x180497930")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060064AD RID: 25773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064AD")]
		[Address(RVA = "0xA70E30", Offset = "0xA70030", VA = "0x180A70E30")]
		public void Initialize(Cleaner cleaner)
		{
		}

		// Token: 0x060064AE RID: 25774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064AE")]
		[Address(RVA = "0xA70F60", Offset = "0xA70160", VA = "0x180A70F60", Slot = "10")]
		protected virtual void RefreshUI()
		{
		}

		// Token: 0x060064AF RID: 25775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064AF")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public CleanerUIElement()
		{
		}

		// Token: 0x040046A1 RID: 18081
		[Token(Token = "0x40046A1")]
		[FieldOffset(Offset = "0x50")]
		[Header("References")]
		public Image[] StationsIcons;
	}
}
