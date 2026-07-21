using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000DA5 RID: 3493
	[Token(Token = "0x2000DA5")]
	public class LabOvenUIElement : WorldspaceUIElement
	{
		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x060064B5 RID: 25781 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060064B6 RID: 25782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E5D")]
		public LabOven AssignedOven
		{
			[Token(Token = "0x60064B5")]
			[Address(RVA = "0x442C10", Offset = "0x441E10", VA = "0x180442C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064B6")]
			[Address(RVA = "0x497920", Offset = "0x496B20", VA = "0x180497920")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060064B7 RID: 25783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064B7")]
		[Address(RVA = "0xA7A050", Offset = "0xA79250", VA = "0x180A7A050")]
		public void Initialize(LabOven oven)
		{
		}

		// Token: 0x060064B8 RID: 25784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064B8")]
		[Address(RVA = "0xA7A130", Offset = "0xA79330", VA = "0x180A7A130", Slot = "10")]
		protected virtual void RefreshUI()
		{
		}

		// Token: 0x060064B9 RID: 25785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064B9")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public LabOvenUIElement()
		{
		}
	}
}
