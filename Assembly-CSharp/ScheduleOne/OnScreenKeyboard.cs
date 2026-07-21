using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Steamworks;

namespace ScheduleOne
{
	// Token: 0x0200020E RID: 526
	[Token(Token = "0x200020E")]
	public static class OnScreenKeyboard
	{
		// Token: 0x06000B81 RID: 2945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x9FA850", Offset = "0x9F9A50", VA = "0x1809FA850")]
		public static void Show(Action<string> onSubmit, [Optional] Action onCancel, string description = "", uint charMax = 32U, string defaultText = "")
		{
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B82")]
		[Address(RVA = "0x9FA730", Offset = "0x9F9930", VA = "0x1809FA730")]
		private static void OnGamepadTextInputDismissed(GamepadTextInputDismissed_t param)
		{
		}

		// Token: 0x04000BE0 RID: 3040
		[Token(Token = "0x4000BE0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static uint s_charLimit;

		// Token: 0x04000BE1 RID: 3041
		[Token(Token = "0x4000BE1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Action<string> s_onSubmit;

		// Token: 0x04000BE2 RID: 3042
		[Token(Token = "0x4000BE2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Action s_onCancel;

		// Token: 0x04000BE3 RID: 3043
		[Token(Token = "0x4000BE3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Callback<GamepadTextInputDismissed_t> s_onGamepadTextInputDismissed;
	}
}
