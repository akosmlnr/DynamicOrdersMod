using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ItemIconCreator
{
	// Token: 0x02000191 RID: 401
	[Token(Token = "0x2000191")]
	public class IconCreatorCanvas : MonoBehaviour
	{
		// Token: 0x060007EE RID: 2030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x8D4BC0", Offset = "0x8D3DC0", VA = "0x1808D4BC0")]
		private void Awake()
		{
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x8D4C20", Offset = "0x8D3E20", VA = "0x1808D4C20")]
		public void SetInfo(int totalItens, int currentItem, string itemName, bool isRecording, KeyCode key)
		{
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x8D4EA0", Offset = "0x8D40A0", VA = "0x1808D4EA0")]
		public void SetTakingPicture()
		{
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public IconCreatorCanvas()
		{
		}

		// Token: 0x040008D7 RID: 2263
		[Token(Token = "0x40008D7")]
		[FieldOffset(Offset = "0x20")]
		public Text textLabel;

		// Token: 0x040008D8 RID: 2264
		[Token(Token = "0x40008D8")]
		[FieldOffset(Offset = "0x28")]
		public GameObject borders;

		// Token: 0x040008D9 RID: 2265
		[Token(Token = "0x40008D9")]
		[FieldOffset(Offset = "0x0")]
		public static IconCreatorCanvas instance;
	}
}
