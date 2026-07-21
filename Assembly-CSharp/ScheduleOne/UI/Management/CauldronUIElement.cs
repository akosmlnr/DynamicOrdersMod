using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000DA0 RID: 3488
	[Token(Token = "0x2000DA0")]
	public class CauldronUIElement : WorldspaceUIElement
	{
		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x0600649C RID: 25756 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600649D RID: 25757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E58")]
		public Cauldron AssignedCauldron
		{
			[Token(Token = "0x600649C")]
			[Address(RVA = "0x442C10", Offset = "0x441E10", VA = "0x180442C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600649D")]
			[Address(RVA = "0x497920", Offset = "0x496B20", VA = "0x180497920")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600649E RID: 25758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600649E")]
		[Address(RVA = "0xA70680", Offset = "0xA6F880", VA = "0x180A70680")]
		public void Initialize(Cauldron cauldron)
		{
		}

		// Token: 0x0600649F RID: 25759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600649F")]
		[Address(RVA = "0xA70760", Offset = "0xA6F960", VA = "0x180A70760", Slot = "10")]
		protected virtual void RefreshUI()
		{
		}

		// Token: 0x060064A0 RID: 25760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064A0")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public CauldronUIElement()
		{
		}
	}
}
