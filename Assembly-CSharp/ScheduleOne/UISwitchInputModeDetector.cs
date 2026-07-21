using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne
{
	// Token: 0x02000239 RID: 569
	[Token(Token = "0x2000239")]
	public class UISwitchInputModeDetector : MonoBehaviour
	{
		// Token: 0x06000CD5 RID: 3285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CD5")]
		[Address(RVA = "0xAE02D0", Offset = "0xADF4D0", VA = "0x180AE02D0")]
		private void Start()
		{
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CD6")]
		[Address(RVA = "0xAE0280", Offset = "0xADF480", VA = "0x180AE0280")]
		private void OnControlsChanged(GameInput.InputDeviceType type)
		{
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CD7")]
		[Address(RVA = "0xAE0480", Offset = "0xADF680", VA = "0x180AE0480")]
		private void SwitchMode(GameInput.InputDeviceType type)
		{
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CD8")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public UISwitchInputModeDetector()
		{
		}

		// Token: 0x04000CCA RID: 3274
		[Token(Token = "0x4000CCA")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent OnInputModeChanged;

		// Token: 0x04000CCB RID: 3275
		[Token(Token = "0x4000CCB")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent OnInputModeChangedToController;

		// Token: 0x04000CCC RID: 3276
		[Token(Token = "0x4000CCC")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent OnInputModeChangedToMouse;
	}
}
