using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace SFB
{
	// Token: 0x0200016F RID: 367
	[Token(Token = "0x200016F")]
	public class StandaloneFileBrowserWindows : IStandaloneFileBrowser
	{
		// Token: 0x060006AC RID: 1708
		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x7B7ED0", Offset = "0x7B70D0", VA = "0x1807B7ED0")]
		[PreserveSig]
		private static extern IntPtr GetActiveWindow();

		// Token: 0x060006AD RID: 1709 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x7B82E0", Offset = "0x7B74E0", VA = "0x1807B82E0", Slot = "4")]
		public string[] OpenFilePanel(string title, string directory, ExtensionFilter[] extensions, bool multiselect)
		{
			return null;
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x7B8290", Offset = "0x7B7490", VA = "0x1807B8290", Slot = "7")]
		public void OpenFilePanelAsync(string title, string directory, ExtensionFilter[] extensions, bool multiselect, Action<string[]> cb)
		{
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x7B8690", Offset = "0x7B7890", VA = "0x1807B8690", Slot = "5")]
		public string[] OpenFolderPanel(string title, string directory, bool multiselect)
		{
			return null;
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x7B84D0", Offset = "0x7B76D0", VA = "0x1807B84D0", Slot = "8")]
		public void OpenFolderPanelAsync(string title, string directory, bool multiselect, Action<string[]> cb)
		{
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x7B8880", Offset = "0x7B7A80", VA = "0x1807B8880", Slot = "6")]
		public string SaveFilePanel(string title, string directory, string defaultName, ExtensionFilter[] extensions)
		{
			return null;
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x7B8830", Offset = "0x7B7A30", VA = "0x1807B8830", Slot = "9")]
		public void SaveFilePanelAsync(string title, string directory, string defaultName, ExtensionFilter[] extensions, Action<string> cb)
		{
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x7B80A0", Offset = "0x7B72A0", VA = "0x1807B80A0")]
		private static string GetFilterFromFileExtensionList(ExtensionFilter[] extensions)
		{
			return null;
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x7B7F40", Offset = "0x7B7140", VA = "0x1807B7F40")]
		private static string GetDirectoryPath(string directory)
		{
			return null;
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public StandaloneFileBrowserWindows()
		{
		}
	}
}
