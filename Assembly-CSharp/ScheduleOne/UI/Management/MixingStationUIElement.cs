using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000DA6 RID: 3494
	[Token(Token = "0x2000DA6")]
	public class MixingStationUIElement : WorldspaceUIElement
	{
		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x060064BA RID: 25786 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060064BB RID: 25787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E5E")]
		public MixingStation AssignedStation
		{
			[Token(Token = "0x60064BA")]
			[Address(RVA = "0x442C10", Offset = "0x441E10", VA = "0x180442C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064BB")]
			[Address(RVA = "0x497920", Offset = "0x496B20", VA = "0x180497920")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060064BC RID: 25788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064BC")]
		[Address(RVA = "0xA7B360", Offset = "0xA7A560", VA = "0x180A7B360")]
		public void Initialize(MixingStation station)
		{
		}

		// Token: 0x060064BD RID: 25789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064BD")]
		[Address(RVA = "0xA7B440", Offset = "0xA7A640", VA = "0x180A7B440", Slot = "10")]
		protected virtual void RefreshUI()
		{
		}

		// Token: 0x060064BE RID: 25790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064BE")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public MixingStationUIElement()
		{
		}
	}
}
