using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	public sealed class GetSetAttribute : PropertyAttribute
	{
		// Token: 0x06000200 RID: 512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x56E810", Offset = "0x56DA10", VA = "0x18056E810")]
		public GetSetAttribute(string name)
		{
		}

		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x10")]
		public readonly string name;

		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x18")]
		public bool dirty;
	}
}
