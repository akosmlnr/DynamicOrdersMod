using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x0200080F RID: 2063
	[Token(Token = "0x200080F")]
	public class ACWindow : MonoBehaviour
	{
		// Token: 0x06003782 RID: 14210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003782")]
		[Address(RVA = "0x7E1520", Offset = "0x7E0720", VA = "0x1807E1520")]
		private void Start()
		{
		}

		// Token: 0x06003783 RID: 14211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003783")]
		[Address(RVA = "0x74D8E0", Offset = "0x74CAE0", VA = "0x18074D8E0")]
		public void Open()
		{
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003784")]
		[Address(RVA = "0x7E1470", Offset = "0x7E0670", VA = "0x1807E1470")]
		public void Close()
		{
		}

		// Token: 0x06003785 RID: 14213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003785")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ACWindow()
		{
		}

		// Token: 0x04002863 RID: 10339
		[Token(Token = "0x4002863")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		public string WindowTitle;

		// Token: 0x04002864 RID: 10340
		[Token(Token = "0x4002864")]
		[FieldOffset(Offset = "0x28")]
		public ACWindow Predecessor;

		// Token: 0x04002865 RID: 10341
		[Token(Token = "0x4002865")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public TextMeshProUGUI TitleText;

		// Token: 0x04002866 RID: 10342
		[Token(Token = "0x4002866")]
		[FieldOffset(Offset = "0x38")]
		public Button BackButton;
	}
}
