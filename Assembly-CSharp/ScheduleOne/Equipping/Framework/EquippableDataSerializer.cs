using System;
using FishNet.Serializing;
using Il2CppDummyDll;
using ScheduleOne.Core.Equipping.Framework;

namespace ScheduleOne.Equipping.Framework
{
	// Token: 0x0200096C RID: 2412
	[Token(Token = "0x200096C")]
	public static class EquippableDataSerializer
	{
		// Token: 0x06004082 RID: 16514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004082")]
		[Address(RVA = "0x8506D0", Offset = "0x84F8D0", VA = "0x1808506D0")]
		public static void WriteEquippableData(this Writer writer, EquippableData value)
		{
		}

		// Token: 0x06004083 RID: 16515 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004083")]
		[Address(RVA = "0x8505C0", Offset = "0x84F7C0", VA = "0x1808505C0")]
		public static EquippableData ReadEquippableData(this Reader reader)
		{
			return null;
		}
	}
}
