using System;
using System.Windows.Forms;
using Il2CppDummyDll;

namespace SFB
{
	// Token: 0x0200016E RID: 366
	[Token(Token = "0x200016E")]
	public class WindowWrapper : IWin32Window
	{
		// Token: 0x060006AA RID: 1706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x7C3450", Offset = "0x7C2650", VA = "0x1807C3450")]
		public WindowWrapper(IntPtr handle)
		{
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x00004F20 File Offset: 0x00003120
		[Token(Token = "0x1700014A")]
		public IntPtr Handle
		{
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x43FFF0", Offset = "0x43F1F0", VA = "0x18043FFF0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0400075F RID: 1887
		[Token(Token = "0x400075F")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr _hwnd;
	}
}
