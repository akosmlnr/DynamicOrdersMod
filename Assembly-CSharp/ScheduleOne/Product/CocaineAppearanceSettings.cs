using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x020008FF RID: 2303
	[Token(Token = "0x20008FF")]
	[Serializable]
	public class CocaineAppearanceSettings
	{
		// Token: 0x06003DAB RID: 15787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DAB")]
		[Address(RVA = "0x82AC40", Offset = "0x829E40", VA = "0x18082AC40")]
		public CocaineAppearanceSettings(Color32 mainColor, Color32 secondaryColor)
		{
		}

		// Token: 0x06003DAC RID: 15788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DAC")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public CocaineAppearanceSettings()
		{
		}

		// Token: 0x06003DAD RID: 15789 RVA: 0x00011B38 File Offset: 0x0000FD38
		[Token(Token = "0x6003DAD")]
		[Address(RVA = "0x82AB20", Offset = "0x829D20", VA = "0x18082AB20")]
		public bool IsUnintialized()
		{
			return default(bool);
		}

		// Token: 0x04002D33 RID: 11571
		[Token(Token = "0x4002D33")]
		[FieldOffset(Offset = "0x10")]
		public Color32 MainColor;

		// Token: 0x04002D34 RID: 11572
		[Token(Token = "0x4002D34")]
		[FieldOffset(Offset = "0x14")]
		public Color32 SecondaryColor;
	}
}
