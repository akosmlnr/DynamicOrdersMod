using System;
using Il2CppDummyDll;

namespace SFB
{
	// Token: 0x0200016B RID: 363
	[Token(Token = "0x200016B")]
	public interface IStandaloneFileBrowser
	{
		// Token: 0x06000697 RID: 1687
		[Token(Token = "0x6000697")]
		string[] OpenFilePanel(string title, string directory, ExtensionFilter[] extensions, bool multiselect);

		// Token: 0x06000698 RID: 1688
		[Token(Token = "0x6000698")]
		string[] OpenFolderPanel(string title, string directory, bool multiselect);

		// Token: 0x06000699 RID: 1689
		[Token(Token = "0x6000699")]
		string SaveFilePanel(string title, string directory, string defaultName, ExtensionFilter[] extensions);

		// Token: 0x0600069A RID: 1690
		[Token(Token = "0x600069A")]
		void OpenFilePanelAsync(string title, string directory, ExtensionFilter[] extensions, bool multiselect, Action<string[]> cb);

		// Token: 0x0600069B RID: 1691
		[Token(Token = "0x600069B")]
		void OpenFolderPanelAsync(string title, string directory, bool multiselect, Action<string[]> cb);

		// Token: 0x0600069C RID: 1692
		[Token(Token = "0x600069C")]
		void SaveFilePanelAsync(string title, string directory, string defaultName, ExtensionFilter[] extensions, Action<string> cb);
	}
}
