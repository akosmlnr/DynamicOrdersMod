using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D9B RID: 3483
	[Token(Token = "0x2000D9B")]
	public class StringSetter : ClipboardScreen
	{
		// Token: 0x06006477 RID: 25719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006477")]
		[Address(RVA = "0xA83540", Offset = "0xA82740", VA = "0x180A83540")]
		private void Awake()
		{
		}

		// Token: 0x06006478 RID: 25720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006478")]
		[Address(RVA = "0xA83770", Offset = "0xA82970", VA = "0x180A83770")]
		public void Initialize(string selectionTitle, string existingValue, int characterLimit, bool allowEmpty, [Optional] Action<string> callback)
		{
		}

		// Token: 0x06006479 RID: 25721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006479")]
		[Address(RVA = "0xA83880", Offset = "0xA82A80", VA = "0x180A83880", Slot = "5")]
		public override void Open()
		{
		}

		// Token: 0x0600647A RID: 25722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600647A")]
		[Address(RVA = "0xA83650", Offset = "0xA82850", VA = "0x180A83650", Slot = "6")]
		public override void Close()
		{
		}

		// Token: 0x0600647B RID: 25723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600647B")]
		[Address(RVA = "0xA836F0", Offset = "0xA828F0", VA = "0x180A836F0")]
		private void DoneButtonPressed()
		{
		}

		// Token: 0x0600647C RID: 25724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600647C")]
		[Address(RVA = "0xA83810", Offset = "0xA82A10", VA = "0x180A83810")]
		private void OnSubmit(string value)
		{
		}

		// Token: 0x0600647D RID: 25725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600647D")]
		[Address(RVA = "0xA83940", Offset = "0xA82B40", VA = "0x180A83940")]
		public StringSetter()
		{
		}

		// Token: 0x0400467E RID: 18046
		[Token(Token = "0x400467E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("References")]
		public TextMeshProUGUI TitleLabel;

		// Token: 0x0400467F RID: 18047
		[Token(Token = "0x400467F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TMP_InputField InputField;

		// Token: 0x04004680 RID: 18048
		[Token(Token = "0x4004680")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Button DoneButton;

		// Token: 0x04004681 RID: 18049
		[Token(Token = "0x4004681")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string _existingValue;

		// Token: 0x04004682 RID: 18050
		[Token(Token = "0x4004682")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _allowEmpty;

		// Token: 0x04004683 RID: 18051
		[Token(Token = "0x4004683")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Action<string> _callback;
	}
}
