using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000DA8 RID: 3496
	[Token(Token = "0x2000DA8")]
	public class PackagerUIElement : WorldspaceUIElement
	{
		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x060064C4 RID: 25796 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060064C5 RID: 25797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E60")]
		public Packager AssignedPackager
		{
			[Token(Token = "0x60064C4")]
			[Address(RVA = "0x497910", Offset = "0x496B10", VA = "0x180497910")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064C5")]
			[Address(RVA = "0x497930", Offset = "0x496B30", VA = "0x180497930")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060064C6 RID: 25798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064C6")]
		[Address(RVA = "0xA7E9D0", Offset = "0xA7DBD0", VA = "0x180A7E9D0")]
		public void Initialize(Packager packager)
		{
		}

		// Token: 0x060064C7 RID: 25799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064C7")]
		[Address(RVA = "0xA7EB00", Offset = "0xA7DD00", VA = "0x180A7EB00", Slot = "10")]
		protected virtual void RefreshUI()
		{
		}

		// Token: 0x060064C8 RID: 25800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064C8")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public PackagerUIElement()
		{
		}

		// Token: 0x040046AD RID: 18093
		[Token(Token = "0x40046AD")]
		[FieldOffset(Offset = "0x50")]
		[Header("References")]
		public RectTransform[] StationRects;
	}
}
