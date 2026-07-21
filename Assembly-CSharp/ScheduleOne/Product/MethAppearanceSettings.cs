using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x0200090A RID: 2314
	[Token(Token = "0x200090A")]
	[Serializable]
	public class MethAppearanceSettings
	{
		// Token: 0x06003DD2 RID: 15826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DD2")]
		[Address(RVA = "0x82AC40", Offset = "0x829E40", VA = "0x18082AC40")]
		public MethAppearanceSettings(Color32 mainColor, Color32 secondaryColor)
		{
		}

		// Token: 0x06003DD3 RID: 15827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DD3")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public MethAppearanceSettings()
		{
		}

		// Token: 0x06003DD4 RID: 15828 RVA: 0x00011B98 File Offset: 0x0000FD98
		[Token(Token = "0x6003DD4")]
		[Address(RVA = "0x82AB20", Offset = "0x829D20", VA = "0x18082AB20")]
		public bool IsUnintialized()
		{
			return default(bool);
		}

		// Token: 0x04002D5B RID: 11611
		[Token(Token = "0x4002D5B")]
		[FieldOffset(Offset = "0x10")]
		public Color32 MainColor;

		// Token: 0x04002D5C RID: 11612
		[Token(Token = "0x4002D5C")]
		[FieldOffset(Offset = "0x14")]
		public Color32 SecondaryColor;
	}
}
