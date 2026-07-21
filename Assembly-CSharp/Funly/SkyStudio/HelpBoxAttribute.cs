using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001FA RID: 506
	[Token(Token = "0x20001FA")]
	public class HelpBoxAttribute : PropertyAttribute
	{
		// Token: 0x06000AEC RID: 2796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x9F7210", Offset = "0x9F6410", VA = "0x1809F7210")]
		public HelpBoxAttribute(string text, HelpBoxMessageType messageType = HelpBoxMessageType.None)
		{
		}

		// Token: 0x04000B96 RID: 2966
		[Token(Token = "0x4000B96")]
		[FieldOffset(Offset = "0x10")]
		public string text;

		// Token: 0x04000B97 RID: 2967
		[Token(Token = "0x4000B97")]
		[FieldOffset(Offset = "0x18")]
		public HelpBoxMessageType messageType;
	}
}
