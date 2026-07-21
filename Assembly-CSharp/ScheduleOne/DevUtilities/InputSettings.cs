using System;
using Il2CppDummyDll;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A2F RID: 2607
	[Token(Token = "0x2000A2F")]
	[Serializable]
	public class InputSettings
	{
		// Token: 0x060049ED RID: 18925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049ED")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public InputSettings()
		{
		}

		// Token: 0x0400345B RID: 13403
		[Token(Token = "0x400345B")]
		[FieldOffset(Offset = "0x10")]
		public float MouseSensitivity;

		// Token: 0x0400345C RID: 13404
		[Token(Token = "0x400345C")]
		[FieldOffset(Offset = "0x14")]
		public bool InvertMouse;

		// Token: 0x0400345D RID: 13405
		[Token(Token = "0x400345D")]
		[FieldOffset(Offset = "0x18")]
		public InputSettings.EActionMode SprintMode;

		// Token: 0x0400345E RID: 13406
		[Token(Token = "0x400345E")]
		[FieldOffset(Offset = "0x20")]
		public string BindingOverrides;

		// Token: 0x02000A30 RID: 2608
		[Token(Token = "0x2000A30")]
		public enum EActionMode
		{
			// Token: 0x04003460 RID: 13408
			[Token(Token = "0x4003460")]
			Press,
			// Token: 0x04003461 RID: 13409
			[Token(Token = "0x4003461")]
			Hold
		}
	}
}
