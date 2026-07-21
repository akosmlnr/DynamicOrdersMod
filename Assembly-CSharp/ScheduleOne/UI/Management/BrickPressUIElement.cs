using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D9F RID: 3487
	[Token(Token = "0x2000D9F")]
	public class BrickPressUIElement : WorldspaceUIElement
	{
		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06006497 RID: 25751 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06006498 RID: 25752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E57")]
		public BrickPress AssignedPress
		{
			[Token(Token = "0x6006497")]
			[Address(RVA = "0x442C10", Offset = "0x441E10", VA = "0x180442C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006498")]
			[Address(RVA = "0x497920", Offset = "0x496B20", VA = "0x180497920")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06006499 RID: 25753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006499")]
		[Address(RVA = "0xA704A0", Offset = "0xA6F6A0", VA = "0x180A704A0")]
		public void Initialize(BrickPress press)
		{
		}

		// Token: 0x0600649A RID: 25754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600649A")]
		[Address(RVA = "0xA70580", Offset = "0xA6F780", VA = "0x180A70580", Slot = "10")]
		protected virtual void RefreshUI()
		{
		}

		// Token: 0x0600649B RID: 25755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600649B")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public BrickPressUIElement()
		{
		}
	}
}
