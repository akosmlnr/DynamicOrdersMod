using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A1E RID: 2590
	[Token(Token = "0x2000A1E")]
	[CreateAssetMenu(fileName = "ColorFont", menuName = "ScriptableObjects/Fonts/ColorFont", order = 1)]
	public class ColorFont : ScriptableObject
	{
		// Token: 0x060049D7 RID: 18903 RVA: 0x00014118 File Offset: 0x00012318
		[Token(Token = "0x60049D7")]
		[Address(RVA = "0x8F4070", Offset = "0x8F3270", VA = "0x1808F4070")]
		public Color GetColour(string name)
		{
			return default(Color);
		}

		// Token: 0x060049D8 RID: 18904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049D8")]
		[Address(RVA = "0x8F4170", Offset = "0x8F3370", VA = "0x1808F4170")]
		public ColorFont()
		{
		}

		// Token: 0x04003427 RID: 13351
		[Token(Token = "0x4003427")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<ColorFont.ColorFontItem> ColorFontItems;

		// Token: 0x02000A1F RID: 2591
		[Token(Token = "0x2000A1F")]
		[Serializable]
		public class ColorFontItem
		{
			// Token: 0x060049D9 RID: 18905 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60049D9")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public ColorFontItem()
			{
			}

			// Token: 0x04003428 RID: 13352
			[Token(Token = "0x4003428")]
			[FieldOffset(Offset = "0x10")]
			public string Name;

			// Token: 0x04003429 RID: 13353
			[Token(Token = "0x4003429")]
			[FieldOffset(Offset = "0x18")]
			public Color Colour;
		}
	}
}
