using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B5C RID: 2908
	[Token(Token = "0x2000B5C")]
	[Serializable]
	public class EffectState
	{
		// Token: 0x0600570E RID: 22286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600570E")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public EffectState()
		{
		}

		// Token: 0x04003A24 RID: 14884
		[Token(Token = "0x4003A24")]
		[FieldOffset(Offset = "0x10")]
		[Header("Controller Settings")]
		public EffectController controller;

		// Token: 0x04003A25 RID: 14885
		[Token(Token = "0x4003A25")]
		[FieldOffset(Offset = "0x18")]
		[Header("Effect Settings")]
		public List<EffectSettings> ActiveSettings;

		// Token: 0x04003A26 RID: 14886
		[Token(Token = "0x4003A26")]
		[FieldOffset(Offset = "0x20")]
		[Header("Audio Settings")]
		public List<AudioSettings> AudioSettings;
	}
}
