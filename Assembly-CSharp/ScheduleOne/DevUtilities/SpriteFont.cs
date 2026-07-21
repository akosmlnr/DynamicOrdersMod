using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A24 RID: 2596
	[Token(Token = "0x2000A24")]
	[CreateAssetMenu(fileName = "SpriteFont", menuName = "ScriptableObjects/Fonts/SpriteFont")]
	public class SpriteFont : ScriptableObject
	{
		// Token: 0x060049E1 RID: 18913 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60049E1")]
		[Address(RVA = "0x9125B0", Offset = "0x9117B0", VA = "0x1809125B0")]
		public Sprite GetSprite(string name)
		{
			return null;
		}

		// Token: 0x060049E2 RID: 18914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049E2")]
		[Address(RVA = "0x9126B0", Offset = "0x9118B0", VA = "0x1809126B0")]
		public SpriteFont()
		{
		}

		// Token: 0x04003430 RID: 13360
		[Token(Token = "0x4003430")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<SpriteFont.SpriteFontItem> SpriteFontItems;

		// Token: 0x02000A25 RID: 2597
		[Token(Token = "0x2000A25")]
		[Serializable]
		public class SpriteFontItem
		{
			// Token: 0x060049E3 RID: 18915 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60049E3")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public SpriteFontItem()
			{
			}

			// Token: 0x04003431 RID: 13361
			[Token(Token = "0x4003431")]
			[FieldOffset(Offset = "0x10")]
			public string Name;

			// Token: 0x04003432 RID: 13362
			[Token(Token = "0x4003432")]
			[FieldOffset(Offset = "0x18")]
			public Sprite Sprite;
		}
	}
}
