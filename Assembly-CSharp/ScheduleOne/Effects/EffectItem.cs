using System;
using Il2CppDummyDll;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B54 RID: 2900
	[Token(Token = "0x2000B54")]
	[Serializable]
	public class EffectItem
	{
		// Token: 0x060056FE RID: 22270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056FE")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public EffectItem()
		{
		}

		// Token: 0x04003A18 RID: 14872
		[Token(Token = "0x4003A18")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		// Token: 0x04003A19 RID: 14873
		[Token(Token = "0x4003A19")]
		[FieldOffset(Offset = "0x18")]
		public EffectSettingsWrapper Wrapper;
	}
}
