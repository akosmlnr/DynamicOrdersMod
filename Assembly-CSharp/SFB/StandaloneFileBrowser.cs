using System;
using Il2CppDummyDll;

namespace SFB
{
	// Token: 0x0200016D RID: 365
	[Token(Token = "0x200016D")]
	public class StandaloneFileBrowser
	{
		// Token: 0x0600069F RID: 1695 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600069F")]
		[Address(RVA = "0x7B8E60", Offset = "0x7B8060", VA = "0x1807B8E60")]
		public static string[] OpenFilePanel(string title, string directory, string extension, bool multiselect)
		{
			return null;
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x7B90A0", Offset = "0x7B82A0", VA = "0x1807B90A0")]
		public static string[] OpenFilePanel(string title, string directory, ExtensionFilter[] extensions, bool multiselect)
		{
			return null;
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x7B8C10", Offset = "0x7B7E10", VA = "0x1807B8C10")]
		public static void OpenFilePanelAsync(string title, string directory, string extension, bool multiselect, Action<string[]> cb)
		{
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x7B8AE0", Offset = "0x7B7CE0", VA = "0x1807B8AE0")]
		public static void OpenFilePanelAsync(string title, string directory, ExtensionFilter[] extensions, bool multiselect, Action<string[]> cb)
		{
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x7B92F0", Offset = "0x7B84F0", VA = "0x1807B92F0")]
		public static string[] OpenFolderPanel(string title, string directory, bool multiselect)
		{
			return null;
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x7B91C0", Offset = "0x7B83C0", VA = "0x1807B91C0")]
		public static void OpenFolderPanelAsync(string title, string directory, bool multiselect, Action<string[]> cb)
		{
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x7B98C0", Offset = "0x7B8AC0", VA = "0x1807B98C0")]
		public static string SaveFilePanel(string title, string directory, string defaultName, string extension)
		{
			return null;
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x7B9790", Offset = "0x7B8990", VA = "0x1807B9790")]
		public static string SaveFilePanel(string title, string directory, string defaultName, ExtensionFilter[] extensions)
		{
			return null;
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x7B9540", Offset = "0x7B8740", VA = "0x1807B9540")]
		public static void SaveFilePanelAsync(string title, string directory, string defaultName, string extension, Action<string> cb)
		{
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x7B9410", Offset = "0x7B8610", VA = "0x1807B9410")]
		public static void SaveFilePanelAsync(string title, string directory, string defaultName, ExtensionFilter[] extensions, Action<string> cb)
		{
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public StandaloneFileBrowser()
		{
		}

		// Token: 0x0400075E RID: 1886
		[Token(Token = "0x400075E")]
		[FieldOffset(Offset = "0x0")]
		private static IStandaloneFileBrowser _platformWrapper;
	}
}
