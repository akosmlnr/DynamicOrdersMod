using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Cartel
{
	// Token: 0x020007A0 RID: 1952
	[Token(Token = "0x20007A0")]
	[Serializable]
	public class CartelGoonAppearance
	{
		// Token: 0x06003435 RID: 13365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003435")]
		[Address(RVA = "0x794760", Offset = "0x793960", VA = "0x180794760")]
		public CartelGoonAppearance(bool isMale, int baseAppearanceIndex, Color skinColor, Color hairColor, int clothingIndex, int voiceIndex)
		{
		}

		// Token: 0x06003436 RID: 13366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003436")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public CartelGoonAppearance()
		{
		}

		// Token: 0x0400261C RID: 9756
		[Token(Token = "0x400261C")]
		[FieldOffset(Offset = "0x10")]
		public bool IsMale;

		// Token: 0x0400261D RID: 9757
		[Token(Token = "0x400261D")]
		[FieldOffset(Offset = "0x14")]
		public int BaseAppearanceIndex;

		// Token: 0x0400261E RID: 9758
		[Token(Token = "0x400261E")]
		[FieldOffset(Offset = "0x18")]
		public Color SkinColor;

		// Token: 0x0400261F RID: 9759
		[Token(Token = "0x400261F")]
		[FieldOffset(Offset = "0x28")]
		public Color HairColor;

		// Token: 0x04002620 RID: 9760
		[Token(Token = "0x4002620")]
		[FieldOffset(Offset = "0x38")]
		public int ClothingIndex;

		// Token: 0x04002621 RID: 9761
		[Token(Token = "0x4002621")]
		[FieldOffset(Offset = "0x3C")]
		public int VoiceIndex;
	}
}
