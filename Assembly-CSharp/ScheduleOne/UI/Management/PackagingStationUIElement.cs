using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000DA9 RID: 3497
	[Token(Token = "0x2000DA9")]
	public class PackagingStationUIElement : WorldspaceUIElement
	{
		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x060064C9 RID: 25801 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060064CA RID: 25802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E61")]
		public PackagingStation AssignedStation
		{
			[Token(Token = "0x60064C9")]
			[Address(RVA = "0x442C10", Offset = "0x441E10", VA = "0x180442C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064CA")]
			[Address(RVA = "0x497920", Offset = "0x496B20", VA = "0x180497920")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060064CB RID: 25803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064CB")]
		[Address(RVA = "0xA7EDA0", Offset = "0xA7DFA0", VA = "0x180A7EDA0")]
		public void Initialize(PackagingStation pack)
		{
		}

		// Token: 0x060064CC RID: 25804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064CC")]
		[Address(RVA = "0xA7EE80", Offset = "0xA7E080", VA = "0x180A7EE80", Slot = "10")]
		protected virtual void RefreshUI()
		{
		}

		// Token: 0x060064CD RID: 25805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064CD")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public PackagingStationUIElement()
		{
		}
	}
}
