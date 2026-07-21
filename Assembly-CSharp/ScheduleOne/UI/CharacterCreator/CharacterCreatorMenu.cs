using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.CharacterCreator
{
	// Token: 0x02000DE2 RID: 3554
	[Token(Token = "0x2000DE2")]
	public class CharacterCreatorMenu : MonoBehaviour
	{
		// Token: 0x060065FE RID: 26110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065FE")]
		[Address(RVA = "0xA8C580", Offset = "0xA8B780", VA = "0x180A8C580")]
		public void Start()
		{
		}

		// Token: 0x060065FF RID: 26111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065FF")]
		[Address(RVA = "0xA8C460", Offset = "0xA8B660", VA = "0x180A8C460")]
		public void OpenWindow(int index)
		{
		}

		// Token: 0x06006600 RID: 26112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006600")]
		[Address(RVA = "0xA8C440", Offset = "0xA8B640", VA = "0x180A8C440")]
		public void Back()
		{
		}

		// Token: 0x06006601 RID: 26113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006601")]
		[Address(RVA = "0xA8C450", Offset = "0xA8B650", VA = "0x180A8C450")]
		public void Next()
		{
		}

		// Token: 0x06006602 RID: 26114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006602")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public CharacterCreatorMenu()
		{
		}

		// Token: 0x040047DB RID: 18395
		[Token(Token = "0x40047DB")]
		[FieldOffset(Offset = "0x20")]
		public CharacterCreatorMenu.Window[] Windows;

		// Token: 0x040047DC RID: 18396
		[Token(Token = "0x40047DC")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public TextMeshProUGUI CategoryLabel;

		// Token: 0x040047DD RID: 18397
		[Token(Token = "0x40047DD")]
		[FieldOffset(Offset = "0x30")]
		public Button BackButton;

		// Token: 0x040047DE RID: 18398
		[Token(Token = "0x40047DE")]
		[FieldOffset(Offset = "0x38")]
		public Button NextButton;

		// Token: 0x040047DF RID: 18399
		[Token(Token = "0x40047DF")]
		[FieldOffset(Offset = "0x40")]
		private int openWindowIndex;

		// Token: 0x040047E0 RID: 18400
		[Token(Token = "0x40047E0")]
		[FieldOffset(Offset = "0x48")]
		private CharacterCreatorMenu.Window openWindow;

		// Token: 0x02000DE3 RID: 3555
		[Token(Token = "0x2000DE3")]
		[Serializable]
		public class Window
		{
			// Token: 0x06006603 RID: 26115 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006603")]
			[Address(RVA = "0xA9FCB0", Offset = "0xA9EEB0", VA = "0x180A9FCB0")]
			public void Open()
			{
			}

			// Token: 0x06006604 RID: 26116 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006604")]
			[Address(RVA = "0xA9FC80", Offset = "0xA9EE80", VA = "0x180A9FC80")]
			public void Close()
			{
			}

			// Token: 0x06006605 RID: 26117 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006605")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public Window()
			{
			}

			// Token: 0x040047E1 RID: 18401
			[Token(Token = "0x40047E1")]
			[FieldOffset(Offset = "0x10")]
			public string Name;

			// Token: 0x040047E2 RID: 18402
			[Token(Token = "0x40047E2")]
			[FieldOffset(Offset = "0x18")]
			public RectTransform Container;
		}
	}
}
