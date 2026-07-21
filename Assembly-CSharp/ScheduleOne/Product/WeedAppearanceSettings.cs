using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x02000942 RID: 2370
	[Token(Token = "0x2000942")]
	[Serializable]
	public class WeedAppearanceSettings
	{
		// Token: 0x06003F8E RID: 16270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F8E")]
		[Address(RVA = "0x86ABD0", Offset = "0x869DD0", VA = "0x18086ABD0")]
		public WeedAppearanceSettings(Color32 mainColor, Color32 secondaryColor, Color32 leafColor, Color32 stemColor)
		{
		}

		// Token: 0x06003F8F RID: 16271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F8F")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public WeedAppearanceSettings()
		{
		}

		// Token: 0x06003F90 RID: 16272 RVA: 0x000121C8 File Offset: 0x000103C8
		[Token(Token = "0x6003F90")]
		[Address(RVA = "0x86A9B0", Offset = "0x869BB0", VA = "0x18086A9B0")]
		public bool IsUnintialized()
		{
			return default(bool);
		}

		// Token: 0x04002E34 RID: 11828
		[Token(Token = "0x4002E34")]
		[FieldOffset(Offset = "0x10")]
		public Color32 MainColor;

		// Token: 0x04002E35 RID: 11829
		[Token(Token = "0x4002E35")]
		[FieldOffset(Offset = "0x14")]
		public Color32 SecondaryColor;

		// Token: 0x04002E36 RID: 11830
		[Token(Token = "0x4002E36")]
		[FieldOffset(Offset = "0x18")]
		public Color32 LeafColor;

		// Token: 0x04002E37 RID: 11831
		[Token(Token = "0x4002E37")]
		[FieldOffset(Offset = "0x1C")]
		public Color32 StemColor;

		// Token: 0x02000943 RID: 2371
		[Token(Token = "0x2000943")]
		public enum EWeedAppearanceType
		{
			// Token: 0x04002E39 RID: 11833
			[Token(Token = "0x4002E39")]
			Main,
			// Token: 0x04002E3A RID: 11834
			[Token(Token = "0x4002E3A")]
			Secondary,
			// Token: 0x04002E3B RID: 11835
			[Token(Token = "0x4002E3B")]
			Leaf,
			// Token: 0x04002E3C RID: 11836
			[Token(Token = "0x4002E3C")]
			Stem
		}
	}
}
