using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000CC1 RID: 3265
	[Token(Token = "0x2000CC1")]
	public class TextInputScreen : Singleton<TextInputScreen>
	{
		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x06005F4B RID: 24395 RVA: 0x00017D90 File Offset: 0x00015F90
		[Token(Token = "0x17000DD0")]
		public bool IsOpen
		{
			[Token(Token = "0x6005F4B")]
			[Address(RVA = "0x9E5500", Offset = "0x9E4700", VA = "0x1809E5500")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005F4C RID: 24396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F4C")]
		[Address(RVA = "0xA15EB0", Offset = "0xA150B0", VA = "0x180A15EB0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005F4D RID: 24397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F4D")]
		[Address(RVA = "0xA164F0", Offset = "0xA156F0", VA = "0x180A164F0")]
		public void Submit()
		{
		}

		// Token: 0x06005F4E RID: 24398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F4E")]
		[Address(RVA = "0xA15F60", Offset = "0xA15160", VA = "0x180A15F60")]
		public void Cancel()
		{
		}

		// Token: 0x06005F4F RID: 24399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F4F")]
		[Address(RVA = "0xA16500", Offset = "0xA15700", VA = "0x180A16500")]
		private void Update()
		{
		}

		// Token: 0x06005F50 RID: 24400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F50")]
		[Address(RVA = "0xA161E0", Offset = "0xA153E0", VA = "0x180A161E0")]
		public void Exit(ExitAction action)
		{
		}

		// Token: 0x06005F51 RID: 24401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F51")]
		[Address(RVA = "0xA16240", Offset = "0xA15440", VA = "0x180A16240")]
		public void Open(string header, string text, TextInputScreen.OnSubmit _onSubmit, int maxChars = 10000)
		{
		}

		// Token: 0x06005F52 RID: 24402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F52")]
		[Address(RVA = "0xA15F70", Offset = "0xA15170", VA = "0x180A15F70")]
		private void Close(bool submit)
		{
		}

		// Token: 0x06005F53 RID: 24403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F53")]
		[Address(RVA = "0xA16550", Offset = "0xA15750", VA = "0x180A16550")]
		public TextInputScreen()
		{
		}

		// Token: 0x040041A0 RID: 16800
		[Token(Token = "0x40041A0")]
		[FieldOffset(Offset = "0x28")]
		public Canvas Canvas;

		// Token: 0x040041A1 RID: 16801
		[Token(Token = "0x40041A1")]
		[FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI HeaderLabel;

		// Token: 0x040041A2 RID: 16802
		[Token(Token = "0x40041A2")]
		[FieldOffset(Offset = "0x38")]
		public TMP_InputField InputField;

		// Token: 0x040041A3 RID: 16803
		[Token(Token = "0x40041A3")]
		[FieldOffset(Offset = "0x40")]
		private TextInputScreen.OnSubmit onSubmit;

		// Token: 0x02000CC2 RID: 3266
		// (Invoke) Token: 0x06005F55 RID: 24405
		[Token(Token = "0x2000CC2")]
		public delegate void OnSubmit(string text);
	}
}
