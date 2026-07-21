using System;
using Il2CppDummyDll;

namespace ScheduleOne.GameTime
{
	// Token: 0x020002FB RID: 763
	[Token(Token = "0x20002FB")]
	public class TimedCallback
	{
		// Token: 0x060011C6 RID: 4550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011C6")]
		[Address(RVA = "0xB30C70", Offset = "0xB2FE70", VA = "0x180B30C70")]
		public TimedCallback(Action callback, int durationMinutes, bool tickAtEndOfDay = true, bool tickOnTimeSkip = true)
		{
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011C7")]
		[Address(RVA = "0xB30640", Offset = "0xB2F840", VA = "0x180B30640")]
		public void Cancel()
		{
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011C8")]
		[Address(RVA = "0xB30C10", Offset = "0xB2FE10", VA = "0x180B30C10")]
		public void Reset()
		{
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011C9")]
		[Address(RVA = "0xB30BC0", Offset = "0xB2FDC0", VA = "0x180B30BC0")]
		private void OnTimeSkip(int skippedMinutes)
		{
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011CA")]
		[Address(RVA = "0xB30C20", Offset = "0xB2FE20", VA = "0x180B30C20")]
		private void Tick()
		{
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011CB")]
		[Address(RVA = "0xB30B90", Offset = "0xB2FD90", VA = "0x180B30B90")]
		private void Execute()
		{
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011CC")]
		[Address(RVA = "0xB308F0", Offset = "0xB2FAF0", VA = "0x180B308F0")]
		private void Cleanup()
		{
		}

		// Token: 0x0400106E RID: 4206
		[Token(Token = "0x400106E")]
		[FieldOffset(Offset = "0x10")]
		private int _remainingMinutes;

		// Token: 0x0400106F RID: 4207
		[Token(Token = "0x400106F")]
		[FieldOffset(Offset = "0x18")]
		private Action _callback;

		// Token: 0x04001070 RID: 4208
		[Token(Token = "0x4001070")]
		[FieldOffset(Offset = "0x20")]
		private int _initialRemainingMinutes;
	}
}
